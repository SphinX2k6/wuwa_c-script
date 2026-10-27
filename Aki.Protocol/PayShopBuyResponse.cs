using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BE9 RID: 3049
	[NetMessage(EMessageId.PayShopBuyResponse)]
	public sealed class PayShopBuyResponse : IMessage<PayShopBuyResponse>, IMessage, IEquatable<PayShopBuyResponse>, IDeepCloneable<PayShopBuyResponse>, IBufferMessage
	{
		// Token: 0x06010860 RID: 67680 RVA: 0x00269B3F File Offset: 0x00267D3F
		[NullableContext(1)]
		public static PayShopBuyResponse Create()
		{
			return new PayShopBuyResponse();
		}

		// Token: 0x17003649 RID: 13897
		// (get) Token: 0x06010861 RID: 67681 RVA: 0x00269B46 File Offset: 0x00267D46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700364A RID: 13898
		// (get) Token: 0x06010862 RID: 67682 RVA: 0x00269B49 File Offset: 0x00267D49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayShopBuyResponse.Descriptor;
			}
		}

		// Token: 0x06010863 RID: 67683 RVA: 0x00269B50 File Offset: 0x00267D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopBuyResponse()
		{
		}

		// Token: 0x06010864 RID: 67684 RVA: 0x00269B58 File Offset: 0x00267D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopBuyResponse(PayShopBuyResponse other) : this()
		{
			this.id_ = other.id_;
			this.count_ = other.count_;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010865 RID: 67685 RVA: 0x00269B95 File Offset: 0x00267D95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopBuyResponse Clone()
		{
			return new PayShopBuyResponse(this);
		}

		// Token: 0x1700364B RID: 13899
		// (get) Token: 0x06010866 RID: 67686 RVA: 0x00269B9D File Offset: 0x00267D9D
		// (set) Token: 0x06010867 RID: 67687 RVA: 0x00269BA5 File Offset: 0x00267DA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x1700364C RID: 13900
		// (get) Token: 0x06010868 RID: 67688 RVA: 0x00269BAE File Offset: 0x00267DAE
		// (set) Token: 0x06010869 RID: 67689 RVA: 0x00269BB6 File Offset: 0x00267DB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x1700364D RID: 13901
		// (get) Token: 0x0601086A RID: 67690 RVA: 0x00269BBF File Offset: 0x00267DBF
		// (set) Token: 0x0601086B RID: 67691 RVA: 0x00269BC7 File Offset: 0x00267DC7
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

		// Token: 0x0601086C RID: 67692 RVA: 0x00269BD0 File Offset: 0x00267DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayShopBuyResponse);
		}

		// Token: 0x0601086D RID: 67693 RVA: 0x00269BE0 File Offset: 0x00267DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayShopBuyResponse other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Count == other.Count && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601086E RID: 67694 RVA: 0x00269C3C File Offset: 0x00267E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
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

		// Token: 0x0601086F RID: 67695 RVA: 0x00269CB3 File Offset: 0x00267EB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010870 RID: 67696 RVA: 0x00269CC0 File Offset: 0x00267EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010871 RID: 67697 RVA: 0x00269CCC File Offset: 0x00267ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Id);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Count);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010872 RID: 67698 RVA: 0x00269D44 File Offset: 0x00267F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
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

		// Token: 0x06010873 RID: 67699 RVA: 0x00269DB4 File Offset: 0x00267FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PayShopBuyResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010874 RID: 67700 RVA: 0x00269E18 File Offset: 0x00268018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010875 RID: 67701 RVA: 0x00269E24 File Offset: 0x00268024
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
					if (num != 96U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ErrorCode = (ErrorCode)input.ReadEnum();
						}
					}
					else
					{
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040068D5 RID: 26837
		private UnknownFieldSet _unknownFields;

		// Token: 0x040068D6 RID: 26838
		public const int IdFieldNumber = 3;

		// Token: 0x040068D7 RID: 26839
		private int id_;

		// Token: 0x040068D8 RID: 26840
		public const int CountFieldNumber = 12;

		// Token: 0x040068D9 RID: 26841
		private int count_;

		// Token: 0x040068DA RID: 26842
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x040068DB RID: 26843
		private ErrorCode errorCode_;
	}
}
