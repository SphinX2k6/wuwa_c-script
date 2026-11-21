using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x020042CD RID: 17101
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueTokenViewData
	{
		// Token: 0x0602B4C9 RID: 177353 RVA: 0x00C2A195 File Offset: 0x00C28395
		public RogueTokenViewData(IIllustratedTokenDataInfo tokenViewInfo)
		{
			this.TokenViewInfo = tokenViewInfo;
		}

		// Token: 0x0602B4CA RID: 177354 RVA: 0x00C2A1A4 File Offset: 0x00C283A4
		public void SetTokenViewInfo(IIllustratedTokenDataInfo tokenViewInfo)
		{
			this.TokenViewInfo = tokenViewInfo;
		}

		// Token: 0x0602B4CB RID: 177355 RVA: 0x00C2A1AD File Offset: 0x00C283AD
		public IIllustratedTokenDataInfo GetTokenViewInfo()
		{
			return this.TokenViewInfo;
		}

		// Token: 0x0602B4CC RID: 177356 RVA: 0x00C2A1B5 File Offset: 0x00C283B5
		public int GetConfigId()
		{
			return this.TokenViewInfo.ConfigId;
		}

		// Token: 0x0602B4CD RID: 177357 RVA: 0x00C2A1C2 File Offset: 0x00C283C2
		public int GetCollectionIndex()
		{
			return this.TokenViewInfo.CollectionIndex;
		}

		// Token: 0x0602B4CE RID: 177358 RVA: 0x00C2A1CF File Offset: 0x00C283CF
		public void SetSelectOn(bool isSelectOn)
		{
			this.TokenViewInfo.IsSelectOn = isSelectOn;
		}

		// Token: 0x0401759E RID: 95646
		private IIllustratedTokenDataInfo TokenViewInfo;
	}
}
