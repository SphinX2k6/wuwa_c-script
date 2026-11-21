using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A77 RID: 6775
	public class ICloseSplineMovePattern
	{
		// Token: 0x06008FF3 RID: 36851 RVA: 0x00152D84 File Offset: 0x00150F84
		private ICloseSplineMovePattern_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICloseSplineMovePattern 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICloseSplineMovePattern_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICloseSplineMovePattern_SetValue());
			}
			return result;
		}

		// Token: 0x06008FF4 RID: 36852 RVA: 0x00152DBC File Offset: 0x00150FBC
		public static ICloseSplineMovePattern Create([Nullable(2)] ICloseSplineMovePattern instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseSplineMovePattern
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008FF5 RID: 36853 RVA: 0x00152DCF File Offset: 0x00150FCF
		public static ICloseSplineMovePattern CreateFromSetValue([Nullable(2)] ICloseSplineMovePattern_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICloseSplineMovePattern
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008FF6 RID: 36854 RVA: 0x00152DE2 File Offset: 0x00150FE2
		public ICloseSplineMovePattern_SetValue ToSetValue()
		{
			return new ICloseSplineMovePattern_SetValue
			{
				Type = this.Type,
				GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity
			};
		}

		// Token: 0x17002E53 RID: 11859
		// (get) Token: 0x06008FF7 RID: 36855 RVA: 0x00152E01 File Offset: 0x00151001
		// (set) Token: 0x06008FF8 RID: 36856 RVA: 0x00152E2C File Offset: 0x0015102C
		public virtual ESplineMovePattern Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESplineMovePattern.PathLine;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002E54 RID: 11860
		// (get) Token: 0x06008FF9 RID: 36857 RVA: 0x00152E3C File Offset: 0x0015103C
		// (set) Token: 0x06008FFA RID: 36858 RVA: 0x00152E76 File Offset: 0x00151076
		public virtual float? GravitySwitchAngularVelocity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GravitySwitchAngularVelocity;
				}
				ICloseSplineMovePattern_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.GravitySwitchAngularVelocity;
			}
			set
			{
				this.GetOrCreatePoco().GravitySwitchAngularVelocity = value;
			}
		}

		// Token: 0x04005A20 RID: 23072
		[Nullable(2)]
		protected ICloseSplineMovePattern FbInstance;

		// Token: 0x04005A21 RID: 23073
		[Nullable(2)]
		protected ICloseSplineMovePattern_SetValue PocoInterface;
	}
}
