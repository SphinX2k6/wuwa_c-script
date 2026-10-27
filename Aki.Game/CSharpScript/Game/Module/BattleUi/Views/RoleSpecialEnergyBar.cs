using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DC8 RID: 24008
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleSpecialEnergyBar
	{
		// Token: 0x0603D01B RID: 249883 RVA: 0x00EAAE34 File Offset: 0x00EA9034
		public UniTask InitAsync(UUIItem parentItem, BattleUiRoleData roleData)
		{
			RoleSpecialEnergyBar.<InitAsync>d__6 <InitAsync>d__;
			<InitAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitAsync>d__.<>4__this = this;
			<InitAsync>d__.parentItem = parentItem;
			<InitAsync>d__.roleData = roleData;
			<InitAsync>d__.<>1__state = -1;
			<InitAsync>d__.<>t__builder.Start<RoleSpecialEnergyBar.<InitAsync>d__6>(ref <InitAsync>d__);
			return <InitAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D01C RID: 249884 RVA: 0x00EAAE88 File Offset: 0x00EA9088
		public void SetVisible(bool visible)
		{
			foreach (SpecialEnergyBarBase specialEnergyBarBase in this.EnergyBarMap.Values)
			{
				specialEnergyBarBase.SetVisible(visible, 0);
			}
		}

		// Token: 0x0603D01D RID: 249885 RVA: 0x00EAAEE0 File Offset: 0x00EA90E0
		public void Destroy()
		{
			this.ClearAllTagCountChangedCallback();
			foreach (SpecialEnergyBarBase specialEnergyBarBase in this.EnergyBarMap.Values)
			{
				specialEnergyBarBase.Destroy(null);
			}
			this.EnergyBarMap.Clear();
		}

		// Token: 0x0603D01E RID: 249886 RVA: 0x00EAAF48 File Offset: 0x00EA9148
		public void Tick(float delta)
		{
			foreach (SpecialEnergyBarBase specialEnergyBarBase in this.EnergyBarMap.Values)
			{
				specialEnergyBarBase.Tick(delta);
			}
		}

		// Token: 0x0603D01F RID: 249887 RVA: 0x00EAAFA0 File Offset: 0x00EA91A0
		[NullableContext(2)]
		private SpecialEnergyBarInfo GetSpecialEnergyBarConfigByRoleData(BattleUiRoleData roleData)
		{
			bool flag;
			if (roleData == null)
			{
				flag = true;
			}
			else
			{
				EntityHandle entityHandle = roleData.EntityHandle;
				flag = !((entityHandle != null) ? new bool?(entityHandle.Valid) : null).GetValueOrDefault();
			}
			if (flag)
			{
				return null;
			}
			RoleInfo? roleConfig = roleData.RoleConfig;
			if (roleConfig == null)
			{
				return null;
			}
			int specialEnergyBarId = roleConfig.Value.SpecialEnergyBarId;
			if (specialEnergyBarId == 0)
			{
				return null;
			}
			return BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(specialEnergyBarId);
		}

		// Token: 0x0603D020 RID: 249888 RVA: 0x00EAB018 File Offset: 0x00EA9218
		private UniTask LoadByConfig(UUIItem parentItem, BattleUiRoleData roleData, int tagId, SpecialEnergyBarInfo config)
		{
			RoleSpecialEnergyBar.<LoadByConfig>d__11 <LoadByConfig>d__;
			<LoadByConfig>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadByConfig>d__.<>4__this = this;
			<LoadByConfig>d__.parentItem = parentItem;
			<LoadByConfig>d__.roleData = roleData;
			<LoadByConfig>d__.tagId = tagId;
			<LoadByConfig>d__.config = config;
			<LoadByConfig>d__.<>1__state = -1;
			<LoadByConfig>d__.<>t__builder.Start<RoleSpecialEnergyBar.<LoadByConfig>d__11>(ref <LoadByConfig>d__);
			return <LoadByConfig>d__.<>t__builder.Task;
		}

		// Token: 0x0603D021 RID: 249889 RVA: 0x00EAB07C File Offset: 0x00EA927C
		private void OnTagChange(int tagId, bool tagExists)
		{
			this.RefreshVisibleByTag(true);
		}

		// Token: 0x0603D022 RID: 249890 RVA: 0x00EAB088 File Offset: 0x00EA9288
		private void RefreshVisibleByTag(bool isTagChange = false)
		{
			if (this.EnergyBarMap.Count > 1)
			{
				BattleUiRoleData roleData = this.RoleData;
				BaseTagComponent baseTagComponent = (roleData != null) ? roleData.GameplayTagComponent : null;
				int num = 0;
				foreach (int num2 in this.EnergyBarMap.Keys)
				{
					if (num2 != 0 && baseTagComponent != null && baseTagComponent.HasTag(num2))
					{
						num = num2;
						break;
					}
				}
				foreach (KeyValuePair<int, SpecialEnergyBarBase> keyValuePair in this.EnergyBarMap)
				{
					int num3;
					SpecialEnergyBarBase specialEnergyBarBase;
					keyValuePair.Deconstruct(out num3, out specialEnergyBarBase);
					int num4 = num3;
					SpecialEnergyBarBase specialEnergyBarBase2 = specialEnergyBarBase;
					bool flag = num4 == num;
					specialEnergyBarBase2.SetVisible(flag, 1);
					if (isTagChange)
					{
						specialEnergyBarBase2.OnChangeVisibleByTagChange(flag);
					}
				}
				return;
			}
			SpecialEnergyBarBase valueOrDefault = this.EnergyBarMap.GetValueOrDefault(0);
			if (valueOrDefault == null)
			{
				return;
			}
			valueOrDefault.SetVisible(true, 1);
		}

		// Token: 0x0603D023 RID: 249891 RVA: 0x00EAB194 File Offset: 0x00EA9394
		private void ListenForTagAddOrRemove(int tagId, BaseTagComponent.TTagSwitchedCallback onTagChange)
		{
			BattleUiRoleData roleData = this.RoleData;
			ITagTask tagTask;
			if (roleData == null)
			{
				tagTask = null;
			}
			else
			{
				BaseTagComponent gameplayTagComponent = roleData.GameplayTagComponent;
				tagTask = ((gameplayTagComponent != null) ? gameplayTagComponent.ListenForTagAddOrRemove(new int?(tagId), onTagChange, null) : null);
			}
			ITagTask tagTask2 = tagTask;
			if (tagTask2 != null)
			{
				this.TagTaskList.Add(tagTask2);
			}
		}

		// Token: 0x0603D024 RID: 249892 RVA: 0x00EAB1D8 File Offset: 0x00EA93D8
		private void ClearAllTagCountChangedCallback()
		{
			foreach (ITagTask tagTask in this.TagTaskList)
			{
				tagTask.EndTask();
			}
			this.TagTaskList.Clear();
		}

		// Token: 0x0401FC87 RID: 130183
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<int, Type> SpecialEnergyBarClassMap = new Dictionary<int, Type>
		{
			{
				11,
				typeof(SpecialEnergyBarChun)
			},
			{
				150402,
				typeof(SpecialEnergyBarDengDeng)
			},
			{
				110701,
				typeof(SpecialEnergyBarKeLaiTa)
			},
			{
				110702,
				typeof(SpecialEnergyBarKeLaiTaUltra)
			},
			{
				160600,
				typeof(SpecialEnergyBarLuoKeKe)
			},
			{
				120600,
				typeof(SpecialEnergyBarBuLanTe)
			},
			{
				150601,
				typeof(SpecialEnergyBarFeibi)
			},
			{
				160700,
				typeof(SpecialEnergyBarKanTeLeiLa)
			},
			{
				140600,
				typeof(SpecialEnergyBarWind)
			},
			{
				140700,
				typeof(SpecialEnergyBarXiaKong)
			},
			{
				150700,
				typeof(SpecialEnergyBarZanni)
			},
			{
				120700,
				typeof(SpecialEnergyBarLuPa)
			},
			{
				140900,
				typeof(SpecialEnergyBarKaTiXiYa)
			},
			{
				502100,
				typeof(SpecialEnergyBarMorphPlayUse)
			},
			{
				160800,
				typeof(SpecialEnergyBarFuLuoLuo)
			},
			{
				141000,
				typeof(SpecialEnergyBarYouNuo)
			},
			{
				130600,
				typeof(SpecialEnergyBarAoGuSiTa)
			},
			{
				141100,
				typeof(SpecialEnergyBarQiuYuan)
			},
			{
				120800,
				typeof(SpecialEnergyBarJiaBeiLiNa)
			},
			{
				130700,
				typeof(SpecialEnergyBarBuLing)
			},
			{
				121000,
				typeof(SpecialEnergyBarAiMiSi)
			},
			{
				150800,
				typeof(SpecialEnergyBarQianXiao)
			},
			{
				120900,
				typeof(SpecialEnergyBarMoNing)
			},
			{
				150900,
				typeof(SpecialEnergyBarLinNai)
			},
			{
				151001,
				typeof(SpecialEnergyBarLuhes)
			},
			{
				151100,
				typeof(SpecialEnergyBarLuXi)
			},
			{
				110801,
				typeof(SpecialEnergyBarFeiXue)
			},
			{
				110901,
				typeof(SpecialEnergyBarLuosela)
			},
			{
				800400,
				typeof(SpecialEnergyBarSuizhe)
			},
			{
				121101,
				typeof(SpecialEnergyBarDaniya)
			},
			{
				130800,
				typeof(SpecialEnergyBarRuibeika)
			},
			{
				141200,
				typeof(SpecialEnergyBarXigelika)
			},
			{
				130900,
				typeof(SpecialEnergyBarThunder)
			},
			{
				161001,
				typeof(SpecialEnergyBarXuanling)
			},
			{
				111001,
				typeof(SpecialEnergyBarSuisui)
			},
			{
				141300,
				typeof(SpecialEnergyBarQingXiao)
			},
			{
				121201,
				typeof(SpecialEnergyBarJingRan)
			},
			{
				131200,
				typeof(SpecialEnergyBarSuoMing)
			},
			{
				131100,
				typeof(SpecialEnergyBarXinYueHu)
			}
		};

		// Token: 0x0401FC88 RID: 130184
		[StaticVariableRuleIgnore]
		private static readonly Type[] SpecialEnergyBarClassList = new Type[]
		{
			typeof(SpecialEnergyBarPoint),
			typeof(SpecialEnergyBarSlot),
			typeof(SpecialEnergyBarPointGraduate),
			typeof(SpecialEnergyBarMorph),
			typeof(SpecialEnergyBarMorph),
			typeof(SpecialEnergyBarMorphCountDown),
			typeof(SpecialEnergyBarJianXin),
			typeof(SpecialEnergyBarSanHua),
			typeof(SpecialEnergyBarChiXia),
			typeof(SpecialEnergyBarMorphCountDown),
			typeof(SpecialEnergyBarMorphJinXi),
			typeof(SpecialEnergyBarXiangLiYao),
			typeof(SpecialEnergyBarZheZhi)
		};

		// Token: 0x0401FC89 RID: 130185
		[Nullable(2)]
		private BattleUiRoleData RoleData;

		// Token: 0x0401FC8A RID: 130186
		private readonly Dictionary<int, SpecialEnergyBarBase> EnergyBarMap = new Dictionary<int, SpecialEnergyBarBase>();

		// Token: 0x0401FC8B RID: 130187
		private readonly List<ITagTask> TagTaskList = new List<ITagTask>();

		// Token: 0x0200C0CE RID: 49358
		[NullableContext(0)]
		private enum EVisibleReason
		{
			// Token: 0x0403A2B9 RID: 238265
			Role,
			// Token: 0x0403A2BA RID: 238266
			Tag
		}
	}
}
