using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200034D RID: 845
	[NetMessage(EMessageId.DangoBrawlEventSelectResponse)]
	public sealed class DangoBrawlEventSelectResponse : IMessage<DangoBrawlEventSelectResponse>, IMessage, IEquatable<DangoBrawlEventSelectResponse>, IDeepCloneable<DangoBrawlEventSelectResponse>, IBufferMessage
	{
		// Token: 0x060054B2 RID: 21682 RVA: 0x000CE929 File Offset: 0x000CCB29
		[NullableContext(1)]
		public static DangoBrawlEventSelectResponse Create()
		{
			return new DangoBrawlEventSelectResponse();
		}

		// Token: 0x17000F69 RID: 3945
		// (get) Token: 0x060054B3 RID: 21683 RVA: 0x000CE930 File Offset: 0x000CCB30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F6A RID: 3946
		// (get) Token: 0x060054B4 RID: 21684 RVA: 0x000CE933 File Offset: 0x000CCB33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlEventSelectResponse.Descriptor;
			}
		}

		// Token: 0x060054B5 RID: 21685 RVA: 0x000CE93A File Offset: 0x000CCB3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEventSelectResponse()
		{
		}

		// Token: 0x060054B6 RID: 21686 RVA: 0x000CE94D File Offset: 0x000CCB4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEventSelectResponse(DangoBrawlEventSelectResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.activeEventIds_ = other.activeEventIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060054B7 RID: 21687 RVA: 0x000CE983 File Offset: 0x000CCB83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEventSelectResponse Clone()
		{
			return new DangoBrawlEventSelectResponse(this);
		}

		// Token: 0x17000F6B RID: 3947
		// (get) Token: 0x060054B8 RID: 21688 RVA: 0x000CE98B File Offset: 0x000CCB8B
		// (set) Token: 0x060054B9 RID: 21689 RVA: 0x000CE993 File Offset: 0x000CCB93
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

		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x060054BA RID: 21690 RVA: 0x000CE99C File Offset: 0x000CCB9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ActiveEventIds
		{
			get
			{
				return this.activeEventIds_;
			}
		}

		// Token: 0x060054BB RID: 21691 RVA: 0x000CE9A4 File Offset: 0x000CCBA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlEventSelectResponse);
		}

		// Token: 0x060054BC RID: 21692 RVA: 0x000CE9B4 File Offset: 0x000CCBB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlEventSelectResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.activeEventIds_.Equals(other.activeEventIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060054BD RID: 21693 RVA: 0x000CEA04 File Offset: 0x000CCC04
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

		// Token: 0x060054BE RID: 21694 RVA: 0x000CEA57 File Offset: 0x000CCC57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060054BF RID: 21695 RVA: 0x000CEA64 File Offset: 0x000CCC64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060054C0 RID: 21696 RVA: 0x000CEA70 File Offset: 0x000CCC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.activeEventIds_.WriteTo(ref output, DangoBrawlEventSelectResponse._repeated_activeEventIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060054C1 RID: 21697 RVA: 0x000CEAC0 File Offset: 0x000CCCC0
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

		// Token: 0x060054C2 RID: 21698 RVA: 0x000CEB14 File Offset: 0x000CCD14
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

		// Token: 0x060054C3 RID: 21699 RVA: 0x000CEB61 File Offset: 0x000CCD61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060054C4 RID: 21700 RVA: 0x000CEB6C File Offset: 0x000CCD6C
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
				if (num != 48U)
				{
					if (num != 112U && num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.activeEventIds_.AddEntriesFrom(ref input, DangoBrawlEventSelectResponse._repeated_activeEventIds_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400342E RID: 13358
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400342F RID: 13359
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04003430 RID: 13360
		private ErrorCode errorCode_;

		// Token: 0x04003431 RID: 13361
		public const int ActiveEventIdsFieldNumber = 14;

		// Token: 0x04003432 RID: 13362
		private static readonly FieldCodec<int> _repeated_activeEventIds_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04003433 RID: 13363
		private readonly RepeatedField<int> activeEventIds_ = new RepeatedField<int>();
	}
}
