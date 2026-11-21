using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E51 RID: 7761
	public class INewSplineMoveType
	{
		// Token: 0x0600A501 RID: 42241 RVA: 0x001789B0 File Offset: 0x00176BB0
		private INewSplineMoveType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INewSplineMoveType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INewSplineMoveType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INewSplineMoveType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A502 RID: 42242 RVA: 0x001789E8 File Offset: 0x00176BE8
		public static INewSplineMoveType Create([Nullable(2)] INewSplineMoveType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INewSplineMoveType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A503 RID: 42243 RVA: 0x001789FB File Offset: 0x00176BFB
		public static INewSplineMoveType CreateFromSetValue([Nullable(2)] INewSplineMoveType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INewSplineMoveType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A504 RID: 42244 RVA: 0x00178A0E File Offset: 0x00176C0E
		public INewSplineMoveType_SetValue ToSetValue()
		{
			return new INewSplineMoveType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003315 RID: 13077
		// (get) Token: 0x0600A505 RID: 42245 RVA: 0x00178A21 File Offset: 0x00176C21
		// (set) Token: 0x0600A506 RID: 42246 RVA: 0x00178A4C File Offset: 0x00176C4C
		public virtual ENewSplineMoveType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENewSplineMoveType.FrontAxleTracking;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040063B8 RID: 25528
		[Nullable(2)]
		protected INewSplineMoveType FbInstance;

		// Token: 0x040063B9 RID: 25529
		[Nullable(2)]
		protected INewSplineMoveType_SetValue PocoInterface;
	}
}
