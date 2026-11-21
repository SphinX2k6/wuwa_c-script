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
	// Token: 0x02004E02 RID: 19970
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarKeyItem : UiPanelBase
	{
		// Token: 0x060323F5 RID: 205813 RVA: 0x00E15926 File Offset: 0x00E13B26
		public void SetConfig(SpecialEnergyBarInfo config)
		{
			this.Config = config;
			this.KeyType = config.KeyType;
		}

		// Token: 0x060323F6 RID: 205814 RVA: 0x00E1593C File Offset: 0x00E13B3C
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

		// Token: 0x060323F7 RID: 205815 RVA: 0x00E15984 File Offset: 0x00E13B84
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarKeyItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarKeyItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060323F8 RID: 205816 RVA: 0x00E159C7 File Offset: 0x00E13BC7
		protected override void OnStart()
		{
			this.SwitchToKeyInfoListInner(this.Config.KeyInfoList);
		}

		// Token: 0x060323F9 RID: 205817 RVA: 0x00E159DA File Offset: 0x00E13BDA
		public void SwitchToDefault()
		{
			this.KeyType = this.Config.KeyType;
			this.SwitchToKeyInfoListInner(this.Config.KeyInfoList);
		}

		// Token: 0x060323FA RID: 205818 RVA: 0x00E159FE File Offset: 0x00E13BFE
		public void SetKeyType(int keyType)
		{
			this.KeyType = keyType;
		}

		// Token: 0x060323FB RID: 205819 RVA: 0x00E15A07 File Offset: 0x00E13C07
		public void SwitchToKeyInfoList(List<SpecialEnergyBarKeyInfo> keyInfoList)
		{
			this.SwitchToKeyInfoListInner(keyInfoList);
		}

		// Token: 0x060323FC RID: 205820 RVA: 0x00E15A10 File Offset: 0x00E13C10
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

		// Token: 0x060323FD RID: 205821 RVA: 0x00E15AB8 File Offset: 0x00E13CB8
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

		// Token: 0x060323FE RID: 205822 RVA: 0x00E15B07 File Offset: 0x00E13D07
		public void RefreshKeyEnable(bool enable, bool bForce)
		{
			InputMultiKeyItemGroup keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.SetEnable(enable, bForce);
		}

		// Token: 0x0401AA05 RID: 109061
		[Nullable(2)]
		private InputMultiKeyItemGroup KeyItem;

		// Token: 0x0401AA06 RID: 109062
		[Nullable(2)]
		private SpecialEnergyBarInfo Config;

		// Token: 0x0401AA07 RID: 109063
		private int KeyType;

		// Token: 0x0200ABA4 RID: 43940
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x040351E7 RID: 217575
			InputMultiKeyItemGroupItem
		}
	}
}
