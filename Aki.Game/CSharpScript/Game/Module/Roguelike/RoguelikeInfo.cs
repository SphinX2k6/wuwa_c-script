using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D6B RID: 15723
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeInfo
	{
		// Token: 0x06028388 RID: 164744 RVA: 0x00B43774 File Offset: 0x00B41974
		public RoguelikeInfo(RoguelikeInstInfo roguelikeInfo)
		{
			this.RoleEntry = new RogueGainEntry(roguelikeInfo.RoleEntry, null);
			if (roguelikeInfo.PhantomEntry != null)
			{
				this.PhantomEntry = new RogueGainEntry(roguelikeInfo.PhantomEntry, null);
			}
			this.BuffEntryList = new List<RogueGainEntry>();
			if (roguelikeInfo.BuffEntryList != null)
			{
				foreach (RogueGainEntry rogueGainEntry in roguelikeInfo.BuffEntryList)
				{
					this.BuffEntryList.Add(new RogueGainEntry(rogueGainEntry, null));
				}
			}
			this.ElementDict = new Dictionary<int, int>();
			if (roguelikeInfo.ElementDict != null)
			{
				foreach (KeyValuePair<int, int> keyValuePair in roguelikeInfo.ElementDict)
				{
					int value = keyValuePair.Value;
					if (value != 0)
					{
						this.ElementDict.Add(keyValuePair.Key, value);
					}
				}
			}
			this.SpecialEntryList = new List<RogueGainEntry>();
			if (roguelikeInfo.MiraclecreationList != null)
			{
				foreach (RogueGainEntry rogueGainEntry2 in roguelikeInfo.MiraclecreationList)
				{
					this.SpecialEntryList.Add(new RogueGainEntry(rogueGainEntry2, null));
				}
			}
		}

		// Token: 0x06028389 RID: 164745 RVA: 0x00B43904 File Offset: 0x00B41B04
		public void Update(RoguelikeGainDataUpdateNotify notify)
		{
			if (notify.GainDataUpdateType == GainDataUpdateType.GainDataUpdate)
			{
				if (notify.RogueGainEntry != null)
				{
					RoguelikeGainDataType type = notify.RogueGainEntry.Type;
					switch (type)
					{
					case RoguelikeGainDataType.Phantom:
						this.PhantomEntry = new RogueGainEntry(notify.RogueGainEntry, null);
						break;
					case RoguelikeGainDataType.Shop:
						break;
					case RoguelikeGainDataType.Role:
						this.RoleEntry = new RogueGainEntry(notify.RogueGainEntry, null);
						break;
					case RoguelikeGainDataType.CommonBuff:
					{
						int num = this.BuffEntryList.FindIndex((RogueGainEntry entry) => entry.IncId == notify.RogueGainEntry.IncId);
						if (num != -1)
						{
							this.BuffEntryList[num] = new RogueGainEntry(notify.RogueGainEntry, null);
						}
						break;
					}
					default:
						if (type == RoguelikeGainDataType.Miraclecreation)
						{
							int num2 = this.SpecialEntryList.FindIndex((RogueGainEntry entry) => entry.IncId == notify.RogueGainEntry.IncId);
							if (num2 != -1)
							{
								this.SpecialEntryList[num2] = new RogueGainEntry(notify.RogueGainEntry, null);
							}
						}
						break;
					}
				}
			}
			else if (notify.GainDataUpdateType == GainDataUpdateType.GainDataAdd)
			{
				if (notify.RogueGainEntry != null)
				{
					RoguelikeGainDataType type = notify.RogueGainEntry.Type;
					if (type != RoguelikeGainDataType.Phantom)
					{
						if (type != RoguelikeGainDataType.CommonBuff)
						{
							if (type == RoguelikeGainDataType.Miraclecreation)
							{
								this.SpecialEntryList.Add(new RogueGainEntry(notify.RogueGainEntry, null));
							}
						}
						else
						{
							this.BuffEntryList.Add(new RogueGainEntry(notify.RogueGainEntry, null));
						}
					}
					else
					{
						this.PhantomEntry = new RogueGainEntry(notify.RogueGainEntry, null);
					}
				}
			}
			else if (notify.GainDataUpdateType == GainDataUpdateType.GainDataDelete && notify.RogueGainEntry != null)
			{
				RoguelikeGainDataType type = notify.RogueGainEntry.Type;
				if (type != RoguelikeGainDataType.Phantom)
				{
					if (type != RoguelikeGainDataType.CommonBuff)
					{
						if (type == RoguelikeGainDataType.Miraclecreation)
						{
							int num3 = this.SpecialEntryList.FindIndex((RogueGainEntry entry) => entry.IncId == notify.RogueGainEntry.IncId);
							if (num3 != -1)
							{
								this.SpecialEntryList.RemoveAt(num3);
							}
						}
					}
					else
					{
						int num4 = this.BuffEntryList.FindIndex((RogueGainEntry entry) => entry.IncId == notify.RogueGainEntry.IncId);
						if (num4 != -1)
						{
							this.BuffEntryList.RemoveAt(num4);
						}
					}
				}
				else
				{
					this.PhantomEntry = null;
				}
			}
			this.ElementDict = new Dictionary<int, int>();
			if (notify.ElementDict != null)
			{
				foreach (KeyValuePair<int, int> keyValuePair in notify.ElementDict)
				{
					int value = keyValuePair.Value;
					if (value != 0)
					{
						this.ElementDict.Add(keyValuePair.Key, value);
					}
				}
			}
		}

		// Token: 0x0602838A RID: 164746 RVA: 0x00B43C2C File Offset: 0x00B41E2C
		public bool GetIsUnlock(AffixEntry affixEntry)
		{
			foreach (KeyValuePair<int, int> keyValuePair in affixEntry.ElementDict)
			{
				int key = keyValuePair.Key;
				int value = keyValuePair.Value;
				int num = 0;
				int num2;
				if (this.ElementDict.TryGetValue(key, out num2))
				{
					num = num2;
				}
				if (num < value)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0602838B RID: 164747 RVA: 0x00B43CB0 File Offset: 0x00B41EB0
		public float GetAttributeValue(int attrId)
		{
			if (this.AttributeDict.Count > 0)
			{
				int num;
				return (float)(this.AttributeDict.TryGetValue(attrId, out num) ? num : 0);
			}
			List<SceneTeamItem> teamItems = SceneTeamModel.Instance.GetTeamItems(false);
			if (teamItems.Count <= 0)
			{
				return 0f;
			}
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(teamItems[0].GetConfigId, true);
			if (roleDataById == null)
			{
				return 0f;
			}
			return roleDataById.GetShowAttributeValueById(attrId);
		}

		// Token: 0x0602838C RID: 164748 RVA: 0x00B43D24 File Offset: 0x00B41F24
		public List<AttrListScrollData> GetShowAttrList()
		{
			if (this.AttributeDict.Count > 0)
			{
				List<AttrListScrollData> list = new List<AttrListScrollData>();
				IReadOnlyList<PropertyIndex> propertyIndexList = PropertyIndexConfig.Instance.GetPropertyIndexList();
				if (propertyIndexList == null)
				{
					return list;
				}
				foreach (PropertyIndex propertyIndex in propertyIndexList)
				{
					if (propertyIndex.IsShow)
					{
						int num2;
						int num = this.AttributeDict.TryGetValue(propertyIndex.Id, out num2) ? num2 : 0;
						list.Add(new RoleAttrListScrollData(propertyIndex.Id, (double)num, 0.0, propertyIndex.Priority, false, CommonComponentDefine.EAttributeType.NormalType));
					}
				}
				list.Sort((AttrListScrollData a, AttrListScrollData b) => a.Priority - b.Priority);
				return list;
			}
			else
			{
				List<SceneTeamItem> teamItems = SceneTeamModel.Instance.GetTeamItems(false);
				if (teamItems.Count <= 0)
				{
					return new List<AttrListScrollData>();
				}
				RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(teamItems[0].GetConfigId, true);
				if (roleDataById == null)
				{
					return new List<AttrListScrollData>();
				}
				return roleDataById.GetShowAttrList();
			}
		}

		// Token: 0x04015E18 RID: 89624
		public RogueGainEntry RoleEntry;

		// Token: 0x04015E19 RID: 89625
		[Nullable(2)]
		public RogueGainEntry PhantomEntry;

		// Token: 0x04015E1A RID: 89626
		public List<RogueGainEntry> BuffEntryList;

		// Token: 0x04015E1B RID: 89627
		public Dictionary<int, int> ElementDict;

		// Token: 0x04015E1C RID: 89628
		public List<RogueGainEntry> SpecialEntryList;

		// Token: 0x04015E1D RID: 89629
		public Dictionary<int, int> AttributeDict = new Dictionary<int, int>();
	}
}
