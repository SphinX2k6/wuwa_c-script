using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x020044E1 RID: 17633
	[NullableContext(1)]
	[Nullable(0)]
	public class FixedSceneGamePlayMarkItemView : ConfigMarkItemView
	{
		// Token: 0x0602C884 RID: 182404 RVA: 0x00C817BD File Offset: 0x00C7F9BD
		public FixedSceneGamePlayMarkItemView(FixedSceneGameplayMarkItem holder) : base(holder)
		{
		}

		// Token: 0x0602C885 RID: 182405 RVA: 0x00C817C6 File Offset: 0x00C7F9C6
		protected override void OnViewRefresh()
		{
			this.UpdateIcon();
		}

		// Token: 0x0602C886 RID: 182406 RVA: 0x00C817D0 File Offset: 0x00C7F9D0
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
