using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002889 RID: 10377
	[NullableContext(1)]
	[Nullable(0)]
	public class IMontageAsset : IMontageConfig
	{
		// Token: 0x0600E5E3 RID: 58851 RVA: 0x0021CB03 File Offset: 0x0021AD03
		public static IMontageAsset Create(IMontageAsset? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMontageAsset
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004693 RID: 18067
		// (get) Token: 0x0600E5E4 RID: 58852 RVA: 0x0021CB22 File Offset: 0x0021AD22
		public override EMontageConfigType Type
		{
			get
			{
				return (EMontageConfigType)this.Instance.Type;
			}
		}

		// Token: 0x17004694 RID: 18068
		// (get) Token: 0x0600E5E5 RID: 58853 RVA: 0x0021CB2F File Offset: 0x0021AD2F
		public virtual string Asset
		{
			get
			{
				return this.Instance.Asset;
			}
		}

		// Token: 0x04007F19 RID: 32537
		private IMontageAsset Instance;
	}
}
