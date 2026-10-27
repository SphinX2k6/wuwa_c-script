using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200100D RID: 4109
	[NullableContext(1)]
	[Nullable(0)]
	public class IMechaTrackScoreStuntAction : IMechaTrackScoreDetectionType
	{
		// Token: 0x06005BB4 RID: 23476 RVA: 0x000DE814 File Offset: 0x000DCA14
		private IMechaTrackScoreStuntAction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMechaTrackScoreStuntAction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMechaTrackScoreStuntAction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMechaTrackScoreStuntAction_SetValue());
			}
			return result;
		}

		// Token: 0x06005BB5 RID: 23477 RVA: 0x000DE84C File Offset: 0x000DCA4C
		public static IMechaTrackScoreStuntAction Create([Nullable(2)] IMechaTrackScoreStuntAction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechaTrackScoreStuntAction
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005BB6 RID: 23478 RVA: 0x000DE85F File Offset: 0x000DCA5F
		public static IMechaTrackScoreStuntAction CreateFromSetValue([Nullable(2)] IMechaTrackScoreStuntAction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMechaTrackScoreStuntAction
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005BB7 RID: 23479 RVA: 0x000DE872 File Offset: 0x000DCA72
		public new IMechaTrackScoreStuntAction_SetValue ToSetValue()
		{
			return new IMechaTrackScoreStuntAction_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001E48 RID: 7752
		// (get) Token: 0x06005BB8 RID: 23480 RVA: 0x000DE885 File Offset: 0x000DCA85
		// (set) Token: 0x06005BB9 RID: 23481 RVA: 0x000DE8B0 File Offset: 0x000DCAB0
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

		// Token: 0x0400373D RID: 14141
		[Nullable(2)]
		protected new IMechaTrackScoreStuntAction FbInstance;

		// Token: 0x0400373E RID: 14142
		[Nullable(2)]
		protected new IMechaTrackScoreStuntAction_SetValue PocoInterface;
	}
}
