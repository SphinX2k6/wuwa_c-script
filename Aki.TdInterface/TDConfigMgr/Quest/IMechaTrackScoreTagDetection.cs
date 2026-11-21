using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200113B RID: 4411
	public class IMechaTrackScoreTagDetection : IMechaTrackScoreDetectionType
	{
		// Token: 0x0600619C RID: 24988 RVA: 0x000EB510 File Offset: 0x000E9710
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

		// Token: 0x0600619D RID: 24989 RVA: 0x000EB548 File Offset: 0x000E9748
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

		// Token: 0x0600619E RID: 24990 RVA: 0x000EB55B File Offset: 0x000E975B
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

		// Token: 0x0600619F RID: 24991 RVA: 0x000EB56E File Offset: 0x000E976E
		public new IMechaTrackScoreTagDetection_SetValue ToSetValue()
		{
			return new IMechaTrackScoreTagDetection_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001FF2 RID: 8178
		// (get) Token: 0x060061A0 RID: 24992 RVA: 0x000EB581 File Offset: 0x000E9781
		// (set) Token: 0x060061A1 RID: 24993 RVA: 0x000EB5AC File Offset: 0x000E97AC
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

		// Token: 0x04003A78 RID: 14968
		[Nullable(2)]
		protected new IMechaTrackScoreTagDetection FbInstance;

		// Token: 0x04003A79 RID: 14969
		[Nullable(2)]
		protected new IMechaTrackScoreTagDetection_SetValue PocoInterface;
	}
}
