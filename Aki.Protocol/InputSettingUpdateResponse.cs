using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000803 RID: 2051
	[NetMessage(EMessageId.InputSettingUpdateResponse)]
	public sealed class InputSettingUpdateResponse : IMessage<InputSettingUpdateResponse>, IMessage, IEquatable<InputSettingUpdateResponse>, IDeepCloneable<InputSettingUpdateResponse>, IBufferMessage
	{
		// Token: 0x0600B7CE RID: 47054 RVA: 0x001B63F0 File Offset: 0x001B45F0
		[NullableContext(1)]
		public static InputSettingUpdateResponse Create()
		{
			return new InputSettingUpdateResponse();
		}

		// Token: 0x17002504 RID: 9476
		// (get) Token: 0x0600B7CF RID: 47055 RVA: 0x001B63F7 File Offset: 0x001B45F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002505 RID: 9477
		// (get) Token: 0x0600B7D0 RID: 47056 RVA: 0x001B63FA File Offset: 0x001B45FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InputSettingUpdateResponse.Descriptor;
			}
		}

		// Token: 0x0600B7D1 RID: 47057 RVA: 0x001B6401 File Offset: 0x001B4601
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingUpdateResponse()
		{
		}

		// Token: 0x0600B7D2 RID: 47058 RVA: 0x001B6409 File Offset: 0x001B4609
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingUpdateResponse(InputSettingUpdateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B7D3 RID: 47059 RVA: 0x001B642E File Offset: 0x001B462E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingUpdateResponse Clone()
		{
			return new InputSettingUpdateResponse(this);
		}

		// Token: 0x17002506 RID: 9478
		// (get) Token: 0x0600B7D4 RID: 47060 RVA: 0x001B6436 File Offset: 0x001B4636
		// (set) Token: 0x0600B7D5 RID: 47061 RVA: 0x001B643E File Offset: 0x001B463E
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

		// Token: 0x0600B7D6 RID: 47062 RVA: 0x001B6447 File Offset: 0x001B4647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InputSettingUpdateResponse);
		}

		// Token: 0x0600B7D7 RID: 47063 RVA: 0x001B6455 File Offset: 0x001B4655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InputSettingUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B7D8 RID: 47064 RVA: 0x001B6484 File Offset: 0x001B4684
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

		// Token: 0x0600B7D9 RID: 47065 RVA: 0x001B64C9 File Offset: 0x001B46C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B7DA RID: 47066 RVA: 0x001B64D6 File Offset: 0x001B46D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B7DB RID: 47067 RVA: 0x001B64DF File Offset: 0x001B46DF
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

		// Token: 0x0600B7DC RID: 47068 RVA: 0x001B6514 File Offset: 0x001B4714
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

		// Token: 0x0600B7DD RID: 47069 RVA: 0x001B6552 File Offset: 0x001B4752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InputSettingUpdateResponse other)
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

		// Token: 0x0600B7DE RID: 47070 RVA: 0x001B6583 File Offset: 0x001B4783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B7DF RID: 47071 RVA: 0x001B658C File Offset: 0x001B478C
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

		// Token: 0x0400516A RID: 20842
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400516B RID: 20843
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x0400516C RID: 20844
		private ErrorCode errorCode_;
	}
}
