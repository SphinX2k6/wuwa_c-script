using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Manufacture.Compose
{
	// Token: 0x02004631 RID: 17969
	[NullableContext(1)]
	[Nullable(0)]
	public class ComposeDefine : IStaticVariableResetter
	{
		// Token: 0x17005B09 RID: 23305
		// (get) Token: 0x0602D282 RID: 184962 RVA: 0x00CA0AFB File Offset: 0x00C9ECFB
		public static Dictionary<EComposeListType, string> ComposeTypeSprite
		{
			get
			{
				return ComposeDefine._composeTypeSprite;
			}
		}

		// Token: 0x17005B0A RID: 23306
		// (get) Token: 0x0602D283 RID: 184963 RVA: 0x00CA0B02 File Offset: 0x00C9ED02
		public static Dictionary<EComposeListType, string> ComposeTypeName
		{
			get
			{
				return ComposeDefine._composeTypeName;
			}
		}

		// Token: 0x0602D284 RID: 184964 RVA: 0x00CA0B09 File Offset: 0x00C9ED09
		static ComposeDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ComposeDefine.CreateStaticDefaultValue), new Action(ComposeDefine.ResetStaticDefaultValue));
		}

		// Token: 0x0602D285 RID: 184965 RVA: 0x00CA0B28 File Offset: 0x00C9ED28
		public static void CreateStaticDefaultValue()
		{
			ComposeDefine._composeTypeSprite = new Dictionary<EComposeListType, string>
			{
				{
					EComposeListType.Purification,
					"SP_Purification"
				},
				{
					EComposeListType.Exchange,
					"SP_Exchange"
				},
				{
					EComposeListType.ReagentProduction,
					"SP_ReagentProduction"
				},
				{
					EComposeListType.Structure,
					"SP_Structure"
				},
				{
					EComposeListType.Collect,
					"SP_Collect"
				}
			};
			ComposeDefine._composeTypeName = new Dictionary<EComposeListType, string>
			{
				{
					EComposeListType.Purification,
					"Text_Purification_Text"
				},
				{
					EComposeListType.Exchange,
					"Text_Exchange_Text"
				},
				{
					EComposeListType.ReagentProduction,
					"Text_ReagentProduction_Text"
				},
				{
					EComposeListType.Structure,
					"Text_Structure_Text"
				},
				{
					EComposeListType.Collect,
					"GatherCraft_Title"
				}
			};
		}

		// Token: 0x0602D286 RID: 184966 RVA: 0x00CA0BC1 File Offset: 0x00C9EDC1
		public static void ResetStaticDefaultValue()
		{
			ComposeDefine._composeTypeSprite = null;
			ComposeDefine._composeTypeName = null;
		}

		// Token: 0x0602D287 RID: 184967 RVA: 0x00CA0BCF File Offset: 0x00C9EDCF
		public static bool IsPurificationLikeType(EComposeListType type)
		{
			return type == EComposeListType.Purification || type == EComposeListType.Collect;
		}

		// Token: 0x0401839C RID: 99228
		public const string COMPOSE_TYPE_TEXTURE_PATH_KEY = "T_ComposeType";

		// Token: 0x0401839D RID: 99229
		public const int COMPOSITE_ENTER_SEQUENCE_TIME_LENGTH = 3000;

		// Token: 0x0401839E RID: 99230
		public const int COMPOSITE_WORKING_SEQUENCE_TIME_LENGTH = 2000;

		// Token: 0x0401839F RID: 99231
		public const int COMPOSITE_FAIL_SEQUENCE_TIME_LENGTH = 2000;

		// Token: 0x040183A0 RID: 99232
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<EComposeListType, string> _composeTypeSprite;

		// Token: 0x040183A1 RID: 99233
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<EComposeListType, string> _composeTypeName;

		// Token: 0x040183A2 RID: 99234
		public const int EXCHANGE_COUNT = 2;

		// Token: 0x040183A3 RID: 99235
		public const string EXCHANGE_MATERIAL_NOT_ENOUGHT_TEXT_PATTERN = "<color=#dc0300>{0}</color>";

		// Token: 0x040183A4 RID: 99236
		public const string EXCHANGE_MATERIAL_ENOUGHT_TEXT_PATTERN = "<color=#ffffff>{0}</color>";

		// Token: 0x040183A5 RID: 99237
		public const string EXCHANGE_MATERIAL_NOT_ENOUGHT_TEXT_PATTERN_B = "<color=#c25757>{0}</color>";

		// Token: 0x040183A6 RID: 99238
		public const string EXCHANGE_MATERIAL_ENOUGHT_TEXT_PATTERN_B = "<color=#36cd33>{0}</color>";
	}
}
