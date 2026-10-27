using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E97 RID: 3735
	[NetMessage(EMessageId.ReadCardResponse)]
	public sealed class ReadCardResponse : IMessage<ReadCardResponse>, IMessage, IEquatable<ReadCardResponse>, IDeepCloneable<ReadCardResponse>, IBufferMessage
	{
		// Token: 0x060140DC RID: 82140 RVA: 0x002EB721 File Offset: 0x002E9921
		[NullableContext(1)]
		public static ReadCardResponse Create()
		{
			return new ReadCardResponse();
		}

		// Token: 0x170042B4 RID: 17076
		// (get) Token: 0x060140DD RID: 82141 RVA: 0x002EB728 File Offset: 0x002E9928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042B5 RID: 17077
		// (get) Token: 0x060140DE RID: 82142 RVA: 0x002EB72B File Offset: 0x002E992B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReadCardResponse.Descriptor;
			}
		}

		// Token: 0x060140DF RID: 82143 RVA: 0x002EB732 File Offset: 0x002E9932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReadCardResponse()
		{
		}

		// Token: 0x060140E0 RID: 82144 RVA: 0x002EB73A File Offset: 0x002E993A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReadCardResponse(ReadCardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060140E1 RID: 82145 RVA: 0x002EB75F File Offset: 0x002E995F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReadCardResponse Clone()
		{
			return new ReadCardResponse(this);
		}

		// Token: 0x170042B6 RID: 17078
		// (get) Token: 0x060140E2 RID: 82146 RVA: 0x002EB767 File Offset: 0x002E9967
		// (set) Token: 0x060140E3 RID: 82147 RVA: 0x002EB76F File Offset: 0x002E996F
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

		// Token: 0x060140E4 RID: 82148 RVA: 0x002EB778 File Offset: 0x002E9978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReadCardResponse);
		}

		// Token: 0x060140E5 RID: 82149 RVA: 0x002EB786 File Offset: 0x002E9986
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReadCardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060140E6 RID: 82150 RVA: 0x002EB7B4 File Offset: 0x002E99B4
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

		// Token: 0x060140E7 RID: 82151 RVA: 0x002EB7F9 File Offset: 0x002E99F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060140E8 RID: 82152 RVA: 0x002EB806 File Offset: 0x002E9A06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060140E9 RID: 82153 RVA: 0x002EB80F File Offset: 0x002E9A0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060140EA RID: 82154 RVA: 0x002EB844 File Offset: 0x002E9A44
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

		// Token: 0x060140EB RID: 82155 RVA: 0x002EB882 File Offset: 0x002E9A82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReadCardResponse other)
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

		// Token: 0x060140EC RID: 82156 RVA: 0x002EB8B3 File Offset: 0x002E9AB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060140ED RID: 82157 RVA: 0x002EB8BC File Offset: 0x002E9ABC
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007A57 RID: 31319
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A58 RID: 31320
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04007A59 RID: 31321
		private ErrorCode errorCode_;
	}
}
