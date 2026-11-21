using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200576E RID: 22382
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlLevelItem : GridProxyAbstract<DangoBrawlLevelData>
	{
		// Token: 0x17006A7C RID: 27260
		// (get) Token: 0x06037379 RID: 226169 RVA: 0x00F6A327 File Offset: 0x00F68527
		// (set) Token: 0x0603737A RID: 226170 RVA: 0x00F6A32F File Offset: 0x00F6852F
		public DangoBrawlLevelData LevelData { get; private set; }

		// Token: 0x0603737B RID: 226171 RVA: 0x00F6A338 File Offset: 0x00F68538
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

		// Token: 0x0603737C RID: 226172 RVA: 0x00F6A594 File Offset: 0x00F68794
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

		// Token: 0x0603737D RID: 226173 RVA: 0x00F6A5FC File Offset: 0x00F687FC
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

		// Token: 0x0603737E RID: 226174 RVA: 0x00F6A875 File Offset: 0x00F68A75
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleState(true, fireEvent);
		}

		// Token: 0x0603737F RID: 226175 RVA: 0x00F6A87F File Offset: 0x00F68A7F
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleState(false, fireEvent);
		}

		// Token: 0x06037380 RID: 226176 RVA: 0x00F6A88C File Offset: 0x00F68A8C
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

		// Token: 0x06037381 RID: 226177 RVA: 0x00F6A8E0 File Offset: 0x00F68AE0
		private bool OnCanExecuteChange()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			return extendToggle == null || extendToggle.GetToggleState() != EToggleState.ETT_Checked;
		}

		// Token: 0x06037382 RID: 226178 RVA: 0x00F6A906 File Offset: 0x00F68B06
		public void SetRedDotVisible(bool isNew)
		{
			UUIItem item = base.GetItem(10);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(isNew);
		}

		// Token: 0x06037383 RID: 226179 RVA: 0x00F6A91B File Offset: 0x00F68B1B
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

		// Token: 0x0401D2DF RID: 119519
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<DangoBrawlLevelItem> OnClickToggleBack;

		// Token: 0x0401D2E1 RID: 119521
		private bool IsFinalAdventure;

		// Token: 0x0401D2E2 RID: 119522
		[Nullable(1)]
		private const string DefaultColor = "FFFFFF";

		// Token: 0x0401D2E3 RID: 119523
		[Nullable(1)]
		private const string DarkColor = "B2B2B2";

		// Token: 0x0200B383 RID: 45955
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x040377D9 RID: 227289
			Toggle,
			// Token: 0x040377DA RID: 227290
			StoryModeItem,
			// Token: 0x040377DB RID: 227291
			TexLevelRole,
			// Token: 0x040377DC RID: 227292
			TexLevelRoleSelect,
			// Token: 0x040377DD RID: 227293
			AdventureModeItem,
			// Token: 0x040377DE RID: 227294
			SprSword,
			// Token: 0x040377DF RID: 227295
			SprRomanNum,
			// Token: 0x040377E0 RID: 227296
			TxtLevelName,
			// Token: 0x040377E1 RID: 227297
			UnlockItem,
			// Token: 0x040377E2 RID: 227298
			LockItem,
			// Token: 0x040377E3 RID: 227299
			RedDotItem,
			// Token: 0x040377E4 RID: 227300
			FinishItem,
			// Token: 0x040377E5 RID: 227301
			NormalBgItem,
			// Token: 0x040377E6 RID: 227302
			SpecialBgItem,
			// Token: 0x040377E7 RID: 227303
			SprSwordHard
		}
	}
}
