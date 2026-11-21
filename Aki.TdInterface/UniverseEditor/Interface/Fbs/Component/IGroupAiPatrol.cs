using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058CD RID: 22733
	public struct IGroupAiPatrol : IFlatbufferObject
	{
		// Token: 0x1700A4D2 RID: 42194
		// (get) Token: 0x06024E8C RID: 151180 RVA: 0x0051162A File Offset: 0x0050F82A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024E8D RID: 151181 RVA: 0x00511637 File Offset: 0x0050F837
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024E8E RID: 151182 RVA: 0x00511640 File Offset: 0x0050F840
		public static IGroupAiPatrol GetRootAsIGroupAiPatrol(ByteBuffer _bb)
		{
			return IGroupAiPatrol.GetRootAsIGroupAiPatrol(_bb, default(IGroupAiPatrol));
		}

		// Token: 0x06024E8F RID: 151183 RVA: 0x0051165C File Offset: 0x0050F85C
		public static IGroupAiPatrol GetRootAsIGroupAiPatrol(ByteBuffer _bb, IGroupAiPatrol obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024E90 RID: 151184 RVA: 0x00511679 File Offset: 0x0050F879
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024E91 RID: 151185 RVA: 0x00511688 File Offset: 0x0050F888
		public IGroupAiPatrol __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A4D3 RID: 42195
		// (get) Token: 0x06024E92 RID: 151186 RVA: 0x00511698 File Offset: 0x0050F898
		public EGroupAiMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGroupAiMode.Default;
				}
				return (EGroupAiMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A4D4 RID: 42196
		// (get) Token: 0x06024E93 RID: 151187 RVA: 0x005116D4 File Offset: 0x0050F8D4
		public int Leader
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

		// Token: 0x1700A4D5 RID: 42197
		// (get) Token: 0x06024E94 RID: 151188 RVA: 0x00511710 File Offset: 0x0050F910
		public int SplineEntityId
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

		// Token: 0x1700A4D6 RID: 42198
		// (get) Token: 0x06024E95 RID: 151189 RVA: 0x0051174C File Offset: 0x0050F94C
		public int PlayerPlaceholderEntityId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A4D7 RID: 42199
		// (get) Token: 0x06024E96 RID: 151190 RVA: 0x0051178C File Offset: 0x0050F98C
		public EGroupAiFormationBasis FormationBasis
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return EGroupAiFormationBasis.Spline;
				}
				return (EGroupAiFormationBasis)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A4D8 RID: 42200
		// (get) Token: 0x06024E97 RID: 151191 RVA: 0x005117CC File Offset: 0x0050F9CC
		public bool IsPreciseFormation
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A4D9 RID: 42201
		// (get) Token: 0x06024E98 RID: 151192 RVA: 0x0051180C File Offset: 0x0050FA0C
		public IGroupAiEcologyGameplayAbp? EcologyGameplayAbp
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IGroupAiEcologyGameplayAbp?(default(IGroupAiEcologyGameplayAbp).__assign(num + this.__p.bb_pos, this.__p.bb));
			}
		}

		// Token: 0x1700A4DA RID: 42202
		// (get) Token: 0x06024E99 RID: 151193 RVA: 0x00511860 File Offset: 0x0050FA60
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024E9A RID: 151194 RVA: 0x005118A0 File Offset: 0x0050FAA0
		public static Offset<IGroupAiPatrol> CreateIGroupAiPatrol(FlatBufferBuilder builder, EGroupAiMode Type = EGroupAiMode.Default, int Leader = 0, int SplineEntityId = 0, int PlayerPlaceholderEntityId = 0, EGroupAiFormationBasis FormationBasis = EGroupAiFormationBasis.Spline, bool IsPreciseFormation = false, IGroupAiEcologyGameplayAbpT EcologyGameplayAbp = null, byte NullMask = 0)
		{
			builder.StartTable(8);
			IGroupAiPatrol.AddEcologyGameplayAbp(builder, IGroupAiEcologyGameplayAbp.Pack(builder, EcologyGameplayAbp));
			IGroupAiPatrol.AddPlayerPlaceholderEntityId(builder, PlayerPlaceholderEntityId);
			IGroupAiPatrol.AddSplineEntityId(builder, SplineEntityId);
			IGroupAiPatrol.AddLeader(builder, Leader);
			IGroupAiPatrol.AddNullMask(builder, NullMask);
			IGroupAiPatrol.AddIsPreciseFormation(builder, IsPreciseFormation);
			IGroupAiPatrol.AddFormationBasis(builder, FormationBasis);
			IGroupAiPatrol.AddType(builder, Type);
			return IGroupAiPatrol.EndIGroupAiPatrol(builder);
		}

		// Token: 0x06024E9B RID: 151195 RVA: 0x005118FD File Offset: 0x0050FAFD
		public static void StartIGroupAiPatrol(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06024E9C RID: 151196 RVA: 0x00511906 File Offset: 0x0050FB06
		public static void AddType(FlatBufferBuilder builder, EGroupAiMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024E9D RID: 151197 RVA: 0x00511911 File Offset: 0x0050FB11
		public static void AddLeader(FlatBufferBuilder builder, int leader)
		{
			builder.AddInt(1, leader, 0);
		}

		// Token: 0x06024E9E RID: 151198 RVA: 0x0051191C File Offset: 0x0050FB1C
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(2, splineEntityId, 0);
		}

		// Token: 0x06024E9F RID: 151199 RVA: 0x00511927 File Offset: 0x0050FB27
		public static void AddPlayerPlaceholderEntityId(FlatBufferBuilder builder, int playerPlaceholderEntityId)
		{
			builder.AddInt(3, playerPlaceholderEntityId, 0);
		}

		// Token: 0x06024EA0 RID: 151200 RVA: 0x00511932 File Offset: 0x0050FB32
		public static void AddFormationBasis(FlatBufferBuilder builder, EGroupAiFormationBasis formationBasis)
		{
			builder.AddByte(4, (byte)formationBasis, 0);
		}

		// Token: 0x06024EA1 RID: 151201 RVA: 0x0051193D File Offset: 0x0050FB3D
		public static void AddIsPreciseFormation(FlatBufferBuilder builder, bool isPreciseFormation)
		{
			builder.AddBool(5, isPreciseFormation, false);
		}

		// Token: 0x06024EA2 RID: 151202 RVA: 0x00511948 File Offset: 0x0050FB48
		public static void AddEcologyGameplayAbp(FlatBufferBuilder builder, Offset<IGroupAiEcologyGameplayAbp> ecologyGameplayAbpOffset)
		{
			builder.AddStruct(6, ecologyGameplayAbpOffset.Value, 0);
		}

		// Token: 0x06024EA3 RID: 151203 RVA: 0x00511958 File Offset: 0x0050FB58
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06024EA4 RID: 151204 RVA: 0x00511963 File Offset: 0x0050FB63
		public static Offset<IGroupAiPatrol> EndIGroupAiPatrol(FlatBufferBuilder builder)
		{
			return new Offset<IGroupAiPatrol>(builder.EndTable());
		}

		// Token: 0x06024EA5 RID: 151205 RVA: 0x00511970 File Offset: 0x0050FB70
		public IGroupAiPatrolT UnPack()
		{
			IGroupAiPatrolT groupAiPatrolT = new IGroupAiPatrolT();
			this.UnPackTo(groupAiPatrolT);
			return groupAiPatrolT;
		}

		// Token: 0x06024EA6 RID: 151206 RVA: 0x0051198C File Offset: 0x0050FB8C
		public void UnPackTo(IGroupAiPatrolT _o)
		{
			_o.Type = this.Type;
			_o.Leader = this.Leader;
			_o.SplineEntityId = this.SplineEntityId;
			_o.PlayerPlaceholderEntityId = this.PlayerPlaceholderEntityId;
			_o.FormationBasis = this.FormationBasis;
			_o.IsPreciseFormation = this.IsPreciseFormation;
			_o.EcologyGameplayAbp = ((this.EcologyGameplayAbp != null) ? this.EcologyGameplayAbp.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06024EA7 RID: 151207 RVA: 0x00511A1C File Offset: 0x0050FC1C
		public static Offset<IGroupAiPatrol> Pack(FlatBufferBuilder builder, IGroupAiPatrolT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGroupAiPatrol>);
			}
			return IGroupAiPatrol.CreateIGroupAiPatrol(builder, _o.Type, _o.Leader, _o.SplineEntityId, _o.PlayerPlaceholderEntityId, _o.FormationBasis, _o.IsPreciseFormation, _o.EcologyGameplayAbp, _o.NullMask);
		}

		// Token: 0x0400F144 RID: 61764
		private Table __p;
	}
}
