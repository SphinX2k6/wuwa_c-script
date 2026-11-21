using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F63 RID: 24419
	public struct ISpawnMonsterPoint : IFlatbufferObject
	{
		// Token: 0x1700B4E4 RID: 46308
		// (get) Token: 0x060290CF RID: 168143 RVA: 0x0059B868 File Offset: 0x00599A68
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060290D0 RID: 168144 RVA: 0x0059B875 File Offset: 0x00599A75
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060290D1 RID: 168145 RVA: 0x0059B87C File Offset: 0x00599A7C
		public static ISpawnMonsterPoint GetRootAsISpawnMonsterPoint(ByteBuffer _bb)
		{
			return ISpawnMonsterPoint.GetRootAsISpawnMonsterPoint(_bb, default(ISpawnMonsterPoint));
		}

		// Token: 0x060290D2 RID: 168146 RVA: 0x0059B898 File Offset: 0x00599A98
		public static ISpawnMonsterPoint GetRootAsISpawnMonsterPoint(ByteBuffer _bb, ISpawnMonsterPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060290D3 RID: 168147 RVA: 0x0059B8B5 File Offset: 0x00599AB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060290D4 RID: 168148 RVA: 0x0059B8C4 File Offset: 0x00599AC4
		public ISpawnMonsterPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B4E5 RID: 46309
		// (get) Token: 0x060290D5 RID: 168149 RVA: 0x0059B8D4 File Offset: 0x00599AD4
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

		// Token: 0x1700B4E6 RID: 46310
		// (get) Token: 0x060290D6 RID: 168150 RVA: 0x0059B910 File Offset: 0x00599B10
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

		// Token: 0x060290D7 RID: 168151 RVA: 0x0059B96D File Offset: 0x00599B6D
		public static Offset<ISpawnMonsterPoint> CreateISpawnMonsterPoint(FlatBufferBuilder builder, EPointChooseType Type = EPointChooseType.SpawnMonsterPoint, Offset<ISearchSpawnMonsterPoint> RangeConstraintOffset = default(Offset<ISearchSpawnMonsterPoint>))
		{
			builder.StartTable(2);
			ISpawnMonsterPoint.AddRangeConstraint(builder, RangeConstraintOffset);
			ISpawnMonsterPoint.AddType(builder, Type);
			return ISpawnMonsterPoint.EndISpawnMonsterPoint(builder);
		}

		// Token: 0x060290D8 RID: 168152 RVA: 0x0059B98A File Offset: 0x00599B8A
		public static void StartISpawnMonsterPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060290D9 RID: 168153 RVA: 0x0059B993 File Offset: 0x00599B93
		public static void AddType(FlatBufferBuilder builder, EPointChooseType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060290DA RID: 168154 RVA: 0x0059B99E File Offset: 0x00599B9E
		public static void AddRangeConstraint(FlatBufferBuilder builder, Offset<ISearchSpawnMonsterPoint> rangeConstraintOffset)
		{
			builder.AddOffset(1, rangeConstraintOffset.Value, 0);
		}

		// Token: 0x060290DB RID: 168155 RVA: 0x0059B9AE File Offset: 0x00599BAE
		public static Offset<ISpawnMonsterPoint> EndISpawnMonsterPoint(FlatBufferBuilder builder)
		{
			return new Offset<ISpawnMonsterPoint>(builder.EndTable());
		}

		// Token: 0x060290DC RID: 168156 RVA: 0x0059B9BC File Offset: 0x00599BBC
		public ISpawnMonsterPointT UnPack()
		{
			ISpawnMonsterPointT spawnMonsterPointT = new ISpawnMonsterPointT();
			this.UnPackTo(spawnMonsterPointT);
			return spawnMonsterPointT;
		}

		// Token: 0x060290DD RID: 168157 RVA: 0x0059B9D8 File Offset: 0x00599BD8
		public void UnPackTo(ISpawnMonsterPointT _o)
		{
			_o.Type = this.Type;
			_o.RangeConstraint = ((this.RangeConstraint != null) ? this.RangeConstraint.Value.UnPack() : null);
		}

		// Token: 0x060290DE RID: 168158 RVA: 0x0059BA20 File Offset: 0x00599C20
		public static Offset<ISpawnMonsterPoint> Pack(FlatBufferBuilder builder, ISpawnMonsterPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpawnMonsterPoint>);
			}
			Offset<ISearchSpawnMonsterPoint> rangeConstraintOffset = (_o.RangeConstraint == null) ? default(Offset<ISearchSpawnMonsterPoint>) : ISearchSpawnMonsterPoint.Pack(builder, _o.RangeConstraint);
			return ISpawnMonsterPoint.CreateISpawnMonsterPoint(builder, _o.Type, rangeConstraintOffset);
		}

		// Token: 0x0400FC2D RID: 64557
		private Table __p;
	}
}
