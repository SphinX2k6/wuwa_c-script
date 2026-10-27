using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068F4 RID: 26868
	public struct IHideRangeType : IFlatbufferObject
	{
		// Token: 0x1700C759 RID: 51033
		// (get) Token: 0x0602EDF3 RID: 191987 RVA: 0x00664E42 File Offset: 0x00663042
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EDF4 RID: 191988 RVA: 0x00664E4F File Offset: 0x0066304F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EDF5 RID: 191989 RVA: 0x00664E58 File Offset: 0x00663058
		public static IHideRangeType GetRootAsIHideRangeType(ByteBuffer _bb)
		{
			return IHideRangeType.GetRootAsIHideRangeType(_bb, default(IHideRangeType));
		}

		// Token: 0x0602EDF6 RID: 191990 RVA: 0x00664E74 File Offset: 0x00663074
		public static IHideRangeType GetRootAsIHideRangeType(ByteBuffer _bb, IHideRangeType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EDF7 RID: 191991 RVA: 0x00664E91 File Offset: 0x00663091
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EDF8 RID: 191992 RVA: 0x00664EA0 File Offset: 0x006630A0
		public IHideRangeType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C75A RID: 51034
		// (get) Token: 0x0602EDF9 RID: 191993 RVA: 0x00664EB0 File Offset: 0x006630B0
		public EHideType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHideType.WorldMonsterAndMonsterTreasure;
				}
				return (EHideType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EDFA RID: 191994 RVA: 0x00664EEC File Offset: 0x006630EC
		public static Offset<IHideRangeType> CreateIHideRangeType(FlatBufferBuilder builder, EHideType Type = EHideType.WorldMonsterAndMonsterTreasure)
		{
			builder.StartTable(1);
			IHideRangeType.AddType(builder, Type);
			return IHideRangeType.EndIHideRangeType(builder);
		}

		// Token: 0x0602EDFB RID: 191995 RVA: 0x00664F02 File Offset: 0x00663102
		public static void StartIHideRangeType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602EDFC RID: 191996 RVA: 0x00664F0B File Offset: 0x0066310B
		public static void AddType(FlatBufferBuilder builder, EHideType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EDFD RID: 191997 RVA: 0x00664F16 File Offset: 0x00663116
		public static Offset<IHideRangeType> EndIHideRangeType(FlatBufferBuilder builder)
		{
			return new Offset<IHideRangeType>(builder.EndTable());
		}

		// Token: 0x0602EDFE RID: 191998 RVA: 0x00664F24 File Offset: 0x00663124
		public IHideRangeTypeT UnPack()
		{
			IHideRangeTypeT hideRangeTypeT = new IHideRangeTypeT();
			this.UnPackTo(hideRangeTypeT);
			return hideRangeTypeT;
		}

		// Token: 0x0602EDFF RID: 191999 RVA: 0x00664F3F File Offset: 0x0066313F
		public void UnPackTo(IHideRangeTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602EE00 RID: 192000 RVA: 0x00664F50 File Offset: 0x00663150
		public static Offset<IHideRangeType> Pack(FlatBufferBuilder builder, IHideRangeTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHideRangeType>);
			}
			return IHideRangeType.CreateIHideRangeType(builder, _o.Type);
		}

		// Token: 0x04011064 RID: 69732
		private Table __p;
	}
}
