using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000557 RID: 1367
	public class IMidViewDistance : IViewDistanceMode
	{
		// Token: 0x06001BC0 RID: 7104 RVA: 0x00050CD4 File Offset: 0x0004EED4
		private IMidViewDistance_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMidViewDistance 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMidViewDistance_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMidViewDistance_SetValue());
			}
			return result;
		}

		// Token: 0x06001BC1 RID: 7105 RVA: 0x00050D0C File Offset: 0x0004EF0C
		public static IMidViewDistance Create([Nullable(2)] IMidViewDistance instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMidViewDistance
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001BC2 RID: 7106 RVA: 0x00050D1F File Offset: 0x0004EF1F
		public static IMidViewDistance CreateFromSetValue([Nullable(2)] IMidViewDistance_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMidViewDistance
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001BC3 RID: 7107 RVA: 0x00050D32 File Offset: 0x0004EF32
		public new IMidViewDistance_SetValue ToSetValue()
		{
			return new IMidViewDistance_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06001BC4 RID: 7108 RVA: 0x00050D45 File Offset: 0x0004EF45
		// (set) Token: 0x06001BC5 RID: 7109 RVA: 0x00050D70 File Offset: 0x0004EF70
		public override EViewDistanceType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EViewDistanceType.Low;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001447 RID: 5191
		[Nullable(2)]
		protected new IMidViewDistance FbInstance;

		// Token: 0x04001448 RID: 5192
		[Nullable(2)]
		protected new IMidViewDistance_SetValue PocoInterface;
	}
}
