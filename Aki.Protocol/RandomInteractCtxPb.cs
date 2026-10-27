using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E82 RID: 3714
	public sealed class RandomInteractCtxPb : IMessage<RandomInteractCtxPb>, IMessage, IEquatable<RandomInteractCtxPb>, IDeepCloneable<RandomInteractCtxPb>, IBufferMessage
	{
		// Token: 0x06013F21 RID: 81697 RVA: 0x002E75B8 File Offset: 0x002E57B8
		[NullableContext(1)]
		public static RandomInteractCtxPb Create()
		{
			return new RandomInteractCtxPb();
		}

		// Token: 0x17004254 RID: 16980
		// (get) Token: 0x06013F22 RID: 81698 RVA: 0x002E75BF File Offset: 0x002E57BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004255 RID: 16981
		// (get) Token: 0x06013F23 RID: 81699 RVA: 0x002E75C2 File Offset: 0x002E57C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RandomInteractCtxPb.Descriptor;
			}
		}

		// Token: 0x06013F24 RID: 81700 RVA: 0x002E75C9 File Offset: 0x002E57C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RandomInteractCtxPb()
		{
		}

		// Token: 0x06013F25 RID: 81701 RVA: 0x002E75D4 File Offset: 0x002E57D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RandomInteractCtxPb(RandomInteractCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.optionIndex_ = other.optionIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013F26 RID: 81702 RVA: 0x002E7620 File Offset: 0x002E5820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RandomInteractCtxPb Clone()
		{
			return new RandomInteractCtxPb(this);
		}

		// Token: 0x17004256 RID: 16982
		// (get) Token: 0x06013F27 RID: 81703 RVA: 0x002E7628 File Offset: 0x002E5828
		// (set) Token: 0x06013F28 RID: 81704 RVA: 0x002E7630 File Offset: 0x002E5830
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

		// Token: 0x17004257 RID: 16983
		// (get) Token: 0x06013F29 RID: 81705 RVA: 0x002E7639 File Offset: 0x002E5839
		// (set) Token: 0x06013F2A RID: 81706 RVA: 0x002E7641 File Offset: 0x002E5841
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

		// Token: 0x06013F2B RID: 81707 RVA: 0x002E764A File Offset: 0x002E584A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RandomInteractCtxPb);
		}

		// Token: 0x06013F2C RID: 81708 RVA: 0x002E7658 File Offset: 0x002E5858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RandomInteractCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.OptionIndex == other.OptionIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013F2D RID: 81709 RVA: 0x002E76A8 File Offset: 0x002E58A8
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

		// Token: 0x06013F2E RID: 81710 RVA: 0x002E76FD File Offset: 0x002E58FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013F2F RID: 81711 RVA: 0x002E770A File Offset: 0x002E590A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013F30 RID: 81712 RVA: 0x002E7714 File Offset: 0x002E5914
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

		// Token: 0x06013F31 RID: 81713 RVA: 0x002E7770 File Offset: 0x002E5970
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

		// Token: 0x06013F32 RID: 81714 RVA: 0x002E77C8 File Offset: 0x002E59C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RandomInteractCtxPb other)
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

		// Token: 0x06013F33 RID: 81715 RVA: 0x002E7830 File Offset: 0x002E5A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013F34 RID: 81716 RVA: 0x002E783C File Offset: 0x002E5A3C
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

		// Token: 0x040079DA RID: 31194
		private UnknownFieldSet _unknownFields;

		// Token: 0x040079DB RID: 31195
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x040079DC RID: 31196
		private EntityCtxPb entityCtx_;

		// Token: 0x040079DD RID: 31197
		public const int OptionIndexFieldNumber = 2;

		// Token: 0x040079DE RID: 31198
		private int optionIndex_;
	}
}
