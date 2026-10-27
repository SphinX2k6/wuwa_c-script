using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067C2 RID: 26562
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlFighterServerData
	{
		// Token: 0x06042278 RID: 270968 RVA: 0x0100AD39 File Offset: 0x01008F39
		public DangoBrawlFighterServerData(DangoBrawlFighterInfo data)
		{
			this.ServerData = data;
		}

		// Token: 0x170096B5 RID: 38581
		// (get) Token: 0x06042279 RID: 270969 RVA: 0x0100AD48 File Offset: 0x01008F48
		public int Uid
		{
			get
			{
				return this.ServerData.FighterUId;
			}
		}

		// Token: 0x170096B6 RID: 38582
		// (get) Token: 0x0604227A RID: 270970 RVA: 0x0100AD55 File Offset: 0x01008F55
		public DangoBrawlFightCamp Camp
		{
			get
			{
				return this.ServerData.Camp;
			}
		}

		// Token: 0x170096B7 RID: 38583
		// (get) Token: 0x0604227B RID: 270971 RVA: 0x0100AD62 File Offset: 0x01008F62
		public int RoleConfigId
		{
			get
			{
				return this.ServerData.RoleConfigId;
			}
		}

		// Token: 0x0604227C RID: 270972 RVA: 0x0100AD6F File Offset: 0x01008F6F
		public int GetAttr(int attrId)
		{
			return this.ServerData.InitFinalAttrs.GetValueOrDefault(attrId, 0);
		}

		// Token: 0x0604227D RID: 270973 RVA: 0x0100AD84 File Offset: 0x01008F84
		public void SetFinalAttrs(MapField<int, int> map)
		{
			foreach (KeyValuePair<int, int> keyValuePair in map)
			{
				this.ServerData.InitFinalAttrs[keyValuePair.Key] = keyValuePair.Value;
			}
		}

		// Token: 0x170096B8 RID: 38584
		// (get) Token: 0x0604227E RID: 270974 RVA: 0x0100ADE4 File Offset: 0x01008FE4
		public int MaxHp
		{
			get
			{
				return this.GetAttr(0);
			}
		}

		// Token: 0x170096B9 RID: 38585
		// (get) Token: 0x0604227F RID: 270975 RVA: 0x0100ADED File Offset: 0x01008FED
		public int Cost
		{
			get
			{
				return this.GetAttr(2);
			}
		}

		// Token: 0x040228A1 RID: 141473
		private readonly DangoBrawlFighterInfo ServerData;
	}
}
