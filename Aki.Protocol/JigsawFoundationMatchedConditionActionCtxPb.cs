using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000860 RID: 2144
	public sealed class JigsawFoundationMatchedConditionActionCtxPb : IMessage<JigsawFoundationMatchedConditionActionCtxPb>, IMessage, IEquatable<JigsawFoundationMatchedConditionActionCtxPb>, IDeepCloneable<JigsawFoundationMatchedConditionActionCtxPb>, IBufferMessage
	{
		// Token: 0x0600BF17 RID: 48919 RVA: 0x001C5F6F File Offset: 0x001C416F
		[NullableContext(1)]
		public static JigsawFoundationMatchedConditionActionCtxPb Create()
		{
			return new JigsawFoundationMatchedConditionActionCtxPb();
		}

		// Token: 0x17002698 RID: 9880
		// (get) Token: 0x0600BF18 RID: 48920 RVA: 0x001C5F76 File Offset: 0x001C4176
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002699 RID: 9881
		// (get) Token: 0x0600BF19 RID: 48921 RVA: 0x001C5F79 File Offset: 0x001C4179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JigsawFoundationMatchedConditionActionCtxPb.Descriptor;
			}
		}

		// Token: 0x0600BF1A RID: 48922 RVA: 0x001C5F80 File Offset: 0x001C4180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JigsawFoundationMatchedConditionActionCtxPb()
		{
		}

		// Token: 0x0600BF1B RID: 48923 RVA: 0x001C5F88 File Offset: 0x001C4188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JigsawFoundationMatchedConditionActionCtxPb(JigsawFoundationMatchedConditionActionCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.matchedIndex_ = other.matchedIndex_;
			this.conditionIndex_ = other.conditionIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BF1C RID: 48924 RVA: 0x001C5FE0 File Offset: 0x001C41E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JigsawFoundationMatchedConditionActionCtxPb Clone()
		{
			return new JigsawFoundationMatchedConditionActionCtxPb(this);
		}

		// Token: 0x1700269A RID: 9882
		// (get) Token: 0x0600BF1D RID: 48925 RVA: 0x001C5FE8 File Offset: 0x001C41E8
		// (set) Token: 0x0600BF1E RID: 48926 RVA: 0x001C5FF0 File Offset: 0x001C41F0
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

		// Token: 0x1700269B RID: 9883
		// (get) Token: 0x0600BF1F RID: 48927 RVA: 0x001C5FF9 File Offset: 0x001C41F9
		// (set) Token: 0x0600BF20 RID: 48928 RVA: 0x001C6001 File Offset: 0x001C4201
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

		// Token: 0x1700269C RID: 9884
		// (get) Token: 0x0600BF21 RID: 48929 RVA: 0x001C600A File Offset: 0x001C420A
		// (set) Token: 0x0600BF22 RID: 48930 RVA: 0x001C6012 File Offset: 0x001C4212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConditionIndex
		{
			get
			{
				return this.conditionIndex_;
			}
			set
			{
				this.conditionIndex_ = value;
			}
		}

		// Token: 0x0600BF23 RID: 48931 RVA: 0x001C601B File Offset: 0x001C421B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JigsawFoundationMatchedConditionActionCtxPb);
		}

		// Token: 0x0600BF24 RID: 48932 RVA: 0x001C602C File Offset: 0x001C422C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JigsawFoundationMatchedConditionActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.MatchedIndex == other.MatchedIndex && this.ConditionIndex == other.ConditionIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BF25 RID: 48933 RVA: 0x001C608C File Offset: 0x001C428C
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
			if (this.ConditionIndex != 0)
			{
				num ^= this.ConditionIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BF26 RID: 48934 RVA: 0x001C60FA File Offset: 0x001C42FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BF27 RID: 48935 RVA: 0x001C6107 File Offset: 0x001C4307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BF28 RID: 48936 RVA: 0x001C6110 File Offset: 0x001C4310
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
			if (this.ConditionIndex != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ConditionIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BF29 RID: 48937 RVA: 0x001C6188 File Offset: 0x001C4388
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
			if (this.ConditionIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConditionIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BF2A RID: 48938 RVA: 0x001C61F8 File Offset: 0x001C43F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JigsawFoundationMatchedConditionActionCtxPb other)
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
			if (other.ConditionIndex != 0)
			{
				this.ConditionIndex = other.ConditionIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BF2B RID: 48939 RVA: 0x001C6274 File Offset: 0x001C4474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BF2C RID: 48940 RVA: 0x001C6280 File Offset: 0x001C4480
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
							this.ConditionIndex = input.ReadInt32();
						}
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

		// Token: 0x04005340 RID: 21312
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005341 RID: 21313
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04005342 RID: 21314
		private EntityCtxPb entityCtx_;

		// Token: 0x04005343 RID: 21315
		public const int MatchedIndexFieldNumber = 2;

		// Token: 0x04005344 RID: 21316
		private int matchedIndex_;

		// Token: 0x04005345 RID: 21317
		public const int ConditionIndexFieldNumber = 3;

		// Token: 0x04005346 RID: 21318
		private int conditionIndex_;
	}
}
