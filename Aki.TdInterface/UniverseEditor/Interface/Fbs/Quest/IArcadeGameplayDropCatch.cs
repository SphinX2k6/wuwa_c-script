using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D07 RID: 15623
	public struct IArcadeGameplayDropCatch : IFlatbufferObject
	{
		// Token: 0x17006B2E RID: 27438
		// (get) Token: 0x060158C3 RID: 88259 RVA: 0x0031D07C File Offset: 0x0031B27C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060158C4 RID: 88260 RVA: 0x0031D089 File Offset: 0x0031B289
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060158C5 RID: 88261 RVA: 0x0031D090 File Offset: 0x0031B290
		public static IArcadeGameplayDropCatch GetRootAsIArcadeGameplayDropCatch(ByteBuffer _bb)
		{
			return IArcadeGameplayDropCatch.GetRootAsIArcadeGameplayDropCatch(_bb, default(IArcadeGameplayDropCatch));
		}

		// Token: 0x060158C6 RID: 88262 RVA: 0x0031D0AC File Offset: 0x0031B2AC
		public static IArcadeGameplayDropCatch GetRootAsIArcadeGameplayDropCatch(ByteBuffer _bb, IArcadeGameplayDropCatch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060158C7 RID: 88263 RVA: 0x0031D0C9 File Offset: 0x0031B2C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060158C8 RID: 88264 RVA: 0x0031D0D8 File Offset: 0x0031B2D8
		public IArcadeGameplayDropCatch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B2F RID: 27439
		// (get) Token: 0x060158C9 RID: 88265 RVA: 0x0031D0E8 File Offset: 0x0031B2E8
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

		// Token: 0x17006B30 RID: 27440
		// (get) Token: 0x060158CA RID: 88266 RVA: 0x0031D124 File Offset: 0x0031B324
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

		// Token: 0x060158CB RID: 88267 RVA: 0x0031D160 File Offset: 0x0031B360
		public static Offset<IArcadeGameplayDropCatch> CreateIArcadeGameplayDropCatch(FlatBufferBuilder builder, EArcadeGameplayType Type = EArcadeGameplayType.DropCatch, int LevelId = 0)
		{
			builder.StartTable(2);
			IArcadeGameplayDropCatch.AddLevelId(builder, LevelId);
			IArcadeGameplayDropCatch.AddType(builder, Type);
			return IArcadeGameplayDropCatch.EndIArcadeGameplayDropCatch(builder);
		}

		// Token: 0x060158CC RID: 88268 RVA: 0x0031D17D File Offset: 0x0031B37D
		public static void StartIArcadeGameplayDropCatch(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060158CD RID: 88269 RVA: 0x0031D186 File Offset: 0x0031B386
		public static void AddType(FlatBufferBuilder builder, EArcadeGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060158CE RID: 88270 RVA: 0x0031D191 File Offset: 0x0031B391
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(1, levelId, 0);
		}

		// Token: 0x060158CF RID: 88271 RVA: 0x0031D19C File Offset: 0x0031B39C
		public static Offset<IArcadeGameplayDropCatch> EndIArcadeGameplayDropCatch(FlatBufferBuilder builder)
		{
			return new Offset<IArcadeGameplayDropCatch>(builder.EndTable());
		}

		// Token: 0x060158D0 RID: 88272 RVA: 0x0031D1AC File Offset: 0x0031B3AC
		public IArcadeGameplayDropCatchT UnPack()
		{
			IArcadeGameplayDropCatchT arcadeGameplayDropCatchT = new IArcadeGameplayDropCatchT();
			this.UnPackTo(arcadeGameplayDropCatchT);
			return arcadeGameplayDropCatchT;
		}

		// Token: 0x060158D1 RID: 88273 RVA: 0x0031D1C7 File Offset: 0x0031B3C7
		public void UnPackTo(IArcadeGameplayDropCatchT _o)
		{
			_o.Type = this.Type;
			_o.LevelId = this.LevelId;
		}

		// Token: 0x060158D2 RID: 88274 RVA: 0x0031D1E4 File Offset: 0x0031B3E4
		public static Offset<IArcadeGameplayDropCatch> Pack(FlatBufferBuilder builder, IArcadeGameplayDropCatchT _o)
		{
			if (_o == null)
			{
				return default(Offset<IArcadeGameplayDropCatch>);
			}
			return IArcadeGameplayDropCatch.CreateIArcadeGameplayDropCatch(builder, _o.Type, _o.LevelId);
		}

		// Token: 0x0400B5BB RID: 46523
		private Table __p;
	}
}
