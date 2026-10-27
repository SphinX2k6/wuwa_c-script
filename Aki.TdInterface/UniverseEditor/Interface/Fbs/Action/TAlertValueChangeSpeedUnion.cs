using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007642 RID: 30274
	public class TAlertValueChangeSpeedUnion
	{
		// Token: 0x1700E5BF RID: 58815
		// (get) Token: 0x06037218 RID: 225816 RVA: 0x00779CD6 File Offset: 0x00777ED6
		// (set) Token: 0x06037219 RID: 225817 RVA: 0x00779CDE File Offset: 0x00777EDE
		public TAlertValueChangeSpeed Type { get; set; }

		// Token: 0x1700E5C0 RID: 58816
		// (get) Token: 0x0603721A RID: 225818 RVA: 0x00779CE7 File Offset: 0x00777EE7
		// (set) Token: 0x0603721B RID: 225819 RVA: 0x00779CEF File Offset: 0x00777EEF
		public object Value { get; set; }

		// Token: 0x0603721C RID: 225820 RVA: 0x00779CF8 File Offset: 0x00777EF8
		public TAlertValueChangeSpeedUnion()
		{
			this.Type = TAlertValueChangeSpeed.NONE;
			this.Value = null;
		}

		// Token: 0x0603721D RID: 225821 RVA: 0x00779D0E File Offset: 0x00777F0E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603721E RID: 225822 RVA: 0x00779D20 File Offset: 0x00777F20
		public IAddOrSubAlertValueChangeSpeedT AsIAddOrSubAlertValueChangeSpeed()
		{
			return this.As<IAddOrSubAlertValueChangeSpeedT>();
		}

		// Token: 0x0603721F RID: 225823 RVA: 0x00779D28 File Offset: 0x00777F28
		public static TAlertValueChangeSpeedUnion FromIAddOrSubAlertValueChangeSpeed(IAddOrSubAlertValueChangeSpeedT _iaddorsubalertvaluechangespeed)
		{
			return new TAlertValueChangeSpeedUnion
			{
				Type = TAlertValueChangeSpeed.IAddOrSubAlertValueChangeSpeed,
				Value = _iaddorsubalertvaluechangespeed
			};
		}

		// Token: 0x06037220 RID: 225824 RVA: 0x00779D3D File Offset: 0x00777F3D
		public ICustomAlertValueChangeSpeedT AsICustomAlertValueChangeSpeed()
		{
			return this.As<ICustomAlertValueChangeSpeedT>();
		}

		// Token: 0x06037221 RID: 225825 RVA: 0x00779D45 File Offset: 0x00777F45
		public static TAlertValueChangeSpeedUnion FromICustomAlertValueChangeSpeed(ICustomAlertValueChangeSpeedT _icustomalertvaluechangespeed)
		{
			return new TAlertValueChangeSpeedUnion
			{
				Type = TAlertValueChangeSpeed.ICustomAlertValueChangeSpeed,
				Value = _icustomalertvaluechangespeed
			};
		}

		// Token: 0x06037222 RID: 225826 RVA: 0x00779D5C File Offset: 0x00777F5C
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
