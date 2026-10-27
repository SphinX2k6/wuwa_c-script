using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Camera;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C56 RID: 27734
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelConditionCheckCameraMode : LevelConditionBase
	{
		// Token: 0x06044518 RID: 279832 RVA: 0x010D6E04 File Offset: 0x010D5004
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

		// Token: 0x06044519 RID: 279833 RVA: 0x010D6E5C File Offset: 0x010D505C
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

		// Token: 0x0604451A RID: 279834 RVA: 0x010D6EA8 File Offset: 0x010D50A8
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

		// Token: 0x040239A9 RID: 145833
		private readonly Dictionary<int, List<int>> ModeCache = new Dictionary<int, List<int>>();
	}
}
