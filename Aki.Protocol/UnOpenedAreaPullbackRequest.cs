using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001503 RID: 5379
	[NetMessage(EMessageId.UnOpenedAreaPullbackRequest)]
	public sealed class UnOpenedAreaPullbackRequest : IMessage<UnOpenedAreaPullbackRequest>, IMessage, IEquatable<UnOpenedAreaPullbackRequest>, IDeepCloneable<UnOpenedAreaPullbackRequest>, IBufferMessage
	{
		// Token: 0x0601C822 RID: 116770 RVA: 0x00422090 File Offset: 0x00420290
		[NullableContext(1)]
		public static UnOpenedAreaPullbackRequest Create()
		{
			return new UnOpenedAreaPullbackRequest();
		}

		// Token: 0x17006074 RID: 24692
		// (get) Token: 0x0601C823 RID: 116771 RVA: 0x00422097 File Offset: 0x00420297
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006075 RID: 24693
		// (get) Token: 0x0601C824 RID: 116772 RVA: 0x0042209A File Offset: 0x0042029A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnOpenedAreaPullbackRequest.Descriptor;
			}
		}

		// Token: 0x0601C825 RID: 116773 RVA: 0x004220A1 File Offset: 0x004202A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnOpenedAreaPullbackRequest()
		{
		}

		// Token: 0x0601C826 RID: 116774 RVA: 0x004220A9 File Offset: 0x004202A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnOpenedAreaPullbackRequest(UnOpenedAreaPullbackRequest other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.reason_ = other.reason_;
			this.transferEffectId_ = other.transferEffectId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C827 RID: 116775 RVA: 0x004220E6 File Offset: 0x004202E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnOpenedAreaPullbackRequest Clone()
		{
			return new UnOpenedAreaPullbackRequest(this);
		}

		// Token: 0x17006076 RID: 24694
		// (get) Token: 0x0601C828 RID: 116776 RVA: 0x004220EE File Offset: 0x004202EE
		// (set) Token: 0x0601C829 RID: 116777 RVA: 0x00422106 File Offset: 0x00420306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportReason Reason
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.reason_;
				}
				return UnOpenedAreaPullbackRequest.ReasonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.reason_ = value;
			}
		}

		// Token: 0x17006077 RID: 24695
		// (get) Token: 0x0601C82A RID: 116778 RVA: 0x0042211D File Offset: 0x0042031D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasReason
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0601C82B RID: 116779 RVA: 0x0042212A File Offset: 0x0042032A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearReason()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17006078 RID: 24696
		// (get) Token: 0x0601C82C RID: 116780 RVA: 0x0042213B File Offset: 0x0042033B
		// (set) Token: 0x0601C82D RID: 116781 RVA: 0x00422153 File Offset: 0x00420353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TransferEffectId
		{
			get
			{
				if ((this._hasBits0 & 2) != 0)
				{
					return this.transferEffectId_;
				}
				return UnOpenedAreaPullbackRequest.TransferEffectIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.transferEffectId_ = value;
			}
		}

		// Token: 0x17006079 RID: 24697
		// (get) Token: 0x0601C82E RID: 116782 RVA: 0x0042216A File Offset: 0x0042036A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasTransferEffectId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0601C82F RID: 116783 RVA: 0x00422177 File Offset: 0x00420377
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearTransferEffectId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0601C830 RID: 116784 RVA: 0x00422188 File Offset: 0x00420388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnOpenedAreaPullbackRequest);
		}

		// Token: 0x0601C831 RID: 116785 RVA: 0x00422196 File Offset: 0x00420396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnOpenedAreaPullbackRequest other)
		{
			return other != null && (other == this || (this.Reason == other.Reason && this.TransferEffectId == other.TransferEffectId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C832 RID: 116786 RVA: 0x004221D4 File Offset: 0x004203D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HasReason)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this.HasTransferEffectId)
			{
				num ^= this.TransferEffectId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C833 RID: 116787 RVA: 0x00422232 File Offset: 0x00420432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C834 RID: 116788 RVA: 0x0042223F File Offset: 0x0042043F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C835 RID: 116789 RVA: 0x00422248 File Offset: 0x00420448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasReason)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Reason);
			}
			if (this.HasTransferEffectId)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TransferEffectId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C836 RID: 116790 RVA: 0x004222A4 File Offset: 0x004204A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HasReason)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			if (this.HasTransferEffectId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TransferEffectId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C837 RID: 116791 RVA: 0x004222FC File Offset: 0x004204FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnOpenedAreaPullbackRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HasReason)
			{
				this.Reason = other.Reason;
			}
			if (other.HasTransferEffectId)
			{
				this.TransferEffectId = other.TransferEffectId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C838 RID: 116792 RVA: 0x0042234C File Offset: 0x0042054C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C839 RID: 116793 RVA: 0x00422358 File Offset: 0x00420558
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
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TransferEffectId = input.ReadInt32();
					}
				}
				else
				{
					this.Reason = (TeleportReason)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A46F RID: 42095
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A470 RID: 42096
		private int _hasBits0;

		// Token: 0x0400A471 RID: 42097
		public const int ReasonFieldNumber = 2;

		// Token: 0x0400A472 RID: 42098
		private static readonly TeleportReason ReasonDefaultValue;

		// Token: 0x0400A473 RID: 42099
		private TeleportReason reason_;

		// Token: 0x0400A474 RID: 42100
		public const int TransferEffectIdFieldNumber = 4;

		// Token: 0x0400A475 RID: 42101
		private static readonly int TransferEffectIdDefaultValue;

		// Token: 0x0400A476 RID: 42102
		private int transferEffectId_;
	}
}
