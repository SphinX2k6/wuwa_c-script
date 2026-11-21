using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001440 RID: 5184
	public class IDarkTideBossEventModule : IDarkTideModule
	{
		// Token: 0x06007546 RID: 30022 RVA: 0x00119A39 File Offset: 0x00117C39
		public static IDarkTideBossEventModule Create(IDarkTideBossEventModule? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDarkTideBossEventModule
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002468 RID: 9320
		// (get) Token: 0x06007547 RID: 30023 RVA: 0x00119A58 File Offset: 0x00117C58
		public override EDarkTideModuleType Type
		{
			get
			{
				return (EDarkTideModuleType)this.Instance.Type;
			}
		}

		// Token: 0x17002469 RID: 9321
		// (get) Token: 0x06007548 RID: 30024 RVA: 0x00119A65 File Offset: 0x00117C65
		public virtual IDarkTideBossEvent EventType
		{
			get
			{
				if (this._EventTypeInited)
				{
					return this._EventTypeCache;
				}
				this._EventTypeInited = true;
				this._EventTypeCache = QuestReadHelper.ReadIDarkTideBossEventModule_EventType(this.Instance);
				return this._EventTypeCache;
			}
		}

		// Token: 0x040042E6 RID: 17126
		private IDarkTideBossEventModule Instance;

		// Token: 0x040042E7 RID: 17127
		private IDarkTideBossEvent _EventTypeCache;

		// Token: 0x040042E8 RID: 17128
		private bool _EventTypeInited;
	}
}
