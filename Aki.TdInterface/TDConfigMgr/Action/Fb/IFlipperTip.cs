using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200275C RID: 10076
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlipperTip : ICommonTipType
	{
		// Token: 0x0600E07E RID: 57470 RVA: 0x00213141 File Offset: 0x00211341
		public static IFlipperTip Create(IFlipperTip? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlipperTip
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004388 RID: 17288
		// (get) Token: 0x0600E07F RID: 57471 RVA: 0x00213160 File Offset: 0x00211360
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x17004389 RID: 17289
		// (get) Token: 0x0600E080 RID: 57472 RVA: 0x0021316D File Offset: 0x0021136D
		public virtual string TidMainText
		{
			get
			{
				return this.Instance.TidMainText;
			}
		}

		// Token: 0x1700438A RID: 17290
		// (get) Token: 0x0600E081 RID: 57473 RVA: 0x0021317A File Offset: 0x0021137A
		public virtual string TidSubText
		{
			get
			{
				return this.Instance.TidSubText;
			}
		}

		// Token: 0x1700438B RID: 17291
		// (get) Token: 0x0600E082 RID: 57474 RVA: 0x00213187 File Offset: 0x00211387
		[Nullable(2)]
		public virtual string EdTidMainText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700438C RID: 17292
		// (get) Token: 0x0600E083 RID: 57475 RVA: 0x0021318A File Offset: 0x0021138A
		[Nullable(2)]
		public virtual string EdTidSubText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04007C5A RID: 31834
		private IFlipperTip Instance;
	}
}
