using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007211 RID: 29201
	public struct ISubScreenModeConfig : IFlatbufferObject
	{
		// Token: 0x1700D8CB RID: 55499
		// (get) Token: 0x06033CB8 RID: 212152 RVA: 0x006F88C0 File Offset: 0x006F6AC0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033CB9 RID: 212153 RVA: 0x006F88CD File Offset: 0x006F6ACD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033CBA RID: 212154 RVA: 0x006F88D4 File Offset: 0x006F6AD4
		public static ISubScreenModeConfig GetRootAsISubScreenModeConfig(ByteBuffer _bb)
		{
			return ISubScreenModeConfig.GetRootAsISubScreenModeConfig(_bb, default(ISubScreenModeConfig));
		}

		// Token: 0x06033CBB RID: 212155 RVA: 0x006F88F0 File Offset: 0x006F6AF0
		public static ISubScreenModeConfig GetRootAsISubScreenModeConfig(ByteBuffer _bb, ISubScreenModeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033CBC RID: 212156 RVA: 0x006F890D File Offset: 0x006F6B0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033CBD RID: 212157 RVA: 0x006F891C File Offset: 0x006F6B1C
		public ISubScreenModeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D8CC RID: 55500
		// (get) Token: 0x06033CBE RID: 212158 RVA: 0x006F892C File Offset: 0x006F6B2C
		public ESubScreenOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESubScreenOperationType.Init;
				}
				return (ESubScreenOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033CBF RID: 212159 RVA: 0x006F8968 File Offset: 0x006F6B68
		public static Offset<ISubScreenModeConfig> CreateISubScreenModeConfig(FlatBufferBuilder builder, ESubScreenOperationType Type = ESubScreenOperationType.Init)
		{
			builder.StartTable(1);
			ISubScreenModeConfig.AddType(builder, Type);
			return ISubScreenModeConfig.EndISubScreenModeConfig(builder);
		}

		// Token: 0x06033CC0 RID: 212160 RVA: 0x006F897E File Offset: 0x006F6B7E
		public static void StartISubScreenModeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033CC1 RID: 212161 RVA: 0x006F8987 File Offset: 0x006F6B87
		public static void AddType(FlatBufferBuilder builder, ESubScreenOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033CC2 RID: 212162 RVA: 0x006F8992 File Offset: 0x006F6B92
		public static Offset<ISubScreenModeConfig> EndISubScreenModeConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISubScreenModeConfig>(builder.EndTable());
		}

		// Token: 0x06033CC3 RID: 212163 RVA: 0x006F89A0 File Offset: 0x006F6BA0
		public ISubScreenModeConfigT UnPack()
		{
			ISubScreenModeConfigT subScreenModeConfigT = new ISubScreenModeConfigT();
			this.UnPackTo(subScreenModeConfigT);
			return subScreenModeConfigT;
		}

		// Token: 0x06033CC4 RID: 212164 RVA: 0x006F89BB File Offset: 0x006F6BBB
		public void UnPackTo(ISubScreenModeConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033CC5 RID: 212165 RVA: 0x006F89CC File Offset: 0x006F6BCC
		public static Offset<ISubScreenModeConfig> Pack(FlatBufferBuilder builder, ISubScreenModeConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISubScreenModeConfig>);
			}
			return ISubScreenModeConfig.CreateISubScreenModeConfig(builder, _o.Type);
		}

		// Token: 0x04011CFC RID: 72956
		private Table __p;
	}
}
