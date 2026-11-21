using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000948 RID: 2376
	public class SpringComponent : IComponentBase
	{
		// Token: 0x060034C7 RID: 13511 RVA: 0x00086884 File Offset: 0x00084A84
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

		// Token: 0x060034C8 RID: 13512 RVA: 0x000868BC File Offset: 0x00084ABC
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

		// Token: 0x060034C9 RID: 13513 RVA: 0x000868CF File Offset: 0x00084ACF
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

		// Token: 0x060034CA RID: 13514 RVA: 0x000868E4 File Offset: 0x00084AE4
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

		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x060034CB RID: 13515 RVA: 0x00086940 File Offset: 0x00084B40
		// (set) Token: 0x060034CC RID: 13516 RVA: 0x0008697A File Offset: 0x00084B7A
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

		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x060034CD RID: 13517 RVA: 0x00086988 File Offset: 0x00084B88
		// (set) Token: 0x060034CE RID: 13518 RVA: 0x000869B2 File Offset: 0x00084BB2
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

		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x060034CF RID: 13519 RVA: 0x000869C0 File Offset: 0x00084BC0
		// (set) Token: 0x060034D0 RID: 13520 RVA: 0x000869EB File Offset: 0x00084BEB
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

		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x060034D1 RID: 13521 RVA: 0x000869F9 File Offset: 0x00084BF9
		// (set) Token: 0x060034D2 RID: 13522 RVA: 0x00086A24 File Offset: 0x00084C24
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

		// Token: 0x17000DFE RID: 3582
		// (get) Token: 0x060034D3 RID: 13523 RVA: 0x00086A34 File Offset: 0x00084C34
		// (set) Token: 0x060034D4 RID: 13524 RVA: 0x00086A95 File Offset: 0x00084C95
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

		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x060034D5 RID: 13525 RVA: 0x00086AAA File Offset: 0x00084CAA
		// (set) Token: 0x060034D6 RID: 13526 RVA: 0x00086AD5 File Offset: 0x00084CD5
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

		// Token: 0x04002299 RID: 8857
		[Nullable(2)]
		protected new SpringComponent FbInstance;

		// Token: 0x0400229A RID: 8858
		[Nullable(2)]
		protected new SpringComponent_SetValue PocoInterface;

		// Token: 0x0400229B RID: 8859
		private ISettingSpringDir _SettingDirCache;

		// Token: 0x0400229C RID: 8860
		private bool _SettingDirInited;
	}
}
