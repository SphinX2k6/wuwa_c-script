using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Manufacture.Compose
{
	// Token: 0x0200565B RID: 22107
	[NullableContext(1)]
	[Nullable(0)]
	public class ComposeDefine : IStaticVariableResetter
	{
		// Token: 0x17008742 RID: 34626
		// (get) Token: 0x06038384 RID: 230276 RVA: 0x00D52BC3 File Offset: 0x00D50DC3
		public static Dictionary<EComposeListType, string> ComposeTypeSprite
		{
			get
			{
				return ComposeDefine._composeTypeSprite;
			}
		}

		// Token: 0x17008743 RID: 34627
		// (get) Token: 0x06038385 RID: 230277 RVA: 0x00D52BCA File Offset: 0x00D50DCA
		public static Dictionary<EComposeListType, string> ComposeTypeName
		{
			get
			{
				return ComposeDefine._composeTypeName;
			}
		}

		// Token: 0x06038386 RID: 230278 RVA: 0x00D52BD1 File Offset: 0x00D50DD1
		static ComposeDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ComposeDefine.CreateStaticDefaultValue), new Action(ComposeDefine.ResetStaticDefaultValue));
		}

		// Token: 0x06038387 RID: 230279 RVA: 0x00D52BF0 File Offset: 0x00D50DF0
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

		// Token: 0x06038388 RID: 230280 RVA: 0x00D52C89 File Offset: 0x00D50E89
		public static void ResetStaticDefaultValue()
		{
			ComposeDefine._composeTypeSprite = null;
			ComposeDefine._composeTypeName = null;
		}

		// Token: 0x06038389 RID: 230281 RVA: 0x00D52C97 File Offset: 0x00D50E97
		public static bool IsPurificationLikeType(EComposeListType type)
		{
			return type == EComposeListType.Purification || type == EComposeListType.Collect;
		}

		// Token: 0x0401D911 RID: 121105
		public const string COMPOSE_TYPE_TEXTURE_PATH_KEY = "T_ComposeType";

		// Token: 0x0401D912 RID: 121106
		public const int COMPOSITE_ENTER_SEQUENCE_TIME_LENGTH = 3000;

		// Token: 0x0401D913 RID: 121107
		public const int COMPOSITE_WORKING_SEQUENCE_TIME_LENGTH = 2000;

		// Token: 0x0401D914 RID: 121108
		public const int COMPOSITE_FAIL_SEQUENCE_TIME_LENGTH = 2000;

		// Token: 0x0401D915 RID: 121109
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<EComposeListType, string> _composeTypeSprite;

		// Token: 0x0401D916 RID: 121110
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<EComposeListType, string> _composeTypeName;

		// Token: 0x0401D917 RID: 121111
		public const int EXCHANGE_COUNT = 2;

		// Token: 0x0401D918 RID: 121112
		public const string EXCHANGE_MATERIAL_NOT_ENOUGHT_TEXT_PATTERN = "<color=#dc0300>{0}</color>";

		// Token: 0x0401D919 RID: 121113
		public const string EXCHANGE_MATERIAL_ENOUGHT_TEXT_PATTERN = "<color=#ffffff>{0}</color>";

		// Token: 0x0401D91A RID: 121114
		public const string EXCHANGE_MATERIAL_NOT_ENOUGHT_TEXT_PATTERN_B = "<color=#c25757>{0}</color>";

		// Token: 0x0401D91B RID: 121115
		public const string EXCHANGE_MATERIAL_ENOUGHT_TEXT_PATTERN_B = "<color=#36cd33>{0}</color>";
	}
}
