using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002859 RID: 10329
	[NullableContext(1)]
	[Nullable(0)]
	public class ISignalBreakGameplay : IUiGame
	{
		// Token: 0x0600E4FB RID: 58619 RVA: 0x0021B04B File Offset: 0x0021924B
		public static ISignalBreakGameplay Create(ISignalBreakGameplay? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISignalBreakGameplay
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700460B RID: 17931
		// (get) Token: 0x0600E4FC RID: 58620 RVA: 0x0021B06A File Offset: 0x0021926A
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x1700460C RID: 17932
		// (get) Token: 0x0600E4FD RID: 58621 RVA: 0x0021B077 File Offset: 0x00219277
		public virtual string SignalBreakId
		{
			get
			{
				return this.Instance.SignalBreakId;
			}
		}

		// Token: 0x04007EAD RID: 32429
		private ISignalBreakGameplay Instance;
	}
}
