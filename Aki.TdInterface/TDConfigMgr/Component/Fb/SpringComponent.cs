using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B35 RID: 2869
	public class SpringComponent : IComponentBase
	{
		// Token: 0x060041A0 RID: 16800 RVA: 0x000A7288 File Offset: 0x000A5488
		public static SpringComponent Create(ISpringComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SpringComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F31 RID: 3889
		// (get) Token: 0x060041A1 RID: 16801 RVA: 0x000A72A8 File Offset: 0x000A54A8
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17000F32 RID: 3890
		// (get) Token: 0x060041A2 RID: 16802 RVA: 0x000A72E0 File Offset: 0x000A54E0
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F33 RID: 3891
		// (get) Token: 0x060041A3 RID: 16803 RVA: 0x000A72F6 File Offset: 0x000A54F6
		public virtual bool IsNormalSpring
		{
			get
			{
				return this.Instance.IsNormalSpring;
			}
		}

		// Token: 0x17000F34 RID: 3892
		// (get) Token: 0x060041A4 RID: 16804 RVA: 0x000A7303 File Offset: 0x000A5503
		public virtual bool IsHitNormalSpring
		{
			get
			{
				return this.Instance.IsHitNormalSpring;
			}
		}

		// Token: 0x17000F35 RID: 3893
		// (get) Token: 0x060041A5 RID: 16805 RVA: 0x000A7310 File Offset: 0x000A5510
		public virtual ISettingSpringDir SettingDir
		{
			get
			{
				if (this._SettingDirInited)
				{
					return this._SettingDirCache;
				}
				this._SettingDirInited = true;
				this._SettingDirCache = ISettingSpringDir.Create(this.Instance.SettingDir);
				return this._SettingDirCache;
			}
		}

		// Token: 0x17000F36 RID: 3894
		// (get) Token: 0x060041A6 RID: 16806 RVA: 0x000A7344 File Offset: 0x000A5544
		public virtual int SpringPow
		{
			get
			{
				return this.Instance.SpringPow;
			}
		}

		// Token: 0x0400245A RID: 9306
		private ISpringComponent Instance;

		// Token: 0x0400245B RID: 9307
		[Nullable(2)]
		private ISettingSpringDir _SettingDirCache;

		// Token: 0x0400245C RID: 9308
		private bool _SettingDirInited;
	}
}
