using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045DB RID: 17883
	public struct ITwoDimensionItemBase : IFlatbufferObject
	{
		// Token: 0x17007F23 RID: 32547
		// (get) Token: 0x0601B111 RID: 110865 RVA: 0x003DB7D4 File Offset: 0x003D99D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B112 RID: 110866 RVA: 0x003DB7E1 File Offset: 0x003D99E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B113 RID: 110867 RVA: 0x003DB7E8 File Offset: 0x003D99E8
		public static ITwoDimensionItemBase GetRootAsITwoDimensionItemBase(ByteBuffer _bb)
		{
			return ITwoDimensionItemBase.GetRootAsITwoDimensionItemBase(_bb, default(ITwoDimensionItemBase));
		}

		// Token: 0x0601B114 RID: 110868 RVA: 0x003DB804 File Offset: 0x003D9A04
		public static ITwoDimensionItemBase GetRootAsITwoDimensionItemBase(ByteBuffer _bb, ITwoDimensionItemBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B115 RID: 110869 RVA: 0x003DB821 File Offset: 0x003D9A21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B116 RID: 110870 RVA: 0x003DB830 File Offset: 0x003D9A30
		public ITwoDimensionItemBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F24 RID: 32548
		// (get) Token: 0x0601B117 RID: 110871 RVA: 0x003DB840 File Offset: 0x003D9A40
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

		// Token: 0x17007F25 RID: 32549
		// (get) Token: 0x0601B118 RID: 110872 RVA: 0x003DB87C File Offset: 0x003D9A7C
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

		// Token: 0x17007F26 RID: 32550
		// (get) Token: 0x0601B119 RID: 110873 RVA: 0x003DB8B8 File Offset: 0x003D9AB8
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

		// Token: 0x0601B11A RID: 110874 RVA: 0x003DB915 File Offset: 0x003D9B15
		public static Offset<ITwoDimensionItemBase> CreateITwoDimensionItemBase(FlatBufferBuilder builder, int Id = 0, ETwoDimensionLevelType Type = ETwoDimensionLevelType.Marble, Offset<ITwoDimensionTransform> TransformOffset = default(Offset<ITwoDimensionTransform>))
		{
			builder.StartTable(3);
			ITwoDimensionItemBase.AddTransform(builder, TransformOffset);
			ITwoDimensionItemBase.AddId(builder, Id);
			ITwoDimensionItemBase.AddType(builder, Type);
			return ITwoDimensionItemBase.EndITwoDimensionItemBase(builder);
		}

		// Token: 0x0601B11B RID: 110875 RVA: 0x003DB939 File Offset: 0x003D9B39
		public static void StartITwoDimensionItemBase(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601B11C RID: 110876 RVA: 0x003DB942 File Offset: 0x003D9B42
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601B11D RID: 110877 RVA: 0x003DB94D File Offset: 0x003D9B4D
		public static void AddType(FlatBufferBuilder builder, ETwoDimensionLevelType type)
		{
			builder.AddByte(1, (byte)type, 0);
		}

		// Token: 0x0601B11E RID: 110878 RVA: 0x003DB958 File Offset: 0x003D9B58
		public static void AddTransform(FlatBufferBuilder builder, Offset<ITwoDimensionTransform> transformOffset)
		{
			builder.AddOffset(2, transformOffset.Value, 0);
		}

		// Token: 0x0601B11F RID: 110879 RVA: 0x003DB968 File Offset: 0x003D9B68
		public static Offset<ITwoDimensionItemBase> EndITwoDimensionItemBase(FlatBufferBuilder builder)
		{
			return new Offset<ITwoDimensionItemBase>(builder.EndTable());
		}

		// Token: 0x0601B120 RID: 110880 RVA: 0x003DB978 File Offset: 0x003D9B78
		public ITwoDimensionItemBaseT UnPack()
		{
			ITwoDimensionItemBaseT twoDimensionItemBaseT = new ITwoDimensionItemBaseT();
			this.UnPackTo(twoDimensionItemBaseT);
			return twoDimensionItemBaseT;
		}

		// Token: 0x0601B121 RID: 110881 RVA: 0x003DB994 File Offset: 0x003D9B94
		public void UnPackTo(ITwoDimensionItemBaseT _o)
		{
			_o.Id = this.Id;
			_o.Type = this.Type;
			_o.Transform = ((this.Transform != null) ? this.Transform.Value.UnPack() : null);
		}

		// Token: 0x0601B122 RID: 110882 RVA: 0x003DB9E8 File Offset: 0x003D9BE8
		public static Offset<ITwoDimensionItemBase> Pack(FlatBufferBuilder builder, ITwoDimensionItemBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITwoDimensionItemBase>);
			}
			Offset<ITwoDimensionTransform> transformOffset = (_o.Transform == null) ? default(Offset<ITwoDimensionTransform>) : ITwoDimensionTransform.Pack(builder, _o.Transform);
			return ITwoDimensionItemBase.CreateITwoDimensionItemBase(builder, _o.Id, _o.Type, transformOffset);
		}

		// Token: 0x0400C6B1 RID: 50865
		private Table __p;
	}
}
