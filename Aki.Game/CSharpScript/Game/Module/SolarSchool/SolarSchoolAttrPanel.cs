using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200598F RID: 22927
	public class SolarSchoolAttrPanel : UiPanelBase
	{
		// Token: 0x06038875 RID: 231541 RVA: 0x00FD1008 File Offset: 0x00FCF208
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038876 RID: 231542 RVA: 0x00FD10D4 File Offset: 0x00FCF2D4
		protected override void OnStart()
		{
			AActor rootActor = base.GetRootActor();
			this.Canvas = (((rootActor != null) ? rootActor.GetComponentByClass(ULGUICanvas.StaticClass()) : null) as ULGUICanvas);
			this.ScoreScroll = new GenericScrollViewNew<SolarSchoolAttrItem, ESolarSchoolSecondAttr>(base.GetScrollViewWithScrollbar(2), new Func<SolarSchoolAttrItem>(this.CreateScoreItem), base.GetItem(3).GetOwner() as AUIBaseActor, false, null);
			this.RefreshAttr();
			this.SetHelpGroupId();
			EventSystem.Instance.Add<ESolarSchoolSecondAttr>(EEventName.SolarSchoolAttrChanged, new Action<ESolarSchoolSecondAttr>(this.OnAttrChanged));
			EventSystem.Instance.Add<ESolarSchoolSecondAttr>(EEventName.SolarSchoolAttrImportantChanged, new Action<ESolarSchoolSecondAttr>(this.OnAttrChanged));
		}

		// Token: 0x06038877 RID: 231543 RVA: 0x00FD1180 File Offset: 0x00FCF380
		private void SetHelpGroupId()
		{
			UUIItem item = base.GetItem(1);
			object obj;
			if (item == null)
			{
				obj = null;
			}
			else
			{
				AActor owner = item.GetOwner();
				obj = ((owner != null) ? owner.GetComponentByClass(UUIExtendButtonComponent.StaticClass()) : null);
			}
			UUIExtendButtonComponent uuiextendButtonComponent = obj as UUIExtendButtonComponent;
			if (uuiextendButtonComponent != null)
			{
				uuiextendButtonComponent.HelpGroupId = 702;
			}
		}

		// Token: 0x06038878 RID: 231544 RVA: 0x00FD11CA File Offset: 0x00FCF3CA
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove<ESolarSchoolSecondAttr>(EEventName.SolarSchoolAttrChanged, new Action<ESolarSchoolSecondAttr>(this.OnAttrChanged));
			EventSystem.Instance.Remove<ESolarSchoolSecondAttr>(EEventName.SolarSchoolAttrImportantChanged, new Action<ESolarSchoolSecondAttr>(this.OnAttrChanged));
		}

		// Token: 0x06038879 RID: 231545 RVA: 0x00FD1204 File Offset: 0x00FCF404
		public void SetBehaviorPreview(int behaviorId)
		{
			this.PreviewBehaviorId = behaviorId;
			this.RefreshAttr();
		}

		// Token: 0x0603887A RID: 231546 RVA: 0x00FD1213 File Offset: 0x00FCF413
		public void ClearBehaviorPreview()
		{
			this.PreviewBehaviorId = 0;
			this.RefreshAttr();
		}

		// Token: 0x0603887B RID: 231547 RVA: 0x00FD1224 File Offset: 0x00FCF424
		public void SetAboveMask(bool above)
		{
			if (this.Canvas == null)
			{
				if (above)
				{
					Log.Instance.Warn(ELogModule.SolarSchool, ELogAuthor.LRC, "[SolarSchool] 属性面板没挂 LGUICanvas，无法抬到二次确认遮罩之上", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				return;
			}
			this.Canvas.SetSortOrder((above > false) ? 1 : 0, true);
		}

		// Token: 0x0603887C RID: 231548 RVA: 0x00FD126C File Offset: 0x00FCF46C
		public void RefreshAttr()
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			this.IncreasedAttrs.Clear();
			if (this.PreviewBehaviorId != 0)
			{
				SolarSchoolBehavior? currentLevelRow = instance.PlayerData.GetCurrentLevelRow(this.PreviewBehaviorId);
				if (currentLevelRow != null)
				{
					foreach (ValueTuple<ESolarSchoolSecondAttr, int> valueTuple in instance.GetBehaviorSuccessAttrDeltas(currentLevelRow.Value))
					{
						ESolarSchoolSecondAttr item = valueTuple.Item1;
						if (valueTuple.Item2 > 0)
						{
							this.IncreasedAttrs.Add(item);
						}
					}
				}
			}
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.SetText(instance.PlayerData.GetAttr(ESolarSchoolSecondAttr.Popularity).ToString(), true);
			}
			UUISprite sprite = base.GetSprite(4);
			if (sprite != null)
			{
				sprite.SetUIActive(instance.PlayerData.IsAttrImportant(ESolarSchoolSecondAttr.Popularity));
			}
			this.ScoreScroll.RefreshByData(SolarSchoolDefine.AttrsShowList, null, false);
		}

		// Token: 0x0603887D RID: 231549 RVA: 0x00FD1368 File Offset: 0x00FCF568
		[NullableContext(1)]
		private SolarSchoolAttrItem CreateScoreItem()
		{
			return new SolarSchoolAttrItem
			{
				IsAttrIncreased = ((ESolarSchoolSecondAttr attr) => this.IncreasedAttrs.Contains(attr))
			};
		}

		// Token: 0x0603887E RID: 231550 RVA: 0x00FD1381 File Offset: 0x00FCF581
		private void OnAttrChanged(ESolarSchoolSecondAttr attr)
		{
			this.RefreshAttr();
		}

		// Token: 0x0401DC76 RID: 121974
		private const int SortOrderNormal = 0;

		// Token: 0x0401DC77 RID: 121975
		private const int SortOrderAboveMask = 1;

		// Token: 0x0401DC78 RID: 121976
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<SolarSchoolAttrItem, ESolarSchoolSecondAttr> ScoreScroll;

		// Token: 0x0401DC79 RID: 121977
		[Nullable(1)]
		private readonly HashSet<ESolarSchoolSecondAttr> IncreasedAttrs = new HashSet<ESolarSchoolSecondAttr>();

		// Token: 0x0401DC7A RID: 121978
		private int PreviewBehaviorId;

		// Token: 0x0401DC7B RID: 121979
		[Nullable(2)]
		private ULGUICanvas Canvas;

		// Token: 0x0200B534 RID: 46388
		private class EComponents
		{
			// Token: 0x0403806A RID: 229482
			public const int TxtPopularity = 0;

			// Token: 0x0403806B RID: 229483
			public const int BtnHelpInfo = 1;

			// Token: 0x0403806C RID: 229484
			public const int ScoreScroll = 2;

			// Token: 0x0403806D RID: 229485
			public const int ScoreItem = 3;

			// Token: 0x0403806E RID: 229486
			public const int SprScratch = 4;
		}
	}
}
