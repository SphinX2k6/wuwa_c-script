using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003DEA RID: 15850
	public struct IBlackBoardEntityId : IFlatbufferObject
	{
		// Token: 0x17006B0A RID: 27402
		// (get) Token: 0x0601546B RID: 87147 RVA: 0x00313B7A File Offset: 0x00311D7A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601546C RID: 87148 RVA: 0x00313B87 File Offset: 0x00311D87
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601546D RID: 87149 RVA: 0x00313B90 File Offset: 0x00311D90
		public static IBlackBoardEntityId GetRootAsIBlackBoardEntityId(ByteBuffer _bb)
		{
			return IBlackBoardEntityId.GetRootAsIBlackBoardEntityId(_bb, default(IBlackBoardEntityId));
		}

		// Token: 0x0601546E RID: 87150 RVA: 0x00313BAC File Offset: 0x00311DAC
		public static IBlackBoardEntityId GetRootAsIBlackBoardEntityId(ByteBuffer _bb, IBlackBoardEntityId obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601546F RID: 87151 RVA: 0x00313BC9 File Offset: 0x00311DC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015470 RID: 87152 RVA: 0x00313BD8 File Offset: 0x00311DD8
		public IBlackBoardEntityId __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B0B RID: 27403
		// (get) Token: 0x06015471 RID: 87153 RVA: 0x00313BE8 File Offset: 0x00311DE8
		public EBlackBoardType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBlackBoardType.Boolean;
				}
				return (EBlackBoardType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006B0C RID: 27404
		// (get) Token: 0x06015472 RID: 87154 RVA: 0x00313C24 File Offset: 0x00311E24
		public string Key
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

		// Token: 0x06015473 RID: 87155 RVA: 0x00313C5B File Offset: 0x00311E5B
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06015474 RID: 87156 RVA: 0x00313C6A File Offset: 0x00311E6A
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17006B0D RID: 27405
		// (get) Token: 0x06015475 RID: 87157 RVA: 0x00313C78 File Offset: 0x00311E78
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015476 RID: 87158 RVA: 0x00313CB4 File Offset: 0x00311EB4
		public static Offset<IBlackBoardEntityId> CreateIBlackBoardEntityId(FlatBufferBuilder builder, EBlackBoardType Type = EBlackBoardType.Boolean, StringOffset KeyOffset = default(StringOffset), int EntityId = 0)
		{
			builder.StartTable(3);
			IBlackBoardEntityId.AddEntityId(builder, EntityId);
			IBlackBoardEntityId.AddKey(builder, KeyOffset);
			IBlackBoardEntityId.AddType(builder, Type);
			return IBlackBoardEntityId.EndIBlackBoardEntityId(builder);
		}

		// Token: 0x06015477 RID: 87159 RVA: 0x00313CD8 File Offset: 0x00311ED8
		public static void StartIBlackBoardEntityId(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06015478 RID: 87160 RVA: 0x00313CE1 File Offset: 0x00311EE1
		public static void AddType(FlatBufferBuilder builder, EBlackBoardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015479 RID: 87161 RVA: 0x00313CEC File Offset: 0x00311EEC
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(1, keyOffset.Value, 0);
		}

		// Token: 0x0601547A RID: 87162 RVA: 0x00313CFC File Offset: 0x00311EFC
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(2, entityId, 0);
		}

		// Token: 0x0601547B RID: 87163 RVA: 0x00313D07 File Offset: 0x00311F07
		public static Offset<IBlackBoardEntityId> EndIBlackBoardEntityId(FlatBufferBuilder builder)
		{
			return new Offset<IBlackBoardEntityId>(builder.EndTable());
		}

		// Token: 0x0601547C RID: 87164 RVA: 0x00313D14 File Offset: 0x00311F14
		public IBlackBoardEntityIdT UnPack()
		{
			IBlackBoardEntityIdT blackBoardEntityIdT = new IBlackBoardEntityIdT();
			this.UnPackTo(blackBoardEntityIdT);
			return blackBoardEntityIdT;
		}

		// Token: 0x0601547D RID: 87165 RVA: 0x00313D2F File Offset: 0x00311F2F
		public void UnPackTo(IBlackBoardEntityIdT _o)
		{
			_o.Type = this.Type;
			_o.Key = this.Key;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x0601547E RID: 87166 RVA: 0x00313D58 File Offset: 0x00311F58
		public static Offset<IBlackBoardEntityId> Pack(FlatBufferBuilder builder, IBlackBoardEntityIdT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBlackBoardEntityId>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			return IBlackBoardEntityId.CreateIBlackBoardEntityId(builder, _o.Type, keyOffset, _o.EntityId);
		}

		// Token: 0x0400B79A RID: 47002
		private Table __p;
	}
}
