using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002513 RID: 9491
	public class ITalkOptionQteFailed : ITalkOptionParamType
	{
		// Token: 0x0600D3B3 RID: 54195 RVA: 0x001F5DAC File Offset: 0x001F3FAC
		[NullableContext(1)]
		public static ITalkOptionQteFailed Create(ITalkOptionQteFailed? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionQteFailed
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B4F RID: 15183
		// (get) Token: 0x0600D3B4 RID: 54196 RVA: 0x001F5DCB File Offset: 0x001F3FCB
		public override ETalkOptionParamType Type
		{
			get
			{
				return (ETalkOptionParamType)this.Instance.Type;
			}
		}

		// Token: 0x04007405 RID: 29701
		private ITalkOptionQteFailed Instance;
	}
}
