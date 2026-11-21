using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelAi
{
	// Token: 0x02005F39 RID: 24377
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelAiWorldState : IStaticVariableResetter
	{
		// Token: 0x0603AA08 RID: 240136 RVA: 0x0109122B File Offset: 0x0108F42B
		static LevelAiWorldState()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelAiWorldState.CreateStaticDefaultValue), new Action(LevelAiWorldState.ResetStaticDefaultValue));
		}

		// Token: 0x0603AA09 RID: 240137 RVA: 0x0109124A File Offset: 0x0108F44A
		public void SetBooleanWorldState(string key, bool value)
		{
			this.BooleanWorldState[key] = value;
		}

		// Token: 0x0603AA0A RID: 240138 RVA: 0x01091259 File Offset: 0x0108F459
		public void SetIntWorldState(string key, long value)
		{
			this.IntWorldState[key] = value;
		}

		// Token: 0x0603AA0B RID: 240139 RVA: 0x01091268 File Offset: 0x0108F468
		public void RemoveBooleanWorldState(string key)
		{
			this.BooleanWorldState.Remove(key);
		}

		// Token: 0x0603AA0C RID: 240140 RVA: 0x01091277 File Offset: 0x0108F477
		public void RemoveIntWorldState(string key)
		{
			this.IntWorldState.Remove(key);
		}

		// Token: 0x0603AA0D RID: 240141 RVA: 0x01091286 File Offset: 0x0108F486
		public bool GetBooleanWorldState(string key)
		{
			return this.BooleanWorldState[key];
		}

		// Token: 0x0603AA0E RID: 240142 RVA: 0x01091294 File Offset: 0x0108F494
		public long GetIntWorldState(string key)
		{
			return this.IntWorldState[key];
		}

		// Token: 0x0603AA0F RID: 240143 RVA: 0x010912A4 File Offset: 0x0108F4A4
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

		// Token: 0x0603AA10 RID: 240144 RVA: 0x01091368 File Offset: 0x0108F568
		public static void CreateStaticDefaultValue()
		{
			LevelAiWorldState.UidGenerator = 0;
		}

		// Token: 0x0603AA11 RID: 240145 RVA: 0x01091370 File Offset: 0x0108F570
		public static void ResetStaticDefaultValue()
		{
			LevelAiWorldState.UidGenerator = 0;
		}

		// Token: 0x0401ECE9 RID: 126185
		private static int UidGenerator;

		// Token: 0x0401ECEA RID: 126186
		public readonly int Uid = ++LevelAiWorldState.UidGenerator;

		// Token: 0x0401ECEB RID: 126187
		public Dictionary<string, bool> BooleanWorldState = new Dictionary<string, bool>();

		// Token: 0x0401ECEC RID: 126188
		public Dictionary<string, long> IntWorldState = new Dictionary<string, long>();
	}
}
