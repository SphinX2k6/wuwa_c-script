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
	// Token: 0x020069D0 RID: 27088
	public class TuningStandLineNodeItem : UiPanelBase
	{
		// Token: 0x0604366D RID: 276077 RVA: 0x01078A88 File Offset: 0x01076C88
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x0604366E RID: 276078 RVA: 0x01078AE2 File Offset: 0x01076CE2
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(base.GetItem(0));
		}

		// Token: 0x0604366F RID: 276079 RVA: 0x01078AF8 File Offset: 0x01076CF8
		public void OnStartAnim()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayLevelSequenceByName("In", false, null, false);
		}

		// Token: 0x06043670 RID: 276080 RVA: 0x01078B28 File Offset: 0x01076D28
		public UniTask OnLinkComplete()
		{
			TuningStandLineNodeItem.<OnLinkComplete>d__4 <OnLinkComplete>d__;
			<OnLinkComplete>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnLinkComplete>d__.<>4__this = this;
			<OnLinkComplete>d__.<>1__state = -1;
			<OnLinkComplete>d__.<>t__builder.Start<TuningStandLineNodeItem.<OnLinkComplete>d__4>(ref <OnLinkComplete>d__);
			return <OnLinkComplete>d__.<>t__builder.Task;
		}

		// Token: 0x06043671 RID: 276081 RVA: 0x01078B6C File Offset: 0x01076D6C
		public UniTask OnBeforeLinkComplete()
		{
			TuningStandLineNodeItem.<OnBeforeLinkComplete>d__5 <OnBeforeLinkComplete>d__;
			<OnBeforeLinkComplete>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeLinkComplete>d__.<>4__this = this;
			<OnBeforeLinkComplete>d__.<>1__state = -1;
			<OnBeforeLinkComplete>d__.<>t__builder.Start<TuningStandLineNodeItem.<OnBeforeLinkComplete>d__5>(ref <OnBeforeLinkComplete>d__);
			return <OnBeforeLinkComplete>d__.<>t__builder.Task;
		}

		// Token: 0x06043672 RID: 276082 RVA: 0x01078BAF File Offset: 0x01076DAF
		protected override void OnBeforeDestroy()
		{
			this.SequencePlayer = null;
		}

		// Token: 0x06043673 RID: 276083 RVA: 0x01078BB8 File Offset: 0x01076DB8
		[NullableContext(1)]
		public UUIItem GetActiveNode(ETuningStandGridType type)
		{
			ENodeDefine name = (type == ETuningStandGridType.Start1) ? ENodeDefine.Active1 : ENodeDefine.Active2;
			return base.GetItem((int)name);
		}

		// Token: 0x040232AB RID: 144043
		[Nullable(2)]
		protected LevelSequencePlayer SequencePlayer;
	}
}
