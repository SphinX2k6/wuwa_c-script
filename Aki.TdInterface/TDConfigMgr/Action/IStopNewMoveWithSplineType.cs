using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002104 RID: 8452
	public class IStopNewMoveWithSplineType
	{
		// Token: 0x0600B388 RID: 45960 RVA: 0x00192C98 File Offset: 0x00190E98
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

		// Token: 0x0600B389 RID: 45961 RVA: 0x00192CD0 File Offset: 0x00190ED0
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

		// Token: 0x0600B38A RID: 45962 RVA: 0x00192CE3 File Offset: 0x00190EE3
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

		// Token: 0x0600B38B RID: 45963 RVA: 0x00192CF6 File Offset: 0x00190EF6
		public IStopNewMoveWithSplineType_SetValue ToSetValue()
		{
			return new IStopNewMoveWithSplineType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700364D RID: 13901
		// (get) Token: 0x0600B38C RID: 45964 RVA: 0x00192D09 File Offset: 0x00190F09
		// (set) Token: 0x0600B38D RID: 45965 RVA: 0x00192D34 File Offset: 0x00190F34
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

		// Token: 0x04006A68 RID: 27240
		[Nullable(2)]
		protected IStopNewMoveWithSplineType FbInstance;

		// Token: 0x04006A69 RID: 27241
		[Nullable(2)]
		protected IStopNewMoveWithSplineType_SetValue PocoInterface;
	}
}
