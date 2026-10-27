using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B5B RID: 2907
	public sealed class NormalInteractCtxPb : IMessage<NormalInteractCtxPb>, IMessage, IEquatable<NormalInteractCtxPb>, IDeepCloneable<NormalInteractCtxPb>, IBufferMessage
	{
		// Token: 0x0600FBF8 RID: 64504 RVA: 0x0024B42F File Offset: 0x0024962F
		[NullableContext(1)]
		public static NormalInteractCtxPb Create()
		{
			return new NormalInteractCtxPb();
		}

		// Token: 0x1700335F RID: 13151
		// (get) Token: 0x0600FBF9 RID: 64505 RVA: 0x0024B436 File Offset: 0x00249636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003360 RID: 13152
		// (get) Token: 0x0600FBFA RID: 64506 RVA: 0x0024B439 File Offset: 0x00249639
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NormalInteractCtxPb.Descriptor;
			}
		}

		// Token: 0x0600FBFB RID: 64507 RVA: 0x0024B440 File Offset: 0x00249640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalInteractCtxPb()
		{
		}

		// Token: 0x0600FBFC RID: 64508 RVA: 0x0024B448 File Offset: 0x00249648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalInteractCtxPb(NormalInteractCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.optionIndex_ = other.optionIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FBFD RID: 64509 RVA: 0x0024B494 File Offset: 0x00249694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalInteractCtxPb Clone()
		{
			return new NormalInteractCtxPb(this);
		}

		// Token: 0x17003361 RID: 13153
		// (get) Token: 0x0600FBFE RID: 64510 RVA: 0x0024B49C File Offset: 0x0024969C
		// (set) Token: 0x0600FBFF RID: 64511 RVA: 0x0024B4A4 File Offset: 0x002496A4
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

		// Token: 0x17003362 RID: 13154
		// (get) Token: 0x0600FC00 RID: 64512 RVA: 0x0024B4AD File Offset: 0x002496AD
		// (set) Token: 0x0600FC01 RID: 64513 RVA: 0x0024B4B5 File Offset: 0x002496B5
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

		// Token: 0x0600FC02 RID: 64514 RVA: 0x0024B4BE File Offset: 0x002496BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NormalInteractCtxPb);
		}

		// Token: 0x0600FC03 RID: 64515 RVA: 0x0024B4CC File Offset: 0x002496CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NormalInteractCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.OptionIndex == other.OptionIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FC04 RID: 64516 RVA: 0x0024B51C File Offset: 0x0024971C
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

		// Token: 0x0600FC05 RID: 64517 RVA: 0x0024B571 File Offset: 0x00249771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FC06 RID: 64518 RVA: 0x0024B57E File Offset: 0x0024977E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FC07 RID: 64519 RVA: 0x0024B588 File Offset: 0x00249788
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

		// Token: 0x0600FC08 RID: 64520 RVA: 0x0024B5E4 File Offset: 0x002497E4
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

		// Token: 0x0600FC09 RID: 64521 RVA: 0x0024B63C File Offset: 0x0024983C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NormalInteractCtxPb other)
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

		// Token: 0x0600FC0A RID: 64522 RVA: 0x0024B6A4 File Offset: 0x002498A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FC0B RID: 64523 RVA: 0x0024B6B0 File Offset: 0x002498B0
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

		// Token: 0x040064A7 RID: 25767
		private UnknownFieldSet _unknownFields;

		// Token: 0x040064A8 RID: 25768
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x040064A9 RID: 25769
		private EntityCtxPb entityCtx_;

		// Token: 0x040064AA RID: 25770
		public const int OptionIndexFieldNumber = 2;

		// Token: 0x040064AB RID: 25771
		private int optionIndex_;
	}
}
