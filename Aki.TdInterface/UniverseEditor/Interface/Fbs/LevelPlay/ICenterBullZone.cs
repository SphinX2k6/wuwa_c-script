using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048A8 RID: 18600
	public struct ICenterBullZone : IFlatbufferObject
	{
		// Token: 0x17008159 RID: 33113
		// (get) Token: 0x0601B7B3 RID: 112563 RVA: 0x003E35CA File Offset: 0x003E17CA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B7B4 RID: 112564 RVA: 0x003E35D7 File Offset: 0x003E17D7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B7B5 RID: 112565 RVA: 0x003E35E0 File Offset: 0x003E17E0
		public static ICenterBullZone GetRootAsICenterBullZone(ByteBuffer _bb)
		{
			return ICenterBullZone.GetRootAsICenterBullZone(_bb, default(ICenterBullZone));
		}

		// Token: 0x0601B7B6 RID: 112566 RVA: 0x003E35FC File Offset: 0x003E17FC
		public static ICenterBullZone GetRootAsICenterBullZone(ByteBuffer _bb, ICenterBullZone obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B7B7 RID: 112567 RVA: 0x003E3619 File Offset: 0x003E1819
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B7B8 RID: 112568 RVA: 0x003E3628 File Offset: 0x003E1828
		public ICenterBullZone __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700815A RID: 33114
		// (get) Token: 0x0601B7B9 RID: 112569 RVA: 0x003E3638 File Offset: 0x003E1838
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

		// Token: 0x0601B7BA RID: 112570 RVA: 0x003E3674 File Offset: 0x003E1874
		public static Offset<ICenterBullZone> CreateICenterBullZone(FlatBufferBuilder builder, EDartboardZoneType Type = EDartboardZoneType.CenterBull)
		{
			builder.StartTable(1);
			ICenterBullZone.AddType(builder, Type);
			return ICenterBullZone.EndICenterBullZone(builder);
		}

		// Token: 0x0601B7BB RID: 112571 RVA: 0x003E368A File Offset: 0x003E188A
		public static void StartICenterBullZone(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B7BC RID: 112572 RVA: 0x003E3693 File Offset: 0x003E1893
		public static void AddType(FlatBufferBuilder builder, EDartboardZoneType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B7BD RID: 112573 RVA: 0x003E369E File Offset: 0x003E189E
		public static Offset<ICenterBullZone> EndICenterBullZone(FlatBufferBuilder builder)
		{
			return new Offset<ICenterBullZone>(builder.EndTable());
		}

		// Token: 0x0601B7BE RID: 112574 RVA: 0x003E36AC File Offset: 0x003E18AC
		public ICenterBullZoneT UnPack()
		{
			ICenterBullZoneT centerBullZoneT = new ICenterBullZoneT();
			this.UnPackTo(centerBullZoneT);
			return centerBullZoneT;
		}

		// Token: 0x0601B7BF RID: 112575 RVA: 0x003E36C7 File Offset: 0x003E18C7
		public void UnPackTo(ICenterBullZoneT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601B7C0 RID: 112576 RVA: 0x003E36D8 File Offset: 0x003E18D8
		public static Offset<ICenterBullZone> Pack(FlatBufferBuilder builder, ICenterBullZoneT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICenterBullZone>);
			}
			return ICenterBullZone.CreateICenterBullZone(builder, _o.Type);
		}

		// Token: 0x0400CE3C RID: 52796
		private Table __p;
	}
}
