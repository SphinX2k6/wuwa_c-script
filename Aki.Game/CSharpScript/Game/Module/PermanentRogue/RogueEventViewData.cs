using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x020052FE RID: 21246
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueEventViewData
	{
		// Token: 0x060365D3 RID: 222675 RVA: 0x00CDC80D File Offset: 0x00CDAA0D
		public RogueEventViewData(IIllustratedTokenDataInfo tokenViewInfo)
		{
			this.TokenViewInfo = tokenViewInfo;
		}

		// Token: 0x060365D4 RID: 222676 RVA: 0x00CDC81C File Offset: 0x00CDAA1C
		public void SetTokenViewInfo(IIllustratedTokenDataInfo tokenViewInfo)
		{
			this.TokenViewInfo = tokenViewInfo;
		}

		// Token: 0x060365D5 RID: 222677 RVA: 0x00CDC825 File Offset: 0x00CDAA25
		public IIllustratedTokenDataInfo GetTokenViewInfo()
		{
			return this.TokenViewInfo;
		}

		// Token: 0x060365D6 RID: 222678 RVA: 0x00CDC82D File Offset: 0x00CDAA2D
		public void SetIsLock(bool bIsLock)
		{
			this.TokenViewInfo.IsLock = bIsLock;
		}

		// Token: 0x060365D7 RID: 222679 RVA: 0x00CDC83B File Offset: 0x00CDAA3B
		public int GetConfigId()
		{
			return this.TokenViewInfo.ConfigId;
		}

		// Token: 0x060365D8 RID: 222680 RVA: 0x00CDC848 File Offset: 0x00CDAA48
		public void SetSelectOn(bool isSelectOn)
		{
			this.TokenViewInfo.IsSelectOn = isSelectOn;
		}

		// Token: 0x060365D9 RID: 222681 RVA: 0x00CDC856 File Offset: 0x00CDAA56
		public bool GetSelectOn()
		{
			return this.TokenViewInfo.IsSelectOn;
		}

		// Token: 0x0401CB69 RID: 117609
		private IIllustratedTokenDataInfo TokenViewInfo;
	}
}
