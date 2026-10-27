using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000833 RID: 2099
	[NetMessage(EMessageId.InteractiveUpdateResponse)]
	public sealed class InteractiveUpdateResponse : IMessage<InteractiveUpdateResponse>, IMessage, IEquatable<InteractiveUpdateResponse>, IDeepCloneable<InteractiveUpdateResponse>, IBufferMessage
	{
		// Token: 0x0600BB8E RID: 48014 RVA: 0x001BEB41 File Offset: 0x001BCD41
		[NullableContext(1)]
		public static InteractiveUpdateResponse Create()
		{
			return new InteractiveUpdateResponse();
		}

		// Token: 0x170025E0 RID: 9696
		// (get) Token: 0x0600BB8F RID: 48015 RVA: 0x001BEB48 File Offset: 0x001BCD48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025E1 RID: 9697
		// (get) Token: 0x0600BB90 RID: 48016 RVA: 0x001BEB4B File Offset: 0x001BCD4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InteractiveUpdateResponse.Descriptor;
			}
		}

		// Token: 0x0600BB91 RID: 48017 RVA: 0x001BEB52 File Offset: 0x001BCD52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractiveUpdateResponse()
		{
		}

		// Token: 0x0600BB92 RID: 48018 RVA: 0x001BEB5A File Offset: 0x001BCD5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractiveUpdateResponse(InteractiveUpdateResponse other) : this()
		{
			this.code_ = other.code_;
			this.interactiveId_ = other.interactiveId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BB93 RID: 48019 RVA: 0x001BEB8B File Offset: 0x001BCD8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractiveUpdateResponse Clone()
		{
			return new InteractiveUpdateResponse(this);
		}

		// Token: 0x170025E2 RID: 9698
		// (get) Token: 0x0600BB94 RID: 48020 RVA: 0x001BEB93 File Offset: 0x001BCD93
		// (set) Token: 0x0600BB95 RID: 48021 RVA: 0x001BEB9B File Offset: 0x001BCD9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x170025E3 RID: 9699
		// (get) Token: 0x0600BB96 RID: 48022 RVA: 0x001BEBA4 File Offset: 0x001BCDA4
		// (set) Token: 0x0600BB97 RID: 48023 RVA: 0x001BEBAC File Offset: 0x001BCDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InteractiveId
		{
			get
			{
				return this.interactiveId_;
			}
			set
			{
				this.interactiveId_ = value;
			}
		}

		// Token: 0x0600BB98 RID: 48024 RVA: 0x001BEBB5 File Offset: 0x001BCDB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InteractiveUpdateResponse);
		}

		// Token: 0x0600BB99 RID: 48025 RVA: 0x001BEBC3 File Offset: 0x001BCDC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InteractiveUpdateResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.InteractiveId == other.InteractiveId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BB9A RID: 48026 RVA: 0x001BEC04 File Offset: 0x001BCE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.InteractiveId != 0)
			{
				num ^= this.InteractiveId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BB9B RID: 48027 RVA: 0x001BEC62 File Offset: 0x001BCE62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BB9C RID: 48028 RVA: 0x001BEC6F File Offset: 0x001BCE6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BB9D RID: 48029 RVA: 0x001BEC78 File Offset: 0x001BCE78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InteractiveId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.InteractiveId);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BB9E RID: 48030 RVA: 0x001BECD4 File Offset: 0x001BCED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.InteractiveId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InteractiveId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BB9F RID: 48031 RVA: 0x001BED2C File Offset: 0x001BCF2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InteractiveUpdateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.InteractiveId != 0)
			{
				this.InteractiveId = other.InteractiveId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BBA0 RID: 48032 RVA: 0x001BED7C File Offset: 0x001BCF7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BBA1 RID: 48033 RVA: 0x001BED88 File Offset: 0x001BCF88
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
				if (num != 16U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Code = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.InteractiveId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400524E RID: 21070
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400524F RID: 21071
		public const int CodeFieldNumber = 9;

		// Token: 0x04005250 RID: 21072
		private ErrorCode code_;

		// Token: 0x04005251 RID: 21073
		public const int InteractiveIdFieldNumber = 2;

		// Token: 0x04005252 RID: 21074
		private int interactiveId_;
	}
}
