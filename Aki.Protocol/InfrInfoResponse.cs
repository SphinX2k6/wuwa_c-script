using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007DF RID: 2015
	[NetMessage(EMessageId.InfrInfoResponse)]
	public sealed class InfrInfoResponse : IMessage<InfrInfoResponse>, IMessage, IEquatable<InfrInfoResponse>, IDeepCloneable<InfrInfoResponse>, IBufferMessage
	{
		// Token: 0x0600B4E6 RID: 46310 RVA: 0x001B0486 File Offset: 0x001AE686
		[NullableContext(1)]
		public static InfrInfoResponse Create()
		{
			return new InfrInfoResponse();
		}

		// Token: 0x1700247B RID: 9339
		// (get) Token: 0x0600B4E7 RID: 46311 RVA: 0x001B048D File Offset: 0x001AE68D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700247C RID: 9340
		// (get) Token: 0x0600B4E8 RID: 46312 RVA: 0x001B0490 File Offset: 0x001AE690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600B4E9 RID: 46313 RVA: 0x001B0497 File Offset: 0x001AE697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrInfoResponse()
		{
		}

		// Token: 0x0600B4EA RID: 46314 RVA: 0x001B04A0 File Offset: 0x001AE6A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrInfoResponse(InfrInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.infrInfo_ = ((other.infrInfo_ != null) ? other.infrInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B4EB RID: 46315 RVA: 0x001B04EC File Offset: 0x001AE6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrInfoResponse Clone()
		{
			return new InfrInfoResponse(this);
		}

		// Token: 0x1700247D RID: 9341
		// (get) Token: 0x0600B4EC RID: 46316 RVA: 0x001B04F4 File Offset: 0x001AE6F4
		// (set) Token: 0x0600B4ED RID: 46317 RVA: 0x001B04FC File Offset: 0x001AE6FC
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

		// Token: 0x1700247E RID: 9342
		// (get) Token: 0x0600B4EE RID: 46318 RVA: 0x001B0505 File Offset: 0x001AE705
		// (set) Token: 0x0600B4EF RID: 46319 RVA: 0x001B050D File Offset: 0x001AE70D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrPb InfrInfo
		{
			get
			{
				return this.infrInfo_;
			}
			set
			{
				this.infrInfo_ = value;
			}
		}

		// Token: 0x0600B4F0 RID: 46320 RVA: 0x001B0516 File Offset: 0x001AE716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrInfoResponse);
		}

		// Token: 0x0600B4F1 RID: 46321 RVA: 0x001B0524 File Offset: 0x001AE724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.InfrInfo, other.InfrInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B4F2 RID: 46322 RVA: 0x001B0574 File Offset: 0x001AE774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.infrInfo_ != null)
			{
				num ^= this.InfrInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B4F3 RID: 46323 RVA: 0x001B05CF File Offset: 0x001AE7CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B4F4 RID: 46324 RVA: 0x001B05DC File Offset: 0x001AE7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B4F5 RID: 46325 RVA: 0x001B05E8 File Offset: 0x001AE7E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.infrInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.InfrInfo);
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

		// Token: 0x0600B4F6 RID: 46326 RVA: 0x001B0644 File Offset: 0x001AE844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.infrInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.InfrInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B4F7 RID: 46327 RVA: 0x001B069C File Offset: 0x001AE89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.infrInfo_ != null)
			{
				if (this.infrInfo_ == null)
				{
					this.InfrInfo = new InfrPb();
				}
				this.InfrInfo.MergeFrom(other.InfrInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B4F8 RID: 46328 RVA: 0x001B0704 File Offset: 0x001AE904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B4F9 RID: 46329 RVA: 0x001B0710 File Offset: 0x001AE910
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
					if (this.infrInfo_ == null)
					{
						this.InfrInfo = new InfrPb();
					}
					input.ReadMessage(this.InfrInfo);
				}
			}
		}

		// Token: 0x04005064 RID: 20580
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005065 RID: 20581
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04005066 RID: 20582
		private ErrorCode errorCode_;

		// Token: 0x04005067 RID: 20583
		public const int InfrInfoFieldNumber = 2;

		// Token: 0x04005068 RID: 20584
		private InfrPb infrInfo_;
	}
}
