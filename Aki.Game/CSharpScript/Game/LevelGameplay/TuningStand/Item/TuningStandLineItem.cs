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
	// Token: 0x02005B2A RID: 23338
	[NullableContext(1)]
	[Nullable(0)]
	public class TuningStandLineItem : UiPanelBase
	{
		// Token: 0x060396A0 RID: 235168 RVA: 0x0101CE07 File Offset: 0x0101B007
		public TuningStandLineItem(string musicPath)
		{
			this.MusicPath = musicPath;
		}

		// Token: 0x17006D59 RID: 27993
		// (get) Token: 0x060396A1 RID: 235169 RVA: 0x0101CE16 File Offset: 0x0101B016
		protected string MusicPath { get; }

		// Token: 0x060396A2 RID: 235170 RVA: 0x0101CE1E File Offset: 0x0101B01E
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem))
			};
		}

		// Token: 0x060396A3 RID: 235171 RVA: 0x0101CE44 File Offset: 0x0101B044
		protected override UniTask OnBeforeStartAsync()
		{
			TuningStandLineItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TuningStandLineItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060396A4 RID: 235172 RVA: 0x0101CE87 File Offset: 0x0101B087
		protected override void OnBeforeDestroy()
		{
			this.MusicItem = null;
		}

		// Token: 0x060396A5 RID: 235173 RVA: 0x0101CE90 File Offset: 0x0101B090
		public void OnStartAnim()
		{
			TuningStandLineNodeItem musicItem = this.MusicItem;
			if (musicItem == null)
			{
				return;
			}
			musicItem.OnStartAnim();
		}

		// Token: 0x060396A6 RID: 235174 RVA: 0x0101CEA4 File Offset: 0x0101B0A4
		public UniTask OnLinkComplete()
		{
			TuningStandLineItem.<OnLinkComplete>d__10 <OnLinkComplete>d__;
			<OnLinkComplete>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnLinkComplete>d__.<>4__this = this;
			<OnLinkComplete>d__.<>1__state = -1;
			<OnLinkComplete>d__.<>t__builder.Start<TuningStandLineItem.<OnLinkComplete>d__10>(ref <OnLinkComplete>d__);
			return <OnLinkComplete>d__.<>t__builder.Task;
		}

		// Token: 0x060396A7 RID: 235175 RVA: 0x0101CEE8 File Offset: 0x0101B0E8
		public UniTask OnBeforeLinkComplete()
		{
			TuningStandLineItem.<OnBeforeLinkComplete>d__11 <OnBeforeLinkComplete>d__;
			<OnBeforeLinkComplete>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeLinkComplete>d__.<>4__this = this;
			<OnBeforeLinkComplete>d__.<>1__state = -1;
			<OnBeforeLinkComplete>d__.<>t__builder.Start<TuningStandLineItem.<OnBeforeLinkComplete>d__11>(ref <OnBeforeLinkComplete>d__);
			return <OnBeforeLinkComplete>d__.<>t__builder.Task;
		}

		// Token: 0x060396A8 RID: 235176 RVA: 0x0101CF2B File Offset: 0x0101B12B
		public UUIItem GetActiveNode(ETuningStandGridType type)
		{
			return this.MusicItem.GetActiveNode(type);
		}

		// Token: 0x0401E495 RID: 124053
		[Nullable(2)]
		protected TuningStandLineNodeItem MusicItem;

		// Token: 0x0200B723 RID: 46883
		[NullableContext(0)]
		public enum ELineDefine
		{
			// Token: 0x040389FD RID: 231933
			Panel
		}
	}
}
