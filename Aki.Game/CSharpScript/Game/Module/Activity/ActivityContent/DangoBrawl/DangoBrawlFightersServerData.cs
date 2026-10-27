using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067C3 RID: 26563
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlFightersServerData
	{
		// Token: 0x06042280 RID: 270976 RVA: 0x0100ADF6 File Offset: 0x01008FF6
		public void Init(IReadOnlyList<DangoBrawlFighterInfo> data)
		{
			this.FighterMap.Clear();
			this.SelfFightPreAttrDic.Clear();
			this.UpdateFighters(data);
		}

		// Token: 0x06042281 RID: 270977 RVA: 0x0100AE18 File Offset: 0x01009018
		public void UpdateFighters(IReadOnlyList<DangoBrawlFighterInfo> newData)
		{
			this.CachePreAttrs();
			this.FighterMap.Clear();
			foreach (DangoBrawlFighterInfo dangoBrawlFighterInfo in newData)
			{
				this.FighterMap[dangoBrawlFighterInfo.FighterUId] = new DangoBrawlFighterServerData(dangoBrawlFighterInfo);
			}
		}

		// Token: 0x06042282 RID: 270978 RVA: 0x0100AE84 File Offset: 0x01009084
		[NullableContext(2)]
		public DangoBrawlFighterServerData GetFighter(int uid)
		{
			DangoBrawlFighterServerData result;
			if (!this.FighterMap.TryGetValue(uid, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06042283 RID: 270979 RVA: 0x0100AEA4 File Offset: 0x010090A4
		public List<DangoBrawlFighterServerData> GetAllFighter()
		{
			return new List<DangoBrawlFighterServerData>(this.FighterMap.Values);
		}

		// Token: 0x06042284 RID: 270980 RVA: 0x0100AEB6 File Offset: 0x010090B6
		[NullableContext(2)]
		public DangoBrawlFighterServerData GetSelfFighter()
		{
			return this.GetAllFighter().Find((DangoBrawlFighterServerData f) => f.Camp == DangoBrawlFightCamp.Player);
		}

		// Token: 0x06042285 RID: 270981 RVA: 0x0100AEE4 File Offset: 0x010090E4
		public int GetPreAttr(DangoBrawlProType proType)
		{
			int result;
			if (this.SelfFightPreAttrDic.TryGetValue(proType, out result))
			{
				return result;
			}
			DangoBrawlFighterServerData selfFighter = this.GetSelfFighter();
			if (selfFighter == null)
			{
				return 0;
			}
			return selfFighter.GetAttr((int)proType);
		}

		// Token: 0x06042286 RID: 270982 RVA: 0x0100AF18 File Offset: 0x01009118
		public void CachePreAttrs()
		{
			DangoBrawlFighterServerData selfFighter = this.GetSelfFighter();
			if (selfFighter == null)
			{
				return;
			}
			this.SelfFightPreAttrDic[DangoBrawlProType.MaxHp] = selfFighter.MaxHp;
			this.SelfFightPreAttrDic[DangoBrawlProType.Cost] = selfFighter.Cost;
		}

		// Token: 0x06042287 RID: 270983 RVA: 0x0100AF54 File Offset: 0x01009154
		public int GetMaxHpDelta()
		{
			DangoBrawlFighterServerData selfFighter = this.GetSelfFighter();
			int num = (selfFighter != null) ? selfFighter.MaxHp : 0;
			int preAttr = this.GetPreAttr(DangoBrawlProType.MaxHp);
			return num - preAttr;
		}

		// Token: 0x06042288 RID: 270984 RVA: 0x0100AF80 File Offset: 0x01009180
		public int GetCostDelta()
		{
			DangoBrawlFighterServerData selfFighter = this.GetSelfFighter();
			int num = (selfFighter != null) ? selfFighter.Cost : 0;
			int preAttr = this.GetPreAttr(DangoBrawlProType.Cost);
			return num - preAttr;
		}

		// Token: 0x040228A2 RID: 141474
		private readonly Dictionary<int, DangoBrawlFighterServerData> FighterMap = new Dictionary<int, DangoBrawlFighterServerData>();

		// Token: 0x040228A3 RID: 141475
		private readonly Dictionary<DangoBrawlProType, int> SelfFightPreAttrDic = new Dictionary<DangoBrawlProType, int>();
	}
}
