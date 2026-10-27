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
	// Token: 0x02005CDE RID: 23774
	public class BattleSkillCombineItem : UiPanelBase
	{
		// Token: 0x0603C28A RID: 246410 RVA: 0x00E669AC File Offset: 0x00E64BAC
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

		// Token: 0x0603C28B RID: 246411 RVA: 0x00E669F4 File Offset: 0x00E64BF4
		protected override UniTask OnBeforeStartAsync()
		{
			BattleSkillCombineItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BattleSkillCombineItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C28C RID: 246412 RVA: 0x00E66A37 File Offset: 0x00E64C37
		protected override void OnStart()
		{
		}

		// Token: 0x0603C28D RID: 246413 RVA: 0x00E66A39 File Offset: 0x00E64C39
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

		// Token: 0x0603C28E RID: 246414 RVA: 0x00E66A5D File Offset: 0x00E64C5D
		public void Refresh()
		{
			CommonKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.RefreshAction("组合主键");
		}

		// Token: 0x0401F5C5 RID: 128453
		[Nullable(2)]
		private CommonKeyItem KeyItem;

		// Token: 0x0200BF35 RID: 48949
		private enum EChildType
		{
			// Token: 0x04039ACC RID: 236236
			KeyItem
		}
	}
}
