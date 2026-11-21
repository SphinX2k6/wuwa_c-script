using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011E7 RID: 4583
	[NetMessage(EMessageId.SecFBRoundEndFlowReportResponse)]
	public sealed class SecFBRoundEndFlowReportResponse : IMessage<SecFBRoundEndFlowReportResponse>, IMessage, IEquatable<SecFBRoundEndFlowReportResponse>, IDeepCloneable<SecFBRoundEndFlowReportResponse>, IBufferMessage
	{
		// Token: 0x0601878A RID: 100234 RVA: 0x003905EA File Offset: 0x0038E7EA
		[NullableContext(1)]
		public static SecFBRoundEndFlowReportResponse Create()
		{
			return new SecFBRoundEndFlowReportResponse();
		}

		// Token: 0x17005289 RID: 21129
		// (get) Token: 0x0601878B RID: 100235 RVA: 0x003905F1 File Offset: 0x0038E7F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700528A RID: 21130
		// (get) Token: 0x0601878C RID: 100236 RVA: 0x003905F4 File Offset: 0x0038E7F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SecFBRoundEndFlowReportResponse.Descriptor;
			}
		}

		// Token: 0x0601878D RID: 100237 RVA: 0x003905FB File Offset: 0x0038E7FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecFBRoundEndFlowReportResponse()
		{
		}

		// Token: 0x0601878E RID: 100238 RVA: 0x00390604 File Offset: 0x0038E804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecFBRoundEndFlowReportResponse(SecFBRoundEndFlowReportResponse other) : this()
		{
			this.logId_ = other.logId_;
			this.error_ = ((other.error_ != null) ? other.error_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601878F RID: 100239 RVA: 0x00390650 File Offset: 0x0038E850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecFBRoundEndFlowReportResponse Clone()
		{
			return new SecFBRoundEndFlowReportResponse(this);
		}

		// Token: 0x1700528B RID: 21131
		// (get) Token: 0x06018790 RID: 100240 RVA: 0x00390658 File Offset: 0x0038E858
		// (set) Token: 0x06018791 RID: 100241 RVA: 0x00390660 File Offset: 0x0038E860
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

		// Token: 0x1700528C RID: 21132
		// (get) Token: 0x06018792 RID: 100242 RVA: 0x00390669 File Offset: 0x0038E869
		// (set) Token: 0x06018793 RID: 100243 RVA: 0x00390671 File Offset: 0x0038E871
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

		// Token: 0x06018794 RID: 100244 RVA: 0x0039067A File Offset: 0x0038E87A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SecFBRoundEndFlowReportResponse);
		}

		// Token: 0x06018795 RID: 100245 RVA: 0x00390688 File Offset: 0x0038E888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SecFBRoundEndFlowReportResponse other)
		{
			return other != null && (other == this || (this.LogId == other.LogId && object.Equals(this.Error, other.Error) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018796 RID: 100246 RVA: 0x003906D8 File Offset: 0x0038E8D8
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

		// Token: 0x06018797 RID: 100247 RVA: 0x0039072D File Offset: 0x0038E92D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018798 RID: 100248 RVA: 0x0039073A File Offset: 0x0038E93A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018799 RID: 100249 RVA: 0x00390744 File Offset: 0x0038E944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.error_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Error);
			}
			if (this.LogId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.LogId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601879A RID: 100250 RVA: 0x003907A0 File Offset: 0x0038E9A0
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

		// Token: 0x0601879B RID: 100251 RVA: 0x003907F8 File Offset: 0x0038E9F8
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

		// Token: 0x0601879C RID: 100252 RVA: 0x00390860 File Offset: 0x0038EA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601879D RID: 100253 RVA: 0x0039086C File Offset: 0x0038EA6C
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
				if (num != 18U)
				{
					if (num != 96U)
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

		// Token: 0x04009166 RID: 37222
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009167 RID: 37223
		public const int LogIdFieldNumber = 12;

		// Token: 0x04009168 RID: 37224
		private long logId_;

		// Token: 0x04009169 RID: 37225
		public const int ErrorFieldNumber = 2;

		// Token: 0x0400916A RID: 37226
		private DErrorResult error_;
	}
}
