using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02006592 RID: 26002
	public interface IDockyardGridInterface
	{
		// Token: 0x06041321 RID: 267041
		void OnItemBlockClick(int id);

		// Token: 0x06041322 RID: 267042
		bool CanDrag(int id);

		// Token: 0x06041323 RID: 267043
		bool DragBegin(int id);

		// Token: 0x06041324 RID: 267044
		bool DragEnd(int id);
	}
}
