using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FED RID: 8173
	public class ISceneActorEvent
	{
		// Token: 0x0600AD97 RID: 44439 RVA: 0x00187BE0 File Offset: 0x00185DE0
		private ISceneActorEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneActorEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneActorEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneActorEvent_SetValue());
			}
			return result;
		}

		// Token: 0x0600AD98 RID: 44440 RVA: 0x00187C18 File Offset: 0x00185E18
		public static ISceneActorEvent Create([Nullable(2)] ISceneActorEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneActorEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AD99 RID: 44441 RVA: 0x00187C2B File Offset: 0x00185E2B
		public static ISceneActorEvent CreateFromSetValue([Nullable(2)] ISceneActorEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneActorEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AD9A RID: 44442 RVA: 0x00187C3E File Offset: 0x00185E3E
		public ISceneActorEvent_SetValue ToSetValue()
		{
			return new ISceneActorEvent_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170034F6 RID: 13558
		// (get) Token: 0x0600AD9B RID: 44443 RVA: 0x00187C51 File Offset: 0x00185E51
		// (set) Token: 0x0600AD9C RID: 44444 RVA: 0x00187C7C File Offset: 0x00185E7C
		public virtual ESceneActorEventType Type
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

		// Token: 0x04006791 RID: 26513
		[Nullable(2)]
		protected ISceneActorEvent FbInstance;

		// Token: 0x04006792 RID: 26514
		[Nullable(2)]
		protected ISceneActorEvent_SetValue PocoInterface;
	}
}
