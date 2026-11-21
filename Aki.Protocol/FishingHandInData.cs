using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000547 RID: 1351
	public sealed class FishingHandInData : IMessage<FishingHandInData>, IMessage, IEquatable<FishingHandInData>, IDeepCloneable<FishingHandInData>, IBufferMessage
	{
		// Token: 0x06007E8D RID: 32397 RVA: 0x001325C1 File Offset: 0x001307C1
		[NullableContext(1)]
		public static FishingHandInData Create()
		{
			return new FishingHandInData();
		}

		// Token: 0x17001898 RID: 6296
		// (get) Token: 0x06007E8E RID: 32398 RVA: 0x001325C8 File Offset: 0x001307C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001899 RID: 6297
		// (get) Token: 0x06007E8F RID: 32399 RVA: 0x001325CB File Offset: 0x001307CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingHandInData.Descriptor;
			}
		}

		// Token: 0x06007E90 RID: 32400 RVA: 0x001325D2 File Offset: 0x001307D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingHandInData()
		{
		}

		// Token: 0x06007E91 RID: 32401 RVA: 0x001325DA File Offset: 0x001307DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingHandInData(FishingHandInData other) : this()
		{
			this.handInId_ = other.handInId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007E92 RID: 32402 RVA: 0x001325FF File Offset: 0x001307FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingHandInData Clone()
		{
			return new FishingHandInData(this);
		}

		// Token: 0x1700189A RID: 6298
		// (get) Token: 0x06007E93 RID: 32403 RVA: 0x00132607 File Offset: 0x00130807
		// (set) Token: 0x06007E94 RID: 32404 RVA: 0x0013260F File Offset: 0x0013080F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HandInId
		{
			get
			{
				return this.handInId_;
			}
			set
			{
				this.handInId_ = value;
			}
		}

		// Token: 0x06007E95 RID: 32405 RVA: 0x00132618 File Offset: 0x00130818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingHandInData);
		}

		// Token: 0x06007E96 RID: 32406 RVA: 0x00132626 File Offset: 0x00130826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingHandInData other)
		{
			return other != null && (other == this || (this.HandInId == other.HandInId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007E97 RID: 32407 RVA: 0x00132654 File Offset: 0x00130854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HandInId != 0)
			{
				num ^= this.HandInId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007E98 RID: 32408 RVA: 0x00132693 File Offset: 0x00130893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007E99 RID: 32409 RVA: 0x001326A0 File Offset: 0x001308A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007E9A RID: 32410 RVA: 0x001326A9 File Offset: 0x001308A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HandInId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.HandInId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007E9B RID: 32411 RVA: 0x001326DC File Offset: 0x001308DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HandInId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HandInId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007E9C RID: 32412 RVA: 0x0013271A File Offset: 0x0013091A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingHandInData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HandInId != 0)
			{
				this.HandInId = other.HandInId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007E9D RID: 32413 RVA: 0x0013274B File Offset: 0x0013094B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007E9E RID: 32414 RVA: 0x00132754 File Offset: 0x00130954
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.HandInId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400406F RID: 16495
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004070 RID: 16496
		public const int HandInIdFieldNumber = 1;

		// Token: 0x04004071 RID: 16497
		private int handInId_;
	}
}
