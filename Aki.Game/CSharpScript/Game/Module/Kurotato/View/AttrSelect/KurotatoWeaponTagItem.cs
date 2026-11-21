using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.AttrSelect
{
	// Token: 0x02004758 RID: 18264
	public class KurotatoWeaponTagItem : UiPanelBase
	{
		// Token: 0x0602DD8C RID: 187788 RVA: 0x00CD4EA0 File Offset: 0x00CD30A0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.OnClickTag));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602DD8D RID: 187789 RVA: 0x00CD4FA9 File Offset: 0x00CD31A9
		private void OnClickTag(EToggleState state)
		{
			Action<List<IKurotatoWeaponBuildData>, EToggleState> clickCb = this.ClickCb;
			if (clickCb == null)
			{
				return;
			}
			clickCb(this.DataList, state);
		}

		// Token: 0x0602DD8E RID: 187790 RVA: 0x00CD4FC4 File Offset: 0x00CD31C4
		[NullableContext(1)]
		public void Refresh(List<IKurotatoWeaponBuildData> dataList)
		{
			this.DataList = dataList;
			KurotatoConfig instance = KurotatoConfig.Instance;
			KurotatoModel instance2 = KurotatoModel.Instance;
			IKurotatoWeaponBuildData kurotatoWeaponBuildData = dataList[0];
			string text = ConfigMultiTextLang.GetLocalTextNew(instance.GetWeaponBuildById(kurotatoWeaponBuildData.BuildId).Value.Name, null) ?? "";
			int weaponBuildLevelByBuildId = instance2.GetWeaponBuildLevelByBuildId(kurotatoWeaponBuildData.BuildId);
			string text2;
			if (!this.IsOutside)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
				defaultInterpolatedStringHandler.AppendFormatted(text);
				defaultInterpolatedStringHandler.AppendLiteral(" (");
				defaultInterpolatedStringHandler.AppendFormatted<int>(weaponBuildLevelByBuildId);
				defaultInterpolatedStringHandler.AppendLiteral(")");
				text2 = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			else
			{
				text2 = text;
			}
			string newText = text2;
			base.GetText(1).SetText(newText, true);
			bool flag = dataList.Count > 1;
			base.GetText(3).SetUIActive(flag);
			base.GetSprite(4).SetUIActive(flag);
			if (flag)
			{
				IKurotatoWeaponBuildData kurotatoWeaponBuildData2 = dataList[1];
				string text3 = ConfigMultiTextLang.GetLocalTextNew(instance.GetWeaponBuildById(kurotatoWeaponBuildData2.BuildId).Value.Name, null) ?? "";
				int weaponBuildLevelByBuildId2 = instance2.GetWeaponBuildLevelByBuildId(kurotatoWeaponBuildData2.BuildId);
				string text4;
				if (!this.IsOutside)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
					defaultInterpolatedStringHandler.AppendFormatted(text3);
					defaultInterpolatedStringHandler.AppendLiteral(" (");
					defaultInterpolatedStringHandler.AppendFormatted<int>(weaponBuildLevelByBuildId2);
					defaultInterpolatedStringHandler.AppendLiteral(")");
					text4 = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				else
				{
					text4 = text3;
				}
				string newText2 = text4;
				base.GetText(3).SetText(newText2, true);
			}
		}

		// Token: 0x0602DD8F RID: 187791 RVA: 0x00CD514C File Offset: 0x00CD334C
		[NullableContext(1)]
		public void SetClickCb(Action<List<IKurotatoWeaponBuildData>, EToggleState> cb)
		{
			this.ClickCb = cb;
		}

		// Token: 0x0602DD90 RID: 187792 RVA: 0x00CD5158 File Offset: 0x00CD3358
		public void SetChecked(bool isChecked)
		{
			EToggleState state = isChecked ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(2).SetToggleStateForce(state, false, false, false);
		}

		// Token: 0x0602DD91 RID: 187793 RVA: 0x00CD517D File Offset: 0x00CD337D
		public bool IsChecked()
		{
			return base.GetExtendToggle(2).GetToggleState() == EToggleState.ETT_Checked;
		}

		// Token: 0x0602DD92 RID: 187794 RVA: 0x00CD518E File Offset: 0x00CD338E
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IKurotatoWeaponBuildData> GetDataList()
		{
			return this.DataList;
		}

		// Token: 0x040187EF RID: 100335
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IKurotatoWeaponBuildData> DataList;

		// Token: 0x040187F0 RID: 100336
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Action<List<IKurotatoWeaponBuildData>, EToggleState> ClickCb;

		// Token: 0x040187F1 RID: 100337
		public bool IsOutside;

		// Token: 0x0200A3B9 RID: 41913
		private class ETagChildComp
		{
			// Token: 0x04032C00 RID: 207872
			public const int PanelOffset = 0;

			// Token: 0x04032C01 RID: 207873
			public const int TextName = 1;

			// Token: 0x04032C02 RID: 207874
			public const int Toggle = 2;

			// Token: 0x04032C03 RID: 207875
			public const int TextName2 = 3;

			// Token: 0x04032C04 RID: 207876
			public const int SpriteLine = 4;
		}
	}
}
