using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B37 RID: 6967
	[NullableContext(1)]
	[Nullable(0)]
	public class IInstrumentBoardSize
	{
		// Token: 0x06009516 RID: 38166 RVA: 0x00158C60 File Offset: 0x00156E60
		private IInstrumentBoardSize_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInstrumentBoardSize 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInstrumentBoardSize_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInstrumentBoardSize_SetValue());
			}
			return result;
		}

		// Token: 0x06009517 RID: 38167 RVA: 0x00158C98 File Offset: 0x00156E98
		public static IInstrumentBoardSize Create([Nullable(2)] IInstrumentBoardSize instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInstrumentBoardSize
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009518 RID: 38168 RVA: 0x00158CAB File Offset: 0x00156EAB
		public static IInstrumentBoardSize CreateFromSetValue([Nullable(2)] IInstrumentBoardSize_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInstrumentBoardSize
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009519 RID: 38169 RVA: 0x00158CBE File Offset: 0x00156EBE
		public IInstrumentBoardSize_SetValue ToSetValue()
		{
			return new IInstrumentBoardSize_SetValue
			{
				X = this.X,
				Y = this.Y
			};
		}

		// Token: 0x17002F0E RID: 12046
		// (get) Token: 0x0600951A RID: 38170 RVA: 0x00158CDD File Offset: 0x00156EDD
		// (set) Token: 0x0600951B RID: 38171 RVA: 0x00158D08 File Offset: 0x00156F08
		public virtual int X
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.X;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.X;
			}
			set
			{
				this.GetOrCreatePoco().X = value;
			}
		}

		// Token: 0x17002F0F RID: 12047
		// (get) Token: 0x0600951C RID: 38172 RVA: 0x00158D16 File Offset: 0x00156F16
		// (set) Token: 0x0600951D RID: 38173 RVA: 0x00158D41 File Offset: 0x00156F41
		public virtual int Y
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Y;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Y;
			}
			set
			{
				this.GetOrCreatePoco().Y = value;
			}
		}

		// Token: 0x04005B43 RID: 23363
		[Nullable(2)]
		protected IInstrumentBoardSize FbInstance;

		// Token: 0x04005B44 RID: 23364
		[Nullable(2)]
		protected IInstrumentBoardSize_SetValue PocoInterface;
	}
}
