using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F1C RID: 3868
	[NetMessage(EMessageId.ReorderFormationResponse)]
	public sealed class ReorderFormationResponse : IMessage<ReorderFormationResponse>, IMessage, IEquatable<ReorderFormationResponse>, IDeepCloneable<ReorderFormationResponse>, IBufferMessage
	{
		// Token: 0x06014B3C RID: 84796 RVA: 0x00301034 File Offset: 0x002FF234
		[NullableContext(1)]
		public static ReorderFormationResponse Create()
		{
			return new ReorderFormationResponse();
		}

		// Token: 0x170044CD RID: 17613
		// (get) Token: 0x06014B3D RID: 84797 RVA: 0x0030103B File Offset: 0x002FF23B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044CE RID: 17614
		// (get) Token: 0x06014B3E RID: 84798 RVA: 0x0030103E File Offset: 0x002FF23E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReorderFormationResponse.Descriptor;
			}
		}

		// Token: 0x06014B3F RID: 84799 RVA: 0x00301045 File Offset: 0x002FF245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReorderFormationResponse()
		{
		}

		// Token: 0x06014B40 RID: 84800 RVA: 0x0030104D File Offset: 0x002FF24D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReorderFormationResponse(ReorderFormationResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014B41 RID: 84801 RVA: 0x00301072 File Offset: 0x002FF272
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReorderFormationResponse Clone()
		{
			return new ReorderFormationResponse(this);
		}

		// Token: 0x170044CF RID: 17615
		// (get) Token: 0x06014B42 RID: 84802 RVA: 0x0030107A File Offset: 0x002FF27A
		// (set) Token: 0x06014B43 RID: 84803 RVA: 0x00301082 File Offset: 0x002FF282
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

		// Token: 0x06014B44 RID: 84804 RVA: 0x0030108B File Offset: 0x002FF28B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReorderFormationResponse);
		}

		// Token: 0x06014B45 RID: 84805 RVA: 0x00301099 File Offset: 0x002FF299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReorderFormationResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014B46 RID: 84806 RVA: 0x003010C8 File Offset: 0x002FF2C8
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

		// Token: 0x06014B47 RID: 84807 RVA: 0x0030110D File Offset: 0x002FF30D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014B48 RID: 84808 RVA: 0x0030111A File Offset: 0x002FF31A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014B49 RID: 84809 RVA: 0x00301123 File Offset: 0x002FF323
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
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

		// Token: 0x06014B4A RID: 84810 RVA: 0x00301158 File Offset: 0x002FF358
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

		// Token: 0x06014B4B RID: 84811 RVA: 0x00301196 File Offset: 0x002FF396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReorderFormationResponse other)
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

		// Token: 0x06014B4C RID: 84812 RVA: 0x003011C7 File Offset: 0x002FF3C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014B4D RID: 84813 RVA: 0x003011D0 File Offset: 0x002FF3D0
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007D17 RID: 32023
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D18 RID: 32024
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04007D19 RID: 32025
		private ErrorCode errorCode_;
	}
}
