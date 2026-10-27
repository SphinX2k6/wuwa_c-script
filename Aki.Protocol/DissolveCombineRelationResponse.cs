using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003E3 RID: 995
	[NetMessage(EMessageId.DissolveCombineRelationResponse)]
	public sealed class DissolveCombineRelationResponse : IMessage<DissolveCombineRelationResponse>, IMessage, IEquatable<DissolveCombineRelationResponse>, IDeepCloneable<DissolveCombineRelationResponse>, IBufferMessage
	{
		// Token: 0x060060B5 RID: 24757 RVA: 0x000E9BD0 File Offset: 0x000E7DD0
		[NullableContext(1)]
		public static DissolveCombineRelationResponse Create()
		{
			return new DissolveCombineRelationResponse();
		}

		// Token: 0x17001205 RID: 4613
		// (get) Token: 0x060060B6 RID: 24758 RVA: 0x000E9BD7 File Offset: 0x000E7DD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001206 RID: 4614
		// (get) Token: 0x060060B7 RID: 24759 RVA: 0x000E9BDA File Offset: 0x000E7DDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DissolveCombineRelationResponse.Descriptor;
			}
		}

		// Token: 0x060060B8 RID: 24760 RVA: 0x000E9BE1 File Offset: 0x000E7DE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DissolveCombineRelationResponse()
		{
		}

		// Token: 0x060060B9 RID: 24761 RVA: 0x000E9BE9 File Offset: 0x000E7DE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DissolveCombineRelationResponse(DissolveCombineRelationResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060060BA RID: 24762 RVA: 0x000E9C0E File Offset: 0x000E7E0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DissolveCombineRelationResponse Clone()
		{
			return new DissolveCombineRelationResponse(this);
		}

		// Token: 0x17001207 RID: 4615
		// (get) Token: 0x060060BB RID: 24763 RVA: 0x000E9C16 File Offset: 0x000E7E16
		// (set) Token: 0x060060BC RID: 24764 RVA: 0x000E9C1E File Offset: 0x000E7E1E
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

		// Token: 0x060060BD RID: 24765 RVA: 0x000E9C27 File Offset: 0x000E7E27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DissolveCombineRelationResponse);
		}

		// Token: 0x060060BE RID: 24766 RVA: 0x000E9C35 File Offset: 0x000E7E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DissolveCombineRelationResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060060BF RID: 24767 RVA: 0x000E9C64 File Offset: 0x000E7E64
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

		// Token: 0x060060C0 RID: 24768 RVA: 0x000E9CA9 File Offset: 0x000E7EA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060060C1 RID: 24769 RVA: 0x000E9CB6 File Offset: 0x000E7EB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060060C2 RID: 24770 RVA: 0x000E9CBF File Offset: 0x000E7EBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060060C3 RID: 24771 RVA: 0x000E9CF4 File Offset: 0x000E7EF4
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

		// Token: 0x060060C4 RID: 24772 RVA: 0x000E9D32 File Offset: 0x000E7F32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DissolveCombineRelationResponse other)
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

		// Token: 0x060060C5 RID: 24773 RVA: 0x000E9D63 File Offset: 0x000E7F63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060060C6 RID: 24774 RVA: 0x000E9D6C File Offset: 0x000E7F6C
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003772 RID: 14194
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003773 RID: 14195
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04003774 RID: 14196
		private ErrorCode errorCode_;
	}
}
