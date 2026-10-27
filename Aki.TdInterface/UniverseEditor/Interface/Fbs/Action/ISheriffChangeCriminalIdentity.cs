using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070BB RID: 28859
	public struct ISheriffChangeCriminalIdentity : IFlatbufferObject
	{
		// Token: 0x1700D664 RID: 54884
		// (get) Token: 0x060331D2 RID: 209362 RVA: 0x006E4AED File Offset: 0x006E2CED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060331D3 RID: 209363 RVA: 0x006E4AFA File Offset: 0x006E2CFA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060331D4 RID: 209364 RVA: 0x006E4B04 File Offset: 0x006E2D04
		public static ISheriffChangeCriminalIdentity GetRootAsISheriffChangeCriminalIdentity(ByteBuffer _bb)
		{
			return ISheriffChangeCriminalIdentity.GetRootAsISheriffChangeCriminalIdentity(_bb, default(ISheriffChangeCriminalIdentity));
		}

		// Token: 0x060331D5 RID: 209365 RVA: 0x006E4B20 File Offset: 0x006E2D20
		public static ISheriffChangeCriminalIdentity GetRootAsISheriffChangeCriminalIdentity(ByteBuffer _bb, ISheriffChangeCriminalIdentity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060331D6 RID: 209366 RVA: 0x006E4B3D File Offset: 0x006E2D3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060331D7 RID: 209367 RVA: 0x006E4B4C File Offset: 0x006E2D4C
		public ISheriffChangeCriminalIdentity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D665 RID: 54885
		// (get) Token: 0x060331D8 RID: 209368 RVA: 0x006E4B5C File Offset: 0x006E2D5C
		public int CriminalId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D666 RID: 54886
		// (get) Token: 0x060331D9 RID: 209369 RVA: 0x006E4B98 File Offset: 0x006E2D98
		public int IdentityId
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

		// Token: 0x060331DA RID: 209370 RVA: 0x006E4BD4 File Offset: 0x006E2DD4
		public static Offset<ISheriffChangeCriminalIdentity> CreateISheriffChangeCriminalIdentity(FlatBufferBuilder builder, int CriminalId = 0, int IdentityId = 0)
		{
			builder.StartTable(2);
			ISheriffChangeCriminalIdentity.AddIdentityId(builder, IdentityId);
			ISheriffChangeCriminalIdentity.AddCriminalId(builder, CriminalId);
			return ISheriffChangeCriminalIdentity.EndISheriffChangeCriminalIdentity(builder);
		}

		// Token: 0x060331DB RID: 209371 RVA: 0x006E4BF1 File Offset: 0x006E2DF1
		public static void StartISheriffChangeCriminalIdentity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060331DC RID: 209372 RVA: 0x006E4BFA File Offset: 0x006E2DFA
		public static void AddCriminalId(FlatBufferBuilder builder, int criminalId)
		{
			builder.AddInt(0, criminalId, 0);
		}

		// Token: 0x060331DD RID: 209373 RVA: 0x006E4C05 File Offset: 0x006E2E05
		public static void AddIdentityId(FlatBufferBuilder builder, int identityId)
		{
			builder.AddInt(1, identityId, 0);
		}

		// Token: 0x060331DE RID: 209374 RVA: 0x006E4C10 File Offset: 0x006E2E10
		public static Offset<ISheriffChangeCriminalIdentity> EndISheriffChangeCriminalIdentity(FlatBufferBuilder builder)
		{
			return new Offset<ISheriffChangeCriminalIdentity>(builder.EndTable());
		}

		// Token: 0x060331DF RID: 209375 RVA: 0x006E4C20 File Offset: 0x006E2E20
		public ISheriffChangeCriminalIdentityT UnPack()
		{
			ISheriffChangeCriminalIdentityT sheriffChangeCriminalIdentityT = new ISheriffChangeCriminalIdentityT();
			this.UnPackTo(sheriffChangeCriminalIdentityT);
			return sheriffChangeCriminalIdentityT;
		}

		// Token: 0x060331E0 RID: 209376 RVA: 0x006E4C3B File Offset: 0x006E2E3B
		public void UnPackTo(ISheriffChangeCriminalIdentityT _o)
		{
			_o.CriminalId = this.CriminalId;
			_o.IdentityId = this.IdentityId;
		}

		// Token: 0x060331E1 RID: 209377 RVA: 0x006E4C58 File Offset: 0x006E2E58
		public static Offset<ISheriffChangeCriminalIdentity> Pack(FlatBufferBuilder builder, ISheriffChangeCriminalIdentityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISheriffChangeCriminalIdentity>);
			}
			return ISheriffChangeCriminalIdentity.CreateISheriffChangeCriminalIdentity(builder, _o.CriminalId, _o.IdentityId);
		}

		// Token: 0x04011B2A RID: 72490
		private Table __p;
	}
}
