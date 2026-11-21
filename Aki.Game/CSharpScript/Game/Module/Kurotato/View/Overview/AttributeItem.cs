using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Overview
{
	// Token: 0x0200471B RID: 18203
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class AttributeItem : GridProxyAbstract<IAttributeListItem>
	{
		// Token: 0x0602DBC0 RID: 187328 RVA: 0x00CCA784 File Offset: 0x00CC8984
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
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
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602DBC1 RID: 187329 RVA: 0x00CCA8B4 File Offset: 0x00CC8AB4
		[NullableContext(1)]
		public override void Refresh(IAttributeListItem data, bool isSelected, int gridIndex)
		{
			KurotatoProperty value = KurotatoConfig.Instance.GetPropertyById(data.AttrId).Value;
			base.SetTextureByPath(value.Icon, base.GetTexture(0), null, null);
			base.GetText(1).ShowTextNew(value.ShowName);
			UUIText text = base.GetText(2);
			bool valueOrDefault = data.IsLocked.GetValueOrDefault();
			IKurotatoAttrPreviewDelta preview = data.Preview;
			bool flag = preview != null && preview.LockValue != null;
			if (valueOrDefault)
			{
				text.SetText(KurotatoUtil.GetPropertyShowValue(data.AttrId, (float)data.LockedValue.GetValueOrDefault()), true);
			}
			else if (flag && preview != null && preview.LockValue != null)
			{
				text.SetText(KurotatoUtil.GetPropertyShowValue(data.AttrId, (float)preview.LockValue.Value), true);
			}
			else
			{
				string text2 = KurotatoUtil.GetPropertyShowValue(data.AttrId, (float)data.Value);
				if (preview != null && !StringUtils.IsEmpty(preview.ValueStr))
				{
					text2 = text2 + " " + preview.ValueStr;
				}
				text.SetText(text2, true);
			}
			KurotatoUtil.ApplyAttrColor(text, (float)data.Value, new float?((float)data.BaseValue.GetValueOrDefault()), valueOrDefault || flag);
			bool flag2 = gridIndex % 2 == 0;
			base.GetSprite(3).SetUIActive(flag2);
			base.GetSprite(4).SetUIActive(!flag2);
			UUISprite sprite = base.GetSprite(5);
			UUIItem uuiitem = sprite;
			bool bUseChangeColor = flag2;
			FColor? fcolor = new FColor?(sprite.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			KurotatoCharacter? kurotatoCharacter;
			int[] array = (KurotatoConfig.Instance.GetCharacterById(KurotatoModel.Instance.GetRoleId()) != null) ? kurotatoCharacter.GetValueOrDefault().GetMainPropertyArray() : null;
			base.GetSprite(7).SetUIActive(array != null && Array.IndexOf<int>(array, data.AttrId) >= 0);
			UUINiagara uiNiagara = base.GetUiNiagara(6);
			if (data.JustChanged.GetValueOrDefault())
			{
				uiNiagara.SetUIActive(true);
			}
		}

		// Token: 0x0602DBC2 RID: 187330 RVA: 0x00CCAAD2 File Offset: 0x00CC8CD2
		public void HideChangeFx()
		{
			UUINiagara uiNiagara = base.GetUiNiagara(6);
			if (uiNiagara == null)
			{
				return;
			}
			uiNiagara.SetUIActive(false);
		}

		// Token: 0x0200A34D RID: 41805
		private enum EAttrChildComp
		{
			// Token: 0x04032A24 RID: 207396
			TextureIcon,
			// Token: 0x04032A25 RID: 207397
			TextAttributeName,
			// Token: 0x04032A26 RID: 207398
			TextNum,
			// Token: 0x04032A27 RID: 207399
			SpriteIconBgA,
			// Token: 0x04032A28 RID: 207400
			SpriteIconBgB,
			// Token: 0x04032A29 RID: 207401
			SpriteBg,
			// Token: 0x04032A2A RID: 207402
			NiagaraGlow,
			// Token: 0x04032A2B RID: 207403
			SpriteMainPropertyLight
		}
	}
}
