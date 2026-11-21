using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200570D RID: 22285
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBackPackItemServerData
	{
		// Token: 0x06036DB4 RID: 224692 RVA: 0x00F4BD91 File Offset: 0x00F49F91
		public DangoBrawlBackPackItemServerData(DangoBrawlNormalBagItemInfo data)
		{
			this.ServerData = data;
		}

		// Token: 0x170069EE RID: 27118
		// (get) Token: 0x06036DB5 RID: 224693 RVA: 0x00F4BDA0 File Offset: 0x00F49FA0
		public int Uid
		{
			get
			{
				return this.ServerData.Inst.Uid;
			}
		}

		// Token: 0x170069EF RID: 27119
		// (get) Token: 0x06036DB6 RID: 224694 RVA: 0x00F4BDB2 File Offset: 0x00F49FB2
		public int ConfigId
		{
			get
			{
				return this.ServerData.Inst.ConfigId;
			}
		}

		// Token: 0x170069F0 RID: 27120
		// (get) Token: 0x06036DB7 RID: 224695 RVA: 0x00F4BDC4 File Offset: 0x00F49FC4
		public EDangoBrawlRotate Rotate
		{
			get
			{
				return (EDangoBrawlRotate)this.ServerData.Rotation;
			}
		}

		// Token: 0x06036DB8 RID: 224696 RVA: 0x00F4BDD1 File Offset: 0x00F49FD1
		public PanelPos GetPosInPanel()
		{
			return new PanelPos(this.ServerData.Y, this.ServerData.X);
		}

		// Token: 0x06036DB9 RID: 224697 RVA: 0x00F4BDF0 File Offset: 0x00F49FF0
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

		// Token: 0x0401D0F6 RID: 119030
		private readonly DangoBrawlNormalBagItemInfo ServerData;
	}
}
