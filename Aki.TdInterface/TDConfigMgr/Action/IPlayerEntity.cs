using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F11 RID: 7953
	public class IPlayerEntity : ITargetEntityType
	{
		// Token: 0x0600A947 RID: 43335 RVA: 0x0018056C File Offset: 0x0017E76C
		private IPlayerEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlayerEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlayerEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlayerEntity_SetValue());
			}
			return result;
		}

		// Token: 0x0600A948 RID: 43336 RVA: 0x001805A4 File Offset: 0x0017E7A4
		public static IPlayerEntity Create([Nullable(2)] IPlayerEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayerEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A949 RID: 43337 RVA: 0x001805B7 File Offset: 0x0017E7B7
		public static IPlayerEntity CreateFromSetValue([Nullable(2)] IPlayerEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlayerEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A94A RID: 43338 RVA: 0x001805CA File Offset: 0x0017E7CA
		public new IPlayerEntity_SetValue ToSetValue()
		{
			return new IPlayerEntity_SetValue
			{
				Type = this.Type,
				PlayerTargetType = this.PlayerTargetType
			};
		}

		// Token: 0x17003418 RID: 13336
		// (get) Token: 0x0600A94B RID: 43339 RVA: 0x001805E9 File Offset: 0x0017E7E9
		// (set) Token: 0x0600A94C RID: 43340 RVA: 0x00180614 File Offset: 0x0017E814
		public override ETargetEntityType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETargetEntityType.Target;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003419 RID: 13337
		// (get) Token: 0x0600A94D RID: 43341 RVA: 0x00180624 File Offset: 0x0017E824
		// (set) Token: 0x0600A94E RID: 43342 RVA: 0x0018065E File Offset: 0x0017E85E
		public virtual EPlayerTargetType? PlayerTargetType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlayerTargetType;
				}
				IPlayerEntity_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PlayerTargetType;
			}
			set
			{
				this.GetOrCreatePoco().PlayerTargetType = value;
			}
		}

		// Token: 0x040065AD RID: 26029
		[Nullable(2)]
		protected new IPlayerEntity FbInstance;

		// Token: 0x040065AE RID: 26030
		[Nullable(2)]
		protected new IPlayerEntity_SetValue PocoInterface;
	}
}
