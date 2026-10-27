using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002511 RID: 9489
	public class ITalkOptionParamType
	{
		// Token: 0x0600D3AD RID: 54189 RVA: 0x001F5D44 File Offset: 0x001F3F44
		[NullableContext(1)]
		public static ITalkOptionParamType Create(ITalkOptionParamType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionParamType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B4D RID: 15181
		// (get) Token: 0x0600D3AE RID: 54190 RVA: 0x001F5D63 File Offset: 0x001F3F63
		public virtual ETalkOptionParamType Type
		{
			get
			{
				return (ETalkOptionParamType)this.Instance.Type;
			}
		}

		// Token: 0x04007403 RID: 29699
		private ITalkOptionParamType Instance;
	}
}
