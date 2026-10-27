using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A18 RID: 10776
	public class IPlayerSlideRailEnd : ISlideRailEndType
	{
		// Token: 0x0600ED95 RID: 60821 RVA: 0x0022A0C2 File Offset: 0x002282C2
		[NullableContext(1)]
		public static IPlayerSlideRailEnd Create(IPlayerSlideRailEnd? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayerSlideRailEnd
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B27 RID: 19239
		// (get) Token: 0x0600ED96 RID: 60822 RVA: 0x0022A0E1 File Offset: 0x002282E1
		public override ESlideRailEndType Type
		{
			get
			{
				return (ESlideRailEndType)this.Instance.Type;
			}
		}

		// Token: 0x040082C6 RID: 33478
		private IPlayerSlideRailEnd Instance;
	}
}
