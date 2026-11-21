using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common.SmallItemGrid
{
	// Token: 0x02004B28 RID: 19240
	public class SmallItemGridRoleDevelopStateTagComponent : SmallItemGridComponent
	{
		// Token: 0x060301FE RID: 197118 RVA: 0x00D6BFF4 File Offset: 0x00D6A1F4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060301FF RID: 197119 RVA: 0x00D6C03C File Offset: 0x00D6A23C
		[NullableContext(1)]
		protected override string GetResourceId()
		{
			return "UiItem_ItemBRoleDevelopTag";
		}

		// Token: 0x06030200 RID: 197120 RVA: 0x00D6C043 File Offset: 0x00D6A243
		public override EItemGridComponentLayoutLevel GetLayoutLevel()
		{
			return EItemGridComponentLayoutLevel.Top;
		}

		// Token: 0x06030201 RID: 197121 RVA: 0x00D6C048 File Offset: 0x00D6A248
		[NullableContext(2)]
		protected override void OnRefresh(object data)
		{
			if (data is ERoleDevelopStateTagType)
			{
				string path;
				switch ((ERoleDevelopStateTagType)data)
				{
				case ERoleDevelopStateTagType.Lack:
					path = "/Game/Aki/UI/UIResources/Common/Image/Com/T_RoleDevelopTag2.T_RoleDevelopTag2";
					break;
				case ERoleDevelopStateTagType.CanBeFilled:
					path = "/Game/Aki/UI/UIResources/Common/Image/Com/T_RoleDevelopTag4.T_RoleDevelopTag4";
					break;
				case ERoleDevelopStateTagType.Completed:
					path = "/Game/Aki/UI/UIResources/Common/Image/Com/T_RoleDevelopTag1.T_RoleDevelopTag1";
					break;
				default:
					this.SetActive(false);
					return;
				}
				base.SetTextureByPath(path, base.GetTexture(0), null, null);
				this.SetActive(true);
				return;
			}
			this.SetActive(false);
		}

		// Token: 0x0200A780 RID: 42880
		private class EChildType
		{
			// Token: 0x04033C38 RID: 212024
			public const int TexIcon = 0;
		}
	}
}
