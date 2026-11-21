using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005713 RID: 22291
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlFightersServerData
	{
		// Token: 0x06036DD6 RID: 224726 RVA: 0x00F4C1DA File Offset: 0x00F4A3DA
		public void Init(IReadOnlyList<DangoBrawlFighterInfo> data)
		{
			this.FighterMap.Clear();
			this.SelfFightPreAttrDic.Clear();
			this.UpdateFighters(data);
		}

		// Token: 0x06036DD7 RID: 224727 RVA: 0x00F4C1FC File Offset: 0x00F4A3FC
		public void UpdateFighters(IReadOnlyList<DangoBrawlFighterInfo> newData)
		{
			this.CachePreAttrs();
			this.FighterMap.Clear();
			foreach (DangoBrawlFighterInfo dangoBrawlFighterInfo in newData)
			{
				this.FighterMap[dangoBrawlFighterInfo.FighterUId] = new DangoBrawlFighterServerData(dangoBrawlFighterInfo);
			}
		}

		// Token: 0x06036DD8 RID: 224728 RVA: 0x00F4C268 File Offset: 0x00F4A468
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

		// Token: 0x06036DD9 RID: 224729 RVA: 0x00F4C288 File Offset: 0x00F4A488
		public List<DangoBrawlFighterServerData> GetAllFighter()
		{
			return new List<DangoBrawlFighterServerData>(this.FighterMap.Values);
		}

		// Token: 0x06036DDA RID: 224730 RVA: 0x00F4C29A File Offset: 0x00F4A49A
		[NullableContext(2)]
		public DangoBrawlFighterServerData GetSelfFighter()
		{
			return this.GetAllFighter().Find((DangoBrawlFighterServerData f) => f.Camp == DangoBrawlFightCamp.Player);
		}

		// Token: 0x06036DDB RID: 224731 RVA: 0x00F4C2C8 File Offset: 0x00F4A4C8
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

		// Token: 0x06036DDC RID: 224732 RVA: 0x00F4C2FC File Offset: 0x00F4A4FC
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

		// Token: 0x06036DDD RID: 224733 RVA: 0x00F4C338 File Offset: 0x00F4A538
		public int GetMaxHpDelta()
		{
			DangoBrawlFighterServerData selfFighter = this.GetSelfFighter();
			int num = (selfFighter != null) ? selfFighter.MaxHp : 0;
			int preAttr = this.GetPreAttr(DangoBrawlProType.MaxHp);
			return num - preAttr;
		}

		// Token: 0x06036DDE RID: 224734 RVA: 0x00F4C364 File Offset: 0x00F4A564
		public int GetCostDelta()
		{
			DangoBrawlFighterServerData selfFighter = this.GetSelfFighter();
			int num = (selfFighter != null) ? selfFighter.Cost : 0;
			int preAttr = this.GetPreAttr(DangoBrawlProType.Cost);
			return num - preAttr;
		}

		// Token: 0x0401D0FF RID: 119039
		private readonly Dictionary<int, DangoBrawlFighterServerData> FighterMap = new Dictionary<int, DangoBrawlFighterServerData>();

		// Token: 0x0401D100 RID: 119040
		private readonly Dictionary<DangoBrawlProType, int> SelfFightPreAttrDic = new Dictionary<DangoBrawlProType, int>();
	}
}
