using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x02005218 RID: 21016
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MenuTabToggleItem : GridProxyAbstract<MotorChallengePlayData>
	{
		// Token: 0x060344CE RID: 214222 RVA: 0x00EA1890 File Offset: 0x00E9FA90
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

		// Token: 0x060344CF RID: 214223 RVA: 0x00EA1950 File Offset: 0x00E9FB50
		protected override UniTask OnBeforeStartAsync()
		{
			MenuTabToggleItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MenuTabToggleItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060344D0 RID: 214224 RVA: 0x00EA1993 File Offset: 0x00E9FB93
		private bool CanExecuteChange()
		{
			return true;
		}

		// Token: 0x060344D1 RID: 214225 RVA: 0x00EA1998 File Offset: 0x00E9FB98
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

		// Token: 0x060344D2 RID: 214226 RVA: 0x00EA1A2D File Offset: 0x00E9FC2D
		public override void OnSelected(bool fireEvent)
		{
			this.SetIsSelect(true, fireEvent);
		}

		// Token: 0x060344D3 RID: 214227 RVA: 0x00EA1A37 File Offset: 0x00E9FC37
		public void SetItemNewVisible(bool bVisible)
		{
			base.GetItem(5).SetUIActive(bVisible);
		}

		// Token: 0x060344D4 RID: 214228 RVA: 0x00EA1A46 File Offset: 0x00E9FC46
		private void OnExtendToggleClick(EToggleState state)
		{
			Action<MotorChallengePlayData, MenuTabToggleItem> onChildToggleCallback = this.OnChildToggleCallback;
			if (onChildToggleCallback == null)
			{
				return;
			}
			onChildToggleCallback(this.Data, this);
		}

		// Token: 0x060344D5 RID: 214229 RVA: 0x00EA1A5F File Offset: 0x00E9FC5F
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

		// Token: 0x0401BC62 RID: 113762
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Action<MotorChallengePlayData, MenuTabToggleItem> OnChildToggleCallback;

		// Token: 0x0401BC63 RID: 113763
		[Nullable(2)]
		private MotorChallengePlayData Data;
	}
}
