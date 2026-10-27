using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D7F RID: 3455
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelQteComponent : IComponentBase
	{
		// Token: 0x06004E9A RID: 20122 RVA: 0x000C2F7F File Offset: 0x000C117F
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

		// Token: 0x17001959 RID: 6489
		// (get) Token: 0x06004E9B RID: 20123 RVA: 0x000C2FA0 File Offset: 0x000C11A0
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

		// Token: 0x1700195A RID: 6490
		// (get) Token: 0x06004E9C RID: 20124 RVA: 0x000C2FD8 File Offset: 0x000C11D8
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700195B RID: 6491
		// (get) Token: 0x06004E9D RID: 20125 RVA: 0x000C2FEE File Offset: 0x000C11EE
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

		// Token: 0x04002D20 RID: 11552
		private ILevelQteComponent Instance;

		// Token: 0x04002D21 RID: 11553
		[Nullable(2)]
		private ISingleBtnQte _QteConfigCache;

		// Token: 0x04002D22 RID: 11554
		private bool _QteConfigInited;
	}
}
