using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.VisualNovel;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A68 RID: 23144
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolVisualNovelBackground : VisualNovelBackground
	{
		// Token: 0x0603902D RID: 233517 RVA: 0x00FF82CD File Offset: 0x00FF64CD
		public SolarSchoolVisualNovelBackground(UUIItem backgroundItem, SolarSchoolRootView rootView) : base(backgroundItem)
		{
			this.RootView = rootView;
		}

		// Token: 0x0603902E RID: 233518 RVA: 0x00FF82DD File Offset: 0x00FF64DD
		public override UniTask ApplyAsync(int backgroundId)
		{
			return this.RootView.SetVisualNovelBackgroundAsync(backgroundId);
		}

		// Token: 0x0603902F RID: 233519 RVA: 0x00FF82EB File Offset: 0x00FF64EB
		public override void FinishChange()
		{
			this.RootView.FinishVisualNovelBackground();
		}

		// Token: 0x06039030 RID: 233520 RVA: 0x00FF82F8 File Offset: 0x00FF64F8
		public override void Reset()
		{
			this.FinishChange();
			base.Reset();
			this.SetPlaybackRate(1f);
			this.SetPaused(false);
		}

		// Token: 0x06039031 RID: 233521 RVA: 0x00FF8318 File Offset: 0x00FF6518
		public override void Destroy()
		{
			this.FinishChange();
			base.Destroy();
		}

		// Token: 0x0401E012 RID: 122898
		private readonly SolarSchoolRootView RootView;
	}
}
