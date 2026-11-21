using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.MingSu;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x0200450E RID: 17678
	public class MingSuNpcTopRightIconHandle : MarkItemTopRightIconHandle
	{
		// Token: 0x0602C9F7 RID: 182775 RVA: 0x00C85422 File Offset: 0x00C83622
		[NullableContext(1)]
		public MingSuNpcTopRightIconHandle(IMarkItemComponentContext context) : base(context)
		{
		}

		// Token: 0x0602C9F8 RID: 182776 RVA: 0x00C8542C File Offset: 0x00C8362C
		protected override void OnUpdate()
		{
			MarkItem markItem = this.Context.MarkItem;
			if (MapModel.Instance.IsMarkDisable(this.Context.MarkItem.MarkId, this.Context.MarkItem.IsMarkDisabled()))
			{
				base.SetVisible(true);
				markItem.TopRightIconPath = UiResourceConfig.Instance.GetResourcePath("SP_MarkBlock");
				this.Context.SetSpriteByPathAction(markItem.TopRightIconPath, this.Context.TopRightIconSprite, false, null, null);
				return;
			}
			IMarkConfig config = this.Context.MarkItem.Config;
			if (config == null)
			{
				base.SetVisible(false);
				return;
			}
			EMarkRelativeType value = config.RelativeType.Value;
			EMarkRelativeSubType value2 = config.RelativeSubType.Value;
			bool flag = false;
			if (value == EMarkRelativeType.LevelPlay && value2 == EMarkRelativeSubType.DarkCoastDelivery)
			{
				int value3 = config.RelativeId.Value;
				flag = (MingSuModel.Instance.GetDarkCoastDeliveryDataByLevelPlayId(value3).GetDarkCoastDeliveryGuardState() == MingSuDefine.EDarkCoastDeliveryLevelDataState.Received);
				if (flag)
				{
					markItem.TopRightIconPath = UiResourceConfig.Instance.GetResourcePath("SP_ComIconFinish");
					this.Context.SetSpriteByPathAction(markItem.TopRightIconPath, this.Context.TopRightIconSprite, false, null, null);
				}
			}
			base.SetVisible(flag);
		}
	}
}
