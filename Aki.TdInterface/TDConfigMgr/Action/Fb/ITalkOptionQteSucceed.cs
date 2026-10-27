using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002512 RID: 9490
	public class ITalkOptionQteSucceed : ITalkOptionParamType
	{
		// Token: 0x0600D3B0 RID: 54192 RVA: 0x001F5D78 File Offset: 0x001F3F78
		[NullableContext(1)]
		public static ITalkOptionQteSucceed Create(ITalkOptionQteSucceed? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionQteSucceed
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B4E RID: 15182
		// (get) Token: 0x0600D3B1 RID: 54193 RVA: 0x001F5D97 File Offset: 0x001F3F97
		public override ETalkOptionParamType Type
		{
			get
			{
				return (ETalkOptionParamType)this.Instance.Type;
			}
		}

		// Token: 0x04007404 RID: 29700
		private ITalkOptionQteSucceed Instance;
	}
}
