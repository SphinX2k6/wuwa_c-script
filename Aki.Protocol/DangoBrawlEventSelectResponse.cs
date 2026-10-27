using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000345 RID: 837
	[NetMessage(EMessageId.DangoBrawlEventSelectResponse)]
	public sealed class DangoBrawlEventSelectResponse : IMessage<DangoBrawlEventSelectResponse>, IMessage, IEquatable<DangoBrawlEventSelectResponse>, IDeepCloneable<DangoBrawlEventSelectResponse>, IBufferMessage
	{
		// Token: 0x060053C5 RID: 21445 RVA: 0x000CC29D File Offset: 0x000CA49D
		[NullableContext(1)]
		public static DangoBrawlEventSelectResponse Create()
		{
			return new DangoBrawlEventSelectResponse();
		}

		// Token: 0x17000F38 RID: 3896
		// (get) Token: 0x060053C6 RID: 21446 RVA: 0x000CC2A4 File Offset: 0x000CA4A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F39 RID: 3897
		// (get) Token: 0x060053C7 RID: 21447 RVA: 0x000CC2A7 File Offset: 0x000CA4A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlEventSelectResponse.Descriptor;
			}
		}

		// Token: 0x060053C8 RID: 21448 RVA: 0x000CC2AE File Offset: 0x000CA4AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEventSelectResponse()
		{
		}

		// Token: 0x060053C9 RID: 21449 RVA: 0x000CC2C1 File Offset: 0x000CA4C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEventSelectResponse(DangoBrawlEventSelectResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.activeEventIds_ = other.activeEventIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060053CA RID: 21450 RVA: 0x000CC2F7 File Offset: 0x000CA4F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEventSelectResponse Clone()
		{
			return new DangoBrawlEventSelectResponse(this);
		}

		// Token: 0x17000F3A RID: 3898
		// (get) Token: 0x060053CB RID: 21451 RVA: 0x000CC2FF File Offset: 0x000CA4FF
		// (set) Token: 0x060053CC RID: 21452 RVA: 0x000CC307 File Offset: 0x000CA507
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

		// Token: 0x17000F3B RID: 3899
		// (get) Token: 0x060053CD RID: 21453 RVA: 0x000CC310 File Offset: 0x000CA510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ActiveEventIds
		{
			get
			{
				return this.activeEventIds_;
			}
		}

		// Token: 0x060053CE RID: 21454 RVA: 0x000CC318 File Offset: 0x000CA518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlEventSelectResponse);
		}

		// Token: 0x060053CF RID: 21455 RVA: 0x000CC328 File Offset: 0x000CA528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlEventSelectResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.activeEventIds_.Equals(other.activeEventIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060053D0 RID: 21456 RVA: 0x000CC378 File Offset: 0x000CA578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.activeEventIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060053D1 RID: 21457 RVA: 0x000CC3CB File Offset: 0x000CA5CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060053D2 RID: 21458 RVA: 0x000CC3D8 File Offset: 0x000CA5D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060053D3 RID: 21459 RVA: 0x000CC3E4 File Offset: 0x000CA5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.activeEventIds_.WriteTo(ref output, DangoBrawlEventSelectResponse._repeated_activeEventIds_codec);
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

		// Token: 0x060053D4 RID: 21460 RVA: 0x000CC434 File Offset: 0x000CA634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.activeEventIds_.CalculateSize(DangoBrawlEventSelectResponse._repeated_activeEventIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060053D5 RID: 21461 RVA: 0x000CC488 File Offset: 0x000CA688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlEventSelectResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.activeEventIds_.Add(other.activeEventIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060053D6 RID: 21462 RVA: 0x000CC4D5 File Offset: 0x000CA6D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060053D7 RID: 21463 RVA: 0x000CC4E0 File Offset: 0x000CA6E0
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
				if (num != 32U && num != 34U)
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
					this.activeEventIds_.AddEntriesFrom(ref input, DangoBrawlEventSelectResponse._repeated_activeEventIds_codec);
				}
			}
		}

		// Token: 0x04003392 RID: 13202
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003393 RID: 13203
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04003394 RID: 13204
		private ErrorCode errorCode_;

		// Token: 0x04003395 RID: 13205
		public const int ActiveEventIdsFieldNumber = 4;

		// Token: 0x04003396 RID: 13206
		private static readonly FieldCodec<int> _repeated_activeEventIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04003397 RID: 13207
		private readonly RepeatedField<int> activeEventIds_ = new RepeatedField<int>();
	}
}
