using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C7F RID: 23679
	public class TPatrolCycleOptionUnion
	{
		// Token: 0x1700B232 RID: 45618
		// (get) Token: 0x06028911 RID: 166161 RVA: 0x00593DAC File Offset: 0x00591FAC
		// (set) Token: 0x06028912 RID: 166162 RVA: 0x00593DB4 File Offset: 0x00591FB4
		public TPatrolCycleOption Type { get; set; }

		// Token: 0x1700B233 RID: 45619
		// (get) Token: 0x06028913 RID: 166163 RVA: 0x00593DBD File Offset: 0x00591FBD
		// (set) Token: 0x06028914 RID: 166164 RVA: 0x00593DC5 File Offset: 0x00591FC5
		public object Value { get; set; }

		// Token: 0x06028915 RID: 166165 RVA: 0x00593DCE File Offset: 0x00591FCE
		public TPatrolCycleOptionUnion()
		{
			this.Type = TPatrolCycleOption.NONE;
			this.Value = null;
		}

		// Token: 0x06028916 RID: 166166 RVA: 0x00593DE4 File Offset: 0x00591FE4
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028917 RID: 166167 RVA: 0x00593DF6 File Offset: 0x00591FF6
		public IPatrolCycleLooplyT AsIPatrolCycleLooply()
		{
			return this.As<IPatrolCycleLooplyT>();
		}

		// Token: 0x06028918 RID: 166168 RVA: 0x00593DFE File Offset: 0x00591FFE
		public static TPatrolCycleOptionUnion FromIPatrolCycleLooply(IPatrolCycleLooplyT _ipatrolcyclelooply)
		{
			return new TPatrolCycleOptionUnion
			{
				Type = TPatrolCycleOption.IPatrolCycleLooply,
				Value = _ipatrolcyclelooply
			};
		}

		// Token: 0x06028919 RID: 166169 RVA: 0x00593E13 File Offset: 0x00592013
		public IPatrolCycleOncelyT AsIPatrolCycleOncely()
		{
			return this.As<IPatrolCycleOncelyT>();
		}

		// Token: 0x0602891A RID: 166170 RVA: 0x00593E1B File Offset: 0x0059201B
		public static TPatrolCycleOptionUnion FromIPatrolCycleOncely(IPatrolCycleOncelyT _ipatrolcycleoncely)
		{
			return new TPatrolCycleOptionUnion
			{
				Type = TPatrolCycleOption.IPatrolCycleOncely,
				Value = _ipatrolcycleoncely
			};
		}

		// Token: 0x0602891B RID: 166171 RVA: 0x00593E30 File Offset: 0x00592030
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
