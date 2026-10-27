using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200090E RID: 2318
	[NetMessage(EMessageId.LevelPlayStateResponse)]
	public sealed class LevelPlayStateResponse : IMessage<LevelPlayStateResponse>, IMessage, IEquatable<LevelPlayStateResponse>, IDeepCloneable<LevelPlayStateResponse>, IBufferMessage
	{
		// Token: 0x0600CCA8 RID: 52392 RVA: 0x001E2AF0 File Offset: 0x001E0CF0
		[NullableContext(1)]
		public static LevelPlayStateResponse Create()
		{
			return new LevelPlayStateResponse();
		}

		// Token: 0x17002955 RID: 10581
		// (get) Token: 0x0600CCA9 RID: 52393 RVA: 0x001E2AF7 File Offset: 0x001E0CF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002956 RID: 10582
		// (get) Token: 0x0600CCAA RID: 52394 RVA: 0x001E2AFA File Offset: 0x001E0CFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayStateResponse.Descriptor;
			}
		}

		// Token: 0x0600CCAB RID: 52395 RVA: 0x001E2B01 File Offset: 0x001E0D01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayStateResponse()
		{
		}

		// Token: 0x0600CCAC RID: 52396 RVA: 0x001E2B14 File Offset: 0x001E0D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayStateResponse(LevelPlayStateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.levelPlayStateDict_ = other.levelPlayStateDict_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CCAD RID: 52397 RVA: 0x001E2B4A File Offset: 0x001E0D4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayStateResponse Clone()
		{
			return new LevelPlayStateResponse(this);
		}

		// Token: 0x17002957 RID: 10583
		// (get) Token: 0x0600CCAE RID: 52398 RVA: 0x001E2B52 File Offset: 0x001E0D52
		// (set) Token: 0x0600CCAF RID: 52399 RVA: 0x001E2B5A File Offset: 0x001E0D5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17002958 RID: 10584
		// (get) Token: 0x0600CCB0 RID: 52400 RVA: 0x001E2B63 File Offset: 0x001E0D63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, LevelPlayStateMsg> LevelPlayStateDict
		{
			get
			{
				return this.levelPlayStateDict_;
			}
		}

		// Token: 0x0600CCB1 RID: 52401 RVA: 0x001E2B6B File Offset: 0x001E0D6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayStateResponse);
		}

		// Token: 0x0600CCB2 RID: 52402 RVA: 0x001E2B7C File Offset: 0x001E0D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayStateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.LevelPlayStateDict.Equals(other.LevelPlayStateDict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CCB3 RID: 52403 RVA: 0x001E2BCC File Offset: 0x001E0DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.LevelPlayStateDict.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CCB4 RID: 52404 RVA: 0x001E2C1F File Offset: 0x001E0E1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CCB5 RID: 52405 RVA: 0x001E2C2C File Offset: 0x001E0E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CCB6 RID: 52406 RVA: 0x001E2C38 File Offset: 0x001E0E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.levelPlayStateDict_.WriteTo(ref output, LevelPlayStateResponse._map_levelPlayStateDict_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CCB7 RID: 52407 RVA: 0x001E2C88 File Offset: 0x001E0E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.levelPlayStateDict_.CalculateSize(LevelPlayStateResponse._map_levelPlayStateDict_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CCB8 RID: 52408 RVA: 0x001E2CDC File Offset: 0x001E0EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayStateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.levelPlayStateDict_.MergeFrom(other.levelPlayStateDict_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CCB9 RID: 52409 RVA: 0x001E2D29 File Offset: 0x001E0F29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CCBA RID: 52410 RVA: 0x001E2D34 File Offset: 0x001E0F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 50U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.levelPlayStateDict_.AddEntriesFrom(ref input, LevelPlayStateResponse._map_levelPlayStateDict_codec);
				}
			}
		}

		// Token: 0x040056C0 RID: 22208
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056C1 RID: 22209
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x040056C2 RID: 22210
		private ErrorCode errorCode_;

		// Token: 0x040056C3 RID: 22211
		public const int LevelPlayStateDictFieldNumber = 6;

		// Token: 0x040056C4 RID: 22212
		private static readonly MapField<int, LevelPlayStateMsg>.Codec _map_levelPlayStateDict_codec = new MapField<int, LevelPlayStateMsg>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<LevelPlayStateMsg>(18U, LevelPlayStateMsg.Parser), 50U);

		// Token: 0x040056C5 RID: 22213
		private readonly MapField<int, LevelPlayStateMsg> levelPlayStateDict_ = new MapField<int, LevelPlayStateMsg>();
	}
}
