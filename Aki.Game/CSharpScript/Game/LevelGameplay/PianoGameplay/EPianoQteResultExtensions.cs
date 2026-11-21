using System;

namespace CSharpScript.Game.LevelGamePlay.PianoGameplay
{
	// Token: 0x02005C30 RID: 23600
	public static class EPianoQteResultExtensions
	{
		// Token: 0x06039F63 RID: 237411 RVA: 0x0104D7A0 File Offset: 0x0104B9A0
		public static string ToEnumString(this EPianoQteResult value)
		{
			string result;
			switch (value)
			{
			case EPianoQteResult.Success:
				result = "Success";
				break;
			case EPianoQteResult.Fail:
				result = "Fail";
				break;
			case EPianoQteResult.Timeout:
				result = "Timeout";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06039F64 RID: 237412 RVA: 0x0104D7E8 File Offset: 0x0104B9E8
		public static EPianoQteResult FromString(string name)
		{
			EPianoQteResult result;
			if (!EPianoQteResultExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPianoQteResult 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06039F65 RID: 237413 RVA: 0x0104D814 File Offset: 0x0104BA14
		public static bool TryFromString(string name, out EPianoQteResult value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPianoQteResult.Success;
				return false;
			}
			if (name == "Success")
			{
				value = EPianoQteResult.Success;
				return true;
			}
			if (name == "Fail")
			{
				value = EPianoQteResult.Fail;
				return true;
			}
			if (!(name == "Timeout"))
			{
				value = EPianoQteResult.Success;
				return false;
			}
			value = EPianoQteResult.Timeout;
			return true;
		}

		// Token: 0x06039F66 RID: 237414 RVA: 0x0104D86A File Offset: 0x0104BA6A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Success",
				"Fail",
				"Timeout"
			};
		}

		// Token: 0x06039F67 RID: 237415 RVA: 0x0104D88A File Offset: 0x0104BA8A
		public static EPianoQteResult[] GetValues()
		{
			return new EPianoQteResult[]
			{
				EPianoQteResult.Success,
				EPianoQteResult.Fail,
				EPianoQteResult.Timeout
			};
		}

		// Token: 0x06039F68 RID: 237416 RVA: 0x0104D89A File Offset: 0x0104BA9A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Success",
				"Fail",
				"Timeout"
			};
		}
	}
}
