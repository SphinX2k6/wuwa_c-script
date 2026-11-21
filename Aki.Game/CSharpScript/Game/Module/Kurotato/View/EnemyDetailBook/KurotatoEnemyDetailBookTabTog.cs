using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.EnemyDetailBook
{
	// Token: 0x02004746 RID: 18246
	public class KurotatoEnemyDetailBookTabTog : GridProxyAbstract<EKurotatoEnemyDetailBookTabAllOrWave>
	{
		// Token: 0x0602DCD1 RID: 187601 RVA: 0x00CD1278 File Offset: 0x00CCF478
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

		// Token: 0x0602DCD2 RID: 187602 RVA: 0x00CD133F File Offset: 0x00CCF53F
		protected override void OnStart()
		{
			base.GetExtendToggle(0).CanExecuteChange.Bind(() => this.CanExecuteChangeFunc == null || this.CanExecuteChangeFunc(base.GridIndex));
		}

		// Token: 0x0602DCD3 RID: 187603 RVA: 0x00CD135E File Offset: 0x00CCF55E
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

		// Token: 0x0602DCD4 RID: 187604 RVA: 0x00CD1388 File Offset: 0x00CCF588
		public override void Refresh(EKurotatoEnemyDetailBookTabAllOrWave data, bool isSelected, int gridIndex)
		{
			this.Data = new EKurotatoEnemyDetailBookTabAllOrWave?(data);
			string textStringId = (data == EKurotatoEnemyDetailBookTabAllOrWave.All) ? "Survivor_Monster_Type" : "Survivor_Monster_Wave";
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, Array.Empty<object>());
		}

		// Token: 0x0602DCD5 RID: 187605 RVA: 0x00CD13C8 File Offset: 0x00CCF5C8
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleState(true);
		}

		// Token: 0x0602DCD6 RID: 187606 RVA: 0x00CD13D1 File Offset: 0x00CCF5D1
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleState(false);
		}

		// Token: 0x0602DCD7 RID: 187607 RVA: 0x00CD13DC File Offset: 0x00CCF5DC
		private void SetToggleState(bool state)
		{
			EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state2, false, false, false);
		}

		// Token: 0x040187BF RID: 100287
		public EKurotatoEnemyDetailBookTabAllOrWave? Data;

		// Token: 0x040187C0 RID: 100288
		[Nullable(2)]
		public Action<EKurotatoEnemyDetailBookTabAllOrWave> OnTogClickCallBack;

		// Token: 0x040187C1 RID: 100289
		[Nullable(2)]
		public Func<int, bool> CanExecuteChangeFunc;

		// Token: 0x0200A393 RID: 41875
		private class ETabItemComponent
		{
			// Token: 0x04032B55 RID: 207701
			public const int TogSelf = 0;

			// Token: 0x04032B56 RID: 207702
			public const int TextTitle = 1;

			// Token: 0x04032B57 RID: 207703
			public const int RedDot = 2;
		}
	}
}
