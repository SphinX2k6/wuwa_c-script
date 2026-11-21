using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003C7 RID: 967
	[NetMessage(EMessageId.DiscardWeaponPush)]
	public sealed class DiscardWeaponPush : IMessage<DiscardWeaponPush>, IMessage, IEquatable<DiscardWeaponPush>, IDeepCloneable<DiscardWeaponPush>, IBufferMessage
	{
		// Token: 0x06005EC3 RID: 24259 RVA: 0x000E5D59 File Offset: 0x000E3F59
		[NullableContext(1)]
		public static DiscardWeaponPush Create()
		{
			return new DiscardWeaponPush();
		}

		// Token: 0x1700119D RID: 4509
		// (get) Token: 0x06005EC4 RID: 24260 RVA: 0x000E5D60 File Offset: 0x000E3F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700119E RID: 4510
		// (get) Token: 0x06005EC5 RID: 24261 RVA: 0x000E5D63 File Offset: 0x000E3F63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DiscardWeaponPush.Descriptor;
			}
		}

		// Token: 0x06005EC6 RID: 24262 RVA: 0x000E5D6A File Offset: 0x000E3F6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DiscardWeaponPush()
		{
		}

		// Token: 0x06005EC7 RID: 24263 RVA: 0x000E5D74 File Offset: 0x000E3F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DiscardWeaponPush(DiscardWeaponPush other) : this()
		{
			this.entityId_ = other.entityId_;
			this.movementInformation_ = ((other.movementInformation_ != null) ? other.movementInformation_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005EC8 RID: 24264 RVA: 0x000E5DC0 File Offset: 0x000E3FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DiscardWeaponPush Clone()
		{
			return new DiscardWeaponPush(this);
		}

		// Token: 0x1700119F RID: 4511
		// (get) Token: 0x06005EC9 RID: 24265 RVA: 0x000E5DC8 File Offset: 0x000E3FC8
		// (set) Token: 0x06005ECA RID: 24266 RVA: 0x000E5DD0 File Offset: 0x000E3FD0
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

		// Token: 0x170011A0 RID: 4512
		// (get) Token: 0x06005ECB RID: 24267 RVA: 0x000E5DD9 File Offset: 0x000E3FD9
		// (set) Token: 0x06005ECC RID: 24268 RVA: 0x000E5DE1 File Offset: 0x000E3FE1
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

		// Token: 0x06005ECD RID: 24269 RVA: 0x000E5DEA File Offset: 0x000E3FEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DiscardWeaponPush);
		}

		// Token: 0x06005ECE RID: 24270 RVA: 0x000E5DF8 File Offset: 0x000E3FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DiscardWeaponPush other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.MovementInformation, other.MovementInformation) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005ECF RID: 24271 RVA: 0x000E5E48 File Offset: 0x000E4048
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

		// Token: 0x06005ED0 RID: 24272 RVA: 0x000E5E9D File Offset: 0x000E409D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005ED1 RID: 24273 RVA: 0x000E5EAA File Offset: 0x000E40AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005ED2 RID: 24274 RVA: 0x000E5EB4 File Offset: 0x000E40B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
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

		// Token: 0x06005ED3 RID: 24275 RVA: 0x000E5F10 File Offset: 0x000E4110
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

		// Token: 0x06005ED4 RID: 24276 RVA: 0x000E5F68 File Offset: 0x000E4168
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

		// Token: 0x06005ED5 RID: 24277 RVA: 0x000E5FD0 File Offset: 0x000E41D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005ED6 RID: 24278 RVA: 0x000E5FDC File Offset: 0x000E41DC
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

		// Token: 0x04003747 RID: 14151
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003748 RID: 14152
		public const int EntityIdFieldNumber = 2;

		// Token: 0x04003749 RID: 14153
		private long entityId_;

		// Token: 0x0400374A RID: 14154
		public const int MovementInformationFieldNumber = 7;

		// Token: 0x0400374B RID: 14155
		private MovementInformation movementInformation_;
	}
}
