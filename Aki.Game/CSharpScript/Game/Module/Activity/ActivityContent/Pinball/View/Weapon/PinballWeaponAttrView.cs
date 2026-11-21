using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Weapon
{
	// Token: 0x02005259 RID: 21081
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballWeaponAttrView : UiPanelBase
	{
		// Token: 0x0603479A RID: 214938 RVA: 0x00EAF2FC File Offset: 0x00EAD4FC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603479B RID: 214939 RVA: 0x00EAF3C8 File Offset: 0x00EAD5C8
		protected override void OnStart()
		{
			this.PropLayout = new GenericLayout<PinballWeaponPropItemView, int>(base.GetVerticalLayout(1), new Func<PinballWeaponPropItemView>(this.CreatePropItem), null, false, true);
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x0603479C RID: 214940 RVA: 0x00EAF3FD File Offset: 0x00EAD5FD
		private PinballWeaponPropItemView CreatePropItem()
		{
			return new PinballWeaponPropItemView();
		}

		// Token: 0x0603479D RID: 214941 RVA: 0x00EAF404 File Offset: 0x00EAD604
		public void Refresh(PinballWeaponData data)
		{
			GenericLayout<PinballWeaponPropItemView, int> propLayout = this.PropLayout;
			if (propLayout != null)
			{
				propLayout.RefreshByData(data.PropList, null, false);
			}
			PinballWeaponMainEntry? pinballWeaponMainEntryConfigById = PinballConfig.Instance.GetPinballWeaponMainEntryConfigById(data.MainEntryId);
			if (pinballWeaponMainEntryConfigById == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PinballBattle;
				ELogAuthor author = ELogAuthor.CB;
				string message = "武器主词条配置不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", data.MainEntryId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(3), pinballWeaponMainEntryConfigById.Value.ProperDesc, pinballWeaponMainEntryConfigById.Value.ProperVal());
			PinballWeaponSubEntry? pinballWeaponSubEntryConfigById = PinballConfig.Instance.GetPinballWeaponSubEntryConfigById(data.SubEntryId);
			if (pinballWeaponSubEntryConfigById == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.PinballBattle;
				ELogAuthor author2 = ELogAuthor.CB;
				string message2 = "武器副词条配置不存在";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Id", data.SubEntryId);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(4), pinballWeaponSubEntryConfigById.Value.ProperDesc, pinballWeaponSubEntryConfigById.Value.ProperVal());
		}

		// Token: 0x0401BD75 RID: 114037
		protected GenericLayout<PinballWeaponPropItemView, int> PropLayout;

		// Token: 0x0200AEB2 RID: 44722
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04035F83 RID: 221059
			ScrollView,
			// Token: 0x04035F84 RID: 221060
			PropLayout,
			// Token: 0x04035F85 RID: 221061
			PropLayoutItem,
			// Token: 0x04035F86 RID: 221062
			TextMainEntry,
			// Token: 0x04035F87 RID: 221063
			TextSubEntry
		}
	}
}
