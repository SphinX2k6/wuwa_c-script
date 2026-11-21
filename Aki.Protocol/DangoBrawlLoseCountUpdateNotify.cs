using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200036A RID: 874
	[NetMessage(EMessageId.DangoBrawlLoseCountUpdateNotify)]
	public sealed class DangoBrawlLoseCountUpdateNotify : IMessage<DangoBrawlLoseCountUpdateNotify>, IMessage, IEquatable<DangoBrawlLoseCountUpdateNotify>, IDeepCloneable<DangoBrawlLoseCountUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600574B RID: 22347 RVA: 0x000D56C9 File Offset: 0x000D38C9
		[NullableContext(1)]
		public static DangoBrawlLoseCountUpdateNotify Create()
		{
			return new DangoBrawlLoseCountUpdateNotify();
		}

		// Token: 0x17001009 RID: 4105
		// (get) Token: 0x0600574C RID: 22348 RVA: 0x000D56D0 File Offset: 0x000D38D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700100A RID: 4106
		// (get) Token: 0x0600574D RID: 22349 RVA: 0x000D56D3 File Offset: 0x000D38D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlLoseCountUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600574E RID: 22350 RVA: 0x000D56DA File Offset: 0x000D38DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlLoseCountUpdateNotify()
		{
		}

		// Token: 0x0600574F RID: 22351 RVA: 0x000D56E2 File Offset: 0x000D38E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlLoseCountUpdateNotify(DangoBrawlLoseCountUpdateNotify other) : this()
		{
			this.loseCount_ = other.loseCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005750 RID: 22352 RVA: 0x000D5707 File Offset: 0x000D3907
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlLoseCountUpdateNotify Clone()
		{
			return new DangoBrawlLoseCountUpdateNotify(this);
		}

		// Token: 0x1700100B RID: 4107
		// (get) Token: 0x06005751 RID: 22353 RVA: 0x000D570F File Offset: 0x000D390F
		// (set) Token: 0x06005752 RID: 22354 RVA: 0x000D5717 File Offset: 0x000D3917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LoseCount
		{
			get
			{
				return this.loseCount_;
			}
			set
			{
				this.loseCount_ = value;
			}
		}

		// Token: 0x06005753 RID: 22355 RVA: 0x000D5720 File Offset: 0x000D3920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlLoseCountUpdateNotify);
		}

		// Token: 0x06005754 RID: 22356 RVA: 0x000D572E File Offset: 0x000D392E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlLoseCountUpdateNotify other)
		{
			return other != null && (other == this || (this.LoseCount == other.LoseCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005755 RID: 22357 RVA: 0x000D575C File Offset: 0x000D395C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LoseCount != 0)
			{
				num ^= this.LoseCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005756 RID: 22358 RVA: 0x000D579B File Offset: 0x000D399B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005757 RID: 22359 RVA: 0x000D57A8 File Offset: 0x000D39A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005758 RID: 22360 RVA: 0x000D57B1 File Offset: 0x000D39B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LoseCount != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.LoseCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005759 RID: 22361 RVA: 0x000D57E4 File Offset: 0x000D39E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LoseCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LoseCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600575A RID: 22362 RVA: 0x000D5822 File Offset: 0x000D3A22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlLoseCountUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LoseCount != 0)
			{
				this.LoseCount = other.LoseCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600575B RID: 22363 RVA: 0x000D5853 File Offset: 0x000D3A53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600575C RID: 22364 RVA: 0x000D585C File Offset: 0x000D3A5C
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.LoseCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003513 RID: 13587
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003514 RID: 13588
		public const int LoseCountFieldNumber = 12;

		// Token: 0x04003515 RID: 13589
		private int loseCount_;
	}
}
