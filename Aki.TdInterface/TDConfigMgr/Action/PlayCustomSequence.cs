using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002105 RID: 8453
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayCustomSequence : ActionParams
	{
		// Token: 0x0600B9F8 RID: 47608 RVA: 0x001ADDEC File Offset: 0x001ABFEC
		private PlayCustomSequence_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("PlayCustomSequence 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			PlayCustomSequence_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new PlayCustomSequence_SetValue());
			}
			return result;
		}

		// Token: 0x0600B9F9 RID: 47609 RVA: 0x001ADE24 File Offset: 0x001AC024
		public static PlayCustomSequence Create([Nullable(2)] PlayCustomSequence instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlayCustomSequence
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B9FA RID: 47610 RVA: 0x001ADE37 File Offset: 0x001AC037
		public static PlayCustomSequence CreateFromSetValue([Nullable(2)] PlayCustomSequence_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new PlayCustomSequence
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B9FB RID: 47611 RVA: 0x001ADE4A File Offset: 0x001AC04A
		public PlayCustomSequence_SetValue ToSetValue()
		{
			return new PlayCustomSequence_SetValue
			{
				CustomSeqId = this.CustomSeqId,
				WhoIds = this.WhoIds,
				ResetCamera = this.ResetCamera
			};
		}

		// Token: 0x170038CE RID: 14542
		// (get) Token: 0x0600B9FC RID: 47612 RVA: 0x001ADE75 File Offset: 0x001AC075
		// (set) Token: 0x0600B9FD RID: 47613 RVA: 0x001ADEA0 File Offset: 0x001AC0A0
		public virtual int CustomSeqId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CustomSeqId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.CustomSeqId;
			}
			set
			{
				this.GetOrCreatePoco().CustomSeqId = value;
			}
		}

		// Token: 0x170038CF RID: 14543
		// (get) Token: 0x0600B9FE RID: 47614 RVA: 0x001ADEAE File Offset: 0x001AC0AE
		// (set) Token: 0x0600B9FF RID: 47615 RVA: 0x001ADED5 File Offset: 0x001AC0D5
		public virtual List<int> WhoIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WhoIds;
				}
				PlayCustomSequence_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.WhoIds;
			}
			set
			{
				this.GetOrCreatePoco().WhoIds = value;
			}
		}

		// Token: 0x170038D0 RID: 14544
		// (get) Token: 0x0600BA00 RID: 47616 RVA: 0x001ADEE4 File Offset: 0x001AC0E4
		// (set) Token: 0x0600BA01 RID: 47617 RVA: 0x001ADF1E File Offset: 0x001AC11E
		public virtual bool? ResetCamera
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ResetCamera;
				}
				PlayCustomSequence_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ResetCamera;
			}
			set
			{
				this.GetOrCreatePoco().ResetCamera = value;
			}
		}

		// Token: 0x04006F5B RID: 28507
		[Nullable(2)]
		protected new PlayCustomSequence FbInstance;

		// Token: 0x04006F5C RID: 28508
		[Nullable(2)]
		protected PlayCustomSequence_SetValue PocoInterface;
	}
}
