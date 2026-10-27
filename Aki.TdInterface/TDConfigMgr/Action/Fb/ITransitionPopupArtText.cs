using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002661 RID: 9825
	[NullableContext(1)]
	[Nullable(0)]
	public class ITransitionPopupArtText : ITransitionPopupStyle
	{
		// Token: 0x0600DC36 RID: 56374 RVA: 0x0020C2D4 File Offset: 0x0020A4D4
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

		// Token: 0x17004136 RID: 16694
		// (get) Token: 0x0600DC37 RID: 56375 RVA: 0x0020C2F3 File Offset: 0x0020A4F3
		public override ETransitionPopupStyleType Type
		{
			get
			{
				return (ETransitionPopupStyleType)this.Instance.Type;
			}
		}

		// Token: 0x17004137 RID: 16695
		// (get) Token: 0x0600DC38 RID: 56376 RVA: 0x0020C300 File Offset: 0x0020A500
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

		// Token: 0x04007A61 RID: 31329
		private ITransitionPopupArtText Instance;

		// Token: 0x04007A62 RID: 31330
		[Nullable(2)]
		private ITransitionPopupYuanChengArtText _ArtTextTypeCache;

		// Token: 0x04007A63 RID: 31331
		private bool _ArtTextTypeInited;
	}
}
