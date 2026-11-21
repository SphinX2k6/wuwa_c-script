using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059F9 RID: 23033
	public struct IInteractSectorRange : IFlatbufferObject
	{
		// Token: 0x1700A75B RID: 42843
		// (get) Token: 0x060259B7 RID: 154039 RVA: 0x00528142 File Offset: 0x00526342
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060259B8 RID: 154040 RVA: 0x0052814F File Offset: 0x0052634F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060259B9 RID: 154041 RVA: 0x00528158 File Offset: 0x00526358
		public static IInteractSectorRange GetRootAsIInteractSectorRange(ByteBuffer _bb)
		{
			return IInteractSectorRange.GetRootAsIInteractSectorRange(_bb, default(IInteractSectorRange));
		}

		// Token: 0x060259BA RID: 154042 RVA: 0x00528174 File Offset: 0x00526374
		public static IInteractSectorRange GetRootAsIInteractSectorRange(ByteBuffer _bb, IInteractSectorRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060259BB RID: 154043 RVA: 0x00528191 File Offset: 0x00526391
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060259BC RID: 154044 RVA: 0x005281A0 File Offset: 0x005263A0
		public IInteractSectorRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A75C RID: 42844
		// (get) Token: 0x060259BD RID: 154045 RVA: 0x005281B0 File Offset: 0x005263B0
		public float Begin
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A75D RID: 42845
		// (get) Token: 0x060259BE RID: 154046 RVA: 0x005281F0 File Offset: 0x005263F0
		public float End
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060259BF RID: 154047 RVA: 0x00528230 File Offset: 0x00526430
		public static Offset<IInteractSectorRange> CreateIInteractSectorRange(FlatBufferBuilder builder, float Begin = 0f, float End = 0f)
		{
			builder.StartTable(2);
			IInteractSectorRange.AddEnd(builder, End);
			IInteractSectorRange.AddBegin(builder, Begin);
			return IInteractSectorRange.EndIInteractSectorRange(builder);
		}

		// Token: 0x060259C0 RID: 154048 RVA: 0x0052824D File Offset: 0x0052644D
		public static void StartIInteractSectorRange(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060259C1 RID: 154049 RVA: 0x00528256 File Offset: 0x00526456
		public static void AddBegin(FlatBufferBuilder builder, float begin)
		{
			builder.AddFloat(0, begin, 0.0);
		}

		// Token: 0x060259C2 RID: 154050 RVA: 0x00528269 File Offset: 0x00526469
		public static void AddEnd(FlatBufferBuilder builder, float end)
		{
			builder.AddFloat(1, end, 0.0);
		}

		// Token: 0x060259C3 RID: 154051 RVA: 0x0052827C File Offset: 0x0052647C
		public static Offset<IInteractSectorRange> EndIInteractSectorRange(FlatBufferBuilder builder)
		{
			return new Offset<IInteractSectorRange>(builder.EndTable());
		}

		// Token: 0x060259C4 RID: 154052 RVA: 0x0052828C File Offset: 0x0052648C
		public IInteractSectorRangeT UnPack()
		{
			IInteractSectorRangeT interactSectorRangeT = new IInteractSectorRangeT();
			this.UnPackTo(interactSectorRangeT);
			return interactSectorRangeT;
		}

		// Token: 0x060259C5 RID: 154053 RVA: 0x005282A7 File Offset: 0x005264A7
		public void UnPackTo(IInteractSectorRangeT _o)
		{
			_o.Begin = this.Begin;
			_o.End = this.End;
		}

		// Token: 0x060259C6 RID: 154054 RVA: 0x005282C4 File Offset: 0x005264C4
		public static Offset<IInteractSectorRange> Pack(FlatBufferBuilder builder, IInteractSectorRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractSectorRange>);
			}
			return IInteractSectorRange.CreateIInteractSectorRange(builder, _o.Begin, _o.End);
		}

		// Token: 0x0400F322 RID: 62242
		private Table __p;
	}
}
