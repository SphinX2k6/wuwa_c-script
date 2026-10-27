using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BDB RID: 3035
	public class IPointField : IConveyorBeltField
	{
		// Token: 0x060045C6 RID: 17862 RVA: 0x000B08FF File Offset: 0x000AEAFF
		[NullableContext(1)]
		public static IPointField Create(IPointField? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPointField
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013CD RID: 5069
		// (get) Token: 0x060045C7 RID: 17863 RVA: 0x000B091E File Offset: 0x000AEB1E
		public override EConveyorBeltFieldType Type
		{
			get
			{
				return (EConveyorBeltFieldType)this.Instance.Type;
			}
		}

		// Token: 0x040027BC RID: 10172
		private IPointField Instance;
	}
}
