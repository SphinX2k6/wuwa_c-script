using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A59 RID: 2649
	public class MoveComponent : IComponentBase
	{
		// Token: 0x06003D03 RID: 15619 RVA: 0x0009CE85 File Offset: 0x0009B085
		[NullableContext(1)]
		public static MoveComponent Create(IMoveComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new MoveComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x06003D04 RID: 15620 RVA: 0x0009CEA4 File Offset: 0x0009B0A4
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x06003D05 RID: 15621 RVA: 0x0009CEDC File Offset: 0x0009B0DC
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x06003D06 RID: 15622 RVA: 0x0009CEF2 File Offset: 0x0009B0F2
		public virtual float InitSpeed
		{
			get
			{
				return this.Instance.InitSpeed;
			}
		}

		// Token: 0x04002200 RID: 8704
		private IMoveComponent Instance;
	}
}
