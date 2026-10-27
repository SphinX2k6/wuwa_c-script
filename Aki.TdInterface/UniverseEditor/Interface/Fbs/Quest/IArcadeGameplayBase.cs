using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D01 RID: 15617
	public struct IArcadeGameplayBase : IFlatbufferObject
	{
		// Token: 0x17006B29 RID: 27433
		// (get) Token: 0x060158A3 RID: 88227 RVA: 0x0031CDBC File Offset: 0x0031AFBC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060158A4 RID: 88228 RVA: 0x0031CDC9 File Offset: 0x0031AFC9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060158A5 RID: 88229 RVA: 0x0031CDD0 File Offset: 0x0031AFD0
		public static IArcadeGameplayBase GetRootAsIArcadeGameplayBase(ByteBuffer _bb)
		{
			return IArcadeGameplayBase.GetRootAsIArcadeGameplayBase(_bb, default(IArcadeGameplayBase));
		}

		// Token: 0x060158A6 RID: 88230 RVA: 0x0031CDEC File Offset: 0x0031AFEC
		public static IArcadeGameplayBase GetRootAsIArcadeGameplayBase(ByteBuffer _bb, IArcadeGameplayBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060158A7 RID: 88231 RVA: 0x0031CE09 File Offset: 0x0031B009
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060158A8 RID: 88232 RVA: 0x0031CE18 File Offset: 0x0031B018
		public IArcadeGameplayBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B2A RID: 27434
		// (get) Token: 0x060158A9 RID: 88233 RVA: 0x0031CE28 File Offset: 0x0031B028
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

		// Token: 0x060158AA RID: 88234 RVA: 0x0031CE64 File Offset: 0x0031B064
		public static Offset<IArcadeGameplayBase> CreateIArcadeGameplayBase(FlatBufferBuilder builder, EArcadeGameplayType Type = EArcadeGameplayType.DropCatch)
		{
			builder.StartTable(1);
			IArcadeGameplayBase.AddType(builder, Type);
			return IArcadeGameplayBase.EndIArcadeGameplayBase(builder);
		}

		// Token: 0x060158AB RID: 88235 RVA: 0x0031CE7A File Offset: 0x0031B07A
		public static void StartIArcadeGameplayBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060158AC RID: 88236 RVA: 0x0031CE83 File Offset: 0x0031B083
		public static void AddType(FlatBufferBuilder builder, EArcadeGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060158AD RID: 88237 RVA: 0x0031CE8E File Offset: 0x0031B08E
		public static Offset<IArcadeGameplayBase> EndIArcadeGameplayBase(FlatBufferBuilder builder)
		{
			return new Offset<IArcadeGameplayBase>(builder.EndTable());
		}

		// Token: 0x060158AE RID: 88238 RVA: 0x0031CE9C File Offset: 0x0031B09C
		public IArcadeGameplayBaseT UnPack()
		{
			IArcadeGameplayBaseT arcadeGameplayBaseT = new IArcadeGameplayBaseT();
			this.UnPackTo(arcadeGameplayBaseT);
			return arcadeGameplayBaseT;
		}

		// Token: 0x060158AF RID: 88239 RVA: 0x0031CEB7 File Offset: 0x0031B0B7
		public void UnPackTo(IArcadeGameplayBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060158B0 RID: 88240 RVA: 0x0031CEC8 File Offset: 0x0031B0C8
		public static Offset<IArcadeGameplayBase> Pack(FlatBufferBuilder builder, IArcadeGameplayBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IArcadeGameplayBase>);
			}
			return IArcadeGameplayBase.CreateIArcadeGameplayBase(builder, _o.Type);
		}

		// Token: 0x0400B5B2 RID: 46514
		private Table __p;
	}
}
