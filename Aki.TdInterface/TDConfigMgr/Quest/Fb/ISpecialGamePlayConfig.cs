using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020012D5 RID: 4821
	public class ISpecialGamePlayConfig
	{
		// Token: 0x06006E37 RID: 28215 RVA: 0x0010A8D6 File Offset: 0x00108AD6
		[NullableContext(1)]
		public static ISpecialGamePlayConfig Create(ISpecialGamePlayConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpecialGamePlayConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002260 RID: 8800
		// (get) Token: 0x06006E38 RID: 28216 RVA: 0x0010A8F5 File Offset: 0x00108AF5
		public virtual ESpecialGamePlayConfigType Type
		{
			get
			{
				return (ESpecialGamePlayConfigType)this.Instance.Type;
			}
		}

		// Token: 0x04003F2B RID: 16171
		private ISpecialGamePlayConfig Instance;
	}
}
