using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles;
using CSharpScript.Game.Module.Map.Marks.SubPanel;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x020044EF RID: 17647
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaNpcMarkItemView : ConfigMarkItemView
	{
		// Token: 0x0602C91F RID: 182559 RVA: 0x00C834ED File Offset: 0x00C816ED
		public PhantomArenaNpcMarkItemView(PhantomArenaNpcMarkItem markItem) : base(markItem)
		{
		}

		// Token: 0x0602C920 RID: 182560 RVA: 0x00C834F8 File Offset: 0x00C816F8
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaNpcMarkItemView.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaNpcMarkItemView.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602C921 RID: 182561 RVA: 0x00C8353B File Offset: 0x00C8173B
		protected override void OnBeforeDestroy()
		{
			PhantomArenaMapNpcUi phantomArenaMapNpcUi = this.PhantomArenaMapNpcUi;
			if (phantomArenaMapNpcUi != null)
			{
				phantomArenaMapNpcUi.Destroy(null);
			}
			base.OnBeforeDestroy();
		}

		// Token: 0x0602C922 RID: 182562 RVA: 0x00C83558 File Offset: 0x00C81758
		protected override void OnSafeUpdate(Vector playerLocation, bool bDragging = false, bool bIsScale = false)
		{
			if (MapModel.Instance.IsExtraUiMarkType(this.Holder.MapType, this.Holder.MarkType))
			{
				UUIItem item = base.GetItem(0);
				if (item != null)
				{
					item.SetUIActive(false);
				}
				PhantomArenaMapNpcUi phantomArenaMapNpcUi = this.PhantomArenaMapNpcUi;
				if (phantomArenaMapNpcUi != null)
				{
					phantomArenaMapNpcUi.SetData(this.Holder.MarkId);
				}
				PhantomArenaMapNpcUi phantomArenaMapNpcUi2 = this.PhantomArenaMapNpcUi;
				if (phantomArenaMapNpcUi2 == null)
				{
					return;
				}
				phantomArenaMapNpcUi2.SetActive(true);
				return;
			}
			else
			{
				UUIItem item2 = base.GetItem(0);
				if (item2 != null)
				{
					item2.SetUIActive(true);
				}
				PhantomArenaMapNpcUi phantomArenaMapNpcUi3 = this.PhantomArenaMapNpcUi;
				if (phantomArenaMapNpcUi3 == null)
				{
					return;
				}
				phantomArenaMapNpcUi3.SetActive(false);
				return;
			}
		}

		// Token: 0x0602C923 RID: 182563 RVA: 0x00C835EC File Offset: 0x00C817EC
		[PreserveBaseOverrides]
		protected new virtual MarkItemSelectHandle CreateSelectHandle(IMarkItemComponentContext markComponentContext)
		{
			return new PhantomArenaNpcMarkItemSelectHandle(markComponentContext);
		}

		// Token: 0x0602C924 RID: 182564 RVA: 0x00C835F4 File Offset: 0x00C817F4
		[NullableContext(2)]
		public override UUIItem GetIconItem()
		{
			PhantomArenaMapNpcUi phantomArenaMapNpcUi = this.PhantomArenaMapNpcUi;
			if (phantomArenaMapNpcUi == null)
			{
				return null;
			}
			return phantomArenaMapNpcUi.GetRootItem();
		}

		// Token: 0x04017EA9 RID: 97961
		[Nullable(2)]
		private PhantomArenaMapNpcUi PhantomArenaMapNpcUi;
	}
}
