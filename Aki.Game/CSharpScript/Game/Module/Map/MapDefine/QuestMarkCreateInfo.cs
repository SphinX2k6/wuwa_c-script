using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x0200455C RID: 17756
	[NullableContext(1)]
	[Nullable(0)]
	public class QuestMarkCreateInfo : DynamicMarkCreateInfo
	{
		// Token: 0x17005A22 RID: 23074
		// (get) Token: 0x0602CBC6 RID: 183238 RVA: 0x00C8724D File Offset: 0x00C8544D
		public long TreeId
		{
			get
			{
				return ((QuestMarkCreateParams)this.CreateParams).TreeId;
			}
		}

		// Token: 0x17005A23 RID: 23075
		// (get) Token: 0x0602CBC7 RID: 183239 RVA: 0x00C8725F File Offset: 0x00C8545F
		public int NodeId
		{
			get
			{
				return ((QuestMarkCreateParams)this.CreateParams).NodeId;
			}
		}

		// Token: 0x17005A24 RID: 23076
		// (get) Token: 0x0602CBC8 RID: 183240 RVA: 0x00C87271 File Offset: 0x00C85471
		public bool IsBoundToParentQuest
		{
			get
			{
				return ((QuestMarkCreateParams)this.CreateParams).IsBoundToParentQuest.GetValueOrDefault();
			}
		}

		// Token: 0x0602CBC9 RID: 183241 RVA: 0x00C87288 File Offset: 0x00C85488
		public QuestMarkCreateInfo(QuestMarkCreateParams @params) : base(QuestMarkCreateInfo.PreprocessParams(@params))
		{
		}

		// Token: 0x0602CBCA RID: 183242 RVA: 0x00C87296 File Offset: 0x00C85496
		private static QuestMarkCreateParams PreprocessParams(QuestMarkCreateParams @params)
		{
			if (@params.MapAndDungeonInfo != null)
			{
				@params.MapAndDungeonInfo.MapConfigId = @params.MapAndDungeonInfo.DungeonId;
			}
			return @params;
		}
	}
}
