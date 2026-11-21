using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BD9 RID: 3033
	[NetMessage(EMessageId.PayShopBuyResponse)]
	public sealed class PayShopBuyResponse : IMessage<PayShopBuyResponse>, IMessage, IEquatable<PayShopBuyResponse>, IDeepCloneable<PayShopBuyResponse>, IBufferMessage
	{
		// Token: 0x0601075C RID: 67420 RVA: 0x00267C7A File Offset: 0x00265E7A
		[NullableContext(1)]
		public static PayShopBuyResponse Create()
		{
			return new PayShopBuyResponse();
		}

		// Token: 0x17003610 RID: 13840
		// (get) Token: 0x0601075D RID: 67421 RVA: 0x00267C81 File Offset: 0x00265E81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003611 RID: 13841
		// (get) Token: 0x0601075E RID: 67422 RVA: 0x00267C84 File Offset: 0x00265E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayShopBuyResponse.Descriptor;
			}
		}

		// Token: 0x0601075F RID: 67423 RVA: 0x00267C8B File Offset: 0x00265E8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopBuyResponse()
		{
		}

		// Token: 0x06010760 RID: 67424 RVA: 0x00267C93 File Offset: 0x00265E93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopBuyResponse(PayShopBuyResponse other) : this()
		{
			this.id_ = other.id_;
			this.count_ = other.count_;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010761 RID: 67425 RVA: 0x00267CD0 File Offset: 0x00265ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopBuyResponse Clone()
		{
			return new PayShopBuyResponse(this);
		}

		// Token: 0x17003612 RID: 13842
		// (get) Token: 0x06010762 RID: 67426 RVA: 0x00267CD8 File Offset: 0x00265ED8
		// (set) Token: 0x06010763 RID: 67427 RVA: 0x00267CE0 File Offset: 0x00265EE0
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

		// Token: 0x17003613 RID: 13843
		// (get) Token: 0x06010764 RID: 67428 RVA: 0x00267CE9 File Offset: 0x00265EE9
		// (set) Token: 0x06010765 RID: 67429 RVA: 0x00267CF1 File Offset: 0x00265EF1
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

		// Token: 0x17003614 RID: 13844
		// (get) Token: 0x06010766 RID: 67430 RVA: 0x00267CFA File Offset: 0x00265EFA
		// (set) Token: 0x06010767 RID: 67431 RVA: 0x00267D02 File Offset: 0x00265F02
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

		// Token: 0x06010768 RID: 67432 RVA: 0x00267D0B File Offset: 0x00265F0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayShopBuyResponse);
		}

		// Token: 0x06010769 RID: 67433 RVA: 0x00267D1C File Offset: 0x00265F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayShopBuyResponse other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Count == other.Count && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601076A RID: 67434 RVA: 0x00267D78 File Offset: 0x00265F78
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

		// Token: 0x0601076B RID: 67435 RVA: 0x00267DEF File Offset: 0x00265FEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601076C RID: 67436 RVA: 0x00267DFC File Offset: 0x00265FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601076D RID: 67437 RVA: 0x00267E08 File Offset: 0x00266008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Count != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Count);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Id);
			}
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

		// Token: 0x0601076E RID: 67438 RVA: 0x00267E80 File Offset: 0x00266080
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

		// Token: 0x0601076F RID: 67439 RVA: 0x00267EF0 File Offset: 0x002660F0
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

		// Token: 0x06010770 RID: 67440 RVA: 0x00267F54 File Offset: 0x00266154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010771 RID: 67441 RVA: 0x00267F60 File Offset: 0x00266160
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
				if (num != 32U)
				{
					if (num != 72U)
					{
						if (num != 88U)
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
						this.Id = input.ReadInt32();
					}
				}
				else
				{
					this.Count = input.ReadInt32();
				}
			}
		}

		// Token: 0x040068E5 RID: 26853
		private UnknownFieldSet _unknownFields;

		// Token: 0x040068E6 RID: 26854
		public const int IdFieldNumber = 9;

		// Token: 0x040068E7 RID: 26855
		private int id_;

		// Token: 0x040068E8 RID: 26856
		public const int CountFieldNumber = 4;

		// Token: 0x040068E9 RID: 26857
		private int count_;

		// Token: 0x040068EA RID: 26858
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x040068EB RID: 26859
		private ErrorCode errorCode_;
	}
}
