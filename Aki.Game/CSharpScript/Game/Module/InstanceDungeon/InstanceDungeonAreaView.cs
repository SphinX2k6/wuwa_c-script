using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x02004841 RID: 18497
	public class InstanceDungeonAreaView : UiViewBase
	{
		// Token: 0x0602E7C2 RID: 190402 RVA: 0x00CF8AF9 File Offset: 0x00CF6CF9
		[NullableContext(1)]
		public InstanceDungeonAreaView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602E7C3 RID: 190403 RVA: 0x00CF8B04 File Offset: 0x00CF6D04
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

		// Token: 0x0602E7C4 RID: 190404 RVA: 0x00CF8B4C File Offset: 0x00CF6D4C
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

		// Token: 0x0602E7C5 RID: 190405 RVA: 0x00CF8B6C File Offset: 0x00CF6D6C
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

		// Token: 0x0602E7C6 RID: 190406 RVA: 0x00CF8BA3 File Offset: 0x00CF6DA3
		protected override void OnBeforeShow()
		{
			this.SetName();
		}

		// Token: 0x04018C14 RID: 101396
		private const int SHOW_TIME = 3000;

		// Token: 0x0200A4A4 RID: 42148
		private enum EChildCom
		{
			// Token: 0x04033027 RID: 208935
			AreaNameText
		}
	}
}
