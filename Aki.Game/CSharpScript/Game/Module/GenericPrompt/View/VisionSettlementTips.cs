using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.GenericPrompt.View
{
	// Token: 0x0200498E RID: 18830
	public class VisionSettlementTips : GenericPromptFloatTipsBase
	{
		// Token: 0x0602F2D4 RID: 193236 RVA: 0x00D260FF File Offset: 0x00D242FF
		[NullableContext(1)]
		public VisionSettlementTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602F2D5 RID: 193237 RVA: 0x00D26108 File Offset: 0x00D24308
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUITexture)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(3, typeof(UUITexture)));
		}

		// Token: 0x0602F2D6 RID: 193238 RVA: 0x00D26148 File Offset: 0x00D24348
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

		// Token: 0x0200A629 RID: 42537
		private class EPhantomSpawnPointTips
		{
			// Token: 0x04033634 RID: 210484
			public const int RedIcon = 2;

			// Token: 0x04033635 RID: 210485
			public const int WhiteIcon = 3;
		}
	}
}
