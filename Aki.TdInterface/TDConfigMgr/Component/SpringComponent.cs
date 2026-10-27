using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008A5 RID: 2213
	[NullableContext(1)]
	[Nullable(0)]
	public class SpringComponent : IComponentBase
	{
		// Token: 0x0600318B RID: 12683 RVA: 0x0007F39C File Offset: 0x0007D59C
		private SpringComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SpringComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SpringComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SpringComponent_SetValue());
			}
			return result;
		}

		// Token: 0x0600318C RID: 12684 RVA: 0x0007F3D4 File Offset: 0x0007D5D4
		public static SpringComponent Create([Nullable(2)] SpringComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SpringComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600318D RID: 12685 RVA: 0x0007F3E7 File Offset: 0x0007D5E7
		public static SpringComponent CreateFromSetValue([Nullable(2)] SpringComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SpringComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600318E RID: 12686 RVA: 0x0007F3FC File Offset: 0x0007D5FC
		public new SpringComponent_SetValue ToSetValue()
		{
			return new SpringComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				IsNormalSpring = this.IsNormalSpring,
				IsHitNormalSpring = this.IsHitNormalSpring,
				SettingDir = this.SettingDir,
				SpringPow = this.SpringPow
			};
		}

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x0600318F RID: 12687 RVA: 0x0007F458 File Offset: 0x0007D658
		// (set) Token: 0x06003190 RID: 12688 RVA: 0x0007F492 File Offset: 0x0007D692
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				SpringComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x06003191 RID: 12689 RVA: 0x0007F4A0 File Offset: 0x0007D6A0
		// (set) Token: 0x06003192 RID: 12690 RVA: 0x0007F4CA File Offset: 0x0007D6CA
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x06003193 RID: 12691 RVA: 0x0007F4D8 File Offset: 0x0007D6D8
		// (set) Token: 0x06003194 RID: 12692 RVA: 0x0007F503 File Offset: 0x0007D703
		public virtual bool IsNormalSpring
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsNormalSpring;
				}
				return this.PocoInterface != null && this.PocoInterface.IsNormalSpring;
			}
			set
			{
				this.GetOrCreatePoco().IsNormalSpring = value;
			}
		}

		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x06003195 RID: 12693 RVA: 0x0007F511 File Offset: 0x0007D711
		// (set) Token: 0x06003196 RID: 12694 RVA: 0x0007F53C File Offset: 0x0007D73C
		public virtual bool IsHitNormalSpring
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsHitNormalSpring;
				}
				return this.PocoInterface != null && this.PocoInterface.IsHitNormalSpring;
			}
			set
			{
				this.GetOrCreatePoco().IsHitNormalSpring = value;
			}
		}

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x06003197 RID: 12695 RVA: 0x0007F54C File Offset: 0x0007D74C
		// (set) Token: 0x06003198 RID: 12696 RVA: 0x0007F5AD File Offset: 0x0007D7AD
		public virtual ISettingSpringDir SettingDir
		{
			get
			{
				if (this._SettingDirInited)
				{
					return this._SettingDirCache;
				}
				this._SettingDirInited = true;
				if (this.FbInstance != null)
				{
					this._SettingDirCache = ISettingSpringDir.Create(this.FbInstance.SettingDir);
				}
				else
				{
					SpringComponent_SetValue pocoInterface = this.PocoInterface;
					this._SettingDirCache = ((pocoInterface != null) ? pocoInterface.SettingDir : null);
				}
				return this._SettingDirCache;
			}
			set
			{
				this.GetOrCreatePoco().SettingDir = value;
				this._SettingDirInited = false;
			}
		}

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x06003199 RID: 12697 RVA: 0x0007F5C2 File Offset: 0x0007D7C2
		// (set) Token: 0x0600319A RID: 12698 RVA: 0x0007F5ED File Offset: 0x0007D7ED
		public virtual int SpringPow
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SpringPow;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SpringPow;
			}
			set
			{
				this.GetOrCreatePoco().SpringPow = value;
			}
		}

		// Token: 0x04002087 RID: 8327
		[Nullable(2)]
		protected new SpringComponent FbInstance;

		// Token: 0x04002088 RID: 8328
		[Nullable(2)]
		protected new SpringComponent_SetValue PocoInterface;

		// Token: 0x04002089 RID: 8329
		private ISettingSpringDir _SettingDirCache;

		// Token: 0x0400208A RID: 8330
		private bool _SettingDirInited;
	}
}
