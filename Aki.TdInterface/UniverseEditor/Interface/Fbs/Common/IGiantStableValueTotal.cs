using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DD9 RID: 24025
	public struct IGiantStableValueTotal : IFlatbufferObject
	{
		// Token: 0x1700B3DB RID: 46043
		// (get) Token: 0x060291F6 RID: 168438 RVA: 0x005A4D37 File Offset: 0x005A2F37
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060291F7 RID: 168439 RVA: 0x005A4D44 File Offset: 0x005A2F44
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060291F8 RID: 168440 RVA: 0x005A4D4C File Offset: 0x005A2F4C
		public static IGiantStableValueTotal GetRootAsIGiantStableValueTotal(ByteBuffer _bb)
		{
			return IGiantStableValueTotal.GetRootAsIGiantStableValueTotal(_bb, default(IGiantStableValueTotal));
		}

		// Token: 0x060291F9 RID: 168441 RVA: 0x005A4D68 File Offset: 0x005A2F68
		public static IGiantStableValueTotal GetRootAsIGiantStableValueTotal(ByteBuffer _bb, IGiantStableValueTotal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060291FA RID: 168442 RVA: 0x005A4D85 File Offset: 0x005A2F85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060291FB RID: 168443 RVA: 0x005A4D94 File Offset: 0x005A2F94
		public IGiantStableValueTotal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B3DC RID: 46044
		// (get) Token: 0x060291FC RID: 168444 RVA: 0x005A4DA4 File Offset: 0x005A2FA4
		public EGiantStableValueType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGiantStableValueType.Region;
				}
				return (EGiantStableValueType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B3DD RID: 46045
		// (get) Token: 0x060291FD RID: 168445 RVA: 0x005A4DE0 File Offset: 0x005A2FE0
		public IGiantStableValueRange? Range
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IGiantStableValueRange?(default(IGiantStableValueRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060291FE RID: 168446 RVA: 0x005A4E3D File Offset: 0x005A303D
		public static Offset<IGiantStableValueTotal> CreateIGiantStableValueTotal(FlatBufferBuilder builder, EGiantStableValueType Type = EGiantStableValueType.Region, Offset<IGiantStableValueRange> RangeOffset = default(Offset<IGiantStableValueRange>))
		{
			builder.StartTable(2);
			IGiantStableValueTotal.AddRange(builder, RangeOffset);
			IGiantStableValueTotal.AddType(builder, Type);
			return IGiantStableValueTotal.EndIGiantStableValueTotal(builder);
		}

		// Token: 0x060291FF RID: 168447 RVA: 0x005A4E5A File Offset: 0x005A305A
		public static void StartIGiantStableValueTotal(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029200 RID: 168448 RVA: 0x005A4E63 File Offset: 0x005A3063
		public static void AddType(FlatBufferBuilder builder, EGiantStableValueType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029201 RID: 168449 RVA: 0x005A4E6E File Offset: 0x005A306E
		public static void AddRange(FlatBufferBuilder builder, Offset<IGiantStableValueRange> rangeOffset)
		{
			builder.AddOffset(1, rangeOffset.Value, 0);
		}

		// Token: 0x06029202 RID: 168450 RVA: 0x005A4E7E File Offset: 0x005A307E
		public static Offset<IGiantStableValueTotal> EndIGiantStableValueTotal(FlatBufferBuilder builder)
		{
			return new Offset<IGiantStableValueTotal>(builder.EndTable());
		}

		// Token: 0x06029203 RID: 168451 RVA: 0x005A4E8C File Offset: 0x005A308C
		public IGiantStableValueTotalT UnPack()
		{
			IGiantStableValueTotalT giantStableValueTotalT = new IGiantStableValueTotalT();
			this.UnPackTo(giantStableValueTotalT);
			return giantStableValueTotalT;
		}

		// Token: 0x06029204 RID: 168452 RVA: 0x005A4EA8 File Offset: 0x005A30A8
		public void UnPackTo(IGiantStableValueTotalT _o)
		{
			_o.Type = this.Type;
			_o.Range = ((this.Range != null) ? this.Range.Value.UnPack() : null);
		}

		// Token: 0x06029205 RID: 168453 RVA: 0x005A4EF0 File Offset: 0x005A30F0
		public static Offset<IGiantStableValueTotal> Pack(FlatBufferBuilder builder, IGiantStableValueTotalT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGiantStableValueTotal>);
			}
			Offset<IGiantStableValueRange> rangeOffset = (_o.Range == null) ? default(Offset<IGiantStableValueRange>) : IGiantStableValueRange.Pack(builder, _o.Range);
			return IGiantStableValueTotal.CreateIGiantStableValueTotal(builder, _o.Type, rangeOffset);
		}

		// Token: 0x0400F7C0 RID: 63424
		private Table __p;
	}
}
