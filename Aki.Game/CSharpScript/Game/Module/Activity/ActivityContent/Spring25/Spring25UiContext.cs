using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Spring25
{
	// Token: 0x02005018 RID: 20504
	[NullableContext(1)]
	[Nullable(0)]
	public class Spring25UiContext
	{
		// Token: 0x170063EC RID: 25580
		// (get) Token: 0x060334F0 RID: 210160 RVA: 0x00E62C2D File Offset: 0x00E60E2D
		// (set) Token: 0x060334F1 RID: 210161 RVA: 0x00E62C35 File Offset: 0x00E60E35
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

		// Token: 0x170063ED RID: 25581
		// (get) Token: 0x060334F2 RID: 210162 RVA: 0x00E62C40 File Offset: 0x00E60E40
		// (set) Token: 0x060334F3 RID: 210163 RVA: 0x00E62C7F File Offset: 0x00E60E7F
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

		// Token: 0x060334F4 RID: 210164 RVA: 0x00E62CBB File Offset: 0x00E60EBB
		public Spring25UiContext(Spring25Model model)
		{
			this.AttachedModel = model;
		}

		// Token: 0x060334F5 RID: 210165 RVA: 0x00E62CCA File Offset: 0x00E60ECA
		public void Dispose()
		{
			this.CurrentSignIdInternal = null;
		}

		// Token: 0x0401B498 RID: 111768
		private readonly Spring25Model AttachedModel;

		// Token: 0x0401B499 RID: 111769
		private int? CurrentSignIdInternal;

		// Token: 0x0401B49A RID: 111770
		private int? CurrentLetterSignIdInternal;
	}
}
