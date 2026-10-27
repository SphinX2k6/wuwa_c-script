using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200681E RID: 26654
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlLevelItem : GridProxyAbstract<DangoBrawlLevelData>
	{
		// Token: 0x1700973B RID: 38715
		// (get) Token: 0x06042824 RID: 272420 RVA: 0x01028DE3 File Offset: 0x01026FE3
		// (set) Token: 0x06042825 RID: 272421 RVA: 0x01028DEB File Offset: 0x01026FEB
		public DangoBrawlLevelData LevelData { get; private set; }

		// Token: 0x06042826 RID: 272422 RVA: 0x01028DF4 File Offset: 0x01026FF4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 15;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickLevel));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06042827 RID: 272423 RVA: 0x01029050 File Offset: 0x01027250
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.CanExecuteChange.Unbind();
			}
			if (extendToggle != null)
			{
				extendToggle.CanExecuteChange.Bind(new Func<bool>(this.OnCanExecuteChange));
			}
			UUITexture texture = base.GetTexture(2);
			if (texture != null)
			{
				texture.SetUIActive(true);
			}
			UUITexture texture2 = base.GetTexture(3);
			if (texture2 == null)
			{
				return;
			}
			texture2.SetUIActive(false);
		}

		// Token: 0x06042828 RID: 272424 RVA: 0x010290B8 File Offset: 0x010272B8
		[NullableContext(1)]
		public override void Refresh(DangoBrawlLevelData data, bool isSelected, int gridIndex)
		{
			this.LevelData = data;
			bool flag = data.BgStyle == EDangoBrawlLevelBgStyle.Adventure;
			this.IsFinalAdventure = (flag && data.IsLast);
			FColor color = FColor.FromHex(data.IsLocked ? "B2B2B2" : "FFFFFF");
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), data.SimpleName, Array.Empty<object>());
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(!flag);
			}
			UUIItem item2 = base.GetItem(4);
			if (item2 != null)
			{
				item2.SetUIActive(flag);
			}
			UUIItem item3 = base.GetItem(12);
			if (item3 != null)
			{
				item3.SetUIActive(!this.IsFinalAdventure);
			}
			UUIItem item4 = base.GetItem(13);
			if (item4 != null)
			{
				item4.SetUIActive(this.IsFinalAdventure);
			}
			UUIItem item5 = base.GetItem(9);
			if (item5 != null)
			{
				item5.SetUIActive(data.IsLocked);
			}
			UUIItem item6 = base.GetItem(8);
			if (item6 != null)
			{
				item6.SetUIActive(!data.IsLocked);
			}
			UUIItem item7 = base.GetItem(11);
			if (item7 != null)
			{
				item7.SetUIActive(data.IsPassed);
			}
			this.SetRedDotVisible(data.IsNew);
			if (flag)
			{
				UUISprite sprite = base.GetSprite(5);
				if (sprite != null)
				{
					sprite.SetUIActive(!data.IsLast);
				}
				UUISprite sprite2 = base.GetSprite(14);
				if (sprite2 != null)
				{
					sprite2.SetUIActive(data.IsLast);
				}
				UUISprite sprite3 = base.GetSprite(5);
				if (sprite3 != null)
				{
					sprite3.SetColor(color);
				}
				UUISprite sprite4 = base.GetSprite(14);
				if (sprite4 != null)
				{
					sprite4.SetColor(color);
				}
				UUISprite sprite5 = base.GetSprite(6);
				if (sprite5 != null)
				{
					sprite5.SetColor(color);
				}
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
				defaultInterpolatedStringHandler.AppendLiteral("SP_DangoBrawlRome");
				defaultInterpolatedStringHandler.AppendFormatted<int>(gridIndex + 1);
				string resourceId = defaultInterpolatedStringHandler.ToStringAndClear();
				string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
				this.SetSpriteByPath(resourcePath, base.GetSprite(6), false, null, null);
				if (this.IsFinalAdventure)
				{
					string resourcePath2 = UiResourceConfig.Instance.GetResourcePath("SP_DangoBrawlSwordHardSel");
					this.SetSpriteByPath(resourcePath2, base.GetSprite(14), false, null, null);
					return;
				}
			}
			else
			{
				base.SetTextureByPath(data.Icon, base.GetTexture(2), null, null);
				base.SetTextureByPath(data.SelIcon, base.GetTexture(3), null, null);
				UUITexture texture = base.GetTexture(2);
				if (texture != null)
				{
					texture.SetColor(color);
				}
				UUITexture texture2 = base.GetTexture(3);
				if (texture2 == null)
				{
					return;
				}
				texture2.SetColor(color);
			}
		}

		// Token: 0x06042829 RID: 272425 RVA: 0x01029331 File Offset: 0x01027531
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleState(true, fireEvent);
		}

		// Token: 0x0604282A RID: 272426 RVA: 0x0102933B File Offset: 0x0102753B
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleState(false, fireEvent);
		}

		// Token: 0x0604282B RID: 272427 RVA: 0x01029348 File Offset: 0x01027548
		private void SetToggleState(bool state, bool fireEvent)
		{
			EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleStateForce(state2, fireEvent, false, false);
			}
			UUITexture texture = base.GetTexture(2);
			if (texture != null)
			{
				texture.SetUIActive(!state);
			}
			UUITexture texture2 = base.GetTexture(3);
			if (texture2 == null)
			{
				return;
			}
			texture2.SetUIActive(state);
		}

		// Token: 0x0604282C RID: 272428 RVA: 0x0102939C File Offset: 0x0102759C
		private bool OnCanExecuteChange()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			return extendToggle == null || extendToggle.GetToggleState() != EToggleState.ETT_Checked;
		}

		// Token: 0x0604282D RID: 272429 RVA: 0x010293C2 File Offset: 0x010275C2
		public void SetRedDotVisible(bool isNew)
		{
			UUIItem item = base.GetItem(10);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(isNew);
		}

		// Token: 0x0604282E RID: 272430 RVA: 0x010293D7 File Offset: 0x010275D7
		private void OnClickLevel(EToggleState state)
		{
			if (this.LevelData == null)
			{
				return;
			}
			Action<DangoBrawlLevelItem> onClickToggleBack = this.OnClickToggleBack;
			if (onClickToggleBack == null)
			{
				return;
			}
			onClickToggleBack(this);
		}

		// Token: 0x04022A82 RID: 141954
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<DangoBrawlLevelItem> OnClickToggleBack;

		// Token: 0x04022A84 RID: 141956
		private bool IsFinalAdventure;

		// Token: 0x04022A85 RID: 141957
		[Nullable(1)]
		private const string DefaultColor = "FFFFFF";

		// Token: 0x04022A86 RID: 141958
		[Nullable(1)]
		private const string DarkColor = "B2B2B2";

		// Token: 0x0200C9B6 RID: 51638
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403CEEC RID: 249580
			Toggle,
			// Token: 0x0403CEED RID: 249581
			StoryModeItem,
			// Token: 0x0403CEEE RID: 249582
			TexLevelRole,
			// Token: 0x0403CEEF RID: 249583
			TexLevelRoleSelect,
			// Token: 0x0403CEF0 RID: 249584
			AdventureModeItem,
			// Token: 0x0403CEF1 RID: 249585
			SprSword,
			// Token: 0x0403CEF2 RID: 249586
			SprRomanNum,
			// Token: 0x0403CEF3 RID: 249587
			TxtLevelName,
			// Token: 0x0403CEF4 RID: 249588
			UnlockItem,
			// Token: 0x0403CEF5 RID: 249589
			LockItem,
			// Token: 0x0403CEF6 RID: 249590
			RedDotItem,
			// Token: 0x0403CEF7 RID: 249591
			FinishItem,
			// Token: 0x0403CEF8 RID: 249592
			NormalBgItem,
			// Token: 0x0403CEF9 RID: 249593
			SpecialBgItem,
			// Token: 0x0403CEFA RID: 249594
			SprSwordHard
		}
	}
}
