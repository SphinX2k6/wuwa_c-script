using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DF7 RID: 3575
	[NetMessage(EMessageId.PullingFoundationRequest)]
	public sealed class PullingFoundationRequest : IMessage<PullingFoundationRequest>, IMessage, IEquatable<PullingFoundationRequest>, IDeepCloneable<PullingFoundationRequest>, IBufferMessage
	{
		// Token: 0x060133AD RID: 78765 RVA: 0x002CCF5F File Offset: 0x002CB15F
		[NullableContext(1)]
		public static PullingFoundationRequest Create()
		{
			return new PullingFoundationRequest();
		}

		// Token: 0x17003FD0 RID: 16336
		// (get) Token: 0x060133AE RID: 78766 RVA: 0x002CCF66 File Offset: 0x002CB166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FD1 RID: 16337
		// (get) Token: 0x060133AF RID: 78767 RVA: 0x002CCF69 File Offset: 0x002CB169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PullingFoundationRequest.Descriptor;
			}
		}

		// Token: 0x060133B0 RID: 78768 RVA: 0x002CCF70 File Offset: 0x002CB170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PullingFoundationRequest()
		{
		}

		// Token: 0x060133B1 RID: 78769 RVA: 0x002CCF78 File Offset: 0x002CB178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PullingFoundationRequest(PullingFoundationRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.accusedEntityId_ = other.accusedEntityId_;
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this.rot_ = ((other.rot_ != null) ? other.rot_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060133B2 RID: 78770 RVA: 0x002CCFEC File Offset: 0x002CB1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PullingFoundationRequest Clone()
		{
			return new PullingFoundationRequest(this);
		}

		// Token: 0x17003FD2 RID: 16338
		// (get) Token: 0x060133B3 RID: 78771 RVA: 0x002CCFF4 File Offset: 0x002CB1F4
		// (set) Token: 0x060133B4 RID: 78772 RVA: 0x002CCFFC File Offset: 0x002CB1FC
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

		// Token: 0x17003FD3 RID: 16339
		// (get) Token: 0x060133B5 RID: 78773 RVA: 0x002CD005 File Offset: 0x002CB205
		// (set) Token: 0x060133B6 RID: 78774 RVA: 0x002CD00D File Offset: 0x002CB20D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long AccusedEntityId
		{
			get
			{
				return this.accusedEntityId_;
			}
			set
			{
				this.accusedEntityId_ = value;
			}
		}

		// Token: 0x17003FD4 RID: 16340
		// (get) Token: 0x060133B7 RID: 78775 RVA: 0x002CD016 File Offset: 0x002CB216
		// (set) Token: 0x060133B8 RID: 78776 RVA: 0x002CD01E File Offset: 0x002CB21E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x17003FD5 RID: 16341
		// (get) Token: 0x060133B9 RID: 78777 RVA: 0x002CD027 File Offset: 0x002CB227
		// (set) Token: 0x060133BA RID: 78778 RVA: 0x002CD02F File Offset: 0x002CB22F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Rotator Rot
		{
			get
			{
				return this.rot_;
			}
			set
			{
				this.rot_ = value;
			}
		}

		// Token: 0x060133BB RID: 78779 RVA: 0x002CD038 File Offset: 0x002CB238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PullingFoundationRequest);
		}

		// Token: 0x060133BC RID: 78780 RVA: 0x002CD048 File Offset: 0x002CB248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PullingFoundationRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.AccusedEntityId == other.AccusedEntityId && object.Equals(this.Pos, other.Pos) && object.Equals(this.Rot, other.Rot) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060133BD RID: 78781 RVA: 0x002CD0BC File Offset: 0x002CB2BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.AccusedEntityId != 0L)
			{
				num ^= this.AccusedEntityId.GetHashCode();
			}
			if (this.pos_ != null)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this.rot_ != null)
			{
				num ^= this.Rot.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060133BE RID: 78782 RVA: 0x002CD140 File Offset: 0x002CB340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060133BF RID: 78783 RVA: 0x002CD14D File Offset: 0x002CB34D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060133C0 RID: 78784 RVA: 0x002CD158 File Offset: 0x002CB358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rot_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Rot);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.EntityId);
			}
			if (this.AccusedEntityId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.AccusedEntityId);
			}
			if (this.pos_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Pos);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060133C1 RID: 78785 RVA: 0x002CD1EC File Offset: 0x002CB3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.AccusedEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.AccusedEntityId);
			}
			if (this.pos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Pos);
			}
			if (this.rot_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Rot);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060133C2 RID: 78786 RVA: 0x002CD274 File Offset: 0x002CB474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PullingFoundationRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.AccusedEntityId != 0L)
			{
				this.AccusedEntityId = other.AccusedEntityId;
			}
			if (other.pos_ != null)
			{
				if (this.pos_ == null)
				{
					this.Pos = new Vector();
				}
				this.Pos.MergeFrom(other.Pos);
			}
			if (other.rot_ != null)
			{
				if (this.rot_ == null)
				{
					this.Rot = new Rotator();
				}
				this.Rot.MergeFrom(other.Rot);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060133C3 RID: 78787 RVA: 0x002CD31C File Offset: 0x002CB51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060133C4 RID: 78788 RVA: 0x002CD328 File Offset: 0x002CB528
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
				if (num <= 48U)
				{
					if (num == 10U)
					{
						if (this.rot_ == null)
						{
							this.Rot = new Rotator();
						}
						input.ReadMessage(this.Rot);
						continue;
					}
					if (num == 48U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.AccusedEntityId = input.ReadInt64();
						continue;
					}
					if (num == 74U)
					{
						if (this.pos_ == null)
						{
							this.Pos = new Vector();
						}
						input.ReadMessage(this.Pos);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400765E RID: 30302
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400765F RID: 30303
		public const int EntityIdFieldNumber = 6;

		// Token: 0x04007660 RID: 30304
		private long entityId_;

		// Token: 0x04007661 RID: 30305
		public const int AccusedEntityIdFieldNumber = 7;

		// Token: 0x04007662 RID: 30306
		private long accusedEntityId_;

		// Token: 0x04007663 RID: 30307
		public const int PosFieldNumber = 9;

		// Token: 0x04007664 RID: 30308
		private Vector pos_;

		// Token: 0x04007665 RID: 30309
		public const int RotFieldNumber = 1;

		// Token: 0x04007666 RID: 30310
		private Rotator rot_;
	}
}
