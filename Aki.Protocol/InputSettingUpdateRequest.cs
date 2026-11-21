using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000802 RID: 2050
	[NetMessage(EMessageId.InputSettingUpdateRequest)]
	public sealed class InputSettingUpdateRequest : IMessage<InputSettingUpdateRequest>, IMessage, IEquatable<InputSettingUpdateRequest>, IDeepCloneable<InputSettingUpdateRequest>, IBufferMessage
	{
		// Token: 0x0600B7BC RID: 47036 RVA: 0x001B61CC File Offset: 0x001B43CC
		[NullableContext(1)]
		public static InputSettingUpdateRequest Create()
		{
			return new InputSettingUpdateRequest();
		}

		// Token: 0x17002501 RID: 9473
		// (get) Token: 0x0600B7BD RID: 47037 RVA: 0x001B61D3 File Offset: 0x001B43D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002502 RID: 9474
		// (get) Token: 0x0600B7BE RID: 47038 RVA: 0x001B61D6 File Offset: 0x001B43D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InputSettingUpdateRequest.Descriptor;
			}
		}

		// Token: 0x0600B7BF RID: 47039 RVA: 0x001B61DD File Offset: 0x001B43DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingUpdateRequest()
		{
		}

		// Token: 0x0600B7C0 RID: 47040 RVA: 0x001B61E5 File Offset: 0x001B43E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingUpdateRequest(InputSettingUpdateRequest other) : this()
		{
			this.inputSettingData_ = ((other.inputSettingData_ != null) ? other.inputSettingData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B7C1 RID: 47041 RVA: 0x001B621A File Offset: 0x001B441A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingUpdateRequest Clone()
		{
			return new InputSettingUpdateRequest(this);
		}

		// Token: 0x17002503 RID: 9475
		// (get) Token: 0x0600B7C2 RID: 47042 RVA: 0x001B6222 File Offset: 0x001B4422
		// (set) Token: 0x0600B7C3 RID: 47043 RVA: 0x001B622A File Offset: 0x001B442A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingData InputSettingData
		{
			get
			{
				return this.inputSettingData_;
			}
			set
			{
				this.inputSettingData_ = value;
			}
		}

		// Token: 0x0600B7C4 RID: 47044 RVA: 0x001B6233 File Offset: 0x001B4433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InputSettingUpdateRequest);
		}

		// Token: 0x0600B7C5 RID: 47045 RVA: 0x001B6241 File Offset: 0x001B4441
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InputSettingUpdateRequest other)
		{
			return other != null && (other == this || (object.Equals(this.InputSettingData, other.InputSettingData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B7C6 RID: 47046 RVA: 0x001B6274 File Offset: 0x001B4474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.inputSettingData_ != null)
			{
				num ^= this.InputSettingData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B7C7 RID: 47047 RVA: 0x001B62B0 File Offset: 0x001B44B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B7C8 RID: 47048 RVA: 0x001B62BD File Offset: 0x001B44BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B7C9 RID: 47049 RVA: 0x001B62C6 File Offset: 0x001B44C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.inputSettingData_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.InputSettingData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B7CA RID: 47050 RVA: 0x001B62F8 File Offset: 0x001B44F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.inputSettingData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.InputSettingData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B7CB RID: 47051 RVA: 0x001B6338 File Offset: 0x001B4538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InputSettingUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.inputSettingData_ != null)
			{
				if (this.inputSettingData_ == null)
				{
					this.InputSettingData = new InputSettingData();
				}
				this.InputSettingData.MergeFrom(other.InputSettingData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B7CC RID: 47052 RVA: 0x001B638C File Offset: 0x001B458C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B7CD RID: 47053 RVA: 0x001B6398 File Offset: 0x001B4598
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.inputSettingData_ == null)
					{
						this.InputSettingData = new InputSettingData();
					}
					input.ReadMessage(this.InputSettingData);
				}
			}
		}

		// Token: 0x04005167 RID: 20839
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005168 RID: 20840
		public const int InputSettingDataFieldNumber = 13;

		// Token: 0x04005169 RID: 20841
		private InputSettingData inputSettingData_;
	}
}
