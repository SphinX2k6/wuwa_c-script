using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Overview
{
	// Token: 0x02005746 RID: 22342
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PropertyInfoItem : GridProxyAbstract<IKurotatoAttrDisplay>
	{
		// Token: 0x06038CC8 RID: 232648 RVA: 0x00D7D098 File Offset: 0x00D7B298
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
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
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038CC9 RID: 232649 RVA: 0x00D7D144 File Offset: 0x00D7B344
		[NullableContext(1)]
		public override void Refresh(IKurotatoAttrDisplay data, bool isSelected, int gridIndex)
		{
			base.SetTextureByPath(data.Icon, base.GetTexture(0), null, null);
			KurotatoProperty? propertyById = KurotatoConfig.Instance.GetPropertyById(data.PropertyId);
			string text;
			if (propertyById != null)
			{
				KurotatoProperty valueOrDefault = propertyById.GetValueOrDefault();
				text = (ConfigMultiTextLang.GetLocalTextNew(valueOrDefault.ShowName, null) ?? valueOrDefault.ShowName);
			}
			else
			{
				text = "";
			}
			string newText = text;
			base.GetText(1).SetText(newText, true);
			base.GetText(2).SetText(data.Text, true);
			base.GetTexture(3).SetUIActive(gridIndex % 2 == 0);
		}

		// Token: 0x0200B935 RID: 47413
		private enum EAttrChildComp
		{
			// Token: 0x04038052 RID: 229458
			TextureIcon,
			// Token: 0x04038053 RID: 229459
			TextAttr,
			// Token: 0x04038054 RID: 229460
			TextNum,
			// Token: 0x04038055 RID: 229461
			TextureBg
		}
	}
}
