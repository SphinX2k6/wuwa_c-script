using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelGamePlay.SplineMoveTask
{
	// Token: 0x02006A2E RID: 27182
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class SplineMoveTaskController : ControllerBase
	{
		// Token: 0x060439B0 RID: 276912 RVA: 0x0108B290 File Offset: 0x01089490
		protected override void OnTick(float delta)
		{
			foreach (KeyValuePair<long, List<SplineMoveTaskBase>> keyValuePair in this.EntitySplineMoveTasks)
			{
				foreach (SplineMoveTaskBase splineMoveTaskBase in keyValuePair.Value)
				{
					splineMoveTaskBase.TickTask((double)delta);
				}
			}
		}

		// Token: 0x060439B1 RID: 276913 RVA: 0x0108B320 File Offset: 0x01089520
		protected override bool OnInit()
		{
			if (!EventSystem.Instance.Has(EEventName.ClearWorld, new Action(this.OnClearWorld)))
			{
				EventSystem.Instance.Add(EEventName.ClearWorld, new Action(this.OnClearWorld));
			}
			return true;
		}

		// Token: 0x060439B2 RID: 276914 RVA: 0x0108B35C File Offset: 0x0108955C
		protected override bool OnClear()
		{
			if (EventSystem.Instance.Has(EEventName.ClearWorld, new Action(this.OnClearWorld)))
			{
				EventSystem.Instance.Remove(EEventName.ClearWorld, new Action(this.OnClearWorld));
			}
			return true;
		}

		// Token: 0x060439B3 RID: 276915 RVA: 0x0108B398 File Offset: 0x01089598
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<SplineMoveTaskBase> GetEntitySplineMoveTasks(long entityId)
		{
			List<SplineMoveTaskBase> result;
			this.EntitySplineMoveTasks.TryGetValue(entityId, out result);
			return result;
		}

		// Token: 0x060439B4 RID: 276916 RVA: 0x0108B3B8 File Offset: 0x010895B8
		[NullableContext(2)]
		public SplineMoveTaskBase GetEntityCurSplineMoveTask(long entityId)
		{
			List<SplineMoveTaskBase> list;
			if (this.EntitySplineMoveTasks.TryGetValue(entityId, out list) && list != null && list.Count > 0)
			{
				return list[0];
			}
			return null;
		}

		// Token: 0x060439B5 RID: 276917 RVA: 0x0108B3EC File Offset: 0x010895EC
		public void EndEntityTasks(long entityId)
		{
			List<SplineMoveTaskBase> entitySplineMoveTasks = this.GetEntitySplineMoveTasks(entityId);
			if (entitySplineMoveTasks == null || entitySplineMoveTasks.Count == 0)
			{
				return;
			}
			foreach (SplineMoveTaskBase splineMoveTaskBase in entitySplineMoveTasks.ToList<SplineMoveTaskBase>())
			{
				splineMoveTaskBase.EndTask(false);
			}
		}

		// Token: 0x060439B6 RID: 276918 RVA: 0x0108B454 File Offset: 0x01089654
		public bool RegisterTask(SplineMoveTaskBase task)
		{
			if (!task.EntityHandle.Valid)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelPlay;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[SplineMoveTaskController] Task所属实体非valid，不允许注册";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", task.EntityHandle.Id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			List<SplineMoveTaskBase> list;
			if (!this.EntitySplineMoveTasks.TryGetValue((long)task.EntityHandle.Id, out list) || list == null)
			{
				list = new List<SplineMoveTaskBase>();
				this.EntitySplineMoveTasks[(long)task.EntityHandle.Id] = list;
			}
			else if (list.Contains(task))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.LevelPlay;
				ELogAuthor author2 = ELogAuthor.ZYL;
				string message2 = "[SplineMoveTaskController] Task已注册过，可能存在错误导致重复注册";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("EntityId", task.EntityHandle.Id);
				instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return true;
			}
			list.Add(task);
			if (task.EntityHandle != null && !EventSystem.Instance.HasWithTarget(task.EntityHandle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity)))
			{
				EventSystem.Instance.AddWithTarget(task.EntityHandle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
			}
			return true;
		}

		// Token: 0x060439B7 RID: 276919 RVA: 0x0108B57C File Offset: 0x0108977C
		public bool UnregisterTask(SplineMoveTaskBase task)
		{
			List<SplineMoveTaskBase> list;
			if (this.EntitySplineMoveTasks.TryGetValue((long)task.EntityHandle.Id, out list) && list != null)
			{
				int num = list.IndexOf(task);
				if (num != -1)
				{
					list.RemoveAt(num);
				}
			}
			if (task.EntityHandle != null && EventSystem.Instance.HasWithTarget(task.EntityHandle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity)))
			{
				EventSystem.Instance.RemoveWithTarget(task.EntityHandle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
			}
			return true;
		}

		// Token: 0x060439B8 RID: 276920 RVA: 0x0108B608 File Offset: 0x01089808
		protected void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.LevelPlay;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "[SplineMoveTaskController] 检测到移动实体被销毁，直接结束Task";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", handle.Id);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			List<SplineMoveTaskBase> entitySplineMoveTasks = this.GetEntitySplineMoveTasks((long)handle.Id);
			if (entitySplineMoveTasks == null || entitySplineMoveTasks.Count == 0)
			{
				return;
			}
			foreach (SplineMoveTaskBase splineMoveTaskBase in entitySplineMoveTasks.ToList<SplineMoveTaskBase>())
			{
				splineMoveTaskBase.EndTask(false);
			}
		}

		// Token: 0x060439B9 RID: 276921 RVA: 0x0108B6A4 File Offset: 0x010898A4
		protected void OnClearWorld()
		{
			Log.Instance.Warn(ELogModule.LevelPlay, ELogAuthor.ZYL, "[SplineMoveTaskController]检测到世界清理，结束所有Task", default(ReadOnlySpan<ValueTuple<string, object>>));
			List<SplineMoveTaskBase> list = new List<SplineMoveTaskBase>();
			foreach (KeyValuePair<long, List<SplineMoveTaskBase>> keyValuePair in this.EntitySplineMoveTasks)
			{
				List<SplineMoveTaskBase> value = keyValuePair.Value;
				if (value != null && value.Count != 0)
				{
					list.AddRange(value);
				}
			}
			foreach (SplineMoveTaskBase splineMoveTaskBase in list)
			{
				splineMoveTaskBase.EndTask(false);
			}
		}

		// Token: 0x170098E4 RID: 39140
		// (get) Token: 0x060439BA RID: 276922 RVA: 0x0108B76C File Offset: 0x0108996C
		public static SplineMoveTaskController Instance
		{
			get
			{
				return SplineMoveTaskController._Instance;
			}
		}

		// Token: 0x060439BB RID: 276923 RVA: 0x0108B773 File Offset: 0x01089973
		public static SplineMoveTaskController GetOrCreateInstance()
		{
			if (SplineMoveTaskController._Instance == null)
			{
				SplineMoveTaskController.CreateInstance();
			}
			return SplineMoveTaskController._Instance;
		}

		// Token: 0x060439BC RID: 276924 RVA: 0x0108B787 File Offset: 0x01089987
		public static bool CreateInstance()
		{
			if (SplineMoveTaskController._Instance != null)
			{
				return true;
			}
			SplineMoveTaskController._Instance = new SplineMoveTaskController();
			return true;
		}

		// Token: 0x060439BD RID: 276925 RVA: 0x0108B79D File Offset: 0x0108999D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060439BE RID: 276926 RVA: 0x0108B79F File Offset: 0x0108999F
		public static void ResetStaticDefaultValue()
		{
			SplineMoveTaskController._Instance = null;
		}

		// Token: 0x060439BF RID: 276927 RVA: 0x0108B7A7 File Offset: 0x010899A7
		static SplineMoveTaskController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SplineMoveTaskController.CreateStaticDefaultValue), new Action(SplineMoveTaskController.ResetStaticDefaultValue));
		}

		// Token: 0x040234C3 RID: 144579
		private readonly Dictionary<long, List<SplineMoveTaskBase>> EntitySplineMoveTasks = new Dictionary<long, List<SplineMoveTaskBase>>();

		// Token: 0x040234C4 RID: 144580
		[Nullable(2)]
		private static SplineMoveTaskController _Instance;
	}
}
