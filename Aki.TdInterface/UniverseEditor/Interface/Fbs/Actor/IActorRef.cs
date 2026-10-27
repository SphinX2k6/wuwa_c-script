using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Actor
{
	// Token: 0x02005EF7 RID: 24311
	public struct IActorRef : IFlatbufferObject
	{
		// Token: 0x1700B5BC RID: 46524
		// (get) Token: 0x06029C04 RID: 171012 RVA: 0x005BAB0B File Offset: 0x005B8D0B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029C05 RID: 171013 RVA: 0x005BAB18 File Offset: 0x005B8D18
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029C06 RID: 171014 RVA: 0x005BAB20 File Offset: 0x005B8D20
		public static IActorRef GetRootAsIActorRef(ByteBuffer _bb)
		{
			return IActorRef.GetRootAsIActorRef(_bb, default(IActorRef));
		}

		// Token: 0x06029C07 RID: 171015 RVA: 0x005BAB3C File Offset: 0x005B8D3C
		public static IActorRef GetRootAsIActorRef(ByteBuffer _bb, IActorRef obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029C08 RID: 171016 RVA: 0x005BAB59 File Offset: 0x005B8D59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029C09 RID: 171017 RVA: 0x005BAB68 File Offset: 0x005B8D68
		public IActorRef __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B5BD RID: 46525
		// (get) Token: 0x06029C0A RID: 171018 RVA: 0x005BAB78 File Offset: 0x005B8D78
		public string ActorName
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029C0B RID: 171019 RVA: 0x005BABAF File Offset: 0x005B8DAF
		public Span<byte> GetActorNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06029C0C RID: 171020 RVA: 0x005BABBE File Offset: 0x005B8DBE
		public byte[] GetActorNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700B5BE RID: 46526
		// (get) Token: 0x06029C0D RID: 171021 RVA: 0x005BABCC File Offset: 0x005B8DCC
		public string PathName
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

		// Token: 0x06029C0E RID: 171022 RVA: 0x005BAC03 File Offset: 0x005B8E03
		public Span<byte> GetPathNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06029C0F RID: 171023 RVA: 0x005BAC12 File Offset: 0x005B8E12
		public byte[] GetPathNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700B5BF RID: 46527
		// (get) Token: 0x06029C10 RID: 171024 RVA: 0x005BAC20 File Offset: 0x005B8E20
		public EActorPlatform Platform
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EActorPlatform.Desktop;
				}
				return (EActorPlatform)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B5C0 RID: 46528
		// (get) Token: 0x06029C11 RID: 171025 RVA: 0x005BAC5C File Offset: 0x005B8E5C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029C12 RID: 171026 RVA: 0x005BAC99 File Offset: 0x005B8E99
		public static Offset<IActorRef> CreateIActorRef(FlatBufferBuilder builder, StringOffset ActorNameOffset = default(StringOffset), StringOffset PathNameOffset = default(StringOffset), EActorPlatform Platform = EActorPlatform.Desktop, byte NullMask = 0)
		{
			builder.StartTable(4);
			IActorRef.AddPathName(builder, PathNameOffset);
			IActorRef.AddActorName(builder, ActorNameOffset);
			IActorRef.AddNullMask(builder, NullMask);
			IActorRef.AddPlatform(builder, Platform);
			return IActorRef.EndIActorRef(builder);
		}

		// Token: 0x06029C13 RID: 171027 RVA: 0x005BACC5 File Offset: 0x005B8EC5
		public static void StartIActorRef(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06029C14 RID: 171028 RVA: 0x005BACCE File Offset: 0x005B8ECE
		public static void AddActorName(FlatBufferBuilder builder, StringOffset actorNameOffset)
		{
			builder.AddOffset(0, actorNameOffset.Value, 0);
		}

		// Token: 0x06029C15 RID: 171029 RVA: 0x005BACDE File Offset: 0x005B8EDE
		public static void AddPathName(FlatBufferBuilder builder, StringOffset pathNameOffset)
		{
			builder.AddOffset(1, pathNameOffset.Value, 0);
		}

		// Token: 0x06029C16 RID: 171030 RVA: 0x005BACEE File Offset: 0x005B8EEE
		public static void AddPlatform(FlatBufferBuilder builder, EActorPlatform platform)
		{
			builder.AddByte(2, (byte)platform, 0);
		}

		// Token: 0x06029C17 RID: 171031 RVA: 0x005BACF9 File Offset: 0x005B8EF9
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06029C18 RID: 171032 RVA: 0x005BAD04 File Offset: 0x005B8F04
		public static Offset<IActorRef> EndIActorRef(FlatBufferBuilder builder)
		{
			return new Offset<IActorRef>(builder.EndTable());
		}

		// Token: 0x06029C19 RID: 171033 RVA: 0x005BAD14 File Offset: 0x005B8F14
		public IActorRefT UnPack()
		{
			IActorRefT actorRefT = new IActorRefT();
			this.UnPackTo(actorRefT);
			return actorRefT;
		}

		// Token: 0x06029C1A RID: 171034 RVA: 0x005BAD2F File Offset: 0x005B8F2F
		public void UnPackTo(IActorRefT _o)
		{
			_o.ActorName = this.ActorName;
			_o.PathName = this.PathName;
			_o.Platform = this.Platform;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06029C1B RID: 171035 RVA: 0x005BAD64 File Offset: 0x005B8F64
		public static Offset<IActorRef> Pack(FlatBufferBuilder builder, IActorRefT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorRef>);
			}
			StringOffset actorNameOffset = (_o.ActorName == null) ? default(StringOffset) : builder.CreateString(_o.ActorName);
			StringOffset pathNameOffset = (_o.PathName == null) ? default(StringOffset) : builder.CreateString(_o.PathName);
			return IActorRef.CreateIActorRef(builder, actorNameOffset, pathNameOffset, _o.Platform, _o.NullMask);
		}

		// Token: 0x0400F9FB RID: 63995
		private Table __p;
	}
}
