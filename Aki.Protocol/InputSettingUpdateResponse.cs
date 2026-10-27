using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000817 RID: 2071
	[NetMessage(EMessageId.InputSettingUpdateResponse)]
	public sealed class InputSettingUpdateResponse : IMessage<InputSettingUpdateResponse>, IMessage, IEquatable<InputSettingUpdateResponse>, IDeepCloneable<InputSettingUpdateResponse>, IBufferMessage
	{
		// Token: 0x0600B924 RID: 47396 RVA: 0x001B8E30 File Offset: 0x001B7030
		[NullableContext(1)]
		public static InputSettingUpdateResponse Create()
		{
			return new InputSettingUpdateResponse();
		}

		// Token: 0x1700254E RID: 9550
		// (get) Token: 0x0600B925 RID: 47397 RVA: 0x001B8E37 File Offset: 0x001B7037
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700254F RID: 9551
		// (get) Token: 0x0600B926 RID: 47398 RVA: 0x001B8E3A File Offset: 0x001B703A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InputSettingUpdateResponse.Descriptor;
			}
		}

		// Token: 0x0600B927 RID: 47399 RVA: 0x001B8E41 File Offset: 0x001B7041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingUpdateResponse()
		{
		}

		// Token: 0x0600B928 RID: 47400 RVA: 0x001B8E49 File Offset: 0x001B7049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingUpdateResponse(InputSettingUpdateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B929 RID: 47401 RVA: 0x001B8E6E File Offset: 0x001B706E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingUpdateResponse Clone()
		{
			return new InputSettingUpdateResponse(this);
		}

		// Token: 0x17002550 RID: 9552
		// (get) Token: 0x0600B92A RID: 47402 RVA: 0x001B8E76 File Offset: 0x001B7076
		// (set) Token: 0x0600B92B RID: 47403 RVA: 0x001B8E7E File Offset: 0x001B707E
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

		// Token: 0x0600B92C RID: 47404 RVA: 0x001B8E87 File Offset: 0x001B7087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InputSettingUpdateResponse);
		}

		// Token: 0x0600B92D RID: 47405 RVA: 0x001B8E95 File Offset: 0x001B7095
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InputSettingUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B92E RID: 47406 RVA: 0x001B8EC4 File Offset: 0x001B70C4
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

		// Token: 0x0600B92F RID: 47407 RVA: 0x001B8F09 File Offset: 0x001B7109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B930 RID: 47408 RVA: 0x001B8F16 File Offset: 0x001B7116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B931 RID: 47409 RVA: 0x001B8F1F File Offset: 0x001B711F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B932 RID: 47410 RVA: 0x001B8F54 File Offset: 0x001B7154
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

		// Token: 0x0600B933 RID: 47411 RVA: 0x001B8F92 File Offset: 0x001B7192
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

		// Token: 0x0600B934 RID: 47412 RVA: 0x001B8FC3 File Offset: 0x001B71C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B935 RID: 47413 RVA: 0x001B8FCC File Offset: 0x001B71CC
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005171 RID: 20849
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005172 RID: 20850
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04005173 RID: 20851
		private ErrorCode errorCode_;
	}
}
