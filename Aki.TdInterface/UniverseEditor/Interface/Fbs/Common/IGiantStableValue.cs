using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DD0 RID: 24016
	public struct IGiantStableValue : IFlatbufferObject
	{
		// Token: 0x1700B3CA RID: 46026
		// (get) Token: 0x060291B0 RID: 168368 RVA: 0x005A4514 File Offset: 0x005A2714
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060291B1 RID: 168369 RVA: 0x005A4521 File Offset: 0x005A2721
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060291B2 RID: 168370 RVA: 0x005A4528 File Offset: 0x005A2728
		public static IGiantStableValue GetRootAsIGiantStableValue(ByteBuffer _bb)
		{
			return IGiantStableValue.GetRootAsIGiantStableValue(_bb, default(IGiantStableValue));
		}

		// Token: 0x060291B3 RID: 168371 RVA: 0x005A4544 File Offset: 0x005A2744
		public static IGiantStableValue GetRootAsIGiantStableValue(ByteBuffer _bb, IGiantStableValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060291B4 RID: 168372 RVA: 0x005A4561 File Offset: 0x005A2761
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060291B5 RID: 168373 RVA: 0x005A4570 File Offset: 0x005A2770
		public IGiantStableValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B3CB RID: 46027
		// (get) Token: 0x060291B6 RID: 168374 RVA: 0x005A4580 File Offset: 0x005A2780
		public EGiantStableValueBoundary Boundary
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGiantStableValueBoundary.Open;
				}
				return (EGiantStableValueBoundary)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B3CC RID: 46028
		// (get) Token: 0x060291B7 RID: 168375 RVA: 0x005A45BC File Offset: 0x005A27BC
		public int Value
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060291B8 RID: 168376 RVA: 0x005A45F8 File Offset: 0x005A27F8
		public static Offset<IGiantStableValue> CreateIGiantStableValue(FlatBufferBuilder builder, EGiantStableValueBoundary Boundary = EGiantStableValueBoundary.Open, int Value = 0)
		{
			builder.StartTable(2);
			IGiantStableValue.AddValue(builder, Value);
			IGiantStableValue.AddBoundary(builder, Boundary);
			return IGiantStableValue.EndIGiantStableValue(builder);
		}

		// Token: 0x060291B9 RID: 168377 RVA: 0x005A4615 File Offset: 0x005A2815
		public static void StartIGiantStableValue(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060291BA RID: 168378 RVA: 0x005A461E File Offset: 0x005A281E
		public static void AddBoundary(FlatBufferBuilder builder, EGiantStableValueBoundary boundary)
		{
			builder.AddByte(0, (byte)boundary, 0);
		}

		// Token: 0x060291BB RID: 168379 RVA: 0x005A4629 File Offset: 0x005A2829
		public static void AddValue(FlatBufferBuilder builder, int value)
		{
			builder.AddInt(1, value, 0);
		}

		// Token: 0x060291BC RID: 168380 RVA: 0x005A4634 File Offset: 0x005A2834
		public static Offset<IGiantStableValue> EndIGiantStableValue(FlatBufferBuilder builder)
		{
			return new Offset<IGiantStableValue>(builder.EndTable());
		}

		// Token: 0x060291BD RID: 168381 RVA: 0x005A4644 File Offset: 0x005A2844
		public IGiantStableValueT UnPack()
		{
			IGiantStableValueT giantStableValueT = new IGiantStableValueT();
			this.UnPackTo(giantStableValueT);
			return giantStableValueT;
		}

		// Token: 0x060291BE RID: 168382 RVA: 0x005A465F File Offset: 0x005A285F
		public void UnPackTo(IGiantStableValueT _o)
		{
			_o.Boundary = this.Boundary;
			_o.Value = this.Value;
		}

		// Token: 0x060291BF RID: 168383 RVA: 0x005A467C File Offset: 0x005A287C
		public static Offset<IGiantStableValue> Pack(FlatBufferBuilder builder, IGiantStableValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGiantStableValue>);
			}
			return IGiantStableValue.CreateIGiantStableValue(builder, _o.Boundary, _o.Value);
		}

		// Token: 0x0400F7B6 RID: 63414
		private Table __p;
	}
}
