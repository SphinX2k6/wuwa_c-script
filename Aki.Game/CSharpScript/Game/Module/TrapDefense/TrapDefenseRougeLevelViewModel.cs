using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A32 RID: 14898
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseRougeLevelViewModel
	{
		// Token: 0x060264FC RID: 156924 RVA: 0x00ABB05B File Offset: 0x00AB925B
		public static TrapDefenseRougeLevelViewModel Create(TrapDefenseModel model)
		{
			return new TrapDefenseRougeLevelViewModel
			{
				Model = model
			};
		}

		// Token: 0x060264FD RID: 156925 RVA: 0x00ABB069 File Offset: 0x00AB9269
		private TrapDefenseRougeLevelViewModel()
		{
		}

		// Token: 0x060264FE RID: 156926 RVA: 0x00ABB071 File Offset: 0x00AB9271
		public void OnViewClose()
		{
		}

		// Token: 0x060264FF RID: 156927 RVA: 0x00ABB074 File Offset: 0x00AB9274
		public void SetJumpLevelData(int? id)
		{
			TrapDefenseLevelData trapDefenseLevelData;
			this.JumpLevelData = (this.Model.LevelDataFromIdMap.TryGetValue(id.GetValueOrDefault(), out trapDefenseLevelData) ? trapDefenseLevelData : null);
		}

		// Token: 0x06026500 RID: 156928 RVA: 0x00ABB0A6 File Offset: 0x00AB92A6
		public void SetIsInstance(bool isInstance)
		{
			this.IsInstance = isInstance;
		}

		// Token: 0x04015089 RID: 86153
		public TrapDefenseModel Model;

		// Token: 0x0401508A RID: 86154
		[Nullable(2)]
		public TrapDefenseLevelData JumpLevelData;

		// Token: 0x0401508B RID: 86155
		public bool IsInstance;
	}
}
