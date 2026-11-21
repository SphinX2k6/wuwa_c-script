using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DFD RID: 15869
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoguelikeTokenGrid : LoopScrollMediumItemGrid<RogueTokenData>
	{
		// Token: 0x17005282 RID: 21122
		// (get) Token: 0x06028842 RID: 165954 RVA: 0x00B5D97B File Offset: 0x00B5BB7B
		// (set) Token: 0x06028843 RID: 165955 RVA: 0x00B5D983 File Offset: 0x00B5BB83
		public new RogueTokenData Data { get; set; }

		// Token: 0x06028844 RID: 165956 RVA: 0x00B5D98C File Offset: 0x00B5BB8C
		protected override void OnStart()
		{
			base.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClicked));
		}

		// Token: 0x06028845 RID: 165957 RVA: 0x00B5D9A0 File Offset: 0x00B5BBA0
		[NullableContext(1)]
		protected void OnClicked(MediumItemGridExtendCallback _)
		{
			base.ScrollViewDelegate.SelectGridProxy(base.GridIndex, base.DisplayIndex, true);
		}

		// Token: 0x06028846 RID: 165958 RVA: 0x00B5D9BC File Offset: 0x00B5BBBC
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

		// Token: 0x06028847 RID: 165959 RVA: 0x00B5DA7D File Offset: 0x00B5BC7D
		public override void OnSelected(bool fireEvent)
		{
			if (fireEvent)
			{
				EventSystem.Instance.Emit<RoguelikeTokenGrid>(EEventName.RoguelikeSelectToken, this);
			}
		}
	}
}
