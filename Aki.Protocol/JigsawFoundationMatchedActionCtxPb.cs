using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200085F RID: 2143
	public sealed class JigsawFoundationMatchedActionCtxPb : IMessage<JigsawFoundationMatchedActionCtxPb>, IMessage, IEquatable<JigsawFoundationMatchedActionCtxPb>, IDeepCloneable<JigsawFoundationMatchedActionCtxPb>, IBufferMessage
	{
		// Token: 0x0600BF03 RID: 48899 RVA: 0x001C5C81 File Offset: 0x001C3E81
		[NullableContext(1)]
		public static JigsawFoundationMatchedActionCtxPb Create()
		{
			return new JigsawFoundationMatchedActionCtxPb();
		}

		// Token: 0x17002694 RID: 9876
		// (get) Token: 0x0600BF04 RID: 48900 RVA: 0x001C5C88 File Offset: 0x001C3E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002695 RID: 9877
		// (get) Token: 0x0600BF05 RID: 48901 RVA: 0x001C5C8B File Offset: 0x001C3E8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JigsawFoundationMatchedActionCtxPb.Descriptor;
			}
		}

		// Token: 0x0600BF06 RID: 48902 RVA: 0x001C5C92 File Offset: 0x001C3E92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JigsawFoundationMatchedActionCtxPb()
		{
		}

		// Token: 0x0600BF07 RID: 48903 RVA: 0x001C5C9C File Offset: 0x001C3E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JigsawFoundationMatchedActionCtxPb(JigsawFoundationMatchedActionCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.matchedIndex_ = other.matchedIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BF08 RID: 48904 RVA: 0x001C5CE8 File Offset: 0x001C3EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JigsawFoundationMatchedActionCtxPb Clone()
		{
			return new JigsawFoundationMatchedActionCtxPb(this);
		}

		// Token: 0x17002696 RID: 9878
		// (get) Token: 0x0600BF09 RID: 48905 RVA: 0x001C5CF0 File Offset: 0x001C3EF0
		// (set) Token: 0x0600BF0A RID: 48906 RVA: 0x001C5CF8 File Offset: 0x001C3EF8
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

		// Token: 0x17002697 RID: 9879
		// (get) Token: 0x0600BF0B RID: 48907 RVA: 0x001C5D01 File Offset: 0x001C3F01
		// (set) Token: 0x0600BF0C RID: 48908 RVA: 0x001C5D09 File Offset: 0x001C3F09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MatchedIndex
		{
			get
			{
				return this.matchedIndex_;
			}
			set
			{
				this.matchedIndex_ = value;
			}
		}

		// Token: 0x0600BF0D RID: 48909 RVA: 0x001C5D12 File Offset: 0x001C3F12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JigsawFoundationMatchedActionCtxPb);
		}

		// Token: 0x0600BF0E RID: 48910 RVA: 0x001C5D20 File Offset: 0x001C3F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JigsawFoundationMatchedActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.MatchedIndex == other.MatchedIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BF0F RID: 48911 RVA: 0x001C5D70 File Offset: 0x001C3F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.entityCtx_ != null)
			{
				num ^= this.EntityCtx.GetHashCode();
			}
			if (this.MatchedIndex != 0)
			{
				num ^= this.MatchedIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BF10 RID: 48912 RVA: 0x001C5DC5 File Offset: 0x001C3FC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BF11 RID: 48913 RVA: 0x001C5DD2 File Offset: 0x001C3FD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BF12 RID: 48914 RVA: 0x001C5DDC File Offset: 0x001C3FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityCtx);
			}
			if (this.MatchedIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MatchedIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BF13 RID: 48915 RVA: 0x001C5E38 File Offset: 0x001C4038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.entityCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityCtx);
			}
			if (this.MatchedIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MatchedIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BF14 RID: 48916 RVA: 0x001C5E90 File Offset: 0x001C4090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JigsawFoundationMatchedActionCtxPb other)
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
			if (other.MatchedIndex != 0)
			{
				this.MatchedIndex = other.MatchedIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BF15 RID: 48917 RVA: 0x001C5EF8 File Offset: 0x001C40F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BF16 RID: 48918 RVA: 0x001C5F04 File Offset: 0x001C4104
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
						this.MatchedIndex = input.ReadInt32();
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

		// Token: 0x0400533B RID: 21307
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400533C RID: 21308
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x0400533D RID: 21309
		private EntityCtxPb entityCtx_;

		// Token: 0x0400533E RID: 21310
		public const int MatchedIndexFieldNumber = 2;

		// Token: 0x0400533F RID: 21311
		private int matchedIndex_;
	}
}
