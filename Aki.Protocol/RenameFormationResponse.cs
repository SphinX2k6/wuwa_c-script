using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F04 RID: 3844
	[NetMessage(EMessageId.RenameFormationResponse)]
	public sealed class RenameFormationResponse : IMessage<RenameFormationResponse>, IMessage, IEquatable<RenameFormationResponse>, IDeepCloneable<RenameFormationResponse>, IBufferMessage
	{
		// Token: 0x060149BF RID: 84415 RVA: 0x002FE758 File Offset: 0x002FC958
		[NullableContext(1)]
		public static RenameFormationResponse Create()
		{
			return new RenameFormationResponse();
		}

		// Token: 0x17004487 RID: 17543
		// (get) Token: 0x060149C0 RID: 84416 RVA: 0x002FE75F File Offset: 0x002FC95F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004488 RID: 17544
		// (get) Token: 0x060149C1 RID: 84417 RVA: 0x002FE762 File Offset: 0x002FC962
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RenameFormationResponse.Descriptor;
			}
		}

		// Token: 0x060149C2 RID: 84418 RVA: 0x002FE769 File Offset: 0x002FC969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenameFormationResponse()
		{
		}

		// Token: 0x060149C3 RID: 84419 RVA: 0x002FE771 File Offset: 0x002FC971
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenameFormationResponse(RenameFormationResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060149C4 RID: 84420 RVA: 0x002FE796 File Offset: 0x002FC996
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenameFormationResponse Clone()
		{
			return new RenameFormationResponse(this);
		}

		// Token: 0x17004489 RID: 17545
		// (get) Token: 0x060149C5 RID: 84421 RVA: 0x002FE79E File Offset: 0x002FC99E
		// (set) Token: 0x060149C6 RID: 84422 RVA: 0x002FE7A6 File Offset: 0x002FC9A6
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

		// Token: 0x060149C7 RID: 84423 RVA: 0x002FE7AF File Offset: 0x002FC9AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RenameFormationResponse);
		}

		// Token: 0x060149C8 RID: 84424 RVA: 0x002FE7BD File Offset: 0x002FC9BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RenameFormationResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060149C9 RID: 84425 RVA: 0x002FE7EC File Offset: 0x002FC9EC
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

		// Token: 0x060149CA RID: 84426 RVA: 0x002FE831 File Offset: 0x002FCA31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060149CB RID: 84427 RVA: 0x002FE83E File Offset: 0x002FCA3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060149CC RID: 84428 RVA: 0x002FE847 File Offset: 0x002FCA47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060149CD RID: 84429 RVA: 0x002FE87C File Offset: 0x002FCA7C
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

		// Token: 0x060149CE RID: 84430 RVA: 0x002FE8BA File Offset: 0x002FCABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RenameFormationResponse other)
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

		// Token: 0x060149CF RID: 84431 RVA: 0x002FE8EB File Offset: 0x002FCAEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060149D0 RID: 84432 RVA: 0x002FE8F4 File Offset: 0x002FCAF4
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007D21 RID: 32033
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D22 RID: 32034
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04007D23 RID: 32035
		private ErrorCode errorCode_;
	}
}
