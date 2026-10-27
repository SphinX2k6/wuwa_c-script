using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200706A RID: 28778
	public struct ISetReviveRegion : IFlatbufferObject
	{
		// Token: 0x1700D5E6 RID: 54758
		// (get) Token: 0x06032F44 RID: 208708 RVA: 0x006DFB60 File Offset: 0x006DDD60
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032F45 RID: 208709 RVA: 0x006DFB6D File Offset: 0x006DDD6D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032F46 RID: 208710 RVA: 0x006DFB74 File Offset: 0x006DDD74
		public static ISetReviveRegion GetRootAsISetReviveRegion(ByteBuffer _bb)
		{
			return ISetReviveRegion.GetRootAsISetReviveRegion(_bb, default(ISetReviveRegion));
		}

		// Token: 0x06032F47 RID: 208711 RVA: 0x006DFB90 File Offset: 0x006DDD90
		public static ISetReviveRegion GetRootAsISetReviveRegion(ByteBuffer _bb, ISetReviveRegion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032F48 RID: 208712 RVA: 0x006DFBAD File Offset: 0x006DDDAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032F49 RID: 208713 RVA: 0x006DFBBC File Offset: 0x006DDDBC
		public ISetReviveRegion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D5E7 RID: 54759
		// (get) Token: 0x06032F4A RID: 208714 RVA: 0x006DFBCC File Offset: 0x006DDDCC
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

		// Token: 0x1700D5E8 RID: 54760
		// (get) Token: 0x06032F4B RID: 208715 RVA: 0x006DFC08 File Offset: 0x006DDE08
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

		// Token: 0x06032F4C RID: 208716 RVA: 0x006DFC44 File Offset: 0x006DDE44
		public static Offset<ISetReviveRegion> CreateISetReviveRegion(FlatBufferBuilder builder, ESetReviveType SetReviveType = ESetReviveType.Add, int ReviveId = 0)
		{
			builder.StartTable(2);
			ISetReviveRegion.AddReviveId(builder, ReviveId);
			ISetReviveRegion.AddSetReviveType(builder, SetReviveType);
			return ISetReviveRegion.EndISetReviveRegion(builder);
		}

		// Token: 0x06032F4D RID: 208717 RVA: 0x006DFC61 File Offset: 0x006DDE61
		public static void StartISetReviveRegion(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032F4E RID: 208718 RVA: 0x006DFC6A File Offset: 0x006DDE6A
		public static void AddSetReviveType(FlatBufferBuilder builder, ESetReviveType setReviveType)
		{
			builder.AddByte(0, (byte)setReviveType, 0);
		}

		// Token: 0x06032F4F RID: 208719 RVA: 0x006DFC75 File Offset: 0x006DDE75
		public static void AddReviveId(FlatBufferBuilder builder, int reviveId)
		{
			builder.AddInt(1, reviveId, 0);
		}

		// Token: 0x06032F50 RID: 208720 RVA: 0x006DFC80 File Offset: 0x006DDE80
		public static Offset<ISetReviveRegion> EndISetReviveRegion(FlatBufferBuilder builder)
		{
			return new Offset<ISetReviveRegion>(builder.EndTable());
		}

		// Token: 0x06032F51 RID: 208721 RVA: 0x006DFC90 File Offset: 0x006DDE90
		public ISetReviveRegionT UnPack()
		{
			ISetReviveRegionT setReviveRegionT = new ISetReviveRegionT();
			this.UnPackTo(setReviveRegionT);
			return setReviveRegionT;
		}

		// Token: 0x06032F52 RID: 208722 RVA: 0x006DFCAB File Offset: 0x006DDEAB
		public void UnPackTo(ISetReviveRegionT _o)
		{
			_o.SetReviveType = this.SetReviveType;
			_o.ReviveId = this.ReviveId;
		}

		// Token: 0x06032F53 RID: 208723 RVA: 0x006DFCC8 File Offset: 0x006DDEC8
		public static Offset<ISetReviveRegion> Pack(FlatBufferBuilder builder, ISetReviveRegionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetReviveRegion>);
			}
			return ISetReviveRegion.CreateISetReviveRegion(builder, _o.SetReviveType, _o.ReviveId);
		}

		// Token: 0x04011ACE RID: 72398
		private Table __p;
	}
}
