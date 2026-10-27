using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C30 RID: 3120
	[NullableContext(1)]
	[Nullable(0)]
	public class ISequenceTrackControlPoint
	{
		// Token: 0x06004776 RID: 18294 RVA: 0x000B4006 File Offset: 0x000B2206
		public static ISequenceTrackControlPoint Create(ISequenceTrackControlPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISequenceTrackControlPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170014D3 RID: 5331
		// (get) Token: 0x06004777 RID: 18295 RVA: 0x000B4025 File Offset: 0x000B2225
		public virtual string Mark
		{
			get
			{
				return this.Instance.Mark;
			}
		}

		// Token: 0x04002899 RID: 10393
		private ISequenceTrackControlPoint Instance;
	}
}
