using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019BE RID: 6590
	[NullableContext(1)]
	[Nullable(0)]
	public class IDollGrabShowcase : IUiGame
	{
		// Token: 0x06008D2F RID: 36143 RVA: 0x0014AF90 File Offset: 0x00149190
		private IDollGrabShowcase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDollGrabShowcase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDollGrabShowcase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDollGrabShowcase_SetValue());
			}
			return result;
		}

		// Token: 0x06008D30 RID: 36144 RVA: 0x0014AFC8 File Offset: 0x001491C8
		public static IDollGrabShowcase Create([Nullable(2)] IDollGrabShowcase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDollGrabShowcase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008D31 RID: 36145 RVA: 0x0014AFDB File Offset: 0x001491DB
		public static IDollGrabShowcase CreateFromSetValue([Nullable(2)] IDollGrabShowcase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDollGrabShowcase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008D32 RID: 36146 RVA: 0x0014AFEE File Offset: 0x001491EE
		public new IDollGrabShowcase_SetValue ToSetValue()
		{
			return new IDollGrabShowcase_SetValue
			{
				Type = this.Type,
				ShowcaseEntityId = this.ShowcaseEntityId
			};
		}

		// Token: 0x17002D4F RID: 11599
		// (get) Token: 0x06008D33 RID: 36147 RVA: 0x0014B00D File Offset: 0x0014920D
		// (set) Token: 0x06008D34 RID: 36148 RVA: 0x0014B038 File Offset: 0x00149238
		public override ESimpleGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESimpleGameplayType.Cipher;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002D50 RID: 11600
		// (get) Token: 0x06008D35 RID: 36149 RVA: 0x0014B046 File Offset: 0x00149246
		// (set) Token: 0x06008D36 RID: 36150 RVA: 0x0014B071 File Offset: 0x00149271
		public virtual int ShowcaseEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShowcaseEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ShowcaseEntityId;
			}
			set
			{
				this.GetOrCreatePoco().ShowcaseEntityId = value;
			}
		}

		// Token: 0x040057C2 RID: 22466
		[Nullable(2)]
		protected new IDollGrabShowcase FbInstance;

		// Token: 0x040057C3 RID: 22467
		[Nullable(2)]
		protected new IDollGrabShowcase_SetValue PocoInterface;
	}
}
