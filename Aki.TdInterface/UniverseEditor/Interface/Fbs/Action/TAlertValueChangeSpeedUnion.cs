using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E50 RID: 32336
	public class TAlertValueChangeSpeedUnion
	{
		// Token: 0x1700F1FD RID: 61949
		// (get) Token: 0x0603A6BD RID: 239293 RVA: 0x007DDDD2 File Offset: 0x007DBFD2
		// (set) Token: 0x0603A6BE RID: 239294 RVA: 0x007DDDDA File Offset: 0x007DBFDA
		public TAlertValueChangeSpeed Type { get; set; }

		// Token: 0x1700F1FE RID: 61950
		// (get) Token: 0x0603A6BF RID: 239295 RVA: 0x007DDDE3 File Offset: 0x007DBFE3
		// (set) Token: 0x0603A6C0 RID: 239296 RVA: 0x007DDDEB File Offset: 0x007DBFEB
		public object Value { get; set; }

		// Token: 0x0603A6C1 RID: 239297 RVA: 0x007DDDF4 File Offset: 0x007DBFF4
		public TAlertValueChangeSpeedUnion()
		{
			this.Type = TAlertValueChangeSpeed.NONE;
			this.Value = null;
		}

		// Token: 0x0603A6C2 RID: 239298 RVA: 0x007DDE0A File Offset: 0x007DC00A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A6C3 RID: 239299 RVA: 0x007DDE1C File Offset: 0x007DC01C
		public IAddOrSubAlertValueChangeSpeedT AsIAddOrSubAlertValueChangeSpeed()
		{
			return this.As<IAddOrSubAlertValueChangeSpeedT>();
		}

		// Token: 0x0603A6C4 RID: 239300 RVA: 0x007DDE24 File Offset: 0x007DC024
		public static TAlertValueChangeSpeedUnion FromIAddOrSubAlertValueChangeSpeed(IAddOrSubAlertValueChangeSpeedT _iaddorsubalertvaluechangespeed)
		{
			return new TAlertValueChangeSpeedUnion
			{
				Type = TAlertValueChangeSpeed.IAddOrSubAlertValueChangeSpeed,
				Value = _iaddorsubalertvaluechangespeed
			};
		}

		// Token: 0x0603A6C5 RID: 239301 RVA: 0x007DDE39 File Offset: 0x007DC039
		public ICustomAlertValueChangeSpeedT AsICustomAlertValueChangeSpeed()
		{
			return this.As<ICustomAlertValueChangeSpeedT>();
		}

		// Token: 0x0603A6C6 RID: 239302 RVA: 0x007DDE41 File Offset: 0x007DC041
		public static TAlertValueChangeSpeedUnion FromICustomAlertValueChangeSpeed(ICustomAlertValueChangeSpeedT _icustomalertvaluechangespeed)
		{
			return new TAlertValueChangeSpeedUnion
			{
				Type = TAlertValueChangeSpeed.ICustomAlertValueChangeSpeed,
				Value = _icustomalertvaluechangespeed
			};
		}

		// Token: 0x0603A6C7 RID: 239303 RVA: 0x007DDE58 File Offset: 0x007DC058
		public static int Pack(FlatBufferBuilder builder, TAlertValueChangeSpeedUnion _o)
		{
			TAlertValueChangeSpeed type = _o.Type;
			if (type == TAlertValueChangeSpeed.IAddOrSubAlertValueChangeSpeed)
			{
				return IAddOrSubAlertValueChangeSpeed.Pack(builder, _o.AsIAddOrSubAlertValueChangeSpeed()).Value;
			}
			if (type != TAlertValueChangeSpeed.ICustomAlertValueChangeSpeed)
			{
				return 0;
			}
			return ICustomAlertValueChangeSpeed.Pack(builder, _o.AsICustomAlertValueChangeSpeed()).Value;
		}
	}
}
