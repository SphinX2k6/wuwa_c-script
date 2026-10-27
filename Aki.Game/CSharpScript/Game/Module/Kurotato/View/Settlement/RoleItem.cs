using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Skin;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Settlement
{
	// Token: 0x0200572D RID: 22317
	internal class RoleItem : SyncGridProxyAbstract<int>
	{
		// Token: 0x06038BCB RID: 232395 RVA: 0x00D774F4 File Offset: 0x00D756F4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038BCC RID: 232396 RVA: 0x00D775BB File Offset: 0x00D757BB
		protected override void OnStart()
		{
		}

		// Token: 0x06038BCD RID: 232397 RVA: 0x00D775C0 File Offset: 0x00D757C0
		public override void Refresh(int data)
		{
			this.Data = data;
			KurotatoCharacter value = KurotatoConfig.Instance.GetCharacterById(data).Value;
			RoleDataBase roleDataByKurotatoRoleId = KurotatoModel.Instance.GetRoleDataByKurotatoRoleId(data);
			base.SetTextureByPath(SkinConfig.Instance.GetRoleSkinConfig(roleDataByKurotatoRoleId.GetRoleSkinId()).Value.RoleHeadIconLarge, base.GetTexture(1), null, null);
			base.GetText(2).ShowTextNew(value.Name);
		}

		// Token: 0x06038BCE RID: 232398 RVA: 0x00D77640 File Offset: 0x00D75840
		private void OnClickBtn()
		{
			Action<int> onClickCb = this.OnClickCb;
			if (onClickCb == null)
			{
				return;
			}
			onClickCb(this.Data);
		}

		// Token: 0x0401DC4C RID: 121932
		public int Data;

		// Token: 0x0401DC4D RID: 121933
		[Nullable(1)]
		public Action<int> OnClickCb;

		// Token: 0x0200B8F6 RID: 47350
		private class ERoleComps
		{
			// Token: 0x04037F1A RID: 229146
			public const int Btn = 0;

			// Token: 0x04037F1B RID: 229147
			public const int TextureRole = 1;

			// Token: 0x04037F1C RID: 229148
			public const int TextName = 2;
		}
	}
}
