using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DB0 RID: 7600
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(IResetPosByResetPointConverter))]
	public class IResetPosByResetPoint : IResetPosType
	{
		// Token: 0x0600A2D5 RID: 41685 RVA: 0x001721E4 File Offset: 0x001703E4
		private IResetPosByResetPoint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IResetPosByResetPoint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IResetPosByResetPoint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IResetPosByResetPoint_SetValue());
			}
			return result;
		}

		// Token: 0x0600A2D6 RID: 41686 RVA: 0x0017221C File Offset: 0x0017041C
		public static IResetPosByResetPoint Create([Nullable(2)] IResetPosByResetPoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IResetPosByResetPoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A2D7 RID: 41687 RVA: 0x0017222F File Offset: 0x0017042F
		public static IResetPosByResetPoint CreateFromSetValue([Nullable(2)] IResetPosByResetPoint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IResetPosByResetPoint
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A2D8 RID: 41688 RVA: 0x00172242 File Offset: 0x00170442
		public new IResetPosByResetPoint_SetValue ToSetValue()
		{
			return new IResetPosByResetPoint_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003239 RID: 12857
		// (get) Token: 0x0600A2D9 RID: 41689 RVA: 0x00172255 File Offset: 0x00170455
		// (set) Token: 0x0600A2DA RID: 41690 RVA: 0x00172280 File Offset: 0x00170480
		public override EResetPosType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EResetPosType.PosEntity;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040061BE RID: 25022
		[Nullable(2)]
		protected new IResetPosByResetPoint FbInstance;

		// Token: 0x040061BF RID: 25023
		[Nullable(2)]
		protected new IResetPosByResetPoint_SetValue PocoInterface;
	}
}
