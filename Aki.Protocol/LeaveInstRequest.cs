using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008EA RID: 2282
	[NetMessage(EMessageId.LeaveInstRequest)]
	public sealed class LeaveInstRequest : IMessage<LeaveInstRequest>, IMessage, IEquatable<LeaveInstRequest>, IDeepCloneable<LeaveInstRequest>, IBufferMessage
	{
		// Token: 0x0600C9D8 RID: 51672 RVA: 0x001DCF2C File Offset: 0x001DB12C
		[NullableContext(1)]
		public static LeaveInstRequest Create()
		{
			return new LeaveInstRequest();
		}

		// Token: 0x170028C4 RID: 10436
		// (get) Token: 0x0600C9D9 RID: 51673 RVA: 0x001DCF33 File Offset: 0x001DB133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028C5 RID: 10437
		// (get) Token: 0x0600C9DA RID: 51674 RVA: 0x001DCF36 File Offset: 0x001DB136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveInstRequest.Descriptor;
			}
		}

		// Token: 0x0600C9DB RID: 51675 RVA: 0x001DCF3D File Offset: 0x001DB13D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveInstRequest()
		{
		}

		// Token: 0x0600C9DC RID: 51676 RVA: 0x001DCF45 File Offset: 0x001DB145
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveInstRequest(LeaveInstRequest other) : this()
		{
			this.posEntityId_ = other.posEntityId_;
			this.way_ = other.way_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C9DD RID: 51677 RVA: 0x001DCF76 File Offset: 0x001DB176
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveInstRequest Clone()
		{
			return new LeaveInstRequest(this);
		}

		// Token: 0x170028C6 RID: 10438
		// (get) Token: 0x0600C9DE RID: 51678 RVA: 0x001DCF7E File Offset: 0x001DB17E
		// (set) Token: 0x0600C9DF RID: 51679 RVA: 0x001DCF86 File Offset: 0x001DB186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PosEntityId
		{
			get
			{
				return this.posEntityId_;
			}
			set
			{
				this.posEntityId_ = value;
			}
		}

		// Token: 0x170028C7 RID: 10439
		// (get) Token: 0x0600C9E0 RID: 51680 RVA: 0x001DCF8F File Offset: 0x001DB18F
		// (set) Token: 0x0600C9E1 RID: 51681 RVA: 0x001DCF97 File Offset: 0x001DB197
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveInstWay Way
		{
			get
			{
				return this.way_;
			}
			set
			{
				this.way_ = value;
			}
		}

		// Token: 0x0600C9E2 RID: 51682 RVA: 0x001DCFA0 File Offset: 0x001DB1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveInstRequest);
		}

		// Token: 0x0600C9E3 RID: 51683 RVA: 0x001DCFAE File Offset: 0x001DB1AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LeaveInstRequest other)
		{
			return other != null && (other == this || (this.PosEntityId == other.PosEntityId && this.Way == other.Way && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C9E4 RID: 51684 RVA: 0x001DCFEC File Offset: 0x001DB1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PosEntityId != 0)
			{
				num ^= this.PosEntityId.GetHashCode();
			}
			if (this.Way != LeaveInstWay.Default)
			{
				num ^= this.Way.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C9E5 RID: 51685 RVA: 0x001DD04A File Offset: 0x001DB24A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C9E6 RID: 51686 RVA: 0x001DD057 File Offset: 0x001DB257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C9E7 RID: 51687 RVA: 0x001DD060 File Offset: 0x001DB260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Way != LeaveInstWay.Default)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Way);
			}
			if (this.PosEntityId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.PosEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C9E8 RID: 51688 RVA: 0x001DD0BC File Offset: 0x001DB2BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PosEntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PosEntityId);
			}
			if (this.Way != LeaveInstWay.Default)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Way);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C9E9 RID: 51689 RVA: 0x001DD114 File Offset: 0x001DB314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LeaveInstRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PosEntityId != 0)
			{
				this.PosEntityId = other.PosEntityId;
			}
			if (other.Way != LeaveInstWay.Default)
			{
				this.Way = other.Way;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C9EA RID: 51690 RVA: 0x001DD164 File Offset: 0x001DB364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C9EB RID: 51691 RVA: 0x001DD170 File Offset: 0x001DB370
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
						this.PosEntityId = input.ReadInt32();
					}
				}
				else
				{
					this.Way = (LeaveInstWay)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005607 RID: 22023
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005608 RID: 22024
		public const int PosEntityIdFieldNumber = 9;

		// Token: 0x04005609 RID: 22025
		private int posEntityId_;

		// Token: 0x0400560A RID: 22026
		public const int WayFieldNumber = 2;

		// Token: 0x0400560B RID: 22027
		private LeaveInstWay way_;
	}
}
