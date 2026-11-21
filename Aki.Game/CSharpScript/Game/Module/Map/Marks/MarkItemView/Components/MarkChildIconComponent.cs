using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Components
{
	// Token: 0x02004515 RID: 17685
	[NullableContext(2)]
	[Nullable(0)]
	public class MarkChildIconComponent : MarkPanelBase
	{
		// Token: 0x0602CA0F RID: 182799 RVA: 0x00C85A80 File Offset: 0x00C83C80
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

		// Token: 0x0602CA10 RID: 182800 RVA: 0x00C85AC8 File Offset: 0x00C83CC8
		protected override void OnStart()
		{
			base.GetSprite(0).SetUIActive(false);
			this.UpdateIcon();
		}

		// Token: 0x0602CA11 RID: 182801 RVA: 0x00C85AE0 File Offset: 0x00C83CE0
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

		// Token: 0x1700595A RID: 22874
		// (get) Token: 0x0602CA12 RID: 182802 RVA: 0x00C85B31 File Offset: 0x00C83D31
		// (set) Token: 0x0602CA13 RID: 182803 RVA: 0x00C85B39 File Offset: 0x00C83D39
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

		// Token: 0x04017EC6 RID: 97990
		private string Path;

		// Token: 0x0200A19A RID: 41370
		[NullableContext(0)]
		public static class EChildComponents
		{
			// Token: 0x040322C8 RID: 205512
			public const int Icon = 0;
		}
	}
}
