using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002836 RID: 10294
	[NullableContext(2)]
	[Nullable(0)]
	public class IInstrumentKeyAttribute
	{
		// Token: 0x0600E440 RID: 58432 RVA: 0x00219AA1 File Offset: 0x00217CA1
		[NullableContext(1)]
		public static IInstrumentKeyAttribute Create(IInstrumentKeyAttribute? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInstrumentKeyAttribute
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004596 RID: 17814
		// (get) Token: 0x0600E441 RID: 58433 RVA: 0x00219AC0 File Offset: 0x00217CC0
		public virtual string FundamentalToneAssetPath
		{
			get
			{
				return this.Instance.FundamentalToneAssetPath;
			}
		}

		// Token: 0x17004597 RID: 17815
		// (get) Token: 0x0600E442 RID: 58434 RVA: 0x00219ACD File Offset: 0x00217CCD
		public virtual string OverToneAssetPath
		{
			get
			{
				return this.Instance.OverToneAssetPath;
			}
		}

		// Token: 0x17004598 RID: 17816
		// (get) Token: 0x0600E443 RID: 58435 RVA: 0x00219ADA File Offset: 0x00217CDA
		public virtual string TextureAssetPath
		{
			get
			{
				return this.Instance.TextureAssetPath;
			}
		}

		// Token: 0x04007E4A RID: 32330
		private IInstrumentKeyAttribute Instance;
	}
}
