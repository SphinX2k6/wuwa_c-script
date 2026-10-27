using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.AttrSelect
{
	// Token: 0x02005781 RID: 22401
	public class KurotatoWeaponTagItem : UiPanelBase
	{
		// Token: 0x06038E7C RID: 233084 RVA: 0x00D861E0 File Offset: 0x00D843E0
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

		// Token: 0x06038E7D RID: 233085 RVA: 0x00D862E9 File Offset: 0x00D844E9
		private void OnClickTag(EToggleState state)
		{
			Action<List<IKurotatoWeaponBuildData>, EToggleState> clickCb = this.ClickCb;
			if (clickCb == null)
			{
				return;
			}
			clickCb(this.DataList, state);
		}

		// Token: 0x06038E7E RID: 233086 RVA: 0x00D86304 File Offset: 0x00D84504
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

		// Token: 0x06038E7F RID: 233087 RVA: 0x00D8648C File Offset: 0x00D8468C
		[NullableContext(1)]
		public void SetClickCb(Action<List<IKurotatoWeaponBuildData>, EToggleState> cb)
		{
			this.ClickCb = cb;
		}

		// Token: 0x06038E80 RID: 233088 RVA: 0x00D86498 File Offset: 0x00D84698
		public void SetChecked(bool isChecked)
		{
			EToggleState state = isChecked ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(2).SetToggleStateForce(state, false, false, false);
		}

		// Token: 0x06038E81 RID: 233089 RVA: 0x00D864BD File Offset: 0x00D846BD
		public bool IsChecked()
		{
			return base.GetExtendToggle(2).GetToggleState() == EToggleState.ETT_Checked;
		}

		// Token: 0x06038E82 RID: 233090 RVA: 0x00D864CE File Offset: 0x00D846CE
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IKurotatoWeaponBuildData> GetDataList()
		{
			return this.DataList;
		}

		// Token: 0x0401DD59 RID: 122201
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IKurotatoWeaponBuildData> DataList;

		// Token: 0x0401DD5A RID: 122202
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Action<List<IKurotatoWeaponBuildData>, EToggleState> ClickCb;

		// Token: 0x0401DD5B RID: 122203
		public bool IsOutside;

		// Token: 0x0200B9A1 RID: 47521
		private class ETagChildComp
		{
			// Token: 0x0403820B RID: 229899
			public const int PanelOffset = 0;

			// Token: 0x0403820C RID: 229900
			public const int TextName = 1;

			// Token: 0x0403820D RID: 229901
			public const int Toggle = 2;

			// Token: 0x0403820E RID: 229902
			public const int TextName2 = 3;

			// Token: 0x0403820F RID: 229903
			public const int SpriteLine = 4;
		}
	}
}
