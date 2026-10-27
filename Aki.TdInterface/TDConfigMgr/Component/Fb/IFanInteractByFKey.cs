using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CCE RID: 3278
	[NullableContext(1)]
	[Nullable(0)]
	public class IFanInteractByFKey : IFanInteractType
	{
		// Token: 0x06004AEF RID: 19183 RVA: 0x000BB73B File Offset: 0x000B993B
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

		// Token: 0x17001710 RID: 5904
		// (get) Token: 0x06004AF0 RID: 19184 RVA: 0x000BB75A File Offset: 0x000B995A
		public override EFanInteractType Type
		{
			get
			{
				return (EFanInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17001711 RID: 5905
		// (get) Token: 0x06004AF1 RID: 19185 RVA: 0x000BB767 File Offset: 0x000B9967
		public virtual string TidInteractOptionText
		{
			get
			{
				return this.Instance.TidInteractOptionText;
			}
		}

		// Token: 0x17001712 RID: 5906
		// (get) Token: 0x06004AF2 RID: 19186 RVA: 0x000BB774 File Offset: 0x000B9974
		[Nullable(2)]
		public virtual string EdTidInteractOptionText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04002AE3 RID: 10979
		private IFanInteractByFKey Instance;
	}
}
