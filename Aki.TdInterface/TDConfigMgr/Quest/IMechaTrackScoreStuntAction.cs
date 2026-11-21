using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001139 RID: 4409
	public class IMechaTrackScoreStuntAction : IMechaTrackScoreDetectionType
	{
		// Token: 0x06006194 RID: 24980 RVA: 0x000EB454 File Offset: 0x000E9654
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

		// Token: 0x06006195 RID: 24981 RVA: 0x000EB48C File Offset: 0x000E968C
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

		// Token: 0x06006196 RID: 24982 RVA: 0x000EB49F File Offset: 0x000E969F
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

		// Token: 0x06006197 RID: 24983 RVA: 0x000EB4B2 File Offset: 0x000E96B2
		public new IMechaTrackScoreStuntAction_SetValue ToSetValue()
		{
			return new IMechaTrackScoreStuntAction_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001FF1 RID: 8177
		// (get) Token: 0x06006198 RID: 24984 RVA: 0x000EB4C5 File Offset: 0x000E96C5
		// (set) Token: 0x06006199 RID: 24985 RVA: 0x000EB4F0 File Offset: 0x000E96F0
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

		// Token: 0x04003A75 RID: 14965
		[Nullable(2)]
		protected new IMechaTrackScoreStuntAction FbInstance;

		// Token: 0x04003A76 RID: 14966
		[Nullable(2)]
		protected new IMechaTrackScoreStuntAction_SetValue PocoInterface;
	}
}
