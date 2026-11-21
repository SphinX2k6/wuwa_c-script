using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Phantom.Vision.View
{
	// Token: 0x02003529 RID: 13609
	[NullableContext(1)]
	[Nullable(0)]
	public class VisionDetailDescItem : UiPanelBase
	{
		// Token: 0x06022A3B RID: 141883 RVA: 0x009DB410 File Offset: 0x009D9610
		public void Clear()
		{
		}

		// Token: 0x06022A3C RID: 141884 RVA: 0x009DB412 File Offset: 0x009D9612
		public VisionDetailDescItem(UUIItem actor)
		{
			this.SourceItem = actor;
		}

		// Token: 0x06022A3D RID: 141885 RVA: 0x009DB424 File Offset: 0x009D9624
		public UniTask Init()
		{
			VisionDetailDescItem.<Init>d__6 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<VisionDetailDescItem.<Init>d__6>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06022A3E RID: 141886 RVA: 0x009DB468 File Offset: 0x009D9668
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickJumpButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06022A3F RID: 141887 RVA: 0x009DB5F6 File Offset: 0x009D97F6
		protected override void OnStart()
		{
			this.Layout = new GenericLayout<VisionDetailDescContentItem, VisionDetailDesc>(base.GetVerticalLayout(7), new Func<VisionDetailDescContentItem>(this.InitItem), null, false, true);
			base.GetItem(3).SetUIActive(false);
		}

		// Token: 0x06022A40 RID: 141888 RVA: 0x009DB626 File Offset: 0x009D9826
		private VisionDetailDescContentItem InitItem()
		{
			return new VisionDetailDescContentItem();
		}

		// Token: 0x06022A41 RID: 141889 RVA: 0x009DB62D File Offset: 0x009D982D
		private void OnClickJumpButton()
		{
			if (this.Data != null && this.Data.JumpCallBack != null)
			{
				this.Data.JumpCallBack();
			}
		}

		// Token: 0x06022A42 RID: 141890 RVA: 0x009DB654 File Offset: 0x009D9854
		public void Update(List<VisionDetailDesc> dataList)
		{
			VisionDetailDesc visionDetailDesc = null;
			List<VisionDetailDesc> list = new List<VisionDetailDesc>();
			foreach (VisionDetailDesc visionDetailDesc2 in dataList)
			{
				if (visionDetailDesc2.SkillConfig != null || (visionDetailDesc2.TitleItemShowState && visionDetailDesc2.TitleType == 0))
				{
					visionDetailDesc = visionDetailDesc2;
					if (visionDetailDesc2.SkillConfig != null)
					{
						list.Add(visionDetailDesc);
					}
				}
				if (visionDetailDesc2.FetterId > 0 || (visionDetailDesc2.TitleItemShowState && visionDetailDesc2.TitleType == 1) || visionDetailDesc2.GetNeedWarn())
				{
					if (visionDetailDesc2.TitleItemShowState)
					{
						visionDetailDesc = visionDetailDesc2;
					}
					if (visionDetailDesc2.FetterId > 0 || visionDetailDesc2.GetNeedWarn())
					{
						list.Add(visionDetailDesc2);
					}
				}
			}
			this.Data = visionDetailDesc;
			if (visionDetailDesc != null)
			{
				this.RefreshTitle(visionDetailDesc);
				this.RefreshJumpButton(visionDetailDesc);
				this.RefreshEmpty(visionDetailDesc);
				this.RefreshTitleItem(visionDetailDesc);
				this.RefreshEmptyContentItem(visionDetailDesc);
				this.RefreshDesc(list);
			}
		}

		// Token: 0x06022A43 RID: 141891 RVA: 0x009DB754 File Offset: 0x009D9954
		private void RefreshDesc(List<VisionDetailDesc> data)
		{
			GenericLayout<VisionDetailDescContentItem, VisionDetailDesc> layout = this.Layout;
			if (layout == null)
			{
				return;
			}
			layout.RefreshByData(data, null, false);
		}

		// Token: 0x06022A44 RID: 141892 RVA: 0x009DB769 File Offset: 0x009D9969
		private void RefreshTitle(VisionDetailDesc data)
		{
			base.GetText(0).SetText(data.Title, true);
		}

		// Token: 0x06022A45 RID: 141893 RVA: 0x009DB780 File Offset: 0x009D9980
		private void RefreshJumpButton(VisionDetailDesc data)
		{
			base.GetButton(1).RootUIComp.Get().SetUIActive(data.JumpCallBack != null && !data.CompareState);
		}

		// Token: 0x06022A46 RID: 141894 RVA: 0x009DB7BA File Offset: 0x009D99BA
		private void RefreshEmpty(VisionDetailDesc data)
		{
			base.GetItem(2).SetUIActive(data.EmptyState);
			if (data.EmptyState)
			{
				base.GetItem(8).SetUIActive(data.TitleType == 0);
			}
		}

		// Token: 0x06022A47 RID: 141895 RVA: 0x009DB7EB File Offset: 0x009D99EB
		private void RefreshEmptyContentItem(VisionDetailDesc data)
		{
			base.GetText(5).SetText(data.EmptyText, true);
		}

		// Token: 0x06022A48 RID: 141896 RVA: 0x009DB800 File Offset: 0x009D9A00
		private void RefreshTitleItem(VisionDetailDesc data)
		{
			base.GetItem(4).SetUIActive(data.TitleItemShowState);
		}

		// Token: 0x04013313 RID: 78611
		[Nullable(2)]
		private readonly UUIItem SourceItem;

		// Token: 0x04013314 RID: 78612
		[Nullable(2)]
		protected VisionDetailDesc CurrentData;

		// Token: 0x04013315 RID: 78613
		[Nullable(2)]
		private VisionDetailDesc Data;

		// Token: 0x04013316 RID: 78614
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<VisionDetailDescContentItem, VisionDetailDesc> Layout;
	}
}
