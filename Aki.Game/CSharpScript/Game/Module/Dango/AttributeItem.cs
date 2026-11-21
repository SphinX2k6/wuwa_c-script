using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Dango
{
	// Token: 0x02004AC5 RID: 19141
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class AttributeItem : GridProxyAbstract<AttributeItemData>
	{
		// Token: 0x0602FE10 RID: 196112 RVA: 0x00D5CBC0 File Offset: 0x00D5ADC0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUITexture))
			};
		}

		// Token: 0x0602FE11 RID: 196113 RVA: 0x00D5CC1C File Offset: 0x00D5AE1C
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

		// Token: 0x0200A744 RID: 42820
		private enum EAttributeItemComponent
		{
			// Token: 0x04033AF2 RID: 211698
			SpriteBg,
			// Token: 0x04033AF3 RID: 211699
			NameText,
			// Token: 0x04033AF4 RID: 211700
			Texture
		}
	}
}
