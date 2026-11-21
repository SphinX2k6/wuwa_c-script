using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004C97 RID: 19607
	public struct IBuffDurationInstant : IFlatbufferObject
	{
		// Token: 0x17008AEA RID: 35562
		// (get) Token: 0x0601E100 RID: 123136 RVA: 0x00436A0A File Offset: 0x00434C0A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E101 RID: 123137 RVA: 0x00436A17 File Offset: 0x00434C17
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E102 RID: 123138 RVA: 0x00436A20 File Offset: 0x00434C20
		public static IBuffDurationInstant GetRootAsIBuffDurationInstant(ByteBuffer _bb)
		{
			return IBuffDurationInstant.GetRootAsIBuffDurationInstant(_bb, default(IBuffDurationInstant));
		}

		// Token: 0x0601E103 RID: 123139 RVA: 0x00436A3C File Offset: 0x00434C3C
		public static IBuffDurationInstant GetRootAsIBuffDurationInstant(ByteBuffer _bb, IBuffDurationInstant obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E104 RID: 123140 RVA: 0x00436A59 File Offset: 0x00434C59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E105 RID: 123141 RVA: 0x00436A68 File Offset: 0x00434C68
		public IBuffDurationInstant __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008AEB RID: 35563
		// (get) Token: 0x0601E106 RID: 123142 RVA: 0x00436A78 File Offset: 0x00434C78
		public EBuffDurationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBuffDurationType.Instant;
				}
				return (EBuffDurationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E107 RID: 123143 RVA: 0x00436AB4 File Offset: 0x00434CB4
		public static Offset<IBuffDurationInstant> CreateIBuffDurationInstant(FlatBufferBuilder builder, EBuffDurationType Type = EBuffDurationType.Instant)
		{
			builder.StartTable(1);
			IBuffDurationInstant.AddType(builder, Type);
			return IBuffDurationInstant.EndIBuffDurationInstant(builder);
		}

		// Token: 0x0601E108 RID: 123144 RVA: 0x00436ACA File Offset: 0x00434CCA
		public static void StartIBuffDurationInstant(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601E109 RID: 123145 RVA: 0x00436AD3 File Offset: 0x00434CD3
		public static void AddType(FlatBufferBuilder builder, EBuffDurationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E10A RID: 123146 RVA: 0x00436ADE File Offset: 0x00434CDE
		public static Offset<IBuffDurationInstant> EndIBuffDurationInstant(FlatBufferBuilder builder)
		{
			return new Offset<IBuffDurationInstant>(builder.EndTable());
		}

		// Token: 0x0601E10B RID: 123147 RVA: 0x00436AEC File Offset: 0x00434CEC
		public IBuffDurationInstantT UnPack()
		{
			IBuffDurationInstantT buffDurationInstantT = new IBuffDurationInstantT();
			this.UnPackTo(buffDurationInstantT);
			return buffDurationInstantT;
		}

		// Token: 0x0601E10C RID: 123148 RVA: 0x00436B07 File Offset: 0x00434D07
		public void UnPackTo(IBuffDurationInstantT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601E10D RID: 123149 RVA: 0x00436B18 File Offset: 0x00434D18
		public static Offset<IBuffDurationInstant> Pack(FlatBufferBuilder builder, IBuffDurationInstantT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBuffDurationInstant>);
			}
			return IBuffDurationInstant.CreateIBuffDurationInstant(builder, _o.Type);
		}

		// Token: 0x0400D797 RID: 55191
		private Table __p;
	}
}
