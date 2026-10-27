using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004524 RID: 17700
	public struct IMarbleItemLevelBase : IFlatbufferObject
	{
		// Token: 0x17007D83 RID: 32131
		// (get) Token: 0x0601A9BB RID: 108987 RVA: 0x003CC656 File Offset: 0x003CA856
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A9BC RID: 108988 RVA: 0x003CC663 File Offset: 0x003CA863
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A9BD RID: 108989 RVA: 0x003CC66C File Offset: 0x003CA86C
		public static IMarbleItemLevelBase GetRootAsIMarbleItemLevelBase(ByteBuffer _bb)
		{
			return IMarbleItemLevelBase.GetRootAsIMarbleItemLevelBase(_bb, default(IMarbleItemLevelBase));
		}

		// Token: 0x0601A9BE RID: 108990 RVA: 0x003CC688 File Offset: 0x003CA888
		public static IMarbleItemLevelBase GetRootAsIMarbleItemLevelBase(ByteBuffer _bb, IMarbleItemLevelBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A9BF RID: 108991 RVA: 0x003CC6A5 File Offset: 0x003CA8A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A9C0 RID: 108992 RVA: 0x003CC6B4 File Offset: 0x003CA8B4
		public IMarbleItemLevelBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D84 RID: 32132
		// (get) Token: 0x0601A9C1 RID: 108993 RVA: 0x003CC6C4 File Offset: 0x003CA8C4
		public int Id
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

		// Token: 0x17007D85 RID: 32133
		// (get) Token: 0x0601A9C2 RID: 108994 RVA: 0x003CC700 File Offset: 0x003CA900
		public ETwoDimensionLevelType Type
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ETwoDimensionLevelType.Marble;
				}
				return (ETwoDimensionLevelType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007D86 RID: 32134
		// (get) Token: 0x0601A9C3 RID: 108995 RVA: 0x003CC73C File Offset: 0x003CA93C
		public ITwoDimensionTransform? Transform
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ITwoDimensionTransform?(default(ITwoDimensionTransform).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007D87 RID: 32135
		// (get) Token: 0x0601A9C4 RID: 108996 RVA: 0x003CC79C File Offset: 0x003CA99C
		public EMarbleItemType SubType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EMarbleItemType.CommonItem;
				}
				return (EMarbleItemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A9C5 RID: 108997 RVA: 0x003CC7D9 File Offset: 0x003CA9D9
		public static Offset<IMarbleItemLevelBase> CreateIMarbleItemLevelBase(FlatBufferBuilder builder, int Id = 0, ETwoDimensionLevelType Type = ETwoDimensionLevelType.Marble, Offset<ITwoDimensionTransform> TransformOffset = default(Offset<ITwoDimensionTransform>), EMarbleItemType SubType = EMarbleItemType.CommonItem)
		{
			builder.StartTable(4);
			IMarbleItemLevelBase.AddTransform(builder, TransformOffset);
			IMarbleItemLevelBase.AddId(builder, Id);
			IMarbleItemLevelBase.AddSubType(builder, SubType);
			IMarbleItemLevelBase.AddType(builder, Type);
			return IMarbleItemLevelBase.EndIMarbleItemLevelBase(builder);
		}

		// Token: 0x0601A9C6 RID: 108998 RVA: 0x003CC805 File Offset: 0x003CAA05
		public static void StartIMarbleItemLevelBase(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601A9C7 RID: 108999 RVA: 0x003CC80E File Offset: 0x003CAA0E
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601A9C8 RID: 109000 RVA: 0x003CC819 File Offset: 0x003CAA19
		public static void AddType(FlatBufferBuilder builder, ETwoDimensionLevelType type)
		{
			builder.AddByte(1, (byte)type, 0);
		}

		// Token: 0x0601A9C9 RID: 109001 RVA: 0x003CC824 File Offset: 0x003CAA24
		public static void AddTransform(FlatBufferBuilder builder, Offset<ITwoDimensionTransform> transformOffset)
		{
			builder.AddOffset(2, transformOffset.Value, 0);
		}

		// Token: 0x0601A9CA RID: 109002 RVA: 0x003CC834 File Offset: 0x003CAA34
		public static void AddSubType(FlatBufferBuilder builder, EMarbleItemType subType)
		{
			builder.AddByte(3, (byte)subType, 0);
		}

		// Token: 0x0601A9CB RID: 109003 RVA: 0x003CC83F File Offset: 0x003CAA3F
		public static Offset<IMarbleItemLevelBase> EndIMarbleItemLevelBase(FlatBufferBuilder builder)
		{
			return new Offset<IMarbleItemLevelBase>(builder.EndTable());
		}

		// Token: 0x0601A9CC RID: 109004 RVA: 0x003CC84C File Offset: 0x003CAA4C
		public IMarbleItemLevelBaseT UnPack()
		{
			IMarbleItemLevelBaseT marbleItemLevelBaseT = new IMarbleItemLevelBaseT();
			this.UnPackTo(marbleItemLevelBaseT);
			return marbleItemLevelBaseT;
		}

		// Token: 0x0601A9CD RID: 109005 RVA: 0x003CC868 File Offset: 0x003CAA68
		public void UnPackTo(IMarbleItemLevelBaseT _o)
		{
			_o.Id = this.Id;
			_o.Type = this.Type;
			_o.Transform = ((this.Transform != null) ? this.Transform.Value.UnPack() : null);
			_o.SubType = this.SubType;
		}

		// Token: 0x0601A9CE RID: 109006 RVA: 0x003CC8C8 File Offset: 0x003CAAC8
		public static Offset<IMarbleItemLevelBase> Pack(FlatBufferBuilder builder, IMarbleItemLevelBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMarbleItemLevelBase>);
			}
			Offset<ITwoDimensionTransform> transformOffset = (_o.Transform == null) ? default(Offset<ITwoDimensionTransform>) : ITwoDimensionTransform.Pack(builder, _o.Transform);
			return IMarbleItemLevelBase.CreateIMarbleItemLevelBase(builder, _o.Id, _o.Type, transformOffset, _o.SubType);
		}

		// Token: 0x0400C5A4 RID: 50596
		private Table __p;
	}
}
