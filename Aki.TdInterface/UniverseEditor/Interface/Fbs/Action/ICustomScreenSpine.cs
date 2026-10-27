using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200650A RID: 25866
	public struct ICustomScreenSpine : IFlatbufferObject
	{
		// Token: 0x1700C057 RID: 49239
		// (get) Token: 0x0602CDE1 RID: 183777 RVA: 0x00629B7A File Offset: 0x00627D7A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CDE2 RID: 183778 RVA: 0x00629B87 File Offset: 0x00627D87
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CDE3 RID: 183779 RVA: 0x00629B90 File Offset: 0x00627D90
		public static ICustomScreenSpine GetRootAsICustomScreenSpine(ByteBuffer _bb)
		{
			return ICustomScreenSpine.GetRootAsICustomScreenSpine(_bb, default(ICustomScreenSpine));
		}

		// Token: 0x0602CDE4 RID: 183780 RVA: 0x00629BAC File Offset: 0x00627DAC
		public static ICustomScreenSpine GetRootAsICustomScreenSpine(ByteBuffer _bb, ICustomScreenSpine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CDE5 RID: 183781 RVA: 0x00629BC9 File Offset: 0x00627DC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CDE6 RID: 183782 RVA: 0x00629BD8 File Offset: 0x00627DD8
		public ICustomScreenSpine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C058 RID: 49240
		// (get) Token: 0x0602CDE7 RID: 183783 RVA: 0x00629BE8 File Offset: 0x00627DE8
		public ECustomScreenType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECustomScreenType.Spine;
				}
				return (ECustomScreenType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C059 RID: 49241
		// (get) Token: 0x0602CDE8 RID: 183784 RVA: 0x00629C24 File Offset: 0x00627E24
		public int SpineId
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

		// Token: 0x0602CDE9 RID: 183785 RVA: 0x00629C60 File Offset: 0x00627E60
		public static Offset<ICustomScreenSpine> CreateICustomScreenSpine(FlatBufferBuilder builder, ECustomScreenType Type = ECustomScreenType.Spine, int SpineId = 0)
		{
			builder.StartTable(2);
			ICustomScreenSpine.AddSpineId(builder, SpineId);
			ICustomScreenSpine.AddType(builder, Type);
			return ICustomScreenSpine.EndICustomScreenSpine(builder);
		}

		// Token: 0x0602CDEA RID: 183786 RVA: 0x00629C7D File Offset: 0x00627E7D
		public static void StartICustomScreenSpine(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602CDEB RID: 183787 RVA: 0x00629C86 File Offset: 0x00627E86
		public static void AddType(FlatBufferBuilder builder, ECustomScreenType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CDEC RID: 183788 RVA: 0x00629C91 File Offset: 0x00627E91
		public static void AddSpineId(FlatBufferBuilder builder, int spineId)
		{
			builder.AddInt(1, spineId, 0);
		}

		// Token: 0x0602CDED RID: 183789 RVA: 0x00629C9C File Offset: 0x00627E9C
		public static Offset<ICustomScreenSpine> EndICustomScreenSpine(FlatBufferBuilder builder)
		{
			return new Offset<ICustomScreenSpine>(builder.EndTable());
		}

		// Token: 0x0602CDEE RID: 183790 RVA: 0x00629CAC File Offset: 0x00627EAC
		public ICustomScreenSpineT UnPack()
		{
			ICustomScreenSpineT customScreenSpineT = new ICustomScreenSpineT();
			this.UnPackTo(customScreenSpineT);
			return customScreenSpineT;
		}

		// Token: 0x0602CDEF RID: 183791 RVA: 0x00629CC7 File Offset: 0x00627EC7
		public void UnPackTo(ICustomScreenSpineT _o)
		{
			_o.Type = this.Type;
			_o.SpineId = this.SpineId;
		}

		// Token: 0x0602CDF0 RID: 183792 RVA: 0x00629CE4 File Offset: 0x00627EE4
		public static Offset<ICustomScreenSpine> Pack(FlatBufferBuilder builder, ICustomScreenSpineT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomScreenSpine>);
			}
			return ICustomScreenSpine.CreateICustomScreenSpine(builder, _o.Type, _o.SpineId);
		}

		// Token: 0x04010B4E RID: 68430
		private Table __p;
	}
}
