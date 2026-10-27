using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DD6 RID: 7638
	[NullableContext(1)]
	[Nullable(0)]
	public class ISceneActorMusicLightsEvent : ISceneActorEvent
	{
		// Token: 0x0600A389 RID: 41865 RVA: 0x00173444 File Offset: 0x00171644
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

		// Token: 0x0600A38A RID: 41866 RVA: 0x0017347C File Offset: 0x0017167C
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

		// Token: 0x0600A38B RID: 41867 RVA: 0x0017348F File Offset: 0x0017168F
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

		// Token: 0x0600A38C RID: 41868 RVA: 0x001734A2 File Offset: 0x001716A2
		public new ISceneActorMusicLightsEvent_SetValue ToSetValue()
		{
			return new ISceneActorMusicLightsEvent_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700325A RID: 12890
		// (get) Token: 0x0600A38D RID: 41869 RVA: 0x001734B5 File Offset: 0x001716B5
		// (set) Token: 0x0600A38E RID: 41870 RVA: 0x001734E0 File Offset: 0x001716E0
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

		// Token: 0x04006207 RID: 25095
		[Nullable(2)]
		protected new ISceneActorMusicLightsEvent FbInstance;

		// Token: 0x04006208 RID: 25096
		[Nullable(2)]
		protected new ISceneActorMusicLightsEvent_SetValue PocoInterface;
	}
}
