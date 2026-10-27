using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011AD RID: 4525
	[NetMessage(EMessageId.SecFBRoundEndFlowReportResponse)]
	public sealed class SecFBRoundEndFlowReportResponse : IMessage<SecFBRoundEndFlowReportResponse>, IMessage, IEquatable<SecFBRoundEndFlowReportResponse>, IDeepCloneable<SecFBRoundEndFlowReportResponse>, IBufferMessage
	{
		// Token: 0x060181E9 RID: 98793 RVA: 0x00381290 File Offset: 0x0037F490
		[NullableContext(1)]
		public static SecFBRoundEndFlowReportResponse Create()
		{
			return new SecFBRoundEndFlowReportResponse();
		}

		// Token: 0x1700511D RID: 20765
		// (get) Token: 0x060181EA RID: 98794 RVA: 0x00381297 File Offset: 0x0037F497
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700511E RID: 20766
		// (get) Token: 0x060181EB RID: 98795 RVA: 0x0038129A File Offset: 0x0037F49A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SecFBRoundEndFlowReportResponse.Descriptor;
			}
		}

		// Token: 0x060181EC RID: 98796 RVA: 0x003812A1 File Offset: 0x0037F4A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecFBRoundEndFlowReportResponse()
		{
		}

		// Token: 0x060181ED RID: 98797 RVA: 0x003812AC File Offset: 0x0037F4AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecFBRoundEndFlowReportResponse(SecFBRoundEndFlowReportResponse other) : this()
		{
			this.logId_ = other.logId_;
			this.error_ = ((other.error_ != null) ? other.error_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060181EE RID: 98798 RVA: 0x003812F8 File Offset: 0x0037F4F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecFBRoundEndFlowReportResponse Clone()
		{
			return new SecFBRoundEndFlowReportResponse(this);
		}

		// Token: 0x1700511F RID: 20767
		// (get) Token: 0x060181EF RID: 98799 RVA: 0x00381300 File Offset: 0x0037F500
		// (set) Token: 0x060181F0 RID: 98800 RVA: 0x00381308 File Offset: 0x0037F508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LogId
		{
			get
			{
				return this.logId_;
			}
			set
			{
				this.logId_ = value;
			}
		}

		// Token: 0x17005120 RID: 20768
		// (get) Token: 0x060181F1 RID: 98801 RVA: 0x00381311 File Offset: 0x0037F511
		// (set) Token: 0x060181F2 RID: 98802 RVA: 0x00381319 File Offset: 0x0037F519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DErrorResult Error
		{
			get
			{
				return this.error_;
			}
			set
			{
				this.error_ = value;
			}
		}

		// Token: 0x060181F3 RID: 98803 RVA: 0x00381322 File Offset: 0x0037F522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SecFBRoundEndFlowReportResponse);
		}

		// Token: 0x060181F4 RID: 98804 RVA: 0x00381330 File Offset: 0x0037F530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SecFBRoundEndFlowReportResponse other)
		{
			return other != null && (other == this || (this.LogId == other.LogId && object.Equals(this.Error, other.Error) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060181F5 RID: 98805 RVA: 0x00381380 File Offset: 0x0037F580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LogId != 0L)
			{
				num ^= this.LogId.GetHashCode();
			}
			if (this.error_ != null)
			{
				num ^= this.Error.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060181F6 RID: 98806 RVA: 0x003813D5 File Offset: 0x0037F5D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060181F7 RID: 98807 RVA: 0x003813E2 File Offset: 0x0037F5E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060181F8 RID: 98808 RVA: 0x003813EC File Offset: 0x0037F5EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.error_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Error);
			}
			if (this.LogId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.LogId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060181F9 RID: 98809 RVA: 0x00381448 File Offset: 0x0037F648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LogId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LogId);
			}
			if (this.error_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Error);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060181FA RID: 98810 RVA: 0x003814A0 File Offset: 0x0037F6A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SecFBRoundEndFlowReportResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LogId != 0L)
			{
				this.LogId = other.LogId;
			}
			if (other.error_ != null)
			{
				if (this.error_ == null)
				{
					this.Error = new DErrorResult();
				}
				this.Error.MergeFrom(other.Error);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060181FB RID: 98811 RVA: 0x00381508 File Offset: 0x0037F708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060181FC RID: 98812 RVA: 0x00381514 File Offset: 0x0037F714
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
				if (num != 26U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LogId = input.ReadInt64();
					}
				}
				else
				{
					if (this.error_ == null)
					{
						this.Error = new DErrorResult();
					}
					input.ReadMessage(this.Error);
				}
			}
		}

		// Token: 0x04008ED3 RID: 36563
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008ED4 RID: 36564
		public const int LogIdFieldNumber = 11;

		// Token: 0x04008ED5 RID: 36565
		private long logId_;

		// Token: 0x04008ED6 RID: 36566
		public const int ErrorFieldNumber = 3;

		// Token: 0x04008ED7 RID: 36567
		private DErrorResult error_;
	}
}
