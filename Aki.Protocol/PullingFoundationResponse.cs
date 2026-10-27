using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DF8 RID: 3576
	[NetMessage(EMessageId.PullingFoundationResponse)]
	public sealed class PullingFoundationResponse : IMessage<PullingFoundationResponse>, IMessage, IEquatable<PullingFoundationResponse>, IDeepCloneable<PullingFoundationResponse>, IBufferMessage
	{
		// Token: 0x060133C5 RID: 78789 RVA: 0x002CD3D9 File Offset: 0x002CB5D9
		[NullableContext(1)]
		public static PullingFoundationResponse Create()
		{
			return new PullingFoundationResponse();
		}

		// Token: 0x17003FD6 RID: 16342
		// (get) Token: 0x060133C6 RID: 78790 RVA: 0x002CD3E0 File Offset: 0x002CB5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FD7 RID: 16343
		// (get) Token: 0x060133C7 RID: 78791 RVA: 0x002CD3E3 File Offset: 0x002CB5E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PullingFoundationResponse.Descriptor;
			}
		}

		// Token: 0x060133C8 RID: 78792 RVA: 0x002CD3EA File Offset: 0x002CB5EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PullingFoundationResponse()
		{
		}

		// Token: 0x060133C9 RID: 78793 RVA: 0x002CD3F2 File Offset: 0x002CB5F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PullingFoundationResponse(PullingFoundationResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060133CA RID: 78794 RVA: 0x002CD417 File Offset: 0x002CB617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PullingFoundationResponse Clone()
		{
			return new PullingFoundationResponse(this);
		}

		// Token: 0x17003FD8 RID: 16344
		// (get) Token: 0x060133CB RID: 78795 RVA: 0x002CD41F File Offset: 0x002CB61F
		// (set) Token: 0x060133CC RID: 78796 RVA: 0x002CD427 File Offset: 0x002CB627
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

		// Token: 0x060133CD RID: 78797 RVA: 0x002CD430 File Offset: 0x002CB630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PullingFoundationResponse);
		}

		// Token: 0x060133CE RID: 78798 RVA: 0x002CD43E File Offset: 0x002CB63E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PullingFoundationResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060133CF RID: 78799 RVA: 0x002CD46C File Offset: 0x002CB66C
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

		// Token: 0x060133D0 RID: 78800 RVA: 0x002CD4B1 File Offset: 0x002CB6B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060133D1 RID: 78801 RVA: 0x002CD4BE File Offset: 0x002CB6BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060133D2 RID: 78802 RVA: 0x002CD4C7 File Offset: 0x002CB6C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060133D3 RID: 78803 RVA: 0x002CD4FC File Offset: 0x002CB6FC
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

		// Token: 0x060133D4 RID: 78804 RVA: 0x002CD53A File Offset: 0x002CB73A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PullingFoundationResponse other)
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

		// Token: 0x060133D5 RID: 78805 RVA: 0x002CD56B File Offset: 0x002CB76B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060133D6 RID: 78806 RVA: 0x002CD574 File Offset: 0x002CB774
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007667 RID: 30311
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007668 RID: 30312
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04007669 RID: 30313
		private ErrorCode errorCode_;
	}
}
