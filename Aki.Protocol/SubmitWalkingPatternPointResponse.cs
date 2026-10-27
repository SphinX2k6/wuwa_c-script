using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012A8 RID: 4776
	[NetMessage(EMessageId.SubmitWalkingPatternPointResponse)]
	public sealed class SubmitWalkingPatternPointResponse : IMessage<SubmitWalkingPatternPointResponse>, IMessage, IEquatable<SubmitWalkingPatternPointResponse>, IDeepCloneable<SubmitWalkingPatternPointResponse>, IBufferMessage
	{
		// Token: 0x060196B6 RID: 104118 RVA: 0x003B1DCD File Offset: 0x003AFFCD
		[NullableContext(1)]
		public static SubmitWalkingPatternPointResponse Create()
		{
			return new SubmitWalkingPatternPointResponse();
		}

		// Token: 0x170055BA RID: 21946
		// (get) Token: 0x060196B7 RID: 104119 RVA: 0x003B1DD4 File Offset: 0x003AFFD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055BB RID: 21947
		// (get) Token: 0x060196B8 RID: 104120 RVA: 0x003B1DD7 File Offset: 0x003AFFD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubmitWalkingPatternPointResponse.Descriptor;
			}
		}

		// Token: 0x060196B9 RID: 104121 RVA: 0x003B1DDE File Offset: 0x003AFFDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitWalkingPatternPointResponse()
		{
		}

		// Token: 0x060196BA RID: 104122 RVA: 0x003B1DE6 File Offset: 0x003AFFE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitWalkingPatternPointResponse(SubmitWalkingPatternPointResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060196BB RID: 104123 RVA: 0x003B1E0B File Offset: 0x003B000B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitWalkingPatternPointResponse Clone()
		{
			return new SubmitWalkingPatternPointResponse(this);
		}

		// Token: 0x170055BC RID: 21948
		// (get) Token: 0x060196BC RID: 104124 RVA: 0x003B1E13 File Offset: 0x003B0013
		// (set) Token: 0x060196BD RID: 104125 RVA: 0x003B1E1B File Offset: 0x003B001B
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

		// Token: 0x060196BE RID: 104126 RVA: 0x003B1E24 File Offset: 0x003B0024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubmitWalkingPatternPointResponse);
		}

		// Token: 0x060196BF RID: 104127 RVA: 0x003B1E32 File Offset: 0x003B0032
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SubmitWalkingPatternPointResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060196C0 RID: 104128 RVA: 0x003B1E60 File Offset: 0x003B0060
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

		// Token: 0x060196C1 RID: 104129 RVA: 0x003B1EA5 File Offset: 0x003B00A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060196C2 RID: 104130 RVA: 0x003B1EB2 File Offset: 0x003B00B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060196C3 RID: 104131 RVA: 0x003B1EBB File Offset: 0x003B00BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060196C4 RID: 104132 RVA: 0x003B1EF0 File Offset: 0x003B00F0
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

		// Token: 0x060196C5 RID: 104133 RVA: 0x003B1F2E File Offset: 0x003B012E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SubmitWalkingPatternPointResponse other)
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

		// Token: 0x060196C6 RID: 104134 RVA: 0x003B1F5F File Offset: 0x003B015F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060196C7 RID: 104135 RVA: 0x003B1F68 File Offset: 0x003B0168
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009541 RID: 38209
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009542 RID: 38210
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04009543 RID: 38211
		private ErrorCode errorCode_;
	}
}
