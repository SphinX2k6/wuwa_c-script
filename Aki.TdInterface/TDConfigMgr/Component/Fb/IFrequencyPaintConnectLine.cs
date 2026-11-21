using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F4A RID: 3914
	public class IFrequencyPaintConnectLine : IFrequencyPaintLineBase
	{
		// Token: 0x060057D3 RID: 22483 RVA: 0x000D6EFE File Offset: 0x000D50FE
		public static IFrequencyPaintConnectLine Create(IFrequencyPaintConnectLine? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFrequencyPaintConnectLine
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001D3A RID: 7482
		// (get) Token: 0x060057D4 RID: 22484 RVA: 0x000D6F1D File Offset: 0x000D511D
		public override EFrequencyPaintLineType Type
		{
			get
			{
				return (EFrequencyPaintLineType)this.Instance.Type;
			}
		}

		// Token: 0x17001D3B RID: 7483
		// (get) Token: 0x060057D5 RID: 22485 RVA: 0x000D6F2A File Offset: 0x000D512A
		public virtual int EntityTarget
		{
			get
			{
				return this.Instance.EntityTarget;
			}
		}

		// Token: 0x17001D3C RID: 7484
		// (get) Token: 0x060057D6 RID: 22486 RVA: 0x000D6F37 File Offset: 0x000D5137
		[Nullable(2)]
		public virtual string EntityState
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.EntityState;
			}
		}

		// Token: 0x0400326D RID: 12909
		private IFrequencyPaintConnectLine Instance;
	}
}
