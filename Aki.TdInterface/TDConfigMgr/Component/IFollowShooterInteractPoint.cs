using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003AC RID: 940
	[NullableContext(1)]
	[Nullable(0)]
	public class IFollowShooterInteractPoint : IExploreSkillInteractType
	{
		// Token: 0x060012C1 RID: 4801 RVA: 0x0003D9FC File Offset: 0x0003BBFC
		private IFollowShooterInteractPoint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFollowShooterInteractPoint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFollowShooterInteractPoint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFollowShooterInteractPoint_SetValue());
			}
			return result;
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x0003DA34 File Offset: 0x0003BC34
		public static IFollowShooterInteractPoint Create([Nullable(2)] IFollowShooterInteractPoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFollowShooterInteractPoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x0003DA47 File Offset: 0x0003BC47
		public static IFollowShooterInteractPoint CreateFromSetValue([Nullable(2)] IFollowShooterInteractPoint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFollowShooterInteractPoint
			{
				PocoInterface = value
			};
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x0003DA5A File Offset: 0x0003BC5A
		public new IFollowShooterInteractPoint_SetValue ToSetValue()
		{
			return new IFollowShooterInteractPoint_SetValue
			{
				Type = this.Type,
				ThrowInteractConfig = this.ThrowInteractConfig
			};
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x060012C5 RID: 4805 RVA: 0x0003DA79 File Offset: 0x0003BC79
		// (set) Token: 0x060012C6 RID: 4806 RVA: 0x0003DAA4 File Offset: 0x0003BCA4
		public override EExploreSkillInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EExploreSkillInteractType.PullGiant;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x060012C7 RID: 4807 RVA: 0x0003DAB4 File Offset: 0x0003BCB4
		// (set) Token: 0x060012C8 RID: 4808 RVA: 0x0003DB15 File Offset: 0x0003BD15
		[Nullable(2)]
		public virtual IThrowFollowShooterInteractConfig ThrowInteractConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._ThrowInteractConfigInited)
				{
					return this._ThrowInteractConfigCache;
				}
				this._ThrowInteractConfigInited = true;
				if (this.FbInstance != null)
				{
					this._ThrowInteractConfigCache = IThrowFollowShooterInteractConfig.Create(this.FbInstance.ThrowInteractConfig);
				}
				else
				{
					IFollowShooterInteractPoint_SetValue pocoInterface = this.PocoInterface;
					this._ThrowInteractConfigCache = ((pocoInterface != null) ? pocoInterface.ThrowInteractConfig : null);
				}
				return this._ThrowInteractConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().ThrowInteractConfig = value;
				this._ThrowInteractConfigInited = false;
			}
		}

		// Token: 0x04000F0D RID: 3853
		[Nullable(2)]
		protected new IFollowShooterInteractPoint FbInstance;

		// Token: 0x04000F0E RID: 3854
		[Nullable(2)]
		protected new IFollowShooterInteractPoint_SetValue PocoInterface;

		// Token: 0x04000F0F RID: 3855
		private IThrowFollowShooterInteractConfig _ThrowInteractConfigCache;

		// Token: 0x04000F10 RID: 3856
		private bool _ThrowInteractConfigInited;
	}
}
