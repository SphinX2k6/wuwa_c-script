using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Actor
{
	// Token: 0x0200653A RID: 25914
	public struct IActorRef : IFlatbufferObject
	{
		// Token: 0x1700BF27 RID: 48935
		// (get) Token: 0x0602C2B8 RID: 180920 RVA: 0x00603FEF File Offset: 0x006021EF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C2B9 RID: 180921 RVA: 0x00603FFC File Offset: 0x006021FC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C2BA RID: 180922 RVA: 0x00604004 File Offset: 0x00602204
		public static IActorRef GetRootAsIActorRef(ByteBuffer _bb)
		{
			return IActorRef.GetRootAsIActorRef(_bb, default(IActorRef));
		}

		// Token: 0x0602C2BB RID: 180923 RVA: 0x00604020 File Offset: 0x00602220
		public static IActorRef GetRootAsIActorRef(ByteBuffer _bb, IActorRef obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C2BC RID: 180924 RVA: 0x0060403D File Offset: 0x0060223D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C2BD RID: 180925 RVA: 0x0060404C File Offset: 0x0060224C
		public IActorRef __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF28 RID: 48936
		// (get) Token: 0x0602C2BE RID: 180926 RVA: 0x0060405C File Offset: 0x0060225C
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

		// Token: 0x0602C2BF RID: 180927 RVA: 0x00604093 File Offset: 0x00602293
		public Span<byte> GetActorNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602C2C0 RID: 180928 RVA: 0x006040A2 File Offset: 0x006022A2
		public byte[] GetActorNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700BF29 RID: 48937
		// (get) Token: 0x0602C2C1 RID: 180929 RVA: 0x006040B0 File Offset: 0x006022B0
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

		// Token: 0x0602C2C2 RID: 180930 RVA: 0x006040E7 File Offset: 0x006022E7
		public Span<byte> GetPathNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602C2C3 RID: 180931 RVA: 0x006040F6 File Offset: 0x006022F6
		public byte[] GetPathNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700BF2A RID: 48938
		// (get) Token: 0x0602C2C4 RID: 180932 RVA: 0x00604104 File Offset: 0x00602304
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

		// Token: 0x1700BF2B RID: 48939
		// (get) Token: 0x0602C2C5 RID: 180933 RVA: 0x00604140 File Offset: 0x00602340
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

		// Token: 0x0602C2C6 RID: 180934 RVA: 0x0060417D File Offset: 0x0060237D
		public static Offset<IActorRef> CreateIActorRef(FlatBufferBuilder builder, StringOffset ActorNameOffset = default(StringOffset), StringOffset PathNameOffset = default(StringOffset), EActorPlatform Platform = EActorPlatform.Desktop, byte NullMask = 0)
		{
			builder.StartTable(4);
			IActorRef.AddPathName(builder, PathNameOffset);
			IActorRef.AddActorName(builder, ActorNameOffset);
			IActorRef.AddNullMask(builder, NullMask);
			IActorRef.AddPlatform(builder, Platform);
			return IActorRef.EndIActorRef(builder);
		}

		// Token: 0x0602C2C7 RID: 180935 RVA: 0x006041A9 File Offset: 0x006023A9
		public static void StartIActorRef(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602C2C8 RID: 180936 RVA: 0x006041B2 File Offset: 0x006023B2
		public static void AddActorName(FlatBufferBuilder builder, StringOffset actorNameOffset)
		{
			builder.AddOffset(0, actorNameOffset.Value, 0);
		}

		// Token: 0x0602C2C9 RID: 180937 RVA: 0x006041C2 File Offset: 0x006023C2
		public static void AddPathName(FlatBufferBuilder builder, StringOffset pathNameOffset)
		{
			builder.AddOffset(1, pathNameOffset.Value, 0);
		}

		// Token: 0x0602C2CA RID: 180938 RVA: 0x006041D2 File Offset: 0x006023D2
		public static void AddPlatform(FlatBufferBuilder builder, EActorPlatform platform)
		{
			builder.AddByte(2, (byte)platform, 0);
		}

		// Token: 0x0602C2CB RID: 180939 RVA: 0x006041DD File Offset: 0x006023DD
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602C2CC RID: 180940 RVA: 0x006041E8 File Offset: 0x006023E8
		public static Offset<IActorRef> EndIActorRef(FlatBufferBuilder builder)
		{
			return new Offset<IActorRef>(builder.EndTable());
		}

		// Token: 0x0602C2CD RID: 180941 RVA: 0x006041F8 File Offset: 0x006023F8
		public IActorRefT UnPack()
		{
			IActorRefT actorRefT = new IActorRefT();
			this.UnPackTo(actorRefT);
			return actorRefT;
		}

		// Token: 0x0602C2CE RID: 180942 RVA: 0x00604213 File Offset: 0x00602413
		public void UnPackTo(IActorRefT _o)
		{
			_o.ActorName = this.ActorName;
			_o.PathName = this.PathName;
			_o.Platform = this.Platform;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602C2CF RID: 180943 RVA: 0x00604248 File Offset: 0x00602448
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

		// Token: 0x0401075F RID: 67423
		private Table __p;
	}
}
