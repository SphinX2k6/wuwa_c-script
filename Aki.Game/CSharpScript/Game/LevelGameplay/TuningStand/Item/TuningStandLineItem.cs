using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.TuningStand.Item
{
	// Token: 0x020069CE RID: 27086
	[NullableContext(1)]
	[Nullable(0)]
	public class TuningStandLineItem : UiPanelBase
	{
		// Token: 0x06043664 RID: 276068 RVA: 0x01078953 File Offset: 0x01076B53
		public TuningStandLineItem(string musicPath)
		{
			this.MusicPath = musicPath;
		}

		// Token: 0x17009879 RID: 39033
		// (get) Token: 0x06043665 RID: 276069 RVA: 0x01078962 File Offset: 0x01076B62
		protected string MusicPath { get; }

		// Token: 0x06043666 RID: 276070 RVA: 0x0107896A File Offset: 0x01076B6A
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem))
			};
		}

		// Token: 0x06043667 RID: 276071 RVA: 0x01078990 File Offset: 0x01076B90
		protected override UniTask OnBeforeStartAsync()
		{
			TuningStandLineItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TuningStandLineItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06043668 RID: 276072 RVA: 0x010789D3 File Offset: 0x01076BD3
		protected override void OnBeforeDestroy()
		{
			this.MusicItem = null;
		}

		// Token: 0x06043669 RID: 276073 RVA: 0x010789DC File Offset: 0x01076BDC
		public void OnStartAnim()
		{
			TuningStandLineNodeItem musicItem = this.MusicItem;
			if (musicItem == null)
			{
				return;
			}
			musicItem.OnStartAnim();
		}

		// Token: 0x0604366A RID: 276074 RVA: 0x010789F0 File Offset: 0x01076BF0
		public UniTask OnLinkComplete()
		{
			TuningStandLineItem.<OnLinkComplete>d__10 <OnLinkComplete>d__;
			<OnLinkComplete>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnLinkComplete>d__.<>4__this = this;
			<OnLinkComplete>d__.<>1__state = -1;
			<OnLinkComplete>d__.<>t__builder.Start<TuningStandLineItem.<OnLinkComplete>d__10>(ref <OnLinkComplete>d__);
			return <OnLinkComplete>d__.<>t__builder.Task;
		}

		// Token: 0x0604366B RID: 276075 RVA: 0x01078A34 File Offset: 0x01076C34
		public UniTask OnBeforeLinkComplete()
		{
			TuningStandLineItem.<OnBeforeLinkComplete>d__11 <OnBeforeLinkComplete>d__;
			<OnBeforeLinkComplete>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeLinkComplete>d__.<>4__this = this;
			<OnBeforeLinkComplete>d__.<>1__state = -1;
			<OnBeforeLinkComplete>d__.<>t__builder.Start<TuningStandLineItem.<OnBeforeLinkComplete>d__11>(ref <OnBeforeLinkComplete>d__);
			return <OnBeforeLinkComplete>d__.<>t__builder.Task;
		}

		// Token: 0x0604366C RID: 276076 RVA: 0x01078A77 File Offset: 0x01076C77
		public UUIItem GetActiveNode(ETuningStandGridType type)
		{
			return this.MusicItem.GetActiveNode(type);
		}

		// Token: 0x040232A5 RID: 144037
		[Nullable(2)]
		protected TuningStandLineNodeItem MusicItem;

		// Token: 0x0200CB44 RID: 52036
		[NullableContext(0)]
		public enum ELineDefine
		{
			// Token: 0x0403D61B RID: 251419
			Panel
		}
	}
}
