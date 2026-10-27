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
	// Token: 0x0200551A RID: 21786
	[NullableContext(1)]
	[Nullable(0)]
	public class MingSuNpcMarkItemView : ConfigMarkItemView
	{
		// Token: 0x06037A45 RID: 227909 RVA: 0x00D3546B File Offset: 0x00D3366B
		public MingSuNpcMarkItemView(MingSuNpcMarkItem holder) : base(holder)
		{
		}

		// Token: 0x06037A46 RID: 227910 RVA: 0x00D35480 File Offset: 0x00D33680
		protected override UniTask OnBeforeStartAsync()
		{
			MingSuNpcMarkItemView.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MingSuNpcMarkItemView.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037A47 RID: 227911 RVA: 0x00D354C3 File Offset: 0x00D336C3
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

		// Token: 0x06037A48 RID: 227912 RVA: 0x00D354EC File Offset: 0x00D336EC
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

		// Token: 0x06037A49 RID: 227913 RVA: 0x00D35594 File Offset: 0x00D33794
		protected override void OnViewRecycle()
		{
			this.NpcIcon.SetUiActive(false);
		}

		// Token: 0x06037A4A RID: 227914 RVA: 0x00D355A4 File Offset: 0x00D337A4
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

		// Token: 0x06037A4B RID: 227915 RVA: 0x00D3561E File Offset: 0x00D3381E
		protected override IMarkItemHandle CreateTopRightHandle(IMarkItemComponentContext markComponentContext)
		{
			return new MingSuNpcTopRightIconHandle(markComponentContext);
		}

		// Token: 0x0401D424 RID: 119844
		private NpcIconPanel NpcIcon = new NpcIconPanel();
	}
}
