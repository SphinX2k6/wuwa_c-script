using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A3D RID: 23101
	public struct ITeleControlBaseCfg : IFlatbufferObject
	{
		// Token: 0x1700ADCB RID: 44491
		// (get) Token: 0x06027482 RID: 160898 RVA: 0x00567F4A File Offset: 0x0056614A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027483 RID: 160899 RVA: 0x00567F57 File Offset: 0x00566157
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027484 RID: 160900 RVA: 0x00567F60 File Offset: 0x00566160
		public static ITeleControlBaseCfg GetRootAsITeleControlBaseCfg(ByteBuffer _bb)
		{
			return ITeleControlBaseCfg.GetRootAsITeleControlBaseCfg(_bb, default(ITeleControlBaseCfg));
		}

		// Token: 0x06027485 RID: 160901 RVA: 0x00567F7C File Offset: 0x0056617C
		public static ITeleControlBaseCfg GetRootAsITeleControlBaseCfg(ByteBuffer _bb, ITeleControlBaseCfg obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027486 RID: 160902 RVA: 0x00567F99 File Offset: 0x00566199
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027487 RID: 160903 RVA: 0x00567FA8 File Offset: 0x005661A8
		public ITeleControlBaseCfg __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ADCC RID: 44492
		// (get) Token: 0x06027488 RID: 160904 RVA: 0x00567FB8 File Offset: 0x005661B8
		public string CommonConfig
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027489 RID: 160905 RVA: 0x00567FEF File Offset: 0x005661EF
		public Span<byte> GetCommonConfigBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602748A RID: 160906 RVA: 0x00567FFE File Offset: 0x005661FE
		public byte[] GetCommonConfigArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700ADCD RID: 44493
		// (get) Token: 0x0602748B RID: 160907 RVA: 0x0056800C File Offset: 0x0056620C
		public bool CanRotate
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700ADCE RID: 44494
		// (get) Token: 0x0602748C RID: 160908 RVA: 0x0056804C File Offset: 0x0056624C
		public bool InitialGravity
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700ADCF RID: 44495
		// (get) Token: 0x0602748D RID: 160909 RVA: 0x0056808C File Offset: 0x0056628C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602748E RID: 160910 RVA: 0x005680C9 File Offset: 0x005662C9
		public static Offset<ITeleControlBaseCfg> CreateITeleControlBaseCfg(FlatBufferBuilder builder, StringOffset CommonConfigOffset = default(StringOffset), bool CanRotate = false, bool InitialGravity = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			ITeleControlBaseCfg.AddCommonConfig(builder, CommonConfigOffset);
			ITeleControlBaseCfg.AddNullMask(builder, NullMask);
			ITeleControlBaseCfg.AddInitialGravity(builder, InitialGravity);
			ITeleControlBaseCfg.AddCanRotate(builder, CanRotate);
			return ITeleControlBaseCfg.EndITeleControlBaseCfg(builder);
		}

		// Token: 0x0602748F RID: 160911 RVA: 0x005680F5 File Offset: 0x005662F5
		public static void StartITeleControlBaseCfg(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06027490 RID: 160912 RVA: 0x005680FE File Offset: 0x005662FE
		public static void AddCommonConfig(FlatBufferBuilder builder, StringOffset commonConfigOffset)
		{
			builder.AddOffset(0, commonConfigOffset.Value, 0);
		}

		// Token: 0x06027491 RID: 160913 RVA: 0x0056810E File Offset: 0x0056630E
		public static void AddCanRotate(FlatBufferBuilder builder, bool canRotate)
		{
			builder.AddBool(1, canRotate, false);
		}

		// Token: 0x06027492 RID: 160914 RVA: 0x00568119 File Offset: 0x00566319
		public static void AddInitialGravity(FlatBufferBuilder builder, bool initialGravity)
		{
			builder.AddBool(2, initialGravity, false);
		}

		// Token: 0x06027493 RID: 160915 RVA: 0x00568124 File Offset: 0x00566324
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06027494 RID: 160916 RVA: 0x0056812F File Offset: 0x0056632F
		public static Offset<ITeleControlBaseCfg> EndITeleControlBaseCfg(FlatBufferBuilder builder)
		{
			return new Offset<ITeleControlBaseCfg>(builder.EndTable());
		}

		// Token: 0x06027495 RID: 160917 RVA: 0x0056813C File Offset: 0x0056633C
		public ITeleControlBaseCfgT UnPack()
		{
			ITeleControlBaseCfgT teleControlBaseCfgT = new ITeleControlBaseCfgT();
			this.UnPackTo(teleControlBaseCfgT);
			return teleControlBaseCfgT;
		}

		// Token: 0x06027496 RID: 160918 RVA: 0x00568157 File Offset: 0x00566357
		public void UnPackTo(ITeleControlBaseCfgT _o)
		{
			_o.CommonConfig = this.CommonConfig;
			_o.CanRotate = this.CanRotate;
			_o.InitialGravity = this.InitialGravity;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027497 RID: 160919 RVA: 0x0056818C File Offset: 0x0056638C
		public static Offset<ITeleControlBaseCfg> Pack(FlatBufferBuilder builder, ITeleControlBaseCfgT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleControlBaseCfg>);
			}
			StringOffset commonConfigOffset = (_o.CommonConfig == null) ? default(StringOffset) : builder.CreateString(_o.CommonConfig);
			return ITeleControlBaseCfg.CreateITeleControlBaseCfg(builder, commonConfigOffset, _o.CanRotate, _o.InitialGravity, _o.NullMask);
		}

		// Token: 0x0400F0B7 RID: 61623
		private Table __p;
	}
}
