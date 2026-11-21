using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002925 RID: 10533
	public class ITransitionPopupArtText : ITransitionPopupStyle
	{
		// Token: 0x0600EA12 RID: 59922 RVA: 0x00228BAC File Offset: 0x00226DAC
		public static ITransitionPopupArtText Create(ITransitionPopupArtText? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITransitionPopupArtText
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004476 RID: 17526
		// (get) Token: 0x0600EA13 RID: 59923 RVA: 0x00228BCB File Offset: 0x00226DCB
		public override ETransitionPopupStyleType Type
		{
			get
			{
				return (ETransitionPopupStyleType)this.Instance.Type;
			}
		}

		// Token: 0x17004477 RID: 17527
		// (get) Token: 0x0600EA14 RID: 59924 RVA: 0x00228BD8 File Offset: 0x00226DD8
		public virtual ITransitionPopupYuanChengArtText ArtTextType
		{
			get
			{
				if (this._ArtTextTypeInited)
				{
					return this._ArtTextTypeCache;
				}
				this._ArtTextTypeInited = true;
				this._ArtTextTypeCache = ITransitionPopupYuanChengArtText.Create(this.Instance.ArtTextType);
				return this._ArtTextTypeCache;
			}
		}

		// Token: 0x04008103 RID: 33027
		private ITransitionPopupArtText Instance;

		// Token: 0x04008104 RID: 33028
		[Nullable(2)]
		private ITransitionPopupYuanChengArtText _ArtTextTypeCache;

		// Token: 0x04008105 RID: 33029
		private bool _ArtTextTypeInited;
	}
}
