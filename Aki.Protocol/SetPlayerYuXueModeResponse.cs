using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011DB RID: 4571
	[NetMessage(EMessageId.SetPlayerYuXueModeResponse)]
	public sealed class SetPlayerYuXueModeResponse : IMessage<SetPlayerYuXueModeResponse>, IMessage, IEquatable<SetPlayerYuXueModeResponse>, IDeepCloneable<SetPlayerYuXueModeResponse>, IBufferMessage
	{
		// Token: 0x060185F0 RID: 99824 RVA: 0x0038B681 File Offset: 0x00389881
		[NullableContext(1)]
		public static SetPlayerYuXueModeResponse Create()
		{
			return new SetPlayerYuXueModeResponse();
		}

		// Token: 0x1700520D RID: 21005
		// (get) Token: 0x060185F1 RID: 99825 RVA: 0x0038B688 File Offset: 0x00389888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700520E RID: 21006
		// (get) Token: 0x060185F2 RID: 99826 RVA: 0x0038B68B File Offset: 0x0038988B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetPlayerYuXueModeResponse.Descriptor;
			}
		}

		// Token: 0x060185F3 RID: 99827 RVA: 0x0038B692 File Offset: 0x00389892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetPlayerYuXueModeResponse()
		{
		}

		// Token: 0x060185F4 RID: 99828 RVA: 0x0038B69A File Offset: 0x0038989A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetPlayerYuXueModeResponse(SetPlayerYuXueModeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060185F5 RID: 99829 RVA: 0x0038B6BF File Offset: 0x003898BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetPlayerYuXueModeResponse Clone()
		{
			return new SetPlayerYuXueModeResponse(this);
		}

		// Token: 0x1700520F RID: 21007
		// (get) Token: 0x060185F6 RID: 99830 RVA: 0x0038B6C7 File Offset: 0x003898C7
		// (set) Token: 0x060185F7 RID: 99831 RVA: 0x0038B6CF File Offset: 0x003898CF
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

		// Token: 0x060185F8 RID: 99832 RVA: 0x0038B6D8 File Offset: 0x003898D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetPlayerYuXueModeResponse);
		}

		// Token: 0x060185F9 RID: 99833 RVA: 0x0038B6E6 File Offset: 0x003898E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetPlayerYuXueModeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060185FA RID: 99834 RVA: 0x0038B714 File Offset: 0x00389914
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

		// Token: 0x060185FB RID: 99835 RVA: 0x0038B759 File Offset: 0x00389959
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060185FC RID: 99836 RVA: 0x0038B766 File Offset: 0x00389966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060185FD RID: 99837 RVA: 0x0038B76F File Offset: 0x0038996F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060185FE RID: 99838 RVA: 0x0038B7A4 File Offset: 0x003899A4
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

		// Token: 0x060185FF RID: 99839 RVA: 0x0038B7E2 File Offset: 0x003899E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetPlayerYuXueModeResponse other)
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

		// Token: 0x06018600 RID: 99840 RVA: 0x0038B813 File Offset: 0x00389A13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018601 RID: 99841 RVA: 0x0038B81C File Offset: 0x00389A1C
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400902B RID: 36907
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400902C RID: 36908
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x0400902D RID: 36909
		private ErrorCode errorCode_;
	}
}
