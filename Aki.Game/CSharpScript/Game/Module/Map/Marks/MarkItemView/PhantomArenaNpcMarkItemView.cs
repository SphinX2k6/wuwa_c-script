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
	// Token: 0x0200551C RID: 21788
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaNpcMarkItemView : ConfigMarkItemView
	{
		// Token: 0x06037A51 RID: 227921 RVA: 0x00D35719 File Offset: 0x00D33919
		public PhantomArenaNpcMarkItemView(PhantomArenaNpcMarkItem markItem) : base(markItem)
		{
		}

		// Token: 0x06037A52 RID: 227922 RVA: 0x00D35724 File Offset: 0x00D33924
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaNpcMarkItemView.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaNpcMarkItemView.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037A53 RID: 227923 RVA: 0x00D35768 File Offset: 0x00D33968
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

		// Token: 0x06037A54 RID: 227924 RVA: 0x00D357FC File Offset: 0x00D339FC
		[PreserveBaseOverrides]
		protected new virtual MarkItemSelectHandle CreateSelectHandle(IMarkItemComponentContext markComponentContext)
		{
			return new PhantomArenaNpcMarkItemSelectHandle(markComponentContext);
		}

		// Token: 0x06037A55 RID: 227925 RVA: 0x00D35804 File Offset: 0x00D33A04
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

		// Token: 0x0401D426 RID: 119846
		[Nullable(2)]
		private PhantomArenaMapNpcUi PhantomArenaMapNpcUi;
	}
}
