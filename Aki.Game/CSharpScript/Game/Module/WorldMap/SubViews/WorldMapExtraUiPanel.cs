using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.WorldMap.ViewComponent;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews
{
	// Token: 0x020036F5 RID: 14069
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapExtraUiPanel : UiPanelBase
	{
		// Token: 0x060249C9 RID: 149961 RVA: 0x00A576E8 File Offset: 0x00A558E8
		public WorldMapExtraUiPanel(EWorldMapExtraUiPanelName panelName, WorldMapExtraUiPanelComponent extraUiPanelComponent)
		{
			this.PanelName = panelName;
			this.ExtraUiPanelComponent = extraUiPanelComponent;
		}

		// Token: 0x060249CA RID: 149962 RVA: 0x00A57717 File Offset: 0x00A55917
		[NullableContext(2)]
		public virtual UUISliderComponent GetScaleSlider()
		{
			return null;
		}

		// Token: 0x060249CB RID: 149963 RVA: 0x00A5771A File Offset: 0x00A5591A
		[NullableContext(2)]
		public virtual void OnHandleShowParam(object param = null)
		{
		}

		// Token: 0x060249CC RID: 149964 RVA: 0x00A5771C File Offset: 0x00A5591C
		public virtual bool OnClickEmpty(Vector2D clickedPosition)
		{
			return false;
		}

		// Token: 0x060249CD RID: 149965 RVA: 0x00A5771F File Offset: 0x00A5591F
		public virtual ClickMarkItemRet OnClickMarkItem(MarkItem clickedItem)
		{
			return this.ClickMarkItemRetData;
		}

		// Token: 0x060249CE RID: 149966 RVA: 0x00A57727 File Offset: 0x00A55927
		public virtual bool OnClickMarks(List<MarkItem> clickedItems, Vector2D clickedPosition)
		{
			return false;
		}

		// Token: 0x060249CF RID: 149967 RVA: 0x00A5772C File Offset: 0x00A5592C
		public virtual int? GetCustomClickRange()
		{
			return null;
		}

		// Token: 0x060249D0 RID: 149968 RVA: 0x00A57742 File Offset: 0x00A55942
		public virtual bool GetIsEnableMapScale()
		{
			return true;
		}

		// Token: 0x060249D1 RID: 149969 RVA: 0x00A57745 File Offset: 0x00A55945
		public virtual bool GetIsEnableMapCursorButton()
		{
			return true;
		}

		// Token: 0x060249D2 RID: 149970 RVA: 0x00A57748 File Offset: 0x00A55948
		public virtual bool OnPointerDrag(Vector2D delta)
		{
			return false;
		}

		// Token: 0x060249D3 RID: 149971 RVA: 0x00A5774B File Offset: 0x00A5594B
		protected void CloseMe()
		{
			this.ExtraUiPanelComponent.CloseUi(this);
		}

		// Token: 0x060249D4 RID: 149972 RVA: 0x00A57759 File Offset: 0x00A55959
		public virtual float GetDefaultMapScale()
		{
			return 0f;
		}

		// Token: 0x060249D5 RID: 149973 RVA: 0x00A57760 File Offset: 0x00A55960
		public virtual float GetMaxMapScale()
		{
			return 0f;
		}

		// Token: 0x060249D6 RID: 149974 RVA: 0x00A57767 File Offset: 0x00A55967
		public virtual float GetMinMapScale()
		{
			return 0f;
		}

		// Token: 0x060249D7 RID: 149975 RVA: 0x00A5776E File Offset: 0x00A5596E
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual IEnumerable<string> GetTileRange()
		{
			return null;
		}

		// Token: 0x060249D8 RID: 149976 RVA: 0x00A57771 File Offset: 0x00A55971
		public virtual bool GetIsShowPlayerMark()
		{
			return false;
		}

		// Token: 0x060249D9 RID: 149977 RVA: 0x00A57774 File Offset: 0x00A55974
		public virtual EMarkType[] GetExtraMarkTypes()
		{
			return Array.Empty<EMarkType>();
		}

		// Token: 0x060249DA RID: 149978 RVA: 0x00A5777B File Offset: 0x00A5597B
		[NullableContext(2)]
		public virtual int[] GetExtraMarkIds()
		{
			return null;
		}

		// Token: 0x060249DB RID: 149979 RVA: 0x00A5777E File Offset: 0x00A5597E
		[NullableContext(2)]
		public virtual int[] GetUnlockFogs()
		{
			return null;
		}

		// Token: 0x060249DC RID: 149980 RVA: 0x00A57781 File Offset: 0x00A55981
		public virtual bool GetIsShowAreaMarkProgress()
		{
			return false;
		}

		// Token: 0x060249DD RID: 149981 RVA: 0x00A57784 File Offset: 0x00A55984
		public virtual bool GetIsCanAutoPilotTrack()
		{
			return false;
		}

		// Token: 0x060249DE RID: 149982 RVA: 0x00A57787 File Offset: 0x00A55987
		public virtual bool GetIsMapRangeVisible()
		{
			return false;
		}

		// Token: 0x060249DF RID: 149983 RVA: 0x00A5778A File Offset: 0x00A5598A
		public virtual bool GetIsMultiMapVisible()
		{
			return false;
		}

		// Token: 0x060249E0 RID: 149984 RVA: 0x00A57790 File Offset: 0x00A55990
		[return: TupleElementNames(new string[]
		{
			"ResourceId",
			"SequenceType"
		})]
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public virtual ValueTuple<string, string>? GetStartSequenceInfo()
		{
			return null;
		}

		// Token: 0x060249E1 RID: 149985 RVA: 0x00A577A6 File Offset: 0x00A559A6
		[NullableContext(2)]
		public virtual string GetBackgroundMusicAudioEvent()
		{
			return null;
		}

		// Token: 0x060249E2 RID: 149986 RVA: 0x00A577A9 File Offset: 0x00A559A9
		[NullableContext(2)]
		public virtual void SetOpenParam(object openParam)
		{
			this.OpenParam = openParam;
		}

		// Token: 0x0401458B RID: 83339
		public readonly EWorldMapExtraUiPanelName PanelName;

		// Token: 0x0401458C RID: 83340
		public readonly WorldMapExtraUiPanelComponent ExtraUiPanelComponent;

		// Token: 0x0401458D RID: 83341
		protected readonly ClickMarkItemRet ClickMarkItemRetData = new ClickMarkItemRet
		{
			IsExtraUiLogic = false,
			IsNeedSelected = true
		};
	}
}
