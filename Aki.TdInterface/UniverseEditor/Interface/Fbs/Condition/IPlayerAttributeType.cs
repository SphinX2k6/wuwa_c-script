using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200517E RID: 20862
	public struct IPlayerAttributeType : IFlatbufferObject
	{
		// Token: 0x17009571 RID: 38257
		// (get) Token: 0x06020D3F RID: 134463 RVA: 0x0048B594 File Offset: 0x00489794
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020D40 RID: 134464 RVA: 0x0048B5A1 File Offset: 0x004897A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020D41 RID: 134465 RVA: 0x0048B5A8 File Offset: 0x004897A8
		public static IPlayerAttributeType GetRootAsIPlayerAttributeType(ByteBuffer _bb)
		{
			return IPlayerAttributeType.GetRootAsIPlayerAttributeType(_bb, default(IPlayerAttributeType));
		}

		// Token: 0x06020D42 RID: 134466 RVA: 0x0048B5C4 File Offset: 0x004897C4
		public static IPlayerAttributeType GetRootAsIPlayerAttributeType(ByteBuffer _bb, IPlayerAttributeType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020D43 RID: 134467 RVA: 0x0048B5E1 File Offset: 0x004897E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020D44 RID: 134468 RVA: 0x0048B5F0 File Offset: 0x004897F0
		public IPlayerAttributeType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009572 RID: 38258
		// (get) Token: 0x06020D45 RID: 134469 RVA: 0x0048B600 File Offset: 0x00489800
		public EPlayerAttributeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPlayerAttributeType.Health;
				}
				return (EPlayerAttributeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020D46 RID: 134470 RVA: 0x0048B63C File Offset: 0x0048983C
		public static Offset<IPlayerAttributeType> CreateIPlayerAttributeType(FlatBufferBuilder builder, EPlayerAttributeType Type = EPlayerAttributeType.Health)
		{
			builder.StartTable(1);
			IPlayerAttributeType.AddType(builder, Type);
			return IPlayerAttributeType.EndIPlayerAttributeType(builder);
		}

		// Token: 0x06020D47 RID: 134471 RVA: 0x0048B652 File Offset: 0x00489852
		public static void StartIPlayerAttributeType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06020D48 RID: 134472 RVA: 0x0048B65B File Offset: 0x0048985B
		public static void AddType(FlatBufferBuilder builder, EPlayerAttributeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020D49 RID: 134473 RVA: 0x0048B666 File Offset: 0x00489866
		public static Offset<IPlayerAttributeType> EndIPlayerAttributeType(FlatBufferBuilder builder)
		{
			return new Offset<IPlayerAttributeType>(builder.EndTable());
		}

		// Token: 0x06020D4A RID: 134474 RVA: 0x0048B674 File Offset: 0x00489874
		public IPlayerAttributeTypeT UnPack()
		{
			IPlayerAttributeTypeT playerAttributeTypeT = new IPlayerAttributeTypeT();
			this.UnPackTo(playerAttributeTypeT);
			return playerAttributeTypeT;
		}

		// Token: 0x06020D4B RID: 134475 RVA: 0x0048B68F File Offset: 0x0048988F
		public void UnPackTo(IPlayerAttributeTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06020D4C RID: 134476 RVA: 0x0048B6A0 File Offset: 0x004898A0
		public static Offset<IPlayerAttributeType> Pack(FlatBufferBuilder builder, IPlayerAttributeTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayerAttributeType>);
			}
			return IPlayerAttributeType.CreateIPlayerAttributeType(builder, _o.Type);
		}

		// Token: 0x0400E163 RID: 57699
		private Table __p;
	}
}
