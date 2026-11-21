using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B5F RID: 2911
	public sealed class NpcPhantomBattleDiscardInfo : IMessage<NpcPhantomBattleDiscardInfo>, IMessage, IEquatable<NpcPhantomBattleDiscardInfo>, IDeepCloneable<NpcPhantomBattleDiscardInfo>, IBufferMessage
	{
		// Token: 0x0600FC98 RID: 64664 RVA: 0x0024D1BF File Offset: 0x0024B3BF
		[NullableContext(1)]
		public static NpcPhantomBattleDiscardInfo Create()
		{
			return new NpcPhantomBattleDiscardInfo();
		}

		// Token: 0x17003380 RID: 13184
		// (get) Token: 0x0600FC99 RID: 64665 RVA: 0x0024D1C6 File Offset: 0x0024B3C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003381 RID: 13185
		// (get) Token: 0x0600FC9A RID: 64666 RVA: 0x0024D1C9 File Offset: 0x0024B3C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomBattleDiscardInfo.Descriptor;
			}
		}

		// Token: 0x0600FC9B RID: 64667 RVA: 0x0024D1D0 File Offset: 0x0024B3D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleDiscardInfo()
		{
		}

		// Token: 0x0600FC9C RID: 64668 RVA: 0x0024D1D8 File Offset: 0x0024B3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleDiscardInfo(NpcPhantomBattleDiscardInfo other) : this()
		{
			this.discardNum_ = other.discardNum_;
			this.handCardNum_ = other.handCardNum_;
			this.curCardLibraryNum_ = other.curCardLibraryNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FC9D RID: 64669 RVA: 0x0024D215 File Offset: 0x0024B415
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleDiscardInfo Clone()
		{
			return new NpcPhantomBattleDiscardInfo(this);
		}

		// Token: 0x17003382 RID: 13186
		// (get) Token: 0x0600FC9E RID: 64670 RVA: 0x0024D21D File Offset: 0x0024B41D
		// (set) Token: 0x0600FC9F RID: 64671 RVA: 0x0024D225 File Offset: 0x0024B425
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DiscardNum
		{
			get
			{
				return this.discardNum_;
			}
			set
			{
				this.discardNum_ = value;
			}
		}

		// Token: 0x17003383 RID: 13187
		// (get) Token: 0x0600FCA0 RID: 64672 RVA: 0x0024D22E File Offset: 0x0024B42E
		// (set) Token: 0x0600FCA1 RID: 64673 RVA: 0x0024D236 File Offset: 0x0024B436
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

		// Token: 0x17003384 RID: 13188
		// (get) Token: 0x0600FCA2 RID: 64674 RVA: 0x0024D23F File Offset: 0x0024B43F
		// (set) Token: 0x0600FCA3 RID: 64675 RVA: 0x0024D247 File Offset: 0x0024B447
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

		// Token: 0x0600FCA4 RID: 64676 RVA: 0x0024D250 File Offset: 0x0024B450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomBattleDiscardInfo);
		}

		// Token: 0x0600FCA5 RID: 64677 RVA: 0x0024D260 File Offset: 0x0024B460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomBattleDiscardInfo other)
		{
			return other != null && (other == this || (this.DiscardNum == other.DiscardNum && this.HandCardNum == other.HandCardNum && this.CurCardLibraryNum == other.CurCardLibraryNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FCA6 RID: 64678 RVA: 0x0024D2BC File Offset: 0x0024B4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DiscardNum != 0)
			{
				num ^= this.DiscardNum.GetHashCode();
			}
			if (this.HandCardNum != 0)
			{
				num ^= this.HandCardNum.GetHashCode();
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

		// Token: 0x0600FCA7 RID: 64679 RVA: 0x0024D32D File Offset: 0x0024B52D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FCA8 RID: 64680 RVA: 0x0024D33A File Offset: 0x0024B53A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FCA9 RID: 64681 RVA: 0x0024D344 File Offset: 0x0024B544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DiscardNum != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DiscardNum);
			}
			if (this.HandCardNum != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.HandCardNum);
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

		// Token: 0x0600FCAA RID: 64682 RVA: 0x0024D3B8 File Offset: 0x0024B5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DiscardNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DiscardNum);
			}
			if (this.HandCardNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HandCardNum);
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

		// Token: 0x0600FCAB RID: 64683 RVA: 0x0024D428 File Offset: 0x0024B628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NpcPhantomBattleDiscardInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DiscardNum != 0)
			{
				this.DiscardNum = other.DiscardNum;
			}
			if (other.HandCardNum != 0)
			{
				this.HandCardNum = other.HandCardNum;
			}
			if (other.CurCardLibraryNum != 0)
			{
				this.CurCardLibraryNum = other.CurCardLibraryNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FCAC RID: 64684 RVA: 0x0024D48C File Offset: 0x0024B68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FCAD RID: 64685 RVA: 0x0024D498 File Offset: 0x0024B698
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
						this.HandCardNum = input.ReadInt32();
					}
				}
				else
				{
					this.DiscardNum = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006538 RID: 25912
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006539 RID: 25913
		public const int DiscardNumFieldNumber = 1;

		// Token: 0x0400653A RID: 25914
		private int discardNum_;

		// Token: 0x0400653B RID: 25915
		public const int HandCardNumFieldNumber = 2;

		// Token: 0x0400653C RID: 25916
		private int handCardNum_;

		// Token: 0x0400653D RID: 25917
		public const int CurCardLibraryNumFieldNumber = 3;

		// Token: 0x0400653E RID: 25918
		private int curCardLibraryNum_;
	}
}
