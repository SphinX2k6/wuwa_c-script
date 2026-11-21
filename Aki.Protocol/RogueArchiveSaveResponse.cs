using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F6F RID: 3951
	[NetMessage(EMessageId.RogueArchiveSaveResponse)]
	public sealed class RogueArchiveSaveResponse : IMessage<RogueArchiveSaveResponse>, IMessage, IEquatable<RogueArchiveSaveResponse>, IDeepCloneable<RogueArchiveSaveResponse>, IBufferMessage
	{
		// Token: 0x0601526B RID: 86635 RVA: 0x00311B41 File Offset: 0x0030FD41
		[NullableContext(1)]
		public static RogueArchiveSaveResponse Create()
		{
			return new RogueArchiveSaveResponse();
		}

		// Token: 0x17004666 RID: 18022
		// (get) Token: 0x0601526C RID: 86636 RVA: 0x00311B48 File Offset: 0x0030FD48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004667 RID: 18023
		// (get) Token: 0x0601526D RID: 86637 RVA: 0x00311B4B File Offset: 0x0030FD4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueArchiveSaveResponse.Descriptor;
			}
		}

		// Token: 0x0601526E RID: 86638 RVA: 0x00311B52 File Offset: 0x0030FD52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArchiveSaveResponse()
		{
		}

		// Token: 0x0601526F RID: 86639 RVA: 0x00311B5A File Offset: 0x0030FD5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArchiveSaveResponse(RogueArchiveSaveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.saveTime_ = other.saveTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015270 RID: 86640 RVA: 0x00311B8B File Offset: 0x0030FD8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArchiveSaveResponse Clone()
		{
			return new RogueArchiveSaveResponse(this);
		}

		// Token: 0x17004668 RID: 18024
		// (get) Token: 0x06015271 RID: 86641 RVA: 0x00311B93 File Offset: 0x0030FD93
		// (set) Token: 0x06015272 RID: 86642 RVA: 0x00311B9B File Offset: 0x0030FD9B
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

		// Token: 0x17004669 RID: 18025
		// (get) Token: 0x06015273 RID: 86643 RVA: 0x00311BA4 File Offset: 0x0030FDA4
		// (set) Token: 0x06015274 RID: 86644 RVA: 0x00311BAC File Offset: 0x0030FDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SaveTime
		{
			get
			{
				return this.saveTime_;
			}
			set
			{
				this.saveTime_ = value;
			}
		}

		// Token: 0x06015275 RID: 86645 RVA: 0x00311BB5 File Offset: 0x0030FDB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueArchiveSaveResponse);
		}

		// Token: 0x06015276 RID: 86646 RVA: 0x00311BC3 File Offset: 0x0030FDC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueArchiveSaveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.SaveTime == other.SaveTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015277 RID: 86647 RVA: 0x00311C04 File Offset: 0x0030FE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.SaveTime != 0L)
			{
				num ^= this.SaveTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015278 RID: 86648 RVA: 0x00311C62 File Offset: 0x0030FE62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015279 RID: 86649 RVA: 0x00311C6F File Offset: 0x0030FE6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601527A RID: 86650 RVA: 0x00311C78 File Offset: 0x0030FE78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SaveTime != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.SaveTime);
			}
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

		// Token: 0x0601527B RID: 86651 RVA: 0x00311CD4 File Offset: 0x0030FED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.SaveTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SaveTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601527C RID: 86652 RVA: 0x00311D2C File Offset: 0x0030FF2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueArchiveSaveResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.SaveTime != 0L)
			{
				this.SaveTime = other.SaveTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601527D RID: 86653 RVA: 0x00311D7C File Offset: 0x0030FF7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601527E RID: 86654 RVA: 0x00311D88 File Offset: 0x0030FF88
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
				if (num != 72U)
				{
					if (num != 120U)
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
					this.SaveTime = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007FAE RID: 32686
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007FAF RID: 32687
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04007FB0 RID: 32688
		private ErrorCode errorCode_;

		// Token: 0x04007FB1 RID: 32689
		public const int SaveTimeFieldNumber = 9;

		// Token: 0x04007FB2 RID: 32690
		private long saveTime_;
	}
}
