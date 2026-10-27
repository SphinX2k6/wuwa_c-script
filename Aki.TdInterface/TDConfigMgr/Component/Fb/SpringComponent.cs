using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A6B RID: 2667
	[NullableContext(1)]
	[Nullable(0)]
	public class SpringComponent : IComponentBase
	{
		// Token: 0x06003D77 RID: 15735 RVA: 0x0009DCD0 File Offset: 0x0009BED0
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

		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x06003D78 RID: 15736 RVA: 0x0009DCF0 File Offset: 0x0009BEF0
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

		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x06003D79 RID: 15737 RVA: 0x0009DD28 File Offset: 0x0009BF28
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x06003D7A RID: 15738 RVA: 0x0009DD3E File Offset: 0x0009BF3E
		public virtual bool IsNormalSpring
		{
			get
			{
				return this.Instance.IsNormalSpring;
			}
		}

		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x06003D7B RID: 15739 RVA: 0x0009DD4B File Offset: 0x0009BF4B
		public virtual bool IsHitNormalSpring
		{
			get
			{
				return this.Instance.IsHitNormalSpring;
			}
		}

		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x06003D7C RID: 15740 RVA: 0x0009DD58 File Offset: 0x0009BF58
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

		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x06003D7D RID: 15741 RVA: 0x0009DD8C File Offset: 0x0009BF8C
		public virtual int SpringPow
		{
			get
			{
				return this.Instance.SpringPow;
			}
		}

		// Token: 0x0400223E RID: 8766
		private ISpringComponent Instance;

		// Token: 0x0400223F RID: 8767
		[Nullable(2)]
		private ISettingSpringDir _SettingDirCache;

		// Token: 0x04002240 RID: 8768
		private bool _SettingDirInited;
	}
}
