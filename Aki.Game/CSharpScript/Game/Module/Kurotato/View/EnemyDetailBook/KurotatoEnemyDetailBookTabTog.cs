using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.EnemyDetailBook
{
	// Token: 0x0200576F RID: 22383
	public class KurotatoEnemyDetailBookTabTog : GridProxyAbstract<EKurotatoEnemyDetailBookTabAllOrWave>
	{
		// Token: 0x06038DC1 RID: 232897 RVA: 0x00D8277C File Offset: 0x00D8097C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnTogClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038DC2 RID: 232898 RVA: 0x00D82843 File Offset: 0x00D80A43
		protected override void OnStart()
		{
			base.GetExtendToggle(0).CanExecuteChange.Bind(() => this.CanExecuteChangeFunc == null || this.CanExecuteChangeFunc(base.GridIndex));
		}

		// Token: 0x06038DC3 RID: 232899 RVA: 0x00D82862 File Offset: 0x00D80A62
		private void OnTogClick(EToggleState state)
		{
			if (this.Data != null)
			{
				Action<EKurotatoEnemyDetailBookTabAllOrWave> onTogClickCallBack = this.OnTogClickCallBack;
				if (onTogClickCallBack == null)
				{
					return;
				}
				onTogClickCallBack(this.Data.Value);
			}
		}

		// Token: 0x06038DC4 RID: 232900 RVA: 0x00D8288C File Offset: 0x00D80A8C
		public override void Refresh(EKurotatoEnemyDetailBookTabAllOrWave data, bool isSelected, int gridIndex)
		{
			this.Data = new EKurotatoEnemyDetailBookTabAllOrWave?(data);
			string textStringId = (data == EKurotatoEnemyDetailBookTabAllOrWave.All) ? "Survivor_Monster_Type" : "Survivor_Monster_Wave";
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, Array.Empty<object>());
		}

		// Token: 0x06038DC5 RID: 232901 RVA: 0x00D828CC File Offset: 0x00D80ACC
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleState(true);
		}

		// Token: 0x06038DC6 RID: 232902 RVA: 0x00D828D5 File Offset: 0x00D80AD5
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleState(false);
		}

		// Token: 0x06038DC7 RID: 232903 RVA: 0x00D828E0 File Offset: 0x00D80AE0
		private void SetToggleState(bool state)
		{
			EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state2, false, false, false);
		}

		// Token: 0x0401DD29 RID: 122153
		public EKurotatoEnemyDetailBookTabAllOrWave? Data;

		// Token: 0x0401DD2A RID: 122154
		[Nullable(2)]
		public Action<EKurotatoEnemyDetailBookTabAllOrWave> OnTogClickCallBack;

		// Token: 0x0401DD2B RID: 122155
		[Nullable(2)]
		public Func<int, bool> CanExecuteChangeFunc;

		// Token: 0x0200B979 RID: 47481
		private class ETabItemComponent
		{
			// Token: 0x0403815B RID: 229723
			public const int TogSelf = 0;

			// Token: 0x0403815C RID: 229724
			public const int TextTitle = 1;

			// Token: 0x0403815D RID: 229725
			public const int RedDot = 2;
		}
	}
}
