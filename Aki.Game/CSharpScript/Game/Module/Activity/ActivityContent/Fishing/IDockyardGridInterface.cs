using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005510 RID: 21776
	public interface IDockyardGridInterface
	{
		// Token: 0x06035FE6 RID: 221158
		void OnItemBlockClick(int id);

		// Token: 0x06035FE7 RID: 221159
		bool CanDrag(int id);

		// Token: 0x06035FE8 RID: 221160
		bool DragBegin(int id);

		// Token: 0x06035FE9 RID: 221161
		bool DragEnd(int id);
	}
}
