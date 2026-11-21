using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Map.MapDefine;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Components
{
	// Token: 0x02004517 RID: 17687
	public class MarkGravityReverseIconComponent : MarkPanelBase
	{
		// Token: 0x0602CA1D RID: 182813 RVA: 0x00C85CA0 File Offset: 0x00C83EA0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602CA1E RID: 182814 RVA: 0x00C85CE8 File Offset: 0x00C83EE8
		protected override void OnStart()
		{
			base.GetSprite(0).SetUIActive(false);
			this.UpdateIcon();
		}

		// Token: 0x0602CA1F RID: 182815 RVA: 0x00C85D00 File Offset: 0x00C83F00
		private void UpdateIcon()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath((this.Gravity == EMapGravityDirection.Down) ? "SP_OverviewDown" : "SP_OverviewUp");
			this.SetSpriteByPath(resourcePath, base.GetSprite(0), false, null, delegate(bool success)
			{
				base.GetSprite(0).SetUIActive(true);
			});
		}

		// Token: 0x1700595C RID: 22876
		// (get) Token: 0x0602CA20 RID: 182816 RVA: 0x00C85D51 File Offset: 0x00C83F51
		// (set) Token: 0x0602CA21 RID: 182817 RVA: 0x00C85D59 File Offset: 0x00C83F59
		public EMapGravityDirection Gravity
		{
			get
			{
				return this.GravityDirection;
			}
			set
			{
				this.GravityDirection = value;
				if (base.GetSprite(0) != null)
				{
					this.UpdateIcon();
				}
			}
		}

		// Token: 0x04017EC8 RID: 97992
		private EMapGravityDirection GravityDirection = EMapGravityDirection.Down;

		// Token: 0x0200A19D RID: 41373
		public static class EComponents
		{
			// Token: 0x040322CE RID: 205518
			public const int Icon = 0;
		}
	}
}
