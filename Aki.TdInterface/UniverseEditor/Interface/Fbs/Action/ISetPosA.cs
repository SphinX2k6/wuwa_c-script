using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007827 RID: 30759
	public struct ISetPosA : IFlatbufferObject
	{
		// Token: 0x1700E1B5 RID: 57781
		// (get) Token: 0x06036185 RID: 221573 RVA: 0x0073F811 File Offset: 0x0073DA11
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036186 RID: 221574 RVA: 0x0073F81E File Offset: 0x0073DA1E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036187 RID: 221575 RVA: 0x0073F828 File Offset: 0x0073DA28
		public static ISetPosA GetRootAsISetPosA(ByteBuffer _bb)
		{
			return ISetPosA.GetRootAsISetPosA(_bb, default(ISetPosA));
		}

		// Token: 0x06036188 RID: 221576 RVA: 0x0073F844 File Offset: 0x0073DA44
		public static ISetPosA GetRootAsISetPosA(ByteBuffer _bb, ISetPosA obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036189 RID: 221577 RVA: 0x0073F861 File Offset: 0x0073DA61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603618A RID: 221578 RVA: 0x0073F870 File Offset: 0x0073DA70
		public ISetPosA __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E1B6 RID: 57782
		// (get) Token: 0x0603618B RID: 221579 RVA: 0x0073F880 File Offset: 0x0073DA80
		public IPosA? Pos
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IPosA?(default(IPosA).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0603618C RID: 221580 RVA: 0x0073F8DD File Offset: 0x0073DADD
		public static Offset<ISetPosA> CreateISetPosA(FlatBufferBuilder builder, Offset<IPosA> PosOffset = default(Offset<IPosA>))
		{
			builder.StartTable(1);
			ISetPosA.AddPos(builder, PosOffset);
			return ISetPosA.EndISetPosA(builder);
		}

		// Token: 0x0603618D RID: 221581 RVA: 0x0073F8F3 File Offset: 0x0073DAF3
		public static void StartISetPosA(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603618E RID: 221582 RVA: 0x0073F8FC File Offset: 0x0073DAFC
		public static void AddPos(FlatBufferBuilder builder, Offset<IPosA> posOffset)
		{
			builder.AddOffset(0, posOffset.Value, 0);
		}

		// Token: 0x0603618F RID: 221583 RVA: 0x0073F90C File Offset: 0x0073DB0C
		public static Offset<ISetPosA> EndISetPosA(FlatBufferBuilder builder)
		{
			return new Offset<ISetPosA>(builder.EndTable());
		}

		// Token: 0x06036190 RID: 221584 RVA: 0x0073F91C File Offset: 0x0073DB1C
		public ISetPosAT UnPack()
		{
			ISetPosAT setPosAT = new ISetPosAT();
			this.UnPackTo(setPosAT);
			return setPosAT;
		}

		// Token: 0x06036191 RID: 221585 RVA: 0x0073F938 File Offset: 0x0073DB38
		public void UnPackTo(ISetPosAT _o)
		{
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
		}

		// Token: 0x06036192 RID: 221586 RVA: 0x0073F974 File Offset: 0x0073DB74
		public static Offset<ISetPosA> Pack(FlatBufferBuilder builder, ISetPosAT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetPosA>);
			}
			Offset<IPosA> posOffset = (_o.Pos == null) ? default(Offset<IPosA>) : IPosA.Pack(builder, _o.Pos);
			return ISetPosA.CreateISetPosA(builder, posOffset);
		}

		// Token: 0x04012AAB RID: 76459
		private Table __p;
	}
}
