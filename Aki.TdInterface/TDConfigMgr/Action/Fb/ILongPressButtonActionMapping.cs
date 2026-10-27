using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002617 RID: 9751
	[NullableContext(1)]
	[Nullable(0)]
	public class ILongPressButtonActionMapping
	{
		// Token: 0x0600DAE1 RID: 56033 RVA: 0x002098E1 File Offset: 0x00207AE1
		public static ILongPressButtonActionMapping Create(ILongPressButtonActionMapping? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILongPressButtonActionMapping
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004075 RID: 16501
		// (get) Token: 0x0600DAE2 RID: 56034 RVA: 0x00209900 File Offset: 0x00207B00
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17004076 RID: 16502
		// (get) Token: 0x0600DAE3 RID: 56035 RVA: 0x0020990D File Offset: 0x00207B0D
		public virtual string ActionName
		{
			get
			{
				return this.Instance.ActionName;
			}
		}

		// Token: 0x0400798D RID: 31117
		private ILongPressButtonActionMapping Instance;
	}
}
