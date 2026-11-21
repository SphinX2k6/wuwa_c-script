using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001528 RID: 5416
	public sealed class UseItemProgress : IMessage<UseItemProgress>, IMessage, IEquatable<UseItemProgress>, IDeepCloneable<UseItemProgress>, IBufferMessage
	{
		// Token: 0x0601CB0E RID: 117518 RVA: 0x0042854B File Offset: 0x0042674B
		[NullableContext(1)]
		public static UseItemProgress Create()
		{
			return new UseItemProgress();
		}

		// Token: 0x1700610C RID: 24844
		// (get) Token: 0x0601CB0F RID: 117519 RVA: 0x00428552 File Offset: 0x00426752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700610D RID: 24845
		// (get) Token: 0x0601CB10 RID: 117520 RVA: 0x00428555 File Offset: 0x00426755
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UseItemProgress.Descriptor;
			}
		}

		// Token: 0x0601CB11 RID: 117521 RVA: 0x0042855C File Offset: 0x0042675C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseItemProgress()
		{
		}

		// Token: 0x0601CB12 RID: 117522 RVA: 0x00428564 File Offset: 0x00426764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseItemProgress(UseItemProgress other) : this()
		{
			this.itemId_ = other.itemId_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CB13 RID: 117523 RVA: 0x00428595 File Offset: 0x00426795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseItemProgress Clone()
		{
			return new UseItemProgress(this);
		}

		// Token: 0x1700610E RID: 24846
		// (get) Token: 0x0601CB14 RID: 117524 RVA: 0x0042859D File Offset: 0x0042679D
		// (set) Token: 0x0601CB15 RID: 117525 RVA: 0x004285A5 File Offset: 0x004267A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x1700610F RID: 24847
		// (get) Token: 0x0601CB16 RID: 117526 RVA: 0x004285AE File Offset: 0x004267AE
		// (set) Token: 0x0601CB17 RID: 117527 RVA: 0x004285B6 File Offset: 0x004267B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x0601CB18 RID: 117528 RVA: 0x004285BF File Offset: 0x004267BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UseItemProgress);
		}

		// Token: 0x0601CB19 RID: 117529 RVA: 0x004285CD File Offset: 0x004267CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UseItemProgress other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CB1A RID: 117530 RVA: 0x0042860C File Offset: 0x0042680C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CB1B RID: 117531 RVA: 0x00428664 File Offset: 0x00426864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CB1C RID: 117532 RVA: 0x00428671 File Offset: 0x00426871
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CB1D RID: 117533 RVA: 0x0042867C File Offset: 0x0042687C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CB1E RID: 117534 RVA: 0x004286D4 File Offset: 0x004268D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CB1F RID: 117535 RVA: 0x0042872C File Offset: 0x0042692C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UseItemProgress other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CB20 RID: 117536 RVA: 0x0042877C File Offset: 0x0042697C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CB21 RID: 117537 RVA: 0x00428788 File Offset: 0x00426988
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A540 RID: 42304
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A541 RID: 42305
		public const int ItemIdFieldNumber = 1;

		// Token: 0x0400A542 RID: 42306
		private int itemId_;

		// Token: 0x0400A543 RID: 42307
		public const int CountFieldNumber = 2;

		// Token: 0x0400A544 RID: 42308
		private int count_;
	}
}
