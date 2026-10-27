using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x0200550E RID: 21774
	[NullableContext(1)]
	[Nullable(0)]
	public class FixedSceneGamePlayMarkItemView : ConfigMarkItemView
	{
		// Token: 0x060379B6 RID: 227766 RVA: 0x00D338E9 File Offset: 0x00D31AE9
		public FixedSceneGamePlayMarkItemView(FixedSceneGameplayMarkItem holder) : base(holder)
		{
		}

		// Token: 0x060379B7 RID: 227767 RVA: 0x00D338F2 File Offset: 0x00D31AF2
		protected override void OnViewRefresh()
		{
			this.UpdateIcon();
		}

		// Token: 0x060379B8 RID: 227768 RVA: 0x00D338FC File Offset: 0x00D31AFC
		protected override void OnSafeUpdate(Vector playerLocation, bool bDragging = false, bool bIsScale = false)
		{
			FixedSceneGameplayMarkItem fixedSceneGameplayMarkItem = (FixedSceneGameplayMarkItem)this.Holder;
			string iconPath = fixedSceneGameplayMarkItem.IconPath;
			LevelPlayInfo levelPlayInfo = LevelPlayModel.Instance.GetLevelPlayInfo(fixedSceneGameplayMarkItem.MarkConfig.Value.RelativeId);
			if (levelPlayInfo == null || levelPlayInfo.IsClose)
			{
				fixedSceneGameplayMarkItem.IconPath = fixedSceneGameplayMarkItem.MarkConfig.Value.LockMarkPic;
			}
			else
			{
				fixedSceneGameplayMarkItem.IconPath = fixedSceneGameplayMarkItem.MarkConfig.Value.UnlockMarkPic;
			}
			if (iconPath != fixedSceneGameplayMarkItem.IconPath)
			{
				this.OnIconPathChanged(fixedSceneGameplayMarkItem.IconPath);
			}
		}
	}
}
