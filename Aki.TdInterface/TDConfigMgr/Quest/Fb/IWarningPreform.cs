using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200142C RID: 5164
	[NullableContext(1)]
	[Nullable(0)]
	public class IWarningPreform
	{
		// Token: 0x06007573 RID: 30067 RVA: 0x0011888C File Offset: 0x00116A8C
		public static IWarningPreform Create(IWarningPreform? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWarningPreform
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170026EE RID: 9966
		// (get) Token: 0x06007574 RID: 30068 RVA: 0x001188AB File Offset: 0x00116AAB
		public virtual IWarningPreformType Type
		{
			get
			{
				if (this._TypeInited)
				{
					return this._TypeCache;
				}
				this._TypeInited = true;
				this._TypeCache = QuestReadHelper.ReadIWarningPreform_Type(this.Instance);
				return this._TypeCache;
			}
		}

		// Token: 0x04004408 RID: 17416
		private IWarningPreform Instance;

		// Token: 0x04004409 RID: 17417
		private IWarningPreformType _TypeCache;

		// Token: 0x0400440A RID: 17418
		private bool _TypeInited;
	}
}
