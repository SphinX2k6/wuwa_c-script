using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Vision.View
{
	// Token: 0x020050FD RID: 20733
	public class AttributePhantomItem : UiPanelBase
	{
		// Token: 0x06034FFE RID: 217086 RVA: 0x00C8DB63 File Offset: 0x00C8BD63
		[NullableContext(1)]
		public AttributePhantomItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x06034FFF RID: 217087 RVA: 0x00C8DB78 File Offset: 0x00C8BD78
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

		// Token: 0x06035000 RID: 217088 RVA: 0x00C8DC81 File Offset: 0x00C8BE81
		private void ClickButton()
		{
			UiManager.Instance.OpenView(EUiViewName.PhantomBattleFettersObtainView, this.CurrentFetter, null);
		}

		// Token: 0x06035001 RID: 217089 RVA: 0x00C8DCA0 File Offset: 0x00C8BEA0
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

		// Token: 0x0401C386 RID: 115590
		private PhantomFetter? CurrentFetter;

		// Token: 0x0200B257 RID: 45655
		private enum EAttributePhantomItem
		{
			// Token: 0x04036110 RID: 221456
			EmptySprite,
			// Token: 0x04036111 RID: 221457
			Texture,
			// Token: 0x04036112 RID: 221458
			BgSprite,
			// Token: 0x04036113 RID: 221459
			EquipSprite,
			// Token: 0x04036114 RID: 221460
			Button
		}
	}
}
