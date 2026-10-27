using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200181E RID: 6174
	[NullableContext(1)]
	[Nullable(0)]
	public class IBubbleIndex : IFlowIndex
	{
		// Token: 0x0600847F RID: 33919 RVA: 0x0013B9B4 File Offset: 0x00139BB4
		private IBubbleIndex_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBubbleIndex 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBubbleIndex_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBubbleIndex_SetValue());
			}
			return result;
		}

		// Token: 0x06008480 RID: 33920 RVA: 0x0013B9EC File Offset: 0x00139BEC
		public static IBubbleIndex Create([Nullable(2)] IBubbleIndex instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBubbleIndex
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008481 RID: 33921 RVA: 0x0013B9FF File Offset: 0x00139BFF
		public static IBubbleIndex CreateFromSetValue([Nullable(2)] IBubbleIndex_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBubbleIndex
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008482 RID: 33922 RVA: 0x0013BA12 File Offset: 0x00139C12
		public new IBubbleIndex_SetValue ToSetValue()
		{
			return new IBubbleIndex_SetValue
			{
				FlowListName = this.FlowListName,
				FlowId = this.FlowId,
				StateId = this.StateId
			};
		}

		// Token: 0x17002B67 RID: 11111
		// (get) Token: 0x06008483 RID: 33923 RVA: 0x0013BA3D File Offset: 0x00139C3D
		// (set) Token: 0x06008484 RID: 33924 RVA: 0x0013BA68 File Offset: 0x00139C68
		public override string FlowListName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FlowListName;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.FlowListName;
			}
			set
			{
				this.GetOrCreatePoco().FlowListName = value;
			}
		}

		// Token: 0x17002B68 RID: 11112
		// (get) Token: 0x06008485 RID: 33925 RVA: 0x0013BA76 File Offset: 0x00139C76
		// (set) Token: 0x06008486 RID: 33926 RVA: 0x0013BAA1 File Offset: 0x00139CA1
		public override int FlowId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FlowId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.FlowId;
			}
			set
			{
				this.GetOrCreatePoco().FlowId = value;
			}
		}

		// Token: 0x17002B69 RID: 11113
		// (get) Token: 0x06008487 RID: 33927 RVA: 0x0013BAB0 File Offset: 0x00139CB0
		// (set) Token: 0x06008488 RID: 33928 RVA: 0x0013BAEA File Offset: 0x00139CEA
		public virtual int? StateId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StateId;
				}
				IBubbleIndex_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StateId;
			}
			set
			{
				this.GetOrCreatePoco().StateId = value;
			}
		}

		// Token: 0x040053D8 RID: 21464
		[Nullable(2)]
		protected new IBubbleIndex FbInstance;

		// Token: 0x040053D9 RID: 21465
		[Nullable(2)]
		protected new IBubbleIndex_SetValue PocoInterface;
	}
}
