using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x020064CB RID: 25803
	public static class EMatchThreePieceSequenceExtensions
	{
		// Token: 0x06040C25 RID: 265253 RVA: 0x00FADFB4 File Offset: 0x00FAC1B4
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

		// Token: 0x06040C26 RID: 265254 RVA: 0x00FADFFC File Offset: 0x00FAC1FC
		public static EMatchThreePieceSequence FromString(string name)
		{
			EMatchThreePieceSequence result;
			if (!EMatchThreePieceSequenceExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMatchThreePieceSequence 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06040C27 RID: 265255 RVA: 0x00FAE028 File Offset: 0x00FAC228
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

		// Token: 0x06040C28 RID: 265256 RVA: 0x00FAE07E File Offset: 0x00FAC27E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"GetXin",
				"Clean",
				"Born"
			};
		}

		// Token: 0x06040C29 RID: 265257 RVA: 0x00FAE09E File Offset: 0x00FAC29E
		public static EMatchThreePieceSequence[] GetValues()
		{
			return new EMatchThreePieceSequence[]
			{
				EMatchThreePieceSequence.Recolor,
				EMatchThreePieceSequence.Clean,
				EMatchThreePieceSequence.Born
			};
		}

		// Token: 0x06040C2A RID: 265258 RVA: 0x00FAE0AE File Offset: 0x00FAC2AE
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
