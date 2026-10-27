using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D08 RID: 3336
	[NetMessage(EMessageId.PhantomSkinChangeResponse)]
	public sealed class PhantomSkinChangeResponse : IMessage<PhantomSkinChangeResponse>, IMessage, IEquatable<PhantomSkinChangeResponse>, IDeepCloneable<PhantomSkinChangeResponse>, IBufferMessage
	{
		// Token: 0x06012073 RID: 73843 RVA: 0x002A29CF File Offset: 0x002A0BCF
		[NullableContext(1)]
		public static PhantomSkinChangeResponse Create()
		{
			return new PhantomSkinChangeResponse();
		}

		// Token: 0x17003BBB RID: 15291
		// (get) Token: 0x06012074 RID: 73844 RVA: 0x002A29D6 File Offset: 0x002A0BD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BBC RID: 15292
		// (get) Token: 0x06012075 RID: 73845 RVA: 0x002A29D9 File Offset: 0x002A0BD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomSkinChangeResponse.Descriptor;
			}
		}

		// Token: 0x06012076 RID: 73846 RVA: 0x002A29E0 File Offset: 0x002A0BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSkinChangeResponse()
		{
		}

		// Token: 0x06012077 RID: 73847 RVA: 0x002A29E8 File Offset: 0x002A0BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSkinChangeResponse(PhantomSkinChangeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012078 RID: 73848 RVA: 0x002A2A0D File Offset: 0x002A0C0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSkinChangeResponse Clone()
		{
			return new PhantomSkinChangeResponse(this);
		}

		// Token: 0x17003BBD RID: 15293
		// (get) Token: 0x06012079 RID: 73849 RVA: 0x002A2A15 File Offset: 0x002A0C15
		// (set) Token: 0x0601207A RID: 73850 RVA: 0x002A2A1D File Offset: 0x002A0C1D
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

		// Token: 0x0601207B RID: 73851 RVA: 0x002A2A26 File Offset: 0x002A0C26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomSkinChangeResponse);
		}

		// Token: 0x0601207C RID: 73852 RVA: 0x002A2A34 File Offset: 0x002A0C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomSkinChangeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601207D RID: 73853 RVA: 0x002A2A64 File Offset: 0x002A0C64
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

		// Token: 0x0601207E RID: 73854 RVA: 0x002A2AA9 File Offset: 0x002A0CA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601207F RID: 73855 RVA: 0x002A2AB6 File Offset: 0x002A0CB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012080 RID: 73856 RVA: 0x002A2ABF File Offset: 0x002A0CBF
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

		// Token: 0x06012081 RID: 73857 RVA: 0x002A2AF4 File Offset: 0x002A0CF4
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

		// Token: 0x06012082 RID: 73858 RVA: 0x002A2B32 File Offset: 0x002A0D32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomSkinChangeResponse other)
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

		// Token: 0x06012083 RID: 73859 RVA: 0x002A2B63 File Offset: 0x002A0D63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012084 RID: 73860 RVA: 0x002A2B6C File Offset: 0x002A0D6C
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

		// Token: 0x040070E3 RID: 28899
		private UnknownFieldSet _unknownFields;

		// Token: 0x040070E4 RID: 28900
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x040070E5 RID: 28901
		private ErrorCode errorCode_;
	}
}
