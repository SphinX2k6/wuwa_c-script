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
	// Token: 0x020047C4 RID: 18372
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapExtraUiPanel : UiPanelBase
	{
		// Token: 0x060301F9 RID: 197113 RVA: 0x00B278DC File Offset: 0x00B25ADC
		public WorldMapExtraUiPanel(EWorldMapExtraUiPanelName panelName, WorldMapExtraUiPanelComponent extraUiPanelComponent)
		{
			this.PanelName = panelName;
			this.ExtraUiPanelComponent = extraUiPanelComponent;
		}

		// Token: 0x060301FA RID: 197114 RVA: 0x00B2790B File Offset: 0x00B25B0B
		[NullableContext(2)]
		public virtual UUISliderComponent GetScaleSlider()
		{
			return null;
		}

		// Token: 0x060301FB RID: 197115 RVA: 0x00B2790E File Offset: 0x00B25B0E
		[NullableContext(2)]
		public virtual void OnHandleShowParam(object param = null)
		{
		}

		// Token: 0x060301FC RID: 197116 RVA: 0x00B27910 File Offset: 0x00B25B10
		public virtual bool OnClickEmpty(Vector2D clickedPosition)
		{
			return false;
		}

		// Token: 0x060301FD RID: 197117 RVA: 0x00B27913 File Offset: 0x00B25B13
		public virtual ClickMarkItemRet OnClickMarkItem(MarkItem clickedItem)
		{
			return this.ClickMarkItemRetData;
		}

		// Token: 0x060301FE RID: 197118 RVA: 0x00B2791B File Offset: 0x00B25B1B
		public virtual bool OnClickMarks(List<MarkItem> clickedItems, Vector2D clickedPosition)
		{
			return false;
		}

		// Token: 0x060301FF RID: 197119 RVA: 0x00B27920 File Offset: 0x00B25B20
		public virtual int? GetCustomClickRange()
		{
			return null;
		}

		// Token: 0x06030200 RID: 197120 RVA: 0x00B27936 File Offset: 0x00B25B36
		public virtual bool GetIsEnableMapScale()
		{
			return true;
		}

		// Token: 0x06030201 RID: 197121 RVA: 0x00B27939 File Offset: 0x00B25B39
		public virtual bool GetIsEnableMapCursorButton()
		{
			return true;
		}

		// Token: 0x06030202 RID: 197122 RVA: 0x00B2793C File Offset: 0x00B25B3C
		public virtual bool OnPointerDrag(Vector2D delta)
		{
			return false;
		}

		// Token: 0x06030203 RID: 197123 RVA: 0x00B2793F File Offset: 0x00B25B3F
		protected void CloseMe()
		{
			this.ExtraUiPanelComponent.CloseUi(this);
		}

		// Token: 0x06030204 RID: 197124 RVA: 0x00B2794D File Offset: 0x00B25B4D
		public virtual float GetDefaultMapScale()
		{
			return 0f;
		}

		// Token: 0x06030205 RID: 197125 RVA: 0x00B27954 File Offset: 0x00B25B54
		public virtual float GetMaxMapScale()
		{
			return 0f;
		}

		// Token: 0x06030206 RID: 197126 RVA: 0x00B2795B File Offset: 0x00B25B5B
		public virtual float GetMinMapScale()
		{
			return 0f;
		}

		// Token: 0x06030207 RID: 197127 RVA: 0x00B27962 File Offset: 0x00B25B62
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual IEnumerable<string> GetTileRange()
		{
			return null;
		}

		// Token: 0x06030208 RID: 197128 RVA: 0x00B27965 File Offset: 0x00B25B65
		public virtual bool GetIsShowPlayerMark()
		{
			return false;
		}

		// Token: 0x06030209 RID: 197129 RVA: 0x00B27968 File Offset: 0x00B25B68
		public virtual EMarkType[] GetExtraMarkTypes()
		{
			return Array.Empty<EMarkType>();
		}

		// Token: 0x0603020A RID: 197130 RVA: 0x00B2796F File Offset: 0x00B25B6F
		[NullableContext(2)]
		public virtual int[] GetExtraMarkIds()
		{
			return null;
		}

		// Token: 0x0603020B RID: 197131 RVA: 0x00B27972 File Offset: 0x00B25B72
		[NullableContext(2)]
		public virtual int[] GetUnlockFogs()
		{
			return null;
		}

		// Token: 0x0603020C RID: 197132 RVA: 0x00B27975 File Offset: 0x00B25B75
		public virtual bool GetIsShowAreaMarkProgress()
		{
			return false;
		}

		// Token: 0x0603020D RID: 197133 RVA: 0x00B27978 File Offset: 0x00B25B78
		public virtual bool GetIsCanAutoPilotTrack()
		{
			return false;
		}

		// Token: 0x0603020E RID: 197134 RVA: 0x00B2797B File Offset: 0x00B25B7B
		public virtual bool GetIsMapRangeVisible()
		{
			return false;
		}

		// Token: 0x0603020F RID: 197135 RVA: 0x00B2797E File Offset: 0x00B25B7E
		public virtual bool GetIsMultiMapVisible()
		{
			return false;
		}

		// Token: 0x06030210 RID: 197136 RVA: 0x00B27984 File Offset: 0x00B25B84
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

		// Token: 0x06030211 RID: 197137 RVA: 0x00B2799A File Offset: 0x00B25B9A
		[NullableContext(2)]
		public virtual string GetBackgroundMusicAudioEvent()
		{
			return null;
		}

		// Token: 0x06030212 RID: 197138 RVA: 0x00B2799D File Offset: 0x00B25B9D
		[NullableContext(2)]
		public virtual void SetOpenParam(object openParam)
		{
			this.OpenParam = openParam;
		}

		// Token: 0x04019EDA RID: 106202
		public readonly EWorldMapExtraUiPanelName PanelName;

		// Token: 0x04019EDB RID: 106203
		public readonly WorldMapExtraUiPanelComponent ExtraUiPanelComponent;

		// Token: 0x04019EDC RID: 106204
		protected readonly ClickMarkItemRet ClickMarkItemRetData = new ClickMarkItemRet
		{
			IsExtraUiLogic = false,
			IsNeedSelected = true
		};
	}
}
