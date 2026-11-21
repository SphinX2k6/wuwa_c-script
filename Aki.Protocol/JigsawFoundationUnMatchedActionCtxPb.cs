using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200084F RID: 2127
	public sealed class JigsawFoundationUnMatchedActionCtxPb : IMessage<JigsawFoundationUnMatchedActionCtxPb>, IMessage, IEquatable<JigsawFoundationUnMatchedActionCtxPb>, IDeepCloneable<JigsawFoundationUnMatchedActionCtxPb>, IBufferMessage
	{
		// Token: 0x0600BDFF RID: 48639 RVA: 0x001C3E36 File Offset: 0x001C2036
		[NullableContext(1)]
		public static JigsawFoundationUnMatchedActionCtxPb Create()
		{
			return new JigsawFoundationUnMatchedActionCtxPb();
		}

		// Token: 0x1700265B RID: 9819
		// (get) Token: 0x0600BE00 RID: 48640 RVA: 0x001C3E3D File Offset: 0x001C203D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700265C RID: 9820
		// (get) Token: 0x0600BE01 RID: 48641 RVA: 0x001C3E40 File Offset: 0x001C2040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JigsawFoundationUnMatchedActionCtxPb.Descriptor;
			}
		}

		// Token: 0x0600BE02 RID: 48642 RVA: 0x001C3E47 File Offset: 0x001C2047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JigsawFoundationUnMatchedActionCtxPb()
		{
		}

		// Token: 0x0600BE03 RID: 48643 RVA: 0x001C3E50 File Offset: 0x001C2050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JigsawFoundationUnMatchedActionCtxPb(JigsawFoundationUnMatchedActionCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.matchedIndex_ = other.matchedIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BE04 RID: 48644 RVA: 0x001C3E9C File Offset: 0x001C209C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JigsawFoundationUnMatchedActionCtxPb Clone()
		{
			return new JigsawFoundationUnMatchedActionCtxPb(this);
		}

		// Token: 0x1700265D RID: 9821
		// (get) Token: 0x0600BE05 RID: 48645 RVA: 0x001C3EA4 File Offset: 0x001C20A4
		// (set) Token: 0x0600BE06 RID: 48646 RVA: 0x001C3EAC File Offset: 0x001C20AC
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

		// Token: 0x1700265E RID: 9822
		// (get) Token: 0x0600BE07 RID: 48647 RVA: 0x001C3EB5 File Offset: 0x001C20B5
		// (set) Token: 0x0600BE08 RID: 48648 RVA: 0x001C3EBD File Offset: 0x001C20BD
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

		// Token: 0x0600BE09 RID: 48649 RVA: 0x001C3EC6 File Offset: 0x001C20C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JigsawFoundationUnMatchedActionCtxPb);
		}

		// Token: 0x0600BE0A RID: 48650 RVA: 0x001C3ED4 File Offset: 0x001C20D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JigsawFoundationUnMatchedActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.MatchedIndex == other.MatchedIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BE0B RID: 48651 RVA: 0x001C3F24 File Offset: 0x001C2124
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

		// Token: 0x0600BE0C RID: 48652 RVA: 0x001C3F79 File Offset: 0x001C2179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BE0D RID: 48653 RVA: 0x001C3F86 File Offset: 0x001C2186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BE0E RID: 48654 RVA: 0x001C3F90 File Offset: 0x001C2190
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

		// Token: 0x0600BE0F RID: 48655 RVA: 0x001C3FEC File Offset: 0x001C21EC
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

		// Token: 0x0600BE10 RID: 48656 RVA: 0x001C4044 File Offset: 0x001C2244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JigsawFoundationUnMatchedActionCtxPb other)
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

		// Token: 0x0600BE11 RID: 48657 RVA: 0x001C40AC File Offset: 0x001C22AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BE12 RID: 48658 RVA: 0x001C40B8 File Offset: 0x001C22B8
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

		// Token: 0x0400534A RID: 21322
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400534B RID: 21323
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x0400534C RID: 21324
		private EntityCtxPb entityCtx_;

		// Token: 0x0400534D RID: 21325
		public const int MatchedIndexFieldNumber = 2;

		// Token: 0x0400534E RID: 21326
		private int matchedIndex_;
	}
}
