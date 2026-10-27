using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x020052FD RID: 21245
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueTokenViewData
	{
		// Token: 0x060365CD RID: 222669 RVA: 0x00CDC7C5 File Offset: 0x00CDA9C5
		public RogueTokenViewData(IIllustratedTokenDataInfo tokenViewInfo)
		{
			this.TokenViewInfo = tokenViewInfo;
		}

		// Token: 0x060365CE RID: 222670 RVA: 0x00CDC7D4 File Offset: 0x00CDA9D4
		public void SetTokenViewInfo(IIllustratedTokenDataInfo tokenViewInfo)
		{
			this.TokenViewInfo = tokenViewInfo;
		}

		// Token: 0x060365CF RID: 222671 RVA: 0x00CDC7DD File Offset: 0x00CDA9DD
		public IIllustratedTokenDataInfo GetTokenViewInfo()
		{
			return this.TokenViewInfo;
		}

		// Token: 0x060365D0 RID: 222672 RVA: 0x00CDC7E5 File Offset: 0x00CDA9E5
		public int GetConfigId()
		{
			return this.TokenViewInfo.ConfigId;
		}

		// Token: 0x060365D1 RID: 222673 RVA: 0x00CDC7F2 File Offset: 0x00CDA9F2
		public int GetCollectionIndex()
		{
			return this.TokenViewInfo.CollectionIndex;
		}

		// Token: 0x060365D2 RID: 222674 RVA: 0x00CDC7FF File Offset: 0x00CDA9FF
		public void SetSelectOn(bool isSelectOn)
		{
			this.TokenViewInfo.IsSelectOn = isSelectOn;
		}

		// Token: 0x0401CB68 RID: 117608
		private IIllustratedTokenDataInfo TokenViewInfo;
	}
}
