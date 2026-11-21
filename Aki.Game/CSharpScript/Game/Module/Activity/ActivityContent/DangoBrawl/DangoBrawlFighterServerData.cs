using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005712 RID: 22290
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlFighterServerData
	{
		// Token: 0x06036DCE RID: 224718 RVA: 0x00F4C11D File Offset: 0x00F4A31D
		public DangoBrawlFighterServerData(DangoBrawlFighterInfo data)
		{
			this.ServerData = data;
		}

		// Token: 0x170069F6 RID: 27126
		// (get) Token: 0x06036DCF RID: 224719 RVA: 0x00F4C12C File Offset: 0x00F4A32C
		public int Uid
		{
			get
			{
				return this.ServerData.FighterUId;
			}
		}

		// Token: 0x170069F7 RID: 27127
		// (get) Token: 0x06036DD0 RID: 224720 RVA: 0x00F4C139 File Offset: 0x00F4A339
		public DangoBrawlFightCamp Camp
		{
			get
			{
				return this.ServerData.Camp;
			}
		}

		// Token: 0x170069F8 RID: 27128
		// (get) Token: 0x06036DD1 RID: 224721 RVA: 0x00F4C146 File Offset: 0x00F4A346
		public int RoleConfigId
		{
			get
			{
				return this.ServerData.RoleConfigId;
			}
		}

		// Token: 0x06036DD2 RID: 224722 RVA: 0x00F4C153 File Offset: 0x00F4A353
		public int GetAttr(int attrId)
		{
			return this.ServerData.InitFinalAttrs.GetValueOrDefault(attrId, 0);
		}

		// Token: 0x06036DD3 RID: 224723 RVA: 0x00F4C168 File Offset: 0x00F4A368
		public void SetFinalAttrs(MapField<int, int> map)
		{
			foreach (KeyValuePair<int, int> keyValuePair in map)
			{
				this.ServerData.InitFinalAttrs[keyValuePair.Key] = keyValuePair.Value;
			}
		}

		// Token: 0x170069F9 RID: 27129
		// (get) Token: 0x06036DD4 RID: 224724 RVA: 0x00F4C1C8 File Offset: 0x00F4A3C8
		public int MaxHp
		{
			get
			{
				return this.GetAttr(0);
			}
		}

		// Token: 0x170069FA RID: 27130
		// (get) Token: 0x06036DD5 RID: 224725 RVA: 0x00F4C1D1 File Offset: 0x00F4A3D1
		public int Cost
		{
			get
			{
				return this.GetAttr(2);
			}
		}

		// Token: 0x0401D0FE RID: 119038
		private readonly DangoBrawlFighterInfo ServerData;
	}
}
