using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200094F RID: 2383
	public sealed class LongPressInteractActionCtxPb : IMessage<LongPressInteractActionCtxPb>, IMessage, IEquatable<LongPressInteractActionCtxPb>, IDeepCloneable<LongPressInteractActionCtxPb>, IBufferMessage
	{
		// Token: 0x0600D20E RID: 53774 RVA: 0x001EF554 File Offset: 0x001ED754
		[NullableContext(1)]
		public static LongPressInteractActionCtxPb Create()
		{
			return new LongPressInteractActionCtxPb();
		}

		// Token: 0x17002A83 RID: 10883
		// (get) Token: 0x0600D20F RID: 53775 RVA: 0x001EF55B File Offset: 0x001ED75B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A84 RID: 10884
		// (get) Token: 0x0600D210 RID: 53776 RVA: 0x001EF55E File Offset: 0x001ED75E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LongPressInteractActionCtxPb.Descriptor;
			}
		}

		// Token: 0x0600D211 RID: 53777 RVA: 0x001EF565 File Offset: 0x001ED765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongPressInteractActionCtxPb()
		{
		}

		// Token: 0x0600D212 RID: 53778 RVA: 0x001EF570 File Offset: 0x001ED770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongPressInteractActionCtxPb(LongPressInteractActionCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.optionIndex_ = other.optionIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D213 RID: 53779 RVA: 0x001EF5BC File Offset: 0x001ED7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongPressInteractActionCtxPb Clone()
		{
			return new LongPressInteractActionCtxPb(this);
		}

		// Token: 0x17002A85 RID: 10885
		// (get) Token: 0x0600D214 RID: 53780 RVA: 0x001EF5C4 File Offset: 0x001ED7C4
		// (set) Token: 0x0600D215 RID: 53781 RVA: 0x001EF5CC File Offset: 0x001ED7CC
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

		// Token: 0x17002A86 RID: 10886
		// (get) Token: 0x0600D216 RID: 53782 RVA: 0x001EF5D5 File Offset: 0x001ED7D5
		// (set) Token: 0x0600D217 RID: 53783 RVA: 0x001EF5DD File Offset: 0x001ED7DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OptionIndex
		{
			get
			{
				return this.optionIndex_;
			}
			set
			{
				this.optionIndex_ = value;
			}
		}

		// Token: 0x0600D218 RID: 53784 RVA: 0x001EF5E6 File Offset: 0x001ED7E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LongPressInteractActionCtxPb);
		}

		// Token: 0x0600D219 RID: 53785 RVA: 0x001EF5F4 File Offset: 0x001ED7F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LongPressInteractActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.OptionIndex == other.OptionIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D21A RID: 53786 RVA: 0x001EF644 File Offset: 0x001ED844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.entityCtx_ != null)
			{
				num ^= this.EntityCtx.GetHashCode();
			}
			if (this.OptionIndex != 0)
			{
				num ^= this.OptionIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D21B RID: 53787 RVA: 0x001EF699 File Offset: 0x001ED899
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D21C RID: 53788 RVA: 0x001EF6A6 File Offset: 0x001ED8A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D21D RID: 53789 RVA: 0x001EF6B0 File Offset: 0x001ED8B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityCtx);
			}
			if (this.OptionIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.OptionIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D21E RID: 53790 RVA: 0x001EF70C File Offset: 0x001ED90C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.entityCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityCtx);
			}
			if (this.OptionIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OptionIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D21F RID: 53791 RVA: 0x001EF764 File Offset: 0x001ED964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LongPressInteractActionCtxPb other)
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
			if (other.OptionIndex != 0)
			{
				this.OptionIndex = other.OptionIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D220 RID: 53792 RVA: 0x001EF7CC File Offset: 0x001ED9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D221 RID: 53793 RVA: 0x001EF7D8 File Offset: 0x001ED9D8
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.OptionIndex = input.ReadInt32();
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

		// Token: 0x04005868 RID: 22632
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005869 RID: 22633
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x0400586A RID: 22634
		private EntityCtxPb entityCtx_;

		// Token: 0x0400586B RID: 22635
		public const int OptionIndexFieldNumber = 2;

		// Token: 0x0400586C RID: 22636
		private int optionIndex_;
	}
}
