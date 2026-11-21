using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CAA RID: 3242
	public class IPointField : IConveyorBeltField
	{
		// Token: 0x06004A24 RID: 18980 RVA: 0x000BAA7B File Offset: 0x000B8C7B
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

		// Token: 0x170014CB RID: 5323
		// (get) Token: 0x06004A25 RID: 18981 RVA: 0x000BAA9A File Offset: 0x000B8C9A
		public override EConveyorBeltFieldType Type
		{
			get
			{
				return (EConveyorBeltFieldType)this.Instance.Type;
			}
		}

		// Token: 0x04002A07 RID: 10759
		private IPointField Instance;
	}
}
