using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DB2 RID: 3506
	public class IFanInteractByFKey : IFanInteractType
	{
		// Token: 0x06004FAA RID: 20394 RVA: 0x000C6373 File Offset: 0x000C4573
		public static IFanInteractByFKey Create(IFanInteractByFKey? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFanInteractByFKey
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001841 RID: 6209
		// (get) Token: 0x06004FAB RID: 20395 RVA: 0x000C6392 File Offset: 0x000C4592
		public override EFanInteractType Type
		{
			get
			{
				return (EFanInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17001842 RID: 6210
		// (get) Token: 0x06004FAC RID: 20396 RVA: 0x000C639F File Offset: 0x000C459F
		public virtual string TidInteractOptionText
		{
			get
			{
				return this.Instance.TidInteractOptionText;
			}
		}

		// Token: 0x17001843 RID: 6211
		// (get) Token: 0x06004FAD RID: 20397 RVA: 0x000C63AC File Offset: 0x000C45AC
		[Nullable(2)]
		public virtual string EdTidInteractOptionText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04002D69 RID: 11625
		private IFanInteractByFKey Instance;
	}
}
