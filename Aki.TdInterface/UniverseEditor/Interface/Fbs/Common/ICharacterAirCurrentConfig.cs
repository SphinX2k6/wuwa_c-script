using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D70 RID: 23920
	public struct ICharacterAirCurrentConfig : IFlatbufferObject
	{
		// Token: 0x1700B325 RID: 45861
		// (get) Token: 0x06028EAC RID: 167596 RVA: 0x0059ED65 File Offset: 0x0059CF65
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028EAD RID: 167597 RVA: 0x0059ED72 File Offset: 0x0059CF72
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028EAE RID: 167598 RVA: 0x0059ED7C File Offset: 0x0059CF7C
		public static ICharacterAirCurrentConfig GetRootAsICharacterAirCurrentConfig(ByteBuffer _bb)
		{
			return ICharacterAirCurrentConfig.GetRootAsICharacterAirCurrentConfig(_bb, default(ICharacterAirCurrentConfig));
		}

		// Token: 0x06028EAF RID: 167599 RVA: 0x0059ED98 File Offset: 0x0059CF98
		public static ICharacterAirCurrentConfig GetRootAsICharacterAirCurrentConfig(ByteBuffer _bb, ICharacterAirCurrentConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028EB0 RID: 167600 RVA: 0x0059EDB5 File Offset: 0x0059CFB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028EB1 RID: 167601 RVA: 0x0059EDC4 File Offset: 0x0059CFC4
		public ICharacterAirCurrentConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B326 RID: 45862
		// (get) Token: 0x06028EB2 RID: 167602 RVA: 0x0059EDD4 File Offset: 0x0059CFD4
		public long BulletId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0L;
				}
				return this.__p.bb.GetLong(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B327 RID: 45863
		// (get) Token: 0x06028EB3 RID: 167603 RVA: 0x0059EE14 File Offset: 0x0059D014
		public IVectorInfo? Range
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B328 RID: 45864
		// (get) Token: 0x06028EB4 RID: 167604 RVA: 0x0059EE74 File Offset: 0x0059D074
		public IVectorInfo? Offset
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06028EB5 RID: 167605 RVA: 0x0059EED1 File Offset: 0x0059D0D1
		public static Offset<ICharacterAirCurrentConfig> CreateICharacterAirCurrentConfig(FlatBufferBuilder builder, long BulletId = 0L, Offset<IVectorInfo> RangeOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			ICharacterAirCurrentConfig.AddBulletId(builder, BulletId);
			ICharacterAirCurrentConfig.AddOffset(builder, OffsetOffset);
			ICharacterAirCurrentConfig.AddRange(builder, RangeOffset);
			return ICharacterAirCurrentConfig.EndICharacterAirCurrentConfig(builder);
		}

		// Token: 0x06028EB6 RID: 167606 RVA: 0x0059EEF5 File Offset: 0x0059D0F5
		public static void StartICharacterAirCurrentConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06028EB7 RID: 167607 RVA: 0x0059EEFE File Offset: 0x0059D0FE
		public static void AddBulletId(FlatBufferBuilder builder, long bulletId)
		{
			builder.AddLong(0, bulletId, 0L);
		}

		// Token: 0x06028EB8 RID: 167608 RVA: 0x0059EF0A File Offset: 0x0059D10A
		public static void AddRange(FlatBufferBuilder builder, Offset<IVectorInfo> rangeOffset)
		{
			builder.AddOffset(1, rangeOffset.Value, 0);
		}

		// Token: 0x06028EB9 RID: 167609 RVA: 0x0059EF1A File Offset: 0x0059D11A
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(2, offsetOffset.Value, 0);
		}

		// Token: 0x06028EBA RID: 167610 RVA: 0x0059EF2A File Offset: 0x0059D12A
		public static Offset<ICharacterAirCurrentConfig> EndICharacterAirCurrentConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICharacterAirCurrentConfig>(builder.EndTable());
		}

		// Token: 0x06028EBB RID: 167611 RVA: 0x0059EF38 File Offset: 0x0059D138
		public ICharacterAirCurrentConfigT UnPack()
		{
			ICharacterAirCurrentConfigT characterAirCurrentConfigT = new ICharacterAirCurrentConfigT();
			this.UnPackTo(characterAirCurrentConfigT);
			return characterAirCurrentConfigT;
		}

		// Token: 0x06028EBC RID: 167612 RVA: 0x0059EF54 File Offset: 0x0059D154
		public void UnPackTo(ICharacterAirCurrentConfigT _o)
		{
			_o.BulletId = this.BulletId;
			_o.Range = ((this.Range != null) ? this.Range.Value.UnPack() : null);
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
		}

		// Token: 0x06028EBD RID: 167613 RVA: 0x0059EFCC File Offset: 0x0059D1CC
		public static Offset<ICharacterAirCurrentConfig> Pack(FlatBufferBuilder builder, ICharacterAirCurrentConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICharacterAirCurrentConfig>);
			}
			Offset<IVectorInfo> rangeOffset = (_o.Range == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Range);
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			return ICharacterAirCurrentConfig.CreateICharacterAirCurrentConfig(builder, _o.BulletId, rangeOffset, offsetOffset);
		}

		// Token: 0x0400F738 RID: 63288
		private Table __p;
	}
}
