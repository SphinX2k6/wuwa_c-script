using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200071A RID: 1818
	public sealed class H5ViewActivityData : IMessage<H5ViewActivityData>, IMessage, IEquatable<H5ViewActivityData>, IDeepCloneable<H5ViewActivityData>, IBufferMessage
	{
		// Token: 0x0600A576 RID: 42358 RVA: 0x0018F33E File Offset: 0x0018D53E
		[NullableContext(1)]
		public static H5ViewActivityData Create()
		{
			return new H5ViewActivityData();
		}

		// Token: 0x17002141 RID: 8513
		// (get) Token: 0x0600A577 RID: 42359 RVA: 0x0018F345 File Offset: 0x0018D545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002142 RID: 8514
		// (get) Token: 0x0600A578 RID: 42360 RVA: 0x0018F348 File Offset: 0x0018D548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return H5ViewActivityData.Descriptor;
			}
		}

		// Token: 0x0600A579 RID: 42361 RVA: 0x0018F34F File Offset: 0x0018D54F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5ViewActivityData()
		{
		}

		// Token: 0x0600A57A RID: 42362 RVA: 0x0018F357 File Offset: 0x0018D557
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5ViewActivityData(H5ViewActivityData other) : this()
		{
			this.redDot_ = other.redDot_;
			this.allRewardClaimed_ = other.allRewardClaimed_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A57B RID: 42363 RVA: 0x0018F388 File Offset: 0x0018D588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5ViewActivityData Clone()
		{
			return new H5ViewActivityData(this);
		}

		// Token: 0x17002143 RID: 8515
		// (get) Token: 0x0600A57C RID: 42364 RVA: 0x0018F390 File Offset: 0x0018D590
		// (set) Token: 0x0600A57D RID: 42365 RVA: 0x0018F398 File Offset: 0x0018D598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool RedDot
		{
			get
			{
				return this.redDot_;
			}
			set
			{
				this.redDot_ = value;
			}
		}

		// Token: 0x17002144 RID: 8516
		// (get) Token: 0x0600A57E RID: 42366 RVA: 0x0018F3A1 File Offset: 0x0018D5A1
		// (set) Token: 0x0600A57F RID: 42367 RVA: 0x0018F3A9 File Offset: 0x0018D5A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool AllRewardClaimed
		{
			get
			{
				return this.allRewardClaimed_;
			}
			set
			{
				this.allRewardClaimed_ = value;
			}
		}

		// Token: 0x0600A580 RID: 42368 RVA: 0x0018F3B2 File Offset: 0x0018D5B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as H5ViewActivityData);
		}

		// Token: 0x0600A581 RID: 42369 RVA: 0x0018F3C0 File Offset: 0x0018D5C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(H5ViewActivityData other)
		{
			return other != null && (other == this || (this.RedDot == other.RedDot && this.AllRewardClaimed == other.AllRewardClaimed && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A582 RID: 42370 RVA: 0x0018F400 File Offset: 0x0018D600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RedDot)
			{
				num ^= this.RedDot.GetHashCode();
			}
			if (this.AllRewardClaimed)
			{
				num ^= this.AllRewardClaimed.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A583 RID: 42371 RVA: 0x0018F458 File Offset: 0x0018D658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A584 RID: 42372 RVA: 0x0018F465 File Offset: 0x0018D665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A585 RID: 42373 RVA: 0x0018F470 File Offset: 0x0018D670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RedDot)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.RedDot);
			}
			if (this.AllRewardClaimed)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.AllRewardClaimed);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A586 RID: 42374 RVA: 0x0018F4C8 File Offset: 0x0018D6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RedDot)
			{
				num += 2;
			}
			if (this.AllRewardClaimed)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A587 RID: 42375 RVA: 0x0018F508 File Offset: 0x0018D708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(H5ViewActivityData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RedDot)
			{
				this.RedDot = other.RedDot;
			}
			if (other.AllRewardClaimed)
			{
				this.AllRewardClaimed = other.AllRewardClaimed;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A588 RID: 42376 RVA: 0x0018F558 File Offset: 0x0018D758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A589 RID: 42377 RVA: 0x0018F564 File Offset: 0x0018D764
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
						this.AllRewardClaimed = input.ReadBool();
					}
				}
				else
				{
					this.RedDot = input.ReadBool();
				}
			}
		}

		// Token: 0x04004C62 RID: 19554
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C63 RID: 19555
		public const int RedDotFieldNumber = 1;

		// Token: 0x04004C64 RID: 19556
		private bool redDot_;

		// Token: 0x04004C65 RID: 19557
		public const int AllRewardClaimedFieldNumber = 2;

		// Token: 0x04004C66 RID: 19558
		private bool allRewardClaimed_;
	}
}
