using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200211C RID: 8476
	public class ISubScreenTransition
	{
		// Token: 0x0600B3FE RID: 46078 RVA: 0x00193A00 File Offset: 0x00191C00
		private ISubScreenTransition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISubScreenTransition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISubScreenTransition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISubScreenTransition_SetValue());
			}
			return result;
		}

		// Token: 0x0600B3FF RID: 46079 RVA: 0x00193A38 File Offset: 0x00191C38
		public static ISubScreenTransition Create([Nullable(2)] ISubScreenTransition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubScreenTransition
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B400 RID: 46080 RVA: 0x00193A4B File Offset: 0x00191C4B
		public static ISubScreenTransition CreateFromSetValue([Nullable(2)] ISubScreenTransition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISubScreenTransition
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B401 RID: 46081 RVA: 0x00193A5E File Offset: 0x00191C5E
		public ISubScreenTransition_SetValue ToSetValue()
		{
			return new ISubScreenTransition_SetValue
			{
				TransitionDuration = this.TransitionDuration,
				TransitionCurve = this.TransitionCurve
			};
		}

		// Token: 0x17003664 RID: 13924
		// (get) Token: 0x0600B402 RID: 46082 RVA: 0x00193A7D File Offset: 0x00191C7D
		// (set) Token: 0x0600B403 RID: 46083 RVA: 0x00193AAC File Offset: 0x00191CAC
		public virtual float TransitionDuration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TransitionDuration;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.TransitionDuration;
			}
			set
			{
				this.GetOrCreatePoco().TransitionDuration = value;
			}
		}

		// Token: 0x17003665 RID: 13925
		// (get) Token: 0x0600B404 RID: 46084 RVA: 0x00193ABA File Offset: 0x00191CBA
		// (set) Token: 0x0600B405 RID: 46085 RVA: 0x00193AE5 File Offset: 0x00191CE5
		public virtual string TransitionCurve
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TransitionCurve;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TransitionCurve;
			}
			set
			{
				this.GetOrCreatePoco().TransitionCurve = value;
			}
		}

		// Token: 0x04006AA1 RID: 27297
		[Nullable(2)]
		protected ISubScreenTransition FbInstance;

		// Token: 0x04006AA2 RID: 27298
		[Nullable(2)]
		protected ISubScreenTransition_SetValue PocoInterface;
	}
}
