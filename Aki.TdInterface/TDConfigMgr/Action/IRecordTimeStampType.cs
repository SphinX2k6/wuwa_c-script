using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F9B RID: 8091
	public class IRecordTimeStampType : IDungeonEventType
	{
		// Token: 0x0600AC03 RID: 44035 RVA: 0x001851BC File Offset: 0x001833BC
		private IRecordTimeStampType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRecordTimeStampType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRecordTimeStampType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRecordTimeStampType_SetValue());
			}
			return result;
		}

		// Token: 0x0600AC04 RID: 44036 RVA: 0x001851F4 File Offset: 0x001833F4
		public static IRecordTimeStampType Create([Nullable(2)] IRecordTimeStampType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRecordTimeStampType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AC05 RID: 44037 RVA: 0x00185207 File Offset: 0x00183407
		public static IRecordTimeStampType CreateFromSetValue([Nullable(2)] IRecordTimeStampType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRecordTimeStampType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AC06 RID: 44038 RVA: 0x0018521A File Offset: 0x0018341A
		public new IRecordTimeStampType_SetValue ToSetValue()
		{
			return new IRecordTimeStampType_SetValue
			{
				Type = this.Type,
				TimeStampType = this.TimeStampType
			};
		}

		// Token: 0x170034A7 RID: 13479
		// (get) Token: 0x0600AC07 RID: 44039 RVA: 0x00185239 File Offset: 0x00183439
		// (set) Token: 0x0600AC08 RID: 44040 RVA: 0x00185264 File Offset: 0x00183464
		public override EDungeonEventType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDungeonEventType.RecordTimeStamp;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170034A8 RID: 13480
		// (get) Token: 0x0600AC09 RID: 44041 RVA: 0x00185272 File Offset: 0x00183472
		// (set) Token: 0x0600AC0A RID: 44042 RVA: 0x0018529D File Offset: 0x0018349D
		public virtual ETimeStampType TimeStampType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TimeStampType;
				}
				if (this.PocoInterface == null)
				{
					return ETimeStampType.DungeonBegin;
				}
				return this.PocoInterface.TimeStampType;
			}
			set
			{
				this.GetOrCreatePoco().TimeStampType = value;
			}
		}

		// Token: 0x040066E4 RID: 26340
		[Nullable(2)]
		protected new IRecordTimeStampType FbInstance;

		// Token: 0x040066E5 RID: 26341
		[Nullable(2)]
		protected new IRecordTimeStampType_SetValue PocoInterface;
	}
}
