using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.BossPiling.View.Item
{
	// Token: 0x02005C2A RID: 23594
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class BossPilingRoleItem : GridProxyAbstract<BossPilingTeamRoleInfo>
	{
		// Token: 0x0603B991 RID: 244113 RVA: 0x00E37AC8 File Offset: 0x00E35CC8
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

		// Token: 0x0603B992 RID: 244114 RVA: 0x00E37BB0 File Offset: 0x00E35DB0
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

		// Token: 0x0603B993 RID: 244115 RVA: 0x00E37D04 File Offset: 0x00E35F04
		private void OnClicked()
		{
			Action<int, int> onClickedCb = this.OnClickedCb;
			if (onClickedCb == null)
			{
				return;
			}
			onClickedCb(this.RoleId, base.GridIndex);
		}

		// Token: 0x0401F070 RID: 127088
		protected int RoleId;

		// Token: 0x0401F071 RID: 127089
		[Nullable(2)]
		public Action<int, int> OnClickedCb;

		// Token: 0x0401F072 RID: 127090
		private readonly Rotator TagRotation = Rotator.Create();

		// Token: 0x0200BE14 RID: 48660
		[NullableContext(0)]
		private enum ERole
		{
			// Token: 0x0403951E RID: 234782
			Btn,
			// Token: 0x0403951F RID: 234783
			SpriteIcon,
			// Token: 0x04039520 RID: 234784
			TexRole,
			// Token: 0x04039521 RID: 234785
			SpriteTag
		}
	}
}
