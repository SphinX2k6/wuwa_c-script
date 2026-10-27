using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200280F RID: 10255
	public class IMechStuntWater : IMechStuntConfigType
	{
		// Token: 0x0600E384 RID: 58244 RVA: 0x00218756 File Offset: 0x00216956
		[NullableContext(1)]
		public static IMechStuntWater Create(IMechStuntWater? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechStuntWater
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004528 RID: 17704
		// (get) Token: 0x0600E385 RID: 58245 RVA: 0x00218775 File Offset: 0x00216975
		public override EMechStuntType Type
		{
			get
			{
				return (EMechStuntType)this.Instance.Type;
			}
		}

		// Token: 0x04007DF5 RID: 32245
		private IMechStuntWater Instance;
	}
}
