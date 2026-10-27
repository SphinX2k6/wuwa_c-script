using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003E9 RID: 1001
	[NetMessage(EMessageId.DollDeliveryResponse)]
	public sealed class DollDeliveryResponse : IMessage<DollDeliveryResponse>, IMessage, IEquatable<DollDeliveryResponse>, IDeepCloneable<DollDeliveryResponse>, IBufferMessage
	{
		// Token: 0x06006127 RID: 24871 RVA: 0x000EA9A9 File Offset: 0x000E8BA9
		[NullableContext(1)]
		public static DollDeliveryResponse Create()
		{
			return new DollDeliveryResponse();
		}

		// Token: 0x1700121B RID: 4635
		// (get) Token: 0x06006128 RID: 24872 RVA: 0x000EA9B0 File Offset: 0x000E8BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700121C RID: 4636
		// (get) Token: 0x06006129 RID: 24873 RVA: 0x000EA9B3 File Offset: 0x000E8BB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollDeliveryResponse.Descriptor;
			}
		}

		// Token: 0x0600612A RID: 24874 RVA: 0x000EA9BA File Offset: 0x000E8BBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollDeliveryResponse()
		{
		}

		// Token: 0x0600612B RID: 24875 RVA: 0x000EA9CD File Offset: 0x000E8BCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollDeliveryResponse(DollDeliveryResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.itemIds_ = other.itemIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600612C RID: 24876 RVA: 0x000EAA03 File Offset: 0x000E8C03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollDeliveryResponse Clone()
		{
			return new DollDeliveryResponse(this);
		}

		// Token: 0x1700121D RID: 4637
		// (get) Token: 0x0600612D RID: 24877 RVA: 0x000EAA0B File Offset: 0x000E8C0B
		// (set) Token: 0x0600612E RID: 24878 RVA: 0x000EAA13 File Offset: 0x000E8C13
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

		// Token: 0x1700121E RID: 4638
		// (get) Token: 0x0600612F RID: 24879 RVA: 0x000EAA1C File Offset: 0x000E8C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ItemIds
		{
			get
			{
				return this.itemIds_;
			}
		}

		// Token: 0x06006130 RID: 24880 RVA: 0x000EAA24 File Offset: 0x000E8C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollDeliveryResponse);
		}

		// Token: 0x06006131 RID: 24881 RVA: 0x000EAA34 File Offset: 0x000E8C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollDeliveryResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.itemIds_.Equals(other.itemIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006132 RID: 24882 RVA: 0x000EAA84 File Offset: 0x000E8C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.itemIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006133 RID: 24883 RVA: 0x000EAAD7 File Offset: 0x000E8CD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006134 RID: 24884 RVA: 0x000EAAE4 File Offset: 0x000E8CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006135 RID: 24885 RVA: 0x000EAAF0 File Offset: 0x000E8CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.itemIds_.WriteTo(ref output, DollDeliveryResponse._repeated_itemIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006136 RID: 24886 RVA: 0x000EAB40 File Offset: 0x000E8D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.itemIds_.CalculateSize(DollDeliveryResponse._repeated_itemIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006137 RID: 24887 RVA: 0x000EAB94 File Offset: 0x000E8D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DollDeliveryResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.itemIds_.Add(other.itemIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006138 RID: 24888 RVA: 0x000EABE1 File Offset: 0x000E8DE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006139 RID: 24889 RVA: 0x000EABEC File Offset: 0x000E8DEC
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
					if (num != 72U && num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.itemIds_.AddEntriesFrom(ref input, DollDeliveryResponse._repeated_itemIds_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400378E RID: 14222
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400378F RID: 14223
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04003790 RID: 14224
		private ErrorCode errorCode_;

		// Token: 0x04003791 RID: 14225
		public const int ItemIdsFieldNumber = 9;

		// Token: 0x04003792 RID: 14226
		private static readonly FieldCodec<int> _repeated_itemIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04003793 RID: 14227
		private readonly RepeatedField<int> itemIds_ = new RepeatedField<int>();
	}
}
