using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B63 RID: 2915
	[NetMessage(EMessageId.NormalMonsterManualInfoResponse)]
	public sealed class NormalMonsterManualInfoResponse : IMessage<NormalMonsterManualInfoResponse>, IMessage, IEquatable<NormalMonsterManualInfoResponse>, IDeepCloneable<NormalMonsterManualInfoResponse>, IBufferMessage
	{
		// Token: 0x0600FC8E RID: 64654 RVA: 0x0024C5B5 File Offset: 0x0024A7B5
		[NullableContext(1)]
		public static NormalMonsterManualInfoResponse Create()
		{
			return new NormalMonsterManualInfoResponse();
		}

		// Token: 0x1700337A RID: 13178
		// (get) Token: 0x0600FC8F RID: 64655 RVA: 0x0024C5BC File Offset: 0x0024A7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700337B RID: 13179
		// (get) Token: 0x0600FC90 RID: 64656 RVA: 0x0024C5BF File Offset: 0x0024A7BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NormalMonsterManualInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600FC91 RID: 64657 RVA: 0x0024C5C6 File Offset: 0x0024A7C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalMonsterManualInfoResponse()
		{
		}

		// Token: 0x0600FC92 RID: 64658 RVA: 0x0024C5D9 File Offset: 0x0024A7D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalMonsterManualInfoResponse(NormalMonsterManualInfoResponse other) : this()
		{
			this.code_ = other.code_;
			this.detectionTarget_ = other.detectionTarget_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FC93 RID: 64659 RVA: 0x0024C60F File Offset: 0x0024A80F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalMonsterManualInfoResponse Clone()
		{
			return new NormalMonsterManualInfoResponse(this);
		}

		// Token: 0x1700337C RID: 13180
		// (get) Token: 0x0600FC94 RID: 64660 RVA: 0x0024C617 File Offset: 0x0024A817
		// (set) Token: 0x0600FC95 RID: 64661 RVA: 0x0024C61F File Offset: 0x0024A81F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x1700337D RID: 13181
		// (get) Token: 0x0600FC96 RID: 64662 RVA: 0x0024C628 File Offset: 0x0024A828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DetectionTarget> DetectionTarget
		{
			get
			{
				return this.detectionTarget_;
			}
		}

		// Token: 0x0600FC97 RID: 64663 RVA: 0x0024C630 File Offset: 0x0024A830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NormalMonsterManualInfoResponse);
		}

		// Token: 0x0600FC98 RID: 64664 RVA: 0x0024C640 File Offset: 0x0024A840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NormalMonsterManualInfoResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.detectionTarget_.Equals(other.detectionTarget_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FC99 RID: 64665 RVA: 0x0024C690 File Offset: 0x0024A890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			num ^= this.detectionTarget_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FC9A RID: 64666 RVA: 0x0024C6E3 File Offset: 0x0024A8E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FC9B RID: 64667 RVA: 0x0024C6F0 File Offset: 0x0024A8F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FC9C RID: 64668 RVA: 0x0024C6FC File Offset: 0x0024A8FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Code);
			}
			this.detectionTarget_.WriteTo(ref output, NormalMonsterManualInfoResponse._repeated_detectionTarget_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FC9D RID: 64669 RVA: 0x0024C74C File Offset: 0x0024A94C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			num += this.detectionTarget_.CalculateSize(NormalMonsterManualInfoResponse._repeated_detectionTarget_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FC9E RID: 64670 RVA: 0x0024C7A0 File Offset: 0x0024A9A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NormalMonsterManualInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this.detectionTarget_.Add(other.detectionTarget_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FC9F RID: 64671 RVA: 0x0024C7ED File Offset: 0x0024A9ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FCA0 RID: 64672 RVA: 0x0024C7F8 File Offset: 0x0024A9F8
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
				if (num != 32U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.detectionTarget_.AddEntriesFrom(ref input, NormalMonsterManualInfoResponse._repeated_detectionTarget_codec);
					}
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040064C9 RID: 25801
		private UnknownFieldSet _unknownFields;

		// Token: 0x040064CA RID: 25802
		public const int CodeFieldNumber = 4;

		// Token: 0x040064CB RID: 25803
		private ErrorCode code_;

		// Token: 0x040064CC RID: 25804
		public const int DetectionTargetFieldNumber = 13;

		// Token: 0x040064CD RID: 25805
		private static readonly FieldCodec<DetectionTarget> _repeated_detectionTarget_codec = FieldCodec.ForMessage<DetectionTarget>(106U, Aki.Protocol.DetectionTarget.Parser);

		// Token: 0x040064CE RID: 25806
		private readonly RepeatedField<DetectionTarget> detectionTarget_ = new RepeatedField<DetectionTarget>();
	}
}
