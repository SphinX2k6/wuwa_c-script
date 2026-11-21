using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelAi
{
	// Token: 0x02005F2B RID: 24363
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelAiNode : IStaticVariableResetter
	{
		// Token: 0x0603A981 RID: 240001 RVA: 0x0108EFF5 File Offset: 0x0108D1F5
		static LevelAiNode()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelAiNode.CreateStaticDefaultValue), new Action(LevelAiNode.ResetStaticDefaultValue));
		}

		// Token: 0x0603A982 RID: 240002 RVA: 0x0108F014 File Offset: 0x0108D214
		public virtual void Serialize(CharacterPlanComponent ownerComponent, CreatureDataComponent creatureDataComp, string description, [Nullable(2)] ActionParams @params = null)
		{
			this.CharacterPlanComp = ownerComponent;
			this.CreatureDataComp = creatureDataComp;
			this.Description = description;
		}

		// Token: 0x17006EB7 RID: 28343
		// (get) Token: 0x0603A983 RID: 240003 RVA: 0x0108F02B File Offset: 0x0108D22B
		public CreatureDataComponent CreatureDataComponent
		{
			get
			{
				return this.CreatureDataComp;
			}
		}

		// Token: 0x17006EB8 RID: 28344
		// (get) Token: 0x0603A984 RID: 240004 RVA: 0x0108F033 File Offset: 0x0108D233
		public CharacterPlanComponent CharacterPlanComponent
		{
			get
			{
				return this.CharacterPlanComp;
			}
		}

		// Token: 0x0603A985 RID: 240005 RVA: 0x0108F03B File Offset: 0x0108D23B
		public void PrintDescription(string reason, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
		}

		// Token: 0x0603A986 RID: 240006 RVA: 0x0108F03D File Offset: 0x0108D23D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603A987 RID: 240007 RVA: 0x0108F03F File Offset: 0x0108D23F
		public static void ResetStaticDefaultValue()
		{
			LevelAiNode.UidGenerator = 0;
		}

		// Token: 0x0401ECAA RID: 126122
		private static int UidGenerator;

		// Token: 0x0401ECAB RID: 126123
		private readonly int Uid = ++LevelAiNode.UidGenerator;

		// Token: 0x0401ECAC RID: 126124
		[Nullable(2)]
		private CreatureDataComponent CreatureDataComp;

		// Token: 0x0401ECAD RID: 126125
		[Nullable(2)]
		private CharacterPlanComponent CharacterPlanComp;

		// Token: 0x0401ECAE RID: 126126
		protected string Description = "";
	}
}
