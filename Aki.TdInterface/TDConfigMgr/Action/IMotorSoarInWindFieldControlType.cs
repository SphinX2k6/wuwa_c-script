using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C26 RID: 7206
	[NullableContext(1)]
	[Nullable(0)]
	public class IMotorSoarInWindFieldControlType
	{
		// Token: 0x06009A99 RID: 39577 RVA: 0x001637D4 File Offset: 0x001619D4
		private IMotorSoarInWindFieldControlType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMotorSoarInWindFieldControlType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMotorSoarInWindFieldControlType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMotorSoarInWindFieldControlType_SetValue());
			}
			return result;
		}

		// Token: 0x06009A9A RID: 39578 RVA: 0x0016380C File Offset: 0x00161A0C
		public static IMotorSoarInWindFieldControlType Create([Nullable(2)] IMotorSoarInWindFieldControlType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorSoarInWindFieldControlType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009A9B RID: 39579 RVA: 0x0016381F File Offset: 0x00161A1F
		public static IMotorSoarInWindFieldControlType CreateFromSetValue([Nullable(2)] IMotorSoarInWindFieldControlType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMotorSoarInWindFieldControlType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009A9C RID: 39580 RVA: 0x00163832 File Offset: 0x00161A32
		public IMotorSoarInWindFieldControlType_SetValue ToSetValue()
		{
			return new IMotorSoarInWindFieldControlType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700306A RID: 12394
		// (get) Token: 0x06009A9D RID: 39581 RVA: 0x00163845 File Offset: 0x00161A45
		// (set) Token: 0x06009A9E RID: 39582 RVA: 0x00163870 File Offset: 0x00161A70
		public virtual EMotorSoarInWindFieldControlType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMotorSoarInWindFieldControlType.EnterWindField;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005E01 RID: 24065
		[Nullable(2)]
		protected IMotorSoarInWindFieldControlType FbInstance;

		// Token: 0x04005E02 RID: 24066
		[Nullable(2)]
		protected IMotorSoarInWindFieldControlType_SetValue PocoInterface;
	}
}
