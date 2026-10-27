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
	// Token: 0x02004600 RID: 17920
	[NullableContext(1)]
	[Nullable(0)]
	public class VisionDetailDescItem : UiPanelBase
	{
		// Token: 0x0602E346 RID: 189254 RVA: 0x00AAED1C File Offset: 0x00AACF1C
		public void Clear()
		{
		}

		// Token: 0x0602E347 RID: 189255 RVA: 0x00AAED1E File Offset: 0x00AACF1E
		public VisionDetailDescItem(UUIItem actor)
		{
			this.SourceItem = actor;
		}

		// Token: 0x0602E348 RID: 189256 RVA: 0x00AAED30 File Offset: 0x00AACF30
		public UniTask Init()
		{
			VisionDetailDescItem.<Init>d__6 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<VisionDetailDescItem.<Init>d__6>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0602E349 RID: 189257 RVA: 0x00AAED74 File Offset: 0x00AACF74
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

		// Token: 0x0602E34A RID: 189258 RVA: 0x00AAEF02 File Offset: 0x00AAD102
		protected override void OnStart()
		{
			this.Layout = new GenericLayout<VisionDetailDescContentItem, VisionDetailDesc>(base.GetVerticalLayout(7), new Func<VisionDetailDescContentItem>(this.InitItem), null, false, true);
			base.GetItem(3).SetUIActive(false);
		}

		// Token: 0x0602E34B RID: 189259 RVA: 0x00AAEF32 File Offset: 0x00AAD132
		private VisionDetailDescContentItem InitItem()
		{
			return new VisionDetailDescContentItem();
		}

		// Token: 0x0602E34C RID: 189260 RVA: 0x00AAEF39 File Offset: 0x00AAD139
		private void OnClickJumpButton()
		{
			if (this.Data != null && this.Data.JumpCallBack != null)
			{
				this.Data.JumpCallBack();
			}
		}

		// Token: 0x0602E34D RID: 189261 RVA: 0x00AAEF60 File Offset: 0x00AAD160
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

		// Token: 0x0602E34E RID: 189262 RVA: 0x00AAF060 File Offset: 0x00AAD260
		private void RefreshDesc(List<VisionDetailDesc> data)
		{
			GenericLayout<VisionDetailDescContentItem, VisionDetailDesc> layout = this.Layout;
			if (layout == null)
			{
				return;
			}
			layout.RefreshByData(data, null, false);
		}

		// Token: 0x0602E34F RID: 189263 RVA: 0x00AAF075 File Offset: 0x00AAD275
		private void RefreshTitle(VisionDetailDesc data)
		{
			base.GetText(0).SetText(data.Title, true);
		}

		// Token: 0x0602E350 RID: 189264 RVA: 0x00AAF08C File Offset: 0x00AAD28C
		private void RefreshJumpButton(VisionDetailDesc data)
		{
			base.GetButton(1).RootUIComp.Get().SetUIActive(data.JumpCallBack != null && !data.CompareState);
		}

		// Token: 0x0602E351 RID: 189265 RVA: 0x00AAF0C6 File Offset: 0x00AAD2C6
		private void RefreshEmpty(VisionDetailDesc data)
		{
			base.GetItem(2).SetUIActive(data.EmptyState);
			if (data.EmptyState)
			{
				base.GetItem(8).SetUIActive(data.TitleType == 0);
			}
		}

		// Token: 0x0602E352 RID: 189266 RVA: 0x00AAF0F7 File Offset: 0x00AAD2F7
		private void RefreshEmptyContentItem(VisionDetailDesc data)
		{
			base.GetText(5).SetText(data.EmptyText, true);
		}

		// Token: 0x0602E353 RID: 189267 RVA: 0x00AAF10C File Offset: 0x00AAD30C
		private void RefreshTitleItem(VisionDetailDesc data)
		{
			base.GetItem(4).SetUIActive(data.TitleItemShowState);
		}

		// Token: 0x04018CD4 RID: 101588
		[Nullable(2)]
		private readonly UUIItem SourceItem;

		// Token: 0x04018CD5 RID: 101589
		[Nullable(2)]
		protected VisionDetailDesc CurrentData;

		// Token: 0x04018CD6 RID: 101590
		[Nullable(2)]
		private VisionDetailDesc Data;

		// Token: 0x04018CD7 RID: 101591
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<VisionDetailDescContentItem, VisionDetailDesc> Layout;
	}
}
