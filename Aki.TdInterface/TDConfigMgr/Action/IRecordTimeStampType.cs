using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D8A RID: 7562
	[NullableContext(1)]
	[Nullable(0)]
	public class IRecordTimeStampType : IDungeonEventType
	{
		// Token: 0x0600A217 RID: 41495 RVA: 0x00170D98 File Offset: 0x0016EF98
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

		// Token: 0x0600A218 RID: 41496 RVA: 0x00170DD0 File Offset: 0x0016EFD0
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

		// Token: 0x0600A219 RID: 41497 RVA: 0x00170DE3 File Offset: 0x0016EFE3
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

		// Token: 0x0600A21A RID: 41498 RVA: 0x00170DF6 File Offset: 0x0016EFF6
		public new IRecordTimeStampType_SetValue ToSetValue()
		{
			return new IRecordTimeStampType_SetValue
			{
				Type = this.Type,
				TimeStampType = this.TimeStampType
			};
		}

		// Token: 0x17003213 RID: 12819
		// (get) Token: 0x0600A21B RID: 41499 RVA: 0x00170E15 File Offset: 0x0016F015
		// (set) Token: 0x0600A21C RID: 41500 RVA: 0x00170E40 File Offset: 0x0016F040
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

		// Token: 0x17003214 RID: 12820
		// (get) Token: 0x0600A21D RID: 41501 RVA: 0x00170E4E File Offset: 0x0016F04E
		// (set) Token: 0x0600A21E RID: 41502 RVA: 0x00170E79 File Offset: 0x0016F079
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

		// Token: 0x04006168 RID: 24936
		[Nullable(2)]
		protected new IRecordTimeStampType FbInstance;

		// Token: 0x04006169 RID: 24937
		[Nullable(2)]
		protected new IRecordTimeStampType_SetValue PocoInterface;
	}
}
