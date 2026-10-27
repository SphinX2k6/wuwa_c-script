using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200090A RID: 2314
	[NetMessage(EMessageId.LevelPlayStateListResponse)]
	public sealed class LevelPlayStateListResponse : IMessage<LevelPlayStateListResponse>, IMessage, IEquatable<LevelPlayStateListResponse>, IDeepCloneable<LevelPlayStateListResponse>, IBufferMessage
	{
		// Token: 0x0600CC48 RID: 52296 RVA: 0x001E1BA5 File Offset: 0x001DFDA5
		[NullableContext(1)]
		public static LevelPlayStateListResponse Create()
		{
			return new LevelPlayStateListResponse();
		}

		// Token: 0x1700293D RID: 10557
		// (get) Token: 0x0600CC49 RID: 52297 RVA: 0x001E1BAC File Offset: 0x001DFDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700293E RID: 10558
		// (get) Token: 0x0600CC4A RID: 52298 RVA: 0x001E1BAF File Offset: 0x001DFDAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayStateListResponse.Descriptor;
			}
		}

		// Token: 0x0600CC4B RID: 52299 RVA: 0x001E1BB6 File Offset: 0x001DFDB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayStateListResponse()
		{
		}

		// Token: 0x0600CC4C RID: 52300 RVA: 0x001E1BC9 File Offset: 0x001DFDC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayStateListResponse(LevelPlayStateListResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.instLevelPlayStateRsps_ = other.instLevelPlayStateRsps_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CC4D RID: 52301 RVA: 0x001E1BFF File Offset: 0x001DFDFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayStateListResponse Clone()
		{
			return new LevelPlayStateListResponse(this);
		}

		// Token: 0x1700293F RID: 10559
		// (get) Token: 0x0600CC4E RID: 52302 RVA: 0x001E1C07 File Offset: 0x001DFE07
		// (set) Token: 0x0600CC4F RID: 52303 RVA: 0x001E1C0F File Offset: 0x001DFE0F
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

		// Token: 0x17002940 RID: 10560
		// (get) Token: 0x0600CC50 RID: 52304 RVA: 0x001E1C18 File Offset: 0x001DFE18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<InstLevelPlayStateRsp> InstLevelPlayStateRsps
		{
			get
			{
				return this.instLevelPlayStateRsps_;
			}
		}

		// Token: 0x0600CC51 RID: 52305 RVA: 0x001E1C20 File Offset: 0x001DFE20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayStateListResponse);
		}

		// Token: 0x0600CC52 RID: 52306 RVA: 0x001E1C30 File Offset: 0x001DFE30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayStateListResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.instLevelPlayStateRsps_.Equals(other.instLevelPlayStateRsps_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CC53 RID: 52307 RVA: 0x001E1C80 File Offset: 0x001DFE80
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

		// Token: 0x0600CC54 RID: 52308 RVA: 0x001E1CD3 File Offset: 0x001DFED3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CC55 RID: 52309 RVA: 0x001E1CE0 File Offset: 0x001DFEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CC56 RID: 52310 RVA: 0x001E1CEC File Offset: 0x001DFEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.instLevelPlayStateRsps_.WriteTo(ref output, LevelPlayStateListResponse._repeated_instLevelPlayStateRsps_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CC57 RID: 52311 RVA: 0x001E1D3C File Offset: 0x001DFF3C
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

		// Token: 0x0600CC58 RID: 52312 RVA: 0x001E1D90 File Offset: 0x001DFF90
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

		// Token: 0x0600CC59 RID: 52313 RVA: 0x001E1DDD File Offset: 0x001DFFDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CC5A RID: 52314 RVA: 0x001E1DE8 File Offset: 0x001DFFE8
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
				if (num != 82U)
				{
					if (num != 104U)
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

		// Token: 0x0400569C RID: 22172
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400569D RID: 22173
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x0400569E RID: 22174
		private ErrorCode errorCode_;

		// Token: 0x0400569F RID: 22175
		public const int InstLevelPlayStateRspsFieldNumber = 10;

		// Token: 0x040056A0 RID: 22176
		private static readonly FieldCodec<InstLevelPlayStateRsp> _repeated_instLevelPlayStateRsps_codec = FieldCodec.ForMessage<InstLevelPlayStateRsp>(82U, InstLevelPlayStateRsp.Parser);

		// Token: 0x040056A1 RID: 22177
		private readonly RepeatedField<InstLevelPlayStateRsp> instLevelPlayStateRsps_ = new RepeatedField<InstLevelPlayStateRsp>();
	}
}
