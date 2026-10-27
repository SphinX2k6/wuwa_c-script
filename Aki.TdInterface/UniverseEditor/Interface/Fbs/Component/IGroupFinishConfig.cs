using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200534D RID: 21325
	public struct IGroupFinishConfig : IFlatbufferObject
	{
		// Token: 0x17009CB2 RID: 40114
		// (get) Token: 0x06022E26 RID: 142886 RVA: 0x004D51CA File Offset: 0x004D33CA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022E27 RID: 142887 RVA: 0x004D51D7 File Offset: 0x004D33D7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022E28 RID: 142888 RVA: 0x004D51E0 File Offset: 0x004D33E0
		public static IGroupFinishConfig GetRootAsIGroupFinishConfig(ByteBuffer _bb)
		{
			return IGroupFinishConfig.GetRootAsIGroupFinishConfig(_bb, default(IGroupFinishConfig));
		}

		// Token: 0x06022E29 RID: 142889 RVA: 0x004D51FC File Offset: 0x004D33FC
		public static IGroupFinishConfig GetRootAsIGroupFinishConfig(ByteBuffer _bb, IGroupFinishConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022E2A RID: 142890 RVA: 0x004D5219 File Offset: 0x004D3419
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022E2B RID: 142891 RVA: 0x004D5228 File Offset: 0x004D3428
		public IGroupFinishConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009CB3 RID: 40115
		// (get) Token: 0x06022E2C RID: 142892 RVA: 0x004D5238 File Offset: 0x004D3438
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

		// Token: 0x06022E2D RID: 142893 RVA: 0x004D5274 File Offset: 0x004D3474
		public static Offset<IGroupFinishConfig> CreateIGroupFinishConfig(FlatBufferBuilder builder, EGroupFinishConfig Type = EGroupFinishConfig.Silence)
		{
			builder.StartTable(1);
			IGroupFinishConfig.AddType(builder, Type);
			return IGroupFinishConfig.EndIGroupFinishConfig(builder);
		}

		// Token: 0x06022E2E RID: 142894 RVA: 0x004D528A File Offset: 0x004D348A
		public static void StartIGroupFinishConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06022E2F RID: 142895 RVA: 0x004D5293 File Offset: 0x004D3493
		public static void AddType(FlatBufferBuilder builder, EGroupFinishConfig type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022E30 RID: 142896 RVA: 0x004D529E File Offset: 0x004D349E
		public static Offset<IGroupFinishConfig> EndIGroupFinishConfig(FlatBufferBuilder builder)
		{
			return new Offset<IGroupFinishConfig>(builder.EndTable());
		}

		// Token: 0x06022E31 RID: 142897 RVA: 0x004D52AC File Offset: 0x004D34AC
		public IGroupFinishConfigT UnPack()
		{
			IGroupFinishConfigT groupFinishConfigT = new IGroupFinishConfigT();
			this.UnPackTo(groupFinishConfigT);
			return groupFinishConfigT;
		}

		// Token: 0x06022E32 RID: 142898 RVA: 0x004D52C7 File Offset: 0x004D34C7
		public void UnPackTo(IGroupFinishConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06022E33 RID: 142899 RVA: 0x004D52D8 File Offset: 0x004D34D8
		public static Offset<IGroupFinishConfig> Pack(FlatBufferBuilder builder, IGroupFinishConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGroupFinishConfig>);
			}
			return IGroupFinishConfig.CreateIGroupFinishConfig(builder, _o.Type);
		}

		// Token: 0x0400E521 RID: 58657
		private Table __p;
	}
}
