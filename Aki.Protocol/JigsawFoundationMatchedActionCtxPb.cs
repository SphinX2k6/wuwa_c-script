using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200084D RID: 2125
	public sealed class JigsawFoundationMatchedActionCtxPb : IMessage<JigsawFoundationMatchedActionCtxPb>, IMessage, IEquatable<JigsawFoundationMatchedActionCtxPb>, IDeepCloneable<JigsawFoundationMatchedActionCtxPb>, IBufferMessage
	{
		// Token: 0x0600BDD5 RID: 48597 RVA: 0x001C37B9 File Offset: 0x001C19B9
		[NullableContext(1)]
		public static JigsawFoundationMatchedActionCtxPb Create()
		{
			return new JigsawFoundationMatchedActionCtxPb();
		}

		// Token: 0x17002652 RID: 9810
		// (get) Token: 0x0600BDD6 RID: 48598 RVA: 0x001C37C0 File Offset: 0x001C19C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002653 RID: 9811
		// (get) Token: 0x0600BDD7 RID: 48599 RVA: 0x001C37C3 File Offset: 0x001C19C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JigsawFoundationMatchedActionCtxPb.Descriptor;
			}
		}

		// Token: 0x0600BDD8 RID: 48600 RVA: 0x001C37CA File Offset: 0x001C19CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JigsawFoundationMatchedActionCtxPb()
		{
		}

		// Token: 0x0600BDD9 RID: 48601 RVA: 0x001C37D4 File Offset: 0x001C19D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JigsawFoundationMatchedActionCtxPb(JigsawFoundationMatchedActionCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.matchedIndex_ = other.matchedIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BDDA RID: 48602 RVA: 0x001C3820 File Offset: 0x001C1A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JigsawFoundationMatchedActionCtxPb Clone()
		{
			return new JigsawFoundationMatchedActionCtxPb(this);
		}

		// Token: 0x17002654 RID: 9812
		// (get) Token: 0x0600BDDB RID: 48603 RVA: 0x001C3828 File Offset: 0x001C1A28
		// (set) Token: 0x0600BDDC RID: 48604 RVA: 0x001C3830 File Offset: 0x001C1A30
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

		// Token: 0x17002655 RID: 9813
		// (get) Token: 0x0600BDDD RID: 48605 RVA: 0x001C3839 File Offset: 0x001C1A39
		// (set) Token: 0x0600BDDE RID: 48606 RVA: 0x001C3841 File Offset: 0x001C1A41
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

		// Token: 0x0600BDDF RID: 48607 RVA: 0x001C384A File Offset: 0x001C1A4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JigsawFoundationMatchedActionCtxPb);
		}

		// Token: 0x0600BDE0 RID: 48608 RVA: 0x001C3858 File Offset: 0x001C1A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JigsawFoundationMatchedActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.MatchedIndex == other.MatchedIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BDE1 RID: 48609 RVA: 0x001C38A8 File Offset: 0x001C1AA8
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

		// Token: 0x0600BDE2 RID: 48610 RVA: 0x001C38FD File Offset: 0x001C1AFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BDE3 RID: 48611 RVA: 0x001C390A File Offset: 0x001C1B0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BDE4 RID: 48612 RVA: 0x001C3914 File Offset: 0x001C1B14
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

		// Token: 0x0600BDE5 RID: 48613 RVA: 0x001C3970 File Offset: 0x001C1B70
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

		// Token: 0x0600BDE6 RID: 48614 RVA: 0x001C39C8 File Offset: 0x001C1BC8
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

		// Token: 0x0600BDE7 RID: 48615 RVA: 0x001C3A30 File Offset: 0x001C1C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BDE8 RID: 48616 RVA: 0x001C3A3C File Offset: 0x001C1C3C
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

		// Token: 0x0400533E RID: 21310
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400533F RID: 21311
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04005340 RID: 21312
		private EntityCtxPb entityCtx_;

		// Token: 0x04005341 RID: 21313
		public const int MatchedIndexFieldNumber = 2;

		// Token: 0x04005342 RID: 21314
		private int matchedIndex_;
	}
}
