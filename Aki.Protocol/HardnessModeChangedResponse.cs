using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200073E RID: 1854
	[NetMessage(EMessageId.HardnessModeChangedResponse)]
	public sealed class HardnessModeChangedResponse : IMessage<HardnessModeChangedResponse>, IMessage, IEquatable<HardnessModeChangedResponse>, IDeepCloneable<HardnessModeChangedResponse>, IBufferMessage
	{
		// Token: 0x0600A809 RID: 43017 RVA: 0x00194684 File Offset: 0x00192884
		[NullableContext(1)]
		public static HardnessModeChangedResponse Create()
		{
			return new HardnessModeChangedResponse();
		}

		// Token: 0x170021CA RID: 8650
		// (get) Token: 0x0600A80A RID: 43018 RVA: 0x0019468B File Offset: 0x0019288B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021CB RID: 8651
		// (get) Token: 0x0600A80B RID: 43019 RVA: 0x0019468E File Offset: 0x0019288E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HardnessModeChangedResponse.Descriptor;
			}
		}

		// Token: 0x0600A80C RID: 43020 RVA: 0x00194695 File Offset: 0x00192895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HardnessModeChangedResponse()
		{
		}

		// Token: 0x0600A80D RID: 43021 RVA: 0x0019469D File Offset: 0x0019289D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HardnessModeChangedResponse(HardnessModeChangedResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A80E RID: 43022 RVA: 0x001946C2 File Offset: 0x001928C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HardnessModeChangedResponse Clone()
		{
			return new HardnessModeChangedResponse(this);
		}

		// Token: 0x170021CC RID: 8652
		// (get) Token: 0x0600A80F RID: 43023 RVA: 0x001946CA File Offset: 0x001928CA
		// (set) Token: 0x0600A810 RID: 43024 RVA: 0x001946D2 File Offset: 0x001928D2
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

		// Token: 0x0600A811 RID: 43025 RVA: 0x001946DB File Offset: 0x001928DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HardnessModeChangedResponse);
		}

		// Token: 0x0600A812 RID: 43026 RVA: 0x001946E9 File Offset: 0x001928E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HardnessModeChangedResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A813 RID: 43027 RVA: 0x00194718 File Offset: 0x00192918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600A814 RID: 43028 RVA: 0x0019475D File Offset: 0x0019295D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A815 RID: 43029 RVA: 0x0019476A File Offset: 0x0019296A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A816 RID: 43030 RVA: 0x00194773 File Offset: 0x00192973
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
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

		// Token: 0x0600A817 RID: 43031 RVA: 0x001947A8 File Offset: 0x001929A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600A818 RID: 43032 RVA: 0x001947E6 File Offset: 0x001929E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HardnessModeChangedResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A819 RID: 43033 RVA: 0x00194817 File Offset: 0x00192A17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A81A RID: 43034 RVA: 0x00194820 File Offset: 0x00192A20
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004CBA RID: 19642
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CBB RID: 19643
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04004CBC RID: 19644
		private ErrorCode errorCode_;
	}
}
