using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark.Component;
using CSharpScript.Game.Module.MingSu;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x0200553C RID: 21820
	public class MingSuNpcTopRightIconHandle : MarkItemTopRightIconHandle
	{
		// Token: 0x06037B27 RID: 228135 RVA: 0x00D37916 File Offset: 0x00D35B16
		[NullableContext(1)]
		public MingSuNpcTopRightIconHandle(IMarkItemComponentContext context) : base(context)
		{
		}

		// Token: 0x06037B28 RID: 228136 RVA: 0x00D37920 File Offset: 0x00D35B20
		protected override void OnUpdate()
		{
			MarkItemEntity markItemEntity = this.Context.MarkItemEntity;
			if (markItemEntity.GamePlay.IsDisable)
			{
				base.SetVisible(true);
				markItemEntity.Resource.TopRightIconPath = UiResourceConfig.Instance.GetResourcePath("SP_MarkBlock");
				this.Context.SetSpriteByPathAction(markItemEntity.Resource.TopRightIconPath, this.Context.TopRightIconSprite, false, null, null);
				return;
			}
			MarkConfigComponent component = markItemEntity.GetComponent<MarkConfigComponent>(EMapComponent.MarkConfig);
			EMarkRelativeType value = component.RelativeType.Value;
			EMarkRelativeSubType value2 = component.RelativeSubType.Value;
			bool flag = false;
			if (value == EMarkRelativeType.LevelPlay && value2 == EMarkRelativeSubType.DarkCoastDelivery)
			{
				int value3 = component.RelativeId.Value;
				flag = (MingSuModel.Instance.GetDarkCoastDeliveryDataByLevelPlayId(value3).GetDarkCoastDeliveryGuardState() == MingSuDefine.EDarkCoastDeliveryLevelDataState.Received);
				if (flag)
				{
					string topRightIconPath = markItemEntity.Resource.TopRightIconPath;
					this.Context.SetSpriteByPathAction(topRightIconPath, this.Context.TopRightIconSprite, false, null, null);
				}
			}
			base.SetVisible(flag);
		}
	}
}
