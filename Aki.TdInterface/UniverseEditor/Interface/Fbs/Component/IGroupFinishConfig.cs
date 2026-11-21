using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058D3 RID: 22739
	public struct IGroupFinishConfig : IFlatbufferObject
	{
		// Token: 0x1700A4EA RID: 42218
		// (get) Token: 0x06024EDA RID: 151258 RVA: 0x0051209E File Offset: 0x0051029E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024EDB RID: 151259 RVA: 0x005120AB File Offset: 0x005102AB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024EDC RID: 151260 RVA: 0x005120B4 File Offset: 0x005102B4
		public static IGroupFinishConfig GetRootAsIGroupFinishConfig(ByteBuffer _bb)
		{
			return IGroupFinishConfig.GetRootAsIGroupFinishConfig(_bb, default(IGroupFinishConfig));
		}

		// Token: 0x06024EDD RID: 151261 RVA: 0x005120D0 File Offset: 0x005102D0
		public static IGroupFinishConfig GetRootAsIGroupFinishConfig(ByteBuffer _bb, IGroupFinishConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024EDE RID: 151262 RVA: 0x005120ED File Offset: 0x005102ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024EDF RID: 151263 RVA: 0x005120FC File Offset: 0x005102FC
		public IGroupFinishConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A4EB RID: 42219
		// (get) Token: 0x06024EE0 RID: 151264 RVA: 0x0051210C File Offset: 0x0051030C
		public EGroupFinishConfig Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGroupFinishConfig.Silence;
				}
				return (EGroupFinishConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024EE1 RID: 151265 RVA: 0x00512148 File Offset: 0x00510348
		public static Offset<IGroupFinishConfig> CreateIGroupFinishConfig(FlatBufferBuilder builder, EGroupFinishConfig Type = EGroupFinishConfig.Silence)
		{
			builder.StartTable(1);
			IGroupFinishConfig.AddType(builder, Type);
			return IGroupFinishConfig.EndIGroupFinishConfig(builder);
		}

		// Token: 0x06024EE2 RID: 151266 RVA: 0x0051215E File Offset: 0x0051035E
		public static void StartIGroupFinishConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06024EE3 RID: 151267 RVA: 0x00512167 File Offset: 0x00510367
		public static void AddType(FlatBufferBuilder builder, EGroupFinishConfig type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024EE4 RID: 151268 RVA: 0x00512172 File Offset: 0x00510372
		public static Offset<IGroupFinishConfig> EndIGroupFinishConfig(FlatBufferBuilder builder)
		{
			return new Offset<IGroupFinishConfig>(builder.EndTable());
		}

		// Token: 0x06024EE5 RID: 151269 RVA: 0x00512180 File Offset: 0x00510380
		public IGroupFinishConfigT UnPack()
		{
			IGroupFinishConfigT groupFinishConfigT = new IGroupFinishConfigT();
			this.UnPackTo(groupFinishConfigT);
			return groupFinishConfigT;
		}

		// Token: 0x06024EE6 RID: 151270 RVA: 0x0051219B File Offset: 0x0051039B
		public void UnPackTo(IGroupFinishConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06024EE7 RID: 151271 RVA: 0x005121AC File Offset: 0x005103AC
		public static Offset<IGroupFinishConfig> Pack(FlatBufferBuilder builder, IGroupFinishConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGroupFinishConfig>);
			}
			return IGroupFinishConfig.CreateIGroupFinishConfig(builder, _o.Type);
		}

		// Token: 0x0400F151 RID: 61777
		private Table __p;
	}
}
