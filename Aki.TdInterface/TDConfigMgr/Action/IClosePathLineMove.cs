using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A6D RID: 6765
	public class IClosePathLineMove : ICloseSplineMovePattern
	{
		// Token: 0x06008FBF RID: 36799 RVA: 0x00152818 File Offset: 0x00150A18
		private IClosePathLineMove_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClosePathLineMove 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClosePathLineMove_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClosePathLineMove_SetValue());
			}
			return result;
		}

		// Token: 0x06008FC0 RID: 36800 RVA: 0x00152850 File Offset: 0x00150A50
		public static IClosePathLineMove Create([Nullable(2)] IClosePathLineMove instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClosePathLineMove
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008FC1 RID: 36801 RVA: 0x00152863 File Offset: 0x00150A63
		public static IClosePathLineMove CreateFromSetValue([Nullable(2)] IClosePathLineMove_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClosePathLineMove
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008FC2 RID: 36802 RVA: 0x00152876 File Offset: 0x00150A76
		public new IClosePathLineMove_SetValue ToSetValue()
		{
			return new IClosePathLineMove_SetValue
			{
				Type = this.Type,
				GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity
			};
		}

		// Token: 0x17002E48 RID: 11848
		// (get) Token: 0x06008FC3 RID: 36803 RVA: 0x00152895 File Offset: 0x00150A95
		// (set) Token: 0x06008FC4 RID: 36804 RVA: 0x001528C0 File Offset: 0x00150AC0
		public override ESplineMovePattern Type
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

		// Token: 0x17002E49 RID: 11849
		// (get) Token: 0x06008FC5 RID: 36805 RVA: 0x001528D0 File Offset: 0x00150AD0
		// (set) Token: 0x06008FC6 RID: 36806 RVA: 0x0015290A File Offset: 0x00150B0A
		public override float? GravitySwitchAngularVelocity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GravitySwitchAngularVelocity;
				}
				IClosePathLineMove_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04005A0B RID: 23051
		[Nullable(2)]
		protected new IClosePathLineMove FbInstance;

		// Token: 0x04005A0C RID: 23052
		[Nullable(2)]
		protected new IClosePathLineMove_SetValue PocoInterface;
	}
}
