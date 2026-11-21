using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007836 RID: 30774
	public struct ISetReviveRegion : IFlatbufferObject
	{
		// Token: 0x1700E1C9 RID: 57801
		// (get) Token: 0x060361E5 RID: 221669 RVA: 0x00740114 File Offset: 0x0073E314
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060361E6 RID: 221670 RVA: 0x00740121 File Offset: 0x0073E321
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060361E7 RID: 221671 RVA: 0x00740128 File Offset: 0x0073E328
		public static ISetReviveRegion GetRootAsISetReviveRegion(ByteBuffer _bb)
		{
			return ISetReviveRegion.GetRootAsISetReviveRegion(_bb, default(ISetReviveRegion));
		}

		// Token: 0x060361E8 RID: 221672 RVA: 0x00740144 File Offset: 0x0073E344
		public static ISetReviveRegion GetRootAsISetReviveRegion(ByteBuffer _bb, ISetReviveRegion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060361E9 RID: 221673 RVA: 0x00740161 File Offset: 0x0073E361
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060361EA RID: 221674 RVA: 0x00740170 File Offset: 0x0073E370
		public ISetReviveRegion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E1CA RID: 57802
		// (get) Token: 0x060361EB RID: 221675 RVA: 0x00740180 File Offset: 0x0073E380
		public ESetReviveType SetReviveType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESetReviveType.Add;
				}
				return (ESetReviveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E1CB RID: 57803
		// (get) Token: 0x060361EC RID: 221676 RVA: 0x007401BC File Offset: 0x0073E3BC
		public int ReviveId
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

		// Token: 0x060361ED RID: 221677 RVA: 0x007401F8 File Offset: 0x0073E3F8
		public static Offset<ISetReviveRegion> CreateISetReviveRegion(FlatBufferBuilder builder, ESetReviveType SetReviveType = ESetReviveType.Add, int ReviveId = 0)
		{
			builder.StartTable(2);
			ISetReviveRegion.AddReviveId(builder, ReviveId);
			ISetReviveRegion.AddSetReviveType(builder, SetReviveType);
			return ISetReviveRegion.EndISetReviveRegion(builder);
		}

		// Token: 0x060361EE RID: 221678 RVA: 0x00740215 File Offset: 0x0073E415
		public static void StartISetReviveRegion(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060361EF RID: 221679 RVA: 0x0074021E File Offset: 0x0073E41E
		public static void AddSetReviveType(FlatBufferBuilder builder, ESetReviveType setReviveType)
		{
			builder.AddByte(0, (byte)setReviveType, 0);
		}

		// Token: 0x060361F0 RID: 221680 RVA: 0x00740229 File Offset: 0x0073E429
		public static void AddReviveId(FlatBufferBuilder builder, int reviveId)
		{
			builder.AddInt(1, reviveId, 0);
		}

		// Token: 0x060361F1 RID: 221681 RVA: 0x00740234 File Offset: 0x0073E434
		public static Offset<ISetReviveRegion> EndISetReviveRegion(FlatBufferBuilder builder)
		{
			return new Offset<ISetReviveRegion>(builder.EndTable());
		}

		// Token: 0x060361F2 RID: 221682 RVA: 0x00740244 File Offset: 0x0073E444
		public ISetReviveRegionT UnPack()
		{
			ISetReviveRegionT setReviveRegionT = new ISetReviveRegionT();
			this.UnPackTo(setReviveRegionT);
			return setReviveRegionT;
		}

		// Token: 0x060361F3 RID: 221683 RVA: 0x0074025F File Offset: 0x0073E45F
		public void UnPackTo(ISetReviveRegionT _o)
		{
			_o.SetReviveType = this.SetReviveType;
			_o.ReviveId = this.ReviveId;
		}

		// Token: 0x060361F4 RID: 221684 RVA: 0x0074027C File Offset: 0x0073E47C
		public static Offset<ISetReviveRegion> Pack(FlatBufferBuilder builder, ISetReviveRegionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetReviveRegion>);
			}
			return ISetReviveRegion.CreateISetReviveRegion(builder, _o.SetReviveType, _o.ReviveId);
		}

		// Token: 0x04012ABC RID: 76476
		private Table __p;
	}
}
