using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02005586 RID: 21894
	[NullableContext(1)]
	[Nullable(0)]
	public class QuestMarkCreateInfo : DynamicMarkCreateInfo
	{
		// Token: 0x1700865B RID: 34395
		// (get) Token: 0x06037CC8 RID: 228552 RVA: 0x00D39575 File Offset: 0x00D37775
		public long TreeId
		{
			get
			{
				return ((QuestMarkCreateParams)this.CreateParams).TreeId;
			}
		}

		// Token: 0x1700865C RID: 34396
		// (get) Token: 0x06037CC9 RID: 228553 RVA: 0x00D39587 File Offset: 0x00D37787
		public int NodeId
		{
			get
			{
				return ((QuestMarkCreateParams)this.CreateParams).NodeId;
			}
		}

		// Token: 0x1700865D RID: 34397
		// (get) Token: 0x06037CCA RID: 228554 RVA: 0x00D39599 File Offset: 0x00D37799
		public bool IsBoundToParentQuest
		{
			get
			{
				return ((QuestMarkCreateParams)this.CreateParams).IsBoundToParentQuest.GetValueOrDefault();
			}
		}

		// Token: 0x06037CCB RID: 228555 RVA: 0x00D395B0 File Offset: 0x00D377B0
		public QuestMarkCreateInfo(QuestMarkCreateParams @params) : base(QuestMarkCreateInfo.PreprocessParams(@params))
		{
		}

		// Token: 0x06037CCC RID: 228556 RVA: 0x00D395BE File Offset: 0x00D377BE
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
