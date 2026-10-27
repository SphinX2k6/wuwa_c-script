using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D58 RID: 19800
	public class TSkillReadyOptionUnion
	{
		// Token: 0x17008F55 RID: 36693
		// (get) Token: 0x0601F6A0 RID: 128672 RVA: 0x00460776 File Offset: 0x0045E976
		// (set) Token: 0x0601F6A1 RID: 128673 RVA: 0x0046077E File Offset: 0x0045E97E
		public TSkillReadyOption Type { get; set; }

		// Token: 0x17008F56 RID: 36694
		// (get) Token: 0x0601F6A2 RID: 128674 RVA: 0x00460787 File Offset: 0x0045E987
		// (set) Token: 0x0601F6A3 RID: 128675 RVA: 0x0046078F File Offset: 0x0045E98F
		public object Value { get; set; }

		// Token: 0x0601F6A4 RID: 128676 RVA: 0x00460798 File Offset: 0x0045E998
		public TSkillReadyOptionUnion()
		{
			this.Type = TSkillReadyOption.NONE;
			this.Value = null;
		}

		// Token: 0x0601F6A5 RID: 128677 RVA: 0x004607AE File Offset: 0x0045E9AE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F6A6 RID: 128678 RVA: 0x004607C0 File Offset: 0x0045E9C0
		public IESkillReadyT AsIESkillReady()
		{
			return this.As<IESkillReadyT>();
		}

		// Token: 0x0601F6A7 RID: 128679 RVA: 0x004607C8 File Offset: 0x0045E9C8
		public static TSkillReadyOptionUnion FromIESkillReady(IESkillReadyT _ieskillready)
		{
			return new TSkillReadyOptionUnion
			{
				Type = TSkillReadyOption.IESkillReady,
				Value = _ieskillready
			};
		}

		// Token: 0x0601F6A8 RID: 128680 RVA: 0x004607DD File Offset: 0x0045E9DD
		public IUltimateSkillReadyT AsIUltimateSkillReady()
		{
			return this.As<IUltimateSkillReadyT>();
		}

		// Token: 0x0601F6A9 RID: 128681 RVA: 0x004607E5 File Offset: 0x0045E9E5
		public static TSkillReadyOptionUnion FromIUltimateSkillReady(IUltimateSkillReadyT _iultimateskillready)
		{
			return new TSkillReadyOptionUnion
			{
				Type = TSkillReadyOption.IUltimateSkillReady,
				Value = _iultimateskillready
			};
		}

		// Token: 0x0601F6AA RID: 128682 RVA: 0x004607FA File Offset: 0x0045E9FA
		public IVisionSkillReadyT AsIVisionSkillReady()
		{
			return this.As<IVisionSkillReadyT>();
		}

		// Token: 0x0601F6AB RID: 128683 RVA: 0x00460802 File Offset: 0x0045EA02
		public static TSkillReadyOptionUnion FromIVisionSkillReady(IVisionSkillReadyT _ivisionskillready)
		{
			return new TSkillReadyOptionUnion
			{
				Type = TSkillReadyOption.IVisionSkillReady,
				Value = _ivisionskillready
			};
		}

		// Token: 0x0601F6AC RID: 128684 RVA: 0x00460818 File Offset: 0x0045EA18
		public static int Pack(FlatBufferBuilder builder, TSkillReadyOptionUnion _o)
		{
			switch (_o.Type)
			{
			case TSkillReadyOption.IESkillReady:
				return IESkillReady.Pack(builder, _o.AsIESkillReady()).Value;
			case TSkillReadyOption.IUltimateSkillReady:
				return IUltimateSkillReady.Pack(builder, _o.AsIUltimateSkillReady()).Value;
			case TSkillReadyOption.IVisionSkillReady:
				return IVisionSkillReady.Pack(builder, _o.AsIVisionSkillReady()).Value;
			default:
				return 0;
			}
		}
	}
}
