using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Skin;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Settlement
{
	// Token: 0x02004704 RID: 18180
	internal class RoleItem : SyncGridProxyAbstract<int>
	{
		// Token: 0x0602DADB RID: 187099 RVA: 0x00CC5BA0 File Offset: 0x00CC3DA0
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

		// Token: 0x0602DADC RID: 187100 RVA: 0x00CC5C67 File Offset: 0x00CC3E67
		protected override void OnStart()
		{
		}

		// Token: 0x0602DADD RID: 187101 RVA: 0x00CC5C6C File Offset: 0x00CC3E6C
		public override void Refresh(int data)
		{
			this.Data = data;
			KurotatoCharacter value = KurotatoConfig.Instance.GetCharacterById(data).Value;
			RoleDataBase roleDataByKurotatoRoleId = KurotatoModel.Instance.GetRoleDataByKurotatoRoleId(data);
			base.SetTextureByPath(SkinConfig.Instance.GetRoleSkinConfig(roleDataByKurotatoRoleId.GetRoleSkinId()).Value.RoleHeadIconLarge, base.GetTexture(1), null, null);
			base.GetText(2).ShowTextNew(value.Name);
		}

		// Token: 0x0602DADE RID: 187102 RVA: 0x00CC5CEC File Offset: 0x00CC3EEC
		private void OnClickBtn()
		{
			Action<int> onClickCb = this.OnClickCb;
			if (onClickCb == null)
			{
				return;
			}
			onClickCb(this.Data);
		}

		// Token: 0x040186E2 RID: 100066
		public int Data;

		// Token: 0x040186E3 RID: 100067
		[Nullable(1)]
		public Action<int> OnClickCb;

		// Token: 0x0200A317 RID: 41751
		private class ERoleComps
		{
			// Token: 0x0403292A RID: 207146
			public const int Btn = 0;

			// Token: 0x0403292B RID: 207147
			public const int TextureRole = 1;

			// Token: 0x0403292C RID: 207148
			public const int TextName = 2;
		}
	}
}
