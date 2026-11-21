using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BF7 RID: 3063
	public class ResetSelfPosComponent : IComponentBase
	{
		// Token: 0x06004650 RID: 18000 RVA: 0x000B33F0 File Offset: 0x000B15F0
		public static ResetSelfPosComponent Create(IResetSelfPosComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ResetSelfPosComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700125D RID: 4701
		// (get) Token: 0x06004651 RID: 18001 RVA: 0x000B3410 File Offset: 0x000B1610
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

		// Token: 0x1700125E RID: 4702
		// (get) Token: 0x06004652 RID: 18002 RVA: 0x000B3448 File Offset: 0x000B1648
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700125F RID: 4703
		// (get) Token: 0x06004653 RID: 18003 RVA: 0x000B345E File Offset: 0x000B165E
		public virtual float ResetRadius
		{
			get
			{
				return this.Instance.ResetRadius;
			}
		}

		// Token: 0x17001260 RID: 4704
		// (get) Token: 0x06004654 RID: 18004 RVA: 0x000B346C File Offset: 0x000B166C
		public virtual bool? IsDisableResetPosAfterThrow
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsDisableResetPosAfterThrow);
			}
		}

		// Token: 0x17001261 RID: 4705
		// (get) Token: 0x06004655 RID: 18005 RVA: 0x000B34A4 File Offset: 0x000B16A4
		public virtual bool? IsResetPosAfterThrow
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsResetPosAfterThrow);
			}
		}

		// Token: 0x17001262 RID: 4706
		// (get) Token: 0x06004656 RID: 18006 RVA: 0x000B34DC File Offset: 0x000B16DC
		public virtual float? ResetPosDelayTime
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new float?(this.Instance.ResetPosDelayTime);
			}
		}

		// Token: 0x04002788 RID: 10120
		private IResetSelfPosComponent Instance;
	}
}
