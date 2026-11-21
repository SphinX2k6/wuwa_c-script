using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DAC RID: 19884
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleSpecialEnergyBar
	{
		// Token: 0x06031F92 RID: 204690 RVA: 0x00DFBD10 File Offset: 0x00DF9F10
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

		// Token: 0x06031F93 RID: 204691 RVA: 0x00DFBD64 File Offset: 0x00DF9F64
		public void SetVisible(bool visible)
		{
			foreach (SpecialEnergyBarBase specialEnergyBarBase in this.EnergyBarMap.Values)
			{
				specialEnergyBarBase.SetVisible(visible, 0);
			}
		}

		// Token: 0x06031F94 RID: 204692 RVA: 0x00DFBDBC File Offset: 0x00DF9FBC
		public void Destroy()
		{
			this.ClearAllTagCountChangedCallback();
			foreach (SpecialEnergyBarBase specialEnergyBarBase in this.EnergyBarMap.Values)
			{
				specialEnergyBarBase.Destroy(null);
			}
			this.EnergyBarMap.Clear();
		}

		// Token: 0x06031F95 RID: 204693 RVA: 0x00DFBE24 File Offset: 0x00DFA024
		public void Tick(float delta)
		{
			foreach (SpecialEnergyBarBase specialEnergyBarBase in this.EnergyBarMap.Values)
			{
				specialEnergyBarBase.Tick(delta);
			}
		}

		// Token: 0x06031F96 RID: 204694 RVA: 0x00DFBE7C File Offset: 0x00DFA07C
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

		// Token: 0x06031F97 RID: 204695 RVA: 0x00DFBEF4 File Offset: 0x00DFA0F4
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

		// Token: 0x06031F98 RID: 204696 RVA: 0x00DFBF58 File Offset: 0x00DFA158
		private void OnTagChange(int tagId, bool tagExists)
		{
			this.RefreshVisibleByTag(true);
		}

		// Token: 0x06031F99 RID: 204697 RVA: 0x00DFBF64 File Offset: 0x00DFA164
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

		// Token: 0x06031F9A RID: 204698 RVA: 0x00DFC070 File Offset: 0x00DFA270
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

		// Token: 0x06031F9B RID: 204699 RVA: 0x00DFC0B4 File Offset: 0x00DFA2B4
		private void ClearAllTagCountChangedCallback()
		{
			foreach (ITagTask tagTask in this.TagTaskList)
			{
				tagTask.EndTask();
			}
			this.TagTaskList.Clear();
		}

		// Token: 0x0401A744 RID: 108356
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
			},
			{
				151202,
				typeof(SpecialEnergyBarLili)
			}
		};

		// Token: 0x0401A745 RID: 108357
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

		// Token: 0x0401A746 RID: 108358
		[Nullable(2)]
		private BattleUiRoleData RoleData;

		// Token: 0x0401A747 RID: 108359
		private readonly Dictionary<int, SpecialEnergyBarBase> EnergyBarMap = new Dictionary<int, SpecialEnergyBarBase>();

		// Token: 0x0401A748 RID: 108360
		private readonly List<ITagTask> TagTaskList = new List<ITagTask>();

		// Token: 0x0200AAD7 RID: 43735
		[NullableContext(0)]
		private enum EVisibleReason
		{
			// Token: 0x04034C8B RID: 216203
			Role,
			// Token: 0x04034C8C RID: 216204
			Tag
		}
	}
}
