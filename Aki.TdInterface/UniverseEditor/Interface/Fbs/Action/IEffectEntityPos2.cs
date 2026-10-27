using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200662A RID: 26154
	public struct IEffectEntityPos2 : IFlatbufferObject
	{
		// Token: 0x1700C24C RID: 49740
		// (get) Token: 0x0602D6A3 RID: 186019 RVA: 0x00638C8A File Offset: 0x00636E8A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D6A4 RID: 186020 RVA: 0x00638C97 File Offset: 0x00636E97
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D6A5 RID: 186021 RVA: 0x00638CA0 File Offset: 0x00636EA0
		public static IEffectEntityPos2 GetRootAsIEffectEntityPos2(ByteBuffer _bb)
		{
			return IEffectEntityPos2.GetRootAsIEffectEntityPos2(_bb, default(IEffectEntityPos2));
		}

		// Token: 0x0602D6A6 RID: 186022 RVA: 0x00638CBC File Offset: 0x00636EBC
		public static IEffectEntityPos2 GetRootAsIEffectEntityPos2(ByteBuffer _bb, IEffectEntityPos2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D6A7 RID: 186023 RVA: 0x00638CD9 File Offset: 0x00636ED9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D6A8 RID: 186024 RVA: 0x00638CE8 File Offset: 0x00636EE8
		public IEffectEntityPos2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C24D RID: 49741
		// (get) Token: 0x0602D6A9 RID: 186025 RVA: 0x00638CF8 File Offset: 0x00636EF8
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

		// Token: 0x1700C24E RID: 49742
		// (get) Token: 0x0602D6AA RID: 186026 RVA: 0x00638D34 File Offset: 0x00636F34
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

		// Token: 0x1700C24F RID: 49743
		// (get) Token: 0x0602D6AB RID: 186027 RVA: 0x00638D70 File Offset: 0x00636F70
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

		// Token: 0x1700C250 RID: 49744
		// (get) Token: 0x0602D6AC RID: 186028 RVA: 0x00638DD0 File Offset: 0x00636FD0
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

		// Token: 0x0602D6AD RID: 186029 RVA: 0x00638E08 File Offset: 0x00637008
		public Span<byte> GetAttachSocketBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0602D6AE RID: 186030 RVA: 0x00638E18 File Offset: 0x00637018
		public byte[] GetAttachSocketArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x0602D6AF RID: 186031 RVA: 0x00638E27 File Offset: 0x00637027
		public static Offset<IEffectEntityPos2> CreateIEffectEntityPos2(FlatBufferBuilder builder, EPos2 Type = EPos2.Player, int EntityId = 0, Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>), StringOffset AttachSocketOffset = default(StringOffset))
		{
			builder.StartTable(4);
			IEffectEntityPos2.AddAttachSocket(builder, AttachSocketOffset);
			IEffectEntityPos2.AddOffset(builder, OffsetOffset);
			IEffectEntityPos2.AddEntityId(builder, EntityId);
			IEffectEntityPos2.AddType(builder, Type);
			return IEffectEntityPos2.EndIEffectEntityPos2(builder);
		}

		// Token: 0x0602D6B0 RID: 186032 RVA: 0x00638E53 File Offset: 0x00637053
		public static void StartIEffectEntityPos2(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602D6B1 RID: 186033 RVA: 0x00638E5C File Offset: 0x0063705C
		public static void AddType(FlatBufferBuilder builder, EPos2 type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D6B2 RID: 186034 RVA: 0x00638E67 File Offset: 0x00637067
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0602D6B3 RID: 186035 RVA: 0x00638E72 File Offset: 0x00637072
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(2, offsetOffset.Value, 0);
		}

		// Token: 0x0602D6B4 RID: 186036 RVA: 0x00638E82 File Offset: 0x00637082
		public static void AddAttachSocket(FlatBufferBuilder builder, StringOffset attachSocketOffset)
		{
			builder.AddOffset(3, attachSocketOffset.Value, 0);
		}

		// Token: 0x0602D6B5 RID: 186037 RVA: 0x00638E92 File Offset: 0x00637092
		public static Offset<IEffectEntityPos2> EndIEffectEntityPos2(FlatBufferBuilder builder)
		{
			return new Offset<IEffectEntityPos2>(builder.EndTable());
		}

		// Token: 0x0602D6B6 RID: 186038 RVA: 0x00638EA0 File Offset: 0x006370A0
		public IEffectEntityPos2T UnPack()
		{
			IEffectEntityPos2T effectEntityPos2T = new IEffectEntityPos2T();
			this.UnPackTo(effectEntityPos2T);
			return effectEntityPos2T;
		}

		// Token: 0x0602D6B7 RID: 186039 RVA: 0x00638EBC File Offset: 0x006370BC
		public void UnPackTo(IEffectEntityPos2T _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
			_o.AttachSocket = this.AttachSocket;
		}

		// Token: 0x0602D6B8 RID: 186040 RVA: 0x00638F1C File Offset: 0x0063711C
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

		// Token: 0x04010CBA RID: 68794
		private Table __p;
	}
}
