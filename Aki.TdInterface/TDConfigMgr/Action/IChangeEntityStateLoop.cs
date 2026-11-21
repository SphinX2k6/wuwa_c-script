using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019FB RID: 6651
	public class IChangeEntityStateLoop : ChangeEntityState
	{
		// Token: 0x06008D95 RID: 36245 RVA: 0x0014ED4C File Offset: 0x0014CF4C
		private IChangeEntityStateLoop_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IChangeEntityStateLoop 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IChangeEntityStateLoop_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IChangeEntityStateLoop_SetValue());
			}
			return result;
		}

		// Token: 0x06008D96 RID: 36246 RVA: 0x0014ED84 File Offset: 0x0014CF84
		public static IChangeEntityStateLoop Create([Nullable(2)] IChangeEntityStateLoop instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChangeEntityStateLoop
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008D97 RID: 36247 RVA: 0x0014ED97 File Offset: 0x0014CF97
		public static IChangeEntityStateLoop CreateFromSetValue([Nullable(2)] IChangeEntityStateLoop_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IChangeEntityStateLoop
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008D98 RID: 36248 RVA: 0x0014EDAA File Offset: 0x0014CFAA
		public new IChangeEntityStateLoop_SetValue ToSetValue()
		{
			return new IChangeEntityStateLoop_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				Circulation = this.Circulation
			};
		}

		// Token: 0x17002DDE RID: 11742
		// (get) Token: 0x06008D99 RID: 36249 RVA: 0x0014EDD5 File Offset: 0x0014CFD5
		// (set) Token: 0x06008D9A RID: 36250 RVA: 0x0014EE00 File Offset: 0x0014D000
		public override EChangeEntityState Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EChangeEntityState.Directly;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002DDF RID: 11743
		// (get) Token: 0x06008D9B RID: 36251 RVA: 0x0014EE0E File Offset: 0x0014D00E
		// (set) Token: 0x06008D9C RID: 36252 RVA: 0x0014EE39 File Offset: 0x0014D039
		public override int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x17002DE0 RID: 11744
		// (get) Token: 0x06008D9D RID: 36253 RVA: 0x0014EE47 File Offset: 0x0014D047
		// (set) Token: 0x06008D9E RID: 36254 RVA: 0x0014EE72 File Offset: 0x0014D072
		public virtual ELoopStateType Circulation
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Circulation;
				}
				if (this.PocoInterface == null)
				{
					return ELoopStateType.Prev;
				}
				return this.PocoInterface.Circulation;
			}
			set
			{
				this.GetOrCreatePoco().Circulation = value;
			}
		}

		// Token: 0x04005915 RID: 22805
		[Nullable(2)]
		protected new IChangeEntityStateLoop FbInstance;

		// Token: 0x04005916 RID: 22806
		[Nullable(2)]
		protected new IChangeEntityStateLoop_SetValue PocoInterface;
	}
}
