using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E7A RID: 3706
	[NetMessage(EMessageId.RbBlockStateChangeNotify)]
	public sealed class RbBlockStateChangeNotify : IMessage<RbBlockStateChangeNotify>, IMessage, IEquatable<RbBlockStateChangeNotify>, IDeepCloneable<RbBlockStateChangeNotify>, IBufferMessage
	{
		// Token: 0x06013EF7 RID: 81655 RVA: 0x002E80DD File Offset: 0x002E62DD
		[NullableContext(1)]
		public static RbBlockStateChangeNotify Create()
		{
			return new RbBlockStateChangeNotify();
		}

		// Token: 0x17004258 RID: 16984
		// (get) Token: 0x06013EF8 RID: 81656 RVA: 0x002E80E4 File Offset: 0x002E62E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004259 RID: 16985
		// (get) Token: 0x06013EF9 RID: 81657 RVA: 0x002E80E7 File Offset: 0x002E62E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RbBlockStateChangeNotify.Descriptor;
			}
		}

		// Token: 0x06013EFA RID: 81658 RVA: 0x002E80EE File Offset: 0x002E62EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockStateChangeNotify()
		{
		}

		// Token: 0x06013EFB RID: 81659 RVA: 0x002E80F8 File Offset: 0x002E62F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockStateChangeNotify(RbBlockStateChangeNotify other) : this()
		{
			this.incId_ = other.incId_;
			this.entityId_ = other.entityId_;
			this.state_ = ((other.state_ != null) ? other.state_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013EFC RID: 81660 RVA: 0x002E8150 File Offset: 0x002E6350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockStateChangeNotify Clone()
		{
			return new RbBlockStateChangeNotify(this);
		}

		// Token: 0x1700425A RID: 16986
		// (get) Token: 0x06013EFD RID: 81661 RVA: 0x002E8158 File Offset: 0x002E6358
		// (set) Token: 0x06013EFE RID: 81662 RVA: 0x002E8160 File Offset: 0x002E6360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x1700425B RID: 16987
		// (get) Token: 0x06013EFF RID: 81663 RVA: 0x002E8169 File Offset: 0x002E6369
		// (set) Token: 0x06013F00 RID: 81664 RVA: 0x002E8171 File Offset: 0x002E6371
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

		// Token: 0x1700425C RID: 16988
		// (get) Token: 0x06013F01 RID: 81665 RVA: 0x002E817A File Offset: 0x002E637A
		// (set) Token: 0x06013F02 RID: 81666 RVA: 0x002E8182 File Offset: 0x002E6382
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockPbState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x06013F03 RID: 81667 RVA: 0x002E818B File Offset: 0x002E638B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RbBlockStateChangeNotify);
		}

		// Token: 0x06013F04 RID: 81668 RVA: 0x002E819C File Offset: 0x002E639C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RbBlockStateChangeNotify other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.EntityId == other.EntityId && object.Equals(this.State, other.State) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013F05 RID: 81669 RVA: 0x002E81FC File Offset: 0x002E63FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.state_ != null)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013F06 RID: 81670 RVA: 0x002E826A File Offset: 0x002E646A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013F07 RID: 81671 RVA: 0x002E8277 File Offset: 0x002E6477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013F08 RID: 81672 RVA: 0x002E8280 File Offset: 0x002E6480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EntityId);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.IncId);
			}
			if (this.state_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.State);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013F09 RID: 81673 RVA: 0x002E82F8 File Offset: 0x002E64F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.state_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.State);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013F0A RID: 81674 RVA: 0x002E8368 File Offset: 0x002E6568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RbBlockStateChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.state_ != null)
			{
				if (this.state_ == null)
				{
					this.State = new RbBlockPbState();
				}
				this.State.MergeFrom(other.State);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013F0B RID: 81675 RVA: 0x002E83E4 File Offset: 0x002E65E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013F0C RID: 81676 RVA: 0x002E83F0 File Offset: 0x002E65F0
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
				if (num != 24U)
				{
					if (num != 32U)
					{
						if (num != 90U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.state_ == null)
							{
								this.State = new RbBlockPbState();
							}
							input.ReadMessage(this.State);
						}
					}
					else
					{
						this.IncId = input.ReadInt32();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007A45 RID: 31301
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A46 RID: 31302
		public const int IncIdFieldNumber = 4;

		// Token: 0x04007A47 RID: 31303
		private int incId_;

		// Token: 0x04007A48 RID: 31304
		public const int EntityIdFieldNumber = 3;

		// Token: 0x04007A49 RID: 31305
		private long entityId_;

		// Token: 0x04007A4A RID: 31306
		public const int StateFieldNumber = 11;

		// Token: 0x04007A4B RID: 31307
		private RbBlockPbState state_;
	}
}
