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
	// Token: 0x020049E8 RID: 18920
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlBattleBuffDetailItem : GridProxyAbstract<DangoBrawlBattleBuffDetailItemData>
	{
		// Token: 0x0602F693 RID: 194195 RVA: 0x00D38E54 File Offset: 0x00D37054
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

		// Token: 0x0602F694 RID: 194196 RVA: 0x00D38EFF File Offset: 0x00D370FF
		protected override void OnStart()
		{
			ActivityDangoBrawlController.Instance.RegisterTermHyperlink(base.GetText(3));
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x0602F695 RID: 194197 RVA: 0x00D38F24 File Offset: 0x00D37124
		protected override void OnBeforeDestroy()
		{
			ActivityDangoBrawlController.Instance.UnRegisterTermHyperlink(base.GetText(3));
		}

		// Token: 0x0602F696 RID: 194198 RVA: 0x00D38F38 File Offset: 0x00D37138
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

		// Token: 0x0602F697 RID: 194199 RVA: 0x00D3906C File Offset: 0x00D3726C
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

		// Token: 0x0602F698 RID: 194200 RVA: 0x00D390A4 File Offset: 0x00D372A4
		public override object GetKey(DangoBrawlBattleBuffDetailItemData data, int displayIndex)
		{
			return data.BaseData.ConfigId;
		}

		// Token: 0x040191FC RID: 102908
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200A67B RID: 42619
		[NullableContext(0)]
		private enum EComp
		{
			// Token: 0x04033788 RID: 210824
			TexIcon,
			// Token: 0x04033789 RID: 210825
			TxtFloorNum,
			// Token: 0x0403378A RID: 210826
			TxtName,
			// Token: 0x0403378B RID: 210827
			TxtDesc
		}
	}
}
