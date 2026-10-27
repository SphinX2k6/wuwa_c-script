using System;

namespace Aki.TDConfigMgr.EditorObject
{
	// Token: 0x0200000E RID: 14
	public static class TEditorObjectTypeExtensions
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00013CDC File Offset: 0x00011EDC
		public static string ToEnumString(this TEditorObjectType value)
		{
			string result;
			switch (value)
			{
			case TEditorObjectType.BehaviorTreeFragment:
				result = "BehaviorTreeFragment";
				break;
			case TEditorObjectType.CommonBt:
				result = "CommonBt";
				break;
			case TEditorObjectType.Entity:
				result = "Entity";
				break;
			case TEditorObjectType.EntityTemplate:
				result = "EntityTemplate";
				break;
			case TEditorObjectType.Flow:
				result = "Flow";
				break;
			case TEditorObjectType.FlowState:
				result = "FlowState";
				break;
			case TEditorObjectType.LevelPlay:
				result = "LevelPlay";
				break;
			case TEditorObjectType.Prefab:
				result = "Prefab";
				break;
			case TEditorObjectType.Quest:
				result = "Quest";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00013D6C File Offset: 0x00011F6C
		public static TEditorObjectType FromString(string name)
		{
			TEditorObjectType result;
			if (!TEditorObjectTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 TEditorObjectType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00013D98 File Offset: 0x00011F98
		public static bool TryFromString(string name, out TEditorObjectType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = TEditorObjectType.BehaviorTreeFragment;
				return false;
			}
			if (name != null)
			{
				int length = name.Length;
				switch (length)
				{
				case 4:
					if (name == "Flow")
					{
						value = TEditorObjectType.Flow;
						return true;
					}
					break;
				case 5:
					if (name == "Quest")
					{
						value = TEditorObjectType.Quest;
						return true;
					}
					break;
				case 6:
				{
					char c = name[0];
					if (c != 'E')
					{
						if (c == 'P')
						{
							if (name == "Prefab")
							{
								value = TEditorObjectType.Prefab;
								return true;
							}
						}
					}
					else if (name == "Entity")
					{
						value = TEditorObjectType.Entity;
						return true;
					}
					break;
				}
				case 7:
				case 10:
				case 11:
				case 12:
				case 13:
					break;
				case 8:
					if (name == "CommonBt")
					{
						value = TEditorObjectType.CommonBt;
						return true;
					}
					break;
				case 9:
				{
					char c = name[0];
					if (c != 'F')
					{
						if (c == 'L')
						{
							if (name == "LevelPlay")
							{
								value = TEditorObjectType.LevelPlay;
								return true;
							}
						}
					}
					else if (name == "FlowState")
					{
						value = TEditorObjectType.FlowState;
						return true;
					}
					break;
				}
				case 14:
					if (name == "EntityTemplate")
					{
						value = TEditorObjectType.EntityTemplate;
						return true;
					}
					break;
				default:
					if (length == 20)
					{
						if (name == "BehaviorTreeFragment")
						{
							value = TEditorObjectType.BehaviorTreeFragment;
							return true;
						}
					}
					break;
				}
			}
			value = TEditorObjectType.BehaviorTreeFragment;
			return false;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00013EF0 File Offset: 0x000120F0
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"BehaviorTreeFragment",
				"CommonBt",
				"Entity",
				"EntityTemplate",
				"Flow",
				"FlowState",
				"LevelPlay",
				"Prefab",
				"Quest"
			};
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00013F4C File Offset: 0x0001214C
		public static TEditorObjectType[] GetValues()
		{
			return new TEditorObjectType[]
			{
				TEditorObjectType.BehaviorTreeFragment,
				TEditorObjectType.CommonBt,
				TEditorObjectType.Entity,
				TEditorObjectType.EntityTemplate,
				TEditorObjectType.Flow,
				TEditorObjectType.FlowState,
				TEditorObjectType.LevelPlay,
				TEditorObjectType.Prefab,
				TEditorObjectType.Quest
			};
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00013F60 File Offset: 0x00012160
		public static string[] GetNames()
		{
			return new string[]
			{
				"BehaviorTreeFragment",
				"CommonBt",
				"Entity",
				"EntityTemplate",
				"Flow",
				"FlowState",
				"LevelPlay",
				"Prefab",
				"Quest"
			};
		}
	}
}
