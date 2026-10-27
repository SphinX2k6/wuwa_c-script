using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043BF RID: 17343
	public struct IRefSource : IFlatbufferObject
	{
		// Token: 0x17007AA8 RID: 31400
		// (get) Token: 0x06019DBE RID: 105918 RVA: 0x003B3A54 File Offset: 0x003B1C54
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019DBF RID: 105919 RVA: 0x003B3A61 File Offset: 0x003B1C61
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019DC0 RID: 105920 RVA: 0x003B3A68 File Offset: 0x003B1C68
		public static IRefSource GetRootAsIRefSource(ByteBuffer _bb)
		{
			return IRefSource.GetRootAsIRefSource(_bb, default(IRefSource));
		}

		// Token: 0x06019DC1 RID: 105921 RVA: 0x003B3A84 File Offset: 0x003B1C84
		public static IRefSource GetRootAsIRefSource(ByteBuffer _bb, IRefSource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019DC2 RID: 105922 RVA: 0x003B3AA1 File Offset: 0x003B1CA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019DC3 RID: 105923 RVA: 0x003B3AB0 File Offset: 0x003B1CB0
		public IRefSource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007AA9 RID: 31401
		// (get) Token: 0x06019DC4 RID: 105924 RVA: 0x003B3AC0 File Offset: 0x003B1CC0
		public ERefSourceType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERefSourceType.AwakeEntity;
				}
				return (ERefSourceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019DC5 RID: 105925 RVA: 0x003B3AFC File Offset: 0x003B1CFC
		public static Offset<IRefSource> CreateIRefSource(FlatBufferBuilder builder, ERefSourceType Type = ERefSourceType.AwakeEntity)
		{
			builder.StartTable(1);
			IRefSource.AddType(builder, Type);
			return IRefSource.EndIRefSource(builder);
		}

		// Token: 0x06019DC6 RID: 105926 RVA: 0x003B3B12 File Offset: 0x003B1D12
		public static void StartIRefSource(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019DC7 RID: 105927 RVA: 0x003B3B1B File Offset: 0x003B1D1B
		public static void AddType(FlatBufferBuilder builder, ERefSourceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019DC8 RID: 105928 RVA: 0x003B3B26 File Offset: 0x003B1D26
		public static Offset<IRefSource> EndIRefSource(FlatBufferBuilder builder)
		{
			return new Offset<IRefSource>(builder.EndTable());
		}

		// Token: 0x06019DC9 RID: 105929 RVA: 0x003B3B34 File Offset: 0x003B1D34
		public IRefSourceT UnPack()
		{
			IRefSourceT refSourceT = new IRefSourceT();
			this.UnPackTo(refSourceT);
			return refSourceT;
		}

		// Token: 0x06019DCA RID: 105930 RVA: 0x003B3B4F File Offset: 0x003B1D4F
		public void UnPackTo(IRefSourceT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06019DCB RID: 105931 RVA: 0x003B3B60 File Offset: 0x003B1D60
		public static Offset<IRefSource> Pack(FlatBufferBuilder builder, IRefSourceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRefSource>);
			}
			return IRefSource.CreateIRefSource(builder, _o.Type);
		}

		// Token: 0x0400C208 RID: 49672
		private Table __p;
	}
}
