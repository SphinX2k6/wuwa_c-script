using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F4B RID: 3915
	public class IFrequencyPaintEncloseLine : IFrequencyPaintLineBase
	{
		// Token: 0x060057D8 RID: 22488 RVA: 0x000D6F4C File Offset: 0x000D514C
		public static IFrequencyPaintEncloseLine Create(IFrequencyPaintEncloseLine? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFrequencyPaintEncloseLine
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001D3D RID: 7485
		// (get) Token: 0x060057D9 RID: 22489 RVA: 0x000D6F6B File Offset: 0x000D516B
		public override EFrequencyPaintLineType Type
		{
			get
			{
				return (EFrequencyPaintLineType)this.Instance.Type;
			}
		}

		// Token: 0x0400326E RID: 12910
		private IFrequencyPaintEncloseLine Instance;
	}
}
