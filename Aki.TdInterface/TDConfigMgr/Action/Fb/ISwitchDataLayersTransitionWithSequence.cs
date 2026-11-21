using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B69 RID: 11113
	public class ISwitchDataLayersTransitionWithSequence : ISwitchDataLayersTransitionType
	{
		// Token: 0x0600F43B RID: 62523 RVA: 0x00239F04 File Offset: 0x00238104
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

		// Token: 0x17004A17 RID: 18967
		// (get) Token: 0x0600F43C RID: 62524 RVA: 0x00239F23 File Offset: 0x00238123
		public override ESwitchDataLayersTransitionType Type
		{
			get
			{
				return (ESwitchDataLayersTransitionType)this.Instance.Type;
			}
		}

		// Token: 0x17004A18 RID: 18968
		// (get) Token: 0x0600F43D RID: 62525 RVA: 0x00239F30 File Offset: 0x00238130
		public virtual string SequencePath
		{
			get
			{
				return this.Instance.SequencePath;
			}
		}

		// Token: 0x17004A19 RID: 18969
		// (get) Token: 0x0600F43E RID: 62526 RVA: 0x00239F3D File Offset: 0x0023813D
		[Nullable(2)]
		public virtual string SeqMarkBeforeModifyMat
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.SeqMarkBeforeModifyMat;
			}
		}

		// Token: 0x040085ED RID: 34285
		private ISwitchDataLayersTransitionWithSequence Instance;
	}
}
