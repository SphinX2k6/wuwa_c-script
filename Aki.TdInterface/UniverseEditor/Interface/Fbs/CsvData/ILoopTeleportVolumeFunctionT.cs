using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004915 RID: 18709
	public class ILoopTeleportVolumeFunctionT
	{
		// Token: 0x170087A9 RID: 34729
		// (get) Token: 0x0601D41E RID: 119838 RVA: 0x004208FF File Offset: 0x0041EAFF
		// (set) Token: 0x0601D41F RID: 119839 RVA: 0x00420907 File Offset: 0x0041EB07
		public int Id { get; set; }

		// Token: 0x170087AA RID: 34730
		// (get) Token: 0x0601D420 RID: 119840 RVA: 0x00420910 File Offset: 0x0041EB10
		// (set) Token: 0x0601D421 RID: 119841 RVA: 0x00420918 File Offset: 0x0041EB18
		public string Desc { get; set; }

		// Token: 0x170087AB RID: 34731
		// (get) Token: 0x0601D422 RID: 119842 RVA: 0x00420921 File Offset: 0x0041EB21
		// (set) Token: 0x0601D423 RID: 119843 RVA: 0x00420929 File Offset: 0x0041EB29
		public int DungeonId { get; set; }

		// Token: 0x170087AC RID: 34732
		// (get) Token: 0x0601D424 RID: 119844 RVA: 0x00420932 File Offset: 0x0041EB32
		// (set) Token: 0x0601D425 RID: 119845 RVA: 0x0042093A File Offset: 0x0041EB3A
		public int VolumeId { get; set; }

		// Token: 0x170087AD RID: 34733
		// (get) Token: 0x0601D426 RID: 119846 RVA: 0x00420943 File Offset: 0x0041EB43
		// (set) Token: 0x0601D427 RID: 119847 RVA: 0x0042094B File Offset: 0x0041EB4B
		public IConditionGroupT Conditions { get; set; }

		// Token: 0x170087AE RID: 34734
		// (get) Token: 0x0601D428 RID: 119848 RVA: 0x00420954 File Offset: 0x0041EB54
		// (set) Token: 0x0601D429 RID: 119849 RVA: 0x0042095C File Offset: 0x0041EB5C
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x170087AF RID: 34735
		// (get) Token: 0x0601D42A RID: 119850 RVA: 0x00420965 File Offset: 0x0041EB65
		// (set) Token: 0x0601D42B RID: 119851 RVA: 0x0042096D File Offset: 0x0041EB6D
		public List<ILoopTeleportClientPlayEffectLogicT> ClientLogic { get; set; }

		// Token: 0x170087B0 RID: 34736
		// (get) Token: 0x0601D42C RID: 119852 RVA: 0x00420976 File Offset: 0x0041EB76
		// (set) Token: 0x0601D42D RID: 119853 RVA: 0x0042097E File Offset: 0x0041EB7E
		public byte NullMask { get; set; }

		// Token: 0x0601D42E RID: 119854 RVA: 0x00420987 File Offset: 0x0041EB87
		public ILoopTeleportVolumeFunctionT()
		{
			this.Id = 0;
			this.Desc = null;
			this.DungeonId = 0;
			this.VolumeId = 0;
			this.Conditions = null;
			this.Actions = null;
			this.ClientLogic = null;
			this.NullMask = 0;
		}
	}
}
