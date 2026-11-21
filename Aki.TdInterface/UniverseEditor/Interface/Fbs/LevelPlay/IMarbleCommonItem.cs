using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004989 RID: 18825
	public struct IMarbleCommonItem : IFlatbufferObject
	{
		// Token: 0x170083B5 RID: 33717
		// (get) Token: 0x0601C166 RID: 115046 RVA: 0x003F8398 File Offset: 0x003F6598
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C167 RID: 115047 RVA: 0x003F83A5 File Offset: 0x003F65A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C168 RID: 115048 RVA: 0x003F83AC File Offset: 0x003F65AC
		public static IMarbleCommonItem GetRootAsIMarbleCommonItem(ByteBuffer _bb)
		{
			return IMarbleCommonItem.GetRootAsIMarbleCommonItem(_bb, default(IMarbleCommonItem));
		}

		// Token: 0x0601C169 RID: 115049 RVA: 0x003F83C8 File Offset: 0x003F65C8
		public static IMarbleCommonItem GetRootAsIMarbleCommonItem(ByteBuffer _bb, IMarbleCommonItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C16A RID: 115050 RVA: 0x003F83E5 File Offset: 0x003F65E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C16B RID: 115051 RVA: 0x003F83F4 File Offset: 0x003F65F4
		public IMarbleCommonItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170083B6 RID: 33718
		// (get) Token: 0x0601C16C RID: 115052 RVA: 0x003F8404 File Offset: 0x003F6604
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

		// Token: 0x170083B7 RID: 33719
		// (get) Token: 0x0601C16D RID: 115053 RVA: 0x003F8440 File Offset: 0x003F6640
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

		// Token: 0x170083B8 RID: 33720
		// (get) Token: 0x0601C16E RID: 115054 RVA: 0x003F847C File Offset: 0x003F667C
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

		// Token: 0x170083B9 RID: 33721
		// (get) Token: 0x0601C16F RID: 115055 RVA: 0x003F84DC File Offset: 0x003F66DC
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

		// Token: 0x170083BA RID: 33722
		// (get) Token: 0x0601C170 RID: 115056 RVA: 0x003F851C File Offset: 0x003F671C
		public int DataId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170083BB RID: 33723
		// (get) Token: 0x0601C171 RID: 115057 RVA: 0x003F855C File Offset: 0x003F675C
		public int AwakenWave
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170083BC RID: 33724
		// (get) Token: 0x0601C172 RID: 115058 RVA: 0x003F859C File Offset: 0x003F679C
		public int DestroyWave
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C173 RID: 115059 RVA: 0x003F85DC File Offset: 0x003F67DC
		public static Offset<IMarbleCommonItem> CreateIMarbleCommonItem(FlatBufferBuilder builder, int Id = 0, ETwoDimensionLevelType Type = ETwoDimensionLevelType.Marble, Offset<ITwoDimensionTransform> TransformOffset = default(Offset<ITwoDimensionTransform>), EMarbleItemType SubType = EMarbleItemType.CommonItem, int DataId = 0, int AwakenWave = 0, int DestroyWave = 0)
		{
			builder.StartTable(7);
			IMarbleCommonItem.AddDestroyWave(builder, DestroyWave);
			IMarbleCommonItem.AddAwakenWave(builder, AwakenWave);
			IMarbleCommonItem.AddDataId(builder, DataId);
			IMarbleCommonItem.AddTransform(builder, TransformOffset);
			IMarbleCommonItem.AddId(builder, Id);
			IMarbleCommonItem.AddSubType(builder, SubType);
			IMarbleCommonItem.AddType(builder, Type);
			return IMarbleCommonItem.EndIMarbleCommonItem(builder);
		}

		// Token: 0x0601C174 RID: 115060 RVA: 0x003F862B File Offset: 0x003F682B
		public static void StartIMarbleCommonItem(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601C175 RID: 115061 RVA: 0x003F8634 File Offset: 0x003F6834
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601C176 RID: 115062 RVA: 0x003F863F File Offset: 0x003F683F
		public static void AddType(FlatBufferBuilder builder, ETwoDimensionLevelType type)
		{
			builder.AddByte(1, (byte)type, 0);
		}

		// Token: 0x0601C177 RID: 115063 RVA: 0x003F864A File Offset: 0x003F684A
		public static void AddTransform(FlatBufferBuilder builder, Offset<ITwoDimensionTransform> transformOffset)
		{
			builder.AddOffset(2, transformOffset.Value, 0);
		}

		// Token: 0x0601C178 RID: 115064 RVA: 0x003F865A File Offset: 0x003F685A
		public static void AddSubType(FlatBufferBuilder builder, EMarbleItemType subType)
		{
			builder.AddByte(3, (byte)subType, 0);
		}

		// Token: 0x0601C179 RID: 115065 RVA: 0x003F8665 File Offset: 0x003F6865
		public static void AddDataId(FlatBufferBuilder builder, int dataId)
		{
			builder.AddInt(4, dataId, 0);
		}

		// Token: 0x0601C17A RID: 115066 RVA: 0x003F8670 File Offset: 0x003F6870
		public static void AddAwakenWave(FlatBufferBuilder builder, int awakenWave)
		{
			builder.AddInt(5, awakenWave, 0);
		}

		// Token: 0x0601C17B RID: 115067 RVA: 0x003F867B File Offset: 0x003F687B
		public static void AddDestroyWave(FlatBufferBuilder builder, int destroyWave)
		{
			builder.AddInt(6, destroyWave, 0);
		}

		// Token: 0x0601C17C RID: 115068 RVA: 0x003F8686 File Offset: 0x003F6886
		public static Offset<IMarbleCommonItem> EndIMarbleCommonItem(FlatBufferBuilder builder)
		{
			return new Offset<IMarbleCommonItem>(builder.EndTable());
		}

		// Token: 0x0601C17D RID: 115069 RVA: 0x003F8694 File Offset: 0x003F6894
		public IMarbleCommonItemT UnPack()
		{
			IMarbleCommonItemT marbleCommonItemT = new IMarbleCommonItemT();
			this.UnPackTo(marbleCommonItemT);
			return marbleCommonItemT;
		}

		// Token: 0x0601C17E RID: 115070 RVA: 0x003F86B0 File Offset: 0x003F68B0
		public void UnPackTo(IMarbleCommonItemT _o)
		{
			_o.Id = this.Id;
			_o.Type = this.Type;
			_o.Transform = ((this.Transform != null) ? this.Transform.Value.UnPack() : null);
			_o.SubType = this.SubType;
			_o.DataId = this.DataId;
			_o.AwakenWave = this.AwakenWave;
			_o.DestroyWave = this.DestroyWave;
		}

		// Token: 0x0601C17F RID: 115071 RVA: 0x003F8734 File Offset: 0x003F6934
		public static Offset<IMarbleCommonItem> Pack(FlatBufferBuilder builder, IMarbleCommonItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMarbleCommonItem>);
			}
			Offset<ITwoDimensionTransform> transformOffset = (_o.Transform == null) ? default(Offset<ITwoDimensionTransform>) : ITwoDimensionTransform.Pack(builder, _o.Transform);
			return IMarbleCommonItem.CreateIMarbleCommonItem(builder, _o.Id, _o.Type, transformOffset, _o.SubType, _o.DataId, _o.AwakenWave, _o.DestroyWave);
		}

		// Token: 0x0400CFCB RID: 53195
		private Table __p;
	}
}
