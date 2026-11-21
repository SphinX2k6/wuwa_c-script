using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004C9D RID: 19613
	public struct IBuffHasDuration : IFlatbufferObject
	{
		// Token: 0x17008AF0 RID: 35568
		// (get) Token: 0x0601E124 RID: 123172 RVA: 0x00436CF9 File Offset: 0x00434EF9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E125 RID: 123173 RVA: 0x00436D06 File Offset: 0x00434F06
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E126 RID: 123174 RVA: 0x00436D10 File Offset: 0x00434F10
		public static IBuffHasDuration GetRootAsIBuffHasDuration(ByteBuffer _bb)
		{
			return IBuffHasDuration.GetRootAsIBuffHasDuration(_bb, default(IBuffHasDuration));
		}

		// Token: 0x0601E127 RID: 123175 RVA: 0x00436D2C File Offset: 0x00434F2C
		public static IBuffHasDuration GetRootAsIBuffHasDuration(ByteBuffer _bb, IBuffHasDuration obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E128 RID: 123176 RVA: 0x00436D49 File Offset: 0x00434F49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E129 RID: 123177 RVA: 0x00436D58 File Offset: 0x00434F58
		public IBuffHasDuration __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008AF1 RID: 35569
		// (get) Token: 0x0601E12A RID: 123178 RVA: 0x00436D68 File Offset: 0x00434F68
		public EBuffDurationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBuffDurationType.Instant;
				}
				return (EBuffDurationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008AF2 RID: 35570
		// (get) Token: 0x0601E12B RID: 123179 RVA: 0x00436DA4 File Offset: 0x00434FA4
		public int Duration
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

		// Token: 0x0601E12C RID: 123180 RVA: 0x00436DE0 File Offset: 0x00434FE0
		public static Offset<IBuffHasDuration> CreateIBuffHasDuration(FlatBufferBuilder builder, EBuffDurationType Type = EBuffDurationType.Instant, int Duration = 0)
		{
			builder.StartTable(2);
			IBuffHasDuration.AddDuration(builder, Duration);
			IBuffHasDuration.AddType(builder, Type);
			return IBuffHasDuration.EndIBuffHasDuration(builder);
		}

		// Token: 0x0601E12D RID: 123181 RVA: 0x00436DFD File Offset: 0x00434FFD
		public static void StartIBuffHasDuration(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601E12E RID: 123182 RVA: 0x00436E06 File Offset: 0x00435006
		public static void AddType(FlatBufferBuilder builder, EBuffDurationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E12F RID: 123183 RVA: 0x00436E11 File Offset: 0x00435011
		public static void AddDuration(FlatBufferBuilder builder, int duration)
		{
			builder.AddInt(1, duration, 0);
		}

		// Token: 0x0601E130 RID: 123184 RVA: 0x00436E1C File Offset: 0x0043501C
		public static Offset<IBuffHasDuration> EndIBuffHasDuration(FlatBufferBuilder builder)
		{
			return new Offset<IBuffHasDuration>(builder.EndTable());
		}

		// Token: 0x0601E131 RID: 123185 RVA: 0x00436E2C File Offset: 0x0043502C
		public IBuffHasDurationT UnPack()
		{
			IBuffHasDurationT buffHasDurationT = new IBuffHasDurationT();
			this.UnPackTo(buffHasDurationT);
			return buffHasDurationT;
		}

		// Token: 0x0601E132 RID: 123186 RVA: 0x00436E47 File Offset: 0x00435047
		public void UnPackTo(IBuffHasDurationT _o)
		{
			_o.Type = this.Type;
			_o.Duration = this.Duration;
		}

		// Token: 0x0601E133 RID: 123187 RVA: 0x00436E64 File Offset: 0x00435064
		public static Offset<IBuffHasDuration> Pack(FlatBufferBuilder builder, IBuffHasDurationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBuffHasDuration>);
			}
			return IBuffHasDuration.CreateIBuffHasDuration(builder, _o.Type, _o.Duration);
		}

		// Token: 0x0400D79B RID: 55195
		private Table __p;
	}
}
