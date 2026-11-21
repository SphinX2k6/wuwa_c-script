using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A43 RID: 19011
	public struct ITwoDimensionItemBase : IFlatbufferObject
	{
		// Token: 0x17008564 RID: 34148
		// (get) Token: 0x0601C8E6 RID: 116966 RVA: 0x00407A70 File Offset: 0x00405C70
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C8E7 RID: 116967 RVA: 0x00407A7D File Offset: 0x00405C7D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C8E8 RID: 116968 RVA: 0x00407A84 File Offset: 0x00405C84
		public static ITwoDimensionItemBase GetRootAsITwoDimensionItemBase(ByteBuffer _bb)
		{
			return ITwoDimensionItemBase.GetRootAsITwoDimensionItemBase(_bb, default(ITwoDimensionItemBase));
		}

		// Token: 0x0601C8E9 RID: 116969 RVA: 0x00407AA0 File Offset: 0x00405CA0
		public static ITwoDimensionItemBase GetRootAsITwoDimensionItemBase(ByteBuffer _bb, ITwoDimensionItemBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C8EA RID: 116970 RVA: 0x00407ABD File Offset: 0x00405CBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C8EB RID: 116971 RVA: 0x00407ACC File Offset: 0x00405CCC
		public ITwoDimensionItemBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008565 RID: 34149
		// (get) Token: 0x0601C8EC RID: 116972 RVA: 0x00407ADC File Offset: 0x00405CDC
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

		// Token: 0x17008566 RID: 34150
		// (get) Token: 0x0601C8ED RID: 116973 RVA: 0x00407B18 File Offset: 0x00405D18
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

		// Token: 0x17008567 RID: 34151
		// (get) Token: 0x0601C8EE RID: 116974 RVA: 0x00407B54 File Offset: 0x00405D54
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

		// Token: 0x0601C8EF RID: 116975 RVA: 0x00407BB1 File Offset: 0x00405DB1
		public static Offset<ITwoDimensionItemBase> CreateITwoDimensionItemBase(FlatBufferBuilder builder, int Id = 0, ETwoDimensionLevelType Type = ETwoDimensionLevelType.Marble, Offset<ITwoDimensionTransform> TransformOffset = default(Offset<ITwoDimensionTransform>))
		{
			builder.StartTable(3);
			ITwoDimensionItemBase.AddTransform(builder, TransformOffset);
			ITwoDimensionItemBase.AddId(builder, Id);
			ITwoDimensionItemBase.AddType(builder, Type);
			return ITwoDimensionItemBase.EndITwoDimensionItemBase(builder);
		}

		// Token: 0x0601C8F0 RID: 116976 RVA: 0x00407BD5 File Offset: 0x00405DD5
		public static void StartITwoDimensionItemBase(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601C8F1 RID: 116977 RVA: 0x00407BDE File Offset: 0x00405DDE
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601C8F2 RID: 116978 RVA: 0x00407BE9 File Offset: 0x00405DE9
		public static void AddType(FlatBufferBuilder builder, ETwoDimensionLevelType type)
		{
			builder.AddByte(1, (byte)type, 0);
		}

		// Token: 0x0601C8F3 RID: 116979 RVA: 0x00407BF4 File Offset: 0x00405DF4
		public static void AddTransform(FlatBufferBuilder builder, Offset<ITwoDimensionTransform> transformOffset)
		{
			builder.AddOffset(2, transformOffset.Value, 0);
		}

		// Token: 0x0601C8F4 RID: 116980 RVA: 0x00407C04 File Offset: 0x00405E04
		public static Offset<ITwoDimensionItemBase> EndITwoDimensionItemBase(FlatBufferBuilder builder)
		{
			return new Offset<ITwoDimensionItemBase>(builder.EndTable());
		}

		// Token: 0x0601C8F5 RID: 116981 RVA: 0x00407C14 File Offset: 0x00405E14
		public ITwoDimensionItemBaseT UnPack()
		{
			ITwoDimensionItemBaseT twoDimensionItemBaseT = new ITwoDimensionItemBaseT();
			this.UnPackTo(twoDimensionItemBaseT);
			return twoDimensionItemBaseT;
		}

		// Token: 0x0601C8F6 RID: 116982 RVA: 0x00407C30 File Offset: 0x00405E30
		public void UnPackTo(ITwoDimensionItemBaseT _o)
		{
			_o.Id = this.Id;
			_o.Type = this.Type;
			_o.Transform = ((this.Transform != null) ? this.Transform.Value.UnPack() : null);
		}

		// Token: 0x0601C8F7 RID: 116983 RVA: 0x00407C84 File Offset: 0x00405E84
		public static Offset<ITwoDimensionItemBase> Pack(FlatBufferBuilder builder, ITwoDimensionItemBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITwoDimensionItemBase>);
			}
			Offset<ITwoDimensionTransform> transformOffset = (_o.Transform == null) ? default(Offset<ITwoDimensionTransform>) : ITwoDimensionTransform.Pack(builder, _o.Transform);
			return ITwoDimensionItemBase.CreateITwoDimensionItemBase(builder, _o.Id, _o.Type, transformOffset);
		}

		// Token: 0x0400D0E0 RID: 53472
		private Table __p;
	}
}
