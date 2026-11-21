using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FF1 RID: 8177
	public class ISceneActorMusicPlantsEvent : ISceneActorEvent
	{
		// Token: 0x0600ADA7 RID: 44455 RVA: 0x00187D58 File Offset: 0x00185F58
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

		// Token: 0x0600ADA8 RID: 44456 RVA: 0x00187D90 File Offset: 0x00185F90
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

		// Token: 0x0600ADA9 RID: 44457 RVA: 0x00187DA3 File Offset: 0x00185FA3
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

		// Token: 0x0600ADAA RID: 44458 RVA: 0x00187DB6 File Offset: 0x00185FB6
		public new ISceneActorMusicPlantsEvent_SetValue ToSetValue()
		{
			return new ISceneActorMusicPlantsEvent_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170034F8 RID: 13560
		// (get) Token: 0x0600ADAB RID: 44459 RVA: 0x00187DC9 File Offset: 0x00185FC9
		// (set) Token: 0x0600ADAC RID: 44460 RVA: 0x00187DF4 File Offset: 0x00185FF4
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

		// Token: 0x04006797 RID: 26519
		[Nullable(2)]
		protected new ISceneActorMusicPlantsEvent FbInstance;

		// Token: 0x04006798 RID: 26520
		[Nullable(2)]
		protected new ISceneActorMusicPlantsEvent_SetValue PocoInterface;
	}
}
