using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004C9A RID: 19610
	public struct IBuffDurationPermanent : IFlatbufferObject
	{
		// Token: 0x17008AED RID: 35565
		// (get) Token: 0x0601E112 RID: 123154 RVA: 0x00436B81 File Offset: 0x00434D81
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E113 RID: 123155 RVA: 0x00436B8E File Offset: 0x00434D8E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E114 RID: 123156 RVA: 0x00436B98 File Offset: 0x00434D98
		public static IBuffDurationPermanent GetRootAsIBuffDurationPermanent(ByteBuffer _bb)
		{
			return IBuffDurationPermanent.GetRootAsIBuffDurationPermanent(_bb, default(IBuffDurationPermanent));
		}

		// Token: 0x0601E115 RID: 123157 RVA: 0x00436BB4 File Offset: 0x00434DB4
		public static IBuffDurationPermanent GetRootAsIBuffDurationPermanent(ByteBuffer _bb, IBuffDurationPermanent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E116 RID: 123158 RVA: 0x00436BD1 File Offset: 0x00434DD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E117 RID: 123159 RVA: 0x00436BE0 File Offset: 0x00434DE0
		public IBuffDurationPermanent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008AEE RID: 35566
		// (get) Token: 0x0601E118 RID: 123160 RVA: 0x00436BF0 File Offset: 0x00434DF0
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

		// Token: 0x0601E119 RID: 123161 RVA: 0x00436C2C File Offset: 0x00434E2C
		public static Offset<IBuffDurationPermanent> CreateIBuffDurationPermanent(FlatBufferBuilder builder, EBuffDurationType Type = EBuffDurationType.Instant)
		{
			builder.StartTable(1);
			IBuffDurationPermanent.AddType(builder, Type);
			return IBuffDurationPermanent.EndIBuffDurationPermanent(builder);
		}

		// Token: 0x0601E11A RID: 123162 RVA: 0x00436C42 File Offset: 0x00434E42
		public static void StartIBuffDurationPermanent(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601E11B RID: 123163 RVA: 0x00436C4B File Offset: 0x00434E4B
		public static void AddType(FlatBufferBuilder builder, EBuffDurationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E11C RID: 123164 RVA: 0x00436C56 File Offset: 0x00434E56
		public static Offset<IBuffDurationPermanent> EndIBuffDurationPermanent(FlatBufferBuilder builder)
		{
			return new Offset<IBuffDurationPermanent>(builder.EndTable());
		}

		// Token: 0x0601E11D RID: 123165 RVA: 0x00436C64 File Offset: 0x00434E64
		public IBuffDurationPermanentT UnPack()
		{
			IBuffDurationPermanentT buffDurationPermanentT = new IBuffDurationPermanentT();
			this.UnPackTo(buffDurationPermanentT);
			return buffDurationPermanentT;
		}

		// Token: 0x0601E11E RID: 123166 RVA: 0x00436C7F File Offset: 0x00434E7F
		public void UnPackTo(IBuffDurationPermanentT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601E11F RID: 123167 RVA: 0x00436C90 File Offset: 0x00434E90
		public static Offset<IBuffDurationPermanent> Pack(FlatBufferBuilder builder, IBuffDurationPermanentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBuffDurationPermanent>);
			}
			return IBuffDurationPermanent.CreateIBuffDurationPermanent(builder, _o.Type);
		}

		// Token: 0x0400D799 RID: 55193
		private Table __p;
	}
}
