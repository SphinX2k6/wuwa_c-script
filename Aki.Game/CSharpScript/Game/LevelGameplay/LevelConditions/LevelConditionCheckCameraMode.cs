using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Camera;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005DD0 RID: 24016
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelConditionCheckCameraMode : LevelConditionBase
	{
		// Token: 0x0603A672 RID: 239218 RVA: 0x01080D9C File Offset: 0x0107EF9C
		private List<int> ParseModes([Nullable(2)] string raw)
		{
			if (string.IsNullOrEmpty(raw))
			{
				return new List<int>();
			}
			string text = raw.TrimStart('[').TrimEnd(']');
			List<int> list = new List<int>();
			foreach (string s in text.Split(',', StringSplitOptions.None))
			{
				list.Add(int.Parse(s));
			}
			return list;
		}

		// Token: 0x0603A673 RID: 239219 RVA: 0x01080DF4 File Offset: 0x0107EFF4
		private List<int> GetModes(Condition inConditionInfo)
		{
			List<int> list;
			if (!this.ModeCache.TryGetValue(inConditionInfo.Id, out list))
			{
				list = this.ParseModes(inConditionInfo.GetLimitParams("Mode"));
				this.ModeCache[inConditionInfo.Id] = list;
			}
			return list;
		}

		// Token: 0x0603A674 RID: 239220 RVA: 0x01080E40 File Offset: 0x0107F040
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			List<int> modes = this.GetModes(inConditionInfo);
			if (modes.Count == 0)
			{
				return false;
			}
			ECustomCameraMode value = CameraModel.Instance.MainModel.CameraMode.Value;
			bool flag = modes.Contains((int)value);
			string text = inConditionInfo.GetLimitParamsOpe("Mode") ?? "";
			bool result = false;
			if (!(text == "!="))
			{
				if (!(text == "="))
				{
					if (text == null)
					{
						return result;
					}
					if (text.Length != 0)
					{
						return result;
					}
				}
				result = flag;
			}
			else
			{
				result = !flag;
			}
			return result;
		}

		// Token: 0x0401EC4B RID: 126027
		private readonly Dictionary<int, List<int>> ModeCache = new Dictionary<int, List<int>>();
	}
}
