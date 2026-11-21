using System;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x02004502 RID: 17666
	public interface IMarkItemHandle
	{
		// Token: 0x17005954 RID: 22868
		// (get) Token: 0x0602C994 RID: 182676
		bool IsVisible { get; }

		// Token: 0x17005955 RID: 22869
		// (get) Token: 0x0602C995 RID: 182677
		bool IsVisibleDirty { get; }

		// Token: 0x0602C996 RID: 182678
		void Init();

		// Token: 0x0602C997 RID: 182679
		void Update();

		// Token: 0x0602C998 RID: 182680
		void ApplyModified();

		// Token: 0x0602C999 RID: 182681
		void SetVisible(bool active);

		// Token: 0x0602C99A RID: 182682
		void ResetVisibleState();

		// Token: 0x0602C99B RID: 182683
		void Dispose();

		// Token: 0x0602C99C RID: 182684
		void UpdateNoCheck();

		// Token: 0x0602C99D RID: 182685
		void ApplyModifiedNoCheck();
	}
}
