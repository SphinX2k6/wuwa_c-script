using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.BossPiling.View.Item
{
	// Token: 0x02004C0A RID: 19466
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class BossPilingRoleItem : GridProxyAbstract<BossPilingTeamRoleInfo>
	{
		// Token: 0x060308DC RID: 198876 RVA: 0x00D87E30 File Offset: 0x00D86030
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClicked));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060308DD RID: 198877 RVA: 0x00D87F18 File Offset: 0x00D86118
		public override void Refresh(BossPilingTeamRoleInfo data, bool isSelected, int gridIndex)
		{
			this.RoleId = data.RoleId;
			UUISprite sprite = base.GetSprite(1);
			if (sprite != null)
			{
				sprite.SetUIActive(this.RoleId == 0);
			}
			UUITexture texture = base.GetTexture(2);
			if (texture != null)
			{
				texture.SetUIActive(this.RoleId != 0);
			}
			if (this.RoleId != 0)
			{
				if (RoleConfig.Instance.IsTrialRole(this.RoleId))
				{
					base.SetRoleIcon("", base.GetTexture(2), this.RoleId, null, null);
				}
				else
				{
					RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(this.RoleId, true);
					base.SetRoleIconByRoleIdOrSkinId("", base.GetTexture(2), this.RoleId, new int?(roleDataById.GetRoleSkinId()), null, null);
				}
				bool flag = RoleModel.Instance.IsRoleHasBranch(this.RoleId);
				UUISprite sprite2 = base.GetSprite(3);
				if (sprite2 != null)
				{
					sprite2.SetUIActive(flag);
				}
				if (flag)
				{
					int roleBranchIndexById = RoleModel.Instance.GetRoleBranchIndexById(this.RoleId, data.TagId);
					this.TagRotation.Yaw = (float)((roleBranchIndexById == 0) ? 0 : 180);
					UUISprite sprite3 = base.GetSprite(3);
					if (sprite3 == null)
					{
						return;
					}
					FRotator frotator = this.TagRotation.ToUeRotator();
					sprite3.SetUIRelativeRotation(frotator);
				}
				return;
			}
			UUISprite sprite4 = base.GetSprite(3);
			if (sprite4 == null)
			{
				return;
			}
			sprite4.SetUIActive(false);
		}

		// Token: 0x060308DE RID: 198878 RVA: 0x00D8806C File Offset: 0x00D8626C
		private void OnClicked()
		{
			Action<int, int> onClickedCb = this.OnClickedCb;
			if (onClickedCb == null)
			{
				return;
			}
			onClickedCb(this.RoleId, base.GridIndex);
		}

		// Token: 0x04019B21 RID: 105249
		protected int RoleId;

		// Token: 0x04019B22 RID: 105250
		[Nullable(2)]
		public Action<int, int> OnClickedCb;

		// Token: 0x04019B23 RID: 105251
		private readonly Rotator TagRotation = Rotator.Create();

		// Token: 0x0200A81C RID: 43036
		[NullableContext(0)]
		private enum ERole
		{
			// Token: 0x04033EE1 RID: 212705
			Btn,
			// Token: 0x04033EE2 RID: 212706
			SpriteIcon,
			// Token: 0x04033EE3 RID: 212707
			TexRole,
			// Token: 0x04033EE4 RID: 212708
			SpriteTag
		}
	}
}
