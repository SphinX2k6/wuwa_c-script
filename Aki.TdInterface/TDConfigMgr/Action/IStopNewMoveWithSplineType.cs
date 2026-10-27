using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001ECB RID: 7883
	[NullableContext(1)]
	[Nullable(0)]
	public class IStopNewMoveWithSplineType
	{
		// Token: 0x0600A8B6 RID: 43190 RVA: 0x0017CCA0 File Offset: 0x0017AEA0
		private IStopNewMoveWithSplineType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStopNewMoveWithSplineType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStopNewMoveWithSplineType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStopNewMoveWithSplineType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A8B7 RID: 43191 RVA: 0x0017CCD8 File Offset: 0x0017AED8
		public static IStopNewMoveWithSplineType Create([Nullable(2)] IStopNewMoveWithSplineType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStopNewMoveWithSplineType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A8B8 RID: 43192 RVA: 0x0017CCEB File Offset: 0x0017AEEB
		public static IStopNewMoveWithSplineType CreateFromSetValue([Nullable(2)] IStopNewMoveWithSplineType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStopNewMoveWithSplineType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A8B9 RID: 43193 RVA: 0x0017CCFE File Offset: 0x0017AEFE
		public IStopNewMoveWithSplineType_SetValue ToSetValue()
		{
			return new IStopNewMoveWithSplineType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003382 RID: 13186
		// (get) Token: 0x0600A8BA RID: 43194 RVA: 0x0017CD11 File Offset: 0x0017AF11
		// (set) Token: 0x0600A8BB RID: 43195 RVA: 0x0017CD3C File Offset: 0x0017AF3C
		public virtual EStopNewMoveWithSplineType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EStopNewMoveWithSplineType.StopAtCurrentPos;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006479 RID: 25721
		[Nullable(2)]
		protected IStopNewMoveWithSplineType FbInstance;

		// Token: 0x0400647A RID: 25722
		[Nullable(2)]
		protected IStopNewMoveWithSplineType_SetValue PocoInterface;
	}
}
