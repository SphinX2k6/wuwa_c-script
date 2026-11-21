using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A4C RID: 23116
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class SolarSchoolBagGiftParam
	{
		// Token: 0x17006C8B RID: 27787
		// (get) Token: 0x06038F80 RID: 233344 RVA: 0x00FF6079 File Offset: 0x00FF4279
		public int RoleId { get; }

		// Token: 0x17006C8C RID: 27788
		// (get) Token: 0x06038F81 RID: 233345 RVA: 0x00FF6081 File Offset: 0x00FF4281
		public Func<int, int> OnGiftSelected { get; }

		// Token: 0x17006C8D RID: 27789
		// (get) Token: 0x06038F82 RID: 233346 RVA: 0x00FF6089 File Offset: 0x00FF4289
		public Action OnCancel { get; }

		// Token: 0x06038F83 RID: 233347 RVA: 0x00FF6091 File Offset: 0x00FF4291
		public SolarSchoolBagGiftParam(int roleId, Func<int, int> onGiftSelected, Action onCancel)
		{
			this.RoleId = roleId;
			this.OnGiftSelected = onGiftSelected;
			this.OnCancel = onCancel;
		}
	}
}
