using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002860 RID: 10336
	public class IProjectorPuzzle : IUiGame
	{
		// Token: 0x0600E516 RID: 58646 RVA: 0x0021B2E2 File Offset: 0x002194E2
		[NullableContext(1)]
		public static IProjectorPuzzle Create(IProjectorPuzzle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IProjectorPuzzle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004618 RID: 17944
		// (get) Token: 0x0600E517 RID: 58647 RVA: 0x0021B301 File Offset: 0x00219501
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x04007EBA RID: 32442
		private IProjectorPuzzle Instance;
	}
}
