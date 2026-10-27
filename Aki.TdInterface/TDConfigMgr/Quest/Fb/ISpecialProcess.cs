using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013CE RID: 5070
	public class ISpecialProcess
	{
		// Token: 0x060073C0 RID: 29632 RVA: 0x0011598E File Offset: 0x00113B8E
		[NullableContext(1)]
		public static ISpecialProcess Create(ISpecialProcess? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpecialProcess
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170025F7 RID: 9719
		// (get) Token: 0x060073C1 RID: 29633 RVA: 0x001159AD File Offset: 0x00113BAD
		public virtual ESpecialProcess Type
		{
			get
			{
				return (ESpecialProcess)this.Instance.Type;
			}
		}

		// Token: 0x04004302 RID: 17154
		private ISpecialProcess Instance;
	}
}
