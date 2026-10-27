using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004521 RID: 17697
	public struct IMarbleCommonItem : IFlatbufferObject
	{
		// Token: 0x17007D74 RID: 32116
		// (get) Token: 0x0601A991 RID: 108945 RVA: 0x003CC0FC File Offset: 0x003CA2FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A992 RID: 108946 RVA: 0x003CC109 File Offset: 0x003CA309
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A993 RID: 108947 RVA: 0x003CC110 File Offset: 0x003CA310
		public static IMarbleCommonItem GetRootAsIMarbleCommonItem(ByteBuffer _bb)
		{
			return IMarbleCommonItem.GetRootAsIMarbleCommonItem(_bb, default(IMarbleCommonItem));
		}

		// Token: 0x0601A994 RID: 108948 RVA: 0x003CC12C File Offset: 0x003CA32C
		public static IMarbleCommonItem GetRootAsIMarbleCommonItem(ByteBuffer _bb, IMarbleCommonItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A995 RID: 108949 RVA: 0x003CC149 File Offset: 0x003CA349
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A996 RID: 108950 RVA: 0x003CC158 File Offset: 0x003CA358
		public IMarbleCommonItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D75 RID: 32117
		// (get) Token: 0x0601A997 RID: 108951 RVA: 0x003CC168 File Offset: 0x003CA368
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

		// Token: 0x17007D76 RID: 32118
		// (get) Token: 0x0601A998 RID: 108952 RVA: 0x003CC1A4 File Offset: 0x003CA3A4
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

		// Token: 0x17007D77 RID: 32119
		// (get) Token: 0x0601A999 RID: 108953 RVA: 0x003CC1E0 File Offset: 0x003CA3E0
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

		// Token: 0x17007D78 RID: 32120
		// (get) Token: 0x0601A99A RID: 108954 RVA: 0x003CC240 File Offset: 0x003CA440
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

		// Token: 0x17007D79 RID: 32121
		// (get) Token: 0x0601A99B RID: 108955 RVA: 0x003CC280 File Offset: 0x003CA480
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

		// Token: 0x17007D7A RID: 32122
		// (get) Token: 0x0601A99C RID: 108956 RVA: 0x003CC2C0 File Offset: 0x003CA4C0
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

		// Token: 0x17007D7B RID: 32123
		// (get) Token: 0x0601A99D RID: 108957 RVA: 0x003CC300 File Offset: 0x003CA500
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

		// Token: 0x0601A99E RID: 108958 RVA: 0x003CC340 File Offset: 0x003CA540
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

		// Token: 0x0601A99F RID: 108959 RVA: 0x003CC38F File Offset: 0x003CA58F
		public static void StartIMarbleCommonItem(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601A9A0 RID: 108960 RVA: 0x003CC398 File Offset: 0x003CA598
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601A9A1 RID: 108961 RVA: 0x003CC3A3 File Offset: 0x003CA5A3
		public static void AddType(FlatBufferBuilder builder, ETwoDimensionLevelType type)
		{
			builder.AddByte(1, (byte)type, 0);
		}

		// Token: 0x0601A9A2 RID: 108962 RVA: 0x003CC3AE File Offset: 0x003CA5AE
		public static void AddTransform(FlatBufferBuilder builder, Offset<ITwoDimensionTransform> transformOffset)
		{
			builder.AddOffset(2, transformOffset.Value, 0);
		}

		// Token: 0x0601A9A3 RID: 108963 RVA: 0x003CC3BE File Offset: 0x003CA5BE
		public static void AddSubType(FlatBufferBuilder builder, EMarbleItemType subType)
		{
			builder.AddByte(3, (byte)subType, 0);
		}

		// Token: 0x0601A9A4 RID: 108964 RVA: 0x003CC3C9 File Offset: 0x003CA5C9
		public static void AddDataId(FlatBufferBuilder builder, int dataId)
		{
			builder.AddInt(4, dataId, 0);
		}

		// Token: 0x0601A9A5 RID: 108965 RVA: 0x003CC3D4 File Offset: 0x003CA5D4
		public static void AddAwakenWave(FlatBufferBuilder builder, int awakenWave)
		{
			builder.AddInt(5, awakenWave, 0);
		}

		// Token: 0x0601A9A6 RID: 108966 RVA: 0x003CC3DF File Offset: 0x003CA5DF
		public static void AddDestroyWave(FlatBufferBuilder builder, int destroyWave)
		{
			builder.AddInt(6, destroyWave, 0);
		}

		// Token: 0x0601A9A7 RID: 108967 RVA: 0x003CC3EA File Offset: 0x003CA5EA
		public static Offset<IMarbleCommonItem> EndIMarbleCommonItem(FlatBufferBuilder builder)
		{
			return new Offset<IMarbleCommonItem>(builder.EndTable());
		}

		// Token: 0x0601A9A8 RID: 108968 RVA: 0x003CC3F8 File Offset: 0x003CA5F8
		public IMarbleCommonItemT UnPack()
		{
			IMarbleCommonItemT marbleCommonItemT = new IMarbleCommonItemT();
			this.UnPackTo(marbleCommonItemT);
			return marbleCommonItemT;
		}

		// Token: 0x0601A9A9 RID: 108969 RVA: 0x003CC414 File Offset: 0x003CA614
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

		// Token: 0x0601A9AA RID: 108970 RVA: 0x003CC498 File Offset: 0x003CA698
		public static Offset<IMarbleCommonItem> Pack(FlatBufferBuilder builder, IMarbleCommonItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMarbleCommonItem>);
			}
			Offset<ITwoDimensionTransform> transformOffset = (_o.Transform == null) ? default(Offset<ITwoDimensionTransform>) : ITwoDimensionTransform.Pack(builder, _o.Transform);
			return IMarbleCommonItem.CreateIMarbleCommonItem(builder, _o.Id, _o.Type, transformOffset, _o.SubType, _o.DataId, _o.AwakenWave, _o.DestroyWave);
		}

		// Token: 0x0400C59C RID: 50588
		private Table __p;
	}
}
