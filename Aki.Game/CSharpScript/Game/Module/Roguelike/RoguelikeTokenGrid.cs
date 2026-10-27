using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E34 RID: 20020
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoguelikeTokenGrid : LoopScrollMediumItemGrid<RogueTokenData>
	{
		// Token: 0x17007ED2 RID: 32466
		// (get) Token: 0x060339D7 RID: 211415 RVA: 0x00C14453 File Offset: 0x00C12653
		// (set) Token: 0x060339D8 RID: 211416 RVA: 0x00C1445B File Offset: 0x00C1265B
		public new RogueTokenData Data { get; set; }

		// Token: 0x060339D9 RID: 211417 RVA: 0x00C14464 File Offset: 0x00C12664
		protected override void OnStart()
		{
			base.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClicked));
		}

		// Token: 0x060339DA RID: 211418 RVA: 0x00C14478 File Offset: 0x00C12678
		[NullableContext(1)]
		protected void OnClicked(MediumItemGridExtendCallback _)
		{
			base.ScrollViewDelegate.SelectGridProxy(base.GridIndex, base.DisplayIndex, true);
		}

		// Token: 0x060339DB RID: 211419 RVA: 0x00C14494 File Offset: 0x00C12694
		[NullableContext(1)]
		protected override void OnRefresh(RogueTokenData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			RogueBuffPool? rogueBuffConfig = RoguelikeConfig.Instance.GetRogueBuffConfig(data.Config.Value.Token);
			PropMediumItemGrid parameters = new PropMediumItemGrid
			{
				Data = data,
				IconPath = rogueBuffConfig.Value.BuffIcon,
				QualityId = new int?(rogueBuffConfig.Value.Quality),
				BottomTextId = rogueBuffConfig.Value.BuffName,
				QualityType = new CommonDefine.EQualityIconType?(CommonDefine.EQualityIconType.MediumItemGridQualitySpritePath),
				IsProhibit = new bool?(data.IsReceive == null)
			};
			base.Apply<PropMediumItemGrid>(parameters);
			this.SetSelected(isSelected, false);
			if (isSelected)
			{
				this.OnSelected(true);
			}
		}

		// Token: 0x060339DC RID: 211420 RVA: 0x00C14555 File Offset: 0x00C12755
		public override void OnSelected(bool fireEvent)
		{
			if (fireEvent)
			{
				EventSystem.Instance.Emit<RoguelikeTokenGrid>(EEventName.RoguelikeSelectToken, this);
			}
		}
	}
}
