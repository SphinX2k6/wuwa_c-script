using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003DE RID: 990
	[NetMessage(EMessageId.DiscardWeaponPush)]
	public sealed class DiscardWeaponPush : IMessage<DiscardWeaponPush>, IMessage, IEquatable<DiscardWeaponPush>, IDeepCloneable<DiscardWeaponPush>, IBufferMessage
	{
		// Token: 0x06006053 RID: 24659 RVA: 0x000E8ED9 File Offset: 0x000E70D9
		[NullableContext(1)]
		public static DiscardWeaponPush Create()
		{
			return new DiscardWeaponPush();
		}

		// Token: 0x170011F2 RID: 4594
		// (get) Token: 0x06006054 RID: 24660 RVA: 0x000E8EE0 File Offset: 0x000E70E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011F3 RID: 4595
		// (get) Token: 0x06006055 RID: 24661 RVA: 0x000E8EE3 File Offset: 0x000E70E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DiscardWeaponPush.Descriptor;
			}
		}

		// Token: 0x06006056 RID: 24662 RVA: 0x000E8EEA File Offset: 0x000E70EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DiscardWeaponPush()
		{
		}

		// Token: 0x06006057 RID: 24663 RVA: 0x000E8EF4 File Offset: 0x000E70F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DiscardWeaponPush(DiscardWeaponPush other) : this()
		{
			this.entityId_ = other.entityId_;
			this.movementInformation_ = ((other.movementInformation_ != null) ? other.movementInformation_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006058 RID: 24664 RVA: 0x000E8F40 File Offset: 0x000E7140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DiscardWeaponPush Clone()
		{
			return new DiscardWeaponPush(this);
		}

		// Token: 0x170011F4 RID: 4596
		// (get) Token: 0x06006059 RID: 24665 RVA: 0x000E8F48 File Offset: 0x000E7148
		// (set) Token: 0x0600605A RID: 24666 RVA: 0x000E8F50 File Offset: 0x000E7150
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

		// Token: 0x170011F5 RID: 4597
		// (get) Token: 0x0600605B RID: 24667 RVA: 0x000E8F59 File Offset: 0x000E7159
		// (set) Token: 0x0600605C RID: 24668 RVA: 0x000E8F61 File Offset: 0x000E7161
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

		// Token: 0x0600605D RID: 24669 RVA: 0x000E8F6A File Offset: 0x000E716A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DiscardWeaponPush);
		}

		// Token: 0x0600605E RID: 24670 RVA: 0x000E8F78 File Offset: 0x000E7178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DiscardWeaponPush other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.MovementInformation, other.MovementInformation) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600605F RID: 24671 RVA: 0x000E8FC8 File Offset: 0x000E71C8
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

		// Token: 0x06006060 RID: 24672 RVA: 0x000E901D File Offset: 0x000E721D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006061 RID: 24673 RVA: 0x000E902A File Offset: 0x000E722A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006062 RID: 24674 RVA: 0x000E9034 File Offset: 0x000E7234
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
				output.WriteRawTag(98);
				output.WriteMessage(this.MovementInformation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006063 RID: 24675 RVA: 0x000E9090 File Offset: 0x000E7290
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

		// Token: 0x06006064 RID: 24676 RVA: 0x000E90E8 File Offset: 0x000E72E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DiscardWeaponPush other)
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

		// Token: 0x06006065 RID: 24677 RVA: 0x000E9150 File Offset: 0x000E7350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006066 RID: 24678 RVA: 0x000E915C File Offset: 0x000E735C
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
					if (num != 98U)
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

		// Token: 0x0400375A RID: 14170
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400375B RID: 14171
		public const int EntityIdFieldNumber = 4;

		// Token: 0x0400375C RID: 14172
		private long entityId_;

		// Token: 0x0400375D RID: 14173
		public const int MovementInformationFieldNumber = 12;

		// Token: 0x0400375E RID: 14174
		private MovementInformation movementInformation_;
	}
}
