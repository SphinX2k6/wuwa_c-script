using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026FA RID: 9978
	public class IMonsterNpcInteractConfigBase
	{
		// Token: 0x0600DEC5 RID: 57029 RVA: 0x00210A4A File Offset: 0x0020EC4A
		[NullableContext(1)]
		public static IMonsterNpcInteractConfigBase Create(IMonsterNpcInteractConfigBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterNpcInteractConfigBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004293 RID: 17043
		// (get) Token: 0x0600DEC6 RID: 57030 RVA: 0x00210A69 File Offset: 0x0020EC69
		public virtual EMonsterNpcInteractType Type
		{
			get
			{
				return (EMonsterNpcInteractType)this.Instance.Type;
			}
		}

		// Token: 0x04007BA6 RID: 31654
		private IMonsterNpcInteractConfigBase Instance;
	}
}
