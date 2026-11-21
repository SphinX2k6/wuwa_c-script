using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BB7 RID: 27575
	public struct IDartPlayableRoleInteractType : IFlatbufferObject
	{
		// Token: 0x1700CA4C RID: 51788
		// (get) Token: 0x0602F75E RID: 194398 RVA: 0x0067934A File Offset: 0x0067754A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F75F RID: 194399 RVA: 0x00679357 File Offset: 0x00677557
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F760 RID: 194400 RVA: 0x00679360 File Offset: 0x00677560
		public static IDartPlayableRoleInteractType GetRootAsIDartPlayableRoleInteractType(ByteBuffer _bb)
		{
			return IDartPlayableRoleInteractType.GetRootAsIDartPlayableRoleInteractType(_bb, default(IDartPlayableRoleInteractType));
		}

		// Token: 0x0602F761 RID: 194401 RVA: 0x0067937C File Offset: 0x0067757C
		public static IDartPlayableRoleInteractType GetRootAsIDartPlayableRoleInteractType(ByteBuffer _bb, IDartPlayableRoleInteractType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F762 RID: 194402 RVA: 0x00679399 File Offset: 0x00677599
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F763 RID: 194403 RVA: 0x006793A8 File Offset: 0x006775A8
		public IDartPlayableRoleInteractType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA4D RID: 51789
		// (get) Token: 0x0602F764 RID: 194404 RVA: 0x006793B8 File Offset: 0x006775B8
		public EDartInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDartInteractType.Machine;
				}
				return (EDartInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CA4E RID: 51790
		// (get) Token: 0x0602F765 RID: 194405 RVA: 0x006793F4 File Offset: 0x006775F4
		public int CompetitorId
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

		// Token: 0x1700CA4F RID: 51791
		// (get) Token: 0x0602F766 RID: 194406 RVA: 0x00679430 File Offset: 0x00677630
		public int TargetEntityId
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

		// Token: 0x1700CA50 RID: 51792
		// (get) Token: 0x0602F767 RID: 194407 RVA: 0x0067946C File Offset: 0x0067766C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F768 RID: 194408 RVA: 0x006794A9 File Offset: 0x006776A9
		public static Offset<IDartPlayableRoleInteractType> CreateIDartPlayableRoleInteractType(FlatBufferBuilder builder, EDartInteractType Type = EDartInteractType.Machine, int CompetitorId = 0, int TargetEntityId = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IDartPlayableRoleInteractType.AddTargetEntityId(builder, TargetEntityId);
			IDartPlayableRoleInteractType.AddCompetitorId(builder, CompetitorId);
			IDartPlayableRoleInteractType.AddNullMask(builder, NullMask);
			IDartPlayableRoleInteractType.AddType(builder, Type);
			return IDartPlayableRoleInteractType.EndIDartPlayableRoleInteractType(builder);
		}

		// Token: 0x0602F769 RID: 194409 RVA: 0x006794D5 File Offset: 0x006776D5
		public static void StartIDartPlayableRoleInteractType(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602F76A RID: 194410 RVA: 0x006794DE File Offset: 0x006776DE
		public static void AddType(FlatBufferBuilder builder, EDartInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F76B RID: 194411 RVA: 0x006794E9 File Offset: 0x006776E9
		public static void AddCompetitorId(FlatBufferBuilder builder, int competitorId)
		{
			builder.AddInt(1, competitorId, 0);
		}

		// Token: 0x0602F76C RID: 194412 RVA: 0x006794F4 File Offset: 0x006776F4
		public static void AddTargetEntityId(FlatBufferBuilder builder, int targetEntityId)
		{
			builder.AddInt(2, targetEntityId, 0);
		}

		// Token: 0x0602F76D RID: 194413 RVA: 0x006794FF File Offset: 0x006776FF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602F76E RID: 194414 RVA: 0x0067950A File Offset: 0x0067770A
		public static Offset<IDartPlayableRoleInteractType> EndIDartPlayableRoleInteractType(FlatBufferBuilder builder)
		{
			return new Offset<IDartPlayableRoleInteractType>(builder.EndTable());
		}

		// Token: 0x0602F76F RID: 194415 RVA: 0x00679518 File Offset: 0x00677718
		public IDartPlayableRoleInteractTypeT UnPack()
		{
			IDartPlayableRoleInteractTypeT dartPlayableRoleInteractTypeT = new IDartPlayableRoleInteractTypeT();
			this.UnPackTo(dartPlayableRoleInteractTypeT);
			return dartPlayableRoleInteractTypeT;
		}

		// Token: 0x0602F770 RID: 194416 RVA: 0x00679533 File Offset: 0x00677733
		public void UnPackTo(IDartPlayableRoleInteractTypeT _o)
		{
			_o.Type = this.Type;
			_o.CompetitorId = this.CompetitorId;
			_o.TargetEntityId = this.TargetEntityId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602F771 RID: 194417 RVA: 0x00679568 File Offset: 0x00677768
		public static Offset<IDartPlayableRoleInteractType> Pack(FlatBufferBuilder builder, IDartPlayableRoleInteractTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDartPlayableRoleInteractType>);
			}
			return IDartPlayableRoleInteractType.CreateIDartPlayableRoleInteractType(builder, _o.Type, _o.CompetitorId, _o.TargetEntityId, _o.NullMask);
		}

		// Token: 0x040119B0 RID: 72112
		private Table __p;
	}
}
