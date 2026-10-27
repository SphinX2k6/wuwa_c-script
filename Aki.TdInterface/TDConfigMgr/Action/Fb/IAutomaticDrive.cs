using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028E0 RID: 10464
	public class IAutomaticDrive
	{
		// Token: 0x0600E879 RID: 59513 RVA: 0x00221E9E File Offset: 0x0022009E
		[NullableContext(1)]
		public static IAutomaticDrive Create(IAutomaticDrive? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAutomaticDrive
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700487B RID: 18555
		// (get) Token: 0x0600E87A RID: 59514 RVA: 0x00221EBD File Offset: 0x002200BD
		public virtual float StandbyTime
		{
			get
			{
				return this.Instance.StandbyTime;
			}
		}

		// Token: 0x04008062 RID: 32866
		private IAutomaticDrive Instance;
	}
}
