using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001007 RID: 4103
	[NullableContext(1)]
	[Nullable(0)]
	public class IMechaTrackScoreDetectionType
	{
		// Token: 0x06005B96 RID: 23446 RVA: 0x000DE464 File Offset: 0x000DC664
		private IMechaTrackScoreDetectionType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMechaTrackScoreDetectionType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMechaTrackScoreDetectionType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMechaTrackScoreDetectionType_SetValue());
			}
			return result;
		}

		// Token: 0x06005B97 RID: 23447 RVA: 0x000DE49C File Offset: 0x000DC69C
		public static IMechaTrackScoreDetectionType Create([Nullable(2)] IMechaTrackScoreDetectionType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechaTrackScoreDetectionType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005B98 RID: 23448 RVA: 0x000DE4AF File Offset: 0x000DC6AF
		public static IMechaTrackScoreDetectionType CreateFromSetValue([Nullable(2)] IMechaTrackScoreDetectionType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMechaTrackScoreDetectionType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005B99 RID: 23449 RVA: 0x000DE4C2 File Offset: 0x000DC6C2
		public IMechaTrackScoreDetectionType_SetValue ToSetValue()
		{
			return new IMechaTrackScoreDetectionType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001E42 RID: 7746
		// (get) Token: 0x06005B9A RID: 23450 RVA: 0x000DE4D5 File Offset: 0x000DC6D5
		// (set) Token: 0x06005B9B RID: 23451 RVA: 0x000DE500 File Offset: 0x000DC700
		public virtual EMechaTrackScoreDetectionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMechaTrackScoreDetectionType.StuntAction;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400372D RID: 14125
		[Nullable(2)]
		protected IMechaTrackScoreDetectionType FbInstance;

		// Token: 0x0400372E RID: 14126
		[Nullable(2)]
		protected IMechaTrackScoreDetectionType_SetValue PocoInterface;
	}
}
