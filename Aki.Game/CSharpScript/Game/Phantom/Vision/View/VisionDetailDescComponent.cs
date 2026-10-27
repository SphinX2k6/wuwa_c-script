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
	// Token: 0x020045FE RID: 17918
	[NullableContext(2)]
	[Nullable(0)]
	public class VisionDetailDescComponent : UiPanelBase
	{
		// Token: 0x0602E339 RID: 189241 RVA: 0x00AAE992 File Offset: 0x00AACB92
		[NullableContext(1)]
		public VisionDetailDescComponent(UUIItem actor)
		{
			this.SourceItem = actor;
		}

		// Token: 0x0602E33A RID: 189242 RVA: 0x00AAE9A4 File Offset: 0x00AACBA4
		public UniTask Init()
		{
			VisionDetailDescComponent.<Init>d__7 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<VisionDetailDescComponent.<Init>d__7>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0602E33B RID: 189243 RVA: 0x00AAE9E8 File Offset: 0x00AACBE8
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

		// Token: 0x0602E33C RID: 189244 RVA: 0x00AAEA94 File Offset: 0x00AACC94
		protected override UniTask OnBeforeStartAsync()
		{
			VisionDetailDescComponent.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<VisionDetailDescComponent.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E33D RID: 189245 RVA: 0x00AAEAD7 File Offset: 0x00AACCD7
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

		// Token: 0x0602E33E RID: 189246 RVA: 0x00AAEAFA File Offset: 0x00AACCFA
		protected override void OnStart()
		{
			this.AddEvent();
		}

		// Token: 0x0602E33F RID: 189247 RVA: 0x00AAEB02 File Offset: 0x00AACD02
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

		// Token: 0x0602E340 RID: 189248 RVA: 0x00AAEB23 File Offset: 0x00AACD23
		private void AddEvent()
		{
			EventSystem.Instance.Add(EEventName.ChangeVisionSimplyState, new Action(this.OnChangeVisionSimplyState));
			EventSystem.Instance.Add<int>(EEventName.GuideGroupFinished, new Action<int>(this.OnGuideDone));
		}

		// Token: 0x0602E341 RID: 189249 RVA: 0x00AAEB5D File Offset: 0x00AACD5D
		private void RemoveEvent()
		{
			EventSystem.Instance.Remove(EEventName.ChangeVisionSimplyState, new Action(this.OnChangeVisionSimplyState));
			EventSystem.Instance.Remove(EEventName.GuideGroupFinished, new Action<int>(this.OnGuideDone));
		}

		// Token: 0x0602E342 RID: 189250 RVA: 0x00AAEB98 File Offset: 0x00AACD98
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

		// Token: 0x0602E343 RID: 189251 RVA: 0x00AAEC00 File Offset: 0x00AACE00
		private void OnGuideDone(int groupId)
		{
			this.FocusVision = false;
		}

		// Token: 0x0602E344 RID: 189252 RVA: 0x00AAEC0C File Offset: 0x00AACE0C
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

		// Token: 0x0602E345 RID: 189253 RVA: 0x00AAED14 File Offset: 0x00AACF14
		protected override void OnBeforeDestroy()
		{
			this.RemoveEvent();
		}

		// Token: 0x04018CC5 RID: 101573
		private readonly UUIItem SourceItem;

		// Token: 0x04018CC6 RID: 101574
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<VisionDetailDesc> CurrentData;

		// Token: 0x04018CC7 RID: 101575
		private VisionDetailDescItem SkillDesc;

		// Token: 0x04018CC8 RID: 101576
		private VisionDetailDescItem VisionDesc;

		// Token: 0x04018CC9 RID: 101577
		private bool FocusVision;

		// Token: 0x0200A845 RID: 43077
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x040333A3 RID: 209827
			AttributeLayout,
			// Token: 0x040333A4 RID: 209828
			DescItem1,
			// Token: 0x040333A5 RID: 209829
			DescItem2,
			// Token: 0x040333A6 RID: 209830
			Layout
		}
	}
}
