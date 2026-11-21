using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Module.Area;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Typing;
using UnrealEngine;

namespace CSharpScript.Game.Module.PerformanceExceed
{
	// Token: 0x0200432C RID: 17196
	[NullableContext(1)]
	[Nullable(0)]
	public class PerfExceedReporter
	{
		// Token: 0x0602B6C9 RID: 177865 RVA: 0x00C34C50 File Offset: 0x00C32E50
		public unsafe bool Report(PerfExceedSubMetric subMetric, PerfExceedPayload payload, double durationMs)
		{
			if (!UKuroAnalytics.HasInstanceInitialized(0))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LogReport;
				ELogAuthor author = ELogAuthor.WLJ;
				string message = "性能超标上报跳过：KuroData实例未初始化";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("eventName", payload.EventName);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			string text = Json.Stringify(PerfExceedReporter.AssembleData(subMetric, payload, durationMs), null);
			if (string.IsNullOrEmpty(text))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.LogReport;
				ELogAuthor author2 = ELogAuthor.WLJ;
				string message2 = "性能超标上报序列化失败";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("eventName", payload.EventName);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
			bool flag = FKuroAnalyticsForCSharp.Track(payload.EventName, text, 0);
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.LogReport;
			ELogAuthor author3 = ELogAuthor.WLJ;
			string message3 = "性能超标上报";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("eventName", payload.EventName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("result", flag);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("json", (text.Length > 2000) ? (text.Substring(0, 2000) + "...") : text);
			instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return flag;
		}

		// Token: 0x0602B6CA RID: 177866 RVA: 0x00C34D8C File Offset: 0x00C32F8C
		public static PerfExceedDataBase AssembleData(PerfExceedSubMetric subMetric, PerfExceedPayload payload, double durationMs)
		{
			PerfExceedDataBase perfExceedDataBase = PerfExceedReporter.CreateData(subMetric);
			PerfExceedReporter.FillCommonFields(perfExceedDataBase, durationMs);
			foreach (KeyValuePair<string, object> keyValuePair in payload.Fields)
			{
				PerfExceedReporter.FillField(perfExceedDataBase, keyValuePair.Key, keyValuePair.Value);
			}
			return perfExceedDataBase;
		}

		// Token: 0x0602B6CB RID: 177867 RVA: 0x00C34DFC File Offset: 0x00C32FFC
		public static PerfExceedDataBase CreateData(PerfExceedSubMetric subMetric)
		{
			PerfExceedDataBase result;
			switch (subMetric)
			{
			case PerfExceedSubMetric.Particles:
				result = new PerfExceedParticlesData();
				break;
			case PerfExceedSubMetric.Emitters:
				result = new PerfExceedEmittersData();
				break;
			case PerfExceedSubMetric.Active:
				result = new PerfExceedActiveData();
				break;
			case PerfExceedSubMetric.Scalability:
				result = new PerfExceedScalabilityData();
				break;
			default:
				result = new PerfExceedParticlesData();
				break;
			}
			return result;
		}

		// Token: 0x0602B6CC RID: 177868 RVA: 0x00C34E48 File Offset: 0x00C33048
		private static void FillCommonFields(PerfExceedDataBase data, double durationMs)
		{
			string s_metric;
			if (!(data is PerfExceedParticlesData))
			{
				if (!(data is PerfExceedEmittersData))
				{
					if (!(data is PerfExceedActiveData))
					{
						if (!(data is PerfExceedScalabilityData))
						{
							s_metric = "niagara_unknown";
						}
						else
						{
							s_metric = "niagara_scalability";
						}
					}
					else
					{
						s_metric = "niagara_active";
					}
				}
				else
				{
					s_metric = "niagara_emitters";
				}
			}
			else
			{
				s_metric = "niagara_particles";
			}
			data.s_metric = s_metric;
			int? num;
			data.s_player_id = (((PlayerInfoModel.Instance.GetId() != null) ? num.GetValueOrDefault().ToString() : null) ?? "0");
			data.s_unique_id = (PlayerInfoModel.Instance.GetAccountName(true) ?? "");
			data.s_world_level = WorldLevelModel.Instance.CurWorldLevel.ToString();
			data.s_player_level = "";
			data.s_region = "";
			data.s_client_platform = KuroApplication.IniPlatformName();
			data.s_net_status = PlatformModel.Instance.GetNetStatus().ToString();
			data.s_client_version = BaseConfigController.Instance.GetVersionString();
			data.s_platform = LoginModel.Instance.Platform;
			data.s_device_id = PerfExceedReporter.GetDeviceId();
			data.i_duration_ms = (long)durationMs;
			data.s_report_time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			data.i_role_id = PlayerInfoModel.Instance.GetPlayerRoleId();
			PerfExceedReporter.FillMapFields(data);
			PerfExceedReporter.FillPositionFields(data);
			PerfExceedReporter.FillCameraFields(data);
		}

		// Token: 0x0602B6CD RID: 177869 RVA: 0x00C34FB8 File Offset: 0x00C331B8
		private static string GetDeviceId()
		{
			try
			{
				if (KuroSdkController.Instance.CanUseSdk())
				{
					return UKuroSDKManager.GetBasicInfo().DeviceId ?? "";
				}
			}
			catch
			{
			}
			return "";
		}

		// Token: 0x0602B6CE RID: 177870 RVA: 0x00C35004 File Offset: 0x00C33204
		private static void FillMapFields(PerfExceedDataBase data)
		{
			string mapPath = GameModeModel.Instance.MapPath;
			data.s_map_id = (mapPath ?? "");
			data.s_map_name = PerfExceedReporter.ResolveMapName(mapPath);
			data.s_area_name = "";
			try
			{
				data.s_area_name = (AreaModel.Instance.AreaName ?? "");
			}
			catch
			{
			}
		}

		// Token: 0x0602B6CF RID: 177871 RVA: 0x00C35074 File Offset: 0x00C33274
		public static string ResolveMapName([Nullable(2)] string mapPath)
		{
			if (!string.IsNullOrEmpty(mapPath))
			{
				string[] array = mapPath.Split(new char[]
				{
					'\\',
					'/'
				}, StringSplitOptions.RemoveEmptyEntries);
				if (array.Length != 0)
				{
					string[] array2 = array;
					return Path.GetFileNameWithoutExtension(array2[array2.Length - 1]);
				}
			}
			return "";
		}

		// Token: 0x0602B6D0 RID: 177872 RVA: 0x00C350B8 File Offset: 0x00C332B8
		private static void FillCameraFields(PerfExceedDataBase data)
		{
			try
			{
				Rotator cameraRotation = CameraController.Instance.GetCameraRotation(new Rotator(), "MainCamera");
				data.f_cam_yaw = cameraRotation.Yaw;
				data.f_cam_pitch = cameraRotation.Pitch;
			}
			catch
			{
			}
		}

		// Token: 0x0602B6D1 RID: 177873 RVA: 0x00C35108 File Offset: 0x00C33308
		private static void FillPositionFields(PerfExceedDataBase data)
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			Vector vector;
			if (baseCharacter == null)
			{
				vector = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
				vector = ((characterActorComponent != null) ? characterActorComponent.ActorLocationProxy : null);
			}
			Vector vector2 = vector;
			if (vector2 != null)
			{
				data.f_pos_x = (float)vector2.X;
				data.f_pos_y = (float)vector2.Y;
				data.f_pos_z = (float)vector2.Z;
			}
		}

