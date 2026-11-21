using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x02005449 RID: 21577
	public static class EMatchThreePieceSequenceExtensions
	{
		// Token: 0x060358E9 RID: 219369 RVA: 0x00EF4FFC File Offset: 0x00EF31FC
		public static string ToEnumString(this EMatchThreePieceSequence value)
		{
			string result;
			switch (value)
			{
			case EMatchThreePieceSequence.Recolor:
				result = "GetXin";
				break;
			case EMatchThreePieceSequence.Clean:
				result = "Clean";
				break;
			case EMatchThreePieceSequence.Born:
				result = "Born";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x060358EA RID: 219370 RVA: 0x00EF5044 File Offset: 0x00EF3244
		public static EMatchThreePieceSequence FromString(string name)
		{
			EMatchThreePieceSequence result;
			if (!EMatchThreePieceSequenceExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMatchThreePieceSequence 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060358EB RID: 219371 RVA: 0x00EF5070 File Offset: 0x00EF3270
		public static bool TryFromString(string name, out EMatchThreePieceSequence value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMatchThreePieceSequence.Recolor;
				return false;
			}
			if (name == "GetXin")
			{
				value = EMatchThreePieceSequence.Recolor;
				return true;
			}
			if (name == "Clean")
			{
				value = EMatchThreePieceSequence.Clean;
				return true;
			}
			if (!(name == "Born"))
			{
				value = EMatchThreePieceSequence.Recolor;
				return false;
			}
			value = EMatchThreePieceSequence.Born;
			return true;
		}

		// Token: 0x060358EC RID: 219372 RVA: 0x00EF50C6 File Offset: 0x00EF32C6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"GetXin",
				"Clean",
				"Born"
			};
		}

		// Token: 0x060358ED RID: 219373 RVA: 0x00EF50E6 File Offset: 0x00EF32E6
		public static EMatchThreePieceSequence[] GetValues()
		{
			return new EMatchThreePieceSequence[]
			{
				EMatchThreePieceSequence.Recolor,
				EMatchThreePieceSequence.Clean,
				EMatchThreePieceSequence.Born
			};
		}

		// Token: 0x060358EE RID: 219374 RVA: 0x00EF50F6 File Offset: 0x00EF32F6
		public static string[] GetNames()
		{
			return new string[]
			{
				"Recolor",
				"Clean",
				"Born"
			};
		}
	}
}
