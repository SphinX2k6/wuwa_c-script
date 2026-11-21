using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C9B RID: 27803
	public struct IEffectEntityPos2 : IFlatbufferObject
	{
		// Token: 0x1700CBEA RID: 52202
		// (get) Token: 0x0602FE74 RID: 196212 RVA: 0x006857F2 File Offset: 0x006839F2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FE75 RID: 196213 RVA: 0x006857FF File Offset: 0x006839FF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FE76 RID: 196214 RVA: 0x00685808 File Offset: 0x00683A08
		public static IEffectEntityPos2 GetRootAsIEffectEntityPos2(ByteBuffer _bb)
		{
			return IEffectEntityPos2.GetRootAsIEffectEntityPos2(_bb, default(IEffectEntityPos2));
		}

		// Token: 0x0602FE77 RID: 196215 RVA: 0x00685824 File Offset: 0x00683A24
		public static IEffectEntityPos2 GetRootAsIEffectEntityPos2(ByteBuffer _bb, IEffectEntityPos2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FE78 RID: 196216 RVA: 0x00685841 File Offset: 0x00683A41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FE79 RID: 196217 RVA: 0x00685850 File Offset: 0x00683A50
		public IEffectEntityPos2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CBEB RID: 52203
		// (get) Token: 0x0602FE7A RID: 196218 RVA: 0x00685860 File Offset: 0x00683A60
		public EPos2 Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPos2.Player;
				}
				return (EPos2)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CBEC RID: 52204
		// (get) Token: 0x0602FE7B RID: 196219 RVA: 0x0068589C File Offset: 0x00683A9C
		public int EntityId
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

		// Token: 0x1700CBED RID: 52205
		// (get) Token: 0x0602FE7C RID: 196220 RVA: 0x006858D8 File Offset: 0x00683AD8
		public IVectorInfo? Offset
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CBEE RID: 52206
		// (get) Token: 0x0602FE7D RID: 196221 RVA: 0x00685938 File Offset: 0x00683B38
		public string AttachSocket
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FE7E RID: 196222 RVA: 0x00685970 File Offset: 0x00683B70
		public Span<byte> GetAttachSocketBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0602FE7F RID: 196223 RVA: 0x00685980 File Offset: 0x00683B80
		public byte[] GetAttachSocketArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x0602FE80 RID: 196224 RVA: 0x0068598F File Offset: 0x00683B8F
		public static Offset<IEffectEntityPos2> CreateIEffectEntityPos2(FlatBufferBuilder builder, EPos2 Type = EPos2.Player, int EntityId = 0, Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>), StringOffset AttachSocketOffset = default(StringOffset))
		{
			builder.StartTable(4);
			IEffectEntityPos2.AddAttachSocket(builder, AttachSocketOffset);
			IEffectEntityPos2.AddOffset(builder, OffsetOffset);
			IEffectEntityPos2.AddEntityId(builder, EntityId);
			IEffectEntityPos2.AddType(builder, Type);
			return IEffectEntityPos2.EndIEffectEntityPos2(builder);
		}

		// Token: 0x0602FE81 RID: 196225 RVA: 0x006859BB File Offset: 0x00683BBB
		public static void StartIEffectEntityPos2(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602FE82 RID: 196226 RVA: 0x006859C4 File Offset: 0x00683BC4
		public static void AddType(FlatBufferBuilder builder, EPos2 type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FE83 RID: 196227 RVA: 0x006859CF File Offset: 0x00683BCF
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0602FE84 RID: 196228 RVA: 0x006859DA File Offset: 0x00683BDA
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(2, offsetOffset.Value, 0);
		}

		// Token: 0x0602FE85 RID: 196229 RVA: 0x006859EA File Offset: 0x00683BEA
		public static void AddAttachSocket(FlatBufferBuilder builder, StringOffset attachSocketOffset)
		{
			builder.AddOffset(3, attachSocketOffset.Value, 0);
		}

		// Token: 0x0602FE86 RID: 196230 RVA: 0x006859FA File Offset: 0x00683BFA
		public static Offset<IEffectEntityPos2> EndIEffectEntityPos2(FlatBufferBuilder builder)
		{
			return new Offset<IEffectEntityPos2>(builder.EndTable());
		}

		// Token: 0x0602FE87 RID: 196231 RVA: 0x00685A08 File Offset: 0x00683C08
		public IEffectEntityPos2T UnPack()
		{
			IEffectEntityPos2T effectEntityPos2T = new IEffectEntityPos2T();
			this.UnPackTo(effectEntityPos2T);
			return effectEntityPos2T;
		}

		// Token: 0x0602FE88 RID: 196232 RVA: 0x00685A24 File Offset: 0x00683C24
		public void UnPackTo(IEffectEntityPos2T _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
			_o.AttachSocket = this.AttachSocket;
		}

		// Token: 0x0602FE89 RID: 196233 RVA: 0x00685A84 File Offset: 0x00683C84
		public static Offset<IEffectEntityPos2> Pack(FlatBufferBuilder builder, IEffectEntityPos2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IEffectEntityPos2>);
			}
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			StringOffset attachSocketOffset = (_o.AttachSocket == null) ? default(StringOffset) : builder.CreateString(_o.AttachSocket);
			return IEffectEntityPos2.CreateIEffectEntityPos2(builder, _o.Type, _o.EntityId, offsetOffset, attachSocketOffset);
		}

		// Token: 0x04011AD5 RID: 72405
		private Table __p;
	}
}
