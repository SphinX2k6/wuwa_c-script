using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E6B RID: 7787
	[NullableContext(1)]
	[Nullable(0)]
	public class ISignalBreakGameplay : IUiGame
	{
		// Token: 0x0600A6AC RID: 42668 RVA: 0x00179178 File Offset: 0x00177378
		private ISignalBreakGameplay_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISignalBreakGameplay 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISignalBreakGameplay_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISignalBreakGameplay_SetValue());
			}
			return result;
		}

		// Token: 0x0600A6AD RID: 42669 RVA: 0x001791B0 File Offset: 0x001773B0
		public static ISignalBreakGameplay Create([Nullable(2)] ISignalBreakGameplay instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISignalBreakGameplay
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A6AE RID: 42670 RVA: 0x001791C3 File Offset: 0x001773C3
		public static ISignalBreakGameplay CreateFromSetValue([Nullable(2)] ISignalBreakGameplay_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISignalBreakGameplay
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A6AF RID: 42671 RVA: 0x001791D6 File Offset: 0x001773D6
		public new ISignalBreakGameplay_SetValue ToSetValue()
		{
			return new ISignalBreakGameplay_SetValue
			{
				Type = this.Type,
				SignalBreakId = this.SignalBreakId
			};
		}

		// Token: 0x1700330D RID: 13069
		// (get) Token: 0x0600A6B0 RID: 42672 RVA: 0x001791F5 File Offset: 0x001773F5
		// (set) Token: 0x0600A6B1 RID: 42673 RVA: 0x00179220 File Offset: 0x00177420
		public override ESimpleGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESimpleGameplayType.Cipher;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700330E RID: 13070
		// (get) Token: 0x0600A6B2 RID: 42674 RVA: 0x0017922E File Offset: 0x0017742E
		// (set) Token: 0x0600A6B3 RID: 42675 RVA: 0x00179259 File Offset: 0x00177459
		public virtual string SignalBreakId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SignalBreakId;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.SignalBreakId;
			}
			set
			{
				this.GetOrCreatePoco().SignalBreakId = value;
			}
		}

		// Token: 0x0400638A RID: 25482
		[Nullable(2)]
		protected new ISignalBreakGameplay FbInstance;

		// Token: 0x0400638B RID: 25483
		[Nullable(2)]
		protected new ISignalBreakGameplay_SetValue PocoInterface;
	}
}
