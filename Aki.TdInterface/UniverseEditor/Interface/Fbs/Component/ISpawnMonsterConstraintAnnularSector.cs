using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005953 RID: 22867
	public struct ISpawnMonsterConstraintAnnularSector : IFlatbufferObject
	{
		// Token: 0x1700ABA7 RID: 43943
		// (get) Token: 0x06026B47 RID: 158535 RVA: 0x005548B3 File Offset: 0x00552AB3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026B48 RID: 158536 RVA: 0x005548C0 File Offset: 0x00552AC0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026B49 RID: 158537 RVA: 0x005548C8 File Offset: 0x00552AC8
		public static ISpawnMonsterConstraintAnnularSector GetRootAsISpawnMonsterConstraintAnnularSector(ByteBuffer _bb)
		{
			return ISpawnMonsterConstraintAnnularSector.GetRootAsISpawnMonsterConstraintAnnularSector(_bb, default(ISpawnMonsterConstraintAnnularSector));
		}

		// Token: 0x06026B4A RID: 158538 RVA: 0x005548E4 File Offset: 0x00552AE4
		public static ISpawnMonsterConstraintAnnularSector GetRootAsISpawnMonsterConstraintAnnularSector(ByteBuffer _bb, ISpawnMonsterConstraintAnnularSector obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026B4B RID: 158539 RVA: 0x00554901 File Offset: 0x00552B01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026B4C RID: 158540 RVA: 0x00554910 File Offset: 0x00552B10
		public ISpawnMonsterConstraintAnnularSector __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ABA8 RID: 43944
		// (get) Token: 0x06026B4D RID: 158541 RVA: 0x00554920 File Offset: 0x00552B20
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

		// Token: 0x1700ABA9 RID: 43945
		// (get) Token: 0x06026B4E RID: 158542 RVA: 0x0055495C File Offset: 0x00552B5C
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

		// Token: 0x1700ABAA RID: 43946
		// (get) Token: 0x06026B4F RID: 158543 RVA: 0x0055499C File Offset: 0x00552B9C
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

		// Token: 0x1700ABAB RID: 43947
		// (get) Token: 0x06026B50 RID: 158544 RVA: 0x005549DC File Offset: 0x00552BDC
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

		// Token: 0x06026B51 RID: 158545 RVA: 0x00554A1D File Offset: 0x00552C1D
		public static Offset<ISpawnMonsterConstraintAnnularSector> CreateISpawnMonsterConstraintAnnularSector(FlatBufferBuilder builder, ESpawnMonsterConstraint Type = ESpawnMonsterConstraint.CharacterForwardAnnularSector, float InnerRadius = 0f, float OuterRadius = 0f, float Angle = 0f)
		{
			builder.StartTable(4);
			ISpawnMonsterConstraintAnnularSector.AddAngle(builder, Angle);
			ISpawnMonsterConstraintAnnularSector.AddOuterRadius(builder, OuterRadius);
			ISpawnMonsterConstraintAnnularSector.AddInnerRadius(builder, InnerRadius);
			ISpawnMonsterConstraintAnnularSector.AddType(builder, Type);
			return ISpawnMonsterConstraintAnnularSector.EndISpawnMonsterConstraintAnnularSector(builder);
		}

		// Token: 0x06026B52 RID: 158546 RVA: 0x00554A49 File Offset: 0x00552C49
		public static void StartISpawnMonsterConstraintAnnularSector(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06026B53 RID: 158547 RVA: 0x00554A52 File Offset: 0x00552C52
		public static void AddType(FlatBufferBuilder builder, ESpawnMonsterConstraint type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026B54 RID: 158548 RVA: 0x00554A5D File Offset: 0x00552C5D
		public static void AddInnerRadius(FlatBufferBuilder builder, float innerRadius)
		{
			builder.AddFloat(1, innerRadius, 0.0);
		}

		// Token: 0x06026B55 RID: 158549 RVA: 0x00554A70 File Offset: 0x00552C70
		public static void AddOuterRadius(FlatBufferBuilder builder, float outerRadius)
		{
			builder.AddFloat(2, outerRadius, 0.0);
		}

		// Token: 0x06026B56 RID: 158550 RVA: 0x00554A83 File Offset: 0x00552C83
		public static void AddAngle(FlatBufferBuilder builder, float angle)
		{
			builder.AddFloat(3, angle, 0.0);
		}

		// Token: 0x06026B57 RID: 158551 RVA: 0x00554A96 File Offset: 0x00552C96
		public static Offset<ISpawnMonsterConstraintAnnularSector> EndISpawnMonsterConstraintAnnularSector(FlatBufferBuilder builder)
		{
			return new Offset<ISpawnMonsterConstraintAnnularSector>(builder.EndTable());
		}

		// Token: 0x06026B58 RID: 158552 RVA: 0x00554AA4 File Offset: 0x00552CA4
		public ISpawnMonsterConstraintAnnularSectorT UnPack()
		{
			ISpawnMonsterConstraintAnnularSectorT spawnMonsterConstraintAnnularSectorT = new ISpawnMonsterConstraintAnnularSectorT();
			this.UnPackTo(spawnMonsterConstraintAnnularSectorT);
			return spawnMonsterConstraintAnnularSectorT;
		}

		// Token: 0x06026B59 RID: 158553 RVA: 0x00554ABF File Offset: 0x00552CBF
		public void UnPackTo(ISpawnMonsterConstraintAnnularSectorT _o)
		{
			_o.Type = this.Type;
			_o.InnerRadius = this.InnerRadius;
			_o.OuterRadius = this.OuterRadius;
			_o.Angle = this.Angle;
		}

		// Token: 0x06026B5A RID: 158554 RVA: 0x00554AF4 File Offset: 0x00552CF4
		public static Offset<ISpawnMonsterConstraintAnnularSector> Pack(FlatBufferBuilder builder, ISpawnMonsterConstraintAnnularSectorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpawnMonsterConstraintAnnularSector>);
			}
			return ISpawnMonsterConstraintAnnularSector.CreateISpawnMonsterConstraintAnnularSector(builder, _o.Type, _o.InnerRadius, _o.OuterRadius, _o.Angle);
		}

		// Token: 0x0400EF33 RID: 61235
		private Table __p;
	}
}
