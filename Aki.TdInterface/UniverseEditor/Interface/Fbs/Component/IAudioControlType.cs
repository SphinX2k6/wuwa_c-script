using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004ECB RID: 20171
	public struct IAudioControlType : IFlatbufferObject
	{
		// Token: 0x170090D0 RID: 37072
		// (get) Token: 0x0601FCA3 RID: 130211 RVA: 0x0046CD49 File Offset: 0x0046AF49
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FCA4 RID: 130212 RVA: 0x0046CD56 File Offset: 0x0046AF56
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FCA5 RID: 130213 RVA: 0x0046CD60 File Offset: 0x0046AF60
		public static IAudioControlType GetRootAsIAudioControlType(ByteBuffer _bb)
		{
			return IAudioControlType.GetRootAsIAudioControlType(_bb, default(IAudioControlType));
		}

		// Token: 0x0601FCA6 RID: 130214 RVA: 0x0046CD7C File Offset: 0x0046AF7C
		public static IAudioControlType GetRootAsIAudioControlType(ByteBuffer _bb, IAudioControlType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FCA7 RID: 130215 RVA: 0x0046CD99 File Offset: 0x0046AF99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FCA8 RID: 130216 RVA: 0x0046CDA8 File Offset: 0x0046AFA8
		public IAudioControlType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170090D1 RID: 37073
		// (get) Token: 0x0601FCA9 RID: 130217 RVA: 0x0046CDB8 File Offset: 0x0046AFB8
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

		// Token: 0x0601FCAA RID: 130218 RVA: 0x0046CDF4 File Offset: 0x0046AFF4
		public static Offset<IAudioControlType> CreateIAudioControlType(FlatBufferBuilder builder, EAudioControlType Type = EAudioControlType.Gramophone)
		{
			builder.StartTable(1);
			IAudioControlType.AddType(builder, Type);
			return IAudioControlType.EndIAudioControlType(builder);
		}

		// Token: 0x0601FCAB RID: 130219 RVA: 0x0046CE0A File Offset: 0x0046B00A
		public static void StartIAudioControlType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601FCAC RID: 130220 RVA: 0x0046CE13 File Offset: 0x0046B013
		public static void AddType(FlatBufferBuilder builder, EAudioControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FCAD RID: 130221 RVA: 0x0046CE1E File Offset: 0x0046B01E
		public static Offset<IAudioControlType> EndIAudioControlType(FlatBufferBuilder builder)
		{
			return new Offset<IAudioControlType>(builder.EndTable());
		}

		// Token: 0x0601FCAE RID: 130222 RVA: 0x0046CE2C File Offset: 0x0046B02C
		public IAudioControlTypeT UnPack()
		{
			IAudioControlTypeT audioControlTypeT = new IAudioControlTypeT();
			this.UnPackTo(audioControlTypeT);
			return audioControlTypeT;
		}

		// Token: 0x0601FCAF RID: 130223 RVA: 0x0046CE47 File Offset: 0x0046B047
		public void UnPackTo(IAudioControlTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601FCB0 RID: 130224 RVA: 0x0046CE58 File Offset: 0x0046B058
		public static Offset<IAudioControlType> Pack(FlatBufferBuilder builder, IAudioControlTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAudioControlType>);
			}
			return IAudioControlType.CreateIAudioControlType(builder, _o.Type);
		}

		// Token: 0x0400DCD0 RID: 56528
		private Table __p;
	}
}
