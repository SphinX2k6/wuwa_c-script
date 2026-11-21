using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AD6 RID: 31446
	public struct ITalkItemStyleInnerVoice : IFlatbufferObject
	{
		// Token: 0x1700E9BA RID: 59834
		// (get) Token: 0x060382F2 RID: 230130 RVA: 0x0078FB3D File Offset: 0x0078DD3D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060382F3 RID: 230131 RVA: 0x0078FB4A File Offset: 0x0078DD4A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060382F4 RID: 230132 RVA: 0x0078FB54 File Offset: 0x0078DD54
		public static ITalkItemStyleInnerVoice GetRootAsITalkItemStyleInnerVoice(ByteBuffer _bb)
		{
			return ITalkItemStyleInnerVoice.GetRootAsITalkItemStyleInnerVoice(_bb, default(ITalkItemStyleInnerVoice));
		}

		// Token: 0x060382F5 RID: 230133 RVA: 0x0078FB70 File Offset: 0x0078DD70
		public static ITalkItemStyleInnerVoice GetRootAsITalkItemStyleInnerVoice(ByteBuffer _bb, ITalkItemStyleInnerVoice obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060382F6 RID: 230134 RVA: 0x0078FB8D File Offset: 0x0078DD8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060382F7 RID: 230135 RVA: 0x0078FB9C File Offset: 0x0078DD9C
		public ITalkItemStyleInnerVoice __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E9BB RID: 59835
		// (get) Token: 0x060382F8 RID: 230136 RVA: 0x0078FBAC File Offset: 0x0078DDAC
		public ETalkItemStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETalkItemStyle.InnerVoice;
				}
				return (ETalkItemStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060382F9 RID: 230137 RVA: 0x0078FBE8 File Offset: 0x0078DDE8
		public static Offset<ITalkItemStyleInnerVoice> CreateITalkItemStyleInnerVoice(FlatBufferBuilder builder, ETalkItemStyle Type = ETalkItemStyle.InnerVoice)
		{
			builder.StartTable(1);
			ITalkItemStyleInnerVoice.AddType(builder, Type);
			return ITalkItemStyleInnerVoice.EndITalkItemStyleInnerVoice(builder);
		}

		// Token: 0x060382FA RID: 230138 RVA: 0x0078FBFE File Offset: 0x0078DDFE
		public static void StartITalkItemStyleInnerVoice(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060382FB RID: 230139 RVA: 0x0078FC07 File Offset: 0x0078DE07
		public static void AddType(FlatBufferBuilder builder, ETalkItemStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060382FC RID: 230140 RVA: 0x0078FC12 File Offset: 0x0078DE12
		public static Offset<ITalkItemStyleInnerVoice> EndITalkItemStyleInnerVoice(FlatBufferBuilder builder)
		{
			return new Offset<ITalkItemStyleInnerVoice>(builder.EndTable());
		}

		// Token: 0x060382FD RID: 230141 RVA: 0x0078FC20 File Offset: 0x0078DE20
		public ITalkItemStyleInnerVoiceT UnPack()
		{
			ITalkItemStyleInnerVoiceT talkItemStyleInnerVoiceT = new ITalkItemStyleInnerVoiceT();
			this.UnPackTo(talkItemStyleInnerVoiceT);
			return talkItemStyleInnerVoiceT;
		}

		// Token: 0x060382FE RID: 230142 RVA: 0x0078FC3B File Offset: 0x0078DE3B
		public void UnPackTo(ITalkItemStyleInnerVoiceT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060382FF RID: 230143 RVA: 0x0078FC4C File Offset: 0x0078DE4C
		public static Offset<ITalkItemStyleInnerVoice> Pack(FlatBufferBuilder builder, ITalkItemStyleInnerVoiceT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkItemStyleInnerVoice>);
			}
			return ITalkItemStyleInnerVoice.CreateITalkItemStyleInnerVoice(builder, _o.Type);
		}

		// Token: 0x04012FE1 RID: 77793
		private Table __p;
	}
}
