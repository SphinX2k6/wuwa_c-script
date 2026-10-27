using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelAi
{
	// Token: 0x02006DAC RID: 28076
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelAiNode : IStaticVariableResetter
	{
		// Token: 0x0604481D RID: 280605 RVA: 0x010E4DCD File Offset: 0x010E2FCD
		static LevelAiNode()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelAiNode.CreateStaticDefaultValue), new Action(LevelAiNode.ResetStaticDefaultValue));
		}

		// Token: 0x0604481E RID: 280606 RVA: 0x010E4DEC File Offset: 0x010E2FEC
		public virtual void Serialize(CharacterPlanComponent ownerComponent, CreatureDataComponent creatureDataComp, string description, [Nullable(2)] ActionParams @params = null)
		{
			this.CharacterPlanComp = ownerComponent;
			this.CreatureDataComp = creatureDataComp;
			this.Description = description;
		}

		// Token: 0x170099B4 RID: 39348
		// (get) Token: 0x0604481F RID: 280607 RVA: 0x010E4E03 File Offset: 0x010E3003
		public CreatureDataComponent CreatureDataComponent
		{
			get
			{
				return this.CreatureDataComp;
			}
		}

		// Token: 0x170099B5 RID: 39349
		// (get) Token: 0x06044820 RID: 280608 RVA: 0x010E4E0B File Offset: 0x010E300B
		public CharacterPlanComponent CharacterPlanComponent
		{
			get
			{
				return this.CharacterPlanComp;
			}
		}

		// Token: 0x06044821 RID: 280609 RVA: 0x010E4E13 File Offset: 0x010E3013
		public void PrintDescription(string reason, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
		}

		// Token: 0x06044822 RID: 280610 RVA: 0x010E4E15 File Offset: 0x010E3015
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06044823 RID: 280611 RVA: 0x010E4E17 File Offset: 0x010E3017
		public static void ResetStaticDefaultValue()
		{
			LevelAiNode.UidGenerator = 0;
		}

		// Token: 0x04023A08 RID: 145928
		private static int UidGenerator;

		// Token: 0x04023A09 RID: 145929
		private readonly int Uid = ++LevelAiNode.UidGenerator;

		// Token: 0x04023A0A RID: 145930
		[Nullable(2)]
		private CreatureDataComponent CreatureDataComp;

		// Token: 0x04023A0B RID: 145931
		[Nullable(2)]
		private CharacterPlanComponent CharacterPlanComp;

		// Token: 0x04023A0C RID: 145932
		protected string Description = "";
	}
}
