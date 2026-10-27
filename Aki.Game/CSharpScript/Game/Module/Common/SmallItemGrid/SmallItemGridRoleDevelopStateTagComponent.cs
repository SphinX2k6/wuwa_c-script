using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common.SmallItemGrid
{
	// Token: 0x02005B4B RID: 23371
	public class SmallItemGridRoleDevelopStateTagComponent : SmallItemGridComponent
	{
		// Token: 0x0603B2BD RID: 242365 RVA: 0x00E1BC60 File Offset: 0x00E19E60
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

		// Token: 0x0603B2BE RID: 242366 RVA: 0x00E1BCA8 File Offset: 0x00E19EA8
		[NullableContext(1)]
		protected override string GetResourceId()
		{
			return "UiItem_ItemBRoleDevelopTag";
		}

		// Token: 0x0603B2BF RID: 242367 RVA: 0x00E1BCAF File Offset: 0x00E19EAF
		public override EItemGridComponentLayoutLevel GetLayoutLevel()
		{
			return EItemGridComponentLayoutLevel.Top;
		}

		// Token: 0x0603B2C0 RID: 242368 RVA: 0x00E1BCB4 File Offset: 0x00E19EB4
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

		// Token: 0x0200BD77 RID: 48503
		private class EChildType
		{
			// Token: 0x0403926C RID: 234092
			public const int TexIcon = 0;
		}
	}
}
