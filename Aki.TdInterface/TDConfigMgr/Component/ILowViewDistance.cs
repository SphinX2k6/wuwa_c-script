using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200052F RID: 1327
	public class ILowViewDistance : IViewDistanceMode
	{
		// Token: 0x06001AB8 RID: 6840 RVA: 0x0004E58C File Offset: 0x0004C78C
		private ILowViewDistance_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILowViewDistance 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILowViewDistance_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILowViewDistance_SetValue());
			}
			return result;
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x0004E5C4 File Offset: 0x0004C7C4
		public static ILowViewDistance Create([Nullable(2)] ILowViewDistance instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILowViewDistance
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x0004E5D7 File Offset: 0x0004C7D7
		public static ILowViewDistance CreateFromSetValue([Nullable(2)] ILowViewDistance_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILowViewDistance
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x0004E5EA File Offset: 0x0004C7EA
		public new ILowViewDistance_SetValue ToSetValue()
		{
			return new ILowViewDistance_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x06001ABC RID: 6844 RVA: 0x0004E5FD File Offset: 0x0004C7FD
		// (set) Token: 0x06001ABD RID: 6845 RVA: 0x0004E628 File Offset: 0x0004C828
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

		// Token: 0x0400139F RID: 5023
		[Nullable(2)]
		protected new ILowViewDistance FbInstance;

		// Token: 0x040013A0 RID: 5024
		[Nullable(2)]
		protected new ILowViewDistance_SetValue PocoInterface;
	}
}
