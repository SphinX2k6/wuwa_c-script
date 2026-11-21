using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004756 RID: 18262
	public class TProgressBarLeftTypeUnion
	{
		// Token: 0x17007F8F RID: 32655
		// (get) Token: 0x0601AE47 RID: 110151 RVA: 0x003D0BCA File Offset: 0x003CEDCA
		// (set) Token: 0x0601AE48 RID: 110152 RVA: 0x003D0BD2 File Offset: 0x003CEDD2
		public TProgressBarLeftType Type { get; set; }

		// Token: 0x17007F90 RID: 32656
		// (get) Token: 0x0601AE49 RID: 110153 RVA: 0x003D0BDB File Offset: 0x003CEDDB
		// (set) Token: 0x0601AE4A RID: 110154 RVA: 0x003D0BE3 File Offset: 0x003CEDE3
		public object Value { get; set; }

		// Token: 0x0601AE4B RID: 110155 RVA: 0x003D0BEC File Offset: 0x003CEDEC
		public TProgressBarLeftTypeUnion()
		{
			this.Type = TProgressBarLeftType.NONE;
			this.Value = null;
		}

		// Token: 0x0601AE4C RID: 110156 RVA: 0x003D0C02 File Offset: 0x003CEE02
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AE4D RID: 110157 RVA: 0x003D0C14 File Offset: 0x003CEE14
		public IUseCountT AsIUseCount()
		{
			return this.As<IUseCountT>();
		}

		// Token: 0x0601AE4E RID: 110158 RVA: 0x003D0C1C File Offset: 0x003CEE1C
		public static TProgressBarLeftTypeUnion FromIUseCount(IUseCountT _iusecount)
		{
			return new TProgressBarLeftTypeUnion
			{
				Type = TProgressBarLeftType.IUseCount,
				Value = _iusecount
			};
		}

		// Token: 0x0601AE4F RID: 110159 RVA: 0x003D0C31 File Offset: 0x003CEE31
		public IUseVarT AsIUseVar()
		{
			return this.As<IUseVarT>();
		}

		// Token: 0x0601AE50 RID: 110160 RVA: 0x003D0C39 File Offset: 0x003CEE39
		public static TProgressBarLeftTypeUnion FromIUseVar(IUseVarT _iusevar)
		{
			return new TProgressBarLeftTypeUnion
			{
				Type = TProgressBarLeftType.IUseVar,
				Value = _iusevar
			};
		}

		// Token: 0x0601AE51 RID: 110161 RVA: 0x003D0C50 File Offset: 0x003CEE50
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
