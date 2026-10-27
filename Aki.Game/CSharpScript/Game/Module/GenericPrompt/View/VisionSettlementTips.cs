using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.GenericPrompt.View
{
	// Token: 0x020059B5 RID: 22965
	public class VisionSettlementTips : GenericPromptFloatTipsBase
	{
		// Token: 0x0603A3AD RID: 238509 RVA: 0x00DD6C26 File Offset: 0x00DD4E26
		[NullableContext(1)]
		public VisionSettlementTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603A3AE RID: 238510 RVA: 0x00DD6C2F File Offset: 0x00DD4E2F
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUITexture)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(3, typeof(UUITexture)));
		}

		// Token: 0x0603A3AF RID: 238511 RVA: 0x00DD6C70 File Offset: 0x00DD4E70
		protected override void OnStart()
		{
			base.OnStart();
			IVisionSettlementTipsData visionSettlementTipsData = this.OpenParam as IVisionSettlementTipsData;
			if (visionSettlementTipsData != null)
			{
				string resourceId = visionSettlementTipsData.IsHard ? "T_VisionSettlementIcon2" : "T_VisionSettlementIcon1";
				string resourceId2 = visionSettlementTipsData.IsHard ? "T_VisionSettlementIcon2Red" : "T_VisionSettlementIcon1Red";
				string path = UiResourceConfig.Instance.GetResourcePath(resourceId) ?? "";
				string path2 = UiResourceConfig.Instance.GetResourcePath(resourceId2) ?? "";
				base.SetTextureByPath(path2, base.GetTexture(2), null, null);
				base.SetTextureByPath(path, base.GetTexture(3), null, null);
			}
		}

		// Token: 0x0200BC1E RID: 48158
		private class EPhantomSpawnPointTips
		{
			// Token: 0x04038C65 RID: 232549
			public const int RedIcon = 2;

			// Token: 0x04038C66 RID: 232550
			public const int WhiteIcon = 3;
		}
	}
}
