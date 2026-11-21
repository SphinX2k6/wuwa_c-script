using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004C91 RID: 19601
	public struct IBuffDurationBase : IFlatbufferObject
	{
		// Token: 0x17008AE5 RID: 35557
		// (get) Token: 0x0601E0DE RID: 123102 RVA: 0x00436708 File Offset: 0x00434908
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E0DF RID: 123103 RVA: 0x00436715 File Offset: 0x00434915
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E0E0 RID: 123104 RVA: 0x0043671C File Offset: 0x0043491C
		public static IBuffDurationBase GetRootAsIBuffDurationBase(ByteBuffer _bb)
		{
			return IBuffDurationBase.GetRootAsIBuffDurationBase(_bb, default(IBuffDurationBase));
		}

		// Token: 0x0601E0E1 RID: 123105 RVA: 0x00436738 File Offset: 0x00434938
		public static IBuffDurationBase GetRootAsIBuffDurationBase(ByteBuffer _bb, IBuffDurationBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E0E2 RID: 123106 RVA: 0x00436755 File Offset: 0x00434955
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E0E3 RID: 123107 RVA: 0x00436764 File Offset: 0x00434964
		public IBuffDurationBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008AE6 RID: 35558
		// (get) Token: 0x0601E0E4 RID: 123108 RVA: 0x00436774 File Offset: 0x00434974
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

		// Token: 0x0601E0E5 RID: 123109 RVA: 0x004367B0 File Offset: 0x004349B0
		public static Offset<IBuffDurationBase> CreateIBuffDurationBase(FlatBufferBuilder builder, EBuffDurationType Type = EBuffDurationType.Instant)
		{
			builder.StartTable(1);
			IBuffDurationBase.AddType(builder, Type);
			return IBuffDurationBase.EndIBuffDurationBase(builder);
		}

		// Token: 0x0601E0E6 RID: 123110 RVA: 0x004367C6 File Offset: 0x004349C6
		public static void StartIBuffDurationBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601E0E7 RID: 123111 RVA: 0x004367CF File Offset: 0x004349CF
		public static void AddType(FlatBufferBuilder builder, EBuffDurationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E0E8 RID: 123112 RVA: 0x004367DA File Offset: 0x004349DA
		public static Offset<IBuffDurationBase> EndIBuffDurationBase(FlatBufferBuilder builder)
		{
			return new Offset<IBuffDurationBase>(builder.EndTable());
		}

		// Token: 0x0601E0E9 RID: 123113 RVA: 0x004367E8 File Offset: 0x004349E8
		public IBuffDurationBaseT UnPack()
		{
			IBuffDurationBaseT buffDurationBaseT = new IBuffDurationBaseT();
			this.UnPackTo(buffDurationBaseT);
			return buffDurationBaseT;
		}

		// Token: 0x0601E0EA RID: 123114 RVA: 0x00436803 File Offset: 0x00434A03
		public void UnPackTo(IBuffDurationBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601E0EB RID: 123115 RVA: 0x00436814 File Offset: 0x00434A14
		public static Offset<IBuffDurationBase> Pack(FlatBufferBuilder builder, IBuffDurationBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBuffDurationBase>);
			}
			return IBuffDurationBase.CreateIBuffDurationBase(builder, _o.Type);
		}

		// Token: 0x0400D78D RID: 55181
		private Table __p;
	}
}
