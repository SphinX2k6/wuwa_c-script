using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000546 RID: 1350
	[NetMessage(EMessageId.FishingGhostStateNotify)]
	public sealed class FishingGhostStateNotify : IMessage<FishingGhostStateNotify>, IMessage, IEquatable<FishingGhostStateNotify>, IDeepCloneable<FishingGhostStateNotify>, IBufferMessage
	{
		// Token: 0x06007E7B RID: 32379 RVA: 0x001323F2 File Offset: 0x001305F2
		[NullableContext(1)]
		public static FishingGhostStateNotify Create()
		{
			return new FishingGhostStateNotify();
		}

		// Token: 0x17001895 RID: 6293
		// (get) Token: 0x06007E7C RID: 32380 RVA: 0x001323F9 File Offset: 0x001305F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001896 RID: 6294
		// (get) Token: 0x06007E7D RID: 32381 RVA: 0x001323FC File Offset: 0x001305FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingGhostStateNotify.Descriptor;
			}
		}

		// Token: 0x06007E7E RID: 32382 RVA: 0x00132403 File Offset: 0x00130603
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingGhostStateNotify()
		{
		}

		// Token: 0x06007E7F RID: 32383 RVA: 0x0013240B File Offset: 0x0013060B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingGhostStateNotify(FishingGhostStateNotify other) : this()
		{
			this.open_ = other.open_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007E80 RID: 32384 RVA: 0x00132430 File Offset: 0x00130630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingGhostStateNotify Clone()
		{
			return new FishingGhostStateNotify(this);
		}

		// Token: 0x17001897 RID: 6295
		// (get) Token: 0x06007E81 RID: 32385 RVA: 0x00132438 File Offset: 0x00130638
		// (set) Token: 0x06007E82 RID: 32386 RVA: 0x00132440 File Offset: 0x00130640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Open
		{
			get
			{
				return this.open_;
			}
			set
			{
				this.open_ = value;
			}
		}

		// Token: 0x06007E83 RID: 32387 RVA: 0x00132449 File Offset: 0x00130649
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingGhostStateNotify);
		}

		// Token: 0x06007E84 RID: 32388 RVA: 0x00132457 File Offset: 0x00130657
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingGhostStateNotify other)
		{
			return other != null && (other == this || (this.Open == other.Open && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007E85 RID: 32389 RVA: 0x00132488 File Offset: 0x00130688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Open)
			{
				num ^= this.Open.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007E86 RID: 32390 RVA: 0x001324C7 File Offset: 0x001306C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007E87 RID: 32391 RVA: 0x001324D4 File Offset: 0x001306D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007E88 RID: 32392 RVA: 0x001324DD File Offset: 0x001306DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Open)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.Open);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007E89 RID: 32393 RVA: 0x00132510 File Offset: 0x00130710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Open)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007E8A RID: 32394 RVA: 0x00132542 File Offset: 0x00130742
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingGhostStateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Open)
			{
				this.Open = other.Open;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007E8B RID: 32395 RVA: 0x00132573 File Offset: 0x00130773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007E8C RID: 32396 RVA: 0x0013257C File Offset: 0x0013077C
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Open = input.ReadBool();
				}
			}
		}

		// Token: 0x0400406C RID: 16492
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400406D RID: 16493
		public const int OpenFieldNumber = 15;

		// Token: 0x0400406E RID: 16494
		private bool open_;
	}
}
