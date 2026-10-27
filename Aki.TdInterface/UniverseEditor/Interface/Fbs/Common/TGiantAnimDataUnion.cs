using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E7F RID: 24191
	public class TGiantAnimDataUnion
	{
		// Token: 0x1700B4D1 RID: 46289
		// (get) Token: 0x06029700 RID: 169728 RVA: 0x005ADC8E File Offset: 0x005ABE8E
		// (set) Token: 0x06029701 RID: 169729 RVA: 0x005ADC96 File Offset: 0x005ABE96
		public TGiantAnimData Type { get; set; }

		// Token: 0x1700B4D2 RID: 46290
		// (get) Token: 0x06029702 RID: 169730 RVA: 0x005ADC9F File Offset: 0x005ABE9F
		// (set) Token: 0x06029703 RID: 169731 RVA: 0x005ADCA7 File Offset: 0x005ABEA7
		public object Value { get; set; }

		// Token: 0x06029704 RID: 169732 RVA: 0x005ADCB0 File Offset: 0x005ABEB0
		public TGiantAnimDataUnion()
		{
			this.Type = TGiantAnimData.NONE;
			this.Value = null;
		}

		// Token: 0x06029705 RID: 169733 RVA: 0x005ADCC6 File Offset: 0x005ABEC6
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06029706 RID: 169734 RVA: 0x005ADCD8 File Offset: 0x005ABED8
		public IGiantIdleAnimDataT AsIGiantIdleAnimData()
		{
			return this.As<IGiantIdleAnimDataT>();
		}

		// Token: 0x06029707 RID: 169735 RVA: 0x005ADCE0 File Offset: 0x005ABEE0
		public static TGiantAnimDataUnion FromIGiantIdleAnimData(IGiantIdleAnimDataT _igiantidleanimdata)
		{
			return new TGiantAnimDataUnion
			{
				Type = TGiantAnimData.IGiantIdleAnimData,
				Value = _igiantidleanimdata
			};
		}

		// Token: 0x06029708 RID: 169736 RVA: 0x005ADCF5 File Offset: 0x005ABEF5
		public IGiantSpecialAnimDataT AsIGiantSpecialAnimData()
		{
			return this.As<IGiantSpecialAnimDataT>();
		}

		// Token: 0x06029709 RID: 169737 RVA: 0x005ADCFD File Offset: 0x005ABEFD
		public static TGiantAnimDataUnion FromIGiantSpecialAnimData(IGiantSpecialAnimDataT _igiantspecialanimdata)
		{
			return new TGiantAnimDataUnion
			{
				Type = TGiantAnimData.IGiantSpecialAnimData,
				Value = _igiantspecialanimdata
			};
		}

		// Token: 0x0602970A RID: 169738 RVA: 0x005ADD14 File Offset: 0x005ABF14
		public static int Pack(FlatBufferBuilder builder, TGiantAnimDataUnion _o)
		{
			TGiantAnimData type = _o.Type;
			if (type == TGiantAnimData.IGiantIdleAnimData)
			{
				return IGiantIdleAnimData.Pack(builder, _o.AsIGiantIdleAnimData()).Value;
			}
			if (type != TGiantAnimData.IGiantSpecialAnimData)
			{
				return 0;
			}
			return IGiantSpecialAnimData.Pack(builder, _o.AsIGiantSpecialAnimData()).Value;
		}
	}
}
