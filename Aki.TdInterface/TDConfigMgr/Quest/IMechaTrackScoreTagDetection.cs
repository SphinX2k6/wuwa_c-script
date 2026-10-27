using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200100F RID: 4111
	[NullableContext(1)]
	[Nullable(0)]
	public class IMechaTrackScoreTagDetection : IMechaTrackScoreDetectionType
	{
		// Token: 0x06005BBC RID: 23484 RVA: 0x000DE8D0 File Offset: 0x000DCAD0
		private IMechaTrackScoreTagDetection_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMechaTrackScoreTagDetection 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMechaTrackScoreTagDetection_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMechaTrackScoreTagDetection_SetValue());
			}
			return result;
		}

		// Token: 0x06005BBD RID: 23485 RVA: 0x000DE908 File Offset: 0x000DCB08
		public static IMechaTrackScoreTagDetection Create([Nullable(2)] IMechaTrackScoreTagDetection instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechaTrackScoreTagDetection
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005BBE RID: 23486 RVA: 0x000DE91B File Offset: 0x000DCB1B
		public static IMechaTrackScoreTagDetection CreateFromSetValue([Nullable(2)] IMechaTrackScoreTagDetection_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMechaTrackScoreTagDetection
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005BBF RID: 23487 RVA: 0x000DE92E File Offset: 0x000DCB2E
		public new IMechaTrackScoreTagDetection_SetValue ToSetValue()
		{
			return new IMechaTrackScoreTagDetection_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001E49 RID: 7753
		// (get) Token: 0x06005BC0 RID: 23488 RVA: 0x000DE941 File Offset: 0x000DCB41
		// (set) Token: 0x06005BC1 RID: 23489 RVA: 0x000DE96C File Offset: 0x000DCB6C
		public override EMechaTrackScoreDetectionType Type
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

		// Token: 0x04003740 RID: 14144
		[Nullable(2)]
		protected new IMechaTrackScoreTagDetection FbInstance;

		// Token: 0x04003741 RID: 14145
		[Nullable(2)]
		protected new IMechaTrackScoreTagDetection_SetValue PocoInterface;
	}
}
