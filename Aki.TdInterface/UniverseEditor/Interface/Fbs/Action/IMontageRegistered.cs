using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200723A RID: 29242
	public struct IMontageRegistered : IFlatbufferObject
	{
		// Token: 0x1700D633 RID: 54835
		// (get) Token: 0x06032E8C RID: 208524 RVA: 0x006DF9B7 File Offset: 0x006DDBB7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032E8D RID: 208525 RVA: 0x006DF9C4 File Offset: 0x006DDBC4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032E8E RID: 208526 RVA: 0x006DF9CC File Offset: 0x006DDBCC
		public static IMontageRegistered GetRootAsIMontageRegistered(ByteBuffer _bb)
		{
			return IMontageRegistered.GetRootAsIMontageRegistered(_bb, default(IMontageRegistered));
		}

		// Token: 0x06032E8F RID: 208527 RVA: 0x006DF9E8 File Offset: 0x006DDBE8
		public static IMontageRegistered GetRootAsIMontageRegistered(ByteBuffer _bb, IMontageRegistered obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032E90 RID: 208528 RVA: 0x006DFA05 File Offset: 0x006DDC05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032E91 RID: 208529 RVA: 0x006DFA14 File Offset: 0x006DDC14
		public IMontageRegistered __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D634 RID: 54836
		// (get) Token: 0x06032E92 RID: 208530 RVA: 0x006DFA24 File Offset: 0x006DDC24
		public EMontageConfigType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMontageConfigType.Asset;
				}
				return (EMontageConfigType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D635 RID: 54837
		// (get) Token: 0x06032E93 RID: 208531 RVA: 0x006DFA60 File Offset: 0x006DDC60
		public IMontageId? MontageId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IMontageId?(default(IMontageId).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06032E94 RID: 208532 RVA: 0x006DFABD File Offset: 0x006DDCBD
		public static Offset<IMontageRegistered> CreateIMontageRegistered(FlatBufferBuilder builder, EMontageConfigType Type = EMontageConfigType.Asset, Offset<IMontageId> MontageIdOffset = default(Offset<IMontageId>))
		{
			builder.StartTable(2);
			IMontageRegistered.AddMontageId(builder, MontageIdOffset);
			IMontageRegistered.AddType(builder, Type);
			return IMontageRegistered.EndIMontageRegistered(builder);
		}

		// Token: 0x06032E95 RID: 208533 RVA: 0x006DFADA File Offset: 0x006DDCDA
		public static void StartIMontageRegistered(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032E96 RID: 208534 RVA: 0x006DFAE3 File Offset: 0x006DDCE3
		public static void AddType(FlatBufferBuilder builder, EMontageConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032E97 RID: 208535 RVA: 0x006DFAEE File Offset: 0x006DDCEE
		public static void AddMontageId(FlatBufferBuilder builder, Offset<IMontageId> montageIdOffset)
		{
			builder.AddOffset(1, montageIdOffset.Value, 0);
		}

		// Token: 0x06032E98 RID: 208536 RVA: 0x006DFAFE File Offset: 0x006DDCFE
		public static Offset<IMontageRegistered> EndIMontageRegistered(FlatBufferBuilder builder)
		{
			return new Offset<IMontageRegistered>(builder.EndTable());
		}

		// Token: 0x06032E99 RID: 208537 RVA: 0x006DFB0C File Offset: 0x006DDD0C
		public IMontageRegisteredT UnPack()
		{
			IMontageRegisteredT montageRegisteredT = new IMontageRegisteredT();
			this.UnPackTo(montageRegisteredT);
			return montageRegisteredT;
		}

		// Token: 0x06032E9A RID: 208538 RVA: 0x006DFB28 File Offset: 0x006DDD28
		public void UnPackTo(IMontageRegisteredT _o)
		{
			_o.Type = this.Type;
			_o.MontageId = ((this.MontageId != null) ? this.MontageId.Value.UnPack() : null);
		}

		// Token: 0x06032E9B RID: 208539 RVA: 0x006DFB70 File Offset: 0x006DDD70
		public static Offset<IMontageRegistered> Pack(FlatBufferBuilder builder, IMontageRegisteredT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMontageRegistered>);
			}
			Offset<IMontageId> montageIdOffset = (_o.MontageId == null) ? default(Offset<IMontageId>) : IMontageId.Pack(builder, _o.MontageId);
			return IMontageRegistered.CreateIMontageRegistered(builder, _o.Type, montageIdOffset);
		}

		// Token: 0x04012287 RID: 74375
		private Table __p;
	}
}
