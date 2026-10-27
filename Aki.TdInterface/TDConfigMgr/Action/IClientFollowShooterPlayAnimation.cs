using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018BA RID: 6330
	[NullableContext(1)]
	[Nullable(0)]
	public class IClientFollowShooterPlayAnimation : IClientFollowShooterLeisureInteractType
	{
		// Token: 0x060087D3 RID: 34771 RVA: 0x00141B84 File Offset: 0x0013FD84
		private IClientFollowShooterPlayAnimation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClientFollowShooterPlayAnimation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClientFollowShooterPlayAnimation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClientFollowShooterPlayAnimation_SetValue());
			}
			return result;
		}

		// Token: 0x060087D4 RID: 34772 RVA: 0x00141BBC File Offset: 0x0013FDBC
		public static IClientFollowShooterPlayAnimation Create([Nullable(2)] IClientFollowShooterPlayAnimation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientFollowShooterPlayAnimation
			{
				FbInstance = instance
			};
		}

		// Token: 0x060087D5 RID: 34773 RVA: 0x00141BCF File Offset: 0x0013FDCF
		public static IClientFollowShooterPlayAnimation CreateFromSetValue([Nullable(2)] IClientFollowShooterPlayAnimation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClientFollowShooterPlayAnimation
			{
				PocoInterface = value
			};
		}

		// Token: 0x060087D6 RID: 34774 RVA: 0x00141BE2 File Offset: 0x0013FDE2
		public new IClientFollowShooterPlayAnimation_SetValue ToSetValue()
		{
			return new IClientFollowShooterPlayAnimation_SetValue
			{
				Type = this.Type,
				Montage = this.Montage
			};
		}

		// Token: 0x17002C27 RID: 11303
		// (get) Token: 0x060087D7 RID: 34775 RVA: 0x00141C01 File Offset: 0x0013FE01
		// (set) Token: 0x060087D8 RID: 34776 RVA: 0x00141C2C File Offset: 0x0013FE2C
		public override EClientFollowShooterLeisureInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EClientFollowShooterLeisureInteractType.ResetToPlayer;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002C28 RID: 11304
		// (get) Token: 0x060087D9 RID: 34777 RVA: 0x00141C3A File Offset: 0x0013FE3A
		// (set) Token: 0x060087DA RID: 34778 RVA: 0x00141C65 File Offset: 0x0013FE65
		public virtual string Montage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Montage;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Montage;
			}
			set
			{
				this.GetOrCreatePoco().Montage = value;
			}
		}

		// Token: 0x0400556A RID: 21866
		[Nullable(2)]
		protected new IClientFollowShooterPlayAnimation FbInstance;

		// Token: 0x0400556B RID: 21867
		[Nullable(2)]
		protected new IClientFollowShooterPlayAnimation_SetValue PocoInterface;
	}
}
