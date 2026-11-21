using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059E2 RID: 23010
	[NullableContext(1)]
	[Nullable(0)]
	internal sealed class SolarSchoolQuestLinePlayer
	{
		// Token: 0x06038ACC RID: 232140 RVA: 0x00FDC9A0 File Offset: 0x00FDABA0
		public SolarSchoolQuestLinePlayer(UUIItem root, UUIItem panel, UUIItem top, UUIItem middle, UUIItem bottom)
		{
			this.Sequence = new LevelSequencePlayer(root);
			this.Panel = panel;
			this.Top = top;
			this.Middle = middle;
			this.Bottom = bottom;
			this.Panel.SetAlpha(0f);
			this.Panel.SetUIActive(true);
			this.Top.SetUIActive(true);
			this.Middle.SetUIActive(true);
			this.Bottom.SetUIActive(true);
		}

		// Token: 0x06038ACD RID: 232141 RVA: 0x00FDCA1D File Offset: 0x00FDAC1D
		public void Hide()
		{
			this.Panel.SetAlpha(0f);
		}

		// Token: 0x06038ACE RID: 232142 RVA: 0x00FDCA30 File Offset: 0x00FDAC30
		private void ApplyMask(ESolarSchoolQuestLineMask mask)
		{
			this.Top.SetAlpha(((mask & ESolarSchoolQuestLineMask.Top) != ESolarSchoolQuestLineMask.None) ? 1f : 0f);
			this.Middle.SetAlpha(((mask & ESolarSchoolQuestLineMask.Middle) != ESolarSchoolQuestLineMask.None) ? 1f : 0f);
			this.Bottom.SetAlpha(((mask & ESolarSchoolQuestLineMask.Bottom) != ESolarSchoolQuestLineMask.None) ? 1f : 0f);
			this.Panel.SetAlpha((mask != ESolarSchoolQuestLineMask.None) ? 1f : 0f);
		}

		// Token: 0x06038ACF RID: 232143 RVA: 0x00FDCAAC File Offset: 0x00FDACAC
		public UniTask PlayAsync(ESolarSchoolQuestLineMask mask)
		{
			SolarSchoolQuestLinePlayer.<PlayAsync>d__8 <PlayAsync>d__;
			<PlayAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayAsync>d__.<>4__this = this;
			<PlayAsync>d__.mask = mask;
			<PlayAsync>d__.<>1__state = -1;
			<PlayAsync>d__.<>t__builder.Start<SolarSchoolQuestLinePlayer.<PlayAsync>d__8>(ref <PlayAsync>d__);
			return <PlayAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038AD0 RID: 232144 RVA: 0x00FDCAF7 File Offset: 0x00FDACF7
		public void Stop()
		{
			this.Sequence.StopPlayingSequence(false, false);
		}

		// Token: 0x06038AD1 RID: 232145 RVA: 0x00FDCB06 File Offset: 0x00FDAD06
		public void Clear()
		{
			this.Stop();
			this.Sequence.Clear();
		}

		// Token: 0x0401DD8D RID: 122253
		private readonly LevelSequencePlayer Sequence;

		// Token: 0x0401DD8E RID: 122254
		private readonly UUIItem Panel;

		// Token: 0x0401DD8F RID: 122255
		private readonly UUIItem Top;

		// Token: 0x0401DD90 RID: 122256
		private readonly UUIItem Middle;

		// Token: 0x0401DD91 RID: 122257
		private readonly UUIItem Bottom;
	}
}
