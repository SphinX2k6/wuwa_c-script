using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006BE RID: 1726
	[NetMessage(EMessageId.GetTraceQuestYuXueModeResponse)]
	public sealed class GetTraceQuestYuXueModeResponse : IMessage<GetTraceQuestYuXueModeResponse>, IMessage, IEquatable<GetTraceQuestYuXueModeResponse>, IDeepCloneable<GetTraceQuestYuXueModeResponse>, IBufferMessage
	{
		// Token: 0x06009E30 RID: 40496 RVA: 0x0017FF12 File Offset: 0x0017E112
		[NullableContext(1)]
		public static GetTraceQuestYuXueModeResponse Create()
		{
			return new GetTraceQuestYuXueModeResponse();
		}

		// Token: 0x17001FC0 RID: 8128
		// (get) Token: 0x06009E31 RID: 40497 RVA: 0x0017FF19 File Offset: 0x0017E119
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FC1 RID: 8129
		// (get) Token: 0x06009E32 RID: 40498 RVA: 0x0017FF1C File Offset: 0x0017E11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetTraceQuestYuXueModeResponse.Descriptor;
			}
		}

		// Token: 0x06009E33 RID: 40499 RVA: 0x0017FF23 File Offset: 0x0017E123
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTraceQuestYuXueModeResponse()
		{
		}

		// Token: 0x06009E34 RID: 40500 RVA: 0x0017FF2B File Offset: 0x0017E12B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTraceQuestYuXueModeResponse(GetTraceQuestYuXueModeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.inYuXueMode_ = other.inYuXueMode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009E35 RID: 40501 RVA: 0x0017FF5C File Offset: 0x0017E15C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTraceQuestYuXueModeResponse Clone()
		{
			return new GetTraceQuestYuXueModeResponse(this);
		}

		// Token: 0x17001FC2 RID: 8130
		// (get) Token: 0x06009E36 RID: 40502 RVA: 0x0017FF64 File Offset: 0x0017E164
		// (set) Token: 0x06009E37 RID: 40503 RVA: 0x0017FF6C File Offset: 0x0017E16C
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

		// Token: 0x17001FC3 RID: 8131
		// (get) Token: 0x06009E38 RID: 40504 RVA: 0x0017FF75 File Offset: 0x0017E175
		// (set) Token: 0x06009E39 RID: 40505 RVA: 0x0017FF7D File Offset: 0x0017E17D
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

		// Token: 0x06009E3A RID: 40506 RVA: 0x0017FF86 File Offset: 0x0017E186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetTraceQuestYuXueModeResponse);
		}

		// Token: 0x06009E3B RID: 40507 RVA: 0x0017FF94 File Offset: 0x0017E194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetTraceQuestYuXueModeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.InYuXueMode == other.InYuXueMode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009E3C RID: 40508 RVA: 0x0017FFD4 File Offset: 0x0017E1D4
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

		// Token: 0x06009E3D RID: 40509 RVA: 0x00180032 File Offset: 0x0017E232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009E3E RID: 40510 RVA: 0x0018003F File Offset: 0x0017E23F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009E3F RID: 40511 RVA: 0x00180048 File Offset: 0x0017E248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.InYuXueMode)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.InYuXueMode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009E40 RID: 40512 RVA: 0x001800A4 File Offset: 0x0017E2A4
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

		// Token: 0x06009E41 RID: 40513 RVA: 0x001800F0 File Offset: 0x0017E2F0
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

		// Token: 0x06009E42 RID: 40514 RVA: 0x00180140 File Offset: 0x0017E340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009E43 RID: 40515 RVA: 0x0018014C File Offset: 0x0017E34C
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
				if (num != 80U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.InYuXueMode = input.ReadBool();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004A69 RID: 19049
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A6A RID: 19050
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04004A6B RID: 19051
		private ErrorCode errorCode_;

		// Token: 0x04004A6C RID: 19052
		public const int InYuXueModeFieldNumber = 11;

		// Token: 0x04004A6D RID: 19053
		private bool inYuXueMode_;
	}
}
