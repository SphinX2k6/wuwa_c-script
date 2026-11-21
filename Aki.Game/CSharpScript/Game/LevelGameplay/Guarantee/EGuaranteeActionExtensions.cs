using System;

namespace CSharpScript.Game.LevelGamePlay.Guarantee
{
	// Token: 0x02005F8B RID: 24459
	public static class EGuaranteeActionExtensions
	{
		// Token: 0x0603ACB8 RID: 240824 RVA: 0x0109F7E8 File Offset: 0x0109D9E8
		public static string ToEnumString(this EGuaranteeAction value)
		{
			string result;
			switch (value)
			{
			case EGuaranteeAction.EnablePlayerMoveControl:
				result = "EnablePlayerMoveControl";
				break;
			case EGuaranteeAction.ExitOrbitalCamera:
				result = "ExitOrbitalCamera";
				break;
			case EGuaranteeAction.RestorePlayerCameraAdjustment:
				result = "RestorePlayerCameraAdjustment";
				break;
			case EGuaranteeAction.UnLimitPlayerOperation:
				result = "UnLimitPlayerOperation";
				break;
			case EGuaranteeAction.ActionBlackScreenFadeOut:
				result = "ActionBlackScreenFadeOut";
				break;
			case EGuaranteeAction.DisableSplineMoveModel:
				result = "DisableSplineMoveModel";
				break;
			case EGuaranteeAction.StopEffect:
				result = "StopEffect";
				break;
			case EGuaranteeAction.Preload:
				result = "Preload";
				break;
			case EGuaranteeAction.DisableKey4Func:
				result = "DisableKey4Func";
				break;
			case EGuaranteeAction.ActionExitMovieMode:
				result = "ActionExitMovieMode";
				break;
			case EGuaranteeAction.StopGamepadShake:
				result = "StopGamepadShake";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0603ACB9 RID: 240825 RVA: 0x0109F890 File Offset: 0x0109DA90
		public static EGuaranteeAction FromString(string name)
		{
			EGuaranteeAction result;
			if (!EGuaranteeActionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EGuaranteeAction 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0603ACBA RID: 240826 RVA: 0x0109F8BC File Offset: 0x0109DABC
		public static bool TryFromString(string name, out EGuaranteeAction value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EGuaranteeAction.EnablePlayerMoveControl;
				return false;
			}
			if (name != null)
			{
				int length = name.Length;
				if (length != 7)
				{
					switch (length)
					{
					case 10:
						if (name == "StopEffect")
						{
							value = EGuaranteeAction.StopEffect;
							return true;
						}
						break;
					case 11:
					case 12:
					case 13:
					case 14:
					case 18:
					case 20:
					case 21:
						break;
					case 15:
						if (name == "DisableKey4Func")
						{
							value = EGuaranteeAction.DisableKey4Func;
							return true;
						}
						break;
					case 16:
						if (name == "StopGamepadShake")
						{
							value = EGuaranteeAction.StopGamepadShake;
							return true;
						}
						break;
					case 17:
						if (name == "ExitOrbitalCamera")
						{
							value = EGuaranteeAction.ExitOrbitalCamera;
							return true;
						}
						break;
					case 19:
						if (name == "ActionExitMovieMode")
						{
							value = EGuaranteeAction.ActionExitMovieMode;
							return true;
						}
						break;
					case 22:
					{
						char c = name[0];
						if (c != 'D')
						{
							if (c == 'U')
							{
								if (name == "UnLimitPlayerOperation")
								{
									value = EGuaranteeAction.UnLimitPlayerOperation;
									return true;
								}
							}
						}
						else if (name == "DisableSplineMoveModel")
						{
							value = EGuaranteeAction.DisableSplineMoveModel;
							return true;
						}
						break;
					}
					case 23:
						if (name == "EnablePlayerMoveControl")
						{
							value = EGuaranteeAction.EnablePlayerMoveControl;
							return true;
						}
						break;
					case 24:
						if (name == "ActionBlackScreenFadeOut")
						{
							value = EGuaranteeAction.ActionBlackScreenFadeOut;
							return true;
						}
						break;
					default:
						if (length == 29)
						{
							if (name == "RestorePlayerCameraAdjustment")
							{
								value = EGuaranteeAction.RestorePlayerCameraAdjustment;
								return true;
							}
						}
						break;
					}
				}
				else if (name == "Preload")
				{
					value = EGuaranteeAction.Preload;
					return true;
				}
			}
			value = EGuaranteeAction.EnablePlayerMoveControl;
			return false;
		}

		// Token: 0x0603ACBB RID: 240827 RVA: 0x0109FA50 File Offset: 0x0109DC50
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"EnablePlayerMoveControl",
				"ExitOrbitalCamera",
				"RestorePlayerCameraAdjustment",
				"UnLimitPlayerOperation",
				"ActionBlackScreenFadeOut",
				"DisableSplineMoveModel",
				"StopEffect",
				"Preload",
				"DisableKey4Func",
				"ActionExitMovieMode",
				"StopGamepadShake"
			};
		}

		// Token: 0x0603ACBC RID: 240828 RVA: 0x0109FABE File Offset: 0x0109DCBE
		public static EGuaranteeAction[] GetValues()
		{
			return new EGuaranteeAction[]
			{
				EGuaranteeAction.EnablePlayerMoveControl,
				EGuaranteeAction.ExitOrbitalCamera,
				EGuaranteeAction.RestorePlayerCameraAdjustment,
				EGuaranteeAction.UnLimitPlayerOperation,
				EGuaranteeAction.ActionBlackScreenFadeOut,
				EGuaranteeAction.DisableSplineMoveModel,
				EGuaranteeAction.StopEffect,
				EGuaranteeAction.Preload,
				EGuaranteeAction.DisableKey4Func,
				EGuaranteeAction.ActionExitMovieMode,
				EGuaranteeAction.StopGamepadShake
			};
		}

		// Token: 0x0603ACBD RID: 240829 RVA: 0x0109FAD4 File Offset: 0x0109DCD4
		public static string[] GetNames()
		{
			return new string[]
			{
				"EnablePlayerMoveControl",
				"ExitOrbitalCamera",
				"RestorePlayerCameraAdjustment",
				"UnLimitPlayerOperation",
				"ActionBlackScreenFadeOut",
				"DisableSplineMoveModel",
				"StopEffect",
				"Preload",
				"DisableKey4Func",
				"ActionExitMovieMode",
				"StopGamepadShake"
			};
		}
	}
}
