using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200136F RID: 4975
	[NetMessage(EMessageId.SwitchLogicStateResponse)]
	public sealed class SwitchLogicStateResponse : IMessage<SwitchLogicStateResponse>, IMessage, IEquatable<SwitchLogicStateResponse>, IDeepCloneable<SwitchLogicStateResponse>, IBufferMessage
	{
		// Token: 0x0601A7EA RID: 108522 RVA: 0x003DC52B File Offset: 0x003DA72B
		[NullableContext(1)]
		public static SwitchLogicStateResponse Create()
		{
			return new SwitchLogicStateResponse();
		}

		// Token: 0x170059B3 RID: 22963
		// (get) Token: 0x0601A7EB RID: 108523 RVA: 0x003DC532 File Offset: 0x003DA732
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059B4 RID: 22964
		// (get) Token: 0x0601A7EC RID: 108524 RVA: 0x003DC535 File Offset: 0x003DA735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwitchLogicStateResponse.Descriptor;
			}
		}

		// Token: 0x0601A7ED RID: 108525 RVA: 0x003DC53C File Offset: 0x003DA73C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchLogicStateResponse()
		{
		}

		// Token: 0x0601A7EE RID: 108526 RVA: 0x003DC544 File Offset: 0x003DA744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchLogicStateResponse(SwitchLogicStateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A7EF RID: 108527 RVA: 0x003DC569 File Offset: 0x003DA769
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchLogicStateResponse Clone()
		{
			return new SwitchLogicStateResponse(this);
		}

		// Token: 0x170059B5 RID: 22965
		// (get) Token: 0x0601A7F0 RID: 108528 RVA: 0x003DC571 File Offset: 0x003DA771
		// (set) Token: 0x0601A7F1 RID: 108529 RVA: 0x003DC579 File Offset: 0x003DA779
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

		// Token: 0x0601A7F2 RID: 108530 RVA: 0x003DC582 File Offset: 0x003DA782
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwitchLogicStateResponse);
		}

		// Token: 0x0601A7F3 RID: 108531 RVA: 0x003DC590 File Offset: 0x003DA790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwitchLogicStateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A7F4 RID: 108532 RVA: 0x003DC5C0 File Offset: 0x003DA7C0
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

		// Token: 0x0601A7F5 RID: 108533 RVA: 0x003DC605 File Offset: 0x003DA805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A7F6 RID: 108534 RVA: 0x003DC612 File Offset: 0x003DA812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A7F7 RID: 108535 RVA: 0x003DC61B File Offset: 0x003DA81B
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

		// Token: 0x0601A7F8 RID: 108536 RVA: 0x003DC650 File Offset: 0x003DA850
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

		// Token: 0x0601A7F9 RID: 108537 RVA: 0x003DC68E File Offset: 0x003DA88E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwitchLogicStateResponse other)
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

		// Token: 0x0601A7FA RID: 108538 RVA: 0x003DC6BF File Offset: 0x003DA8BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A7FB RID: 108539 RVA: 0x003DC6C8 File Offset: 0x003DA8C8
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

		// Token: 0x04009B61 RID: 39777
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B62 RID: 39778
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04009B63 RID: 39779
		private ErrorCode errorCode_;
	}
}
