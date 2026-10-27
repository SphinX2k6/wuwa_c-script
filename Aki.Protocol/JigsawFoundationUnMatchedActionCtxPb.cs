using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000861 RID: 2145
	public sealed class JigsawFoundationUnMatchedActionCtxPb : IMessage<JigsawFoundationUnMatchedActionCtxPb>, IMessage, IEquatable<JigsawFoundationUnMatchedActionCtxPb>, IDeepCloneable<JigsawFoundationUnMatchedActionCtxPb>, IBufferMessage
	{
		// Token: 0x0600BF2D RID: 48941 RVA: 0x001C62FE File Offset: 0x001C44FE
		[NullableContext(1)]
		public static JigsawFoundationUnMatchedActionCtxPb Create()
		{
			return new JigsawFoundationUnMatchedActionCtxPb();
		}

		// Token: 0x1700269D RID: 9885
		// (get) Token: 0x0600BF2E RID: 48942 RVA: 0x001C6305 File Offset: 0x001C4505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700269E RID: 9886
		// (get) Token: 0x0600BF2F RID: 48943 RVA: 0x001C6308 File Offset: 0x001C4508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JigsawFoundationUnMatchedActionCtxPb.Descriptor;
			}
		}

		// Token: 0x0600BF30 RID: 48944 RVA: 0x001C630F File Offset: 0x001C450F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JigsawFoundationUnMatchedActionCtxPb()
		{
		}

		// Token: 0x0600BF31 RID: 48945 RVA: 0x001C6318 File Offset: 0x001C4518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JigsawFoundationUnMatchedActionCtxPb(JigsawFoundationUnMatchedActionCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.matchedIndex_ = other.matchedIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BF32 RID: 48946 RVA: 0x001C6364 File Offset: 0x001C4564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JigsawFoundationUnMatchedActionCtxPb Clone()
		{
			return new JigsawFoundationUnMatchedActionCtxPb(this);
		}

		// Token: 0x1700269F RID: 9887
		// (get) Token: 0x0600BF33 RID: 48947 RVA: 0x001C636C File Offset: 0x001C456C
		// (set) Token: 0x0600BF34 RID: 48948 RVA: 0x001C6374 File Offset: 0x001C4574
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

		// Token: 0x170026A0 RID: 9888
		// (get) Token: 0x0600BF35 RID: 48949 RVA: 0x001C637D File Offset: 0x001C457D
		// (set) Token: 0x0600BF36 RID: 48950 RVA: 0x001C6385 File Offset: 0x001C4585
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

		// Token: 0x0600BF37 RID: 48951 RVA: 0x001C638E File Offset: 0x001C458E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JigsawFoundationUnMatchedActionCtxPb);
		}

		// Token: 0x0600BF38 RID: 48952 RVA: 0x001C639C File Offset: 0x001C459C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JigsawFoundationUnMatchedActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.MatchedIndex == other.MatchedIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BF39 RID: 48953 RVA: 0x001C63EC File Offset: 0x001C45EC
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

		// Token: 0x0600BF3A RID: 48954 RVA: 0x001C6441 File Offset: 0x001C4641
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BF3B RID: 48955 RVA: 0x001C644E File Offset: 0x001C464E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BF3C RID: 48956 RVA: 0x001C6458 File Offset: 0x001C4658
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

		// Token: 0x0600BF3D RID: 48957 RVA: 0x001C64B4 File Offset: 0x001C46B4
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

		// Token: 0x0600BF3E RID: 48958 RVA: 0x001C650C File Offset: 0x001C470C
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

		// Token: 0x0600BF3F RID: 48959 RVA: 0x001C6574 File Offset: 0x001C4774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BF40 RID: 48960 RVA: 0x001C6580 File Offset: 0x001C4780
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

		// Token: 0x04005347 RID: 21319
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005348 RID: 21320
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04005349 RID: 21321
		private EntityCtxPb entityCtx_;

		// Token: 0x0400534A RID: 21322
		public const int MatchedIndexFieldNumber = 2;

		// Token: 0x0400534B RID: 21323
		private int matchedIndex_;
	}
}
