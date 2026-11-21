using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020045C3 RID: 17859
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueGetListItem : SliderItem
	{
		// Token: 0x0602CF4B RID: 184139 RVA: 0x00C9280E File Offset: 0x00C90A0E
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x0602CF4C RID: 184140 RVA: 0x00C92847 File Offset: 0x00C90A47
		protected override void OnStart()
		{
			this.LevelSequencePlayerInstance = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayerInstance.BindSequenceCloseEvent(new TSequenceEndEvent(this.FinishSequenceEvent), false);
		}

		// Token: 0x0602CF4D RID: 184141 RVA: 0x00C92872 File Offset: 0x00C90A72
		protected override void OnBeforeDestroy()
		{
			if (this.LevelSequencePlayerInstance != null)
			{
				this.LevelSequencePlayerInstance.Clear();
				this.LevelSequencePlayerInstance = null;
			}
		}

		// Token: 0x0602CF4E RID: 184142 RVA: 0x00C9288E File Offset: 0x00C90A8E
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

		// Token: 0x0602CF4F RID: 184143 RVA: 0x00C928B8 File Offset: 0x00C90AB8
		protected override void PlayStart()
		{
			this.LevelSequencePlayerInstance.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x0602CF50 RID: 184144 RVA: 0x00C928E0 File Offset: 0x00C90AE0
		public override void PlayEnd()
		{
			this.LevelSequencePlayerInstance.PlayLevelSequenceByName("Close", false, null, false);
		}

		// Token: 0x0602CF51 RID: 184145 RVA: 0x00C92908 File Offset: 0x00C90B08
		protected override void OnActiveStatusChange(bool value)
		{
		}

		// Token: 0x0602CF52 RID: 184146 RVA: 0x00C9290C File Offset: 0x00C90B0C
		public override UniTask AsyncLoadUiResource()
		{
			RogueGetListItem.<AsyncLoadUiResource>d__9 <AsyncLoadUiResource>d__;
			<AsyncLoadUiResource>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AsyncLoadUiResource>d__.<>4__this = this;
			<AsyncLoadUiResource>d__.<>1__state = -1;
			<AsyncLoadUiResource>d__.<>t__builder.Start<RogueGetListItem.<AsyncLoadUiResource>d__9>(ref <AsyncLoadUiResource>d__);
			return <AsyncLoadUiResource>d__.<>t__builder.Task;
		}

		// Token: 0x0602CF53 RID: 184147 RVA: 0x00C92950 File Offset: 0x00C90B50
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

		// Token: 0x04018183 RID: 98691
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayerInstance;

		// Token: 0x04018184 RID: 98692
		[Nullable(2)]
		protected IRogueGetListItemData Data;
	}
}
