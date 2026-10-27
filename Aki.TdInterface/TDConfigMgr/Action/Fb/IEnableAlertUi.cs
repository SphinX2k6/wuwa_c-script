using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029FB RID: 10747
	public class IEnableAlertUi : IAlertSystemOption
	{
		// Token: 0x0600ED35 RID: 60725 RVA: 0x0022993B File Offset: 0x00227B3B
		[NullableContext(1)]
		public static IEnableAlertUi Create(IEnableAlertUi? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableAlertUi
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B01 RID: 19201
		// (get) Token: 0x0600ED36 RID: 60726 RVA: 0x0022995A File Offset: 0x00227B5A
		public override EAlertSystemOption Type
		{
			get
			{
				return (EAlertSystemOption)this.Instance.Type;
			}
		}

		// Token: 0x17004B02 RID: 19202
		// (get) Token: 0x0600ED37 RID: 60727 RVA: 0x00229967 File Offset: 0x00227B67
		public override int AreaId
		{
			get
			{
				return this.Instance.AreaId;
			}
		}

		// Token: 0x17004B03 RID: 19203
		// (get) Token: 0x0600ED38 RID: 60728 RVA: 0x00229974 File Offset: 0x00227B74
		public virtual bool IsEnable
		{
			get
			{
				return this.Instance.IsEnable;
			}
		}

		// Token: 0x04008299 RID: 33433
		private IEnableAlertUi Instance;
	}
}
