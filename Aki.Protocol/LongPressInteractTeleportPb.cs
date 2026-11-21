using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200093F RID: 2367
	public sealed class LongPressInteractTeleportPb : IMessage<LongPressInteractTeleportPb>, IMessage, IEquatable<LongPressInteractTeleportPb>, IDeepCloneable<LongPressInteractTeleportPb>, IBufferMessage
	{
		// Token: 0x0600D108 RID: 53512 RVA: 0x001ED65B File Offset: 0x001EB85B
		[NullableContext(1)]
		public static LongPressInteractTeleportPb Create()
		{
			return new LongPressInteractTeleportPb();
		}

		// Token: 0x17002A49 RID: 10825
		// (get) Token: 0x0600D109 RID: 53513 RVA: 0x001ED662 File Offset: 0x001EB862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A4A RID: 10826
		// (get) Token: 0x0600D10A RID: 53514 RVA: 0x001ED665 File Offset: 0x001EB865
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LongPressInteractTeleportPb.Descriptor;
			}
		}

		// Token: 0x0600D10B RID: 53515 RVA: 0x001ED66C File Offset: 0x001EB86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongPressInteractTeleportPb()
		{
		}

		// Token: 0x0600D10C RID: 53516 RVA: 0x001ED674 File Offset: 0x001EB874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongPressInteractTeleportPb(LongPressInteractTeleportPb other) : this()
		{
			this.actionCtx_ = ((other.actionCtx_ != null) ? other.actionCtx_.Clone() : null);
			this.index_ = other.index_;
			this.streamingSourceConditionIndex_ = other.streamingSourceConditionIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D10D RID: 53517 RVA: 0x001ED6CC File Offset: 0x001EB8CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongPressInteractTeleportPb Clone()
		{
			return new LongPressInteractTeleportPb(this);
		}

		// Token: 0x17002A4B RID: 10827
		// (get) Token: 0x0600D10E RID: 53518 RVA: 0x001ED6D4 File Offset: 0x001EB8D4
		// (set) Token: 0x0600D10F RID: 53519 RVA: 0x001ED6DC File Offset: 0x001EB8DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameCtxPb ActionCtx
		{
			get
			{
				return this.actionCtx_;
			}
			set
			{
				this.actionCtx_ = value;
			}
		}

		// Token: 0x17002A4C RID: 10828
		// (get) Token: 0x0600D110 RID: 53520 RVA: 0x001ED6E5 File Offset: 0x001EB8E5
		// (set) Token: 0x0600D111 RID: 53521 RVA: 0x001ED6ED File Offset: 0x001EB8ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x17002A4D RID: 10829
		// (get) Token: 0x0600D112 RID: 53522 RVA: 0x001ED6F6 File Offset: 0x001EB8F6
		// (set) Token: 0x0600D113 RID: 53523 RVA: 0x001ED6FE File Offset: 0x001EB8FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StreamingSourceConditionIndex
		{
			get
			{
				return this.streamingSourceConditionIndex_;
			}
			set
			{
				this.streamingSourceConditionIndex_ = value;
			}
		}

		// Token: 0x0600D114 RID: 53524 RVA: 0x001ED707 File Offset: 0x001EB907
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LongPressInteractTeleportPb);
		}

		// Token: 0x0600D115 RID: 53525 RVA: 0x001ED718 File Offset: 0x001EB918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LongPressInteractTeleportPb other)
		{
			return other != null && (other == this || (object.Equals(this.ActionCtx, other.ActionCtx) && this.Index == other.Index && this.StreamingSourceConditionIndex == other.StreamingSourceConditionIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D116 RID: 53526 RVA: 0x001ED778 File Offset: 0x001EB978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.actionCtx_ != null)
			{
				num ^= this.ActionCtx.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.StreamingSourceConditionIndex != 0)
			{
				num ^= this.StreamingSourceConditionIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D117 RID: 53527 RVA: 0x001ED7E6 File Offset: 0x001EB9E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D118 RID: 53528 RVA: 0x001ED7F3 File Offset: 0x001EB9F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D119 RID: 53529 RVA: 0x001ED7FC File Offset: 0x001EB9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.actionCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ActionCtx);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Index);
			}
			if (this.StreamingSourceConditionIndex != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.StreamingSourceConditionIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D11A RID: 53530 RVA: 0x001ED874 File Offset: 0x001EBA74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.actionCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ActionCtx);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.StreamingSourceConditionIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StreamingSourceConditionIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D11B RID: 53531 RVA: 0x001ED8E4 File Offset: 0x001EBAE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LongPressInteractTeleportPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.actionCtx_ != null)
			{
				if (this.actionCtx_ == null)
				{
					this.ActionCtx = new GameCtxPb();
				}
				this.ActionCtx.MergeFrom(other.ActionCtx);
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.StreamingSourceConditionIndex != 0)
			{
				this.StreamingSourceConditionIndex = other.StreamingSourceConditionIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D11C RID: 53532 RVA: 0x001ED960 File Offset: 0x001EBB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D11D RID: 53533 RVA: 0x001ED96C File Offset: 0x001EBB6C
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
							this.StreamingSourceConditionIndex = input.ReadInt32();
						}
					}
					else
					{
						this.Index = input.ReadInt32();
					}
				}
				else
				{
					if (this.actionCtx_ == null)
					{
						this.ActionCtx = new GameCtxPb();
					}
					input.ReadMessage(this.ActionCtx);
				}
			}
		}

		// Token: 0x04005876 RID: 22646
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005877 RID: 22647
		public const int ActionCtxFieldNumber = 1;

		// Token: 0x04005878 RID: 22648
		private GameCtxPb actionCtx_;

		// Token: 0x04005879 RID: 22649
		public const int IndexFieldNumber = 2;

		// Token: 0x0400587A RID: 22650
		private int index_;

		// Token: 0x0400587B RID: 22651
		public const int StreamingSourceConditionIndexFieldNumber = 3;

		// Token: 0x0400587C RID: 22652
		private int streamingSourceConditionIndex_;
	}
}
