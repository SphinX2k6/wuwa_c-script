using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200498C RID: 18828
	public struct IMarbleItemLevelBase : IFlatbufferObject
	{
		// Token: 0x170083C4 RID: 33732
		// (get) Token: 0x0601C190 RID: 115088 RVA: 0x003F88F2 File Offset: 0x003F6AF2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C191 RID: 115089 RVA: 0x003F88FF File Offset: 0x003F6AFF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C192 RID: 115090 RVA: 0x003F8908 File Offset: 0x003F6B08
		public static IMarbleItemLevelBase GetRootAsIMarbleItemLevelBase(ByteBuffer _bb)
		{
			return IMarbleItemLevelBase.GetRootAsIMarbleItemLevelBase(_bb, default(IMarbleItemLevelBase));
		}

		// Token: 0x0601C193 RID: 115091 RVA: 0x003F8924 File Offset: 0x003F6B24
		public static IMarbleItemLevelBase GetRootAsIMarbleItemLevelBase(ByteBuffer _bb, IMarbleItemLevelBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C194 RID: 115092 RVA: 0x003F8941 File Offset: 0x003F6B41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C195 RID: 115093 RVA: 0x003F8950 File Offset: 0x003F6B50
		public IMarbleItemLevelBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170083C5 RID: 33733
		// (get) Token: 0x0601C196 RID: 115094 RVA: 0x003F8960 File Offset: 0x003F6B60
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

		// Token: 0x170083C6 RID: 33734
		// (get) Token: 0x0601C197 RID: 115095 RVA: 0x003F899C File Offset: 0x003F6B9C
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

		// Token: 0x170083C7 RID: 33735
		// (get) Token: 0x0601C198 RID: 115096 RVA: 0x003F89D8 File Offset: 0x003F6BD8
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

		// Token: 0x170083C8 RID: 33736
		// (get) Token: 0x0601C199 RID: 115097 RVA: 0x003F8A38 File Offset: 0x003F6C38
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

		// Token: 0x0601C19A RID: 115098 RVA: 0x003F8A75 File Offset: 0x003F6C75
		public static Offset<IMarbleItemLevelBase> CreateIMarbleItemLevelBase(FlatBufferBuilder builder, int Id = 0, ETwoDimensionLevelType Type = ETwoDimensionLevelType.Marble, Offset<ITwoDimensionTransform> TransformOffset = default(Offset<ITwoDimensionTransform>), EMarbleItemType SubType = EMarbleItemType.CommonItem)
		{
			builder.StartTable(4);
			IMarbleItemLevelBase.AddTransform(builder, TransformOffset);
			IMarbleItemLevelBase.AddId(builder, Id);
			IMarbleItemLevelBase.AddSubType(builder, SubType);
			IMarbleItemLevelBase.AddType(builder, Type);
			return IMarbleItemLevelBase.EndIMarbleItemLevelBase(builder);
		}

		// Token: 0x0601C19B RID: 115099 RVA: 0x003F8AA1 File Offset: 0x003F6CA1
		public static void StartIMarbleItemLevelBase(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601C19C RID: 115100 RVA: 0x003F8AAA File Offset: 0x003F6CAA
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601C19D RID: 115101 RVA: 0x003F8AB5 File Offset: 0x003F6CB5
		public static void AddType(FlatBufferBuilder builder, ETwoDimensionLevelType type)
		{
			builder.AddByte(1, (byte)type, 0);
		}

		// Token: 0x0601C19E RID: 115102 RVA: 0x003F8AC0 File Offset: 0x003F6CC0
		public static void AddTransform(FlatBufferBuilder builder, Offset<ITwoDimensionTransform> transformOffset)
		{
			builder.AddOffset(2, transformOffset.Value, 0);
		}

		// Token: 0x0601C19F RID: 115103 RVA: 0x003F8AD0 File Offset: 0x003F6CD0
		public static void AddSubType(FlatBufferBuilder builder, EMarbleItemType subType)
		{
			builder.AddByte(3, (byte)subType, 0);
		}

		// Token: 0x0601C1A0 RID: 115104 RVA: 0x003F8ADB File Offset: 0x003F6CDB
		public static Offset<IMarbleItemLevelBase> EndIMarbleItemLevelBase(FlatBufferBuilder builder)
		{
			return new Offset<IMarbleItemLevelBase>(builder.EndTable());
		}

		// Token: 0x0601C1A1 RID: 115105 RVA: 0x003F8AE8 File Offset: 0x003F6CE8
		public IMarbleItemLevelBaseT UnPack()
		{
			IMarbleItemLevelBaseT marbleItemLevelBaseT = new IMarbleItemLevelBaseT();
			this.UnPackTo(marbleItemLevelBaseT);
			return marbleItemLevelBaseT;
		}

		// Token: 0x0601C1A2 RID: 115106 RVA: 0x003F8B04 File Offset: 0x003F6D04
		public void UnPackTo(IMarbleItemLevelBaseT _o)
		{
			_o.Id = this.Id;
			_o.Type = this.Type;
			_o.Transform = ((this.Transform != null) ? this.Transform.Value.UnPack() : null);
			_o.SubType = this.SubType;
		}

		// Token: 0x0601C1A3 RID: 115107 RVA: 0x003F8B64 File Offset: 0x003F6D64
		public static Offset<IMarbleItemLevelBase> Pack(FlatBufferBuilder builder, IMarbleItemLevelBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMarbleItemLevelBase>);
			}
			Offset<ITwoDimensionTransform> transformOffset = (_o.Transform == null) ? default(Offset<ITwoDimensionTransform>) : ITwoDimensionTransform.Pack(builder, _o.Transform);
			return IMarbleItemLevelBase.CreateIMarbleItemLevelBase(builder, _o.Id, _o.Type, transformOffset, _o.SubType);
		}

		// Token: 0x0400CFD3 RID: 53203
		private Table __p;
	}
}
