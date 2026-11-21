using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FEF RID: 8175
	public class ISceneActorMusicLightsEvent : ISceneActorEvent
	{
		// Token: 0x0600AD9F RID: 44447 RVA: 0x00187C9C File Offset: 0x00185E9C
		private ISceneActorMusicLightsEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneActorMusicLightsEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneActorMusicLightsEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneActorMusicLightsEvent_SetValue());
			}
			return result;
		}

		// Token: 0x0600ADA0 RID: 44448 RVA: 0x00187CD4 File Offset: 0x00185ED4
		public static ISceneActorMusicLightsEvent Create([Nullable(2)] ISceneActorMusicLightsEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneActorMusicLightsEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600ADA1 RID: 44449 RVA: 0x00187CE7 File Offset: 0x00185EE7
		public static ISceneActorMusicLightsEvent CreateFromSetValue([Nullable(2)] ISceneActorMusicLightsEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneActorMusicLightsEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600ADA2 RID: 44450 RVA: 0x00187CFA File Offset: 0x00185EFA
		public new ISceneActorMusicLightsEvent_SetValue ToSetValue()
		{
			return new ISceneActorMusicLightsEvent_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170034F7 RID: 13559
		// (get) Token: 0x0600ADA3 RID: 44451 RVA: 0x00187D0D File Offset: 0x00185F0D
		// (set) Token: 0x0600ADA4 RID: 44452 RVA: 0x00187D38 File Offset: 0x00185F38
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

		// Token: 0x04006794 RID: 26516
		[Nullable(2)]
		protected new ISceneActorMusicLightsEvent FbInstance;

		// Token: 0x04006795 RID: 26517
		[Nullable(2)]
		protected new ISceneActorMusicLightsEvent_SetValue PocoInterface;
	}
}
