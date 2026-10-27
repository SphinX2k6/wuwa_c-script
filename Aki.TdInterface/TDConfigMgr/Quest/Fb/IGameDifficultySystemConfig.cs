using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020012DF RID: 4831
	public class IGameDifficultySystemConfig : IEnableSystemConfig
	{
		// Token: 0x06006E63 RID: 28259 RVA: 0x0010ACA5 File Offset: 0x00108EA5
		[NullableContext(1)]
		public static IGameDifficultySystemConfig Create(IGameDifficultySystemConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGameDifficultySystemConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002278 RID: 8824
		// (get) Token: 0x06006E64 RID: 28260 RVA: 0x0010ACC4 File Offset: 0x00108EC4
		public override EEnableSystemType Type
		{
			get
			{
				return (EEnableSystemType)this.Instance.Type;
			}
		}

		// Token: 0x04003F3D RID: 16189
		private IGameDifficultySystemConfig Instance;
	}
}
