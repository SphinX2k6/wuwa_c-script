using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Phantom.Vision.View
{
	// Token: 0x02003527 RID: 13607
	[NullableContext(2)]
	[Nullable(0)]
	public class VisionDetailDescComponent : UiPanelBase
	{
		// Token: 0x06022A2E RID: 141870 RVA: 0x009DB086 File Offset: 0x009D9286
		[NullableContext(1)]
		public VisionDetailDescComponent(UUIItem actor)
		{
			this.SourceItem = actor;
		}

		// Token: 0x06022A2F RID: 141871 RVA: 0x009DB098 File Offset: 0x009D9298
		public UniTask Init()
		{
			VisionDetailDescComponent.<Init>d__7 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<VisionDetailDescComponent.<Init>d__7>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06022A30 RID: 141872 RVA: 0x009DB0DC File Offset: 0x009D92DC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06022A31 RID: 141873 RVA: 0x009DB188 File Offset: 0x009D9388
		protected override UniTask OnBeforeStartAsync()
		{
			VisionDetailDescComponent.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<VisionDetailDescComponent.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022A32 RID: 141874 RVA: 0x009DB1CB File Offset: 0x009D93CB
		[NullableContext(1)]
		private void OnLayoutRebuild(UUILayoutBase _)
		{
			if (this.FocusVision)
			{
				UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(0);
				if (scrollViewWithScrollbar == null)
				{
					return;
				}
				scrollViewWithScrollbar.ScrollTo(base.GetItem(2), false);
			}
		}

		// Token: 0x06022A33 RID: 141875 RVA: 0x009DB1EE File Offset: 0x009D93EE
		protected override void OnStart()
		{
			this.AddEvent();
		}

		// Token: 0x06022A34 RID: 141876 RVA: 0x009DB1F6 File Offset: 0x009D93F6
		public UUIItem GetTxtItemByIndex(int index)
		{
			if (index == 0)
			{
				return base.GetItem(1);
			}
			if (index == 1)
			{
				this.FocusVision = true;
				return base.GetItem(2);
			}
			return null;
		}

		// Token: 0x06022A35 RID: 141877 RVA: 0x009DB217 File Offset: 0x009D9417
		private void AddEvent()
		{
			EventSystem.Instance.Add(EEventName.ChangeVisionSimplyState, new Action(this.OnChangeVisionSimplyState));
			EventSystem.Instance.Add<int>(EEventName.GuideGroupFinished, new Action<int>(this.OnGuideDone));
		}

		// Token: 0x06022A36 RID: 141878 RVA: 0x009DB251 File Offset: 0x009D9451
		private void RemoveEvent()
		{
			EventSystem.Instance.Remove(EEventName.ChangeVisionSimplyState, new Action(this.OnChangeVisionSimplyState));
			EventSystem.Instance.Remove(EEventName.GuideGroupFinished, new Action<int>(this.OnGuideDone));
		}

		// Token: 0x06022A37 RID: 141879 RVA: 0x009DB28C File Offset: 0x009D948C
		private void OnChangeVisionSimplyState()
		{
			if (this.CurrentData != null)
			{
				foreach (VisionDetailDesc visionDetailDesc in this.CurrentData)
				{
					visionDetailDesc.NeedSimplyStateChangeAnimation = true;
				}
				this.Refresh(this.CurrentData, true);
			}
		}

		// Token: 0x06022A38 RID: 141880 RVA: 0x009DB2F4 File Offset: 0x009D94F4
		private void OnGuideDone(int groupId)
		{
			this.FocusVision = false;
		}

		// Token: 0x06022A39 RID: 141881 RVA: 0x009DB300 File Offset: 0x009D9500
		[NullableContext(1)]
		public void Refresh(List<VisionDetailDesc> data, bool fromSimplyStateChange = false)
		{
			this.CurrentData = data;
			List<VisionDetailDesc> list = new List<VisionDetailDesc>();
			List<VisionDetailDesc> list2 = new List<VisionDetailDesc>();
			foreach (VisionDetailDesc visionDetailDesc in data)
			{
				if (visionDetailDesc.SkillConfig != null || (visionDetailDesc.TitleItemShowState && visionDetailDesc.TitleType == 0))
				{
					list.Add(visionDetailDesc);
				}
				if (visionDetailDesc.FetterId > 0 || (visionDetailDesc.TitleItemShowState && visionDetailDesc.TitleType == 1) || visionDetailDesc.GetNeedWarn())
				{
					list2.Add(visionDetailDesc);
				}
			}
			VisionDetailDescItem skillDesc = this.SkillDesc;
			if (skillDesc != null)
			{
				skillDesc.Update(list);
			}
			VisionDetailDescItem visionDesc = this.VisionDesc;
			if (visionDesc != null)
			{
				visionDesc.Update(list2);
			}
			foreach (VisionDetailDesc visionDetailDesc2 in data)
			{
				visionDetailDesc2.NeedSimplyStateChangeAnimation = false;
			}
		}

		// Token: 0x06022A3A RID: 141882 RVA: 0x009DB408 File Offset: 0x009D9608
		protected override void OnBeforeDestroy()
		{
			this.RemoveEvent();
		}

		// Token: 0x04013304 RID: 78596
		private readonly UUIItem SourceItem;

		// Token: 0x04013305 RID: 78597
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<VisionDetailDesc> CurrentData;

		// Token: 0x04013306 RID: 78598
		private VisionDetailDescItem SkillDesc;

		// Token: 0x04013307 RID: 78599
		private VisionDetailDescItem VisionDesc;

		// Token: 0x04013308 RID: 78600
		private bool FocusVision;

		// Token: 0x020091FD RID: 37373
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0402DB31 RID: 187185
			AttributeLayout,
			// Token: 0x0402DB32 RID: 187186
			DescItem1,
			// Token: 0x0402DB33 RID: 187187
			DescItem2,
			// Token: 0x0402DB34 RID: 187188
			Layout
		}
	}
}
