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
	// Token: 0x020067E8 RID: 26600
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlCombineEnsureLineItem : UiPanelBase
	{
		// Token: 0x0604244E RID: 271438 RVA: 0x01015964 File Offset: 0x01013B64
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

		// Token: 0x0604244F RID: 271439 RVA: 0x010159F0 File Offset: 0x01013BF0
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlCombineEnsureLineItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlCombineEnsureLineItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042450 RID: 271440 RVA: 0x01015A33 File Offset: 0x01013C33
		public void Refresh(DangoBrawlCombineLineCluster cluster)
		{
			this.Cluster = cluster;
			this.RefreshButton();
			this.RefreshLines();
		}

		// Token: 0x06042451 RID: 271441 RVA: 0x01015A48 File Offset: 0x01013C48
		private FVector2D? GetItemLinkLguiPos(int uid)
		{
			FVector2D value;
			if (this.Cluster.UidToLgui.TryGetValue(uid, out value))
			{
				return new FVector2D?(value);
			}
			return null;
		}

		// Token: 0x06042452 RID: 271442 RVA: 0x01015A7C File Offset: 0x01013C7C
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

		// Token: 0x06042453 RID: 271443 RVA: 0x01015AF4 File Offset: 0x01013CF4
		private static float CalcDistance(FVector2D a, FVector2D b)
		{
			float num = b.X - a.X;
			float num2 = b.Y - a.Y;
			return (float)Math.Sqrt((double)(num * num + num2 * num2));
		}

		// Token: 0x06042454 RID: 271444 RVA: 0x01015B2C File Offset: 0x01013D2C
		private UniTask CreateCombineButton()
		{
			DangoBrawlCombineEnsureLineItem.<CreateCombineButton>d__11 <CreateCombineButton>d__;
			<CreateCombineButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCombineButton>d__.<>4__this = this;
			<CreateCombineButton>d__.<>1__state = -1;
			<CreateCombineButton>d__.<>t__builder.Start<DangoBrawlCombineEnsureLineItem.<CreateCombineButton>d__11>(ref <CreateCombineButton>d__);
			return <CreateCombineButton>d__.<>t__builder.Task;
		}

		// Token: 0x06042455 RID: 271445 RVA: 0x01015B70 File Offset: 0x01013D70
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

		// Token: 0x06042456 RID: 271446 RVA: 0x01015C40 File Offset: 0x01013E40
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

		// Token: 0x06042457 RID: 271447 RVA: 0x01015E2C File Offset: 0x0101402C
		private void ApplyLineTransform(UUIItem line, FVector2D from, FVector2D to)
		{
			this.SetChildLocalByLgui(line, from);
			line.SetWidth(DangoBrawlCombineEnsureLineItem.CalcDistance(from, to));
			FRotator frotator = new FRotator(0f, DangoBrawlCombineUtil.CalcCombineLineAngleDeg(from, to), 0f);
			line.SetUIRelativeRotation(frotator);
		}

		// Token: 0x06042458 RID: 271448 RVA: 0x01015E70 File Offset: 0x01014070
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

		// Token: 0x04022932 RID: 141618
		private ActivityDangoBrawlData ActData;

		// Token: 0x04022933 RID: 141619
		private DangoBrawlCombineLineCluster Cluster;

		// Token: 0x04022934 RID: 141620
		[Nullable(2)]
		private DangoBrawlCombineEnsureLineItemButton Button;

		// Token: 0x04022935 RID: 141621
		private readonly List<UUIItem> LinePool = new List<UUIItem>();

		// Token: 0x0200C917 RID: 51479
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403CB69 RID: 248681
			BtnCombine,
			// Token: 0x0403CB6A RID: 248682
			ContentLine,
			// Token: 0x0403CB6B RID: 248683
			TemplateLine
		}
	}
}
