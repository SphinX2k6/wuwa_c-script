using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B67 RID: 2919
	public sealed class NpcPhantomBattleBackCardLibrary : IMessage<NpcPhantomBattleBackCardLibrary>, IMessage, IEquatable<NpcPhantomBattleBackCardLibrary>, IDeepCloneable<NpcPhantomBattleBackCardLibrary>, IBufferMessage
	{
		// Token: 0x0600FCE4 RID: 64740 RVA: 0x0024D2D0 File Offset: 0x0024B4D0
		[NullableContext(1)]
		public static NpcPhantomBattleBackCardLibrary Create()
		{
			return new NpcPhantomBattleBackCardLibrary();
		}

		// Token: 0x1700338D RID: 13197
		// (get) Token: 0x0600FCE5 RID: 64741 RVA: 0x0024D2D7 File Offset: 0x0024B4D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700338E RID: 13198
		// (get) Token: 0x0600FCE6 RID: 64742 RVA: 0x0024D2DA File Offset: 0x0024B4DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomBattleBackCardLibrary.Descriptor;
			}
		}

		// Token: 0x0600FCE7 RID: 64743 RVA: 0x0024D2E1 File Offset: 0x0024B4E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleBackCardLibrary()
		{
		}

		// Token: 0x0600FCE8 RID: 64744 RVA: 0x0024D2E9 File Offset: 0x0024B4E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleBackCardLibrary(NpcPhantomBattleBackCardLibrary other) : this()
		{
			this.handCardNum_ = other.handCardNum_;
			this.handCardIndex_ = other.handCardIndex_;
			this.curCardLibraryNum_ = other.curCardLibraryNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FCE9 RID: 64745 RVA: 0x0024D326 File Offset: 0x0024B526
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleBackCardLibrary Clone()
		{
			return new NpcPhantomBattleBackCardLibrary(this);
		}

		// Token: 0x1700338F RID: 13199
		// (get) Token: 0x0600FCEA RID: 64746 RVA: 0x0024D32E File Offset: 0x0024B52E
		// (set) Token: 0x0600FCEB RID: 64747 RVA: 0x0024D336 File Offset: 0x0024B536
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HandCardNum
		{
			get
			{
				return this.handCardNum_;
			}
			set
			{
				this.handCardNum_ = value;
			}
		}

		// Token: 0x17003390 RID: 13200
		// (get) Token: 0x0600FCEC RID: 64748 RVA: 0x0024D33F File Offset: 0x0024B53F
		// (set) Token: 0x0600FCED RID: 64749 RVA: 0x0024D347 File Offset: 0x0024B547
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HandCardIndex
		{
			get
			{
				return this.handCardIndex_;
			}
			set
			{
				this.handCardIndex_ = value;
			}
		}

		// Token: 0x17003391 RID: 13201
		// (get) Token: 0x0600FCEE RID: 64750 RVA: 0x0024D350 File Offset: 0x0024B550
		// (set) Token: 0x0600FCEF RID: 64751 RVA: 0x0024D358 File Offset: 0x0024B558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurCardLibraryNum
		{
			get
			{
				return this.curCardLibraryNum_;
			}
			set
			{
				this.curCardLibraryNum_ = value;
			}
		}

		// Token: 0x0600FCF0 RID: 64752 RVA: 0x0024D361 File Offset: 0x0024B561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomBattleBackCardLibrary);
		}

		// Token: 0x0600FCF1 RID: 64753 RVA: 0x0024D370 File Offset: 0x0024B570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomBattleBackCardLibrary other)
		{
			return other != null && (other == this || (this.HandCardNum == other.HandCardNum && this.HandCardIndex == other.HandCardIndex && this.CurCardLibraryNum == other.CurCardLibraryNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FCF2 RID: 64754 RVA: 0x0024D3CC File Offset: 0x0024B5CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HandCardNum != 0)
			{
				num ^= this.HandCardNum.GetHashCode();
			}
			if (this.HandCardIndex != 0)
			{
				num ^= this.HandCardIndex.GetHashCode();
			}
			if (this.CurCardLibraryNum != 0)
			{
				num ^= this.CurCardLibraryNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FCF3 RID: 64755 RVA: 0x0024D43D File Offset: 0x0024B63D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FCF4 RID: 64756 RVA: 0x0024D44A File Offset: 0x0024B64A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FCF5 RID: 64757 RVA: 0x0024D454 File Offset: 0x0024B654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HandCardNum != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.HandCardNum);
			}
			if (this.HandCardIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.HandCardIndex);
			}
			if (this.CurCardLibraryNum != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CurCardLibraryNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FCF6 RID: 64758 RVA: 0x0024D4C8 File Offset: 0x0024B6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HandCardNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HandCardNum);
			}
			if (this.HandCardIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HandCardIndex);
			}
			if (this.CurCardLibraryNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurCardLibraryNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FCF7 RID: 64759 RVA: 0x0024D538 File Offset: 0x0024B738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NpcPhantomBattleBackCardLibrary other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HandCardNum != 0)
			{
				this.HandCardNum = other.HandCardNum;
			}
			if (other.HandCardIndex != 0)
			{
				this.HandCardIndex = other.HandCardIndex;
			}
			if (other.CurCardLibraryNum != 0)
			{
				this.CurCardLibraryNum = other.CurCardLibraryNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FCF8 RID: 64760 RVA: 0x0024D59C File Offset: 0x0024B79C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FCF9 RID: 64761 RVA: 0x0024D5A8 File Offset: 0x0024B7A8
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CurCardLibraryNum = input.ReadInt32();
						}
					}
					else
					{
						this.HandCardIndex = input.ReadInt32();
					}
				}
				else
				{
					this.HandCardNum = input.ReadInt32();
				}
			}
		}

		// Token: 0x040064E4 RID: 25828
		private UnknownFieldSet _unknownFields;

		// Token: 0x040064E5 RID: 25829
		public const int HandCardNumFieldNumber = 1;

		// Token: 0x040064E6 RID: 25830
		private int handCardNum_;

		// Token: 0x040064E7 RID: 25831
		public const int HandCardIndexFieldNumber = 2;

		// Token: 0x040064E8 RID: 25832
		private int handCardIndex_;

		// Token: 0x040064E9 RID: 25833
		public const int CurCardLibraryNumFieldNumber = 3;

		// Token: 0x040064EA RID: 25834
		private int curCardLibraryNum_;
	}
}
