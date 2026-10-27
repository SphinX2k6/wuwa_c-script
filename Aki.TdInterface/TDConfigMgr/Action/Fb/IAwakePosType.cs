using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002640 RID: 9792
	public class IAwakePosType
	{
		// Token: 0x0600DBB5 RID: 56245 RVA: 0x0020B2FF File Offset: 0x002094FF
		[NullableContext(1)]
		public static IAwakePosType Create(IAwakePosType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAwakePosType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170040F7 RID: 16631
		// (get) Token: 0x0600DBB6 RID: 56246 RVA: 0x0020B31E File Offset: 0x0020951E
		public virtual EAwakePosType Type
		{
			get
			{
				return (EAwakePosType)this.Instance.Type;
			}
		}

		// Token: 0x04007A14 RID: 31252
		private IAwakePosType Instance;
	}
}
