using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.World.Define
{
	// Token: 0x0200345D RID: 13405
	[NullableContext(1)]
	[Nullable(0)]
	public class WaitEntityPreloadTask
	{
		// Token: 0x06022344 RID: 140100 RVA: 0x009AFA40 File Offset: 0x009ADC40
		public WaitEntityPreloadTask(EntityHandle handle, Action<EWaitEntityPreloadResult> callBack)
		{
			this.Handle = handle;
			this.CallBack = callBack;
		}

		// Token: 0x06022345 RID: 140101 RVA: 0x009AFA78 File Offset: 0x009ADC78
		public unsafe void Init()
		{
			this.CreatureData = this.Handle.Entity.GetComponent<CreatureDataComponent>();
			EventSystem.Instance.Add<EntityHandle>(EEventName.PreloadEntityFinished, new Action<EntityHandle>(this.OnPreloadEntityFinished));
			EventSystem.Instance.Add<ERemoveEntityType, EntityHandle>(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
			TimerSystem.Instance.Delay(delegate(float _)
			{
				EntityHandle handle = this.Handle;
				if (handle != null && !handle.Valid)
				{
					return;
				}
				if ((this.Result & EWaitEntityPreloadResult.Finished) != EWaitEntityPreloadResult.None)
				{
					return;
				}
				this.Result |= EWaitEntityPreloadResult.Timeout;
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Entity;
				ELogAuthor author = ELogAuthor.LFJW;
				string message = "等待实体超时";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureDataId", this.CreatureData.GetCreatureDataId());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("依赖的实体", this.WaitEntityString);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("没有预加载的实体", this.GetDoNotPreloadEntityString());
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				this.DoCallback();
			}, 60000f, null, null, true, 1f);
			this.FilterEntity();
			if (this.Count != 0)
			{
				return;
			}
			this.DoCallback();
		}

		// Token: 0x170047F4 RID: 18420
		// (get) Token: 0x06022346 RID: 140102 RVA: 0x009AFB0C File Offset: 0x009ADD0C
		private int Count
		{
			get
			{
				return this.EntityIdMap.Count + this.PbDataIdMap.Count + this.CreatureDataIdMap.Count;
			}
		}

		// Token: 0x06022347 RID: 140103 RVA: 0x009AFB31 File Offset: 0x009ADD31
		public void Clear()
		{
			this.Handle = null;
			this.CreatureDataIdMap.Clear();
			this.PbDataIdMap.Clear();
			this.EntityIdMap.Clear();
			this.WaitEntityString = null;
			this.CallBack = null;
		}

		// Token: 0x06022348 RID: 140104 RVA: 0x009AFB6C File Offset: 0x009ADD6C
		private void FilterEntity()
		{
			foreach (long num in new List<long>(this.CreatureDataIdMap.Keys))
			{
				EntityHandle entity = CreatureModel.Instance.GetEntity(num);
				if (entity != null && entity.Valid && (entity.Entity.GetComponent<CreatureDataComponent>().GetPreloadFinished() || entity.IsInit))
				{
					this.CreatureDataIdMap.Remove(num);
				}
			}
			foreach (int num2 in new List<int>(this.PbDataIdMap.Keys))
			{
				EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(num2);
				if (entityByPbDataId != null && entityByPbDataId.Valid && (entityByPbDataId.Entity.GetComponent<CreatureDataComponent>().GetPreloadFinished() || entityByPbDataId.IsInit))
				{
					this.PbDataIdMap.Remove(num2);
				}
			}
			foreach (int num3 in new List<int>(this.EntityIdMap.Keys))
			{
				EntityHandle entityById = CreatureModel.Instance.GetEntityById(num3);
				if (entityById != null && entityById.Valid && (entityById.Entity.GetComponent<CreatureDataComponent>().GetPreloadFinished() || entityById.IsInit))
				{
					this.EntityIdMap.Remove(num3);
				}
			}
		}

		// Token: 0x06022349 RID: 140105 RVA: 0x009AFD28 File Offset: 0x009ADF28
		private void DoCallback()
		{
			EventSystem.Instance.Remove<EntityHandle>(EEventName.PreloadEntityFinished, new Action<EntityHandle>(this.OnPreloadEntityFinished));
			EventSystem.Instance.Remove<ERemoveEntityType, EntityHandle>(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
			this.Result |= EWaitEntityPreloadResult.Finished;
			this.CallBack(this.Result);
			this.Clear();
		}

		// Token: 0x0602234A RID: 140106 RVA: 0x009AFD94 File Offset: 0x009ADF94
		private string GetDoNotPreloadEntityString()
		{
			string text = "";
			if (this.CreatureDataIdMap.Count != 0)
			{
				foreach (KeyValuePair<long, EWaitPreloadId> keyValuePair in this.CreatureDataIdMap)
				{
					long key = keyValuePair.Key;
					string str = text;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 1);
					defaultInterpolatedStringHandler.AppendLiteral("CreatureDataId:");
					defaultInterpolatedStringHandler.AppendFormatted<long>(key);
					defaultInterpolatedStringHandler.AppendLiteral(",");
					text = str + defaultInterpolatedStringHandler.ToStringAndClear();
				}
			}
			if (this.PbDataIdMap.Count != 0)
			{
				foreach (KeyValuePair<int, EWaitPreloadId> keyValuePair2 in this.PbDataIdMap)
				{
					int key2 = keyValuePair2.Key;
					string str2 = text;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
					defaultInterpolatedStringHandler.AppendLiteral("PbDataId:");
					defaultInterpolatedStringHandler.AppendFormatted<int>(key2);
					defaultInterpolatedStringHandler.AppendLiteral(",");
					text = str2 + defaultInterpolatedStringHandler.ToStringAndClear();
				}
			}
			if (this.EntityIdMap.Count != 0)
			{
				foreach (KeyValuePair<int, EWaitPreloadId> keyValuePair3 in this.EntityIdMap)
				{
					int key3 = keyValuePair3.Key;
					string str3 = text;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
					defaultInterpolatedStringHandler.AppendLiteral("EntityId:");
					defaultInterpolatedStringHandler.AppendFormatted<int>(key3);
					defaultInterpolatedStringHandler.AppendLiteral(",");
					text = str3 + defaultInterpolatedStringHandler.ToStringAndClear();
				}
			}
			return text;
		}

		// Token: 0x0602234B RID: 140107 RVA: 0x009AFF4C File Offset: 0x009AE14C
		private void OnPreloadEntityFinished(EntityHandle handle)
		{
			if ((this.Result & EWaitEntityPreloadResult.Finished) != EWaitEntityPreloadResult.None)
			{
				return;
			}
			CreatureDataComponent component = handle.Entity.GetComponent<CreatureDataComponent>();
			long creatureDataId = component.GetCreatureDataId();
			int pbDataId = component.GetPbDataId();
			int id = handle.Id;
			bool flag = false;
			if (this.CreatureDataIdMap.ContainsKey(creatureDataId))
			{
				flag = true;
				this.CreatureDataIdMap.Remove(creatureDataId);
			}
			if (this.PbDataIdMap.ContainsKey(pbDataId))
			{
				flag = true;
				this.PbDataIdMap.Remove(pbDataId);
			}
			if (this.EntityIdMap.ContainsKey(id))
			{
				flag = true;
				this.EntityIdMap.Remove(id);
			}
			if (!flag)
			{
				return;
			}
			if (this.Count != 0)
			{
				return;
			}
			this.DoCallback();
		}

		// Token: 0x0602234C RID: 140108 RVA: 0x009AFFF0 File Offset: 0x009AE1F0
		private unsafe void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
		{
			if ((this.Result & EWaitEntityPreloadResult.Finished) != EWaitEntityPreloadResult.None)
			{
				return;
			}
			if (handle.Id == this.Handle.Id)
			{
				this.Result |= EWaitEntityPreloadResult.Cancel;
				this.DoCallback();
				return;
			}
			CreatureDataComponent component = handle.Entity.GetComponent<CreatureDataComponent>();
			long creatureDataId = component.GetCreatureDataId();
			int pbDataId = component.GetPbDataId();
			int id = handle.Id;
			bool flag = false;
			if (this.CreatureDataIdMap.ContainsKey(creatureDataId))
			{
				flag = true;
				this.CreatureDataIdMap.Remove(creatureDataId);
				if (!CreatureModel.Instance.LeavingLevel)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Entity;
					ELogAuthor author = ELogAuthor.LFJW;
					string message = "实体需要等待的实体被删了";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
					string item = "CreatureDataId";
					CreatureDataComponent creatureData = this.CreatureData;
					ptr = new ValueTuple<string, object>(item, (creatureData != null) ? new long?(creatureData.GetCreatureDataId()) : null);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("被删的实体CreatureDataId", creatureDataId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("依赖的实体列表", this.WaitEntityString);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				}
			}
			if (this.PbDataIdMap.ContainsKey(pbDataId))
			{
				flag = true;
				this.PbDataIdMap.Remove(pbDataId);
				if (!CreatureModel.Instance.LeavingLevel)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Entity;
					ELogAuthor author2 = ELogAuthor.LFJW;
					string message2 = "实体需要等待的实体被删了";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
					ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0);
					string item2 = "CreatureDataId";
					CreatureDataComponent creatureData2 = this.CreatureData;
					ptr2 = new ValueTuple<string, object>(item2, (creatureData2 != null) ? new long?(creatureData2.GetCreatureDataId()) : null);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("被删的实体PbDataId", pbDataId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("依赖的实体列表", this.WaitEntityString);
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				}
			}
			if (this.EntityIdMap.ContainsKey(id))
			{
				flag = true;
				this.EntityIdMap.Remove(id);
				if (!CreatureModel.Instance.LeavingLevel)
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.Entity;
					ELogAuthor author3 = ELogAuthor.LFJW;
					string message3 = "实体需要等待的实体被删了";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
					ref ValueTuple<string, object> ptr3 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0);
					string item3 = "CreatureDataId";
					CreatureDataComponent creatureData3 = this.CreatureData;
					ptr3 = new ValueTuple<string, object>(item3, (creatureData3 != null) ? new long?(creatureData3.GetCreatureDataId()) : null);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("被删的实体EntityId", id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("依赖的实体列表", this.WaitEntityString);
					instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
				}
			}
			if (!flag)
			{
				return;
			}
			this.Result |= EWaitEntityPreloadResult.Fail;
			if (this.Count != 0)
			{
				return;
			}
			this.DoCallback();
		}

		// Token: 0x0602234D RID: 140109 RVA: 0x009B02C7 File Offset: 0x009AE4C7
		public static WaitEntityPreloadTask Create(EntityHandle handle, Action<EWaitEntityPreloadResult> callBack)
		{
			WaitEntityPreloadTask waitEntityPreloadTask = new WaitEntityPreloadTask(handle, callBack);
			waitEntityPreloadTask.Init();
			return waitEntityPreloadTask;
		}

		// Token: 0x04012D54 RID: 77140
		[Nullable(2)]
		private EntityHandle Handle;

		// Token: 0x04012D55 RID: 77141
		[Nullable(2)]
		private Action<EWaitEntityPreloadResult> CallBack;

		// Token: 0x04012D56 RID: 77142
		private EWaitEntityPreloadResult Result;

		// Token: 0x04012D57 RID: 77143
		[Nullable(2)]
		private CreatureDataComponent CreatureData;

		// Token: 0x04012D58 RID: 77144
		private readonly Dictionary<long, EWaitPreloadId> CreatureDataIdMap = new Dictionary<long, EWaitPreloadId>();

		// Token: 0x04012D59 RID: 77145
		private readonly Dictionary<int, EWaitPreloadId> PbDataIdMap = new Dictionary<int, EWaitPreloadId>();

		// Token: 0x04012D5A RID: 77146
		private readonly Dictionary<int, EWaitPreloadId> EntityIdMap = new Dictionary<int, EWaitPreloadId>();

		// Token: 0x04012D5B RID: 77147
		[Nullable(2)]
		private string WaitEntityString;

		// Token: 0x04012D5C RID: 77148
		private const int WAIT_TIME = 60000;
	}
}
