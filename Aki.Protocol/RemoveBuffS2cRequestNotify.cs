using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EE3 RID: 3811
	[NetMessage(EMessageId.RemoveBuffS2cRequestNotify)]
	public sealed class RemoveBuffS2cRequestNotify : IMessage<RemoveBuffS2cRequestNotify>, IMessage, IEquatable<RemoveBuffS2cRequestNotify>, IDeepCloneable<RemoveBuffS2cRequestNotify>, IBufferMessage
	{
		// Token: 0x06014737 RID: 83767 RVA: 0x002F9639 File Offset: 0x002F7839
		[NullableContext(1)]
		public static RemoveBuffS2cRequestNotify Create()
		{
			return new RemoveBuffS2cRequestNotify();
		}

		// Token: 0x17004409 RID: 17417
		// (get) Token: 0x06014738 RID: 83768 RVA: 0x002F9640 File Offset: 0x002F7840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700440A RID: 17418
		// (get) Token: 0x06014739 RID: 83769 RVA: 0x002F9643 File Offset: 0x002F7843
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveBuffS2cRequestNotify.Descriptor;
			}
		}

		// Token: 0x0601473A RID: 83770 RVA: 0x002F964A File Offset: 0x002F784A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveBuffS2cRequestNotify()
		{
		}

		// Token: 0x0601473B RID: 83771 RVA: 0x002F9654 File Offset: 0x002F7854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveBuffS2cRequestNotify(RemoveBuffS2cRequestNotify other) : this()
		{
			this.handle_ = other.handle_;
			this.stackCount_ = other.stackCount_;
			this.reason_ = other.reason_;
			this.instigatorId_ = other.instigatorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601473C RID: 83772 RVA: 0x002F96A8 File Offset: 0x002F78A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveBuffS2cRequestNotify Clone()
		{
			return new RemoveBuffS2cRequestNotify(this);
		}

		// Token: 0x1700440B RID: 17419
		// (get) Token: 0x0601473D RID: 83773 RVA: 0x002F96B0 File Offset: 0x002F78B0
		// (set) Token: 0x0601473E RID: 83774 RVA: 0x002F96B8 File Offset: 0x002F78B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Handle
		{
			get
			{
				return this.handle_;
			}
			set
			{
				this.handle_ = value;
			}
		}

		// Token: 0x1700440C RID: 17420
		// (get) Token: 0x0601473F RID: 83775 RVA: 0x002F96C1 File Offset: 0x002F78C1
		// (set) Token: 0x06014740 RID: 83776 RVA: 0x002F96C9 File Offset: 0x002F78C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StackCount
		{
			get
			{
				return this.stackCount_;
			}
			set
			{
				this.stackCount_ = value;
			}
		}

		// Token: 0x1700440D RID: 17421
		// (get) Token: 0x06014741 RID: 83777 RVA: 0x002F96D2 File Offset: 0x002F78D2
		// (set) Token: 0x06014742 RID: 83778 RVA: 0x002F96DA File Offset: 0x002F78DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x1700440E RID: 17422
		// (get) Token: 0x06014743 RID: 83779 RVA: 0x002F96E3 File Offset: 0x002F78E3
		// (set) Token: 0x06014744 RID: 83780 RVA: 0x002F96EB File Offset: 0x002F78EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long InstigatorId
		{
			get
			{
				return this.instigatorId_;
			}
			set
			{
				this.instigatorId_ = value;
			}
		}

		// Token: 0x06014745 RID: 83781 RVA: 0x002F96F4 File Offset: 0x002F78F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveBuffS2cRequestNotify);
		}

		// Token: 0x06014746 RID: 83782 RVA: 0x002F9704 File Offset: 0x002F7904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveBuffS2cRequestNotify other)
		{
			return other != null && (other == this || (this.Handle == other.Handle && this.StackCount == other.StackCount && this.Reason == other.Reason && this.InstigatorId == other.InstigatorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014747 RID: 83783 RVA: 0x002F9770 File Offset: 0x002F7970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Handle != 0)
			{
				num ^= this.Handle.GetHashCode();
			}
			if (this.StackCount != 0)
			{
				num ^= this.StackCount.GetHashCode();
			}
			if (this.Reason != 0)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this.InstigatorId != 0L)
			{
				num ^= this.InstigatorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014748 RID: 83784 RVA: 0x002F97FA File Offset: 0x002F79FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014749 RID: 83785 RVA: 0x002F9807 File Offset: 0x002F7A07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601474A RID: 83786 RVA: 0x002F9810 File Offset: 0x002F7A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StackCount != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.StackCount);
			}
			if (this.Handle != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Handle);
			}
			if (this.Reason != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Reason);
			}
			if (this.InstigatorId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.InstigatorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601474B RID: 83787 RVA: 0x002F98A0 File Offset: 0x002F7AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Handle != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Handle);
			}
			if (this.StackCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StackCount);
			}
			if (this.Reason != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Reason);
			}
			if (this.InstigatorId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.InstigatorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601474C RID: 83788 RVA: 0x002F9928 File Offset: 0x002F7B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveBuffS2cRequestNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Handle != 0)
			{
				this.Handle = other.Handle;
			}
			if (other.StackCount != 0)
			{
				this.StackCount = other.StackCount;
			}
			if (other.Reason != 0)
			{
				this.Reason = other.Reason;
			}
			if (other.InstigatorId != 0L)
			{
				this.InstigatorId = other.InstigatorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601474D RID: 83789 RVA: 0x002F99A0 File Offset: 0x002F7BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601474E RID: 83790 RVA: 0x002F99AC File Offset: 0x002F7BAC
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
				if (num <= 72U)
				{
					if (num == 8U)
					{
						this.StackCount = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.Handle = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.Reason = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.InstigatorId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007C83 RID: 31875
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C84 RID: 31876
		public const int HandleFieldNumber = 9;

		// Token: 0x04007C85 RID: 31877
		private int handle_;

		// Token: 0x04007C86 RID: 31878
		public const int StackCountFieldNumber = 1;

		// Token: 0x04007C87 RID: 31879
		private int stackCount_;

		// Token: 0x04007C88 RID: 31880
		public const int ReasonFieldNumber = 11;

		// Token: 0x04007C89 RID: 31881
		private int reason_;

		// Token: 0x04007C8A RID: 31882
		public const int InstigatorIdFieldNumber = 15;

		// Token: 0x04007C8B RID: 31883
		private long instigatorId_;
	}
}
