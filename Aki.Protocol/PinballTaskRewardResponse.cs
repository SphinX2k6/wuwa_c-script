using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D64 RID: 3428
	[NetMessage(EMessageId.PinballTaskRewardResponse)]
	public sealed class PinballTaskRewardResponse : IMessage<PinballTaskRewardResponse>, IMessage, IEquatable<PinballTaskRewardResponse>, IDeepCloneable<PinballTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x060127CE RID: 75726 RVA: 0x002B2995 File Offset: 0x002B0B95
		[NullableContext(1)]
		public static PinballTaskRewardResponse Create()
		{
			return new PinballTaskRewardResponse();
		}

		// Token: 0x17003D4A RID: 15690
		// (get) Token: 0x060127CF RID: 75727 RVA: 0x002B299C File Offset: 0x002B0B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D4B RID: 15691
		// (get) Token: 0x060127D0 RID: 75728 RVA: 0x002B299F File Offset: 0x002B0B9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x060127D1 RID: 75729 RVA: 0x002B29A6 File Offset: 0x002B0BA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballTaskRewardResponse()
		{
		}

		// Token: 0x060127D2 RID: 75730 RVA: 0x002B29AE File Offset: 0x002B0BAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballTaskRewardResponse(PinballTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060127D3 RID: 75731 RVA: 0x002B29D3 File Offset: 0x002B0BD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballTaskRewardResponse Clone()
		{
			return new PinballTaskRewardResponse(this);
		}

		// Token: 0x17003D4C RID: 15692
		// (get) Token: 0x060127D4 RID: 75732 RVA: 0x002B29DB File Offset: 0x002B0BDB
		// (set) Token: 0x060127D5 RID: 75733 RVA: 0x002B29E3 File Offset: 0x002B0BE3
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

		// Token: 0x060127D6 RID: 75734 RVA: 0x002B29EC File Offset: 0x002B0BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballTaskRewardResponse);
		}

		// Token: 0x060127D7 RID: 75735 RVA: 0x002B29FA File Offset: 0x002B0BFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060127D8 RID: 75736 RVA: 0x002B2A28 File Offset: 0x002B0C28
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

		// Token: 0x060127D9 RID: 75737 RVA: 0x002B2A6D File Offset: 0x002B0C6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060127DA RID: 75738 RVA: 0x002B2A7A File Offset: 0x002B0C7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060127DB RID: 75739 RVA: 0x002B2A83 File Offset: 0x002B0C83
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

		// Token: 0x060127DC RID: 75740 RVA: 0x002B2AB8 File Offset: 0x002B0CB8
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

		// Token: 0x060127DD RID: 75741 RVA: 0x002B2AF6 File Offset: 0x002B0CF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballTaskRewardResponse other)
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

		// Token: 0x060127DE RID: 75742 RVA: 0x002B2B27 File Offset: 0x002B0D27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060127DF RID: 75743 RVA: 0x002B2B30 File Offset: 0x002B0D30
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

		// Token: 0x040072FD RID: 29437
		private UnknownFieldSet _unknownFields;

		// Token: 0x040072FE RID: 29438
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x040072FF RID: 29439
		private ErrorCode errorCode_;
	}
}
