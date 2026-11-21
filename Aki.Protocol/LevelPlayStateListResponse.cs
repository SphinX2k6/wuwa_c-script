using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008F9 RID: 2297
	[NetMessage(EMessageId.LevelPlayStateListResponse)]
	public sealed class LevelPlayStateListResponse : IMessage<LevelPlayStateListResponse>, IMessage, IEquatable<LevelPlayStateListResponse>, IDeepCloneable<LevelPlayStateListResponse>, IBufferMessage
	{
		// Token: 0x0600CB2C RID: 52012 RVA: 0x001DF8CD File Offset: 0x001DDACD
		[NullableContext(1)]
		public static LevelPlayStateListResponse Create()
		{
			return new LevelPlayStateListResponse();
		}

		// Token: 0x170028FE RID: 10494
		// (get) Token: 0x0600CB2D RID: 52013 RVA: 0x001DF8D4 File Offset: 0x001DDAD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028FF RID: 10495
		// (get) Token: 0x0600CB2E RID: 52014 RVA: 0x001DF8D7 File Offset: 0x001DDAD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayStateListResponse.Descriptor;
			}
		}

		// Token: 0x0600CB2F RID: 52015 RVA: 0x001DF8DE File Offset: 0x001DDADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayStateListResponse()
		{
		}

		// Token: 0x0600CB30 RID: 52016 RVA: 0x001DF8F1 File Offset: 0x001DDAF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayStateListResponse(LevelPlayStateListResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.instLevelPlayStateRsps_ = other.instLevelPlayStateRsps_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CB31 RID: 52017 RVA: 0x001DF927 File Offset: 0x001DDB27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayStateListResponse Clone()
		{
			return new LevelPlayStateListResponse(this);
		}

		// Token: 0x17002900 RID: 10496
		// (get) Token: 0x0600CB32 RID: 52018 RVA: 0x001DF92F File Offset: 0x001DDB2F
		// (set) Token: 0x0600CB33 RID: 52019 RVA: 0x001DF937 File Offset: 0x001DDB37
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

		// Token: 0x17002901 RID: 10497
		// (get) Token: 0x0600CB34 RID: 52020 RVA: 0x001DF940 File Offset: 0x001DDB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<InstLevelPlayStateRsp> InstLevelPlayStateRsps
		{
			get
			{
				return this.instLevelPlayStateRsps_;
			}
		}

		// Token: 0x0600CB35 RID: 52021 RVA: 0x001DF948 File Offset: 0x001DDB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayStateListResponse);
		}

		// Token: 0x0600CB36 RID: 52022 RVA: 0x001DF958 File Offset: 0x001DDB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayStateListResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.instLevelPlayStateRsps_.Equals(other.instLevelPlayStateRsps_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CB37 RID: 52023 RVA: 0x001DF9A8 File Offset: 0x001DDBA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.instLevelPlayStateRsps_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CB38 RID: 52024 RVA: 0x001DF9FB File Offset: 0x001DDBFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CB39 RID: 52025 RVA: 0x001DFA08 File Offset: 0x001DDC08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CB3A RID: 52026 RVA: 0x001DFA14 File Offset: 0x001DDC14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.instLevelPlayStateRsps_.WriteTo(ref output, LevelPlayStateListResponse._repeated_instLevelPlayStateRsps_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CB3B RID: 52027 RVA: 0x001DFA64 File Offset: 0x001DDC64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.instLevelPlayStateRsps_.CalculateSize(LevelPlayStateListResponse._repeated_instLevelPlayStateRsps_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CB3C RID: 52028 RVA: 0x001DFAB8 File Offset: 0x001DDCB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayStateListResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.instLevelPlayStateRsps_.Add(other.instLevelPlayStateRsps_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CB3D RID: 52029 RVA: 0x001DFB05 File Offset: 0x001DDD05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CB3E RID: 52030 RVA: 0x001DFB10 File Offset: 0x001DDD10
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
				if (num != 18U)
				{
					if (num != 112U)
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
					this.instLevelPlayStateRsps_.AddEntriesFrom(ref input, LevelPlayStateListResponse._repeated_instLevelPlayStateRsps_codec);
				}
			}
		}

		// Token: 0x040056A3 RID: 22179
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056A4 RID: 22180
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x040056A5 RID: 22181
		private ErrorCode errorCode_;

		// Token: 0x040056A6 RID: 22182
		public const int InstLevelPlayStateRspsFieldNumber = 2;

		// Token: 0x040056A7 RID: 22183
		private static readonly FieldCodec<InstLevelPlayStateRsp> _repeated_instLevelPlayStateRsps_codec = FieldCodec.ForMessage<InstLevelPlayStateRsp>(18U, InstLevelPlayStateRsp.Parser);

		// Token: 0x040056A8 RID: 22184
		private readonly RepeatedField<InstLevelPlayStateRsp> instLevelPlayStateRsps_ = new RepeatedField<InstLevelPlayStateRsp>();
	}
}
