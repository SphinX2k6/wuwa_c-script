using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200055F RID: 1375
	[NetMessage(EMessageId.FishingHandInResponse)]
	public sealed class FishingHandInResponse : IMessage<FishingHandInResponse>, IMessage, IEquatable<FishingHandInResponse>, IDeepCloneable<FishingHandInResponse>, IBufferMessage
	{
		// Token: 0x06008038 RID: 32824 RVA: 0x00135BA3 File Offset: 0x00133DA3
		[NullableContext(1)]
		public static FishingHandInResponse Create()
		{
			return new FishingHandInResponse();
		}

		// Token: 0x170018F5 RID: 6389
		// (get) Token: 0x06008039 RID: 32825 RVA: 0x00135BAA File Offset: 0x00133DAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018F6 RID: 6390
		// (get) Token: 0x0600803A RID: 32826 RVA: 0x00135BAD File Offset: 0x00133DAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingHandInResponse.Descriptor;
			}
		}

		// Token: 0x0600803B RID: 32827 RVA: 0x00135BB4 File Offset: 0x00133DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingHandInResponse()
		{
		}

		// Token: 0x0600803C RID: 32828 RVA: 0x00135BBC File Offset: 0x00133DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingHandInResponse(FishingHandInResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.handInComplete_ = other.handInComplete_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600803D RID: 32829 RVA: 0x00135BED File Offset: 0x00133DED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingHandInResponse Clone()
		{
			return new FishingHandInResponse(this);
		}

		// Token: 0x170018F7 RID: 6391
		// (get) Token: 0x0600803E RID: 32830 RVA: 0x00135BF5 File Offset: 0x00133DF5
		// (set) Token: 0x0600803F RID: 32831 RVA: 0x00135BFD File Offset: 0x00133DFD
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

		// Token: 0x170018F8 RID: 6392
		// (get) Token: 0x06008040 RID: 32832 RVA: 0x00135C06 File Offset: 0x00133E06
		// (set) Token: 0x06008041 RID: 32833 RVA: 0x00135C0E File Offset: 0x00133E0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HandInComplete
		{
			get
			{
				return this.handInComplete_;
			}
			set
			{
				this.handInComplete_ = value;
			}
		}

		// Token: 0x06008042 RID: 32834 RVA: 0x00135C17 File Offset: 0x00133E17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingHandInResponse);
		}

		// Token: 0x06008043 RID: 32835 RVA: 0x00135C25 File Offset: 0x00133E25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingHandInResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.HandInComplete == other.HandInComplete && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008044 RID: 32836 RVA: 0x00135C64 File Offset: 0x00133E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.HandInComplete)
			{
				num ^= this.HandInComplete.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008045 RID: 32837 RVA: 0x00135CC2 File Offset: 0x00133EC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008046 RID: 32838 RVA: 0x00135CCF File Offset: 0x00133ECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008047 RID: 32839 RVA: 0x00135CD8 File Offset: 0x00133ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.HandInComplete)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.HandInComplete);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008048 RID: 32840 RVA: 0x00135D34 File Offset: 0x00133F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.HandInComplete)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008049 RID: 32841 RVA: 0x00135D80 File Offset: 0x00133F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingHandInResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.HandInComplete)
			{
				this.HandInComplete = other.HandInComplete;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600804A RID: 32842 RVA: 0x00135DD0 File Offset: 0x00133FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600804B RID: 32843 RVA: 0x00135DDC File Offset: 0x00133FDC
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
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.HandInComplete = input.ReadBool();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004091 RID: 16529
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004092 RID: 16530
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04004093 RID: 16531
		private ErrorCode errorCode_;

		// Token: 0x04004094 RID: 16532
		public const int HandInCompleteFieldNumber = 12;

		// Token: 0x04004095 RID: 16533
		private bool handInComplete_;
	}
}
