using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005918 RID: 22808
	public struct IHitLogicChangeCountDownState : IFlatbufferObject
	{
		// Token: 0x1700A570 RID: 42352
		// (get) Token: 0x0602514A RID: 151882 RVA: 0x00516F94 File Offset: 0x00515194
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602514B RID: 151883 RVA: 0x00516FA1 File Offset: 0x005151A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602514C RID: 151884 RVA: 0x00516FA8 File Offset: 0x005151A8
		public static IHitLogicChangeCountDownState GetRootAsIHitLogicChangeCountDownState(ByteBuffer _bb)
		{
			return IHitLogicChangeCountDownState.GetRootAsIHitLogicChangeCountDownState(_bb, default(IHitLogicChangeCountDownState));
		}

		// Token: 0x0602514D RID: 151885 RVA: 0x00516FC4 File Offset: 0x005151C4
		public static IHitLogicChangeCountDownState GetRootAsIHitLogicChangeCountDownState(ByteBuffer _bb, IHitLogicChangeCountDownState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602514E RID: 151886 RVA: 0x00516FE1 File Offset: 0x005151E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602514F RID: 151887 RVA: 0x00516FF0 File Offset: 0x005151F0
		public IHitLogicChangeCountDownState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A571 RID: 42353
		// (get) Token: 0x06025150 RID: 151888 RVA: 0x00517000 File Offset: 0x00515200
		public EHitLogicType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHitLogicType.ChangeNextState;
				}
				return (EHitLogicType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025151 RID: 151889 RVA: 0x0051703C File Offset: 0x0051523C
		public static Offset<IHitLogicChangeCountDownState> CreateIHitLogicChangeCountDownState(FlatBufferBuilder builder, EHitLogicType Type = EHitLogicType.ChangeNextState)
		{
			builder.StartTable(1);
			IHitLogicChangeCountDownState.AddType(builder, Type);
			return IHitLogicChangeCountDownState.EndIHitLogicChangeCountDownState(builder);
		}

		// Token: 0x06025152 RID: 151890 RVA: 0x00517052 File Offset: 0x00515252
		public static void StartIHitLogicChangeCountDownState(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06025153 RID: 151891 RVA: 0x0051705B File Offset: 0x0051525B
		public static void AddType(FlatBufferBuilder builder, EHitLogicType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025154 RID: 151892 RVA: 0x00517066 File Offset: 0x00515266
		public static Offset<IHitLogicChangeCountDownState> EndIHitLogicChangeCountDownState(FlatBufferBuilder builder)
		{
			return new Offset<IHitLogicChangeCountDownState>(builder.EndTable());
		}

		// Token: 0x06025155 RID: 151893 RVA: 0x00517074 File Offset: 0x00515274
		public IHitLogicChangeCountDownStateT UnPack()
		{
			IHitLogicChangeCountDownStateT hitLogicChangeCountDownStateT = new IHitLogicChangeCountDownStateT();
			this.UnPackTo(hitLogicChangeCountDownStateT);
			return hitLogicChangeCountDownStateT;
		}

		// Token: 0x06025156 RID: 151894 RVA: 0x0051708F File Offset: 0x0051528F
		public void UnPackTo(IHitLogicChangeCountDownStateT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025157 RID: 151895 RVA: 0x005170A0 File Offset: 0x005152A0
		public static Offset<IHitLogicChangeCountDownState> Pack(FlatBufferBuilder builder, IHitLogicChangeCountDownStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitLogicChangeCountDownState>);
			}
			return IHitLogicChangeCountDownState.CreateIHitLogicChangeCountDownState(builder, _o.Type);
		}

		// Token: 0x0400F1AE RID: 61870
		private Table __p;
	}
}
