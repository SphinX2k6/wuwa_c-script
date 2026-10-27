using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Weapon
{
	// Token: 0x020062DC RID: 25308
	public class PinballWeaponPropItemView : GridProxyAbstract<int>
	{
		// Token: 0x0603FADE RID: 260830 RVA: 0x00F685D8 File Offset: 0x00F667D8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603FADF RID: 260831 RVA: 0x00F68684 File Offset: 0x00F66884
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			PinballWeaponAttr? pinballWeaponAttrConfigById = PinballConfig.Instance.GetPinballWeaponAttrConfigById(data);
			if (pinballWeaponAttrConfigById == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PinballBattle;
				ELogAuthor author = ELogAuthor.CB;
				string message = "武器属性配置不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", data);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			PinballPropertyIndex? pinballPropertyIndexConfigById = PinballConfig.Instance.GetPinballPropertyIndexConfigById(pinballWeaponAttrConfigById.Value.ProperKey);
			if (pinballPropertyIndexConfigById == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.PinballBattle;
				ELogAuthor author2 = ELogAuthor.CB;
				string message2 = "属性索引配置不存在";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Id", pinballWeaponAttrConfigById.Value.ProperKey);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(0), pinballPropertyIndexConfigById.Value.Name, Array.Empty<object>());
			string text;
			if (!pinballPropertyIndexConfigById.Value.IsPercent)
			{
				text = pinballWeaponAttrConfigById.Value.ProperVal.ToString();
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendFormatted<float>(pinballWeaponAttrConfigById.Value.ProperVal);
				defaultInterpolatedStringHandler.AppendLiteral("%");
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			string newText = text;
			UUIText text2 = base.GetText(1);
			if (text2 != null)
			{
				text2.SetText(newText, true);
			}
			base.TrySetTextureByPath(pinballPropertyIndexConfigById.Value.Icon, base.GetTexture(2), null, null);
		}

		// Token: 0x0603FAE0 RID: 260832 RVA: 0x00F687FC File Offset: 0x00F669FC
		public override void Clear()
		{
		}

		// Token: 0x0603FAE1 RID: 260833 RVA: 0x00F687FE File Offset: 0x00F669FE
		public override void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x0603FAE2 RID: 260834 RVA: 0x00F68800 File Offset: 0x00F66A00
		public override void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x0603FAE3 RID: 260835 RVA: 0x00F68802 File Offset: 0x00F66A02
		[NullableContext(1)]
		public override object GetKey(int data, int gridIndex)
		{
			return gridIndex;
		}

		// Token: 0x0200C4CC RID: 50380
		private enum EPropItemComponent
		{
			// Token: 0x0403B627 RID: 243239
			PropName,
			// Token: 0x0403B628 RID: 243240
			PropValue,
			// Token: 0x0403B629 RID: 243241
			PropIcon,
			// Token: 0x0403B62A RID: 243242
			PropBg
		}
	}
}
