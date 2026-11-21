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
	// Token: 0x02005782 RID: 22402
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlRoleItem : GridProxyAbstract<DangoBrawlRoleData>
	{
		// Token: 0x17006A8B RID: 27275
		// (get) Token: 0x0603747A RID: 226426 RVA: 0x00F6F7AB File Offset: 0x00F6D9AB
		// (set) Token: 0x0603747B RID: 226427 RVA: 0x00F6F7B3 File Offset: 0x00F6D9B3
		public DangoBrawlRoleData RoleData { get; private set; }

		// Token: 0x0603747C RID: 226428 RVA: 0x00F6F7BC File Offset: 0x00F6D9BC
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

		// Token: 0x0603747D RID: 226429 RVA: 0x00F6F94A File Offset: 0x00F6DB4A
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

		// Token: 0x0603747E RID: 226430 RVA: 0x00F6F980 File Offset: 0x00F6DB80
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

		// Token: 0x0603747F RID: 226431 RVA: 0x00F6FACC File Offset: 0x00F6DCCC
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

		// Token: 0x06037480 RID: 226432 RVA: 0x00F6FB17 File Offset: 0x00F6DD17
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleState(true, fireEvent);
		}

		// Token: 0x06037481 RID: 226433 RVA: 0x00F6FB21 File Offset: 0x00F6DD21
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleState(false, fireEvent);
		}

		// Token: 0x06037482 RID: 226434 RVA: 0x00F6FB2C File Offset: 0x00F6DD2C
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

		// Token: 0x06037483 RID: 226435 RVA: 0x00F6FB60 File Offset: 0x00F6DD60
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

		// Token: 0x06037484 RID: 226436 RVA: 0x00F6FBC0 File Offset: 0x00F6DDC0
		private bool OnCanExecuteChange()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			return extendToggle == null || extendToggle.GetToggleState() != EToggleState.ETT_Checked;
		}

		// Token: 0x06037485 RID: 226437 RVA: 0x00F6FBE6 File Offset: 0x00F6DDE6
		public void SetNewVisible(bool visible)
		{
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(visible);
		}

		// Token: 0x06037486 RID: 226438 RVA: 0x00F6FBFA File Offset: 0x00F6DDFA
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

		// Token: 0x0401D346 RID: 119622
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<DangoBrawlRoleItem> OnClickRole;

		// Token: 0x0200B3B2 RID: 46002
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x040378E2 RID: 227554
			Toggle,
			// Token: 0x040378E3 RID: 227555
			SprRole,
			// Token: 0x040378E4 RID: 227556
			SprRecommend,
			// Token: 0x040378E5 RID: 227557
			NewItem,
			// Token: 0x040378E6 RID: 227558
			TexOccupationType,
			// Token: 0x040378E7 RID: 227559
			LockItem,
			// Token: 0x040378E8 RID: 227560
			SprLockRole,
			// Token: 0x040378E9 RID: 227561
			NormalItem,
			// Token: 0x040378EA RID: 227562
			SprRoleShadow
		}
	}
}
