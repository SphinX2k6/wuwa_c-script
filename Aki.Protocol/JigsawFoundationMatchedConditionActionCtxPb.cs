using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200084E RID: 2126
	public sealed class JigsawFoundationMatchedConditionActionCtxPb : IMessage<JigsawFoundationMatchedConditionActionCtxPb>, IMessage, IEquatable<JigsawFoundationMatchedConditionActionCtxPb>, IDeepCloneable<JigsawFoundationMatchedConditionActionCtxPb>, IBufferMessage
	{
		// Token: 0x0600BDE9 RID: 48617 RVA: 0x001C3AA7 File Offset: 0x001C1CA7
		[NullableContext(1)]
		public static JigsawFoundationMatchedConditionActionCtxPb Create()
		{
			return new JigsawFoundationMatchedConditionActionCtxPb();
		}

		// Token: 0x17002656 RID: 9814
		// (get) Token: 0x0600BDEA RID: 48618 RVA: 0x001C3AAE File Offset: 0x001C1CAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002657 RID: 9815
		// (get) Token: 0x0600BDEB RID: 48619 RVA: 0x001C3AB1 File Offset: 0x001C1CB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JigsawFoundationMatchedConditionActionCtxPb.Descriptor;
			}
		}

		// Token: 0x0600BDEC RID: 48620 RVA: 0x001C3AB8 File Offset: 0x001C1CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JigsawFoundationMatchedConditionActionCtxPb()
		{
		}

		// Token: 0x0600BDED RID: 48621 RVA: 0x001C3AC0 File Offset: 0x001C1CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JigsawFoundationMatchedConditionActionCtxPb(JigsawFoundationMatchedConditionActionCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.matchedIndex_ = other.matchedIndex_;
			this.conditionIndex_ = other.conditionIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BDEE RID: 48622 RVA: 0x001C3B18 File Offset: 0x001C1D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JigsawFoundationMatchedConditionActionCtxPb Clone()
		{
			return new JigsawFoundationMatchedConditionActionCtxPb(this);
		}

		// Token: 0x17002658 RID: 9816
		// (get) Token: 0x0600BDEF RID: 48623 RVA: 0x001C3B20 File Offset: 0x001C1D20
		// (set) Token: 0x0600BDF0 RID: 48624 RVA: 0x001C3B28 File Offset: 0x001C1D28
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

		// Token: 0x17002659 RID: 9817
		// (get) Token: 0x0600BDF1 RID: 48625 RVA: 0x001C3B31 File Offset: 0x001C1D31
		// (set) Token: 0x0600BDF2 RID: 48626 RVA: 0x001C3B39 File Offset: 0x001C1D39
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

		// Token: 0x1700265A RID: 9818
		// (get) Token: 0x0600BDF3 RID: 48627 RVA: 0x001C3B42 File Offset: 0x001C1D42
		// (set) Token: 0x0600BDF4 RID: 48628 RVA: 0x001C3B4A File Offset: 0x001C1D4A
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

		// Token: 0x0600BDF5 RID: 48629 RVA: 0x001C3B53 File Offset: 0x001C1D53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JigsawFoundationMatchedConditionActionCtxPb);
		}

		// Token: 0x0600BDF6 RID: 48630 RVA: 0x001C3B64 File Offset: 0x001C1D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JigsawFoundationMatchedConditionActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.MatchedIndex == other.MatchedIndex && this.ConditionIndex == other.ConditionIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BDF7 RID: 48631 RVA: 0x001C3BC4 File Offset: 0x001C1DC4
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

		// Token: 0x0600BDF8 RID: 48632 RVA: 0x001C3C32 File Offset: 0x001C1E32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BDF9 RID: 48633 RVA: 0x001C3C3F File Offset: 0x001C1E3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BDFA RID: 48634 RVA: 0x001C3C48 File Offset: 0x001C1E48
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

		// Token: 0x0600BDFB RID: 48635 RVA: 0x001C3CC0 File Offset: 0x001C1EC0
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

		// Token: 0x0600BDFC RID: 48636 RVA: 0x001C3D30 File Offset: 0x001C1F30
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

		// Token: 0x0600BDFD RID: 48637 RVA: 0x001C3DAC File Offset: 0x001C1FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BDFE RID: 48638 RVA: 0x001C3DB8 File Offset: 0x001C1FB8
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

		// Token: 0x04005343 RID: 21315
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005344 RID: 21316
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04005345 RID: 21317
		private EntityCtxPb entityCtx_;

		// Token: 0x04005346 RID: 21318
		public const int MatchedIndexFieldNumber = 2;

		// Token: 0x04005347 RID: 21319
		private int matchedIndex_;

		// Token: 0x04005348 RID: 21320
		public const int ConditionIndexFieldNumber = 3;

		// Token: 0x04005349 RID: 21321
		private int conditionIndex_;
	}
}
