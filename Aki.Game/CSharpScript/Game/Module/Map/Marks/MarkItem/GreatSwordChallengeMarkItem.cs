using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020044BA RID: 17594
	[NullableContext(1)]
	[Nullable(0)]
	public class GreatSwordChallengeMarkItem : ConfigMarkItem
	{
		// Token: 0x0602C6A9 RID: 181929 RVA: 0x00C7C1D0 File Offset: 0x00C7A3D0
		public GreatSwordChallengeMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource trackSource = ETrackSource.MapMark) : base(markId, markConfig, parent, mapType, markScale, new ETrackSource?(trackSource))
		{
		}

		// Token: 0x0602C6AA RID: 181930 RVA: 0x00C7C1E6 File Offset: 0x00C7A3E6
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.GreatSwordChallengeMarkItemView;
		}

		// Token: 0x0602C6AB RID: 181931 RVA: 0x00C7C1EA File Offset: 0x00C7A3EA
		[PreserveBaseOverrides]
		protected new virtual GreatSwordChallengeMarkItemView CreateView()
		{
			return new GreatSwordChallengeMarkItemView(this);
		}

		// Token: 0x0602C6AC RID: 181932 RVA: 0x00C7C1F2 File Offset: 0x00C7A3F2
		protected override void InitIcon()
		{
			this.UpdateIconPath();
		}

		// Token: 0x0602C6AD RID: 181933 RVA: 0x00C7C1FC File Offset: 0x00C7A3FC
		public override void UpdateIconPath()
		{
			MapMark? mapMark;
			this.IconPath = (((base.MarkConfig != null) ? mapMark.GetValueOrDefault().UnlockMarkPic : null) ?? "");
		}
	}
}
