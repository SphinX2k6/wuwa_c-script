using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008F2 RID: 2290
	[NetMessage(EMessageId.LeaveWorldTeamRequest)]
	public sealed class LeaveWorldTeamRequest : IMessage<LeaveWorldTeamRequest>, IMessage, IEquatable<LeaveWorldTeamRequest>, IDeepCloneable<LeaveWorldTeamRequest>, IBufferMessage
	{
		// Token: 0x0600CA6E RID: 51822 RVA: 0x001DE0D6 File Offset: 0x001DC2D6
		[NullableContext(1)]
		public static LeaveWorldTeamRequest Create()
		{
			return new LeaveWorldTeamRequest();
		}

		// Token: 0x170028DF RID: 10463
		// (get) Token: 0x0600CA6F RID: 51823 RVA: 0x001DE0DD File Offset: 0x001DC2DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028E0 RID: 10464
		// (get) Token: 0x0600CA70 RID: 51824 RVA: 0x001DE0E0 File Offset: 0x001DC2E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveWorldTeamRequest.Descriptor;
			}
		}

		// Token: 0x0600CA71 RID: 51825 RVA: 0x001DE0E7 File Offset: 0x001DC2E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveWorldTeamRequest()
		{
		}

		// Token: 0x0600CA72 RID: 51826 RVA: 0x001DE0EF File Offset: 0x001DC2EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveWorldTeamRequest(LeaveWorldTeamRequest other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.playerId_ = other.playerId_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CA73 RID: 51827 RVA: 0x001DE12C File Offset: 0x001DC32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveWorldTeamRequest Clone()
		{
			return new LeaveWorldTeamRequest(this);
		}

		// Token: 0x170028E1 RID: 10465
		// (get) Token: 0x0600CA74 RID: 51828 RVA: 0x001DE134 File Offset: 0x001DC334
		// (set) Token: 0x0600CA75 RID: 51829 RVA: 0x001DE13C File Offset: 0x001DC33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x170028E2 RID: 10466
		// (get) Token: 0x0600CA76 RID: 51830 RVA: 0x001DE145 File Offset: 0x001DC345
		// (set) Token: 0x0600CA77 RID: 51831 RVA: 0x001DE15D File Offset: 0x001DC35D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldTeamLeaveReason Reason
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.reason_;
				}
				return LeaveWorldTeamRequest.ReasonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.reason_ = value;
			}
		}

		// Token: 0x170028E3 RID: 10467
		// (get) Token: 0x0600CA78 RID: 51832 RVA: 0x001DE174 File Offset: 0x001DC374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasReason
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600CA79 RID: 51833 RVA: 0x001DE181 File Offset: 0x001DC381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearReason()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600CA7A RID: 51834 RVA: 0x001DE192 File Offset: 0x001DC392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveWorldTeamRequest);
		}

		// Token: 0x0600CA7B RID: 51835 RVA: 0x001DE1A0 File Offset: 0x001DC3A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LeaveWorldTeamRequest other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CA7C RID: 51836 RVA: 0x001DE1E0 File Offset: 0x001DC3E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.HasReason)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CA7D RID: 51837 RVA: 0x001DE23E File Offset: 0x001DC43E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CA7E RID: 51838 RVA: 0x001DE24B File Offset: 0x001DC44B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CA7F RID: 51839 RVA: 0x001DE254 File Offset: 0x001DC454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasReason)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.Reason);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CA80 RID: 51840 RVA: 0x001DE2B0 File Offset: 0x001DC4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.HasReason)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CA81 RID: 51841 RVA: 0x001DE308 File Offset: 0x001DC508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LeaveWorldTeamRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.HasReason)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CA82 RID: 51842 RVA: 0x001DE358 File Offset: 0x001DC558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CA83 RID: 51843 RVA: 0x001DE364 File Offset: 0x001DC564
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
				if (num != 56U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PlayerId = input.ReadInt32();
					}
				}
				else
				{
					this.Reason = (WorldTeamLeaveReason)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005626 RID: 22054
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005627 RID: 22055
		private int _hasBits0;

		// Token: 0x04005628 RID: 22056
		public const int PlayerIdFieldNumber = 10;

		// Token: 0x04005629 RID: 22057
		private int playerId_;

		// Token: 0x0400562A RID: 22058
		public const int ReasonFieldNumber = 7;

		// Token: 0x0400562B RID: 22059
		private static readonly WorldTeamLeaveReason ReasonDefaultValue;

		// Token: 0x0400562C RID: 22060
		private WorldTeamLeaveReason reason_;
	}
}
