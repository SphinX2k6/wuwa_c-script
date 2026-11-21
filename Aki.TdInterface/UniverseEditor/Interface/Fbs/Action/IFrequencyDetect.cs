using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EFC RID: 28412
	public struct IFrequencyDetect : IFlatbufferObject
	{
		// Token: 0x1700D05F RID: 53343
		// (get) Token: 0x060312A3 RID: 201379 RVA: 0x006A9F0C File Offset: 0x006A810C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060312A4 RID: 201380 RVA: 0x006A9F19 File Offset: 0x006A8119
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060312A5 RID: 201381 RVA: 0x006A9F20 File Offset: 0x006A8120
		public static IFrequencyDetect GetRootAsIFrequencyDetect(ByteBuffer _bb)
		{
			return IFrequencyDetect.GetRootAsIFrequencyDetect(_bb, default(IFrequencyDetect));
		}

		// Token: 0x060312A6 RID: 201382 RVA: 0x006A9F3C File Offset: 0x006A813C
		public static IFrequencyDetect GetRootAsIFrequencyDetect(ByteBuffer _bb, IFrequencyDetect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060312A7 RID: 201383 RVA: 0x006A9F59 File Offset: 0x006A8159
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060312A8 RID: 201384 RVA: 0x006A9F68 File Offset: 0x006A8168
		public IFrequencyDetect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D060 RID: 53344
		// (get) Token: 0x060312A9 RID: 201385 RVA: 0x006A9F78 File Offset: 0x006A8178
		public ESimpleGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESimpleGameplayType.Cipher;
				}
				return (ESimpleGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D061 RID: 53345
		// (get) Token: 0x060312AA RID: 201386 RVA: 0x006A9FB4 File Offset: 0x006A81B4
		public int Id
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

		// Token: 0x060312AB RID: 201387 RVA: 0x006A9FF0 File Offset: 0x006A81F0
		public static Offset<IFrequencyDetect> CreateIFrequencyDetect(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, int Id = 0)
		{
			builder.StartTable(2);
			IFrequencyDetect.AddId(builder, Id);
			IFrequencyDetect.AddType(builder, Type);
			return IFrequencyDetect.EndIFrequencyDetect(builder);
		}

		// Token: 0x060312AC RID: 201388 RVA: 0x006AA00D File Offset: 0x006A820D
		public static void StartIFrequencyDetect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060312AD RID: 201389 RVA: 0x006AA016 File Offset: 0x006A8216
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060312AE RID: 201390 RVA: 0x006AA021 File Offset: 0x006A8221
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x060312AF RID: 201391 RVA: 0x006AA02C File Offset: 0x006A822C
		public static Offset<IFrequencyDetect> EndIFrequencyDetect(FlatBufferBuilder builder)
		{
			return new Offset<IFrequencyDetect>(builder.EndTable());
		}

		// Token: 0x060312B0 RID: 201392 RVA: 0x006AA03C File Offset: 0x006A823C
		public IFrequencyDetectT UnPack()
		{
			IFrequencyDetectT frequencyDetectT = new IFrequencyDetectT();
			this.UnPackTo(frequencyDetectT);
			return frequencyDetectT;
		}

		// Token: 0x060312B1 RID: 201393 RVA: 0x006AA057 File Offset: 0x006A8257
		public void UnPackTo(IFrequencyDetectT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x060312B2 RID: 201394 RVA: 0x006AA074 File Offset: 0x006A8274
		public static Offset<IFrequencyDetect> Pack(FlatBufferBuilder builder, IFrequencyDetectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFrequencyDetect>);
			}
			return IFrequencyDetect.CreateIFrequencyDetect(builder, _o.Type, _o.Id);
		}

		// Token: 0x04011E03 RID: 73219
		private Table __p;
	}
}
