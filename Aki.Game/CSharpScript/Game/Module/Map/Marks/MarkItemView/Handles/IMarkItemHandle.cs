using System;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x0200552F RID: 21807
	public interface IMarkItemHandle
	{
		// Token: 0x06037AC8 RID: 228040
		void Init();

		// Token: 0x06037AC9 RID: 228041
		void Update();

		// Token: 0x06037ACA RID: 228042
		void ApplyModified();

		// Token: 0x06037ACB RID: 228043
		void SetVisible(bool active);

		// Token: 0x06037ACC RID: 228044
		void Dispose();

		// Token: 0x06037ACD RID: 228045
		void UpdateNoCheck();

		// Token: 0x06037ACE RID: 228046
		void ApplyModifiedNoCheck();
	}
}
