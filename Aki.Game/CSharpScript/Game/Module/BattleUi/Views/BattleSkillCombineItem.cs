using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CC0 RID: 19648
	public class BattleSkillCombineItem : UiPanelBase
	{
		// Token: 0x060311E0 RID: 201184 RVA: 0x00DB6F60 File Offset: 0x00DB5160
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

		// Token: 0x060311E1 RID: 201185 RVA: 0x00DB6FA8 File Offset: 0x00DB51A8
		protected override UniTask OnBeforeStartAsync()
		{
			BattleSkillCombineItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BattleSkillCombineItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060311E2 RID: 201186 RVA: 0x00DB6FEB File Offset: 0x00DB51EB
		protected override void OnStart()
		{
		}

		// Token: 0x060311E3 RID: 201187 RVA: 0x00DB6FED File Offset: 0x00DB51ED
		public void SetVisible(bool bVisible)
		{
			if (bVisible)
			{
				if (!base.IsShowOrShowing)
				{
					base.Show(null);
					return;
				}
			}
			else if (base.IsShowOrShowing)
			{
				base.Hide(null);
			}
		}

		// Token: 0x060311E4 RID: 201188 RVA: 0x00DB7011 File Offset: 0x00DB5211
		public void Refresh()
		{
			CommonKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.RefreshAction("组合主键");
		}

		// Token: 0x0401A07E RID: 106622
		[Nullable(2)]
		private CommonKeyItem KeyItem;

		// Token: 0x0200A93B RID: 43323
		private enum EChildType
		{
			// Token: 0x0403448E RID: 214158
			KeyItem
		}
	}
}
