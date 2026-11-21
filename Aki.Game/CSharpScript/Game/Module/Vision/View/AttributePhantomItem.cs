using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Vision.View
{
	// Token: 0x020040CD RID: 16589
	public class AttributePhantomItem : UiPanelBase
	{
		// Token: 0x06029EF7 RID: 171767 RVA: 0x00BDAE3F File Offset: 0x00BD903F
		[NullableContext(1)]
		public AttributePhantomItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x06029EF8 RID: 171768 RVA: 0x00BDAE54 File Offset: 0x00BD9054
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.ClickButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06029EF9 RID: 171769 RVA: 0x00BDAF5D File Offset: 0x00BD915D
		private void ClickButton()
		{
			UiManager.Instance.OpenView(EUiViewName.PhantomBattleFettersObtainView, this.CurrentFetter, null);
		}

		// Token: 0x06029EFA RID: 171770 RVA: 0x00BDAF7C File Offset: 0x00BD917C
		public void Update(int monsterId, PhantomFetter fetterConfig)
		{
			this.CurrentFetter = new PhantomFetter?(fetterConfig);
			if (PhantomBattleModel.Instance.GetIfHasMonsterInInventory(monsterId))
			{
				base.GetTexture(1).SetUIActive(true);
				CalabashDevelopReward? calabashDevelopRewardByMonsterId = CalabashConfig.Instance.GetCalabashDevelopRewardByMonsterId(monsterId);
				string monsterIcon = MonsterInfoConfig.Instance.GetMonsterIcon(calabashDevelopRewardByMonsterId.Value.MonsterInfoId);
				base.SetTextureByPath(monsterIcon, base.GetTexture(1), new EUiViewName?(EUiViewName.VisionEquipmentView), null);
				RoleInstance curSelectMainRoleInstance = RoleModel.Instance.GetCurSelectMainRoleInstance();
				base.GetSprite(2).useChangeColor = false;
				base.GetSprite(3).SetUIActive(PhantomBattleController.Instance.CheckIsEquipByMonsterId(monsterId, curSelectMainRoleInstance.GetRoleId()));
				return;
			}
			base.GetTexture(1).SetUIActive(false);
			base.GetSprite(2).useChangeColor = true;
		}

		// Token: 0x04016DB9 RID: 93625
		private PhantomFetter? CurrentFetter;

		// Token: 0x02009C90 RID: 40080
		private enum EAttributePhantomItem
		{
			// Token: 0x04030B65 RID: 199525
			EmptySprite,
			// Token: 0x04030B66 RID: 199526
			Texture,
			// Token: 0x04030B67 RID: 199527
			BgSprite,
			// Token: 0x04030B68 RID: 199528
			EquipSprite,
			// Token: 0x04030B69 RID: 199529
			Button
		}
	}
}
