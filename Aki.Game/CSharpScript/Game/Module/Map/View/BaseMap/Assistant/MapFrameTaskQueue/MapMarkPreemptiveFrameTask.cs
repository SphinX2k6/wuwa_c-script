using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;

namespace CSharpScript.Game.Module.Map.View.BaseMap.Assistant.MapFrameTaskQueue
{
	// Token: 0x020054A8 RID: 21672
	[NullableContext(2)]
	[Nullable(0)]
	public class MapMarkPreemptiveFrameTask : IMapMarkPreemptiveFrameTask, IPreemptiveFrameTask
	{
		// Token: 0x170084B0 RID: 33968
		// (get) Token: 0x060375ED RID: 226797 RVA: 0x00D275BE File Offset: 0x00D257BE
		// (set) Token: 0x060375EE RID: 226798 RVA: 0x00D275C6 File Offset: 0x00D257C6
		public int Priority { get; set; }

		// Token: 0x170084B1 RID: 33969
		// (get) Token: 0x060375EF RID: 226799 RVA: 0x00D275CF File Offset: 0x00D257CF
		// (set) Token: 0x060375F0 RID: 226800 RVA: 0x00D275D7 File Offset: 0x00D257D7
		[Nullable(1)]
		public TPreemptiveExecuteMethod Execute { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x170084B2 RID: 33970
		// (get) Token: 0x060375F1 RID: 226801 RVA: 0x00D275E0 File Offset: 0x00D257E0
		// (set) Token: 0x060375F2 RID: 226802 RVA: 0x00D275E8 File Offset: 0x00D257E8
		public TPreemptiveExecuteMethod FrameExecute { get; set; }

		// Token: 0x170084B3 RID: 33971
		// (get) Token: 0x060375F3 RID: 226803 RVA: 0x00D275F1 File Offset: 0x00D257F1
		// (set) Token: 0x060375F4 RID: 226804 RVA: 0x00D275F9 File Offset: 0x00D257F9
		public TPreemptiveIsCompleteMethod IsComplete { get; set; }

		// Token: 0x170084B4 RID: 33972
		// (get) Token: 0x060375F5 RID: 226805 RVA: 0x00D27602 File Offset: 0x00D25802
		// (set) Token: 0x060375F6 RID: 226806 RVA: 0x00D2760A File Offset: 0x00D2580A
		public TPreemptiveCancelMethod Cancel { get; set; }

		// Token: 0x170084B5 RID: 33973
		// (get) Token: 0x060375F7 RID: 226807 RVA: 0x00D27613 File Offset: 0x00D25813
		// (set) Token: 0x060375F8 RID: 226808 RVA: 0x00D2761B File Offset: 0x00D2581B
		public TGetPreemptiveResultMethod GetResult { get; set; }

		// Token: 0x170084B6 RID: 33974
		// (get) Token: 0x060375F9 RID: 226809 RVA: 0x00D27624 File Offset: 0x00D25824
		// (set) Token: 0x060375FA RID: 226810 RVA: 0x00D2762C File Offset: 0x00D2582C
		public EMarkType MarkType { get; set; }

		// Token: 0x170084B7 RID: 33975
		// (get) Token: 0x060375FB RID: 226811 RVA: 0x00D27635 File Offset: 0x00D25835
		// (set) Token: 0x060375FC RID: 226812 RVA: 0x00D2763D File Offset: 0x00D2583D
		public int MarkId { get; set; }
	}
}
