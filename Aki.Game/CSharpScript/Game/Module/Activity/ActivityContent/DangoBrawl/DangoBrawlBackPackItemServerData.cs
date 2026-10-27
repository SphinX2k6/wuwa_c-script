using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067BD RID: 26557
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBackPackItemServerData
	{
		// Token: 0x0604225E RID: 270942 RVA: 0x0100A9AD File Offset: 0x01008BAD
		public DangoBrawlBackPackItemServerData(DangoBrawlNormalBagItemInfo data)
		{
			this.ServerData = data;
		}

		// Token: 0x170096AD RID: 38573
		// (get) Token: 0x0604225F RID: 270943 RVA: 0x0100A9BC File Offset: 0x01008BBC
		public int Uid
		{
			get
			{
				return this.ServerData.Inst.Uid;
			}
		}

		// Token: 0x170096AE RID: 38574
		// (get) Token: 0x06042260 RID: 270944 RVA: 0x0100A9CE File Offset: 0x01008BCE
		public int ConfigId
		{
			get
			{
				return this.ServerData.Inst.ConfigId;
			}
		}

		// Token: 0x170096AF RID: 38575
		// (get) Token: 0x06042261 RID: 270945 RVA: 0x0100A9E0 File Offset: 0x01008BE0
		public EDangoBrawlRotate Rotate
		{
			get
			{
				return (EDangoBrawlRotate)this.ServerData.Rotation;
			}
		}

		// Token: 0x06042262 RID: 270946 RVA: 0x0100A9ED File Offset: 0x01008BED
		public PanelPos GetPosInPanel()
		{
			return new PanelPos(this.ServerData.Y, this.ServerData.X);
		}

		// Token: 0x06042263 RID: 270947 RVA: 0x0100AA0C File Offset: 0x01008C0C
		public static DangoBrawlBackPackItemServerData MakeData(int uid, int configId, PanelPos leftTopPos, EDangoBrawlRotate rotate)
		{
			DangoBrawlNormalBagItemInfo dangoBrawlNormalBagItemInfo = DangoBrawlNormalBagItemInfo.Create();
			DangoBrawlBaseItemInfo dangoBrawlBaseItemInfo = DangoBrawlBaseItemInfo.Create();
			dangoBrawlBaseItemInfo.Uid = uid;
			dangoBrawlBaseItemInfo.ConfigId = configId;
			dangoBrawlNormalBagItemInfo.Inst = dangoBrawlBaseItemInfo;
			dangoBrawlNormalBagItemInfo.X = leftTopPos.ColIndex;
			dangoBrawlNormalBagItemInfo.Y = leftTopPos.RowIndex;
			dangoBrawlNormalBagItemInfo.Rotation = (int)rotate;
			return new DangoBrawlBackPackItemServerData(dangoBrawlNormalBagItemInfo);
		}

		// Token: 0x04022899 RID: 141465
		private readonly DangoBrawlNormalBagItemInfo ServerData;
	}
}
