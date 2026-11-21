using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.AttributeDetail
{
	// Token: 0x0200475A RID: 18266
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class KurotatoRoleAttributeItem : GridProxyAbstract<IKurotatoRoleSkillInfo>
	{
		// Token: 0x17005C40 RID: 23616
		// (get) Token: 0x0602DD9D RID: 187805 RVA: 0x00CD5501 File Offset: 0x00CD3701
		// (set) Token: 0x0602DD9E RID: 187806 RVA: 0x00CD5509 File Offset: 0x00CD3709
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public new IScrollViewDelegate<IGridProxy<IKurotatoRoleSkillInfo>, IKurotatoRoleSkillInfo> ScrollViewDelegate { [return: Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})] set; }

		// Token: 0x0602DD9F RID: 187807 RVA: 0x00CD5512 File Offset: 0x00CD3712
		public override void Refresh(IKurotatoRoleSkillInfo data, bool isSelected, int gridIndex)
		{
			this.Update(data);
		}

		// Token: 0x0602DDA0 RID: 187808 RVA: 0x00CD551C File Offset: 0x00CD371C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
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
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602DDA1 RID: 187809 RVA: 0x00CD55E8 File Offset: 0x00CD37E8
		public void Update(IKurotatoRoleSkillInfo data)
		{
			base.GetSprite(0).useChangeColor = (base.GridIndex % 2 == 1);
			KurotatoProperty value = KurotatoConfig.Instance.GetPropertyById(data.AttrId).Value;
			base.SetTextureByPath(value.Icon, base.GetTexture(1), null, null);
			base.GetText(2).ShowTextNew(value.ShowName);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), value.Desc, NoLinq.ToArray<string>(value.DescParamsIter()));
			UUIText text = base.GetText(4);
			bool valueOrDefault = data.IsLocked.GetValueOrDefault();
			int num = valueOrDefault ? data.LockedValue.GetValueOrDefault() : data.Value;
			text.SetText(KurotatoUtil.GetPropertyShowValue(data.AttrId, (float)num), true);
			float rawValue = (float)data.Value;
			int? baseValue = data.BaseValue;
			KurotatoUtil.ApplyAttrColor(text, rawValue, (baseValue != null) ? new float?((float)baseValue.GetValueOrDefault()) : null, valueOrDefault);
		}

		// Token: 0x0200A3BC RID: 41916
		[NullableContext(0)]
		private enum ERoleAttrItemDefine
		{
			// Token: 0x04032C0D RID: 207885
			SpriteBg,
			// Token: 0x04032C0E RID: 207886
			AttrIconTexture,
			// Token: 0x04032C0F RID: 207887
			AttrNameText,
			// Token: 0x04032C10 RID: 207888
			TextDescription,
			// Token: 0x04032C11 RID: 207889
			AttrValue
		}
	}
}
