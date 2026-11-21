using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200411E RID: 16670
	public struct IArcadeGameplayDropCatch : IFlatbufferObject
	{
		// Token: 0x170070E8 RID: 28904
		// (get) Token: 0x06016DFB RID: 93691 RVA: 0x003442F4 File Offset: 0x003424F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016DFC RID: 93692 RVA: 0x00344301 File Offset: 0x00342501
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016DFD RID: 93693 RVA: 0x00344308 File Offset: 0x00342508
		public static IArcadeGameplayDropCatch GetRootAsIArcadeGameplayDropCatch(ByteBuffer _bb)
		{
			return IArcadeGameplayDropCatch.GetRootAsIArcadeGameplayDropCatch(_bb, default(IArcadeGameplayDropCatch));
		}

		// Token: 0x06016DFE RID: 93694 RVA: 0x00344324 File Offset: 0x00342524
		public static IArcadeGameplayDropCatch GetRootAsIArcadeGameplayDropCatch(ByteBuffer _bb, IArcadeGameplayDropCatch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016DFF RID: 93695 RVA: 0x00344341 File Offset: 0x00342541
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016E00 RID: 93696 RVA: 0x00344350 File Offset: 0x00342550
		public IArcadeGameplayDropCatch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170070E9 RID: 28905
		// (get) Token: 0x06016E01 RID: 93697 RVA: 0x00344360 File Offset: 0x00342560
		public EArcadeGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EArcadeGameplayType.DropCatch;
				}
				return (EArcadeGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170070EA RID: 28906
		// (get) Token: 0x06016E02 RID: 93698 RVA: 0x0034439C File Offset: 0x0034259C
		public int LevelId
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

		// Token: 0x06016E03 RID: 93699 RVA: 0x003443D8 File Offset: 0x003425D8
		public static Offset<IArcadeGameplayDropCatch> CreateIArcadeGameplayDropCatch(FlatBufferBuilder builder, EArcadeGameplayType Type = EArcadeGameplayType.DropCatch, int LevelId = 0)
		{
			builder.StartTable(2);
			IArcadeGameplayDropCatch.AddLevelId(builder, LevelId);
			IArcadeGameplayDropCatch.AddType(builder, Type);
			return IArcadeGameplayDropCatch.EndIArcadeGameplayDropCatch(builder);
		}

		// Token: 0x06016E04 RID: 93700 RVA: 0x003443F5 File Offset: 0x003425F5
		public static void StartIArcadeGameplayDropCatch(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06016E05 RID: 93701 RVA: 0x003443FE File Offset: 0x003425FE
		public static void AddType(FlatBufferBuilder builder, EArcadeGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016E06 RID: 93702 RVA: 0x00344409 File Offset: 0x00342609
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(1, levelId, 0);
		}

		// Token: 0x06016E07 RID: 93703 RVA: 0x00344414 File Offset: 0x00342614
		public static Offset<IArcadeGameplayDropCatch> EndIArcadeGameplayDropCatch(FlatBufferBuilder builder)
		{
			return new Offset<IArcadeGameplayDropCatch>(builder.EndTable());
		}

		// Token: 0x06016E08 RID: 93704 RVA: 0x00344424 File Offset: 0x00342624
		public IArcadeGameplayDropCatchT UnPack()
		{
			IArcadeGameplayDropCatchT arcadeGameplayDropCatchT = new IArcadeGameplayDropCatchT();
			this.UnPackTo(arcadeGameplayDropCatchT);
			return arcadeGameplayDropCatchT;
		}

		// Token: 0x06016E09 RID: 93705 RVA: 0x0034443F File Offset: 0x0034263F
		public void UnPackTo(IArcadeGameplayDropCatchT _o)
		{
			_o.Type = this.Type;
			_o.LevelId = this.LevelId;
		}

		// Token: 0x06016E0A RID: 93706 RVA: 0x0034445C File Offset: 0x0034265C
		public static Offset<IArcadeGameplayDropCatch> Pack(FlatBufferBuilder builder, IArcadeGameplayDropCatchT _o)
		{
			if (_o == null)
			{
				return default(Offset<IArcadeGameplayDropCatch>);
			}
			return IArcadeGameplayDropCatch.CreateIArcadeGameplayDropCatch(builder, _o.Type, _o.LevelId);
		}

		// Token: 0x0400BF68 RID: 49000
		private Table __p;
	}
}
