using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BDD RID: 3037
	public class IFixSpeed : IConveyorBeltMove
	{
		// Token: 0x060045CC RID: 17868 RVA: 0x000B0967 File Offset: 0x000AEB67
		[NullableContext(1)]
		public static IFixSpeed Create(IFixSpeed? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFixSpeed
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013CF RID: 5071
		// (get) Token: 0x060045CD RID: 17869 RVA: 0x000B0986 File Offset: 0x000AEB86
		public override EConveyorBeltMoveType Type
		{
			get
			{
				return (EConveyorBeltMoveType)this.Instance.Type;
			}
		}

		// Token: 0x170013D0 RID: 5072
		// (get) Token: 0x060045CE RID: 17870 RVA: 0x000B0993 File Offset: 0x000AEB93
		public virtual int Speed
		{
			get
			{
				return this.Instance.Speed;
			}
		}

		// Token: 0x040027BE RID: 10174
		private IFixSpeed Instance;
	}
}
