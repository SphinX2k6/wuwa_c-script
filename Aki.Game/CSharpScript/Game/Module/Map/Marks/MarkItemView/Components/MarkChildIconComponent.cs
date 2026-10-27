using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Components
{
	// Token: 0x02005543 RID: 21827
	[NullableContext(2)]
	[Nullable(0)]
	public class MarkChildIconComponent : MarkPanelBase
	{
		// Token: 0x06037B40 RID: 228160 RVA: 0x00D37FAC File Offset: 0x00D361AC
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

		// Token: 0x06037B41 RID: 228161 RVA: 0x00D37FF4 File Offset: 0x00D361F4
		protected override void OnStart()
		{
			base.GetSprite(0).SetUIActive(false);
			this.UpdateIcon();
		}

		// Token: 0x06037B42 RID: 228162 RVA: 0x00D3800C File Offset: 0x00D3620C
		private void UpdateIcon()
		{
			if (string.IsNullOrEmpty(this.Path))
			{
				base.GetSprite(0).SetUIActive(false);
				return;
			}
			this.SetSpriteByPath(this.Path, base.GetSprite(0), false, null, delegate(bool success)
			{
				base.GetSprite(0).SetUIActive(true);
			});
		}

		// Token: 0x170085BA RID: 34234
		// (get) Token: 0x06037B43 RID: 228163 RVA: 0x00D3805D File Offset: 0x00D3625D
		// (set) Token: 0x06037B44 RID: 228164 RVA: 0x00D38065 File Offset: 0x00D36265
		public string Icon
		{
			get
			{
				return this.Path;
			}
			set
			{
				this.Path = value;
				if (base.GetSprite(0) != null)
				{
					this.UpdateIcon();
				}
			}
		}

		// Token: 0x0401D440 RID: 119872
		private string Path;

		// Token: 0x0200B76F RID: 46959
		[NullableContext(0)]
		public static class EChildComponents
		{
			// Token: 0x0403789D RID: 227485
			public const int Icon = 0;
		}
	}
}
