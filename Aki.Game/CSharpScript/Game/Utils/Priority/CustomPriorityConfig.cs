using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.Priority
{
	// Token: 0x0200455F RID: 17759
	public class CustomPriorityConfig<T> : ICustomPriorityConfig<T> where T : struct, Enum
	{
		// Token: 0x17007563 RID: 30051
		// (get) Token: 0x0602DDDF RID: 187871 RVA: 0x00A8C1F9 File Offset: 0x00A8A3F9
		// (set) Token: 0x0602DDE0 RID: 187872 RVA: 0x00A8C201 File Offset: 0x00A8A401
		public bool Enable { get; set; }

		// Token: 0x17007564 RID: 30052
		// (get) Token: 0x0602DDE1 RID: 187873 RVA: 0x00A8C20A File Offset: 0x00A8A40A
		// (set) Token: 0x0602DDE2 RID: 187874 RVA: 0x00A8C212 File Offset: 0x00A8A412
		public T? Enum { get; set; }

		// Token: 0x17007565 RID: 30053
		// (get) Token: 0x0602DDE3 RID: 187875 RVA: 0x00A8C21B File Offset: 0x00A8A41B
		// (set) Token: 0x0602DDE4 RID: 187876 RVA: 0x00A8C223 File Offset: 0x00A8A423
		public int? Priority { get; set; }

		// Token: 0x17007566 RID: 30054
		// (get) Token: 0x0602DDE5 RID: 187877 RVA: 0x00A8C22C File Offset: 0x00A8A42C
		// (set) Token: 0x0602DDE6 RID: 187878 RVA: 0x00A8C234 File Offset: 0x00A8A434
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<ICustomPriorityCallbackParam, bool> EnterCallback { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17007567 RID: 30055
		// (get) Token: 0x0602DDE7 RID: 187879 RVA: 0x00A8C23D File Offset: 0x00A8A43D
		// (set) Token: 0x0602DDE8 RID: 187880 RVA: 0x00A8C245 File Offset: 0x00A8A445
		public bool? EnterReentrant { get; set; }

		// Token: 0x17007568 RID: 30056
		// (get) Token: 0x0602DDE9 RID: 187881 RVA: 0x00A8C24E File Offset: 0x00A8A44E
		// (set) Token: 0x0602DDEA RID: 187882 RVA: 0x00A8C256 File Offset: 0x00A8A456
		public bool? ForceEnterCallback { get; set; }

		// Token: 0x17007569 RID: 30057
		// (get) Token: 0x0602DDEB RID: 187883 RVA: 0x00A8C25F File Offset: 0x00A8A45F
		// (set) Token: 0x0602DDEC RID: 187884 RVA: 0x00A8C267 File Offset: 0x00A8A467
		public bool? CheckEnterValid { get; set; }

		// Token: 0x1700756A RID: 30058
		// (get) Token: 0x0602DDED RID: 187885 RVA: 0x00A8C270 File Offset: 0x00A8A470
		// (set) Token: 0x0602DDEE RID: 187886 RVA: 0x00A8C278 File Offset: 0x00A8A478
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<ICustomPriorityCallbackParam, bool> ExitCallback { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x1700756B RID: 30059
		// (get) Token: 0x0602DDEF RID: 187887 RVA: 0x00A8C281 File Offset: 0x00A8A481
		// (set) Token: 0x0602DDF0 RID: 187888 RVA: 0x00A8C289 File Offset: 0x00A8A489
		public bool? ForceExitCallback { get; set; }

		// Token: 0x1700756C RID: 30060
		// (get) Token: 0x0602DDF1 RID: 187889 RVA: 0x00A8C292 File Offset: 0x00A8A492
		// (set) Token: 0x0602DDF2 RID: 187890 RVA: 0x00A8C29A File Offset: 0x00A8A49A
		public bool? CheckExitValid { get; set; }
	}
}
