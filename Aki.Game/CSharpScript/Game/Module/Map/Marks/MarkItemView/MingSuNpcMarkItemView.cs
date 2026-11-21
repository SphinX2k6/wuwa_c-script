using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x020044ED RID: 17645
	[NullableContext(1)]
	[Nullable(0)]
	public class MingSuNpcMarkItemView : ConfigMarkItemView
	{
		// Token: 0x0602C913 RID: 182547 RVA: 0x00C8323C File Offset: 0x00C8143C
		public MingSuNpcMarkItemView(MingSuNpcMarkItem holder) : base(holder)
		{
		}

		// Token: 0x0602C914 RID: 182548 RVA: 0x00C83250 File Offset: 0x00C81450
		protected override UniTask OnBeforeStartAsync()
		{
			MingSuNpcMarkItemView.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MingSuNpcMarkItemView.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602C915 RID: 182549 RVA: 0x00C83293 File Offset: 0x00C81493
		protected override void OnStart()
		{
			base.OnStart();
			UUIItem iconItem = this.GetIconItem();
			if (iconItem != null)
			{
				iconItem.SetUIActive(false);
			}
			this.NpcIcon.SetUiActive(false);
		}

		// Token: 0x0602C916 RID: 182550 RVA: 0x00C832BC File Offset: 0x00C814BC
		protected override void OnViewRefresh()
		{
			base.OnViewRefresh();
			MingSuNpcMarkItem mingSuNpcMarkItem = this.Holder as MingSuNpcMarkItem;
			bool isWithSeqNpc = mingSuNpcMarkItem.MarkConfig.Value.RelativeSubType == 12 || mingSuNpcMarkItem.MarkConfig.Value.RelativeSubType == 11;
			if (isWithSeqNpc)
			{
				this.NpcIcon.SetIcon(mingSuNpcMarkItem.IconPath, delegate
				{
					if (this.IsShow)
					{
						this.NpcIcon.SetUiActive(isWithSeqNpc);
						if (isWithSeqNpc)
						{
							this.ProcessSequence();
						}
					}
				});
				this.IsShowIcon = false;
			}
			UUIItem iconItem = this.GetIconItem();
			if (iconItem == null)
			{
				return;
			}
			iconItem.SetUIActive(!isWithSeqNpc);
		}

		// Token: 0x0602C917 RID: 182551 RVA: 0x00C8336A File Offset: 0x00C8156A
		protected override void OnViewRecycle()
		{
			this.NpcIcon.SetUiActive(false);
		}

		// Token: 0x0602C918 RID: 182552 RVA: 0x00C83378 File Offset: 0x00C81578
		private void ProcessSequence()
		{
			if (this.Holder.MarkId == 0 || this.Holder.MapType != EMapType.WorldMap)
			{
				return;
			}
			HashSet<int> hashSet = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.MapNPCMarkShowSeq, null) ?? new HashSet<int>();
			if (!hashSet.Contains(this.Holder.MarkId))
			{
				this.NpcIcon.PlaySequence();
				hashSet.Add(this.Holder.MarkId);
			}
			LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.MapNPCMarkShowSeq, hashSet);
		}

		// Token: 0x0602C919 RID: 182553 RVA: 0x00C833F2 File Offset: 0x00C815F2
		protected override IMarkItemHandle CreateTopRightHandle(IMarkItemComponentContext markComponentContext)
		{
			return new MingSuNpcTopRightIconHandle(markComponentContext);
		}

		// Token: 0x04017EA7 RID: 97959
		private NpcIconPanel NpcIcon = new NpcIconPanel();
	}
}
