using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007115 RID: 28949
	public struct ILiveParamConfig : IFlatbufferObject
	{
		// Token: 0x1700D409 RID: 54281
		// (get) Token: 0x060324A3 RID: 205987 RVA: 0x006CCE93 File Offset: 0x006CB093
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060324A4 RID: 205988 RVA: 0x006CCEA0 File Offset: 0x006CB0A0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060324A5 RID: 205989 RVA: 0x006CCEA8 File Offset: 0x006CB0A8
		public static ILiveParamConfig GetRootAsILiveParamConfig(ByteBuffer _bb)
		{
			return ILiveParamConfig.GetRootAsILiveParamConfig(_bb, default(ILiveParamConfig));
		}

		// Token: 0x060324A6 RID: 205990 RVA: 0x006CCEC4 File Offset: 0x006CB0C4
		public static ILiveParamConfig GetRootAsILiveParamConfig(ByteBuffer _bb, ILiveParamConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060324A7 RID: 205991 RVA: 0x006CCEE1 File Offset: 0x006CB0E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060324A8 RID: 205992 RVA: 0x006CCEF0 File Offset: 0x006CB0F0
		public ILiveParamConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D40A RID: 54282
		// (get) Token: 0x060324A9 RID: 205993 RVA: 0x006CCF00 File Offset: 0x006CB100
		public ELiveParamType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELiveParamType.Heat;
				}
				return (ELiveParamType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060324AA RID: 205994 RVA: 0x006CCF3C File Offset: 0x006CB13C
		public static Offset<ILiveParamConfig> CreateILiveParamConfig(FlatBufferBuilder builder, ELiveParamType Type = ELiveParamType.Heat)
		{
			builder.StartTable(1);
			ILiveParamConfig.AddType(builder, Type);
			return ILiveParamConfig.EndILiveParamConfig(builder);
		}

		// Token: 0x060324AB RID: 205995 RVA: 0x006CCF52 File Offset: 0x006CB152
		public static void StartILiveParamConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060324AC RID: 205996 RVA: 0x006CCF5B File Offset: 0x006CB15B
		public static void AddType(FlatBufferBuilder builder, ELiveParamType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060324AD RID: 205997 RVA: 0x006CCF66 File Offset: 0x006CB166
		public static Offset<ILiveParamConfig> EndILiveParamConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILiveParamConfig>(builder.EndTable());
		}

		// Token: 0x060324AE RID: 205998 RVA: 0x006CCF74 File Offset: 0x006CB174
		public ILiveParamConfigT UnPack()
		{
			ILiveParamConfigT liveParamConfigT = new ILiveParamConfigT();
			this.UnPackTo(liveParamConfigT);
			return liveParamConfigT;
		}

		// Token: 0x060324AF RID: 205999 RVA: 0x006CCF8F File Offset: 0x006CB18F
		public void UnPackTo(ILiveParamConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060324B0 RID: 206000 RVA: 0x006CCFA0 File Offset: 0x006CB1A0
		public static Offset<ILiveParamConfig> Pack(FlatBufferBuilder builder, ILiveParamConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiveParamConfig>);
			}
			return ILiveParamConfig.CreateILiveParamConfig(builder, _o.Type);
		}

		// Token: 0x040120F4 RID: 73972
		private Table __p;
	}
}
