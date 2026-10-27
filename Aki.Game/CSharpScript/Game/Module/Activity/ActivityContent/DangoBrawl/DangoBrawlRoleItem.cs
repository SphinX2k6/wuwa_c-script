using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006832 RID: 26674
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlRoleItem : GridProxyAbstract<DangoBrawlRoleData>
	{
		// Token: 0x1700974A RID: 38730
		// (get) Token: 0x06042926 RID: 272678 RVA: 0x0102E26F File Offset: 0x0102C46F
		// (set) Token: 0x06042927 RID: 272679 RVA: 0x0102E277 File Offset: 0x0102C477
		public DangoBrawlRoleData RoleData { get; private set; }

		// Token: 0x06042928 RID: 272680 RVA: 0x0102E280 File Offset: 0x0102C480
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggleSpriteTransition));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickTogItem));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06042929 RID: 272681 RVA: 0x0102E40E File Offset: 0x0102C60E
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.CanExecuteChange.Unbind();
			}
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.CanExecuteChange.Bind(new Func<bool>(this.OnCanExecuteChange));
		}

		// Token: 0x0604292A RID: 272682 RVA: 0x0102E444 File Offset: 0x0102C644
		[NullableContext(1)]
		public override void Refresh(DangoBrawlRoleData data, bool isSelected, int gridIndex)
		{
			base.GridIndex = gridIndex;
			this.RoleData = data;
			DangoBrawlRole? roleConfigById = DangoBrawlConfig.Instance.GetRoleConfigById(data.RoleId);
			if (roleConfigById == null)
			{
				return;
			}
			DangoBrawlOccupation? occupationConfigById = DangoBrawlConfig.Instance.GetOccupationConfigById(roleConfigById.Value.OccupationId);
			bool valueOrDefault = data.IsShowShadow.GetValueOrDefault();
			bool isUnlocked = data.IsUnlocked;
			bool valueOrDefault2 = data.IsRecommend.GetValueOrDefault();
			bool flag = valueOrDefault && !isUnlocked;
			UUISprite sprite = base.GetSprite(2);
			if (sprite != null)
			{
				sprite.SetUIActive(valueOrDefault2);
			}
			UUIItem item = base.GetItem(7);
			if (item != null)
			{
				item.SetUIActive(!flag);
			}
			UUIItem item2 = base.GetItem(5);
			if (item2 != null)
			{
				item2.SetUIActive(!isUnlocked);
			}
			UUISprite sprite2 = base.GetSprite(8);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(flag);
			}
			this.SetNewVisible(data.IsNew.GetValueOrDefault());
			this.RefreshRoleSpriteTransition(roleConfigById.Value).Forget();
			this.SetSpriteByPath(roleConfigById.Value.RoleIcon, base.GetSprite(6), true, null, null);
			if (occupationConfigById != null)
			{
				base.SetTextureByPath(occupationConfigById.Value.Icon, base.GetTexture(4), null, null);
			}
		}

		// Token: 0x0604292B RID: 272683 RVA: 0x0102E590 File Offset: 0x0102C790
		private UniTask RefreshRoleSpriteTransition(DangoBrawlRole roleConfig)
		{
			DangoBrawlRoleItem.<RefreshRoleSpriteTransition>d__9 <RefreshRoleSpriteTransition>d__;
			<RefreshRoleSpriteTransition>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshRoleSpriteTransition>d__.<>4__this = this;
			<RefreshRoleSpriteTransition>d__.roleConfig = roleConfig;
			<RefreshRoleSpriteTransition>d__.<>1__state = -1;
			<RefreshRoleSpriteTransition>d__.<>t__builder.Start<DangoBrawlRoleItem.<RefreshRoleSpriteTransition>d__9>(ref <RefreshRoleSpriteTransition>d__);
			return <RefreshRoleSpriteTransition>d__.<>t__builder.Task;
		}

		// Token: 0x0604292C RID: 272684 RVA: 0x0102E5DB File Offset: 0x0102C7DB
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleState(true, fireEvent);
		}

		// Token: 0x0604292D RID: 272685 RVA: 0x0102E5E5 File Offset: 0x0102C7E5
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleState(false, fireEvent);
		}

		// Token: 0x0604292E RID: 272686 RVA: 0x0102E5F0 File Offset: 0x0102C7F0
		private void SetToggleState(bool state, bool fireEvent)
		{
			EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleStateForce(state2, fireEvent, false, false);
			}
			if (state)
			{
				this.PostRoleSelectAudio();
			}
		}

		// Token: 0x0604292F RID: 272687 RVA: 0x0102E624 File Offset: 0x0102C824
		private void PostRoleSelectAudio()
		{
			if (this.RoleData == null)
			{
				return;
			}
			DangoBrawlRole? dangoBrawlRole;
			string text = (DangoBrawlConfig.Instance.GetRoleConfigById(this.RoleData.RoleId) != null) ? dangoBrawlRole.GetValueOrDefault().AudioRoleSelect : null;
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			AudioSystem.Instance.PostEvent(text);
		}

		// Token: 0x06042930 RID: 272688 RVA: 0x0102E684 File Offset: 0x0102C884
		private bool OnCanExecuteChange()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			return extendToggle == null || extendToggle.GetToggleState() != EToggleState.ETT_Checked;
		}

		// Token: 0x06042931 RID: 272689 RVA: 0x0102E6AA File Offset: 0x0102C8AA
		public void SetNewVisible(bool visible)
		{
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(visible);
		}

		// Token: 0x06042932 RID: 272690 RVA: 0x0102E6BE File Offset: 0x0102C8BE
		private void OnClickTogItem(EToggleState state)
		{
			if (this.RoleData == null)
			{
				return;
			}
			Action<DangoBrawlRoleItem> onClickRole = this.OnClickRole;
			if (onClickRole == null)
			{
				return;
			}
			onClickRole(this);
		}

		// Token: 0x04022AE9 RID: 142057
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<DangoBrawlRoleItem> OnClickRole;

		// Token: 0x0200C9E6 RID: 51686
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403CFF8 RID: 249848
			Toggle,
			// Token: 0x0403CFF9 RID: 249849
			SprRole,
			// Token: 0x0403CFFA RID: 249850
			SprRecommend,
			// Token: 0x0403CFFB RID: 249851
			NewItem,
			// Token: 0x0403CFFC RID: 249852
			TexOccupationType,
			// Token: 0x0403CFFD RID: 249853
			LockItem,
			// Token: 0x0403CFFE RID: 249854
			SprLockRole,
			// Token: 0x0403CFFF RID: 249855
			NormalItem,
			// Token: 0x0403D000 RID: 249856
			SprRoleShadow
		}
	}
}
