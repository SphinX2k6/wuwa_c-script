using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelAi
{
	// Token: 0x02006DBA RID: 28090
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelAiWorldState : IStaticVariableResetter
	{
		// Token: 0x060448A4 RID: 280740 RVA: 0x010E7003 File Offset: 0x010E5203
		static LevelAiWorldState()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelAiWorldState.CreateStaticDefaultValue), new Action(LevelAiWorldState.ResetStaticDefaultValue));
		}

		// Token: 0x060448A5 RID: 280741 RVA: 0x010E7022 File Offset: 0x010E5222
		public void SetBooleanWorldState(string key, bool value)
		{
			this.BooleanWorldState[key] = value;
		}

		// Token: 0x060448A6 RID: 280742 RVA: 0x010E7031 File Offset: 0x010E5231
		public void SetIntWorldState(string key, long value)
		{
			this.IntWorldState[key] = value;
		}

		// Token: 0x060448A7 RID: 280743 RVA: 0x010E7040 File Offset: 0x010E5240
		public void RemoveBooleanWorldState(string key)
		{
			this.BooleanWorldState.Remove(key);
		}

		// Token: 0x060448A8 RID: 280744 RVA: 0x010E704F File Offset: 0x010E524F
		public void RemoveIntWorldState(string key)
		{
			this.IntWorldState.Remove(key);
		}

		// Token: 0x060448A9 RID: 280745 RVA: 0x010E705E File Offset: 0x010E525E
		public bool GetBooleanWorldState(string key)
		{
			return this.BooleanWorldState[key];
		}

		// Token: 0x060448AA RID: 280746 RVA: 0x010E706C File Offset: 0x010E526C
		public long GetIntWorldState(string key)
		{
			return this.IntWorldState[key];
		}

		// Token: 0x060448AB RID: 280747 RVA: 0x010E707C File Offset: 0x010E527C
		public LevelAiWorldState MakeCopy()
		{
			LevelAiWorldState levelAiWorldState = new LevelAiWorldState();
			foreach (KeyValuePair<string, bool> keyValuePair in this.BooleanWorldState)
			{
				levelAiWorldState.BooleanWorldState[keyValuePair.Key] = keyValuePair.Value;
			}
			foreach (KeyValuePair<string, long> keyValuePair2 in this.IntWorldState)
			{
				levelAiWorldState.IntWorldState[keyValuePair2.Key] = keyValuePair2.Value;
			}
			return levelAiWorldState;
		}

		// Token: 0x060448AC RID: 280748 RVA: 0x010E7140 File Offset: 0x010E5340
		public static void CreateStaticDefaultValue()
		{
			LevelAiWorldState.UidGenerator = 0;
		}

		// Token: 0x060448AD RID: 280749 RVA: 0x010E7148 File Offset: 0x010E5348
		public static void ResetStaticDefaultValue()
		{
			LevelAiWorldState.UidGenerator = 0;
		}

		// Token: 0x04023A47 RID: 145991
		private static int UidGenerator;

		// Token: 0x04023A48 RID: 145992
		public readonly int Uid = ++LevelAiWorldState.UidGenerator;

		// Token: 0x04023A49 RID: 145993
		public Dictionary<string, bool> BooleanWorldState = new Dictionary<string, bool>();

		// Token: 0x04023A4A RID: 145994
		public Dictionary<string, long> IntWorldState = new Dictionary<string, long>();
	}
}
