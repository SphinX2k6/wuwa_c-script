using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200508A RID: 20618
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeGeneralObtainView : RoverlikeActionViewBase
	{
		// Token: 0x060339A7 RID: 211367 RVA: 0x00E71A00 File Offset: 0x00E6FC00
		public RoverlikeGeneralObtainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060339A8 RID: 211368 RVA: 0x00E71A14 File Offset: 0x00E6FC14
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

		// Token: 0x060339A9 RID: 211369 RVA: 0x00E71BC4 File Offset: 0x00E6FDC4
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

		// Token: 0x060339AA RID: 211370 RVA: 0x00E71C1C File Offset: 0x00E6FE1C
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

		// Token: 0x060339AB RID: 211371 RVA: 0x00E71DB4 File Offset: 0x00E6FFB4
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

		// Token: 0x060339AC RID: 211372 RVA: 0x00E71E70 File Offset: 0x00E70070
		private void PlayObtainTransition(bool isLose)
		{
			base.PlayOrReplaySequence(isLose ? "Lose" : "Get", false, null);
		}

		// Token: 0x060339AD RID: 211373 RVA: 0x00E71E9C File Offset: 0x00E7009C
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

		// Token: 0x060339AE RID: 211374 RVA: 0x00E71F44 File Offset: 0x00E70144
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

		// Token: 0x060339AF RID: 211375 RVA: 0x00E71FCC File Offset: 0x00E701CC
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

		// Token: 0x060339B0 RID: 211376 RVA: 0x00E7200B File Offset: 0x00E7020B
		private void OnBtnCloseClick()
		{
			this.RefreshObtainList(true);
		}

		// Token: 0x0401B62B RID: 112171
		[Nullable(2)]
		private MultiTemplateComponent MultiList;

		// Token: 0x0401B62C RID: 112172
		private readonly List<IMultiTemplateGridData> ScrollDataList = new List<IMultiTemplateGridData>();

		// Token: 0x0200AD45 RID: 44357
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040358C8 RID: 219336
			public const int BtnClose = 0;

			// Token: 0x040358C9 RID: 219337
			public const int TxtTitle = 1;

			// Token: 0x040358CA RID: 219338
			public const int Layout = 2;

			// Token: 0x040358CB RID: 219339
			public const int ItemBlessTemplate = 3;

			// Token: 0x040358CC RID: 219340
			public const int ItemReinforcementTemplate = 4;

			// Token: 0x040358CD RID: 219341
			public const int ItemPropTemplate = 5;

			// Token: 0x040358CE RID: 219342
			public const int TexBg = 6;

			// Token: 0x040358CF RID: 219343
			public const int SpriteDecoration1 = 7;

			// Token: 0x040358D0 RID: 219344
			public const int SpriteDecoration2 = 8;

			// Token: 0x040358D1 RID: 219345
			public const int SpriteDecoration3 = 9;
		}

		// Token: 0x0200AD46 RID: 44358
		[NullableContext(0)]
		private enum ETemplateIndex
		{
			// Token: 0x040358D3 RID: 219347
			Bless,
			// Token: 0x040358D4 RID: 219348
			Prop,
			// Token: 0x040358D5 RID: 219349
			Reinforcement
		}

		// Token: 0x0200AD47 RID: 44359
		[NullableContext(0)]
		private enum EObtainSequence
		{
			// Token: 0x040358D7 RID: 219351
			Get,
			// Token: 0x040358D8 RID: 219352
			Lose
		}

		// Token: 0x0200AD48 RID: 44360
		[Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		private class AttributeGridData : MultiTemplateGridDataBase<IRoverlikeBlessingItemData, RoverlikeBlessingCardItem>
		{
			// Token: 0x06046D05 RID: 290053 RVA: 0x0156295E File Offset: 0x01560B5E
			public override int GetTemplateIndex()
			{
				return 0;
			}

			// Token: 0x06046D06 RID: 290054 RVA: 0x01562961 File Offset: 0x01560B61
			public override RoverlikeBlessingCardItem CreateProxy()
			{
				return new RoverlikeBlessingCardItem();
			}
		}

		// Token: 0x0200AD49 RID: 44361
		[Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		private class PropGridData : MultiTemplateGridDataBase<IRoverlikePropItemData, RoverlikePropCardItem>
		{
			// Token: 0x06046D08 RID: 290056 RVA: 0x01562970 File Offset: 0x01560B70
			public override int GetTemplateIndex()
			{
				return 1;
			}

			// Token: 0x06046D09 RID: 290057 RVA: 0x01562973 File Offset: 0x01560B73
			public override RoverlikePropCardItem CreateProxy()
			{
				return new RoverlikePropCardItem();
			}
		}

		// Token: 0x0200AD4A RID: 44362
		[Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		private class ReinforcementGridData : MultiTemplateGridDataBase<IRoverlikeReinforcementItemData, RoverlikeReinforcementCardItem>
		{
			// Token: 0x06046D0B RID: 290059 RVA: 0x01562982 File Offset: 0x01560B82
			public override int GetTemplateIndex()
			{
				return 2;
			}

			// Token: 0x06046D0C RID: 290060 RVA: 0x01562985 File Offset: 0x01560B85
			public override RoverlikeReinforcementCardItem CreateProxy()
			{
				return new RoverlikeReinforcementCardItem();
			}
		}
	}
}
