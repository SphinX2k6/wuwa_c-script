using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.AttributeDetail
{
	// Token: 0x02005783 RID: 22403
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class KurotatoRoleAttributeItem : GridProxyAbstract<IKurotatoRoleSkillInfo>
	{
		// Token: 0x17008878 RID: 34936
		// (get) Token: 0x06038E8D RID: 233101 RVA: 0x00D867BD File Offset: 0x00D849BD
		// (set) Token: 0x06038E8E RID: 233102 RVA: 0x00D867C5 File Offset: 0x00D849C5
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

		// Token: 0x06038E8F RID: 233103 RVA: 0x00D867CE File Offset: 0x00D849CE
		public override void Refresh(IKurotatoRoleSkillInfo data, bool isSelected, int gridIndex)
		{
			this.Update(data);
		}

		// Token: 0x06038E90 RID: 233104 RVA: 0x00D867D8 File Offset: 0x00D849D8
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

		// Token: 0x06038E91 RID: 233105 RVA: 0x00D868A4 File Offset: 0x00D84AA4
		public void Update(IKurotatoRoleSkillInfo data)
		{
			base.GetSprite(0).useChangeColor = (base.GridIndex % 2 == 1);
			KurotatoProperty value = KurotatoConfig.Instance.GetPropertyById(data.AttrId).Value;
			base.SetTextureByPath(value.Icon, base.GetTexture(1), null, null);
			base.GetText(2).ShowTextNew(value.ShowName);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), value.Desc, value.DescParamsIter().ToArray<string>());
			UUIText text = base.GetText(4);
			bool valueOrDefault = data.IsLocked.GetValueOrDefault();
			int num = valueOrDefault ? data.LockedValue.GetValueOrDefault() : data.Value;
			text.SetText(KurotatoUtil.GetPropertyShowValue(data.AttrId, (float)num), true);
			float rawValue = (float)data.Value;
			int? baseValue = data.BaseValue;
			KurotatoUtil.ApplyAttrColor(text, rawValue, (baseValue != null) ? new float?((float)baseValue.GetValueOrDefault()) : null, valueOrDefault);
		}

		// Token: 0x0200B9A5 RID: 47525
		[NullableContext(0)]
		private enum ERoleAttrItemDefine
		{
			// Token: 0x0403821B RID: 229915
			SpriteBg,
			// Token: 0x0403821C RID: 229916
			AttrIconTexture,
			// Token: 0x0403821D RID: 229917
			AttrNameText,
			// Token: 0x0403821E RID: 229918
			TextDescription,
			// Token: 0x0403821F RID: 229919
			AttrValue
		}
	}
}
