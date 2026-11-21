using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004A9 RID: 1193
	public sealed class EntitySimplyMoveInfo : IMessage<EntitySimplyMoveInfo>, IMessage, IEquatable<EntitySimplyMoveInfo>, IDeepCloneable<EntitySimplyMoveInfo>, IBufferMessage
	{
		// Token: 0x06007218 RID: 29208 RVA: 0x001185E5 File Offset: 0x001167E5
		[NullableContext(1)]
		public static EntitySimplyMoveInfo Create()
		{
			return new EntitySimplyMoveInfo();
		}

		// Token: 0x1700160A RID: 5642
		// (get) Token: 0x06007219 RID: 29209 RVA: 0x001185EC File Offset: 0x001167EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EntitySimplyMoveInfo> Parser
		{
			get
			{
				return EntitySimplyMoveInfo._parser;
			}
		}

		// Token: 0x1700160B RID: 5643
		// (get) Token: 0x0600721A RID: 29210 RVA: 0x001185F3 File Offset: 0x001167F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700160C RID: 5644
		// (get) Token: 0x0600721B RID: 29211 RVA: 0x001185F6 File Offset: 0x001167F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntitySimplyMoveInfo.Descriptor;
			}
		}

		// Token: 0x0600721C RID: 29212 RVA: 0x001185FD File Offset: 0x001167FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntitySimplyMoveInfo()
		{
		}

		// Token: 0x0600721D RID: 29213 RVA: 0x00118608 File Offset: 0x00116808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntitySimplyMoveInfo(EntitySimplyMoveInfo other) : this()
		{
			this.entityId_ = other.entityId_;
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this.rotation_ = ((other.rotation_ != null) ? other.rotation_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600721E RID: 29214 RVA: 0x00118670 File Offset: 0x00116870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntitySimplyMoveInfo Clone()
		{
			return new EntitySimplyMoveInfo(this);
		}

		// Token: 0x1700160D RID: 5645
		// (get) Token: 0x0600721F RID: 29215 RVA: 0x00118678 File Offset: 0x00116878
		// (set) Token: 0x06007220 RID: 29216 RVA: 0x00118680 File Offset: 0x00116880
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

		// Token: 0x1700160E RID: 5646
		// (get) Token: 0x06007221 RID: 29217 RVA: 0x00118689 File Offset: 0x00116889
		// (set) Token: 0x06007222 RID: 29218 RVA: 0x00118691 File Offset: 0x00116891
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

		// Token: 0x1700160F RID: 5647
		// (get) Token: 0x06007223 RID: 29219 RVA: 0x0011869A File Offset: 0x0011689A
		// (set) Token: 0x06007224 RID: 29220 RVA: 0x001186A2 File Offset: 0x001168A2
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

		// Token: 0x06007225 RID: 29221 RVA: 0x001186AB File Offset: 0x001168AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntitySimplyMoveInfo);
		}

		// Token: 0x06007226 RID: 29222 RVA: 0x001186BC File Offset: 0x001168BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntitySimplyMoveInfo other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.Location, other.Location) && object.Equals(this.Rotation, other.Rotation) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007227 RID: 29223 RVA: 0x00118720 File Offset: 0x00116920
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007228 RID: 29224 RVA: 0x0011878B File Offset: 0x0011698B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007229 RID: 29225 RVA: 0x00118798 File Offset: 0x00116998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600722A RID: 29226 RVA: 0x001187A4 File Offset: 0x001169A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.location_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Location);
			}
			if (this.rotation_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Rotation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600722B RID: 29227 RVA: 0x00118818 File Offset: 0x00116A18
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600722C RID: 29228 RVA: 0x00118888 File Offset: 0x00116A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntitySimplyMoveInfo other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600722D RID: 29229 RVA: 0x0011891C File Offset: 0x00116B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600722E RID: 29230 RVA: 0x00118928 File Offset: 0x00116B28
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.rotation_ == null)
							{
								this.Rotation = new Rotator();
							}
							input.ReadMessage(this.Rotation);
						}
					}
					else
					{
						if (this.location_ == null)
						{
							this.Location = new Vector();
						}
						input.ReadMessage(this.Location);
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003D1D RID: 15645
		private static readonly MessageParser<EntitySimplyMoveInfo> _parser = new MessageParser<EntitySimplyMoveInfo>(() => new EntitySimplyMoveInfo());

		// Token: 0x04003D1E RID: 15646
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D1F RID: 15647
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04003D20 RID: 15648
		private long entityId_;

		// Token: 0x04003D21 RID: 15649
		public const int LocationFieldNumber = 2;

		// Token: 0x04003D22 RID: 15650
		private Vector location_;

		// Token: 0x04003D23 RID: 15651
		public const int RotationFieldNumber = 3;

		// Token: 0x04003D24 RID: 15652
		private Rotator rotation_;
	}
}
