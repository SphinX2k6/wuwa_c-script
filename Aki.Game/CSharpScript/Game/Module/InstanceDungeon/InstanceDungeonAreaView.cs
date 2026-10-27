using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x02005869 RID: 22633
	public class InstanceDungeonAreaView : UiViewBase
	{
		// Token: 0x060398A5 RID: 235685 RVA: 0x00DA9DD1 File Offset: 0x00DA7FD1
		[NullableContext(1)]
		public InstanceDungeonAreaView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060398A6 RID: 235686 RVA: 0x00DA9DDC File Offset: 0x00DA7FDC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060398A7 RID: 235687 RVA: 0x00DA9E24 File Offset: 0x00DA8024
		protected override void OnStart()
		{
			this.UiViewSequence.AddSequenceFinishEvent("Start", delegate(string _)
			{
				TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
				{
					base.CloseMe(null);
				}, 3000f, null, null, true, 1f);
			}, false);
		}

		// Token: 0x060398A8 RID: 235688 RVA: 0x00DA9E44 File Offset: 0x00DA8044
		private void SetName()
		{
			if (base.GetText(0) != null)
			{
				string instanceDungeonName = InstanceDungeonModel.Instance.GetInstanceDungeonName();
				if (!string.IsNullOrEmpty(instanceDungeonName))
				{
					base.GetText(0).SetText(instanceDungeonName, true);
				}
			}
		}

		// Token: 0x060398A9 RID: 235689 RVA: 0x00DA9E7B File Offset: 0x00DA807B
		protected override void OnBeforeShow()
		{
			this.SetName();
		}

		// Token: 0x0401E177 RID: 123255
		private const int SHOW_TIME = 3000;

		// Token: 0x0200BA8D RID: 47757
		private enum EChildCom
		{
			// Token: 0x04038630 RID: 230960
			AreaNameText
		}
	}
}
