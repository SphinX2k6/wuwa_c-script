using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200610C RID: 24844
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeGeneralObtainView : RoverlikeActionViewBase
	{
		// Token: 0x0603ECE5 RID: 257253 RVA: 0x00F2ABEC File Offset: 0x00F28DEC
		public RoverlikeGeneralObtainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603ECE6 RID: 257254 RVA: 0x00F2AC00 File Offset: 0x00F28E00
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnCloseClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603ECE7 RID: 257255 RVA: 0x00F2ADB0 File Offset: 0x00F28FB0
		protected override void OnStart()
		{
			Dictionary<int, UUIItem> dictionary = new Dictionary<int, UUIItem>();
			dictionary[0] = base.GetItem(3);
			dictionary[2] = base.GetItem(4);
			dictionary[1] = base.GetItem(5);
			Dictionary<int, UUIItem> templateItems = dictionary;
			this.MultiList = new MultiTemplateComponent(base.GetItem(2), templateItems);
			this.RefreshObtainList(false);
		}

		// Token: 0x0603ECE8 RID: 257256 RVA: 0x00F2AE08 File Offset: 0x00F29008
		private List<IMultiTemplateGridData> BuildDataList(List<RoverlikeGainEntry> entries)
		{
			List<IMultiTemplateGridData> list = new List<IMultiTemplateGridData>();
			foreach (RoverlikeGainEntry roverlikeGainEntry in entries)
			{
				switch (roverlikeGainEntry.Type)
				{
				case RoverRogueGainDataType.RoverRogueGainBless:
				{
					RoverlikeBlessingItemData data = new RoverlikeBlessingItemData
					{
						BlessId = roverlikeGainEntry.ConfigId,
						IncId = new int?(roverlikeGainEntry.IncId),
						AllowToggleInteract = new bool?(false)
					};
					list.Add(new RoverlikeGeneralObtainView.AttributeGridData
					{
						Data = data
					});
					continue;
				}
				case RoverRogueGainDataType.RoverRogueGainRoleEnhance:
				{
					RoverlikeReinforcementItemData data2 = new RoverlikeReinforcementItemData
					{
						ConfigId = roverlikeGainEntry.ConfigId,
						IncId = new int?(roverlikeGainEntry.IncId),
						AllowToggleInteract = new bool?(false)
					};
					list.Add(new RoverlikeGeneralObtainView.ReinforcementGridData
					{
						Data = data2
					});
					continue;
				}
				case RoverRogueGainDataType.RoverRogueGainItem:
				{
					RoverlikePropItemData data3 = new RoverlikePropItemData
					{
						ConfigId = roverlikeGainEntry.ConfigId,
						IncId = new int?(roverlikeGainEntry.IncId),
						IsInGame = true
					};
					list.Add(new RoverlikeGeneralObtainView.PropGridData
					{
						Data = data3
					});
					continue;
				}
				}
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Roverlike;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[俯视角肉鸽] 通用获得界面不支持该类型Entry";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", roverlikeGainEntry.Type);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return list;
		}

		// Token: 0x0603ECE9 RID: 257257 RVA: 0x00F2AFA0 File Offset: 0x00F291A0
		public void RefreshObtainList(bool isFirst = true)
		{
			IRoverlikeGeneralObtainParam roverlikeGeneralObtainParam = RoverlikeModel.Instance.ActionData.PopObtainParam();
			if (roverlikeGeneralObtainParam == null)
			{
				base.CloseMe(null);
				return;
			}
			this.ScrollDataList.Clear();
			this.ScrollDataList.AddRange(this.BuildDataList(roverlikeGeneralObtainParam.Entries));
			this.RefreshAnim(roverlikeGeneralObtainParam.IsLose);
			MultiTemplateComponent multiList = this.MultiList;
			if (multiList != null)
			{
				multiList.RefreshByData(this.ScrollDataList, true);
			}
			this.RefreshStyle(roverlikeGeneralObtainParam.IsLose);
			this.RefreshTitle(roverlikeGeneralObtainParam.IsLose, roverlikeGeneralObtainParam.Entries);
			if (isFirst)
			{
				this.PlayObtainTransition(roverlikeGeneralObtainParam.IsLose);
				return;
			}
			this.UiViewSequence.StartSequenceName = (roverlikeGeneralObtainParam.IsLose ? "StartLose" : "StartGet");
		}

		// Token: 0x0603ECEA RID: 257258 RVA: 0x00F2B05C File Offset: 0x00F2925C
		private void PlayObtainTransition(bool isLose)
		{
			base.PlayOrReplaySequence(isLose ? "Lose" : "Get", false, null);
		}

		// Token: 0x0603ECEB RID: 257259 RVA: 0x00F2B088 File Offset: 0x00F29288
		private void RefreshStyle(bool isLose)
		{
			UUITexture texture = base.GetTexture(6);
			UUIItem uuiitem = texture;
			FColor? fcolor = new FColor?(texture.changeColor);
			uuiitem.SetChangeColor(isLose, fcolor);
			UUISprite sprite = base.GetSprite(7);
			UUIItem uuiitem2 = sprite;
			fcolor = new FColor?(sprite.changeColor);
			uuiitem2.SetChangeColor(isLose, fcolor);
			UUISprite sprite2 = base.GetSprite(8);
			UUIItem uuiitem3 = sprite2;
			fcolor = new FColor?(sprite2.changeColor);
			uuiitem3.SetChangeColor(isLose, fcolor);
			UUISprite sprite3 = base.GetSprite(9);
			UUIItem uuiitem4 = sprite3;
			fcolor = new FColor?(sprite3.changeColor);
			uuiitem4.SetChangeColor(isLose, fcolor);
			UUIText text = base.GetText(1);
			UUIItem uuiitem5 = text;
			fcolor = new FColor?(text.changeColor);
			uuiitem5.SetChangeColor(isLose, fcolor);
		}

		// Token: 0x0603ECEC RID: 257260 RVA: 0x00F2B130 File Offset: 0x00F29330
		private void RefreshTitle(bool isLose, List<RoverlikeGainEntry> entries)
		{
			string textStringId = "";
			switch (entries[0].Type)
			{
			case RoverRogueGainDataType.RoverRogueGainBless:
				textStringId = (isLose ? "RoverRogue_HintLoseBlessing" : "RoverRogue_HintGetBlessing");
				break;
			case RoverRogueGainDataType.RoverRogueGainRoleEnhance:
				textStringId = (isLose ? "RoverRogue_HintLoseHint" : "RoverRogue_HintGetHint");
				break;
			case RoverRogueGainDataType.RoverRogueGainItem:
				textStringId = (isLose ? "RoverRogue_HintLoseItem" : "RoverRogue_HintGetItem");
				break;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, Array.Empty<object>());
		}

		// Token: 0x0603ECED RID: 257261 RVA: 0x00F2B1B8 File Offset: 0x00F293B8
		private void RefreshAnim(bool isLose)
		{
			MultiTemplateComponent multiList = this.MultiList;
			UUIInturnAnimController uuiinturnAnimController = (multiList != null) ? multiList.GetUiAnimController() : null;
			if (uuiinturnAnimController != null)
			{
				uuiinturnAnimController.AnimName = (isLose ? "Start2" : "Start");
				uuiinturnAnimController.PlayFromIndex = 0;
			}
		}

		// Token: 0x0603ECEE RID: 257262 RVA: 0x00F2B1F7 File Offset: 0x00F293F7
		private void OnBtnCloseClick()
		{
			this.RefreshObtainList(true);
		}

		// Token: 0x04020CFE RID: 134398
		[Nullable(2)]
		private MultiTemplateComponent MultiList;

		// Token: 0x04020CFF RID: 134399
		private readonly List<IMultiTemplateGridData> ScrollDataList = new List<IMultiTemplateGridData>();

		// Token: 0x0200C35D RID: 50013
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403AF63 RID: 241507
			public const int BtnClose = 0;

			// Token: 0x0403AF64 RID: 241508
			public const int TxtTitle = 1;

			// Token: 0x0403AF65 RID: 241509
			public const int Layout = 2;

			// Token: 0x0403AF66 RID: 241510
			public const int ItemBlessTemplate = 3;

			// Token: 0x0403AF67 RID: 241511
			public const int ItemReinforcementTemplate = 4;

			// Token: 0x0403AF68 RID: 241512
			public const int ItemPropTemplate = 5;

			// Token: 0x0403AF69 RID: 241513
			public const int TexBg = 6;

			// Token: 0x0403AF6A RID: 241514
			public const int SpriteDecoration1 = 7;

			// Token: 0x0403AF6B RID: 241515
			public const int SpriteDecoration2 = 8;

			// Token: 0x0403AF6C RID: 241516
			public const int SpriteDecoration3 = 9;
		}

		// Token: 0x0200C35E RID: 50014
		[NullableContext(0)]
		private enum ETemplateIndex
		{
			// Token: 0x0403AF6E RID: 241518
			Bless,
			// Token: 0x0403AF6F RID: 241519
			Prop,
			// Token: 0x0403AF70 RID: 241520
			Reinforcement
		}

		// Token: 0x0200C35F RID: 50015
		[NullableContext(0)]
		private enum EObtainSequence
		{
			// Token: 0x0403AF72 RID: 241522
			Get,
			// Token: 0x0403AF73 RID: 241523
			Lose
		}

		// Token: 0x0200C360 RID: 50016
		[Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		private class AttributeGridData : MultiTemplateGridDataBase<IRoverlikeBlessingItemData, RoverlikeBlessingCardItem>
		{
			// Token: 0x06050818 RID: 329752 RVA: 0x015AAC56 File Offset: 0x015A8E56
			public override int GetTemplateIndex()
			{
				return 0;
			}

			// Token: 0x06050819 RID: 329753 RVA: 0x015AAC59 File Offset: 0x015A8E59
			public override RoverlikeBlessingCardItem CreateProxy()
			{
				return new RoverlikeBlessingCardItem();
			}
		}

		// Token: 0x0200C361 RID: 50017
		[Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		private class PropGridData : MultiTemplateGridDataBase<IRoverlikePropItemData, RoverlikePropCardItem>
		{
			// Token: 0x0605081B RID: 329755 RVA: 0x015AAC68 File Offset: 0x015A8E68
			public override int GetTemplateIndex()
			{
				return 1;
			}

			// Token: 0x0605081C RID: 329756 RVA: 0x015AAC6B File Offset: 0x015A8E6B
			public override RoverlikePropCardItem CreateProxy()
			{
				return new RoverlikePropCardItem();
			}
		}

		// Token: 0x0200C362 RID: 50018
		[Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		private class ReinforcementGridData : MultiTemplateGridDataBase<IRoverlikeReinforcementItemData, RoverlikeReinforcementCardItem>
		{
			// Token: 0x0605081E RID: 329758 RVA: 0x015AAC7A File Offset: 0x015A8E7A
			public override int GetTemplateIndex()
			{
				return 2;
			}

			// Token: 0x0605081F RID: 329759 RVA: 0x015AAC7D File Offset: 0x015A8E7D
			public override RoverlikeReinforcementCardItem CreateProxy()
			{
				return new RoverlikeReinforcementCardItem();
			}
		}
	}
}
