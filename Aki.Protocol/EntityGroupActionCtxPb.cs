using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000493 RID: 1171
	public sealed class EntityGroupActionCtxPb : IMessage<EntityGroupActionCtxPb>, IMessage, IEquatable<EntityGroupActionCtxPb>, IDeepCloneable<EntityGroupActionCtxPb>, IBufferMessage
	{
		// Token: 0x06006FEA RID: 28650 RVA: 0x00112B70 File Offset: 0x00110D70
		[NullableContext(1)]
		public static EntityGroupActionCtxPb Create()
		{
			return new EntityGroupActionCtxPb();
		}

		// Token: 0x1700158D RID: 5517
		// (get) Token: 0x06006FEB RID: 28651 RVA: 0x00112B77 File Offset: 0x00110D77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700158E RID: 5518
		// (get) Token: 0x06006FEC RID: 28652 RVA: 0x00112B7A File Offset: 0x00110D7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityGroupActionCtxPb.Descriptor;
			}
		}

		// Token: 0x06006FED RID: 28653 RVA: 0x00112B81 File Offset: 0x00110D81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityGroupActionCtxPb()
		{
		}

		// Token: 0x06006FEE RID: 28654 RVA: 0x00112B8C File Offset: 0x00110D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityGroupActionCtxPb(EntityGroupActionCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.triggerIndex_ = other.triggerIndex_;
			this.isMatch_ = other.isMatch_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006FEF RID: 28655 RVA: 0x00112BE4 File Offset: 0x00110DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityGroupActionCtxPb Clone()
		{
			return new EntityGroupActionCtxPb(this);
		}

		// Token: 0x1700158F RID: 5519
		// (get) Token: 0x06006FF0 RID: 28656 RVA: 0x00112BEC File Offset: 0x00110DEC
		// (set) Token: 0x06006FF1 RID: 28657 RVA: 0x00112BF4 File Offset: 0x00110DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCtxPb EntityCtx
		{
			get
			{
				return this.entityCtx_;
			}
			set
			{
				this.entityCtx_ = value;
			}
		}

		// Token: 0x17001590 RID: 5520
		// (get) Token: 0x06006FF2 RID: 28658 RVA: 0x00112BFD File Offset: 0x00110DFD
		// (set) Token: 0x06006FF3 RID: 28659 RVA: 0x00112C05 File Offset: 0x00110E05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TriggerIndex
		{
			get
			{
				return this.triggerIndex_;
			}
			set
			{
				this.triggerIndex_ = value;
			}
		}

		// Token: 0x17001591 RID: 5521
		// (get) Token: 0x06006FF4 RID: 28660 RVA: 0x00112C0E File Offset: 0x00110E0E
		// (set) Token: 0x06006FF5 RID: 28661 RVA: 0x00112C16 File Offset: 0x00110E16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsMatch
		{
			get
			{
				return this.isMatch_;
			}
			set
			{
				this.isMatch_ = value;
			}
		}

		// Token: 0x06006FF6 RID: 28662 RVA: 0x00112C1F File Offset: 0x00110E1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityGroupActionCtxPb);
		}

		// Token: 0x06006FF7 RID: 28663 RVA: 0x00112C30 File Offset: 0x00110E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityGroupActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.TriggerIndex == other.TriggerIndex && this.IsMatch == other.IsMatch && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006FF8 RID: 28664 RVA: 0x00112C90 File Offset: 0x00110E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.entityCtx_ != null)
			{
				num ^= this.EntityCtx.GetHashCode();
			}
			if (this.TriggerIndex != 0)
			{
				num ^= this.TriggerIndex.GetHashCode();
			}
			if (this.IsMatch)
			{
				num ^= this.IsMatch.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006FF9 RID: 28665 RVA: 0x00112CFE File Offset: 0x00110EFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006FFA RID: 28666 RVA: 0x00112D0B File Offset: 0x00110F0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006FFB RID: 28667 RVA: 0x00112D14 File Offset: 0x00110F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityCtx);
			}
			if (this.TriggerIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TriggerIndex);
			}
			if (this.IsMatch)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsMatch);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006FFC RID: 28668 RVA: 0x00112D8C File Offset: 0x00110F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.entityCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityCtx);
			}
			if (this.TriggerIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TriggerIndex);
			}
			if (this.IsMatch)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006FFD RID: 28669 RVA: 0x00112DF0 File Offset: 0x00110FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityGroupActionCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.entityCtx_ != null)
			{
				if (this.entityCtx_ == null)
				{
					this.EntityCtx = new EntityCtxPb();
				}
				this.EntityCtx.MergeFrom(other.EntityCtx);
			}
			if (other.TriggerIndex != 0)
			{
				this.TriggerIndex = other.TriggerIndex;
			}
			if (other.IsMatch)
			{
				this.IsMatch = other.IsMatch;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006FFE RID: 28670 RVA: 0x00112E6C File Offset: 0x0011106C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006FFF RID: 28671 RVA: 0x00112E78 File Offset: 0x00111078
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsMatch = input.ReadBool();
						}
					}
					else
					{
						this.TriggerIndex = input.ReadInt32();
					}
				}
				else
				{
					if (this.entityCtx_ == null)
					{
						this.EntityCtx = new EntityCtxPb();
					}
					input.ReadMessage(this.EntityCtx);
				}
			}
		}

		// Token: 0x04003C13 RID: 15379
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C14 RID: 15380
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04003C15 RID: 15381
		private EntityCtxPb entityCtx_;

		// Token: 0x04003C16 RID: 15382
		public const int TriggerIndexFieldNumber = 2;

		// Token: 0x04003C17 RID: 15383
		private int triggerIndex_;

		// Token: 0x04003C18 RID: 15384
		public const int IsMatchFieldNumber = 3;

		// Token: 0x04003C19 RID: 15385
		private bool isMatch_;
	}
}
