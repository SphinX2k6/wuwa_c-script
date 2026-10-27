using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C1D RID: 3101
	public class IMonsterNpcInteractionGazePerform : IMonsterNpcInteractionConfig
	{
		// Token: 0x06004713 RID: 18195 RVA: 0x000B30A4 File Offset: 0x000B12A4
		[NullableContext(1)]
		public static IMonsterNpcInteractionGazePerform Create(IMonsterNpcInteractionGazePerform? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterNpcInteractionGazePerform
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001496 RID: 5270
		// (get) Token: 0x06004714 RID: 18196 RVA: 0x000B30C3 File Offset: 0x000B12C3
		public override EMonsterNpcInteractionType Type
		{
			get
			{
				return (EMonsterNpcInteractionType)this.Instance.Type;
			}
		}

		// Token: 0x04002858 RID: 10328
		private IMonsterNpcInteractionGazePerform Instance;
	}
}
