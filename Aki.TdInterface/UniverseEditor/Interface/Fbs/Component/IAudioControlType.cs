using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053FA RID: 21498
	public struct IAudioControlType : IFlatbufferObject
	{
		// Token: 0x17009843 RID: 38979
		// (get) Token: 0x060219E7 RID: 137703 RVA: 0x004A2B19 File Offset: 0x004A0D19
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060219E8 RID: 137704 RVA: 0x004A2B26 File Offset: 0x004A0D26
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060219E9 RID: 137705 RVA: 0x004A2B30 File Offset: 0x004A0D30
		public static IAudioControlType GetRootAsIAudioControlType(ByteBuffer _bb)
		{
			return IAudioControlType.GetRootAsIAudioControlType(_bb, default(IAudioControlType));
		}

		// Token: 0x060219EA RID: 137706 RVA: 0x004A2B4C File Offset: 0x004A0D4C
		public static IAudioControlType GetRootAsIAudioControlType(ByteBuffer _bb, IAudioControlType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060219EB RID: 137707 RVA: 0x004A2B69 File Offset: 0x004A0D69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060219EC RID: 137708 RVA: 0x004A2B78 File Offset: 0x004A0D78
		public IAudioControlType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009844 RID: 38980
		// (get) Token: 0x060219ED RID: 137709 RVA: 0x004A2B88 File Offset: 0x004A0D88
		public EAudioControlType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAudioControlType.Gramophone;
				}
				return (EAudioControlType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060219EE RID: 137710 RVA: 0x004A2BC4 File Offset: 0x004A0DC4
		public static Offset<IAudioControlType> CreateIAudioControlType(FlatBufferBuilder builder, EAudioControlType Type = EAudioControlType.Gramophone)
		{
			builder.StartTable(1);
			IAudioControlType.AddType(builder, Type);
			return IAudioControlType.EndIAudioControlType(builder);
		}

		// Token: 0x060219EF RID: 137711 RVA: 0x004A2BDA File Offset: 0x004A0DDA
		public static void StartIAudioControlType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060219F0 RID: 137712 RVA: 0x004A2BE3 File Offset: 0x004A0DE3
		public static void AddType(FlatBufferBuilder builder, EAudioControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060219F1 RID: 137713 RVA: 0x004A2BEE File Offset: 0x004A0DEE
		public static Offset<IAudioControlType> EndIAudioControlType(FlatBufferBuilder builder)
		{
			return new Offset<IAudioControlType>(builder.EndTable());
		}

		// Token: 0x060219F2 RID: 137714 RVA: 0x004A2BFC File Offset: 0x004A0DFC
		public IAudioControlTypeT UnPack()
		{
			IAudioControlTypeT audioControlTypeT = new IAudioControlTypeT();
			this.UnPackTo(audioControlTypeT);
			return audioControlTypeT;
		}

		// Token: 0x060219F3 RID: 137715 RVA: 0x004A2C17 File Offset: 0x004A0E17
		public void UnPackTo(IAudioControlTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060219F4 RID: 137716 RVA: 0x004A2C28 File Offset: 0x004A0E28
		public static Offset<IAudioControlType> Pack(FlatBufferBuilder builder, IAudioControlTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAudioControlType>);
			}
			return IAudioControlType.CreateIAudioControlType(builder, _o.Type);
		}

		// Token: 0x0400E877 RID: 59511
		private Table __p;
	}
}
