using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062AD RID: 25261
	public class TPatrolCycleOptionUnion
	{
		// Token: 0x1700BB8A RID: 48010
		// (get) Token: 0x0602AF4B RID: 175947 RVA: 0x005DC3E6 File Offset: 0x005DA5E6
		// (set) Token: 0x0602AF4C RID: 175948 RVA: 0x005DC3EE File Offset: 0x005DA5EE
		public TPatrolCycleOption Type { get; set; }

		// Token: 0x1700BB8B RID: 48011
		// (get) Token: 0x0602AF4D RID: 175949 RVA: 0x005DC3F7 File Offset: 0x005DA5F7
		// (set) Token: 0x0602AF4E RID: 175950 RVA: 0x005DC3FF File Offset: 0x005DA5FF
		public object Value { get; set; }

		// Token: 0x0602AF4F RID: 175951 RVA: 0x005DC408 File Offset: 0x005DA608
		public TPatrolCycleOptionUnion()
		{
			this.Type = TPatrolCycleOption.NONE;
			this.Value = null;
		}

		// Token: 0x0602AF50 RID: 175952 RVA: 0x005DC41E File Offset: 0x005DA61E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AF51 RID: 175953 RVA: 0x005DC430 File Offset: 0x005DA630
		public IPatrolCycleLooplyT AsIPatrolCycleLooply()
		{
			return this.As<IPatrolCycleLooplyT>();
		}

		// Token: 0x0602AF52 RID: 175954 RVA: 0x005DC438 File Offset: 0x005DA638
		public static TPatrolCycleOptionUnion FromIPatrolCycleLooply(IPatrolCycleLooplyT _ipatrolcyclelooply)
		{
			return new TPatrolCycleOptionUnion
			{
				Type = TPatrolCycleOption.IPatrolCycleLooply,
				Value = _ipatrolcyclelooply
			};
		}

		// Token: 0x0602AF53 RID: 175955 RVA: 0x005DC44D File Offset: 0x005DA64D
		public IPatrolCycleOncelyT AsIPatrolCycleOncely()
		{
			return this.As<IPatrolCycleOncelyT>();
		}

		// Token: 0x0602AF54 RID: 175956 RVA: 0x005DC455 File Offset: 0x005DA655
		public static TPatrolCycleOptionUnion FromIPatrolCycleOncely(IPatrolCycleOncelyT _ipatrolcycleoncely)
		{
			return new TPatrolCycleOptionUnion
			{
				Type = TPatrolCycleOption.IPatrolCycleOncely,
				Value = _ipatrolcycleoncely
			};
		}

		// Token: 0x0602AF55 RID: 175957 RVA: 0x005DC46C File Offset: 0x005DA66C
		public static int Pack(FlatBufferBuilder builder, TPatrolCycleOptionUnion _o)
		{
			TPatrolCycleOption type = _o.Type;
			if (type == TPatrolCycleOption.IPatrolCycleLooply)
			{
				return IPatrolCycleLooply.Pack(builder, _o.AsIPatrolCycleLooply()).Value;
			}
			if (type != TPatrolCycleOption.IPatrolCycleOncely)
			{
				return 0;
			}
			return IPatrolCycleOncely.Pack(builder, _o.AsIPatrolCycleOncely()).Value;
		}
	}
}
