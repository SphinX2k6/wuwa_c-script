using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200279D RID: 10141
	[NullableContext(1)]
	[Nullable(0)]
	public class ISubScreenPresetInitData : ISubScreenInitData
	{
		// Token: 0x0600E1AF RID: 57775 RVA: 0x00215907 File Offset: 0x00213B07
		public static ISubScreenPresetInitData Create(ISubScreenPresetInitData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubScreenPresetInitData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004437 RID: 17463
		// (get) Token: 0x0600E1B0 RID: 57776 RVA: 0x00215926 File Offset: 0x00213B26
		public override ESubScreenInitDataType Type
		{
			get
			{
				return (ESubScreenInitDataType)this.Instance.Type;
			}
		}

		// Token: 0x17004438 RID: 17464
		// (get) Token: 0x0600E1B1 RID: 57777 RVA: 0x00215933 File Offset: 0x00213B33
		public override string SubScreenKey
		{
			get
			{
				return this.Instance.SubScreenKey;
			}
		}

		// Token: 0x17004439 RID: 17465
		// (get) Token: 0x0600E1B2 RID: 57778 RVA: 0x00215940 File Offset: 0x00213B40
		public virtual ESubScreenInitPreset AnchorType
		{
			get
			{
				return (ESubScreenInitPreset)this.Instance.AnchorType;
			}
		}

		// Token: 0x04007D25 RID: 32037
		private ISubScreenPresetInitData Instance;
	}
}