		// Token: 0x0602B6D2 RID: 177874 RVA: 0x00C35160 File Offset: 0x00C33360
		public static void FillField(PerfExceedDataBase data, string key, object value)
		{
			if (key != null)
			{
				switch (key.Length)
				{
				case 8:
					if (key == "s_metric")
					{
						data.s_metric = (value.ToString() ?? "");
						return;
					}
					break;
				case 11:
					if (key == "i_threshold")
					{
						data.i_threshold = PerfExceedReporter.ToInt(value);
						return;
					}
					break;
				case 12:
					switch (key[7])
					{
					case '_':
						if (key == "s_top10_json")
						{
							data.s_top10_json = (value.ToString() ?? "");
							return;
						}
						break;
					case 'a':
						if (key == "s_top1_asset")
						{
							data.s_top1_asset = (value.ToString() ?? "");
							return;
						}
						break;
					case 'c':
						if (key == "i_top1_count")
						{
							data.i_top1_count = PerfExceedReporter.ToInt(value);
							return;
						}
						break;
					}
					break;
				case 14:
					if (key == "i_total_active")
					{
						data.i_total_active = PerfExceedReporter.ToInt(value);
						return;
					}
					break;
				case 16:
					if (key == "i_total_emitters")
					{
						data.i_total_emitters = PerfExceedReporter.ToInt(value);
						return;
					}
					break;
				case 17:
					if (key == "i_total_particles")
					{
						data.i_total_particles = PerfExceedReporter.ToInt(value);
						return;
					}
					break;
				case 19:
					if (key == "i_total_scalability")
					{
						data.i_total_scalability = PerfExceedReporter.ToInt(value);
						return;
					}
					break;
				}
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.LogReport;
			ELogAuthor author = ELogAuthor.WLJ;
			string message = "性能超标上报未知字段忽略";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("field", key);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0602B6D3 RID: 177875 RVA: 0x00C35358 File Offset: 0x00C33558
		private static int ToInt(object value)
		{
			if (value is int)
			{
				return (int)value;
			}
			int result;
			if (!int.TryParse(value.ToString(), out result))
			{
				return 0;
			}
			return result;
		}
	}
}
