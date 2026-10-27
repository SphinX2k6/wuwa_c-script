using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Input;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E1D RID: 24093
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarKeyItem : UiPanelBase
	{
		// Token: 0x0603D466 RID: 250982 RVA: 0x00EC43C6 File Offset: 0x00EC25C6
		public void SetConfig(SpecialEnergyBarInfo config)
		{
			this.Config = config;
			this.KeyType = config.KeyType;
		}

		// Token: 0x0603D467 RID: 250983 RVA: 0x00EC43DC File Offset: 0x00EC25DC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603D468 RID: 250984 RVA: 0x00EC4424 File Offset: 0x00EC2624
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarKeyItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarKeyItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D469 RID: 250985 RVA: 0x00EC4467 File Offset: 0x00EC2667
		protected override void OnStart()
		{
			this.SwitchToKeyInfoListInner(this.Config.KeyInfoList);
		}

		// Token: 0x0603D46A RID: 250986 RVA: 0x00EC447A File Offset: 0x00EC267A
		public void SwitchToDefault()
		{
			this.KeyType = this.Config.KeyType;
			this.SwitchToKeyInfoListInner(this.Config.KeyInfoList);
		}

		// Token: 0x0603D46B RID: 250987 RVA: 0x00EC449E File Offset: 0x00EC269E
		public void SetKeyType(int keyType)
		{
			this.KeyType = keyType;
		}

		// Token: 0x0603D46C RID: 250988 RVA: 0x00EC44A7 File Offset: 0x00EC26A7
		public void SwitchToKeyInfoList(List<SpecialEnergyBarKeyInfo> keyInfoList)
		{
			this.SwitchToKeyInfoListInner(keyInfoList);
		}

		// Token: 0x0603D46D RID: 250989 RVA: 0x00EC44B0 File Offset: 0x00EC26B0
		protected void SwitchToKeyInfoListInner(List<SpecialEnergyBarKeyInfo> keyInfoList)
		{
			SpecialEnergyBarKeyInfo keyInfo = keyInfoList[0];
			SpecialEnergyBarKeyInfo valueOrDefault = keyInfoList.GetValueOrDefault(1);
			string linkString;
			if (this.KeyType == 0)
			{
				linkString = string.Empty;
			}
			else
			{
				int keyType = this.KeyType;
				if (keyType != 1)
				{
					if (keyType != 2)
					{
						linkString = "";
					}
					else
					{
						linkString = "/";
					}
				}
				else
				{
					linkString = "+";
				}
			}
			InputActionOrAxisKeyItemGroup inputActionOrAxisKeyItemGroup = new InputActionOrAxisKeyItemGroup
			{
				SingleActionOrAxisKeyItem = this.ConvertToInputActionOrAxisKeyItem(keyInfo),
				DoubleActionOrAxisKeyItem = ((valueOrDefault != null) ? this.ConvertToInputActionOrAxisKeyItem(valueOrDefault) : null),
				LinkString = linkString
			};
			InputMultiKeyItemGroup keyItem = this.KeyItem;
			if (keyItem != null)
			{
				keyItem.Refresh(inputActionOrAxisKeyItemGroup);
			}
			InputMultiKeyItemGroup keyItem2 = this.KeyItem;
			if (keyItem2 == null)
			{
				return;
			}
			keyItem2.SetActive(true);
		}

		// Token: 0x0603D46E RID: 250990 RVA: 0x00EC4558 File Offset: 0x00EC2758
		private InputActionOrAxisKeyItem ConvertToInputActionOrAxisKeyItem(SpecialEnergyBarKeyInfo keyInfo)
		{
			bool value = keyInfo.Action == 1;
			return new InputActionOrAxisKeyItem
			{
				ActionOrAxisName = EInputAction.Defines[keyInfo.ActionType].Name,
				IsLongPressProcessVisible = new bool?(value),
				IsTextArrowVisible = new bool?(value)
			};
		}

		// Token: 0x0603D46F RID: 250991 RVA: 0x00EC45A7 File Offset: 0x00EC27A7
		public void RefreshKeyEnable(bool enable, bool bForce)
		{
			InputMultiKeyItemGroup keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.SetEnable(enable, bForce);
		}

		// Token: 0x0401FF3E RID: 130878
		[Nullable(2)]
		private InputMultiKeyItemGroup KeyItem;

		// Token: 0x0401FF3F RID: 130879
		[Nullable(2)]
		private SpecialEnergyBarInfo Config;

		// Token: 0x0401FF40 RID: 130880
		private int KeyType;

		// Token: 0x0200C195 RID: 49557
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A7F5 RID: 239605
			InputMultiKeyItemGroupItem
		}
	}
}
