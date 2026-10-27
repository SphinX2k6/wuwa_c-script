using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Dango
{
	// Token: 0x02005AE4 RID: 23268
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class AttributeItem : GridProxyAbstract<AttributeItemData>
	{
		// Token: 0x0603AE9E RID: 241310 RVA: 0x00E0BEDC File Offset: 0x00E0A0DC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUITexture))
			};
		}

		// Token: 0x0603AE9F RID: 241311 RVA: 0x00E0BF38 File Offset: 0x00E0A138
		[NullableContext(1)]
		public override void Refresh(AttributeItemData data, bool isSelected, int gridIndex)
		{
			if (data.DangoRoleData == null)
			{
				return;
			}
			AbyssDangoRoleData dangoRoleData = data.DangoRoleData;
			string skillCastTypeName = dangoRoleData.GetSkillCastTypeName();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), skillCastTypeName, Array.Empty<object>());
			string skillCastTypeIconPath = dangoRoleData.GetSkillCastTypeIconPath();
			base.SetTextureByPath(skillCastTypeIconPath, base.GetTexture(2), null, null);
		}

		// Token: 0x0200BD3C RID: 48444
		private enum EAttributeItemComponent
		{
			// Token: 0x04039128 RID: 233768
			SpriteBg,
			// Token: 0x04039129 RID: 233769
			NameText,
			// Token: 0x0403912A RID: 233770
			Texture
		}
	}
}
