using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005738 RID: 22328
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlCombineEnsureLineItem : UiPanelBase
	{
		// Token: 0x06036FA4 RID: 225188 RVA: 0x00F56DFC File Offset: 0x00F54FFC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06036FA5 RID: 225189 RVA: 0x00F56E88 File Offset: 0x00F55088
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlCombineEnsureLineItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlCombineEnsureLineItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036FA6 RID: 225190 RVA: 0x00F56ECB File Offset: 0x00F550CB
		public void Refresh(DangoBrawlCombineLineCluster cluster)
		{
			this.Cluster = cluster;
			this.RefreshButton();
			this.RefreshLines();
		}

		// Token: 0x06036FA7 RID: 225191 RVA: 0x00F56EE0 File Offset: 0x00F550E0
		private FVector2D? GetItemLinkLguiPos(int uid)
		{
			FVector2D value;
			if (this.Cluster.UidToLgui.TryGetValue(uid, out value))
			{
				return new FVector2D?(value);
			}
			return null;
		}

		// Token: 0x06036FA8 RID: 225192 RVA: 0x00F56F14 File Offset: 0x00F55114
		private void SetChildLocalByLgui(UUIItem child, FVector2D lguiPos)
		{
			if (this.RootItem == null || !this.RootItem.IsValid())
			{
				Log.Instance.Warn(ELogModule.DangoBrawl, ELogAuthor.LSH, "[CombineEnsureLine] SetChildLocalByLgui: RootItem invalid", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			FVector lguispaceAbsolutePosition = this.RootItem.GetLGUISpaceAbsolutePosition();
			child.SetUIRelativeLocation(new FVector(lguiPos.X - lguispaceAbsolutePosition.X, lguiPos.Y - lguispaceAbsolutePosition.Y, 0f));
		}

		// Token: 0x06036FA9 RID: 225193 RVA: 0x00F56F8C File Offset: 0x00F5518C
		private static float CalcDistance(FVector2D a, FVector2D b)
		{
			float num = b.X - a.X;
			float num2 = b.Y - a.Y;
			return (float)Math.Sqrt((double)(num * num + num2 * num2));
		}

		// Token: 0x06036FAA RID: 225194 RVA: 0x00F56FC4 File Offset: 0x00F551C4
		private UniTask CreateCombineButton()
		{
			DangoBrawlCombineEnsureLineItem.<CreateCombineButton>d__11 <CreateCombineButton>d__;
			<CreateCombineButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCombineButton>d__.<>4__this = this;
			<CreateCombineButton>d__.<>1__state = -1;
			<CreateCombineButton>d__.<>t__builder.Start<DangoBrawlCombineEnsureLineItem.<CreateCombineButton>d__11>(ref <CreateCombineButton>d__);
			return <CreateCombineButton>d__.<>t__builder.Task;
		}

		// Token: 0x06036FAB RID: 225195 RVA: 0x00F57008 File Offset: 0x00F55208
		private void RefreshButton()
		{
			DangoBrawlCombineEnsureLineItemButton button = this.Button;
			UUIItem uuiitem = (button != null) ? button.GetRootItem() : null;
			if (uuiitem == null || !uuiitem.IsValid() || this.RootItem == null || !this.RootItem.IsValid())
			{
				return;
			}
			FVector2D? itemLinkLguiPos = this.GetItemLinkLguiPos(this.Cluster.MainUid);
			if (itemLinkLguiPos == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DangoBrawl;
				ELogAuthor author = ELogAuthor.LSH;
				string message = "[CombineEnsureLine] RefreshButton: mainLgui null";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("mainUid", this.Cluster.MainUid);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				uuiitem.SetUIActive(false);
				return;
			}
			this.SetChildLocalByLgui(uuiitem, itemLinkLguiPos.Value);
			DangoBrawlCombineEnsureLineItemButton button2 = this.Button;
			if (button2 != null)
			{
				button2.Refresh(this.Cluster.Row);
			}
			uuiitem.SetUIActive(true);
		}

		// Token: 0x06036FAC RID: 225196 RVA: 0x00F570D8 File Offset: 0x00F552D8
		private unsafe void RefreshLines()
		{
			if (this.RootItem == null || !this.RootItem.IsValid())
			{
				return;
			}
			ValueTuple<int, int>[] array = this.Cluster.Edges ?? Array.Empty<ValueTuple<int, int>>();
			this.EnsurePoolSize(array.Length);
			foreach (UUIItem uuiitem in this.LinePool)
			{
				uuiitem.SetUIActive(false);
			}
			int num = 0;
			while (num < array.Length && num < this.LinePool.Count)
			{
				UUIItem uuiitem2 = this.LinePool[num];
				if (uuiitem2.IsValid())
				{
					FVector2D? itemLinkLguiPos = this.GetItemLinkLguiPos(array[num].Item1);
					FVector2D? itemLinkLguiPos2 = this.GetItemLinkLguiPos(array[num].Item2);
					if (itemLinkLguiPos == null || itemLinkLguiPos2 == null)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.DangoBrawl;
						ELogAuthor author = ELogAuthor.LSH;
						string message = "[CombineEnsureLine] RefreshLines: endpoint null";
						<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("fromUid", array[num].Item1);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("toUid", array[num].Item2);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("fromNull", itemLinkLguiPos == null);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("toNull", itemLinkLguiPos2 == null);
						instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
						uuiitem2.SetUIActive(false);
					}
					else
					{
						this.ApplyLineTransform(uuiitem2, itemLinkLguiPos.Value, itemLinkLguiPos2.Value);
						uuiitem2.SetUIActive(true);
					}
				}
				num++;
			}
		}

		// Token: 0x06036FAD RID: 225197 RVA: 0x00F572C4 File Offset: 0x00F554C4
		private void ApplyLineTransform(UUIItem line, FVector2D from, FVector2D to)
		{
			this.SetChildLocalByLgui(line, from);
			line.SetWidth(DangoBrawlCombineEnsureLineItem.CalcDistance(from, to));
			FRotator frotator = new FRotator(0f, DangoBrawlCombineUtil.CalcCombineLineAngleDeg(from, to), 0f);
			line.SetUIRelativeRotation(frotator);
		}

		// Token: 0x06036FAE RID: 225198 RVA: 0x00F57308 File Offset: 0x00F55508
		private void EnsurePoolSize(int size)
		{
			UUIItem item = base.GetItem(2);
			if (item == null || this.RootItem == null || !this.RootItem.IsValid())
			{
				return;
			}
			while (this.LinePool.Count < size)
			{
				UUIItem uuiitem = LguiUtil.Instance.CopyItem(item, this.RootItem);
				uuiitem.SetUIActive(false);
				this.LinePool.Add(uuiitem);
			}
		}

		// Token: 0x0401D18F RID: 119183
		private ActivityDangoBrawlData ActData;

		// Token: 0x0401D190 RID: 119184
		private DangoBrawlCombineLineCluster Cluster;

		// Token: 0x0401D191 RID: 119185
		[Nullable(2)]
		private DangoBrawlCombineEnsureLineItemButton Button;

		// Token: 0x0401D192 RID: 119186
		private readonly List<UUIItem> LinePool = new List<UUIItem>();

		// Token: 0x0200B2E5 RID: 45797
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403745A RID: 226394
			BtnCombine,
			// Token: 0x0403745B RID: 226395
			ContentLine,
			// Token: 0x0403745C RID: 226396
			TemplateLine
		}
	}
}
