using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001133 RID: 4403
	public class IMechaTrackScoreDetectionType
	{
		// Token: 0x06006176 RID: 24950 RVA: 0x000EB0A4 File Offset: 0x000E92A4
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

		// Token: 0x06006177 RID: 24951 RVA: 0x000EB0DC File Offset: 0x000E92DC
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

		// Token: 0x06006178 RID: 24952 RVA: 0x000EB0EF File Offset: 0x000E92EF
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

		// Token: 0x06006179 RID: 24953 RVA: 0x000EB102 File Offset: 0x000E9302
		public IMechaTrackScoreDetectionType_SetValue ToSetValue()
		{
			return new IMechaTrackScoreDetectionType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001FEB RID: 8171
		// (get) Token: 0x0600617A RID: 24954 RVA: 0x000EB115 File Offset: 0x000E9315
		// (set) Token: 0x0600617B RID: 24955 RVA: 0x000EB140 File Offset: 0x000E9340
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

		// Token: 0x04003A65 RID: 14949
		[Nullable(2)]
		protected IMechaTrackScoreDetectionType FbInstance;

		// Token: 0x04003A66 RID: 14950
		[Nullable(2)]
		protected IMechaTrackScoreDetectionType_SetValue PocoInterface;
	}
}
