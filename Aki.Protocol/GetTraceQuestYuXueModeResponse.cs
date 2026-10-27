using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006D2 RID: 1746
	[NetMessage(EMessageId.GetTraceQuestYuXueModeResponse)]
	public sealed class GetTraceQuestYuXueModeResponse : IMessage<GetTraceQuestYuXueModeResponse>, IMessage, IEquatable<GetTraceQuestYuXueModeResponse>, IDeepCloneable<GetTraceQuestYuXueModeResponse>, IBufferMessage
	{
		// Token: 0x06009F86 RID: 40838 RVA: 0x00182946 File Offset: 0x00180B46
		[NullableContext(1)]
		public static GetTraceQuestYuXueModeResponse Create()
		{
			return new GetTraceQuestYuXueModeResponse();
		}

		// Token: 0x1700200A RID: 8202
		// (get) Token: 0x06009F87 RID: 40839 RVA: 0x0018294D File Offset: 0x00180B4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700200B RID: 8203
		// (get) Token: 0x06009F88 RID: 40840 RVA: 0x00182950 File Offset: 0x00180B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetTraceQuestYuXueModeResponse.Descriptor;
			}
		}

		// Token: 0x06009F89 RID: 40841 RVA: 0x00182957 File Offset: 0x00180B57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTraceQuestYuXueModeResponse()
		{
		}

		// Token: 0x06009F8A RID: 40842 RVA: 0x0018295F File Offset: 0x00180B5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTraceQuestYuXueModeResponse(GetTraceQuestYuXueModeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.inYuXueMode_ = other.inYuXueMode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009F8B RID: 40843 RVA: 0x00182990 File Offset: 0x00180B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTraceQuestYuXueModeResponse Clone()
		{
			return new GetTraceQuestYuXueModeResponse(this);
		}

		// Token: 0x1700200C RID: 8204
		// (get) Token: 0x06009F8C RID: 40844 RVA: 0x00182998 File Offset: 0x00180B98
		// (set) Token: 0x06009F8D RID: 40845 RVA: 0x001829A0 File Offset: 0x00180BA0
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

		// Token: 0x1700200D RID: 8205
		// (get) Token: 0x06009F8E RID: 40846 RVA: 0x001829A9 File Offset: 0x00180BA9
		// (set) Token: 0x06009F8F RID: 40847 RVA: 0x001829B1 File Offset: 0x00180BB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool InYuXueMode
		{
			get
			{
				return this.inYuXueMode_;
			}
			set
			{
				this.inYuXueMode_ = value;
			}
		}

		// Token: 0x06009F90 RID: 40848 RVA: 0x001829BA File Offset: 0x00180BBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetTraceQuestYuXueModeResponse);
		}

		// Token: 0x06009F91 RID: 40849 RVA: 0x001829C8 File Offset: 0x00180BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetTraceQuestYuXueModeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.InYuXueMode == other.InYuXueMode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009F92 RID: 40850 RVA: 0x00182A08 File Offset: 0x00180C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.InYuXueMode)
			{
				num ^= this.InYuXueMode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009F93 RID: 40851 RVA: 0x00182A66 File Offset: 0x00180C66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009F94 RID: 40852 RVA: 0x00182A73 File Offset: 0x00180C73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009F95 RID: 40853 RVA: 0x00182A7C File Offset: 0x00180C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InYuXueMode)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.InYuXueMode);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009F96 RID: 40854 RVA: 0x00182AD8 File Offset: 0x00180CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.InYuXueMode)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009F97 RID: 40855 RVA: 0x00182B24 File Offset: 0x00180D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetTraceQuestYuXueModeResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.InYuXueMode)
			{
				this.InYuXueMode = other.InYuXueMode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009F98 RID: 40856 RVA: 0x00182B74 File Offset: 0x00180D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009F99 RID: 40857 RVA: 0x00182B80 File Offset: 0x00180D80
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
				if (num != 56U)
				{
					if (num != 80U)
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
					this.InYuXueMode = input.ReadBool();
				}
			}
		}

		// Token: 0x04004A70 RID: 19056
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A71 RID: 19057
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04004A72 RID: 19058
		private ErrorCode errorCode_;

		// Token: 0x04004A73 RID: 19059
		public const int InYuXueModeFieldNumber = 7;

		// Token: 0x04004A74 RID: 19060
		private bool inYuXueMode_;
	}
}
