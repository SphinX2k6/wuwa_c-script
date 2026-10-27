using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Map.MapDefine;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Components
{
	// Token: 0x02005545 RID: 21829
	public class MarkGravityReverseIconComponent : MarkPanelBase
	{
		// Token: 0x06037B4E RID: 228174 RVA: 0x00D381CC File Offset: 0x00D363CC
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

		// Token: 0x06037B4F RID: 228175 RVA: 0x00D38214 File Offset: 0x00D36414
		protected override void OnStart()
		{
			base.GetSprite(0).SetUIActive(false);
			this.UpdateIcon();
		}

		// Token: 0x06037B50 RID: 228176 RVA: 0x00D3822C File Offset: 0x00D3642C
		private void UpdateIcon()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath((this.Gravity == EMapGravityDirection.Down) ? "SP_OverviewDown" : "SP_OverviewUp");
			this.SetSpriteByPath(resourcePath, base.GetSprite(0), false, null, delegate(bool success)
			{
				base.GetSprite(0).SetUIActive(true);
			});
		}

		// Token: 0x170085BC RID: 34236
		// (get) Token: 0x06037B51 RID: 228177 RVA: 0x00D3827D File Offset: 0x00D3647D
		// (set) Token: 0x06037B52 RID: 228178 RVA: 0x00D38285 File Offset: 0x00D36485
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

		// Token: 0x0401D442 RID: 119874
		private EMapGravityDirection GravityDirection = EMapGravityDirection.Down;

		// Token: 0x0200B772 RID: 46962
		public static class EComponents
		{
			// Token: 0x040378A3 RID: 227491
			public const int Icon = 0;
		}
	}
}
