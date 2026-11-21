using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DE7 RID: 3559
	[NetMessage(EMessageId.PullingFoundationRequest)]
	public sealed class PullingFoundationRequest : IMessage<PullingFoundationRequest>, IMessage, IEquatable<PullingFoundationRequest>, IDeepCloneable<PullingFoundationRequest>, IBufferMessage
	{
		// Token: 0x060132C8 RID: 78536 RVA: 0x002CB89B File Offset: 0x002C9A9B
		[NullableContext(1)]
		public static PullingFoundationRequest Create()
		{
			return new PullingFoundationRequest();
		}

		// Token: 0x17003FA6 RID: 16294
		// (get) Token: 0x060132C9 RID: 78537 RVA: 0x002CB8A2 File Offset: 0x002C9AA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FA7 RID: 16295
		// (get) Token: 0x060132CA RID: 78538 RVA: 0x002CB8A5 File Offset: 0x002C9AA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PullingFoundationRequest.Descriptor;
			}
		}

		// Token: 0x060132CB RID: 78539 RVA: 0x002CB8AC File Offset: 0x002C9AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PullingFoundationRequest()
		{
		}

		// Token: 0x060132CC RID: 78540 RVA: 0x002CB8B4 File Offset: 0x002C9AB4
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

		// Token: 0x060132CD RID: 78541 RVA: 0x002CB928 File Offset: 0x002C9B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PullingFoundationRequest Clone()
		{
			return new PullingFoundationRequest(this);
		}

		// Token: 0x17003FA8 RID: 16296
		// (get) Token: 0x060132CE RID: 78542 RVA: 0x002CB930 File Offset: 0x002C9B30
		// (set) Token: 0x060132CF RID: 78543 RVA: 0x002CB938 File Offset: 0x002C9B38
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

		// Token: 0x17003FA9 RID: 16297
		// (get) Token: 0x060132D0 RID: 78544 RVA: 0x002CB941 File Offset: 0x002C9B41
		// (set) Token: 0x060132D1 RID: 78545 RVA: 0x002CB949 File Offset: 0x002C9B49
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

		// Token: 0x17003FAA RID: 16298
		// (get) Token: 0x060132D2 RID: 78546 RVA: 0x002CB952 File Offset: 0x002C9B52
		// (set) Token: 0x060132D3 RID: 78547 RVA: 0x002CB95A File Offset: 0x002C9B5A
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

		// Token: 0x17003FAB RID: 16299
		// (get) Token: 0x060132D4 RID: 78548 RVA: 0x002CB963 File Offset: 0x002C9B63
		// (set) Token: 0x060132D5 RID: 78549 RVA: 0x002CB96B File Offset: 0x002C9B6B
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

		// Token: 0x060132D6 RID: 78550 RVA: 0x002CB974 File Offset: 0x002C9B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PullingFoundationRequest);
		}

		// Token: 0x060132D7 RID: 78551 RVA: 0x002CB984 File Offset: 0x002C9B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PullingFoundationRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.AccusedEntityId == other.AccusedEntityId && object.Equals(this.Pos, other.Pos) && object.Equals(this.Rot, other.Rot) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060132D8 RID: 78552 RVA: 0x002CB9F8 File Offset: 0x002C9BF8
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

		// Token: 0x060132D9 RID: 78553 RVA: 0x002CBA7C File Offset: 0x002C9C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060132DA RID: 78554 RVA: 0x002CBA89 File Offset: 0x002C9C89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060132DB RID: 78555 RVA: 0x002CBA94 File Offset: 0x002C9C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rot_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Rot);
			}
			if (this.pos_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Pos);
			}
			if (this.AccusedEntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.AccusedEntityId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060132DC RID: 78556 RVA: 0x002CBB28 File Offset: 0x002C9D28
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

		// Token: 0x060132DD RID: 78557 RVA: 0x002CBBB0 File Offset: 0x002C9DB0
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

		// Token: 0x060132DE RID: 78558 RVA: 0x002CBC58 File Offset: 0x002C9E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060132DF RID: 78559 RVA: 0x002CBC64 File Offset: 0x002C9E64
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
				if (num <= 58U)
				{
					if (num == 42U)
					{
						if (this.rot_ == null)
						{
							this.Rot = new Rotator();
						}
						input.ReadMessage(this.Rot);
						continue;
					}
					if (num == 58U)
					{
						if (this.pos_ == null)
						{
							this.Pos = new Vector();
						}
						input.ReadMessage(this.Pos);
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.AccusedEntityId = input.ReadInt64();
						continue;
					}
					if (num == 112U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007688 RID: 30344
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007689 RID: 30345
		public const int EntityIdFieldNumber = 14;

		// Token: 0x0400768A RID: 30346
		private long entityId_;

		// Token: 0x0400768B RID: 30347
		public const int AccusedEntityIdFieldNumber = 8;

		// Token: 0x0400768C RID: 30348
		private long accusedEntityId_;

		// Token: 0x0400768D RID: 30349
		public const int PosFieldNumber = 7;

		// Token: 0x0400768E RID: 30350
		private Vector pos_;

		// Token: 0x0400768F RID: 30351
		public const int RotFieldNumber = 5;

		// Token: 0x04007690 RID: 30352
		private Rotator rot_;
	}
}
