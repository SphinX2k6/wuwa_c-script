using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x0200629A RID: 25242
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MenuTabToggleItem : GridProxyAbstract<MotorChallengePlayData>
	{
		// Token: 0x0603F80D RID: 260109 RVA: 0x00F5A934 File Offset: 0x00F58B34
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnExtendToggleClick))
			};
		}

		// Token: 0x0603F80E RID: 260110 RVA: 0x00F5A9F4 File Offset: 0x00F58BF4
		protected override UniTask OnBeforeStartAsync()
		{
			MenuTabToggleItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MenuTabToggleItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F80F RID: 260111 RVA: 0x00F5AA37 File Offset: 0x00F58C37
		private bool CanExecuteChange()
		{
			return true;
		}

		// Token: 0x0603F810 RID: 260112 RVA: 0x00F5AA3C File Offset: 0x00F58C3C
		public override void Refresh(MotorChallengePlayData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.ShowTextNew(data.NameTextId);
			}
			base.GetItem(2).SetUIActive(data.IsFinished);
			base.GetItem(3).SetUIActive(!data.IsUnlock);
			base.GetItem(4).SetUIActive(data.HasRedDot);
			base.GetItem(5).SetUIActive(data.IsUnlock && data.IsNew && !data.HasRedDot);
			this.SetIsSelect(isSelected, false);
		}

		// Token: 0x0603F811 RID: 260113 RVA: 0x00F5AAD1 File Offset: 0x00F58CD1
		public override void OnSelected(bool fireEvent)
		{
			this.SetIsSelect(true, fireEvent);
		}

		// Token: 0x0603F812 RID: 260114 RVA: 0x00F5AADB File Offset: 0x00F58CDB
		public void SetItemNewVisible(bool bVisible)
		{
			base.GetItem(5).SetUIActive(bVisible);
		}

		// Token: 0x0603F813 RID: 260115 RVA: 0x00F5AAEA File Offset: 0x00F58CEA
		private void OnExtendToggleClick(EToggleState state)
		{
			Action<MotorChallengePlayData, MenuTabToggleItem> onChildToggleCallback = this.OnChildToggleCallback;
			if (onChildToggleCallback == null)
			{
				return;
			}
			onChildToggleCallback(this.Data, this);
		}

		// Token: 0x0603F814 RID: 260116 RVA: 0x00F5AB03 File Offset: 0x00F58D03
		public void SetIsSelect(bool isSelect, bool fireEvent = false)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleStateForce(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			}
			if (fireEvent)
			{
				Action<MotorChallengePlayData, MenuTabToggleItem> onChildToggleCallback = this.OnChildToggleCallback;
				if (onChildToggleCallback == null)
				{
					return;
				}
				onChildToggleCallback(this.Data, this);
			}
		}

		// Token: 0x04021333 RID: 135987
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Action<MotorChallengePlayData, MenuTabToggleItem> OnChildToggleCallback;

		// Token: 0x04021334 RID: 135988
		[Nullable(2)]
		private MotorChallengePlayData Data;
	}
}
