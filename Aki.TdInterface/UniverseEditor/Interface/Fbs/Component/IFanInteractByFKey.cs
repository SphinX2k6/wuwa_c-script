using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005799 RID: 22425
	public struct IFanInteractByFKey : IFlatbufferObject
	{
		// Token: 0x1700A22A RID: 41514
		// (get) Token: 0x06024323 RID: 148259 RVA: 0x004FA141 File Offset: 0x004F8341
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024324 RID: 148260 RVA: 0x004FA14E File Offset: 0x004F834E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024325 RID: 148261 RVA: 0x004FA158 File Offset: 0x004F8358
		public static IFanInteractByFKey GetRootAsIFanInteractByFKey(ByteBuffer _bb)
		{
			return IFanInteractByFKey.GetRootAsIFanInteractByFKey(_bb, default(IFanInteractByFKey));
		}

		// Token: 0x06024326 RID: 148262 RVA: 0x004FA174 File Offset: 0x004F8374
		public static IFanInteractByFKey GetRootAsIFanInteractByFKey(ByteBuffer _bb, IFanInteractByFKey obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024327 RID: 148263 RVA: 0x004FA191 File Offset: 0x004F8391
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024328 RID: 148264 RVA: 0x004FA1A0 File Offset: 0x004F83A0
		public IFanInteractByFKey __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A22B RID: 41515
		// (get) Token: 0x06024329 RID: 148265 RVA: 0x004FA1B0 File Offset: 0x004F83B0
		public EFanInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFanInteractType.Hit;
				}
				return (EFanInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A22C RID: 41516
		// (get) Token: 0x0602432A RID: 148266 RVA: 0x004FA1EC File Offset: 0x004F83EC
		public string TidInteractOptionText
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

		// Token: 0x0602432B RID: 148267 RVA: 0x004FA223 File Offset: 0x004F8423
		public Span<byte> GetTidInteractOptionTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602432C RID: 148268 RVA: 0x004FA232 File Offset: 0x004F8432
		public byte[] GetTidInteractOptionTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602432D RID: 148269 RVA: 0x004FA240 File Offset: 0x004F8440
		public static Offset<IFanInteractByFKey> CreateIFanInteractByFKey(FlatBufferBuilder builder, EFanInteractType Type = EFanInteractType.Hit, StringOffset TidInteractOptionTextOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IFanInteractByFKey.AddTidInteractOptionText(builder, TidInteractOptionTextOffset);
			IFanInteractByFKey.AddType(builder, Type);
			return IFanInteractByFKey.EndIFanInteractByFKey(builder);
		}

		// Token: 0x0602432E RID: 148270 RVA: 0x004FA25D File Offset: 0x004F845D
		public static void StartIFanInteractByFKey(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602432F RID: 148271 RVA: 0x004FA266 File Offset: 0x004F8466
		public static void AddType(FlatBufferBuilder builder, EFanInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024330 RID: 148272 RVA: 0x004FA271 File Offset: 0x004F8471
		public static void AddTidInteractOptionText(FlatBufferBuilder builder, StringOffset tidInteractOptionTextOffset)
		{
			builder.AddOffset(1, tidInteractOptionTextOffset.Value, 0);
		}

		// Token: 0x06024331 RID: 148273 RVA: 0x004FA281 File Offset: 0x004F8481
		public static Offset<IFanInteractByFKey> EndIFanInteractByFKey(FlatBufferBuilder builder)
		{
			return new Offset<IFanInteractByFKey>(builder.EndTable());
		}

		// Token: 0x06024332 RID: 148274 RVA: 0x004FA290 File Offset: 0x004F8490
		public IFanInteractByFKeyT UnPack()
		{
			IFanInteractByFKeyT fanInteractByFKeyT = new IFanInteractByFKeyT();
			this.UnPackTo(fanInteractByFKeyT);
			return fanInteractByFKeyT;
		}

		// Token: 0x06024333 RID: 148275 RVA: 0x004FA2AB File Offset: 0x004F84AB
		public void UnPackTo(IFanInteractByFKeyT _o)
		{
			_o.Type = this.Type;
			_o.TidInteractOptionText = this.TidInteractOptionText;
		}

		// Token: 0x06024334 RID: 148276 RVA: 0x004FA2C8 File Offset: 0x004F84C8
		public static Offset<IFanInteractByFKey> Pack(FlatBufferBuilder builder, IFanInteractByFKeyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFanInteractByFKey>);
			}
			StringOffset tidInteractOptionTextOffset = (_o.TidInteractOptionText == null) ? default(StringOffset) : builder.CreateString(_o.TidInteractOptionText);
			return IFanInteractByFKey.CreateIFanInteractByFKey(builder, _o.Type, tidInteractOptionTextOffset);
		}

		// Token: 0x0400EF7D RID: 61309
		private Table __p;
	}
}
