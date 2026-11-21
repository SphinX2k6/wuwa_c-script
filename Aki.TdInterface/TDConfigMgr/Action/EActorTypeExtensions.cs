using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024FE RID: 9470
	public static class EActorTypeExtensions
	{
		// Token: 0x0600CDD1 RID: 52689 RVA: 0x001DD158 File Offset: 0x001DB358
		public static string ToEnumString(this EActorType value)
		{
			string result;
			switch (value)
			{
			case EActorType.MeshActor:
				result = "MeshActor";
				break;
			case EActorType.SoundActor:
				result = "SoundActor";
				break;
			case EActorType.EffectActor:
				result = "EffectActor";
				break;
			case EActorType.TriggerVolume:
				result = "TriggerVolume";
				break;
			case EActorType.WorldPartitionTriggerVolumeWrapper:
				result = "WorldPartitionTriggerVolumeWrapper";
				break;
			case EActorType.LightsGroup:
				result = "LightsGroup";
				break;
			case EActorType.PPVolume:
				result = "PPVolume";
				break;
			case EActorType.CullDistanceVolume:
				result = "CullDistanceVolume";
				break;
			case EActorType.Skybox:
				result = "Skybox";
				break;
			case EActorType.FloatingActor:
				result = "FloatingActor";
				break;
			case EActorType.GpuNpc:
				result = "GpuNpc";
				break;
			case EActorType.ToonDepth:
				result = "ToonDepth";
				break;
			case EActorType.DecalActor:
				result = "DecalActor";
				break;
			case EActorType.NvClothPlacement:
				result = "NvClothPlacement";
				break;
			case EActorType.PhysicalActor:
				result = "PhysicalActor";
				break;
			case EActorType.SmartLightActor:
				result = "SmartLightActor";
				break;
			case EActorType.MediaPlayer:
				result = "MediaPlayer";
				break;
			case EActorType.KuroAttachGroupActor:
				result = "KuroAttachGroupActor";
				break;
			case EActorType.LoopTeleportVolume:
				result = "LoopTeleportVolume";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600CDD2 RID: 52690 RVA: 0x001DD270 File Offset: 0x001DB470
		public static EActorType FromString(string name)
		{
			EActorType result;
			if (!EActorTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EActorType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CDD3 RID: 52691 RVA: 0x001DD29C File Offset: 0x001DB49C
		public static bool TryFromString(string name, out EActorType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EActorType.MeshActor;
				return false;
			}
			if (name != null)
			{
				int length = name.Length;
				switch (length)
				{
				case 6:
				{
					char c = name[0];
					if (c != 'G')
					{
						if (c == 'S')
						{
							if (name == "Skybox")
							{
								value = EActorType.Skybox;
								return true;
							}
						}
					}
					else if (name == "GpuNpc")
					{
						value = EActorType.GpuNpc;
						return true;
					}
					break;
				}
				case 7:
				case 12:
				case 14:
				case 17:
				case 19:
					break;
				case 8:
					if (name == "PPVolume")
					{
						value = EActorType.PPVolume;
						return true;
					}
					break;
				case 9:
				{
					char c = name[0];
					if (c != 'M')
					{
						if (c == 'T')
						{
							if (name == "ToonDepth")
							{
								value = EActorType.ToonDepth;
								return true;
							}
						}
					}
					else if (name == "MeshActor")
					{
						value = EActorType.MeshActor;
						return true;
					}
					break;
				}
				case 10:
				{
					char c = name[0];
					if (c != 'D')
					{
						if (c == 'S')
						{
							if (name == "SoundActor")
							{
								value = EActorType.SoundActor;
								return true;
							}
						}
					}
					else if (name == "DecalActor")
					{
						value = EActorType.DecalActor;
						return true;
					}
					break;
				}
				case 11:
				{
					char c = name[0];
					if (c != 'E')
					{
						if (c != 'L')
						{
							if (c == 'M')
							{
								if (name == "MediaPlayer")
								{
									value = EActorType.MediaPlayer;
									return true;
								}
							}
						}
						else if (name == "LightsGroup")
						{
							value = EActorType.LightsGroup;
							return true;
						}
					}
					else if (name == "EffectActor")
					{
						value = EActorType.EffectActor;
						return true;
					}
					break;
				}
				case 13:
				{
					char c = name[0];
					if (c != 'F')
					{
						if (c != 'P')
						{
							if (c == 'T')
							{
								if (name == "TriggerVolume")
								{
									value = EActorType.TriggerVolume;
									return true;
								}
							}
						}
						else if (name == "PhysicalActor")
						{
							value = EActorType.PhysicalActor;
							return true;
						}
					}
					else if (name == "FloatingActor")
					{
						value = EActorType.FloatingActor;
						return true;
					}
					break;
				}
				case 15:
					if (name == "SmartLightActor")
					{
						value = EActorType.SmartLightActor;
						return true;
					}
					break;
				case 16:
					if (name == "NvClothPlacement")
					{
						value = EActorType.NvClothPlacement;
						return true;
					}
					break;
				case 18:
				{
					char c = name[0];
					if (c != 'C')
					{
						if (c == 'L')
						{
							if (name == "LoopTeleportVolume")
							{
								value = EActorType.LoopTeleportVolume;
								return true;
							}
						}
					}
					else if (name == "CullDistanceVolume")
					{
						value = EActorType.CullDistanceVolume;
						return true;
					}
					break;
				}
				case 20:
					if (name == "KuroAttachGroupActor")
					{
						value = EActorType.KuroAttachGroupActor;
						return true;
					}
					break;
				default:
					if (length == 34)
					{
						if (name == "WorldPartitionTriggerVolumeWrapper")
						{
							value = EActorType.WorldPartitionTriggerVolumeWrapper;
							return true;
						}
					}
					break;
				}
			}
			value = EActorType.MeshActor;
			return false;
		}

		// Token: 0x0600CDD4 RID: 52692 RVA: 0x001DD5BC File Offset: 0x001DB7BC
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"MeshActor",
				"SoundActor",
				"EffectActor",
				"TriggerVolume",
				"WorldPartitionTriggerVolumeWrapper",
				"LightsGroup",
				"PPVolume",
				"CullDistanceVolume",
				"Skybox",
				"FloatingActor",
				"GpuNpc",
				"ToonDepth",
				"DecalActor",
				"NvClothPlacement",
				"PhysicalActor",
				"SmartLightActor",
				"MediaPlayer",
				"KuroAttachGroupActor",
				"LoopTeleportVolume"
			};
		}

		// Token: 0x0600CDD5 RID: 52693 RVA: 0x001DD672 File Offset: 0x001DB872
		public static EActorType[] GetValues()
		{
			return new EActorType[]
			{
				EActorType.MeshActor,
				EActorType.SoundActor,
				EActorType.EffectActor,
				EActorType.TriggerVolume,
				EActorType.WorldPartitionTriggerVolumeWrapper,
				EActorType.LightsGroup,
				EActorType.PPVolume,
				EActorType.CullDistanceVolume,
				EActorType.Skybox,
				EActorType.FloatingActor,
				EActorType.GpuNpc,
				EActorType.ToonDepth,
				EActorType.DecalActor,
				EActorType.NvClothPlacement,
				EActorType.PhysicalActor,
				EActorType.SmartLightActor,
				EActorType.MediaPlayer,
				EActorType.KuroAttachGroupActor,
				EActorType.LoopTeleportVolume
			};
		}

		// Token: 0x0600CDD6 RID: 52694 RVA: 0x001DD688 File Offset: 0x001DB888
		public static string[] GetNames()
		{
			return new string[]
			{
				"MeshActor",
				"SoundActor",
				"EffectActor",
				"TriggerVolume",
				"WorldPartitionTriggerVolumeWrapper",
				"LightsGroup",
				"PPVolume",
				"CullDistanceVolume",
				"Skybox",
				"FloatingActor",
				"GpuNpc",
				"ToonDepth",
				"DecalActor",
				"NvClothPlacement",
				"PhysicalActor",
				"SmartLightActor",
				"MediaPlayer",
				"KuroAttachGroupActor",
				"LoopTeleportVolume"
			};
		}
	}
}
