using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x0200430C RID: 17164
	public class RogueResTrialTabItem : GridProxyAbstract<ERogueResTrialType>
	{
		// Token: 0x0602B636 RID: 177718 RVA: 0x00C32194 File Offset: 0x00C30394
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIGridLayout)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUISprite)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIItem))
			};
		}

		// Token: 0x0602B637 RID: 177719 RVA: 0x00C32246 File Offset: 0x00C30446
		protected override void OnStart()
		{
			this.Layout = new GenericLayout<RogueResTrialRoleItem, int>(base.GetGridLayout(2), new Func<RogueResTrialRoleItem>(this.InitRoleGrid), null, false, true);
		}

		// Token: 0x0602B638 RID: 177720 RVA: 0x00C3226C File Offset: 0x00C3046C
		public override void Refresh(ERogueResTrialType data, bool isSelected, int gridIndex)
		{
			List<int> trailRole = ActivityPermanentRogueModel.Instance.GetTrailRole(this.SeasonId, data);
			EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
			List<int> list = new List<int>();
			foreach (int num in trailRole)
			{
				int baseRoleId = RoleConfig.Instance.GetBaseRoleId(num);
				if (!RoleModel.Instance.IsMainRole(baseRoleId))
				{
					list.Add(num);
				}
				else if (RoleConfig.Instance.GetMainRoleById(baseRoleId).Value.Gender == (int)playerGender)
				{
					list.Add(num);
				}
			}
			GenericLayout<RogueResTrialRoleItem, int> layout = this.Layout;
			if (layout != null)
			{
				layout.RefreshByData(list, null, false);
			}
			FColor color = FColor.FromHex(<RogueResTrialPopView>FDADFB2A9BC14ABAED9384706B037305D07C2C04A563EB30B9F601FAE7EC4A498__TabColorMap.GetColor(data));
			UUISprite sprite = base.GetSprite(4);
			if (sprite != null)
			{
				sprite.SetColor(color);
			}
			FColor color2 = FColor.FromHex(<RogueResTrialPopView>FDADFB2A9BC14ABAED9384706B037305D07C2C04A563EB30B9F601FAE7EC4A498__TxtColorMap.GetColor(data));
			base.GetText(1).SetColor(color2);
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIText text = base.GetText(5);
			if (text != null)
			{
				text.SetUIActive(false);
			}
			if (data == ERogueResTrialType.Dynamic)
			{
				string trailRemainTime = ActivityPermanentRogueModel.Instance.GetTrailRemainTime(this.SeasonId);
				UUIText text2 = base.GetText(5);
				if (text2 != null)
				{
					text2.SetText(trailRemainTime, true);
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), <RogueResTrialPopView>FDADFB2A9BC14ABAED9384706B037305D07C2C04A563EB30B9F601FAE7EC4A498__TabTextMap.GetText(data), Array.Empty<object>());
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), <RogueResTrialPopView>FDADFB2A9BC14ABAED9384706B037305D07C2C04A563EB30B9F601FAE7EC4A498__TabTextMap.GetText(data), Array.Empty<object>());
		}

		// Token: 0x0602B639 RID: 177721 RVA: 0x00C323FC File Offset: 0x00C305FC
		[NullableContext(1)]
		private RogueResTrialRoleItem InitRoleGrid()
		{
			return new RogueResTrialRoleItem();
		}

		// Token: 0x04017704 RID: 96004
		public int SeasonId;

		// Token: 0x04017705 RID: 96005
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RogueResTrialRoleItem, int> Layout;
	}
}
