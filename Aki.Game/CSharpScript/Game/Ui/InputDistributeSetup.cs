using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004685 RID: 18053
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class InputDistributeSetup
	{
		// Token: 0x0602E98F RID: 190863
		public abstract bool OnRefresh();

		// Token: 0x0602E990 RID: 190864 RVA: 0x00AC9E27 File Offset: 0x00AC8027
		protected void SetInputDistributeTag(string tagName)
		{
			InputDistributeModel.Instance.SetInputDistributeTag(tagName);
		}

		// Token: 0x0602E991 RID: 190865 RVA: 0x00AC9E34 File Offset: 0x00AC8034
		protected void SetInputDistributeTags(IList<string> tagNames)
		{
			InputDistributeModel.Instance.SetInputDistributeTags(tagNames);
		}

		// Token: 0x0602E992 RID: 190866 RVA: 0x00AC9E41 File Offset: 0x00AC8041
		protected void AddInputDistributeTag(string tagName)
		{
			InputDistributeModel.Instance.AddInputDistributeTag(tagName);
		}

		// Token: 0x0602E993 RID: 190867 RVA: 0x00AC9E4E File Offset: 0x00AC804E
		protected void RemoveInputDistributeTag(string tagName, bool bRemoveChild = false)
		{
			InputDistributeModel.Instance.RemoveInputDistributeTag(tagName, bRemoveChild);
		}
	}
}
