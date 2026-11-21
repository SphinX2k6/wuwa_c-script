using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200507C RID: 20604
	public struct ICompareDungeonId : IFlatbufferObject
	{
		// Token: 0x1700937A RID: 37754
		// (get) Token: 0x0602038E RID: 131982 RVA: 0x004775D4 File Offset: 0x004757D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602038F RID: 131983 RVA: 0x004775E1 File Offset: 0x004757E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020390 RID: 131984 RVA: 0x004775E8 File Offset: 0x004757E8
		public static ICompareDungeonId GetRootAsICompareDungeonId(ByteBuffer _bb)
		{
			return ICompareDungeonId.GetRootAsICompareDungeonId(_bb, default(ICompareDungeonId));
		}

		// Token: 0x06020391 RID: 131985 RVA: 0x00477604 File Offset: 0x00475804
		public static ICompareDungeonId GetRootAsICompareDungeonId(ByteBuffer _bb, ICompareDungeonId obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020392 RID: 131986 RVA: 0x00477621 File Offset: 0x00475821
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020393 RID: 131987 RVA: 0x00477630 File Offset: 0x00475830
		public ICompareDungeonId __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700937B RID: 37755
		// (get) Token: 0x06020394 RID: 131988 RVA: 0x00477640 File Offset: 0x00475840
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700937C RID: 37756
		// (get) Token: 0x06020395 RID: 131989 RVA: 0x0047767C File Offset: 0x0047587C
		public int DungeonId
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

		// Token: 0x1700937D RID: 37757
		// (get) Token: 0x06020396 RID: 131990 RVA: 0x004776B8 File Offset: 0x004758B8
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020397 RID: 131991 RVA: 0x004776F4 File Offset: 0x004758F4
		public static Offset<ICompareDungeonId> CreateICompareDungeonId(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int DungeonId = 0, ECompare Compare = ECompare.Eq)
		{
			builder.StartTable(3);
			ICompareDungeonId.AddDungeonId(builder, DungeonId);
			ICompareDungeonId.AddCompare(builder, Compare);
			ICompareDungeonId.AddType(builder, Type);
			return ICompareDungeonId.EndICompareDungeonId(builder);
		}

		// Token: 0x06020398 RID: 131992 RVA: 0x00477718 File Offset: 0x00475918
		public static void StartICompareDungeonId(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06020399 RID: 131993 RVA: 0x00477721 File Offset: 0x00475921
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602039A RID: 131994 RVA: 0x0047772C File Offset: 0x0047592C
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(1, dungeonId, 0);
		}

		// Token: 0x0602039B RID: 131995 RVA: 0x00477737 File Offset: 0x00475937
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0602039C RID: 131996 RVA: 0x00477742 File Offset: 0x00475942
		public static Offset<ICompareDungeonId> EndICompareDungeonId(FlatBufferBuilder builder)
		{
			return new Offset<ICompareDungeonId>(builder.EndTable());
		}

		// Token: 0x0602039D RID: 131997 RVA: 0x00477750 File Offset: 0x00475950
		public ICompareDungeonIdT UnPack()
		{
			ICompareDungeonIdT compareDungeonIdT = new ICompareDungeonIdT();
			this.UnPackTo(compareDungeonIdT);
			return compareDungeonIdT;
		}

		// Token: 0x0602039E RID: 131998 RVA: 0x0047776B File Offset: 0x0047596B
		public void UnPackTo(ICompareDungeonIdT _o)
		{
			_o.Type = this.Type;
			_o.DungeonId = this.DungeonId;
			_o.Compare = this.Compare;
		}

		// Token: 0x0602039F RID: 131999 RVA: 0x00477794 File Offset: 0x00475994
		public static Offset<ICompareDungeonId> Pack(FlatBufferBuilder builder, ICompareDungeonIdT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareDungeonId>);
			}
			return ICompareDungeonId.CreateICompareDungeonId(builder, _o.Type, _o.DungeonId, _o.Compare);
		}

		// Token: 0x0400DF6E RID: 57198
		private Table __p;
	}
}
