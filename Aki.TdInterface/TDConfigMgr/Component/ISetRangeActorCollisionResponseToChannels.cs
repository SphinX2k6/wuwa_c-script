using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000765 RID: 1893
	public class ISetRangeActorCollisionResponseToChannels
	{
		// Token: 0x06002858 RID: 10328 RVA: 0x0006B6D0 File Offset: 0x000698D0
		private ISetRangeActorCollisionResponseToChannels_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetRangeActorCollisionResponseToChannels 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetRangeActorCollisionResponseToChannels_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetRangeActorCollisionResponseToChannels_SetValue());
			}
			return result;
		}

		// Token: 0x06002859 RID: 10329 RVA: 0x0006B708 File Offset: 0x00069908
		public static ISetRangeActorCollisionResponseToChannels Create([Nullable(2)] ISetRangeActorCollisionResponseToChannels instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetRangeActorCollisionResponseToChannels
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600285A RID: 10330 RVA: 0x0006B71B File Offset: 0x0006991B
		public static ISetRangeActorCollisionResponseToChannels CreateFromSetValue([Nullable(2)] ISetRangeActorCollisionResponseToChannels_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetRangeActorCollisionResponseToChannels
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600285B RID: 10331 RVA: 0x0006B72E File Offset: 0x0006992E
		public ISetRangeActorCollisionResponseToChannels_SetValue ToSetValue()
		{
			return new ISetRangeActorCollisionResponseToChannels_SetValue
			{
				CollisionChannelType = this.CollisionChannelType,
				CollisionResponseType = this.CollisionResponseType
			};
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x0600285C RID: 10332 RVA: 0x0006B74D File Offset: 0x0006994D
		// (set) Token: 0x0600285D RID: 10333 RVA: 0x0006B778 File Offset: 0x00069978
		public virtual ECollisionChannelType CollisionChannelType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CollisionChannelType;
				}
				if (this.PocoInterface == null)
				{
					return ECollisionChannelType.WorldStatic;
				}
				return this.PocoInterface.CollisionChannelType;
			}
			set
			{
				this.GetOrCreatePoco().CollisionChannelType = value;
			}
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x0600285E RID: 10334 RVA: 0x0006B786 File Offset: 0x00069986
		// (set) Token: 0x0600285F RID: 10335 RVA: 0x0006B7B1 File Offset: 0x000699B1
		public virtual ECollisionResponseType CollisionResponseType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CollisionResponseType;
				}
				if (this.PocoInterface == null)
				{
					return ECollisionResponseType.Ignore;
				}
				return this.PocoInterface.CollisionResponseType;
			}
			set
			{
				this.GetOrCreatePoco().CollisionResponseType = value;
			}
		}

		// Token: 0x04001B72 RID: 7026
		[Nullable(2)]
		protected ISetRangeActorCollisionResponseToChannels FbInstance;

		// Token: 0x04001B73 RID: 7027
		[Nullable(2)]
		protected ISetRangeActorCollisionResponseToChannels_SetValue PocoInterface;
	}
}
