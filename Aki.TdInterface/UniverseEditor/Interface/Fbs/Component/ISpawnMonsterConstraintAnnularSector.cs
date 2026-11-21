using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F60 RID: 24416
	public struct ISpawnMonsterConstraintAnnularSector : IFlatbufferObject
	{
		// Token: 0x1700B4DB RID: 46299
		// (get) Token: 0x060290B1 RID: 168113 RVA: 0x0059B51F File Offset: 0x0059971F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060290B2 RID: 168114 RVA: 0x0059B52C File Offset: 0x0059972C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060290B3 RID: 168115 RVA: 0x0059B534 File Offset: 0x00599734
		public static ISpawnMonsterConstraintAnnularSector GetRootAsISpawnMonsterConstraintAnnularSector(ByteBuffer _bb)
		{
			return ISpawnMonsterConstraintAnnularSector.GetRootAsISpawnMonsterConstraintAnnularSector(_bb, default(ISpawnMonsterConstraintAnnularSector));
		}

		// Token: 0x060290B4 RID: 168116 RVA: 0x0059B550 File Offset: 0x00599750
		public static ISpawnMonsterConstraintAnnularSector GetRootAsISpawnMonsterConstraintAnnularSector(ByteBuffer _bb, ISpawnMonsterConstraintAnnularSector obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060290B5 RID: 168117 RVA: 0x0059B56D File Offset: 0x0059976D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060290B6 RID: 168118 RVA: 0x0059B57C File Offset: 0x0059977C
		public ISpawnMonsterConstraintAnnularSector __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B4DC RID: 46300
		// (get) Token: 0x060290B7 RID: 168119 RVA: 0x0059B58C File Offset: 0x0059978C
		public ESpawnMonsterConstraint Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpawnMonsterConstraint.CharacterForwardAnnularSector;
				}
				return (ESpawnMonsterConstraint)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B4DD RID: 46301
		// (get) Token: 0x060290B8 RID: 168120 RVA: 0x0059B5C8 File Offset: 0x005997C8
		public float InnerRadius
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B4DE RID: 46302
		// (get) Token: 0x060290B9 RID: 168121 RVA: 0x0059B608 File Offset: 0x00599808
		public float OuterRadius
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B4DF RID: 46303
		// (get) Token: 0x060290BA RID: 168122 RVA: 0x0059B648 File Offset: 0x00599848
		public float Angle
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060290BB RID: 168123 RVA: 0x0059B689 File Offset: 0x00599889
		public static Offset<ISpawnMonsterConstraintAnnularSector> CreateISpawnMonsterConstraintAnnularSector(FlatBufferBuilder builder, ESpawnMonsterConstraint Type = ESpawnMonsterConstraint.CharacterForwardAnnularSector, float InnerRadius = 0f, float OuterRadius = 0f, float Angle = 0f)
		{
			builder.StartTable(4);
			ISpawnMonsterConstraintAnnularSector.AddAngle(builder, Angle);
			ISpawnMonsterConstraintAnnularSector.AddOuterRadius(builder, OuterRadius);
			ISpawnMonsterConstraintAnnularSector.AddInnerRadius(builder, InnerRadius);
			ISpawnMonsterConstraintAnnularSector.AddType(builder, Type);
			return ISpawnMonsterConstraintAnnularSector.EndISpawnMonsterConstraintAnnularSector(builder);
		}

		// Token: 0x060290BC RID: 168124 RVA: 0x0059B6B5 File Offset: 0x005998B5
		public static void StartISpawnMonsterConstraintAnnularSector(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060290BD RID: 168125 RVA: 0x0059B6BE File Offset: 0x005998BE
		public static void AddType(FlatBufferBuilder builder, ESpawnMonsterConstraint type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060290BE RID: 168126 RVA: 0x0059B6C9 File Offset: 0x005998C9
		public static void AddInnerRadius(FlatBufferBuilder builder, float innerRadius)
		{
			builder.AddFloat(1, innerRadius, 0.0);
		}

		// Token: 0x060290BF RID: 168127 RVA: 0x0059B6DC File Offset: 0x005998DC
		public static void AddOuterRadius(FlatBufferBuilder builder, float outerRadius)
		{
			builder.AddFloat(2, outerRadius, 0.0);
		}

		// Token: 0x060290C0 RID: 168128 RVA: 0x0059B6EF File Offset: 0x005998EF
		public static void AddAngle(FlatBufferBuilder builder, float angle)
		{
			builder.AddFloat(3, angle, 0.0);
		}

		// Token: 0x060290C1 RID: 168129 RVA: 0x0059B702 File Offset: 0x00599902
		public static Offset<ISpawnMonsterConstraintAnnularSector> EndISpawnMonsterConstraintAnnularSector(FlatBufferBuilder builder)
		{
			return new Offset<ISpawnMonsterConstraintAnnularSector>(builder.EndTable());
		}

		// Token: 0x060290C2 RID: 168130 RVA: 0x0059B710 File Offset: 0x00599910
		public ISpawnMonsterConstraintAnnularSectorT UnPack()
		{
			ISpawnMonsterConstraintAnnularSectorT spawnMonsterConstraintAnnularSectorT = new ISpawnMonsterConstraintAnnularSectorT();
			this.UnPackTo(spawnMonsterConstraintAnnularSectorT);
			return spawnMonsterConstraintAnnularSectorT;
		}

		// Token: 0x060290C3 RID: 168131 RVA: 0x0059B72B File Offset: 0x0059992B
		public void UnPackTo(ISpawnMonsterConstraintAnnularSectorT _o)
		{
			_o.Type = this.Type;
			_o.InnerRadius = this.InnerRadius;
			_o.OuterRadius = this.OuterRadius;
			_o.Angle = this.Angle;
		}

		// Token: 0x060290C4 RID: 168132 RVA: 0x0059B760 File Offset: 0x00599960
		public static Offset<ISpawnMonsterConstraintAnnularSector> Pack(FlatBufferBuilder builder, ISpawnMonsterConstraintAnnularSectorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpawnMonsterConstraintAnnularSector>);
			}
			return ISpawnMonsterConstraintAnnularSector.CreateISpawnMonsterConstraintAnnularSector(builder, _o.Type, _o.InnerRadius, _o.OuterRadius, _o.Angle);
		}

		// Token: 0x0400FC28 RID: 64552
		private Table __p;
	}
}
