using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047BD RID: 18365
	public struct IEntityOwnerInfo : IFlatbufferObject
	{
		// Token: 0x170083ED RID: 33773
		// (get) Token: 0x0601C5B5 RID: 116149 RVA: 0x004036FC File Offset: 0x004018FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C5B6 RID: 116150 RVA: 0x00403709 File Offset: 0x00401909
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C5B7 RID: 116151 RVA: 0x00403710 File Offset: 0x00401910
		public static IEntityOwnerInfo GetRootAsIEntityOwnerInfo(ByteBuffer _bb)
		{
			return IEntityOwnerInfo.GetRootAsIEntityOwnerInfo(_bb, default(IEntityOwnerInfo));
		}

		// Token: 0x0601C5B8 RID: 116152 RVA: 0x0040372C File Offset: 0x0040192C
		public static IEntityOwnerInfo GetRootAsIEntityOwnerInfo(ByteBuffer _bb, IEntityOwnerInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C5B9 RID: 116153 RVA: 0x00403749 File Offset: 0x00401949
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C5BA RID: 116154 RVA: 0x00403758 File Offset: 0x00401958
		public IEntityOwnerInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170083EE RID: 33774
		// (get) Token: 0x0601C5BB RID: 116155 RVA: 0x00403768 File Offset: 0x00401968
		public EEntityOwnerType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEntityOwnerType.Quest;
				}
				return (EEntityOwnerType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C5BC RID: 116156 RVA: 0x004037A4 File Offset: 0x004019A4
		public static Offset<IEntityOwnerInfo> CreateIEntityOwnerInfo(FlatBufferBuilder builder, EEntityOwnerType Type = EEntityOwnerType.Quest)
		{
			builder.StartTable(1);
			IEntityOwnerInfo.AddType(builder, Type);
			return IEntityOwnerInfo.EndIEntityOwnerInfo(builder);
		}

		// Token: 0x0601C5BD RID: 116157 RVA: 0x004037BA File Offset: 0x004019BA
		public static void StartIEntityOwnerInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601C5BE RID: 116158 RVA: 0x004037C3 File Offset: 0x004019C3
		public static void AddType(FlatBufferBuilder builder, EEntityOwnerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C5BF RID: 116159 RVA: 0x004037CE File Offset: 0x004019CE
		public static Offset<IEntityOwnerInfo> EndIEntityOwnerInfo(FlatBufferBuilder builder)
		{
			return new Offset<IEntityOwnerInfo>(builder.EndTable());
		}

		// Token: 0x0601C5C0 RID: 116160 RVA: 0x004037DC File Offset: 0x004019DC
		public IEntityOwnerInfoT UnPack()
		{
			IEntityOwnerInfoT entityOwnerInfoT = new IEntityOwnerInfoT();
			this.UnPackTo(entityOwnerInfoT);
			return entityOwnerInfoT;
		}

		// Token: 0x0601C5C1 RID: 116161 RVA: 0x004037F7 File Offset: 0x004019F7
		public void UnPackTo(IEntityOwnerInfoT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601C5C2 RID: 116162 RVA: 0x00403808 File Offset: 0x00401A08
		public static Offset<IEntityOwnerInfo> Pack(FlatBufferBuilder builder, IEntityOwnerInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityOwnerInfo>);
			}
			return IEntityOwnerInfo.CreateIEntityOwnerInfo(builder, _o.Type);
		}

		// Token: 0x0400CC42 RID: 52290
		private Table __p;
	}
}
