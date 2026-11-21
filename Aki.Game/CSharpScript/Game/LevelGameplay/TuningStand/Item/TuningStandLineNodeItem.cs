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
	// Token: 0x02005B2C RID: 23340
	public class TuningStandLineNodeItem : UiPanelBase
	{
		// Token: 0x060396A9 RID: 235177 RVA: 0x0101CF3C File Offset: 0x0101B13C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x060396AA RID: 235178 RVA: 0x0101CF96 File Offset: 0x0101B196
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(base.GetItem(0));
		}

		// Token: 0x060396AB RID: 235179 RVA: 0x0101CFAC File Offset: 0x0101B1AC
		public void OnStartAnim()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayLevelSequenceByName("In", false, null, false);
		}

		// Token: 0x060396AC RID: 235180 RVA: 0x0101CFDC File Offset: 0x0101B1DC
		public UniTask OnLinkComplete()
		{
			TuningStandLineNodeItem.<OnLinkComplete>d__4 <OnLinkComplete>d__;
			<OnLinkComplete>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnLinkComplete>d__.<>4__this = this;
			<OnLinkComplete>d__.<>1__state = -1;
			<OnLinkComplete>d__.<>t__builder.Start<TuningStandLineNodeItem.<OnLinkComplete>d__4>(ref <OnLinkComplete>d__);
			return <OnLinkComplete>d__.<>t__builder.Task;
		}

		// Token: 0x060396AD RID: 235181 RVA: 0x0101D020 File Offset: 0x0101B220
		public UniTask OnBeforeLinkComplete()
		{
			TuningStandLineNodeItem.<OnBeforeLinkComplete>d__5 <OnBeforeLinkComplete>d__;
			<OnBeforeLinkComplete>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeLinkComplete>d__.<>4__this = this;
			<OnBeforeLinkComplete>d__.<>1__state = -1;
			<OnBeforeLinkComplete>d__.<>t__builder.Start<TuningStandLineNodeItem.<OnBeforeLinkComplete>d__5>(ref <OnBeforeLinkComplete>d__);
			return <OnBeforeLinkComplete>d__.<>t__builder.Task;
		}

		// Token: 0x060396AE RID: 235182 RVA: 0x0101D063 File Offset: 0x0101B263
		protected override void OnBeforeDestroy()
		{
			this.SequencePlayer = null;
		}

		// Token: 0x060396AF RID: 235183 RVA: 0x0101D06C File Offset: 0x0101B26C
		[NullableContext(1)]
		public UUIItem GetActiveNode(ETuningStandGridType type)
		{
			ENodeDefine name = (type == ETuningStandGridType.Start1) ? ENodeDefine.Active1 : ENodeDefine.Active2;
			return base.GetItem((int)name);
		}

		// Token: 0x0401E49B RID: 124059
		[Nullable(2)]
		protected LevelSequencePlayer SequencePlayer;
	}
}
