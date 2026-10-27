using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003DF RID: 991
	[NetMessage(EMessageId.DiscardWeaponRequest)]
	public sealed class DiscardWeaponRequest : IMessage<DiscardWeaponRequest>, IMessage, IEquatable<DiscardWeaponRequest>, IDeepCloneable<DiscardWeaponRequest>, IBufferMessage
	{
		// Token: 0x06006067 RID: 24679 RVA: 0x000E91C7 File Offset: 0x000E73C7
		[NullableContext(1)]
		public static DiscardWeaponRequest Create()
		{
			return new DiscardWeaponRequest();
		}

		// Token: 0x170011F6 RID: 4598
		// (get) Token: 0x06006068 RID: 24680 RVA: 0x000E91CE File Offset: 0x000E73CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011F7 RID: 4599
		// (get) Token: 0x06006069 RID: 24681 RVA: 0x000E91D1 File Offset: 0x000E73D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DiscardWeaponRequest.Descriptor;
			}
		}

		// Token: 0x0600606A RID: 24682 RVA: 0x000E91D8 File Offset: 0x000E73D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DiscardWeaponRequest()
		{
		}

		// Token: 0x0600606B RID: 24683 RVA: 0x000E91E0 File Offset: 0x000E73E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DiscardWeaponRequest(DiscardWeaponRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.movementInformation_ = ((other.movementInformation_ != null) ? other.movementInformation_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600606C RID: 24684 RVA: 0x000E922C File Offset: 0x000E742C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DiscardWeaponRequest Clone()
		{
			return new DiscardWeaponRequest(this);
		}

		// Token: 0x170011F8 RID: 4600
		// (get) Token: 0x0600606D RID: 24685 RVA: 0x000E9234 File Offset: 0x000E7434
		// (set) Token: 0x0600606E RID: 24686 RVA: 0x000E923C File Offset: 0x000E743C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x170011F9 RID: 4601
		// (get) Token: 0x0600606F RID: 24687 RVA: 0x000E9245 File Offset: 0x000E7445
		// (set) Token: 0x06006070 RID: 24688 RVA: 0x000E924D File Offset: 0x000E744D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovementInformation MovementInformation
		{
			get
			{
				return this.movementInformation_;
			}
			set
			{
				this.movementInformation_ = value;
			}
		}

		// Token: 0x06006071 RID: 24689 RVA: 0x000E9256 File Offset: 0x000E7456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DiscardWeaponRequest);
		}

		// Token: 0x06006072 RID: 24690 RVA: 0x000E9264 File Offset: 0x000E7464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DiscardWeaponRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.MovementInformation, other.MovementInformation) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006073 RID: 24691 RVA: 0x000E92B4 File Offset: 0x000E74B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.movementInformation_ != null)
			{
				num ^= this.MovementInformation.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006074 RID: 24692 RVA: 0x000E9309 File Offset: 0x000E7509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006075 RID: 24693 RVA: 0x000E9316 File Offset: 0x000E7516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006076 RID: 24694 RVA: 0x000E9320 File Offset: 0x000E7520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.EntityId);
			}
			if (this.movementInformation_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.MovementInformation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006077 RID: 24695 RVA: 0x000E937C File Offset: 0x000E757C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.movementInformation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MovementInformation);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006078 RID: 24696 RVA: 0x000E93D4 File Offset: 0x000E75D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DiscardWeaponRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.movementInformation_ != null)
			{
				if (this.movementInformation_ == null)
				{
					this.MovementInformation = new MovementInformation();
				}
				this.MovementInformation.MergeFrom(other.MovementInformation);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006079 RID: 24697 RVA: 0x000E943C File Offset: 0x000E763C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600607A RID: 24698 RVA: 0x000E9448 File Offset: 0x000E7648
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
				if (num != 32U)
				{
					if (num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.movementInformation_ == null)
						{
							this.MovementInformation = new MovementInformation();
						}
						input.ReadMessage(this.MovementInformation);
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400375F RID: 14175
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003760 RID: 14176
		public const int EntityIdFieldNumber = 4;

		// Token: 0x04003761 RID: 14177
		private long entityId_;

		// Token: 0x04003762 RID: 14178
		public const int MovementInformationFieldNumber = 7;

		// Token: 0x04003763 RID: 14179
		private MovementInformation movementInformation_;
	}
}
