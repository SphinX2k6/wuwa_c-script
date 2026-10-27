using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004440 RID: 17472
	public struct ICenterBullZone : IFlatbufferObject
	{
		// Token: 0x17007B1A RID: 31514
		// (get) Token: 0x06019FE2 RID: 106466 RVA: 0x003B73BE File Offset: 0x003B55BE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019FE3 RID: 106467 RVA: 0x003B73CB File Offset: 0x003B55CB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019FE4 RID: 106468 RVA: 0x003B73D4 File Offset: 0x003B55D4
		public static ICenterBullZone GetRootAsICenterBullZone(ByteBuffer _bb)
		{
			return ICenterBullZone.GetRootAsICenterBullZone(_bb, default(ICenterBullZone));
		}

		// Token: 0x06019FE5 RID: 106469 RVA: 0x003B73F0 File Offset: 0x003B55F0
		public static ICenterBullZone GetRootAsICenterBullZone(ByteBuffer _bb, ICenterBullZone obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019FE6 RID: 106470 RVA: 0x003B740D File Offset: 0x003B560D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019FE7 RID: 106471 RVA: 0x003B741C File Offset: 0x003B561C
		public ICenterBullZone __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007B1B RID: 31515
		// (get) Token: 0x06019FE8 RID: 106472 RVA: 0x003B742C File Offset: 0x003B562C
		public EDartboardZoneType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDartboardZoneType.CenterBull;
				}
				return (EDartboardZoneType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019FE9 RID: 106473 RVA: 0x003B7468 File Offset: 0x003B5668
		public static Offset<ICenterBullZone> CreateICenterBullZone(FlatBufferBuilder builder, EDartboardZoneType Type = EDartboardZoneType.CenterBull)
		{
			builder.StartTable(1);
			ICenterBullZone.AddType(builder, Type);
			return ICenterBullZone.EndICenterBullZone(builder);
		}

		// Token: 0x06019FEA RID: 106474 RVA: 0x003B747E File Offset: 0x003B567E
		public static void StartICenterBullZone(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019FEB RID: 106475 RVA: 0x003B7487 File Offset: 0x003B5687
		public static void AddType(FlatBufferBuilder builder, EDartboardZoneType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019FEC RID: 106476 RVA: 0x003B7492 File Offset: 0x003B5692
		public static Offset<ICenterBullZone> EndICenterBullZone(FlatBufferBuilder builder)
		{
			return new Offset<ICenterBullZone>(builder.EndTable());
		}

		// Token: 0x06019FED RID: 106477 RVA: 0x003B74A0 File Offset: 0x003B56A0
		public ICenterBullZoneT UnPack()
		{
			ICenterBullZoneT centerBullZoneT = new ICenterBullZoneT();
			this.UnPackTo(centerBullZoneT);
			return centerBullZoneT;
		}

		// Token: 0x06019FEE RID: 106478 RVA: 0x003B74BB File Offset: 0x003B56BB
		public void UnPackTo(ICenterBullZoneT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06019FEF RID: 106479 RVA: 0x003B74CC File Offset: 0x003B56CC
		public static Offset<ICenterBullZone> Pack(FlatBufferBuilder builder, ICenterBullZoneT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICenterBullZone>);
			}
			return ICenterBullZone.CreateICenterBullZone(builder, _o.Type);
		}

		// Token: 0x0400C40E RID: 50190
		private Table __p;
	}
}
