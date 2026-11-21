using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002928 RID: 10536
	public class IHandInItemViewStyle : IDeliverItemProbeCollectibleViewStyle
	{
		// Token: 0x0600EA1D RID: 59933 RVA: 0x00228CD5 File Offset: 0x00226ED5
		public static IHandInItemViewStyle Create(IHandInItemViewStyle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHandInItemViewStyle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700447B RID: 17531
		// (get) Token: 0x0600EA1E RID: 59934 RVA: 0x00228CF4 File Offset: 0x00226EF4
		public override EDeliverItemProbeCollectibleViewStyle Type
		{
			get
			{
				return (EDeliverItemProbeCollectibleViewStyle)this.Instance.Type;
			}
		}

		// Token: 0x1700447C RID: 17532
		// (get) Token: 0x0600EA1F RID: 59935 RVA: 0x00228D01 File Offset: 0x00226F01
		public virtual string TidDescText
		{
			get
			{
				return this.Instance.TidDescText;
			}
		}

		// Token: 0x1700447D RID: 17533
		// (get) Token: 0x0600EA20 RID: 59936 RVA: 0x00228D0E File Offset: 0x00226F0E
		[Nullable(2)]
		public virtual string EdTidDescText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x0400810A RID: 33034
		private IHandInItemViewStyle Instance;
	}
}
