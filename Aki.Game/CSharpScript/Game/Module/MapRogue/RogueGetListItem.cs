using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055ED RID: 21997
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueGetListItem : SliderItem
	{
		// Token: 0x0603804D RID: 229453 RVA: 0x00D44AC6 File Offset: 0x00D42CC6
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x0603804E RID: 229454 RVA: 0x00D44AFF File Offset: 0x00D42CFF
		protected override void OnStart()
		{
			this.LevelSequencePlayerInstance = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayerInstance.BindSequenceCloseEvent(new TSequenceEndEvent(this.FinishSequenceEvent), false);
		}

		// Token: 0x0603804F RID: 229455 RVA: 0x00D44B2A File Offset: 0x00D42D2A
		protected override void OnBeforeDestroy()
		{
			if (this.LevelSequencePlayerInstance != null)
			{
				this.LevelSequencePlayerInstance.Clear();
				this.LevelSequencePlayerInstance = null;
			}
		}

		// Token: 0x06038050 RID: 229456 RVA: 0x00D44B46 File Offset: 0x00D42D46
		private void FinishSequenceEvent(string sequenceName)
		{
			if (sequenceName == "Start")
			{
				base.FinishPlayStart();
				return;
			}
			if (sequenceName == "Close")
			{
				base.FinishPlayEnd();
			}
		}

		// Token: 0x06038051 RID: 229457 RVA: 0x00D44B70 File Offset: 0x00D42D70
		protected override void PlayStart()
		{
			this.LevelSequencePlayerInstance.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x06038052 RID: 229458 RVA: 0x00D44B98 File Offset: 0x00D42D98
		public override void PlayEnd()
		{
			this.LevelSequencePlayerInstance.PlayLevelSequenceByName("Close", false, null, false);
		}

		// Token: 0x06038053 RID: 229459 RVA: 0x00D44BC0 File Offset: 0x00D42DC0
		protected override void OnActiveStatusChange(bool value)
		{
		}

		// Token: 0x06038054 RID: 229460 RVA: 0x00D44BC4 File Offset: 0x00D42DC4
		public override UniTask AsyncLoadUiResource()
		{
			RogueGetListItem.<AsyncLoadUiResource>d__9 <AsyncLoadUiResource>d__;
			<AsyncLoadUiResource>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AsyncLoadUiResource>d__.<>4__this = this;
			<AsyncLoadUiResource>d__.<>1__state = -1;
			<AsyncLoadUiResource>d__.<>t__builder.Start<RogueGetListItem.<AsyncLoadUiResource>d__9>(ref <AsyncLoadUiResource>d__);
			return <AsyncLoadUiResource>d__.<>t__builder.Task;
		}

		// Token: 0x06038055 RID: 229461 RVA: 0x00D44C08 File Offset: 0x00D42E08
		public UniTask Refresh(IRogueGetListItemData data)
		{
			RogueGetListItem.<Refresh>d__10 <Refresh>d__;
			<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Refresh>d__.<>4__this = this;
			<Refresh>d__.data = data;
			<Refresh>d__.<>1__state = -1;
			<Refresh>d__.<>t__builder.Start<RogueGetListItem.<Refresh>d__10>(ref <Refresh>d__);
			return <Refresh>d__.<>t__builder.Task;
		}

		// Token: 0x0401D6F8 RID: 120568
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayerInstance;

		// Token: 0x0401D6F9 RID: 120569
		[Nullable(2)]
		protected IRogueGetListItemData Data;
	}
}
