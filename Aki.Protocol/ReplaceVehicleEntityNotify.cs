using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F0D RID: 3853
	[NetMessage(EMessageId.ReplaceVehicleEntityNotify)]
	public sealed class ReplaceVehicleEntityNotify : IMessage<ReplaceVehicleEntityNotify>, IMessage, IEquatable<ReplaceVehicleEntityNotify>, IDeepCloneable<ReplaceVehicleEntityNotify>, IBufferMessage
	{
		// Token: 0x06014A69 RID: 84585 RVA: 0x002FFB59 File Offset: 0x002FDD59
		[NullableContext(1)]
		public static ReplaceVehicleEntityNotify Create()
		{
			return new ReplaceVehicleEntityNotify();
		}

		// Token: 0x170044A6 RID: 17574
		// (get) Token: 0x06014A6A RID: 84586 RVA: 0x002FFB60 File Offset: 0x002FDD60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044A7 RID: 17575
		// (get) Token: 0x06014A6B RID: 84587 RVA: 0x002FFB63 File Offset: 0x002FDD63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReplaceVehicleEntityNotify.Descriptor;
			}
		}

		// Token: 0x06014A6C RID: 84588 RVA: 0x002FFB6A File Offset: 0x002FDD6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReplaceVehicleEntityNotify()
		{
		}

		// Token: 0x06014A6D RID: 84589 RVA: 0x002FFB74 File Offset: 0x002FDD74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReplaceVehicleEntityNotify(ReplaceVehicleEntityNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this.rotation_ = ((other.rotation_ != null) ? other.rotation_.Clone() : null);
			this.isReplace_ = other.isReplace_;
			this.gravityDirection_ = ((other.gravityDirection_ != null) ? other.gravityDirection_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014A6E RID: 84590 RVA: 0x002FFC04 File Offset: 0x002FDE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReplaceVehicleEntityNotify Clone()
		{
			return new ReplaceVehicleEntityNotify(this);
		}

		// Token: 0x170044A8 RID: 17576
		// (get) Token: 0x06014A6F RID: 84591 RVA: 0x002FFC0C File Offset: 0x002FDE0C
		// (set) Token: 0x06014A70 RID: 84592 RVA: 0x002FFC14 File Offset: 0x002FDE14
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

		// Token: 0x170044A9 RID: 17577
		// (get) Token: 0x06014A71 RID: 84593 RVA: 0x002FFC1D File Offset: 0x002FDE1D
		// (set) Token: 0x06014A72 RID: 84594 RVA: 0x002FFC25 File Offset: 0x002FDE25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Location
		{
			get
			{
				return this.location_;
			}
			set
			{
				this.location_ = value;
			}
		}

		// Token: 0x170044AA RID: 17578
		// (get) Token: 0x06014A73 RID: 84595 RVA: 0x002FFC2E File Offset: 0x002FDE2E
		// (set) Token: 0x06014A74 RID: 84596 RVA: 0x002FFC36 File Offset: 0x002FDE36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Rotator Rotation
		{
			get
			{
				return this.rotation_;
			}
			set
			{
				this.rotation_ = value;
			}
		}

		// Token: 0x170044AB RID: 17579
		// (get) Token: 0x06014A75 RID: 84597 RVA: 0x002FFC3F File Offset: 0x002FDE3F
		// (set) Token: 0x06014A76 RID: 84598 RVA: 0x002FFC47 File Offset: 0x002FDE47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsReplace
		{
			get
			{
				return this.isReplace_;
			}
			set
			{
				this.isReplace_ = value;
			}
		}

		// Token: 0x170044AC RID: 17580
		// (get) Token: 0x06014A77 RID: 84599 RVA: 0x002FFC50 File Offset: 0x002FDE50
		// (set) Token: 0x06014A78 RID: 84600 RVA: 0x002FFC58 File Offset: 0x002FDE58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector GravityDirection
		{
			get
			{
				return this.gravityDirection_;
			}
			set
			{
				this.gravityDirection_ = value;
			}
		}

		// Token: 0x06014A79 RID: 84601 RVA: 0x002FFC61 File Offset: 0x002FDE61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReplaceVehicleEntityNotify);
		}

		// Token: 0x06014A7A RID: 84602 RVA: 0x002FFC70 File Offset: 0x002FDE70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReplaceVehicleEntityNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.Location, other.Location) && object.Equals(this.Rotation, other.Rotation) && this.IsReplace == other.IsReplace && object.Equals(this.GravityDirection, other.GravityDirection) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014A7B RID: 84603 RVA: 0x002FFCF8 File Offset: 0x002FDEF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.location_ != null)
			{
				num ^= this.Location.GetHashCode();
			}
			if (this.rotation_ != null)
			{
				num ^= this.Rotation.GetHashCode();
			}
			if (this.IsReplace)
			{
				num ^= this.IsReplace.GetHashCode();
			}
			if (this.gravityDirection_ != null)
			{
				num ^= this.GravityDirection.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014A7C RID: 84604 RVA: 0x002FFD92 File Offset: 0x002FDF92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014A7D RID: 84605 RVA: 0x002FFD9F File Offset: 0x002FDF9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014A7E RID: 84606 RVA: 0x002FFDA8 File Offset: 0x002FDFA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.location_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Location);
			}
			if (this.rotation_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Rotation);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.EntityId);
			}
			if (this.IsReplace)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.IsReplace);
			}
			if (this.gravityDirection_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.GravityDirection);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014A7F RID: 84607 RVA: 0x002FFE58 File Offset: 0x002FE058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.location_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Location);
			}
			if (this.rotation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Rotation);
			}
			if (this.IsReplace)
			{
				num += 2;
			}
			if (this.gravityDirection_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GravityDirection);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014A80 RID: 84608 RVA: 0x002FFEEC File Offset: 0x002FE0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReplaceVehicleEntityNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.location_ != null)
			{
				if (this.location_ == null)
				{
					this.Location = new Vector();
				}
				this.Location.MergeFrom(other.Location);
			}
			if (other.rotation_ != null)
			{
				if (this.rotation_ == null)
				{
					this.Rotation = new Rotator();
				}
				this.Rotation.MergeFrom(other.Rotation);
			}
			if (other.IsReplace)
			{
				this.IsReplace = other.IsReplace;
			}
			if (other.gravityDirection_ != null)
			{
				if (this.gravityDirection_ == null)
				{
					this.GravityDirection = new Vector();
				}
				this.GravityDirection.MergeFrom(other.GravityDirection);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014A81 RID: 84609 RVA: 0x002FFFC0 File Offset: 0x002FE1C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014A82 RID: 84610 RVA: 0x002FFFCC File Offset: 0x002FE1CC
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
				if (num <= 50U)
				{
					if (num == 42U)
					{
						if (this.location_ == null)
						{
							this.Location = new Vector();
						}
						input.ReadMessage(this.Location);
						continue;
					}
					if (num == 50U)
					{
						if (this.rotation_ == null)
						{
							this.Rotation = new Rotator();
						}
						input.ReadMessage(this.Rotation);
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 96U)
					{
						this.IsReplace = input.ReadBool();
						continue;
					}
					if (num == 122U)
					{
						if (this.gravityDirection_ == null)
						{
							this.GravityDirection = new Vector();
						}
						input.ReadMessage(this.GravityDirection);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007D44 RID: 32068
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D45 RID: 32069
		public const int EntityIdFieldNumber = 10;

		// Token: 0x04007D46 RID: 32070
		private long entityId_;

		// Token: 0x04007D47 RID: 32071
		public const int LocationFieldNumber = 5;

		// Token: 0x04007D48 RID: 32072
		private Vector location_;

		// Token: 0x04007D49 RID: 32073
		public const int RotationFieldNumber = 6;

		// Token: 0x04007D4A RID: 32074
		private Rotator rotation_;

		// Token: 0x04007D4B RID: 32075
		public const int IsReplaceFieldNumber = 12;

		// Token: 0x04007D4C RID: 32076
		private bool isReplace_;

		// Token: 0x04007D4D RID: 32077
		public const int GravityDirectionFieldNumber = 15;

		// Token: 0x04007D4E RID: 32078
		private Vector gravityDirection_;
	}
}
