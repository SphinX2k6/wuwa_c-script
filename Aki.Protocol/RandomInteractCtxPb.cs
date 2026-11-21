using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E72 RID: 3698
	public sealed class RandomInteractCtxPb : IMessage<RandomInteractCtxPb>, IMessage, IEquatable<RandomInteractCtxPb>, IDeepCloneable<RandomInteractCtxPb>, IBufferMessage
	{
		// Token: 0x06013E3C RID: 81468 RVA: 0x002E5EFC File Offset: 0x002E40FC
		[NullableContext(1)]
		public static RandomInteractCtxPb Create()
		{
			return new RandomInteractCtxPb();
		}

		// Token: 0x1700422A RID: 16938
		// (get) Token: 0x06013E3D RID: 81469 RVA: 0x002E5F03 File Offset: 0x002E4103
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700422B RID: 16939
		// (get) Token: 0x06013E3E RID: 81470 RVA: 0x002E5F06 File Offset: 0x002E4106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RandomInteractCtxPb.Descriptor;
			}
		}

		// Token: 0x06013E3F RID: 81471 RVA: 0x002E5F0D File Offset: 0x002E410D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RandomInteractCtxPb()
		{
		}

		// Token: 0x06013E40 RID: 81472 RVA: 0x002E5F18 File Offset: 0x002E4118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RandomInteractCtxPb(RandomInteractCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.optionIndex_ = other.optionIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013E41 RID: 81473 RVA: 0x002E5F64 File Offset: 0x002E4164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RandomInteractCtxPb Clone()
		{
			return new RandomInteractCtxPb(this);
		}

		// Token: 0x1700422C RID: 16940
		// (get) Token: 0x06013E42 RID: 81474 RVA: 0x002E5F6C File Offset: 0x002E416C
		// (set) Token: 0x06013E43 RID: 81475 RVA: 0x002E5F74 File Offset: 0x002E4174
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

		// Token: 0x1700422D RID: 16941
		// (get) Token: 0x06013E44 RID: 81476 RVA: 0x002E5F7D File Offset: 0x002E417D
		// (set) Token: 0x06013E45 RID: 81477 RVA: 0x002E5F85 File Offset: 0x002E4185
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

		// Token: 0x06013E46 RID: 81478 RVA: 0x002E5F8E File Offset: 0x002E418E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RandomInteractCtxPb);
		}

		// Token: 0x06013E47 RID: 81479 RVA: 0x002E5F9C File Offset: 0x002E419C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RandomInteractCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.OptionIndex == other.OptionIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013E48 RID: 81480 RVA: 0x002E5FEC File Offset: 0x002E41EC
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

		// Token: 0x06013E49 RID: 81481 RVA: 0x002E6041 File Offset: 0x002E4241
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013E4A RID: 81482 RVA: 0x002E604E File Offset: 0x002E424E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013E4B RID: 81483 RVA: 0x002E6058 File Offset: 0x002E4258
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

		// Token: 0x06013E4C RID: 81484 RVA: 0x002E60B4 File Offset: 0x002E42B4
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

		// Token: 0x06013E4D RID: 81485 RVA: 0x002E610C File Offset: 0x002E430C
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

		// Token: 0x06013E4E RID: 81486 RVA: 0x002E6174 File Offset: 0x002E4374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013E4F RID: 81487 RVA: 0x002E6180 File Offset: 0x002E4380
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

		// Token: 0x04007A04 RID: 31236
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A05 RID: 31237
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04007A06 RID: 31238
		private EntityCtxPb entityCtx_;

		// Token: 0x04007A07 RID: 31239
		public const int OptionIndexFieldNumber = 2;

		// Token: 0x04007A08 RID: 31240
		private int optionIndex_;
	}
}
