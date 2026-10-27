using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DD8 RID: 7640
	[NullableContext(1)]
	[Nullable(0)]
	public class ISceneActorMusicPlantsEvent : ISceneActorEvent
	{
		// Token: 0x0600A391 RID: 41873 RVA: 0x00173500 File Offset: 0x00171700
		private ISceneActorMusicPlantsEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneActorMusicPlantsEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneActorMusicPlantsEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneActorMusicPlantsEvent_SetValue());
			}
			return result;
		}

		// Token: 0x0600A392 RID: 41874 RVA: 0x00173538 File Offset: 0x00171738
		public static ISceneActorMusicPlantsEvent Create([Nullable(2)] ISceneActorMusicPlantsEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneActorMusicPlantsEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A393 RID: 41875 RVA: 0x0017354B File Offset: 0x0017174B
		public static ISceneActorMusicPlantsEvent CreateFromSetValue([Nullable(2)] ISceneActorMusicPlantsEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneActorMusicPlantsEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A394 RID: 41876 RVA: 0x0017355E File Offset: 0x0017175E
		public new ISceneActorMusicPlantsEvent_SetValue ToSetValue()
		{
			return new ISceneActorMusicPlantsEvent_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700325B RID: 12891
		// (get) Token: 0x0600A395 RID: 41877 RVA: 0x00173571 File Offset: 0x00171771
		// (set) Token: 0x0600A396 RID: 41878 RVA: 0x0017359C File Offset: 0x0017179C
		public override ESceneActorEventType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESceneActorEventType.PlayMusicPlants;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400620A RID: 25098
		[Nullable(2)]
		protected new ISceneActorMusicPlantsEvent FbInstance;

		// Token: 0x0400620B RID: 25099
		[Nullable(2)]
		protected new ISceneActorMusicPlantsEvent_SetValue PocoInterface;
	}
}
