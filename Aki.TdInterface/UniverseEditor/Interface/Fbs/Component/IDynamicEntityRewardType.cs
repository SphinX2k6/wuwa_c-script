using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005643 RID: 22083
	public struct IDynamicEntityRewardType : IFlatbufferObject
	{
		// Token: 0x17009EA6 RID: 40614
		// (get) Token: 0x06023489 RID: 144521 RVA: 0x004DADDF File Offset: 0x004D8FDF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602348A RID: 144522 RVA: 0x004DADEC File Offset: 0x004D8FEC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602348B RID: 144523 RVA: 0x004DADF4 File Offset: 0x004D8FF4
		public static IDynamicEntityRewardType GetRootAsIDynamicEntityRewardType(ByteBuffer _bb)
		{
			return IDynamicEntityRewardType.GetRootAsIDynamicEntityRewardType(_bb, default(IDynamicEntityRewardType));
		}

		// Token: 0x0602348C RID: 144524 RVA: 0x004DAE10 File Offset: 0x004D9010
		public static IDynamicEntityRewardType GetRootAsIDynamicEntityRewardType(ByteBuffer _bb, IDynamicEntityRewardType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602348D RID: 144525 RVA: 0x004DAE2D File Offset: 0x004D902D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602348E RID: 144526 RVA: 0x004DAE3C File Offset: 0x004D903C
		public IDynamicEntityRewardType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009EA7 RID: 40615
		// (get) Token: 0x0602348F RID: 144527 RVA: 0x004DAE4C File Offset: 0x004D904C
		public EDynamicEntityRewardType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDynamicEntityRewardType.Traffic;
				}
				return (EDynamicEntityRewardType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023490 RID: 144528 RVA: 0x004DAE88 File Offset: 0x004D9088
		public static Offset<IDynamicEntityRewardType> CreateIDynamicEntityRewardType(FlatBufferBuilder builder, EDynamicEntityRewardType Type = EDynamicEntityRewardType.Traffic)
		{
			builder.StartTable(1);
			IDynamicEntityRewardType.AddType(builder, Type);
			return IDynamicEntityRewardType.EndIDynamicEntityRewardType(builder);
		}

		// Token: 0x06023491 RID: 144529 RVA: 0x004DAE9E File Offset: 0x004D909E
		public static void StartIDynamicEntityRewardType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06023492 RID: 144530 RVA: 0x004DAEA7 File Offset: 0x004D90A7
		public static void AddType(FlatBufferBuilder builder, EDynamicEntityRewardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023493 RID: 144531 RVA: 0x004DAEB2 File Offset: 0x004D90B2
		public static Offset<IDynamicEntityRewardType> EndIDynamicEntityRewardType(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicEntityRewardType>(builder.EndTable());
		}

		// Token: 0x06023494 RID: 144532 RVA: 0x004DAEC0 File Offset: 0x004D90C0
		public IDynamicEntityRewardTypeT UnPack()
		{
			IDynamicEntityRewardTypeT dynamicEntityRewardTypeT = new IDynamicEntityRewardTypeT();
			this.UnPackTo(dynamicEntityRewardTypeT);
			return dynamicEntityRewardTypeT;
		}

		// Token: 0x06023495 RID: 144533 RVA: 0x004DAEDB File Offset: 0x004D90DB
		public void UnPackTo(IDynamicEntityRewardTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06023496 RID: 144534 RVA: 0x004DAEEC File Offset: 0x004D90EC
		public static Offset<IDynamicEntityRewardType> Pack(FlatBufferBuilder builder, IDynamicEntityRewardTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDynamicEntityRewardType>);
			}
			return IDynamicEntityRewardType.CreateIDynamicEntityRewardType(builder, _o.Type);
		}

		// Token: 0x0400ED2B RID: 60715
		private Table __p;
	}
}
