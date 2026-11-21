using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012D2 RID: 4818
	public class ITetrisPlayModeNormal : ITetrisPlayModeBase
	{
		// Token: 0x06006C7D RID: 27773 RVA: 0x00102A7C File Offset: 0x00100C7C
		private ITetrisPlayModeNormal_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITetrisPlayModeNormal 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITetrisPlayModeNormal_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITetrisPlayModeNormal_SetValue());
			}
			return result;
		}

		// Token: 0x06006C7E RID: 27774 RVA: 0x00102AB4 File Offset: 0x00100CB4
		public static ITetrisPlayModeNormal Create([Nullable(2)] ITetrisPlayModeNormal instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITetrisPlayModeNormal
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006C7F RID: 27775 RVA: 0x00102AC7 File Offset: 0x00100CC7
		public static ITetrisPlayModeNormal CreateFromSetValue([Nullable(2)] ITetrisPlayModeNormal_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITetrisPlayModeNormal
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006C80 RID: 27776 RVA: 0x00102ADA File Offset: 0x00100CDA
		public new ITetrisPlayModeNormal_SetValue ToSetValue()
		{
			return new ITetrisPlayModeNormal_SetValue
			{
				Type = this.Type,
				Time = this.Time
			};
		}

		// Token: 0x17002303 RID: 8963
		// (get) Token: 0x06006C81 RID: 27777 RVA: 0x00102AF9 File Offset: 0x00100CF9
		// (set) Token: 0x06006C82 RID: 27778 RVA: 0x00102B24 File Offset: 0x00100D24
		public override ETetrisPlayMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETetrisPlayMode.Normal;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002304 RID: 8964
		// (get) Token: 0x06006C83 RID: 27779 RVA: 0x00102B32 File Offset: 0x00100D32
		// (set) Token: 0x06006C84 RID: 27780 RVA: 0x00102B5D File Offset: 0x00100D5D
		public virtual int Time
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Time;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Time;
			}
			set
			{
				this.GetOrCreatePoco().Time = value;
			}
		}

		// Token: 0x040040C7 RID: 16583
		[Nullable(2)]
		protected new ITetrisPlayModeNormal FbInstance;

		// Token: 0x040040C8 RID: 16584
		[Nullable(2)]
		protected new ITetrisPlayModeNormal_SetValue PocoInterface;
	}
}
