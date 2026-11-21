using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005523 RID: 21795
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DockyardInteractGrid : GridProxyAbstract<IPanelPos>
	{
		// Token: 0x170068DB RID: 26843
		// (get) Token: 0x060360A1 RID: 221345 RVA: 0x00F1603E File Offset: 0x00F1423E
		// (set) Token: 0x060360A0 RID: 221344 RVA: 0x00F1601A File Offset: 0x00F1421A
		public EDockyardInteractGridShowType ShowType
		{
			get
			{
				return this.ShowTypeInternal;
			}
			set
			{
				if (this.ShowTypeInternal == value)
				{
					return;
				}
				this.ShowTypeInternal = value;
				this.StateFunc[value]();
			}
		}

		// Token: 0x060360A2 RID: 221346 RVA: 0x00F16048 File Offset: 0x00F14248
		private void SetEmptyState()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_GridEmpty");
			this.SetSpriteByPath(resourcePath, this.BgSprite, false, null, null);
			this.BgSprite.SetUIActive(true);
		}

		// Token: 0x060360A3 RID: 221347 RVA: 0x00F1608C File Offset: 0x00F1428C
		private void SetOutlineState()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_GridFinsh");
			this.SetSpriteByPath(resourcePath, this.BgSprite, false, null, null);
			this.BgSprite.SetUIActive(true);
		}

		// Token: 0x060360A4 RID: 221348 RVA: 0x00F160D0 File Offset: 0x00F142D0
		private void SetPreviewErrorState()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_GridError");
			this.SetSpriteByPath(resourcePath, this.BgSprite, false, null, null);
			this.BgSprite.SetUIActive(true);
		}

		// Token: 0x060360A5 RID: 221349 RVA: 0x00F16114 File Offset: 0x00F14314
		private void SetPreviewOccupancyState()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_GridReplace");
			this.SetSpriteByPath(resourcePath, this.BgSprite, false, null, null);
			this.BgSprite.SetUIActive(true);
		}

		// Token: 0x060360A6 RID: 221350 RVA: 0x00F16158 File Offset: 0x00F14358
		private void SetPreviewMatchState()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_GridFinsh");
			this.SetSpriteByPath(resourcePath, this.BgSprite, false, null, null);
			this.BgSprite.SetUIActive(true);
		}

		// Token: 0x060360A7 RID: 221351 RVA: 0x00F1619C File Offset: 0x00F1439C
		private void SetMatchState()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_GridFinsh");
			this.SetSpriteByPath(resourcePath, this.BgSprite, false, null, null);
			this.BgSprite.SetUIActive(true);
		}

		// Token: 0x060360A8 RID: 221352 RVA: 0x00F161E0 File Offset: 0x00F143E0
		public DockyardInteractGrid(DockyardInteractPanelModel parentModel)
		{
			this.ParentModel = parentModel;
			this.StateFunc = new Dictionary<EDockyardInteractGridShowType, Action>
			{
				{
					EDockyardInteractGridShowType.None,
					null
				},
				{
					EDockyardInteractGridShowType.Empty,
					new Action(this.SetEmptyState)
				},
				{
					EDockyardInteractGridShowType.Outline,
					new Action(this.SetOutlineState)
				},
				{
					EDockyardInteractGridShowType.PreviewError,
					new Action(this.SetPreviewErrorState)
				},
				{
					EDockyardInteractGridShowType.PreviewOccupancy,
					new Action(this.SetPreviewOccupancyState)
				},
				{
					EDockyardInteractGridShowType.PreviewMatch,
					new Action(this.SetPreviewMatchState)
				},
				{
					EDockyardInteractGridShowType.Match,
					new Action(this.SetMatchState)
				}
			};
		}

		// Token: 0x060360A9 RID: 221353 RVA: 0x00F16280 File Offset: 0x00F14480
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060360AA RID: 221354 RVA: 0x00F162E9 File Offset: 0x00F144E9
		protected override void OnStart()
		{
			this.BgSprite = base.GetSprite(0);
			UUIItem item = base.GetItem(1);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x060360AB RID: 221355 RVA: 0x00F1630A File Offset: 0x00F1450A
		public override void Refresh(IPanelPos pos, bool isSelected, int gridIndex)
		{
			this.InteractGridData = this.ParentModel.GetInteractGridData(pos);
			this.ShowType = (this.InteractGridData.IsFinish ? EDockyardInteractGridShowType.Match : EDockyardInteractGridShowType.Empty);
		}

		// Token: 0x060360AC RID: 221356 RVA: 0x00F16335 File Offset: 0x00F14535
		public void RefreshBgSprite(bool isAllMatch)
		{
			if (!isAllMatch)
			{
				this.ShowType = EDockyardInteractGridShowType.PreviewError;
				return;
			}
			if (this.InteractGridData.IsFinish)
			{
				this.ShowType = EDockyardInteractGridShowType.PreviewOccupancy;
				return;
			}
			this.ShowType = EDockyardInteractGridShowType.PreviewMatch;
		}

		// Token: 0x060360AD RID: 221357 RVA: 0x00F1635E File Offset: 0x00F1455E
		public void ResetPreviewBg()
		{
			if (this.InteractGridData.IsFinish)
			{
				this.ShowType = EDockyardInteractGridShowType.Match;
				return;
			}
			this.ShowType = EDockyardInteractGridShowType.Empty;
		}

		// Token: 0x060360AE RID: 221358 RVA: 0x00F1637C File Offset: 0x00F1457C
		public int GetTargetItemId()
		{
			return this.InteractGridData.TargetId;
		}

		// Token: 0x170068DC RID: 26844
		// (get) Token: 0x060360AF RID: 221359 RVA: 0x00F16389 File Offset: 0x00F14589
		public bool IsFinishInteract
		{
			get
			{
				return this.InteractGridData.IsFinish;
			}
		}

		// Token: 0x060360B0 RID: 221360 RVA: 0x00F16396 File Offset: 0x00F14596
		public override object GetKey(IPanelPos data, int displayIndex)
		{
			return data;
		}

		// Token: 0x0401C89E RID: 116894
		private DockyardInteractGridData InteractGridData;

		// Token: 0x0401C89F RID: 116895
		private UUISprite BgSprite;

		// Token: 0x0401C8A0 RID: 116896
		private readonly DockyardInteractPanelModel ParentModel;

		// Token: 0x0401C8A1 RID: 116897
		private EDockyardInteractGridShowType ShowTypeInternal;

		// Token: 0x0401C8A2 RID: 116898
		private Dictionary<EDockyardInteractGridShowType, Action> StateFunc;

		// Token: 0x0200B186 RID: 45446
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04036E3A RID: 224826
			public const int BgSprite = 0;

			// Token: 0x04036E3B RID: 224827
			public const int QuicklySellItem = 1;
		}
	}
}
