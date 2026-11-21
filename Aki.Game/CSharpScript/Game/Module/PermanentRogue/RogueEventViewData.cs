using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x020042CE RID: 17102
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueEventViewData
	{
		// Token: 0x0602B4CF RID: 177359 RVA: 0x00C2A1DD File Offset: 0x00C283DD
		public RogueEventViewData(IIllustratedTokenDataInfo tokenViewInfo)
		{
			this.TokenViewInfo = tokenViewInfo;
		}

		// Token: 0x0602B4D0 RID: 177360 RVA: 0x00C2A1EC File Offset: 0x00C283EC
		public void SetTokenViewInfo(IIllustratedTokenDataInfo tokenViewInfo)
		{
			this.TokenViewInfo = tokenViewInfo;
		}

		// Token: 0x0602B4D1 RID: 177361 RVA: 0x00C2A1F5 File Offset: 0x00C283F5
		public IIllustratedTokenDataInfo GetTokenViewInfo()
		{
			return this.TokenViewInfo;
		}

		// Token: 0x0602B4D2 RID: 177362 RVA: 0x00C2A1FD File Offset: 0x00C283FD
		public void SetIsLock(bool bIsLock)
		{
			this.TokenViewInfo.IsLock = bIsLock;
		}

		// Token: 0x0602B4D3 RID: 177363 RVA: 0x00C2A20B File Offset: 0x00C2840B
		public int GetConfigId()
		{
			return this.TokenViewInfo.ConfigId;
		}

		// Token: 0x0602B4D4 RID: 177364 RVA: 0x00C2A218 File Offset: 0x00C28418
		public void SetSelectOn(bool isSelectOn)
		{
			this.TokenViewInfo.IsSelectOn = isSelectOn;
		}

		// Token: 0x0602B4D5 RID: 177365 RVA: 0x00C2A226 File Offset: 0x00C28426
		public bool GetSelectOn()
		{
			return this.TokenViewInfo.IsSelectOn;
		}

		// Token: 0x0401759F RID: 95647
		private IIllustratedTokenDataInfo TokenViewInfo;
	}
}
