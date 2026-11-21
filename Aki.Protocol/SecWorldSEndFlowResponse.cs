using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011F3 RID: 4595
	[NetMessage(EMessageId.SecWorldSEndFlowResponse)]
	public sealed class SecWorldSEndFlowResponse : IMessage<SecWorldSEndFlowResponse>, IMessage, IEquatable<SecWorldSEndFlowResponse>, IDeepCloneable<SecWorldSEndFlowResponse>, IBufferMessage
	{
		// Token: 0x060188FD RID: 100605 RVA: 0x00395555 File Offset: 0x00393755
		[NullableContext(1)]
		public static SecWorldSEndFlowResponse Create()
		{
			return new SecWorldSEndFlowResponse();
		}

		// Token: 0x170052FB RID: 21243
		// (get) Token: 0x060188FE RID: 100606 RVA: 0x0039555C File Offset: 0x0039375C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170052FC RID: 21244
		// (get) Token: 0x060188FF RID: 100607 RVA: 0x0039555F File Offset: 0x0039375F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SecWorldSEndFlowResponse.Descriptor;
			}
		}

		// Token: 0x06018900 RID: 100608 RVA: 0x00395566 File Offset: 0x00393766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecWorldSEndFlowResponse()
		{
		}

		// Token: 0x06018901 RID: 100609 RVA: 0x00395570 File Offset: 0x00393770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecWorldSEndFlowResponse(SecWorldSEndFlowResponse other) : this()
		{
			this.logId_ = other.logId_;
			this.error_ = ((other.error_ != null) ? other.error_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018902 RID: 100610 RVA: 0x003955BC File Offset: 0x003937BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecWorldSEndFlowResponse Clone()
		{
			return new SecWorldSEndFlowResponse(this);
		}

		// Token: 0x170052FD RID: 21245
		// (get) Token: 0x06018903 RID: 100611 RVA: 0x003955C4 File Offset: 0x003937C4
		// (set) Token: 0x06018904 RID: 100612 RVA: 0x003955CC File Offset: 0x003937CC
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

		// Token: 0x170052FE RID: 21246
		// (get) Token: 0x06018905 RID: 100613 RVA: 0x003955D5 File Offset: 0x003937D5
		// (set) Token: 0x06018906 RID: 100614 RVA: 0x003955DD File Offset: 0x003937DD
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

		// Token: 0x06018907 RID: 100615 RVA: 0x003955E6 File Offset: 0x003937E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SecWorldSEndFlowResponse);
		}

		// Token: 0x06018908 RID: 100616 RVA: 0x003955F4 File Offset: 0x003937F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SecWorldSEndFlowResponse other)
		{
			return other != null && (other == this || (this.LogId == other.LogId && object.Equals(this.Error, other.Error) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018909 RID: 100617 RVA: 0x00395644 File Offset: 0x00393844
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

		// Token: 0x0601890A RID: 100618 RVA: 0x00395699 File Offset: 0x00393899
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601890B RID: 100619 RVA: 0x003956A6 File Offset: 0x003938A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601890C RID: 100620 RVA: 0x003956B0 File Offset: 0x003938B0
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
				output.WriteRawTag(72);
				output.WriteInt64(this.LogId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601890D RID: 100621 RVA: 0x0039570C File Offset: 0x0039390C
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

		// Token: 0x0601890E RID: 100622 RVA: 0x00395764 File Offset: 0x00393964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SecWorldSEndFlowResponse other)
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

		// Token: 0x0601890F RID: 100623 RVA: 0x003957CC File Offset: 0x003939CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018910 RID: 100624 RVA: 0x003957D8 File Offset: 0x003939D8
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
					if (num != 72U)
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

		// Token: 0x04009227 RID: 37415
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009228 RID: 37416
		public const int LogIdFieldNumber = 9;

		// Token: 0x04009229 RID: 37417
		private long logId_;

		// Token: 0x0400922A RID: 37418
		public const int ErrorFieldNumber = 2;

		// Token: 0x0400922B RID: 37419
		private DErrorResult error_;
	}
}
