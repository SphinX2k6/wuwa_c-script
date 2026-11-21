using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Settlement
{
	// Token: 0x02005277 RID: 21111
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DamageLayoutItemView : GridProxyAbstract<IDamageLayoutItemData>
	{
		// Token: 0x06034902 RID: 215298 RVA: 0x00EB4A84 File Offset: 0x00EB2C84
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06034903 RID: 215299 RVA: 0x00EB4BB4 File Offset: 0x00EB2DB4
		[NullableContext(1)]
		public override void Refresh(IDamageLayoutItemData data, bool isSelected, int gridIndex)
		{
			PinballRoleConfig? pinballRoleConfigById = PinballConfig.Instance.GetPinballRoleConfigById(data.RoleId);
			if (pinballRoleConfigById == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PinballBattle;
				ELogAuthor author = ELogAuthor.CB;
				string message = "星弹奇游角色配置不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("RoleId", data.RoleId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(pinballRoleConfigById.Value.RoleId);
			if (roleConfig == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.PinballBattle;
				ELogAuthor author2 = ELogAuthor.CB;
				string message2 = "角色表角色配置不存在";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("RoleId", data.RoleId);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			base.TrySetTextureByPath(pinballRoleConfigById.Value.MiddleIcon, base.GetTexture(1), null, null);
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(2), roleConfig.Value.Name, Array.Empty<object>());
			UUIText text = base.GetText(7);
			if (text != null)
			{
				text.SetText(((int)Math.Round((double)(data.Damage * 100f))).ToString(), true);
			}
			if (data.IsWin)
			{
				UUISprite sprite = base.GetSprite(4);
				if (sprite != null)
				{
					sprite.SetFillAmount(data.Damage);
				}
			}
			else
			{
				UUISprite sprite2 = base.GetSprite(5);
				if (sprite2 != null)
				{
					sprite2.SetFillAmount(data.Damage);
				}
			}
			UUISprite sprite3 = base.GetSprite(4);
			if (sprite3 != null)
			{
				sprite3.SetUIActive(data.IsWin);
			}
			UUISprite sprite4 = base.GetSprite(5);
			if (sprite4 != null)
			{
				sprite4.SetUIActive(!data.IsWin);
			}
			UUISprite sprite5 = base.GetSprite(0);
			FColor? fcolor;
			if (sprite5 != null)
			{
				bool bUseChangeColor = !data.IsWin;
				fcolor = new FColor?(base.GetSprite(0).changeColor);
				sprite5.SetChangeColor(bUseChangeColor, fcolor);
			}
			UUIText text2 = base.GetText(2);
			if (text2 != null)
			{
				bool bUseChangeColor2 = !data.IsWin;
				fcolor = new FColor?(base.GetText(2).changeColor);
				text2.SetChangeColor(bUseChangeColor2, fcolor);
			}
			UUISprite sprite6 = base.GetSprite(3);
			if (sprite6 != null)
			{
				bool bUseChangeColor3 = !data.IsWin;
				fcolor = new FColor?(base.GetSprite(3).changeColor);
				sprite6.SetChangeColor(bUseChangeColor3, fcolor);
			}
			UUIText text3 = base.GetText(6);
			if (text3 != null)
			{
				bool bUseChangeColor4 = !data.IsWin;
				fcolor = new FColor?(base.GetText(6).changeColor);
				text3.SetChangeColor(bUseChangeColor4, fcolor);
			}
			UUIText text4 = base.GetText(7);
			if (text4 == null)
			{
				return;
			}
			bool bUseChangeColor5 = !data.IsWin;
			fcolor = new FColor?(base.GetText(7).changeColor);
			text4.SetChangeColor(bUseChangeColor5, fcolor);
		}

		// Token: 0x0200AEDA RID: 44762
		private enum EDamageLayoutItemComponent
		{
			// Token: 0x0403605E RID: 221278
			SpriteBg,
			// Token: 0x0403605F RID: 221279
			HeadTexture,
			// Token: 0x04036060 RID: 221280
			TextName,
			// Token: 0x04036061 RID: 221281
			SpriteBarBg,
			// Token: 0x04036062 RID: 221282
			SpriteSuccessBar,
			// Token: 0x04036063 RID: 221283
			SpriteFailBar,
			// Token: 0x04036064 RID: 221284
			TextDamageProgressPercent,
			// Token: 0x04036065 RID: 221285
			TextDamageProgress
		}
	}
}
