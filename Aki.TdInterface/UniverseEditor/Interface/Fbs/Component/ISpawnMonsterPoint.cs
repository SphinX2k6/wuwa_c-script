using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005956 RID: 22870
	public struct ISpawnMonsterPoint : IFlatbufferObject
	{
		// Token: 0x1700ABB0 RID: 43952
		// (get) Token: 0x06026B65 RID: 158565 RVA: 0x00554BFC File Offset: 0x00552DFC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026B66 RID: 158566 RVA: 0x00554C09 File Offset: 0x00552E09
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026B67 RID: 158567 RVA: 0x00554C10 File Offset: 0x00552E10
		public static ISpawnMonsterPoint GetRootAsISpawnMonsterPoint(ByteBuffer _bb)
		{
			return ISpawnMonsterPoint.GetRootAsISpawnMonsterPoint(_bb, default(ISpawnMonsterPoint));
		}

		// Token: 0x06026B68 RID: 158568 RVA: 0x00554C2C File Offset: 0x00552E2C
		public static ISpawnMonsterPoint GetRootAsISpawnMonsterPoint(ByteBuffer _bb, ISpawnMonsterPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026B69 RID: 158569 RVA: 0x00554C49 File Offset: 0x00552E49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026B6A RID: 158570 RVA: 0x00554C58 File Offset: 0x00552E58
		public ISpawnMonsterPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ABB1 RID: 43953
		// (get) Token: 0x06026B6B RID: 158571 RVA: 0x00554C68 File Offset: 0x00552E68
		public EPointChooseType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPointChooseType.SpawnMonsterPoint;
				}
				return (EPointChooseType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700ABB2 RID: 43954
		// (get) Token: 0x06026B6C RID: 158572 RVA: 0x00554CA4 File Offset: 0x00552EA4
		public ISearchSpawnMonsterPoint? RangeConstraint
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ISearchSpawnMonsterPoint?(default(ISearchSpawnMonsterPoint).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06026B6D RID: 158573 RVA: 0x00554D01 File Offset: 0x00552F01
		public static Offset<ISpawnMonsterPoint> CreateISpawnMonsterPoint(FlatBufferBuilder builder, EPointChooseType Type = EPointChooseType.SpawnMonsterPoint, Offset<ISearchSpawnMonsterPoint> RangeConstraintOffset = default(Offset<ISearchSpawnMonsterPoint>))
		{
			builder.StartTable(2);
			ISpawnMonsterPoint.AddRangeConstraint(builder, RangeConstraintOffset);
			ISpawnMonsterPoint.AddType(builder, Type);
			return ISpawnMonsterPoint.EndISpawnMonsterPoint(builder);
		}

		// Token: 0x06026B6E RID: 158574 RVA: 0x00554D1E File Offset: 0x00552F1E
		public static void StartISpawnMonsterPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06026B6F RID: 158575 RVA: 0x00554D27 File Offset: 0x00552F27
		public static void AddType(FlatBufferBuilder builder, EPointChooseType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026B70 RID: 158576 RVA: 0x00554D32 File Offset: 0x00552F32
		public static void AddRangeConstraint(FlatBufferBuilder builder, Offset<ISearchSpawnMonsterPoint> rangeConstraintOffset)
		{
			builder.AddOffset(1, rangeConstraintOffset.Value, 0);
		}

		// Token: 0x06026B71 RID: 158577 RVA: 0x00554D42 File Offset: 0x00552F42
		public static Offset<ISpawnMonsterPoint> EndISpawnMonsterPoint(FlatBufferBuilder builder)
		{
			return new Offset<ISpawnMonsterPoint>(builder.EndTable());
		}

		// Token: 0x06026B72 RID: 158578 RVA: 0x00554D50 File Offset: 0x00552F50
		public ISpawnMonsterPointT UnPack()
		{
			ISpawnMonsterPointT spawnMonsterPointT = new ISpawnMonsterPointT();
			this.UnPackTo(spawnMonsterPointT);
			return spawnMonsterPointT;
		}

		// Token: 0x06026B73 RID: 158579 RVA: 0x00554D6C File Offset: 0x00552F6C
		public void UnPackTo(ISpawnMonsterPointT _o)
		{
			_o.Type = this.Type;
			_o.RangeConstraint = ((this.RangeConstraint != null) ? this.RangeConstraint.Value.UnPack() : null);
		}

		// Token: 0x06026B74 RID: 158580 RVA: 0x00554DB4 File Offset: 0x00552FB4
		public static Offset<ISpawnMonsterPoint> Pack(FlatBufferBuilder builder, ISpawnMonsterPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpawnMonsterPoint>);
			}
			Offset<ISearchSpawnMonsterPoint> rangeConstraintOffset = (_o.RangeConstraint == null) ? default(Offset<ISearchSpawnMonsterPoint>) : ISearchSpawnMonsterPoint.Pack(builder, _o.RangeConstraint);
			return ISpawnMonsterPoint.CreateISpawnMonsterPoint(builder, _o.Type, rangeConstraintOffset);
		}

		// Token: 0x0400EF38 RID: 61240
		private Table __p;
	}
}
