using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A8A RID: 19082
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseRougeLevelViewModel
	{
		// Token: 0x0603176C RID: 202604 RVA: 0x00B770A7 File Offset: 0x00B752A7
		public static TrapDefenseRougeLevelViewModel Create(TrapDefenseModel model)
		{
			return new TrapDefenseRougeLevelViewModel
			{
				Model = model
			};
		}

		// Token: 0x0603176D RID: 202605 RVA: 0x00B770B5 File Offset: 0x00B752B5
		private TrapDefenseRougeLevelViewModel()
		{
		}

		// Token: 0x0603176E RID: 202606 RVA: 0x00B770BD File Offset: 0x00B752BD
		public void OnViewClose()
		{
		}

		// Token: 0x0603176F RID: 202607 RVA: 0x00B770C0 File Offset: 0x00B752C0
		public void SetJumpLevelData(int? id)
		{
			TrapDefenseLevelData trapDefenseLevelData;
			this.JumpLevelData = (this.Model.LevelDataFromIdMap.TryGetValue(id.GetValueOrDefault(), out trapDefenseLevelData) ? trapDefenseLevelData : null);
		}

		// Token: 0x06031770 RID: 202608 RVA: 0x00B770F2 File Offset: 0x00B752F2
		public void SetIsInstance(bool isInstance)
		{
			this.IsInstance = isInstance;
		}

		// Token: 0x0401A737 RID: 108343
		public TrapDefenseModel Model;

		// Token: 0x0401A738 RID: 108344
		[Nullable(2)]
		public TrapDefenseLevelData JumpLevelData;

		// Token: 0x0401A739 RID: 108345
		public bool IsInstance;
	}
}
