using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059B9 RID: 22969
	public struct IStateRepPerfMontagePath : IFlatbufferObject
	{
		// Token: 0x1700AC5A RID: 44122
		// (get) Token: 0x06026EA7 RID: 159399 RVA: 0x0055AB48 File Offset: 0x00558D48
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026EA8 RID: 159400 RVA: 0x0055AB55 File Offset: 0x00558D55
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026EA9 RID: 159401 RVA: 0x0055AB5C File Offset: 0x00558D5C
		public static IStateRepPerfMontagePath GetRootAsIStateRepPerfMontagePath(ByteBuffer _bb)
		{
			return IStateRepPerfMontagePath.GetRootAsIStateRepPerfMontagePath(_bb, default(IStateRepPerfMontagePath));
		}

		// Token: 0x06026EAA RID: 159402 RVA: 0x0055AB78 File Offset: 0x00558D78
		public static IStateRepPerfMontagePath GetRootAsIStateRepPerfMontagePath(ByteBuffer _bb, IStateRepPerfMontagePath obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026EAB RID: 159403 RVA: 0x0055AB95 File Offset: 0x00558D95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026EAC RID: 159404 RVA: 0x0055ABA4 File Offset: 0x00558DA4
		public IStateRepPerfMontagePath __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AC5B RID: 44123
		// (get) Token: 0x06026EAD RID: 159405 RVA: 0x0055ABB4 File Offset: 0x00558DB4
		public EStateRepPerfType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EStateRepPerfType.SkillId;
				}
				return (EStateRepPerfType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AC5C RID: 44124
		// (get) Token: 0x06026EAE RID: 159406 RVA: 0x0055ABF0 File Offset: 0x00558DF0
		public string MontagePath
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

		// Token: 0x06026EAF RID: 159407 RVA: 0x0055AC27 File Offset: 0x00558E27
		public Span<byte> GetMontagePathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06026EB0 RID: 159408 RVA: 0x0055AC36 File Offset: 0x00558E36
		public byte[] GetMontagePathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700AC5D RID: 44125
		// (get) Token: 0x06026EB1 RID: 159409 RVA: 0x0055AC44 File Offset: 0x00558E44
		public string MontageName
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026EB2 RID: 159410 RVA: 0x0055AC7B File Offset: 0x00558E7B
		public Span<byte> GetMontageNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06026EB3 RID: 159411 RVA: 0x0055AC8A File Offset: 0x00558E8A
		public byte[] GetMontageNameArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06026EB4 RID: 159412 RVA: 0x0055AC98 File Offset: 0x00558E98
		public static Offset<IStateRepPerfMontagePath> CreateIStateRepPerfMontagePath(FlatBufferBuilder builder, EStateRepPerfType Type = EStateRepPerfType.SkillId, StringOffset MontagePathOffset = default(StringOffset), StringOffset MontageNameOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IStateRepPerfMontagePath.AddMontageName(builder, MontageNameOffset);
			IStateRepPerfMontagePath.AddMontagePath(builder, MontagePathOffset);
			IStateRepPerfMontagePath.AddType(builder, Type);
			return IStateRepPerfMontagePath.EndIStateRepPerfMontagePath(builder);
		}

		// Token: 0x06026EB5 RID: 159413 RVA: 0x0055ACBC File Offset: 0x00558EBC
		public static void StartIStateRepPerfMontagePath(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06026EB6 RID: 159414 RVA: 0x0055ACC5 File Offset: 0x00558EC5
		public static void AddType(FlatBufferBuilder builder, EStateRepPerfType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026EB7 RID: 159415 RVA: 0x0055ACD0 File Offset: 0x00558ED0
		public static void AddMontagePath(FlatBufferBuilder builder, StringOffset montagePathOffset)
		{
			builder.AddOffset(1, montagePathOffset.Value, 0);
		}

		// Token: 0x06026EB8 RID: 159416 RVA: 0x0055ACE0 File Offset: 0x00558EE0
		public static void AddMontageName(FlatBufferBuilder builder, StringOffset montageNameOffset)
		{
			builder.AddOffset(2, montageNameOffset.Value, 0);
		}

		// Token: 0x06026EB9 RID: 159417 RVA: 0x0055ACF0 File Offset: 0x00558EF0
		public static Offset<IStateRepPerfMontagePath> EndIStateRepPerfMontagePath(FlatBufferBuilder builder)
		{
			return new Offset<IStateRepPerfMontagePath>(builder.EndTable());
		}

		// Token: 0x06026EBA RID: 159418 RVA: 0x0055AD00 File Offset: 0x00558F00
		public IStateRepPerfMontagePathT UnPack()
		{
			IStateRepPerfMontagePathT stateRepPerfMontagePathT = new IStateRepPerfMontagePathT();
			this.UnPackTo(stateRepPerfMontagePathT);
			return stateRepPerfMontagePathT;
		}

		// Token: 0x06026EBB RID: 159419 RVA: 0x0055AD1B File Offset: 0x00558F1B
		public void UnPackTo(IStateRepPerfMontagePathT _o)
		{
			_o.Type = this.Type;
			_o.MontagePath = this.MontagePath;
			_o.MontageName = this.MontageName;
		}

		// Token: 0x06026EBC RID: 159420 RVA: 0x0055AD44 File Offset: 0x00558F44
		public static Offset<IStateRepPerfMontagePath> Pack(FlatBufferBuilder builder, IStateRepPerfMontagePathT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStateRepPerfMontagePath>);
			}
			StringOffset montagePathOffset = (_o.MontagePath == null) ? default(StringOffset) : builder.CreateString(_o.MontagePath);
			StringOffset montageNameOffset = (_o.MontageName == null) ? default(StringOffset) : builder.CreateString(_o.MontageName);
			return IStateRepPerfMontagePath.CreateIStateRepPerfMontagePath(builder, _o.Type, montagePathOffset, montageNameOffset);
		}

		// Token: 0x0400EFCC RID: 61388
		private Table __p;
	}
}
