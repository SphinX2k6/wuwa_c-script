using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200286B RID: 10347
	public class IWriteLetter : IUiGame
	{
		// Token: 0x0600E54A RID: 58698 RVA: 0x0021B7D8 File Offset: 0x002199D8
		[NullableContext(1)]
		public static IWriteLetter Create(IWriteLetter? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWriteLetter
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004636 RID: 17974
		// (get) Token: 0x0600E54B RID: 58699 RVA: 0x0021B7F7 File Offset: 0x002199F7
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x17004637 RID: 17975
		// (get) Token: 0x0600E54C RID: 58700 RVA: 0x0021B804 File Offset: 0x00219A04
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x04007ECD RID: 32461
		private IWriteLetter Instance;
	}
}
