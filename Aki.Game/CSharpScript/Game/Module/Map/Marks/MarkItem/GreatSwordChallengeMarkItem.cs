using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020054E7 RID: 21735
	[NullableContext(1)]
	[Nullable(0)]
	public class GreatSwordChallengeMarkItem : ConfigMarkItem
	{
		// Token: 0x060377EC RID: 227308 RVA: 0x00D2E0DD File Offset: 0x00D2C2DD
		public GreatSwordChallengeMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource trackSource = ETrackSource.MapMark) : base(markId, markConfig, parent, mapType, markScale, new ETrackSource?(trackSource))
		{
		}

		// Token: 0x060377ED RID: 227309 RVA: 0x00D2E0F3 File Offset: 0x00D2C2F3
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.GreatSwordChallengeMarkItemView;
		}

		// Token: 0x060377EE RID: 227310 RVA: 0x00D2E0F7 File Offset: 0x00D2C2F7
		[PreserveBaseOverrides]
		protected new virtual GreatSwordChallengeMarkItemView CreateView()
		{
			return new GreatSwordChallengeMarkItemView(this);
		}

		// Token: 0x060377EF RID: 227311 RVA: 0x00D2E0FF File Offset: 0x00D2C2FF
		protected override void InitIcon()
		{
			this.UpdateIconPath();
		}

		// Token: 0x060377F0 RID: 227312 RVA: 0x00D2E108 File Offset: 0x00D2C308
		public override void UpdateIconPath()
		{
			this.IconPath = (((this.MarkConfig != null) ? this.MarkConfig.GetValueOrDefault().UnlockMarkPic : null) ?? "");
		}
	}
}
