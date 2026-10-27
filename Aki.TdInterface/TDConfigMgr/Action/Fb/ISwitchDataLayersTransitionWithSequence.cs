using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002894 RID: 10388
	[NullableContext(1)]
	[Nullable(0)]
	public class ISwitchDataLayersTransitionWithSequence : ISwitchDataLayersTransitionType
	{
		// Token: 0x0600E60C RID: 58892 RVA: 0x0021CF84 File Offset: 0x0021B184
		public static ISwitchDataLayersTransitionWithSequence Create(ISwitchDataLayersTransitionWithSequence? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISwitchDataLayersTransitionWithSequence
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046A6 RID: 18086
		// (get) Token: 0x0600E60D RID: 58893 RVA: 0x0021CFA3 File Offset: 0x0021B1A3
		public override ESwitchDataLayersTransitionType Type
		{
			get
			{
				return (ESwitchDataLayersTransitionType)this.Instance.Type;
			}
		}

		// Token: 0x170046A7 RID: 18087
		// (get) Token: 0x0600E60E RID: 58894 RVA: 0x0021CFB0 File Offset: 0x0021B1B0
		public virtual string SequencePath
		{
			get
			{
				return this.Instance.SequencePath;
			}
		}

		// Token: 0x170046A8 RID: 18088
		// (get) Token: 0x0600E60F RID: 58895 RVA: 0x0021CFBD File Offset: 0x0021B1BD
		[Nullable(2)]
		public virtual string SeqMarkBeforeModifyMat
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.SeqMarkBeforeModifyMat;
			}
		}

		// Token: 0x04007F2E RID: 32558
		private ISwitchDataLayersTransitionWithSequence Instance;
	}
}
