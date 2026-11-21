using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200536A RID: 21354
	public struct IAddBuffMode : IFlatbufferObject
	{
		// Token: 0x170096C6 RID: 38598
		// (get) Token: 0x06021419 RID: 136217 RVA: 0x00496E56 File Offset: 0x00495056
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602141A RID: 136218 RVA: 0x00496E63 File Offset: 0x00495063
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602141B RID: 136219 RVA: 0x00496E6C File Offset: 0x0049506C
		public static IAddBuffMode GetRootAsIAddBuffMode(ByteBuffer _bb)
		{
			return IAddBuffMode.GetRootAsIAddBuffMode(_bb, default(IAddBuffMode));
		}

		// Token: 0x0602141C RID: 136220 RVA: 0x00496E88 File Offset: 0x00495088
		public static IAddBuffMode GetRootAsIAddBuffMode(ByteBuffer _bb, IAddBuffMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602141D RID: 136221 RVA: 0x00496EA5 File Offset: 0x004950A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602141E RID: 136222 RVA: 0x00496EB4 File Offset: 0x004950B4
		public IAddBuffMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170096C7 RID: 38599
		// (get) Token: 0x0602141F RID: 136223 RVA: 0x00496EC4 File Offset: 0x004950C4
		public EBuffProducerMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBuffProducerMode.Immediate;
				}
				return (EBuffProducerMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021420 RID: 136224 RVA: 0x00496F00 File Offset: 0x00495100
		public static Offset<IAddBuffMode> CreateIAddBuffMode(FlatBufferBuilder builder, EBuffProducerMode Type = EBuffProducerMode.Immediate)
		{
			builder.StartTable(1);
			IAddBuffMode.AddType(builder, Type);
			return IAddBuffMode.EndIAddBuffMode(builder);
		}

		// Token: 0x06021421 RID: 136225 RVA: 0x00496F16 File Offset: 0x00495116
		public static void StartIAddBuffMode(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06021422 RID: 136226 RVA: 0x00496F1F File Offset: 0x0049511F
		public static void AddType(FlatBufferBuilder builder, EBuffProducerMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021423 RID: 136227 RVA: 0x00496F2A File Offset: 0x0049512A
		public static Offset<IAddBuffMode> EndIAddBuffMode(FlatBufferBuilder builder)
		{
			return new Offset<IAddBuffMode>(builder.EndTable());
		}

		// Token: 0x06021424 RID: 136228 RVA: 0x00496F38 File Offset: 0x00495138
		public IAddBuffModeT UnPack()
		{
			IAddBuffModeT addBuffModeT = new IAddBuffModeT();
			this.UnPackTo(addBuffModeT);
			return addBuffModeT;
		}

		// Token: 0x06021425 RID: 136229 RVA: 0x00496F53 File Offset: 0x00495153
		public void UnPackTo(IAddBuffModeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06021426 RID: 136230 RVA: 0x00496F64 File Offset: 0x00495164
		public static Offset<IAddBuffMode> Pack(FlatBufferBuilder builder, IAddBuffModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAddBuffMode>);
			}
			return IAddBuffMode.CreateIAddBuffMode(builder, _o.Type);
		}

		// Token: 0x0400E771 RID: 59249
		private Table __p;
	}
}
