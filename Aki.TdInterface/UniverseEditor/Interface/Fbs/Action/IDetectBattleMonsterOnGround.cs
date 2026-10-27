using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065AF RID: 26031
	public struct IDetectBattleMonsterOnGround : IFlatbufferObject
	{
		// Token: 0x1700C146 RID: 49478
		// (get) Token: 0x0602D273 RID: 184947 RVA: 0x00631185 File Offset: 0x0062F385
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D274 RID: 184948 RVA: 0x00631192 File Offset: 0x0062F392
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D275 RID: 184949 RVA: 0x0063119C File Offset: 0x0062F39C
		public static IDetectBattleMonsterOnGround GetRootAsIDetectBattleMonsterOnGround(ByteBuffer _bb)
		{
			return IDetectBattleMonsterOnGround.GetRootAsIDetectBattleMonsterOnGround(_bb, default(IDetectBattleMonsterOnGround));
		}

		// Token: 0x0602D276 RID: 184950 RVA: 0x006311B8 File Offset: 0x0062F3B8
		public static IDetectBattleMonsterOnGround GetRootAsIDetectBattleMonsterOnGround(ByteBuffer _bb, IDetectBattleMonsterOnGround obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D277 RID: 184951 RVA: 0x006311D5 File Offset: 0x0062F3D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D278 RID: 184952 RVA: 0x006311E4 File Offset: 0x0062F3E4
		public IDetectBattleMonsterOnGround __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C147 RID: 49479
		// (get) Token: 0x0602D279 RID: 184953 RVA: 0x006311F4 File Offset: 0x0062F3F4
		public EDetectBattleTagType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDetectBattleTagType.MonsterOnTheGround;
				}
				return (EDetectBattleTagType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D27A RID: 184954 RVA: 0x00631230 File Offset: 0x0062F430
		public static Offset<IDetectBattleMonsterOnGround> CreateIDetectBattleMonsterOnGround(FlatBufferBuilder builder, EDetectBattleTagType Type = EDetectBattleTagType.MonsterOnTheGround)
		{
			builder.StartTable(1);
			IDetectBattleMonsterOnGround.AddType(builder, Type);
			return IDetectBattleMonsterOnGround.EndIDetectBattleMonsterOnGround(builder);
		}

		// Token: 0x0602D27B RID: 184955 RVA: 0x00631246 File Offset: 0x0062F446
		public static void StartIDetectBattleMonsterOnGround(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D27C RID: 184956 RVA: 0x0063124F File Offset: 0x0062F44F
		public static void AddType(FlatBufferBuilder builder, EDetectBattleTagType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D27D RID: 184957 RVA: 0x0063125A File Offset: 0x0062F45A
		public static Offset<IDetectBattleMonsterOnGround> EndIDetectBattleMonsterOnGround(FlatBufferBuilder builder)
		{
			return new Offset<IDetectBattleMonsterOnGround>(builder.EndTable());
		}

		// Token: 0x0602D27E RID: 184958 RVA: 0x00631268 File Offset: 0x0062F468
		public IDetectBattleMonsterOnGroundT UnPack()
		{
			IDetectBattleMonsterOnGroundT detectBattleMonsterOnGroundT = new IDetectBattleMonsterOnGroundT();
			this.UnPackTo(detectBattleMonsterOnGroundT);
			return detectBattleMonsterOnGroundT;
		}

		// Token: 0x0602D27F RID: 184959 RVA: 0x00631283 File Offset: 0x0062F483
		public void UnPackTo(IDetectBattleMonsterOnGroundT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602D280 RID: 184960 RVA: 0x00631294 File Offset: 0x0062F494
		public static Offset<IDetectBattleMonsterOnGround> Pack(FlatBufferBuilder builder, IDetectBattleMonsterOnGroundT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDetectBattleMonsterOnGround>);
			}
			return IDetectBattleMonsterOnGround.CreateIDetectBattleMonsterOnGround(builder, _o.Type);
		}

		// Token: 0x04010C0A RID: 68618
		private Table __p;
	}
}
