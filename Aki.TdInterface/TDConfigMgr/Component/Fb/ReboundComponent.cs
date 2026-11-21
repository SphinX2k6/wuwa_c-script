using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D69 RID: 3433
	public class ReboundComponent : IComponentBase
	{
		// Token: 0x06004E11 RID: 19985 RVA: 0x000C2A11 File Offset: 0x000C0C11
		public static ReboundComponent Create(IReboundComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ReboundComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700173A RID: 5946
		// (get) Token: 0x06004E12 RID: 19986 RVA: 0x000C2A30 File Offset: 0x000C0C30
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

		// Token: 0x1700173B RID: 5947
		// (get) Token: 0x06004E13 RID: 19987 RVA: 0x000C2A68 File Offset: 0x000C0C68
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700173C RID: 5948
		// (get) Token: 0x06004E14 RID: 19988 RVA: 0x000C2A7E File Offset: 0x000C0C7E
		public virtual long BulletId
		{
			get
			{
				return this.Instance.BulletId;
			}
		}

		// Token: 0x1700173D RID: 5949
		// (get) Token: 0x06004E15 RID: 19989 RVA: 0x000C2A8B File Offset: 0x000C0C8B
		public virtual IForwardFrontRebound Option
		{
			get
			{
				if (this._OptionInited)
				{
					return this._OptionCache;
				}
				this._OptionInited = true;
				this._OptionCache = IForwardFrontRebound.Create(this.Instance.Option);
				return this._OptionCache;
			}
		}

		// Token: 0x04002C56 RID: 11350
		private IReboundComponent Instance;

		// Token: 0x04002C57 RID: 11351
		[Nullable(2)]
		private IForwardFrontRebound _OptionCache;

		// Token: 0x04002C58 RID: 11352
		private bool _OptionInited;
	}
}
