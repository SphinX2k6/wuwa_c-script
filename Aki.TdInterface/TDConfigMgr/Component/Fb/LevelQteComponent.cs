using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E7B RID: 3707
	public class LevelQteComponent : IComponentBase
	{
		// Token: 0x060053BF RID: 21439 RVA: 0x000CE7CF File Offset: 0x000CC9CF
		public static LevelQteComponent Create(ILevelQteComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new LevelQteComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001AC4 RID: 6852
		// (get) Token: 0x060053C0 RID: 21440 RVA: 0x000CE7F0 File Offset: 0x000CC9F0
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

		// Token: 0x17001AC5 RID: 6853
		// (get) Token: 0x060053C1 RID: 21441 RVA: 0x000CE828 File Offset: 0x000CCA28
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001AC6 RID: 6854
		// (get) Token: 0x060053C2 RID: 21442 RVA: 0x000CE83E File Offset: 0x000CCA3E
		public virtual ISingleBtnQte QteConfig
		{
			get
			{
				if (this._QteConfigInited)
				{
					return this._QteConfigCache;
				}
				this._QteConfigInited = true;
				this._QteConfigCache = ISingleBtnQte.Create(this.Instance.QteConfig);
				return this._QteConfigCache;
			}
		}

		// Token: 0x04002FE6 RID: 12262
		private ILevelQteComponent Instance;

		// Token: 0x04002FE7 RID: 12263
		[Nullable(2)]
		private ISingleBtnQte _QteConfigCache;

		// Token: 0x04002FE8 RID: 12264
		private bool _QteConfigInited;
	}
}
