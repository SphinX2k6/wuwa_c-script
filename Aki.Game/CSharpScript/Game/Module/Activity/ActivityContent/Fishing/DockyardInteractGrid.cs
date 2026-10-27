using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065A5 RID: 26021
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DockyardInteractGrid : GridProxyAbstract<IPanelPos>
	{
		// Token: 0x17009579 RID: 38265
		// (get) Token: 0x060413DC RID: 267228 RVA: 0x00FCF03A File Offset: 0x00FCD23A
		// (set) Token: 0x060413DB RID: 267227 RVA: 0x00FCF016 File Offset: 0x00FCD216
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

		// Token: 0x060413DD RID: 267229 RVA: 0x00FCF044 File Offset: 0x00FCD244
		private void SetEmptyState()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_GridEmpty");
			this.SetSpriteByPath(resourcePath, this.BgSprite, false, null, null);
			this.BgSprite.SetUIActive(true);
		}

		// Token: 0x060413DE RID: 267230 RVA: 0x00FCF088 File Offset: 0x00FCD288
		private void SetOutlineState()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_GridFinsh");
			this.SetSpriteByPath(resourcePath, this.BgSprite, false, null, null);
			this.BgSprite.SetUIActive(true);
		}

		// Token: 0x060413DF RID: 267231 RVA: 0x00FCF0CC File Offset: 0x00FCD2CC
		private void SetPreviewErrorState()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_GridError");
			this.SetSpriteByPath(resourcePath, this.BgSprite, false, null, null);
			this.BgSprite.SetUIActive(true);
		}

		// Token: 0x060413E0 RID: 267232 RVA: 0x00FCF110 File Offset: 0x00FCD310
		private void SetPreviewOccupancyState()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_GridReplace");
			this.SetSpriteByPath(resourcePath, this.BgSprite, false, null, null);
			this.BgSprite.SetUIActive(true);
		}

		// Token: 0x060413E1 RID: 267233 RVA: 0x00FCF154 File Offset: 0x00FCD354
		private void SetPreviewMatchState()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_GridFinsh");
			this.SetSpriteByPath(resourcePath, this.BgSprite, false, null, null);
			this.BgSprite.SetUIActive(true);
		}

		// Token: 0x060413E2 RID: 267234 RVA: 0x00FCF198 File Offset: 0x00FCD398
		private void SetMatchState()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_GridFinsh");
			this.SetSpriteByPath(resourcePath, this.BgSprite, false, null, null);
			this.BgSprite.SetUIActive(true);
		}

		// Token: 0x060413E3 RID: 267235 RVA: 0x00FCF1DC File Offset: 0x00FCD3DC
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

		// Token: 0x060413E4 RID: 267236 RVA: 0x00FCF27C File Offset: 0x00FCD47C
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

		// Token: 0x060413E5 RID: 267237 RVA: 0x00FCF2E5 File Offset: 0x00FCD4E5
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

		// Token: 0x060413E6 RID: 267238 RVA: 0x00FCF306 File Offset: 0x00FCD506
		public override void Refresh(IPanelPos pos, bool isSelected, int gridIndex)
		{
			this.InteractGridData = this.ParentModel.GetInteractGridData(pos);
			this.ShowType = (this.InteractGridData.IsFinish ? EDockyardInteractGridShowType.Match : EDockyardInteractGridShowType.Empty);
		}

		// Token: 0x060413E7 RID: 267239 RVA: 0x00FCF331 File Offset: 0x00FCD531
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

		// Token: 0x060413E8 RID: 267240 RVA: 0x00FCF35A File Offset: 0x00FCD55A
		public void ResetPreviewBg()
		{
			if (this.InteractGridData.IsFinish)
			{
				this.ShowType = EDockyardInteractGridShowType.Match;
				return;
			}
			this.ShowType = EDockyardInteractGridShowType.Empty;
		}

		// Token: 0x060413E9 RID: 267241 RVA: 0x00FCF378 File Offset: 0x00FCD578
		public int GetTargetItemId()
		{
			return this.InteractGridData.TargetId;
		}

		// Token: 0x1700957A RID: 38266
		// (get) Token: 0x060413EA RID: 267242 RVA: 0x00FCF385 File Offset: 0x00FCD585
		public bool IsFinishInteract
		{
			get
			{
				return this.InteractGridData.IsFinish;
			}
		}

		// Token: 0x060413EB RID: 267243 RVA: 0x00FCF392 File Offset: 0x00FCD592
		public override object GetKey(IPanelPos data, int displayIndex)
		{
			return data;
		}

		// Token: 0x04021F6D RID: 139117
		private DockyardInteractGridData InteractGridData;

		// Token: 0x04021F6E RID: 139118
		private UUISprite BgSprite;

		// Token: 0x04021F6F RID: 139119
		private readonly DockyardInteractPanelModel ParentModel;

		// Token: 0x04021F70 RID: 139120
		private EDockyardInteractGridShowType ShowTypeInternal;

		// Token: 0x04021F71 RID: 139121
		private Dictionary<EDockyardInteractGridShowType, Action> StateFunc;

		// Token: 0x0200C7A1 RID: 51105
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403C4E9 RID: 247017
			public const int BgSprite = 0;

			// Token: 0x0403C4EA RID: 247018
			public const int QuicklySellItem = 1;
		}
	}
}
