using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042F7 RID: 17143
	public class TProgressBarLeftTypeUnion
	{
		// Token: 0x1700795C RID: 31068
		// (get) Token: 0x060196C5 RID: 104133 RVA: 0x003A529A File Offset: 0x003A349A
		// (set) Token: 0x060196C6 RID: 104134 RVA: 0x003A52A2 File Offset: 0x003A34A2
		public TProgressBarLeftType Type { get; set; }

		// Token: 0x1700795D RID: 31069
		// (get) Token: 0x060196C7 RID: 104135 RVA: 0x003A52AB File Offset: 0x003A34AB
		// (set) Token: 0x060196C8 RID: 104136 RVA: 0x003A52B3 File Offset: 0x003A34B3
		public object Value { get; set; }

		// Token: 0x060196C9 RID: 104137 RVA: 0x003A52BC File Offset: 0x003A34BC
		public TProgressBarLeftTypeUnion()
		{
			this.Type = TProgressBarLeftType.NONE;
			this.Value = null;
		}

		// Token: 0x060196CA RID: 104138 RVA: 0x003A52D2 File Offset: 0x003A34D2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060196CB RID: 104139 RVA: 0x003A52E4 File Offset: 0x003A34E4
		public IUseCountT AsIUseCount()
		{
			return this.As<IUseCountT>();
		}

		// Token: 0x060196CC RID: 104140 RVA: 0x003A52EC File Offset: 0x003A34EC
		public static TProgressBarLeftTypeUnion FromIUseCount(IUseCountT _iusecount)
		{
			return new TProgressBarLeftTypeUnion
			{
				Type = TProgressBarLeftType.IUseCount,
				Value = _iusecount
			};
		}

		// Token: 0x060196CD RID: 104141 RVA: 0x003A5301 File Offset: 0x003A3501
		public IUseVarT AsIUseVar()
		{
			return this.As<IUseVarT>();
		}

		// Token: 0x060196CE RID: 104142 RVA: 0x003A5309 File Offset: 0x003A3509
		public static TProgressBarLeftTypeUnion FromIUseVar(IUseVarT _iusevar)
		{
			return new TProgressBarLeftTypeUnion
			{
				Type = TProgressBarLeftType.IUseVar,
				Value = _iusevar
			};
		}

		// Token: 0x060196CF RID: 104143 RVA: 0x003A5320 File Offset: 0x003A3520
		public static int Pack(FlatBufferBuilder builder, TProgressBarLeftTypeUnion _o)
		{
			TProgressBarLeftType type = _o.Type;
			if (type == TProgressBarLeftType.IUseCount)
			{
				return IUseCount.Pack(builder, _o.AsIUseCount()).Value;
			}
			if (type != TProgressBarLeftType.IUseVar)
			{
				return 0;
			}
			return IUseVar.Pack(builder, _o.AsIUseVar()).Value;
		}
	}
}
