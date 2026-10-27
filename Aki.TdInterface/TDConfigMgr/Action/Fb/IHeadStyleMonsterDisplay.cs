using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002507 RID: 9479
	public class IHeadStyleMonsterDisplay : IHeadStyle
	{
		// Token: 0x0600D381 RID: 54145 RVA: 0x001F5926 File Offset: 0x001F3B26
		[NullableContext(1)]
		public static IHeadStyleMonsterDisplay Create(IHeadStyleMonsterDisplay? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHeadStyleMonsterDisplay
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B35 RID: 15157
		// (get) Token: 0x0600D382 RID: 54146 RVA: 0x001F5945 File Offset: 0x001F3B45
		public override EHeadStyle Type
		{
			get
			{
				return (EHeadStyle)this.Instance.Type;
			}
		}

		// Token: 0x17003B36 RID: 15158
		// (get) Token: 0x0600D383 RID: 54147 RVA: 0x001F5952 File Offset: 0x001F3B52
		public virtual int MonsterDisplayId
		{
			get
			{
				return this.Instance.MonsterDisplayId;
			}
		}

		// Token: 0x040073F1 RID: 29681
		private IHeadStyleMonsterDisplay Instance;
	}
}
