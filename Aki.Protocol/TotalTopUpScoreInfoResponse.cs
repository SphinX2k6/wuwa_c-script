using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001392 RID: 5010
	[NetMessage(EMessageId.TotalTopUpScoreInfoResponse)]
	public sealed class TotalTopUpScoreInfoResponse : IMessage<TotalTopUpScoreInfoResponse>, IMessage, IEquatable<TotalTopUpScoreInfoResponse>, IDeepCloneable<TotalTopUpScoreInfoResponse>, IBufferMessage
	{
		// Token: 0x0601A964 RID: 108900 RVA: 0x003DB6D9 File Offset: 0x003D98D9
		[NullableContext(1)]
		public static TotalTopUpScoreInfoResponse Create()
		{
			return new TotalTopUpScoreInfoResponse();
		}

		// Token: 0x170059A5 RID: 22949
		// (get) Token: 0x0601A965 RID: 108901 RVA: 0x003DB6E0 File Offset: 0x003D98E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059A6 RID: 22950
		// (get) Token: 0x0601A966 RID: 108902 RVA: 0x003DB6E3 File Offset: 0x003D98E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TotalTopUpScoreInfoResponse.Descriptor;
			}
		}

		// Token: 0x0601A967 RID: 108903 RVA: 0x003DB6EA File Offset: 0x003D98EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpScoreInfoResponse()
		{
		}

		// Token: 0x0601A968 RID: 108904 RVA: 0x003DB6FD File Offset: 0x003D98FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpScoreInfoResponse(TotalTopUpScoreInfoResponse other) : this()
		{
			this.infos_ = other.infos_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A969 RID: 108905 RVA: 0x003DB733 File Offset: 0x003D9933
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpScoreInfoResponse Clone()
		{
			return new TotalTopUpScoreInfoResponse(this);
		}

		// Token: 0x170059A7 RID: 22951
		// (get) Token: 0x0601A96A RID: 108906 RVA: 0x003DB73B File Offset: 0x003D993B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TotalTopUpScoreInfo> Infos
		{
			get
			{
				return this.infos_;
			}
		}

		// Token: 0x170059A8 RID: 22952
		// (get) Token: 0x0601A96B RID: 108907 RVA: 0x003DB743 File Offset: 0x003D9943
		// (set) Token: 0x0601A96C RID: 108908 RVA: 0x003DB74B File Offset: 0x003D994B
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

		// Token: 0x0601A96D RID: 108909 RVA: 0x003DB754 File Offset: 0x003D9954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TotalTopUpScoreInfoResponse);
		}

		// Token: 0x0601A96E RID: 108910 RVA: 0x003DB764 File Offset: 0x003D9964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TotalTopUpScoreInfoResponse other)
		{
			return other != null && (other == this || (this.infos_.Equals(other.infos_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A96F RID: 108911 RVA: 0x003DB7B4 File Offset: 0x003D99B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.infos_.GetHashCode();
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A970 RID: 108912 RVA: 0x003DB807 File Offset: 0x003D9A07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A971 RID: 108913 RVA: 0x003DB814 File Offset: 0x003D9A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A972 RID: 108914 RVA: 0x003DB820 File Offset: 0x003D9A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.infos_.WriteTo(ref output, TotalTopUpScoreInfoResponse._repeated_infos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A973 RID: 108915 RVA: 0x003DB870 File Offset: 0x003D9A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.infos_.CalculateSize(TotalTopUpScoreInfoResponse._repeated_infos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A974 RID: 108916 RVA: 0x003DB8C4 File Offset: 0x003D9AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TotalTopUpScoreInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.infos_.Add(other.infos_);
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A975 RID: 108917 RVA: 0x003DB911 File Offset: 0x003D9B11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A976 RID: 108918 RVA: 0x003DB91C File Offset: 0x003D9B1C
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
				if (num != 66U)
				{
					if (num != 72U)
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
					this.infos_.AddEntriesFrom(ref input, TotalTopUpScoreInfoResponse._repeated_infos_codec);
				}
			}
		}

		// Token: 0x04009A88 RID: 39560
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A89 RID: 39561
		public const int InfosFieldNumber = 8;

		// Token: 0x04009A8A RID: 39562
		private static readonly FieldCodec<TotalTopUpScoreInfo> _repeated_infos_codec = FieldCodec.ForMessage<TotalTopUpScoreInfo>(66U, TotalTopUpScoreInfo.Parser);

		// Token: 0x04009A8B RID: 39563
		private readonly RepeatedField<TotalTopUpScoreInfo> infos_ = new RepeatedField<TotalTopUpScoreInfo>();

		// Token: 0x04009A8C RID: 39564
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04009A8D RID: 39565
		private ErrorCode errorCode_;
	}
}
