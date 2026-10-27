using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B81 RID: 2945
	public class ISpwanMonsterMode
	{
		// Token: 0x060043C9 RID: 17353 RVA: 0x000AC904 File Offset: 0x000AAB04
		[NullableContext(1)]
		public static ISpwanMonsterMode Create(ISpwanMonsterMode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpwanMonsterMode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001284 RID: 4740
		// (get) Token: 0x060043CA RID: 17354 RVA: 0x000AC923 File Offset: 0x000AAB23
		public virtual ESpawnMonsterConstraint Type
		{
			get
			{
				return (ESpawnMonsterConstraint)this.Instance.Type;
			}
		}

		// Token: 0x0400263A RID: 9786
		private ISpwanMonsterMode Instance;
	}
}
