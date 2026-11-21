using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AC2 RID: 23234
	public struct IMechaTrackCountDownTip : IFlatbufferObject
	{
		// Token: 0x1700A94E RID: 43342
		// (get) Token: 0x06026187 RID: 156039 RVA: 0x00537F91 File Offset: 0x00536191
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026188 RID: 156040 RVA: 0x00537F9E File Offset: 0x0053619E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026189 RID: 156041 RVA: 0x00537FA8 File Offset: 0x005361A8
		public static IMechaTrackCountDownTip GetRootAsIMechaTrackCountDownTip(ByteBuffer _bb)
		{
			return IMechaTrackCountDownTip.GetRootAsIMechaTrackCountDownTip(_bb, default(IMechaTrackCountDownTip));
		}

		// Token: 0x0602618A RID: 156042 RVA: 0x00537FC4 File Offset: 0x005361C4
		public static IMechaTrackCountDownTip GetRootAsIMechaTrackCountDownTip(ByteBuffer _bb, IMechaTrackCountDownTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602618B RID: 156043 RVA: 0x00537FE1 File Offset: 0x005361E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602618C RID: 156044 RVA: 0x00537FF0 File Offset: 0x005361F0
		public IMechaTrackCountDownTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A94F RID: 43343
		// (get) Token: 0x0602618D RID: 156045 RVA: 0x00538000 File Offset: 0x00536200
		public ETrampleTipType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrampleTipType.CountDownTextTip;
				}
				return (ETrampleTipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A950 RID: 43344
		// (get) Token: 0x0602618E RID: 156046 RVA: 0x0053803C File Offset: 0x0053623C
		public string TidCountDownTip
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602618F RID: 156047 RVA: 0x00538073 File Offset: 0x00536273
		public Span<byte> GetTidCountDownTipBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06026190 RID: 156048 RVA: 0x00538082 File Offset: 0x00536282
		public byte[] GetTidCountDownTipArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06026191 RID: 156049 RVA: 0x00538090 File Offset: 0x00536290
		public static Offset<IMechaTrackCountDownTip> CreateIMechaTrackCountDownTip(FlatBufferBuilder builder, ETrampleTipType Type = ETrampleTipType.CountDownTextTip, StringOffset TidCountDownTipOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IMechaTrackCountDownTip.AddTidCountDownTip(builder, TidCountDownTipOffset);
			IMechaTrackCountDownTip.AddType(builder, Type);
			return IMechaTrackCountDownTip.EndIMechaTrackCountDownTip(builder);
		}

		// Token: 0x06026192 RID: 156050 RVA: 0x005380AD File Offset: 0x005362AD
		public static void StartIMechaTrackCountDownTip(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06026193 RID: 156051 RVA: 0x005380B6 File Offset: 0x005362B6
		public static void AddType(FlatBufferBuilder builder, ETrampleTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026194 RID: 156052 RVA: 0x005380C1 File Offset: 0x005362C1
		public static void AddTidCountDownTip(FlatBufferBuilder builder, StringOffset tidCountDownTipOffset)
		{
			builder.AddOffset(1, tidCountDownTipOffset.Value, 0);
		}

		// Token: 0x06026195 RID: 156053 RVA: 0x005380D1 File Offset: 0x005362D1
		public static Offset<IMechaTrackCountDownTip> EndIMechaTrackCountDownTip(FlatBufferBuilder builder)
		{
			return new Offset<IMechaTrackCountDownTip>(builder.EndTable());
		}

		// Token: 0x06026196 RID: 156054 RVA: 0x005380E0 File Offset: 0x005362E0
		public IMechaTrackCountDownTipT UnPack()
		{
			IMechaTrackCountDownTipT mechaTrackCountDownTipT = new IMechaTrackCountDownTipT();
			this.UnPackTo(mechaTrackCountDownTipT);
			return mechaTrackCountDownTipT;
		}

		// Token: 0x06026197 RID: 156055 RVA: 0x005380FB File Offset: 0x005362FB
		public void UnPackTo(IMechaTrackCountDownTipT _o)
		{
			_o.Type = this.Type;
			_o.TidCountDownTip = this.TidCountDownTip;
		}

		// Token: 0x06026198 RID: 156056 RVA: 0x00538118 File Offset: 0x00536318
		public static Offset<IMechaTrackCountDownTip> Pack(FlatBufferBuilder builder, IMechaTrackCountDownTipT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechaTrackCountDownTip>);
			}
			StringOffset tidCountDownTipOffset = (_o.TidCountDownTip == null) ? default(StringOffset) : builder.CreateString(_o.TidCountDownTip);
			return IMechaTrackCountDownTip.CreateIMechaTrackCountDownTip(builder, _o.Type, tidCountDownTipOffset);
		}

		// Token: 0x0400F46B RID: 62571
		private Table __p;
	}
}
