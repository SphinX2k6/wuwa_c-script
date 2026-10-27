using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001122 RID: 4386
	[NetMessage(EMessageId.RoverRogueShopBuyResponse)]
	public sealed class RoverRogueShopBuyResponse : IMessage<RoverRogueShopBuyResponse>, IMessage, IEquatable<RoverRogueShopBuyResponse>, IDeepCloneable<RoverRogueShopBuyResponse>, IBufferMessage
	{
		// Token: 0x0601765C RID: 95836 RVA: 0x003660E8 File Offset: 0x003642E8
		[NullableContext(1)]
		public static RoverRogueShopBuyResponse Create()
		{
			return new RoverRogueShopBuyResponse();
		}

		// Token: 0x17004E86 RID: 20102
		// (get) Token: 0x0601765D RID: 95837 RVA: 0x003660EF File Offset: 0x003642EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E87 RID: 20103
		// (get) Token: 0x0601765E RID: 95838 RVA: 0x003660F2 File Offset: 0x003642F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueShopBuyResponse.Descriptor;
			}
		}

		// Token: 0x0601765F RID: 95839 RVA: 0x003660F9 File Offset: 0x003642F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopBuyResponse()
		{
		}

		// Token: 0x06017660 RID: 95840 RVA: 0x00366101 File Offset: 0x00364301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopBuyResponse(RoverRogueShopBuyResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017661 RID: 95841 RVA: 0x00366126 File Offset: 0x00364326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopBuyResponse Clone()
		{
			return new RoverRogueShopBuyResponse(this);
		}

		// Token: 0x17004E88 RID: 20104
		// (get) Token: 0x06017662 RID: 95842 RVA: 0x0036612E File Offset: 0x0036432E
		// (set) Token: 0x06017663 RID: 95843 RVA: 0x00366136 File Offset: 0x00364336
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

		// Token: 0x06017664 RID: 95844 RVA: 0x0036613F File Offset: 0x0036433F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueShopBuyResponse);
		}

		// Token: 0x06017665 RID: 95845 RVA: 0x0036614D File Offset: 0x0036434D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueShopBuyResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017666 RID: 95846 RVA: 0x0036617C File Offset: 0x0036437C
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

		// Token: 0x06017667 RID: 95847 RVA: 0x003661C1 File Offset: 0x003643C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017668 RID: 95848 RVA: 0x003661CE File Offset: 0x003643CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017669 RID: 95849 RVA: 0x003661D7 File Offset: 0x003643D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601766A RID: 95850 RVA: 0x0036620C File Offset: 0x0036440C
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

		// Token: 0x0601766B RID: 95851 RVA: 0x0036624A File Offset: 0x0036444A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueShopBuyResponse other)
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

		// Token: 0x0601766C RID: 95852 RVA: 0x0036627B File Offset: 0x0036447B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601766D RID: 95853 RVA: 0x00366284 File Offset: 0x00364484
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008B2E RID: 35630
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B2F RID: 35631
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04008B30 RID: 35632
		private ErrorCode errorCode_;
	}
}
