using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x02005361 RID: 21345
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MowingRiskInstanceDetailAttributeGridItem : GridProxyAbstract<IMowingRiskInstanceDetailAttributeItemData>
	{
		// Token: 0x060351D9 RID: 217561 RVA: 0x00ED591C File Offset: 0x00ED3B1C
		[NullableContext(1)]
		public override void Refresh(IMowingRiskInstanceDetailAttributeItemData data, bool isSelected, int gridIndex)
		{
			UUITexture texture = base.GetTexture(0);
			if (!string.IsNullOrEmpty(data.IconPath))
			{
				if (texture != null)
				{
					texture.SetUIActive(true);
				}
				base.SetTextureByPath(data.IconPath, texture, null, null);
			}
			else if (texture != null)
			{
				texture.SetUIActive(false);
			}
			UUIText text = base.GetText(1);
			if (!string.IsNullOrEmpty(data.AttributeTextId))
			{
				if (text != null)
				{
					text.SetUIActive(true);
				}
				LguiUtil.Instance.SetLocalTextNew(text, data.AttributeTextId, Array.Empty<object>());
				return;
			}
			if (text != null)
			{
				text.SetUIActive(false);
			}
		}

		// Token: 0x060351DA RID: 217562 RVA: 0x00ED59AB File Offset: 0x00ED3BAB
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x0200AFE5 RID: 45029
		private static class EItemComponent
		{
			// Token: 0x040365D8 RID: 222680
			public const int IconTexture = 0;

			// Token: 0x040365D9 RID: 222681
			public const int AttributeText = 1;
		}
	}
}
