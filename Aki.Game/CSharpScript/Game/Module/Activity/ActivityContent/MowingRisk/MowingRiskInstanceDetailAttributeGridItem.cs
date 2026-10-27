using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063E3 RID: 25571
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MowingRiskInstanceDetailAttributeGridItem : GridProxyAbstract<IMowingRiskInstanceDetailAttributeItemData>
	{
		// Token: 0x06040518 RID: 263448 RVA: 0x00F8E984 File Offset: 0x00F8CB84
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

		// Token: 0x06040519 RID: 263449 RVA: 0x00F8EA13 File Offset: 0x00F8CC13
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x0200C5FE RID: 50686
		private static class EItemComponent
		{
			// Token: 0x0403BC79 RID: 244857
			public const int IconTexture = 0;

			// Token: 0x0403BC7A RID: 244858
			public const int AttributeText = 1;
		}
	}
}
