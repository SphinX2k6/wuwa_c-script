using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003F5 RID: 1013
	public class IFollowShooterInteractPoint : IExploreSkillInteractType
	{
		// Token: 0x06001407 RID: 5127 RVA: 0x00040D34 File Offset: 0x0003EF34
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

		// Token: 0x06001408 RID: 5128 RVA: 0x00040D6C File Offset: 0x0003EF6C
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

		// Token: 0x06001409 RID: 5129 RVA: 0x00040D7F File Offset: 0x0003EF7F
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

		// Token: 0x0600140A RID: 5130 RVA: 0x00040D92 File Offset: 0x0003EF92
		public new IFollowShooterInteractPoint_SetValue ToSetValue()
		{
			return new IFollowShooterInteractPoint_SetValue
			{
				Type = this.Type,
				ThrowInteractConfig = this.ThrowInteractConfig
			};
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x0600140B RID: 5131 RVA: 0x00040DB1 File Offset: 0x0003EFB1
		// (set) Token: 0x0600140C RID: 5132 RVA: 0x00040DDC File Offset: 0x0003EFDC
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

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x0600140D RID: 5133 RVA: 0x00040DEC File Offset: 0x0003EFEC
		// (set) Token: 0x0600140E RID: 5134 RVA: 0x00040E4D File Offset: 0x0003F04D
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

		// Token: 0x04001005 RID: 4101
		[Nullable(2)]
		protected new IFollowShooterInteractPoint FbInstance;

		// Token: 0x04001006 RID: 4102
		[Nullable(2)]
		protected new IFollowShooterInteractPoint_SetValue PocoInterface;

		// Token: 0x04001007 RID: 4103
		private IThrowFollowShooterInteractConfig _ThrowInteractConfigCache;

		// Token: 0x04001008 RID: 4104
		private bool _ThrowInteractConfigInited;
	}
}
