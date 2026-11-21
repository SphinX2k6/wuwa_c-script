using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005DC RID: 1500
	[NetMessage(EMessageId.FloroRanchWeeklyResponse)]
	public sealed class FloroRanchWeeklyResponse : IMessage<FloroRanchWeeklyResponse>, IMessage, IEquatable<FloroRanchWeeklyResponse>, IDeepCloneable<FloroRanchWeeklyResponse>, IBufferMessage
	{
		// Token: 0x06008B6A RID: 35690 RVA: 0x00152CFE File Offset: 0x00150EFE
		[NullableContext(1)]
		public static FloroRanchWeeklyResponse Create()
		{
			return new FloroRanchWeeklyResponse();
		}

		// Token: 0x17001B99 RID: 7065
		// (get) Token: 0x06008B6B RID: 35691 RVA: 0x00152D05 File Offset: 0x00150F05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B9A RID: 7066
		// (get) Token: 0x06008B6C RID: 35692 RVA: 0x00152D08 File Offset: 0x00150F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchWeeklyResponse.Descriptor;
			}
		}

		// Token: 0x06008B6D RID: 35693 RVA: 0x00152D0F File Offset: 0x00150F0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchWeeklyResponse()
		{
		}

		// Token: 0x06008B6E RID: 35694 RVA: 0x00152D18 File Offset: 0x00150F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchWeeklyResponse(FloroRanchWeeklyResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this.playerInfo_ = ((other.playerInfo_ != null) ? other.playerInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008B6F RID: 35695 RVA: 0x00152D7C File Offset: 0x00150F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchWeeklyResponse Clone()
		{
			return new FloroRanchWeeklyResponse(this);
		}

		// Token: 0x17001B9B RID: 7067
		// (get) Token: 0x06008B70 RID: 35696 RVA: 0x00152D84 File Offset: 0x00150F84
		// (set) Token: 0x06008B71 RID: 35697 RVA: 0x00152D8C File Offset: 0x00150F8C
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

		// Token: 0x17001B9C RID: 7068
		// (get) Token: 0x06008B72 RID: 35698 RVA: 0x00152D95 File Offset: 0x00150F95
		// (set) Token: 0x06008B73 RID: 35699 RVA: 0x00152D9D File Offset: 0x00150F9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17001B9D RID: 7069
		// (get) Token: 0x06008B74 RID: 35700 RVA: 0x00152DA6 File Offset: 0x00150FA6
		// (set) Token: 0x06008B75 RID: 35701 RVA: 0x00152DAE File Offset: 0x00150FAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubInsId
		{
			get
			{
				return this.subInsId_;
			}
			set
			{
				this.subInsId_ = value;
			}
		}

		// Token: 0x17001B9E RID: 7070
		// (get) Token: 0x06008B76 RID: 35702 RVA: 0x00152DB7 File Offset: 0x00150FB7
		// (set) Token: 0x06008B77 RID: 35703 RVA: 0x00152DBF File Offset: 0x00150FBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayerInfo PlayerInfo
		{
			get
			{
				return this.playerInfo_;
			}
			set
			{
				this.playerInfo_ = value;
			}
		}

		// Token: 0x06008B78 RID: 35704 RVA: 0x00152DC8 File Offset: 0x00150FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchWeeklyResponse);
		}

		// Token: 0x06008B79 RID: 35705 RVA: 0x00152DD8 File Offset: 0x00150FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchWeeklyResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && object.Equals(this.PlayerInfo, other.PlayerInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008B7A RID: 35706 RVA: 0x00152E48 File Offset: 0x00151048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.SubInsId != 0)
			{
				num ^= this.SubInsId.GetHashCode();
			}
			if (this.playerInfo_ != null)
			{
				num ^= this.PlayerInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008B7B RID: 35707 RVA: 0x00152ED5 File Offset: 0x001510D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008B7C RID: 35708 RVA: 0x00152EE2 File Offset: 0x001510E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008B7D RID: 35709 RVA: 0x00152EEC File Offset: 0x001510EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SubInsId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ActivityId);
			}
			if (this.playerInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.PlayerInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008B7E RID: 35710 RVA: 0x00152F80 File Offset: 0x00151180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.SubInsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubInsId);
			}
			if (this.playerInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PlayerInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008B7F RID: 35711 RVA: 0x00153008 File Offset: 0x00151208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchWeeklyResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.SubInsId != 0)
			{
				this.SubInsId = other.SubInsId;
			}
			if (other.playerInfo_ != null)
			{
				if (this.playerInfo_ == null)
				{
					this.PlayerInfo = new FloroRanchPlayerInfo();
				}
				this.PlayerInfo.MergeFrom(other.PlayerInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008B80 RID: 35712 RVA: 0x00153098 File Offset: 0x00151298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008B81 RID: 35713 RVA: 0x001530A4 File Offset: 0x001512A4
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
				if (num <= 64U)
				{
					if (num == 16U)
					{
						this.SubInsId = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
					if (num == 122U)
					{
						if (this.playerInfo_ == null)
						{
							this.PlayerInfo = new FloroRanchPlayerInfo();
						}
						input.ReadMessage(this.PlayerInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040044D0 RID: 17616
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044D1 RID: 17617
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x040044D2 RID: 17618
		private ErrorCode errorCode_;

		// Token: 0x040044D3 RID: 17619
		public const int ActivityIdFieldNumber = 9;

		// Token: 0x040044D4 RID: 17620
		private int activityId_;

		// Token: 0x040044D5 RID: 17621
		public const int SubInsIdFieldNumber = 2;

		// Token: 0x040044D6 RID: 17622
		private int subInsId_;

		// Token: 0x040044D7 RID: 17623
		public const int PlayerInfoFieldNumber = 15;

		// Token: 0x040044D8 RID: 17624
		private FloroRanchPlayerInfo playerInfo_;
	}
}
