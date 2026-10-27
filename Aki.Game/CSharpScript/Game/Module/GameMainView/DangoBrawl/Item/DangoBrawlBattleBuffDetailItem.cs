using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.GameMainView.DangoBrawl.Item
{
	// Token: 0x02005A0C RID: 23052
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlBattleBuffDetailItem : GridProxyAbstract<DangoBrawlBattleBuffDetailItemData>
	{
		// Token: 0x0603A74A RID: 239434 RVA: 0x00DE88D4 File Offset: 0x00DE6AD4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603A74B RID: 239435 RVA: 0x00DE897F File Offset: 0x00DE6B7F
		protected override void OnStart()
		{
			ActivityDangoBrawlController.Instance.RegisterTermHyperlink(base.GetText(3));
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x0603A74C RID: 239436 RVA: 0x00DE89A4 File Offset: 0x00DE6BA4
		protected override void OnBeforeDestroy()
		{
			ActivityDangoBrawlController.Instance.UnRegisterTermHyperlink(base.GetText(3));
		}

		// Token: 0x0603A74D RID: 239437 RVA: 0x00DE89B8 File Offset: 0x00DE6BB8
		public override void Refresh(DangoBrawlBattleBuffDetailItemData data, bool isSelected, int gridIndex)
		{
			DangoBrawlBattleBuffItemData baseData = data.BaseData;
			DangoBrawlBuff? buffConfigById = DangoBrawlConfig.Instance.GetBuffConfigById(baseData.ConfigId);
			if (buffConfigById == null)
			{
				return;
			}
			base.SetTextureByPath(buffConfigById.Value.Icon, base.GetTexture(0), null, null);
			UUIText text = base.GetText(1);
			bool flag = buffConfigById.Value.BuffType == 1;
			string hexStr = flag ? "AAFF93" : "FF8888";
			string hexStr2 = flag ? "1F313B" : "391A1A";
			text.SetColor(FColor.FromHex(hexStr));
			text.SetFontOutlineColor(FColor.FromHex(hexStr2));
			text.SetText(baseData.FloorValue.ToString(), true);
			UUIText text2 = base.GetText(2);
			text2.SetColor(FColor.FromHex(buffConfigById.Value.NameColor));
			LguiUtil.Instance.SetLocalTextNew(text2, buffConfigById.Value.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), buffConfigById.Value.Desc, Array.Empty<object>());
			this.PlayTween(data.IsSelected);
		}

		// Token: 0x0603A74E RID: 239438 RVA: 0x00DE8AEC File Offset: 0x00DE6CEC
		public void PlayTween(bool isSelected)
		{
			string sequenceName = isSelected ? "SelectIn" : "SelectOut";
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayOrReplaySequenceByName(sequenceName, false, null);
		}

		// Token: 0x0603A74F RID: 239439 RVA: 0x00DE8B24 File Offset: 0x00DE6D24
		public override object GetKey(DangoBrawlBattleBuffDetailItemData data, int displayIndex)
		{
			return data.BaseData.ConfigId;
		}

		// Token: 0x0401E755 RID: 124757
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200BC72 RID: 48242
		[NullableContext(0)]
		private enum EComp
		{
			// Token: 0x04038DBC RID: 232892
			TexIcon,
			// Token: 0x04038DBD RID: 232893
			TxtFloorNum,
			// Token: 0x04038DBE RID: 232894
			TxtName,
			// Token: 0x04038DBF RID: 232895
			TxtDesc
		}
	}
}
