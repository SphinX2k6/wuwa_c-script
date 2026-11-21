using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001202 RID: 4610
	[NetMessage(EMessageId.SetAlertUiVisibleResponse)]
	public sealed class SetAlertUiVisibleResponse : IMessage<SetAlertUiVisibleResponse>, IMessage, IEquatable<SetAlertUiVisibleResponse>, IDeepCloneable<SetAlertUiVisibleResponse>, IBufferMessage
	{
		// Token: 0x06018A29 RID: 100905 RVA: 0x00397F14 File Offset: 0x00396114
		[NullableContext(1)]
		public static SetAlertUiVisibleResponse Create()
		{
			return new SetAlertUiVisibleResponse();
		}

		// Token: 0x17005337 RID: 21303
		// (get) Token: 0x06018A2A RID: 100906 RVA: 0x00397F1B File Offset: 0x0039611B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005338 RID: 21304
		// (get) Token: 0x06018A2B RID: 100907 RVA: 0x00397F1E File Offset: 0x0039611E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetAlertUiVisibleResponse.Descriptor;
			}
		}

		// Token: 0x06018A2C RID: 100908 RVA: 0x00397F25 File Offset: 0x00396125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetAlertUiVisibleResponse()
		{
		}

		// Token: 0x06018A2D RID: 100909 RVA: 0x00397F2D File Offset: 0x0039612D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetAlertUiVisibleResponse(SetAlertUiVisibleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018A2E RID: 100910 RVA: 0x00397F52 File Offset: 0x00396152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetAlertUiVisibleResponse Clone()
		{
			return new SetAlertUiVisibleResponse(this);
		}

		// Token: 0x17005339 RID: 21305
		// (get) Token: 0x06018A2F RID: 100911 RVA: 0x00397F5A File Offset: 0x0039615A
		// (set) Token: 0x06018A30 RID: 100912 RVA: 0x00397F62 File Offset: 0x00396162
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

		// Token: 0x06018A31 RID: 100913 RVA: 0x00397F6B File Offset: 0x0039616B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetAlertUiVisibleResponse);
		}

		// Token: 0x06018A32 RID: 100914 RVA: 0x00397F79 File Offset: 0x00396179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetAlertUiVisibleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018A33 RID: 100915 RVA: 0x00397FA8 File Offset: 0x003961A8
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

		// Token: 0x06018A34 RID: 100916 RVA: 0x00397FED File Offset: 0x003961ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018A35 RID: 100917 RVA: 0x00397FFA File Offset: 0x003961FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018A36 RID: 100918 RVA: 0x00398003 File Offset: 0x00396203
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018A37 RID: 100919 RVA: 0x00398038 File Offset: 0x00396238
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

		// Token: 0x06018A38 RID: 100920 RVA: 0x00398076 File Offset: 0x00396276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetAlertUiVisibleResponse other)
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

		// Token: 0x06018A39 RID: 100921 RVA: 0x003980A7 File Offset: 0x003962A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018A3A RID: 100922 RVA: 0x003980B0 File Offset: 0x003962B0
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009273 RID: 37491
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009274 RID: 37492
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04009275 RID: 37493
		private ErrorCode errorCode_;
	}
}
