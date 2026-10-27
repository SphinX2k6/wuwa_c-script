using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x020061FC RID: 25084
	public class MenuTabToggleItem : UiPanelBase
	{
		// Token: 0x0603F4A1 RID: 259233 RVA: 0x00F4B3A0 File Offset: 0x00F495A0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUISprite)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnExtendToggleClick))
			};
		}

		// Token: 0x0603F4A2 RID: 259234 RVA: 0x00F4B460 File Offset: 0x00F49660
		protected override UniTask OnBeforeStartAsync()
		{
			MenuTabToggleItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MenuTabToggleItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F4A3 RID: 259235 RVA: 0x00F4B4A3 File Offset: 0x00F496A3
		private bool CanExecuteChange()
		{
			return true;
		}

		// Token: 0x0603F4A4 RID: 259236 RVA: 0x00F4B4A8 File Offset: 0x00F496A8
		[NullableContext(1)]
		public void Refresh(MotorChallengePlayData data)
		{
			this.Data = data;
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.ShowTextNew(data.NameTextId);
			}
			base.GetSprite(2).SetUIActive(data.IsFinished);
			base.GetSprite(3).SetUIActive(!data.IsUnlock);
			base.GetItem(4).SetUIActive(data.HasRedDot);
			base.GetItem(5).SetUIActive(data.IsUnlock && data.IsNew && !data.HasRedDot);
		}

		// Token: 0x0603F4A5 RID: 259237 RVA: 0x00F4B535 File Offset: 0x00F49735
		public void SetItemNewVisible(bool bVisible)
		{
			base.GetItem(5).SetUIActive(bVisible);
		}

		// Token: 0x0603F4A6 RID: 259238 RVA: 0x00F4B544 File Offset: 0x00F49744
		private void OnExtendToggleClick(EToggleState state)
		{
			Action<MotorChallengePlayData, MenuTabToggleItem> onChildToggleCallback = this.OnChildToggleCallback;
			if (onChildToggleCallback == null)
			{
				return;
			}
			onChildToggleCallback(this.Data, this);
		}

		// Token: 0x0603F4A7 RID: 259239 RVA: 0x00F4B55D File Offset: 0x00F4975D
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

		// Token: 0x04021039 RID: 135225
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Action<MotorChallengePlayData, MenuTabToggleItem> OnChildToggleCallback;

		// Token: 0x0402103A RID: 135226
		[Nullable(2)]
		private MotorChallengePlayData Data;
	}
}
