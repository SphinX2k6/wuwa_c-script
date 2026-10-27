using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C1A RID: 3098
	public class IMonsterNpcInteractionWallRun : IMonsterNpcInteractionConfig
	{
		// Token: 0x0600470A RID: 18186 RVA: 0x000B3008 File Offset: 0x000B1208
		[NullableContext(1)]
		public static IMonsterNpcInteractionWallRun Create(IMonsterNpcInteractionWallRun? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterNpcInteractionWallRun
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001493 RID: 5267
		// (get) Token: 0x0600470B RID: 18187 RVA: 0x000B3027 File Offset: 0x000B1227
		public override EMonsterNpcInteractionType Type
		{
			get
			{
				return (EMonsterNpcInteractionType)this.Instance.Type;
			}
		}

		// Token: 0x04002855 RID: 10325
		private IMonsterNpcInteractionWallRun Instance;
	}
}
