using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063A7 RID: 25511
	public struct ICharacterAirCurrentConfig : IFlatbufferObject
	{
		// Token: 0x1700BC86 RID: 48262
		// (get) Token: 0x0602B516 RID: 177430 RVA: 0x005E77D5 File Offset: 0x005E59D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B517 RID: 177431 RVA: 0x005E77E2 File Offset: 0x005E59E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B518 RID: 177432 RVA: 0x005E77EC File Offset: 0x005E59EC
		public static ICharacterAirCurrentConfig GetRootAsICharacterAirCurrentConfig(ByteBuffer _bb)
		{
			return ICharacterAirCurrentConfig.GetRootAsICharacterAirCurrentConfig(_bb, default(ICharacterAirCurrentConfig));
		}

		// Token: 0x0602B519 RID: 177433 RVA: 0x005E7808 File Offset: 0x005E5A08
		public static ICharacterAirCurrentConfig GetRootAsICharacterAirCurrentConfig(ByteBuffer _bb, ICharacterAirCurrentConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B51A RID: 177434 RVA: 0x005E7825 File Offset: 0x005E5A25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B51B RID: 177435 RVA: 0x005E7834 File Offset: 0x005E5A34
		public ICharacterAirCurrentConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC87 RID: 48263
		// (get) Token: 0x0602B51C RID: 177436 RVA: 0x005E7844 File Offset: 0x005E5A44
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

		// Token: 0x1700BC88 RID: 48264
		// (get) Token: 0x0602B51D RID: 177437 RVA: 0x005E7884 File Offset: 0x005E5A84
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

		// Token: 0x1700BC89 RID: 48265
		// (get) Token: 0x0602B51E RID: 177438 RVA: 0x005E78E4 File Offset: 0x005E5AE4
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

		// Token: 0x0602B51F RID: 177439 RVA: 0x005E7941 File Offset: 0x005E5B41
		public static Offset<ICharacterAirCurrentConfig> CreateICharacterAirCurrentConfig(FlatBufferBuilder builder, long BulletId = 0L, Offset<IVectorInfo> RangeOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			ICharacterAirCurrentConfig.AddBulletId(builder, BulletId);
			ICharacterAirCurrentConfig.AddOffset(builder, OffsetOffset);
			ICharacterAirCurrentConfig.AddRange(builder, RangeOffset);
			return ICharacterAirCurrentConfig.EndICharacterAirCurrentConfig(builder);
		}

		// Token: 0x0602B520 RID: 177440 RVA: 0x005E7965 File Offset: 0x005E5B65
		public static void StartICharacterAirCurrentConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602B521 RID: 177441 RVA: 0x005E796E File Offset: 0x005E5B6E
		public static void AddBulletId(FlatBufferBuilder builder, long bulletId)
		{
			builder.AddLong(0, bulletId, 0L);
		}

		// Token: 0x0602B522 RID: 177442 RVA: 0x005E797A File Offset: 0x005E5B7A
		public static void AddRange(FlatBufferBuilder builder, Offset<IVectorInfo> rangeOffset)
		{
			builder.AddOffset(1, rangeOffset.Value, 0);
		}

		// Token: 0x0602B523 RID: 177443 RVA: 0x005E798A File Offset: 0x005E5B8A
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(2, offsetOffset.Value, 0);
		}

		// Token: 0x0602B524 RID: 177444 RVA: 0x005E799A File Offset: 0x005E5B9A
		public static Offset<ICharacterAirCurrentConfig> EndICharacterAirCurrentConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICharacterAirCurrentConfig>(builder.EndTable());
		}

		// Token: 0x0602B525 RID: 177445 RVA: 0x005E79A8 File Offset: 0x005E5BA8
		public ICharacterAirCurrentConfigT UnPack()
		{
			ICharacterAirCurrentConfigT characterAirCurrentConfigT = new ICharacterAirCurrentConfigT();
			this.UnPackTo(characterAirCurrentConfigT);
			return characterAirCurrentConfigT;
		}

		// Token: 0x0602B526 RID: 177446 RVA: 0x005E79C4 File Offset: 0x005E5BC4
		public void UnPackTo(ICharacterAirCurrentConfigT _o)
		{
			_o.BulletId = this.BulletId;
			_o.Range = ((this.Range != null) ? this.Range.Value.UnPack() : null);
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
		}

		// Token: 0x0602B527 RID: 177447 RVA: 0x005E7A3C File Offset: 0x005E5C3C
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

		// Token: 0x0401048A RID: 66698
		private Table __p;
	}
}
