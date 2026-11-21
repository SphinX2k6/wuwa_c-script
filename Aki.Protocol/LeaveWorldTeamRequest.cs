using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008E1 RID: 2273
	[NetMessage(EMessageId.LeaveWorldTeamRequest)]
	public sealed class LeaveWorldTeamRequest : IMessage<LeaveWorldTeamRequest>, IMessage, IEquatable<LeaveWorldTeamRequest>, IDeepCloneable<LeaveWorldTeamRequest>, IBufferMessage
	{
		// Token: 0x0600C952 RID: 51538 RVA: 0x001DBDFA File Offset: 0x001D9FFA
		[NullableContext(1)]
		public static LeaveWorldTeamRequest Create()
		{
			return new LeaveWorldTeamRequest();
		}

		// Token: 0x170028A0 RID: 10400
		// (get) Token: 0x0600C953 RID: 51539 RVA: 0x001DBE01 File Offset: 0x001DA001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028A1 RID: 10401
		// (get) Token: 0x0600C954 RID: 51540 RVA: 0x001DBE04 File Offset: 0x001DA004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveWorldTeamRequest.Descriptor;
			}
		}

		// Token: 0x0600C955 RID: 51541 RVA: 0x001DBE0B File Offset: 0x001DA00B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveWorldTeamRequest()
		{
		}

		// Token: 0x0600C956 RID: 51542 RVA: 0x001DBE13 File Offset: 0x001DA013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveWorldTeamRequest(LeaveWorldTeamRequest other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.playerId_ = other.playerId_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C957 RID: 51543 RVA: 0x001DBE50 File Offset: 0x001DA050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveWorldTeamRequest Clone()
		{
			return new LeaveWorldTeamRequest(this);
		}

		// Token: 0x170028A2 RID: 10402
		// (get) Token: 0x0600C958 RID: 51544 RVA: 0x001DBE58 File Offset: 0x001DA058
		// (set) Token: 0x0600C959 RID: 51545 RVA: 0x001DBE60 File Offset: 0x001DA060
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

		// Token: 0x170028A3 RID: 10403
		// (get) Token: 0x0600C95A RID: 51546 RVA: 0x001DBE69 File Offset: 0x001DA069
		// (set) Token: 0x0600C95B RID: 51547 RVA: 0x001DBE81 File Offset: 0x001DA081
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

		// Token: 0x170028A4 RID: 10404
		// (get) Token: 0x0600C95C RID: 51548 RVA: 0x001DBE98 File Offset: 0x001DA098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasReason
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600C95D RID: 51549 RVA: 0x001DBEA5 File Offset: 0x001DA0A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearReason()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600C95E RID: 51550 RVA: 0x001DBEB6 File Offset: 0x001DA0B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveWorldTeamRequest);
		}

		// Token: 0x0600C95F RID: 51551 RVA: 0x001DBEC4 File Offset: 0x001DA0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LeaveWorldTeamRequest other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C960 RID: 51552 RVA: 0x001DBF04 File Offset: 0x001DA104
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

		// Token: 0x0600C961 RID: 51553 RVA: 0x001DBF62 File Offset: 0x001DA162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C962 RID: 51554 RVA: 0x001DBF6F File Offset: 0x001DA16F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C963 RID: 51555 RVA: 0x001DBF78 File Offset: 0x001DA178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.PlayerId);
			}
			if (this.HasReason)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C964 RID: 51556 RVA: 0x001DBFD4 File Offset: 0x001DA1D4
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

		// Token: 0x0600C965 RID: 51557 RVA: 0x001DC02C File Offset: 0x001DA22C
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

		// Token: 0x0600C966 RID: 51558 RVA: 0x001DC07C File Offset: 0x001DA27C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C967 RID: 51559 RVA: 0x001DC088 File Offset: 0x001DA288
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
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Reason = (WorldTeamLeaveReason)input.ReadEnum();
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400562D RID: 22061
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400562E RID: 22062
		private int _hasBits0;

		// Token: 0x0400562F RID: 22063
		public const int PlayerIdFieldNumber = 7;

		// Token: 0x04005630 RID: 22064
		private int playerId_;

		// Token: 0x04005631 RID: 22065
		public const int ReasonFieldNumber = 13;

		// Token: 0x04005632 RID: 22066
		private static readonly WorldTeamLeaveReason ReasonDefaultValue;

		// Token: 0x04005633 RID: 22067
		private WorldTeamLeaveReason reason_;
	}
}
