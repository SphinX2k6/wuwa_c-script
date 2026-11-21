using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelGamePlay.SplineMoveTask
{
	// Token: 0x02005B8B RID: 23435
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class SplineMoveTaskController : ControllerBase
	{
		// Token: 0x060399FE RID: 236030 RVA: 0x0102FAC0 File Offset: 0x0102DCC0
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

		// Token: 0x060399FF RID: 236031 RVA: 0x0102FB50 File Offset: 0x0102DD50
		protected override bool OnInit()
		{
			if (!EventSystem.Instance.Has(EEventName.ClearWorld, new Action(this.OnClearWorld)))
			{
				EventSystem.Instance.Add(EEventName.ClearWorld, new Action(this.OnClearWorld));
			}
			return true;
		}

		// Token: 0x06039A00 RID: 236032 RVA: 0x0102FB8C File Offset: 0x0102DD8C
		protected override bool OnClear()
		{
			if (EventSystem.Instance.Has(EEventName.ClearWorld, new Action(this.OnClearWorld)))
			{
				EventSystem.Instance.Remove(EEventName.ClearWorld, new Action(this.OnClearWorld));
			}
			return true;
		}

		// Token: 0x06039A01 RID: 236033 RVA: 0x0102FBC8 File Offset: 0x0102DDC8
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

		// Token: 0x06039A02 RID: 236034 RVA: 0x0102FBE8 File Offset: 0x0102DDE8
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

		// Token: 0x06039A03 RID: 236035 RVA: 0x0102FC1C File Offset: 0x0102DE1C
		public void EndEntityTasks(long entityId)
		{
			List<SplineMoveTaskBase> entitySplineMoveTasks = this.GetEntitySplineMoveTasks(entityId);
			if (entitySplineMoveTasks == null || entitySplineMoveTasks.Count == 0)
			{
				return;
			}
			foreach (SplineMoveTaskBase splineMoveTaskBase in new List<SplineMoveTaskBase>(entitySplineMoveTasks))
			{
				splineMoveTaskBase.EndTask(false);
			}
		}

		// Token: 0x06039A04 RID: 236036 RVA: 0x0102FC84 File Offset: 0x0102DE84
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

		// Token: 0x06039A05 RID: 236037 RVA: 0x0102FDAC File Offset: 0x0102DFAC
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

		// Token: 0x06039A06 RID: 236038 RVA: 0x0102FE38 File Offset: 0x0102E038
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
			foreach (SplineMoveTaskBase splineMoveTaskBase in new List<SplineMoveTaskBase>(entitySplineMoveTasks))
			{
				splineMoveTaskBase.EndTask(false);
			}
		}

		// Token: 0x06039A07 RID: 236039 RVA: 0x0102FED4 File Offset: 0x0102E0D4
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

		// Token: 0x17006DC9 RID: 28105
		// (get) Token: 0x06039A08 RID: 236040 RVA: 0x0102FF9C File Offset: 0x0102E19C
		public static SplineMoveTaskController Instance
		{
			get
			{
				return SplineMoveTaskController._Instance;
			}
		}

		// Token: 0x06039A09 RID: 236041 RVA: 0x0102FFA3 File Offset: 0x0102E1A3
		public static SplineMoveTaskController GetOrCreateInstance()
		{
			if (SplineMoveTaskController._Instance == null)
			{
				SplineMoveTaskController.CreateInstance();
			}
			return SplineMoveTaskController._Instance;
		}

		// Token: 0x06039A0A RID: 236042 RVA: 0x0102FFB7 File Offset: 0x0102E1B7
		public static bool CreateInstance()
		{
			if (SplineMoveTaskController._Instance != null)
			{
				return true;
			}
			SplineMoveTaskController._Instance = new SplineMoveTaskController();
			return true;
		}

		// Token: 0x06039A0B RID: 236043 RVA: 0x0102FFCD File Offset: 0x0102E1CD
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06039A0C RID: 236044 RVA: 0x0102FFCF File Offset: 0x0102E1CF
		public static void ResetStaticDefaultValue()
		{
			SplineMoveTaskController._Instance = null;
		}

		// Token: 0x06039A0D RID: 236045 RVA: 0x0102FFD7 File Offset: 0x0102E1D7
		static SplineMoveTaskController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SplineMoveTaskController.CreateStaticDefaultValue), new Action(SplineMoveTaskController.ResetStaticDefaultValue));
		}

		// Token: 0x0401E6B5 RID: 124597
		private readonly Dictionary<long, List<SplineMoveTaskBase>> EntitySplineMoveTasks = new Dictionary<long, List<SplineMoveTaskBase>>();

		// Token: 0x0401E6B6 RID: 124598
		[Nullable(2)]
		private static SplineMoveTaskController _Instance;
	}
}
