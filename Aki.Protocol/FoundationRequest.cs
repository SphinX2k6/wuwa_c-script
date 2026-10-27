using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200063B RID: 1595
	[NetMessage(EMessageId.FoundationRequest)]
	public sealed class FoundationRequest : IMessage<FoundationRequest>, IMessage, IEquatable<FoundationRequest>, IDeepCloneable<FoundationRequest>, IBufferMessage
	{
		// Token: 0x060092F5 RID: 37621 RVA: 0x001638F2 File Offset: 0x00161AF2
		[NullableContext(1)]
		public static FoundationRequest Create()
		{
			return new FoundationRequest();
		}

		// Token: 0x17001D40 RID: 7488
		// (get) Token: 0x060092F6 RID: 37622 RVA: 0x001638F9 File Offset: 0x00161AF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D41 RID: 7489
		// (get) Token: 0x060092F7 RID: 37623 RVA: 0x001638FC File Offset: 0x00161AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FoundationRequest.Descriptor;
			}
		}

		// Token: 0x060092F8 RID: 37624 RVA: 0x00163903 File Offset: 0x00161B03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationRequest()
		{
		}

		// Token: 0x060092F9 RID: 37625 RVA: 0x0016390C File Offset: 0x00161B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationRequest(FoundationRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.accusedEntityId_ = other.accusedEntityId_;
			this.activeOperate_ = other.activeOperate_;
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this.rot_ = ((other.rot_ != null) ? other.rot_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060092FA RID: 37626 RVA: 0x0016398C File Offset: 0x00161B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationRequest Clone()
		{
			return new FoundationRequest(this);
		}

		// Token: 0x17001D42 RID: 7490
		// (get) Token: 0x060092FB RID: 37627 RVA: 0x00163994 File Offset: 0x00161B94
		// (set) Token: 0x060092FC RID: 37628 RVA: 0x0016399C File Offset: 0x00161B9C
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

		// Token: 0x17001D43 RID: 7491
		// (get) Token: 0x060092FD RID: 37629 RVA: 0x001639A5 File Offset: 0x00161BA5
		// (set) Token: 0x060092FE RID: 37630 RVA: 0x001639AD File Offset: 0x00161BAD
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

		// Token: 0x17001D44 RID: 7492
		// (get) Token: 0x060092FF RID: 37631 RVA: 0x001639B6 File Offset: 0x00161BB6
		// (set) Token: 0x06009300 RID: 37632 RVA: 0x001639BE File Offset: 0x00161BBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActiveOperate
		{
			get
			{
				return this.activeOperate_;
			}
			set
			{
				this.activeOperate_ = value;
			}
		}

		// Token: 0x17001D45 RID: 7493
		// (get) Token: 0x06009301 RID: 37633 RVA: 0x001639C7 File Offset: 0x00161BC7
		// (set) Token: 0x06009302 RID: 37634 RVA: 0x001639CF File Offset: 0x00161BCF
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

		// Token: 0x17001D46 RID: 7494
		// (get) Token: 0x06009303 RID: 37635 RVA: 0x001639D8 File Offset: 0x00161BD8
		// (set) Token: 0x06009304 RID: 37636 RVA: 0x001639E0 File Offset: 0x00161BE0
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

		// Token: 0x06009305 RID: 37637 RVA: 0x001639E9 File Offset: 0x00161BE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FoundationRequest);
		}

		// Token: 0x06009306 RID: 37638 RVA: 0x001639F8 File Offset: 0x00161BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FoundationRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.AccusedEntityId == other.AccusedEntityId && this.ActiveOperate == other.ActiveOperate && object.Equals(this.Pos, other.Pos) && object.Equals(this.Rot, other.Rot) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009307 RID: 37639 RVA: 0x00163A7C File Offset: 0x00161C7C
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
			if (this.ActiveOperate != 0)
			{
				num ^= this.ActiveOperate.GetHashCode();
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

		// Token: 0x06009308 RID: 37640 RVA: 0x00163B19 File Offset: 0x00161D19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009309 RID: 37641 RVA: 0x00163B26 File Offset: 0x00161D26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600930A RID: 37642 RVA: 0x00163B30 File Offset: 0x00161D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActiveOperate != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActiveOperate);
			}
			if (this.rot_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Rot);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.EntityId);
			}
			if (this.AccusedEntityId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.AccusedEntityId);
			}
			if (this.pos_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Pos);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600930B RID: 37643 RVA: 0x00163BE0 File Offset: 0x00161DE0
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
			if (this.ActiveOperate != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActiveOperate);
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

		// Token: 0x0600930C RID: 37644 RVA: 0x00163C80 File Offset: 0x00161E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FoundationRequest other)
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
			if (other.ActiveOperate != 0)
			{
				this.ActiveOperate = other.ActiveOperate;
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

		// Token: 0x0600930D RID: 37645 RVA: 0x00163D3C File Offset: 0x00161F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600930E RID: 37646 RVA: 0x00163D48 File Offset: 0x00161F48
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
				if (num <= 42U)
				{
					if (num == 24U)
					{
						this.ActiveOperate = input.ReadInt32();
						continue;
					}
					if (num == 42U)
					{
						if (this.rot_ == null)
						{
							this.Rot = new Rotator();
						}
						input.ReadMessage(this.Rot);
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 72U)
					{
						this.AccusedEntityId = input.ReadInt64();
						continue;
					}
					if (num == 82U)
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

		// Token: 0x040046C3 RID: 18115
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046C4 RID: 18116
		public const int EntityIdFieldNumber = 8;

		// Token: 0x040046C5 RID: 18117
		private long entityId_;

		// Token: 0x040046C6 RID: 18118
		public const int AccusedEntityIdFieldNumber = 9;

		// Token: 0x040046C7 RID: 18119
		private long accusedEntityId_;

		// Token: 0x040046C8 RID: 18120
		public const int ActiveOperateFieldNumber = 3;

		// Token: 0x040046C9 RID: 18121
		private int activeOperate_;

		// Token: 0x040046CA RID: 18122
		public const int PosFieldNumber = 10;

		// Token: 0x040046CB RID: 18123
		private Vector pos_;

		// Token: 0x040046CC RID: 18124
		public const int RotFieldNumber = 5;

		// Token: 0x040046CD RID: 18125
		private Rotator rot_;
	}
}
