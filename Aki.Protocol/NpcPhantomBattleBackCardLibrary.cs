using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B57 RID: 2903
	public sealed class NpcPhantomBattleBackCardLibrary : IMessage<NpcPhantomBattleBackCardLibrary>, IMessage, IEquatable<NpcPhantomBattleBackCardLibrary>, IDeepCloneable<NpcPhantomBattleBackCardLibrary>, IBufferMessage
	{
		// Token: 0x0600FBE0 RID: 64480 RVA: 0x0024B400 File Offset: 0x00249600
		[NullableContext(1)]
		public static NpcPhantomBattleBackCardLibrary Create()
		{
			return new NpcPhantomBattleBackCardLibrary();
		}

		// Token: 0x17003354 RID: 13140
		// (get) Token: 0x0600FBE1 RID: 64481 RVA: 0x0024B407 File Offset: 0x00249607
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003355 RID: 13141
		// (get) Token: 0x0600FBE2 RID: 64482 RVA: 0x0024B40A File Offset: 0x0024960A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomBattleBackCardLibrary.Descriptor;
			}
		}

		// Token: 0x0600FBE3 RID: 64483 RVA: 0x0024B411 File Offset: 0x00249611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleBackCardLibrary()
		{
		}

		// Token: 0x0600FBE4 RID: 64484 RVA: 0x0024B419 File Offset: 0x00249619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleBackCardLibrary(NpcPhantomBattleBackCardLibrary other) : this()
		{
			this.handCardNum_ = other.handCardNum_;
			this.handCardIndex_ = other.handCardIndex_;
			this.curCardLibraryNum_ = other.curCardLibraryNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FBE5 RID: 64485 RVA: 0x0024B456 File Offset: 0x00249656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleBackCardLibrary Clone()
		{
			return new NpcPhantomBattleBackCardLibrary(this);
		}

		// Token: 0x17003356 RID: 13142
		// (get) Token: 0x0600FBE6 RID: 64486 RVA: 0x0024B45E File Offset: 0x0024965E
		// (set) Token: 0x0600FBE7 RID: 64487 RVA: 0x0024B466 File Offset: 0x00249666
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

		// Token: 0x17003357 RID: 13143
		// (get) Token: 0x0600FBE8 RID: 64488 RVA: 0x0024B46F File Offset: 0x0024966F
		// (set) Token: 0x0600FBE9 RID: 64489 RVA: 0x0024B477 File Offset: 0x00249677
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

		// Token: 0x17003358 RID: 13144
		// (get) Token: 0x0600FBEA RID: 64490 RVA: 0x0024B480 File Offset: 0x00249680
		// (set) Token: 0x0600FBEB RID: 64491 RVA: 0x0024B488 File Offset: 0x00249688
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

		// Token: 0x0600FBEC RID: 64492 RVA: 0x0024B491 File Offset: 0x00249691
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomBattleBackCardLibrary);
		}

		// Token: 0x0600FBED RID: 64493 RVA: 0x0024B4A0 File Offset: 0x002496A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomBattleBackCardLibrary other)
		{
			return other != null && (other == this || (this.HandCardNum == other.HandCardNum && this.HandCardIndex == other.HandCardIndex && this.CurCardLibraryNum == other.CurCardLibraryNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FBEE RID: 64494 RVA: 0x0024B4FC File Offset: 0x002496FC
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

		// Token: 0x0600FBEF RID: 64495 RVA: 0x0024B56D File Offset: 0x0024976D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FBF0 RID: 64496 RVA: 0x0024B57A File Offset: 0x0024977A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FBF1 RID: 64497 RVA: 0x0024B584 File Offset: 0x00249784
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

		// Token: 0x0600FBF2 RID: 64498 RVA: 0x0024B5F8 File Offset: 0x002497F8
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

		// Token: 0x0600FBF3 RID: 64499 RVA: 0x0024B668 File Offset: 0x00249868
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

		// Token: 0x0600FBF4 RID: 64500 RVA: 0x0024B6CC File Offset: 0x002498CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FBF5 RID: 64501 RVA: 0x0024B6D8 File Offset: 0x002498D8
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

		// Token: 0x040064F4 RID: 25844
		private UnknownFieldSet _unknownFields;

		// Token: 0x040064F5 RID: 25845
		public const int HandCardNumFieldNumber = 1;

		// Token: 0x040064F6 RID: 25846
		private int handCardNum_;

		// Token: 0x040064F7 RID: 25847
		public const int HandCardIndexFieldNumber = 2;

		// Token: 0x040064F8 RID: 25848
		private int handCardIndex_;

		// Token: 0x040064F9 RID: 25849
		public const int CurCardLibraryNumFieldNumber = 3;

		// Token: 0x040064FA RID: 25850
		private int curCardLibraryNum_;
	}
}
