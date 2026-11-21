using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Weapon
{
	// Token: 0x0200525A RID: 21082
	public class PinballWeaponPropItemView : GridProxyAbstract<int>
	{
		// Token: 0x0603479F RID: 214943 RVA: 0x00EAF534 File Offset: 0x00EAD734
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

		// Token: 0x060347A0 RID: 214944 RVA: 0x00EAF5E0 File Offset: 0x00EAD7E0
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

		// Token: 0x060347A1 RID: 214945 RVA: 0x00EAF758 File Offset: 0x00EAD958
		public override void Clear()
		{
		}

		// Token: 0x060347A2 RID: 214946 RVA: 0x00EAF75A File Offset: 0x00EAD95A
		public override void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x060347A3 RID: 214947 RVA: 0x00EAF75C File Offset: 0x00EAD95C
		public override void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x060347A4 RID: 214948 RVA: 0x00EAF75E File Offset: 0x00EAD95E
		[NullableContext(1)]
		public override object GetKey(int data, int gridIndex)
		{
			return gridIndex;
		}

		// Token: 0x0200AEB3 RID: 44723
		private enum EPropItemComponent
		{
			// Token: 0x04035F89 RID: 221065
			PropName,
			// Token: 0x04035F8A RID: 221066
			PropValue,
			// Token: 0x04035F8B RID: 221067
			PropIcon,
			// Token: 0x04035F8C RID: 221068
			PropBg
		}
	}
}
