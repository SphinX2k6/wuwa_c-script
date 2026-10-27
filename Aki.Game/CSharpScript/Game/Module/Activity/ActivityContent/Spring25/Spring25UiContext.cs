using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Spring25
{
	// Token: 0x0200609A RID: 24730
	[NullableContext(1)]
	[Nullable(0)]
	public class Spring25UiContext
	{
		// Token: 0x1700908A RID: 37002
		// (get) Token: 0x0603E82C RID: 256044 RVA: 0x00F1BE69 File Offset: 0x00F1A069
		// (set) Token: 0x0603E82D RID: 256045 RVA: 0x00F1BE71 File Offset: 0x00F1A071
		public int? CurrentSignId
		{
			get
			{
				return this.CurrentSignIdInternal;
			}
			set
			{
				this.CurrentSignIdInternal = value;
			}
		}

		// Token: 0x1700908B RID: 37003
		// (get) Token: 0x0603E82E RID: 256046 RVA: 0x00F1BE7C File Offset: 0x00F1A07C
		// (set) Token: 0x0603E82F RID: 256047 RVA: 0x00F1BEBB File Offset: 0x00F1A0BB
		public int? CurrentLetterSignId
		{
			get
			{
				if (this.CurrentLetterSignIdInternal == null)
				{
					Log.Instance.Error(ELogModule.Spring25, ELogAuthor.WZ, "打开面板之前，未能获得TaskId，请确认Letter TaskId 是否已赋值", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				return this.CurrentLetterSignIdInternal;
			}
			set
			{
				this.CurrentLetterSignIdInternal = value;
				if (value != null)
				{
					this.AttachedModel.SetLetterClickedBySignId(value.Value, true);
					EventSystem.Instance.Emit<int>(EEventName.Spring25SelectLetter, value.Value);
				}
			}
		}

		// Token: 0x0603E830 RID: 256048 RVA: 0x00F1BEF7 File Offset: 0x00F1A0F7
		public Spring25UiContext(Spring25Model model)
		{
			this.AttachedModel = model;
		}

		// Token: 0x0603E831 RID: 256049 RVA: 0x00F1BF06 File Offset: 0x00F1A106
		public void Dispose()
		{
			this.CurrentSignIdInternal = null;
		}

		// Token: 0x04020B6B RID: 133995
		private readonly Spring25Model AttachedModel;

		// Token: 0x04020B6C RID: 133996
		private int? CurrentSignIdInternal;

		// Token: 0x04020B6D RID: 133997
		private int? CurrentLetterSignIdInternal;
	}
}
