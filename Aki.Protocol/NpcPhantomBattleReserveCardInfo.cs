using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B76 RID: 2934
	public sealed class NpcPhantomBattleReserveCardInfo : IMessage<NpcPhantomBattleReserveCardInfo>, IMessage, IEquatable<NpcPhantomBattleReserveCardInfo>, IDeepCloneable<NpcPhantomBattleReserveCardInfo>, IBufferMessage
	{
		// Token: 0x0600FE54 RID: 65108 RVA: 0x00251911 File Offset: 0x0024FB11
		[NullableContext(1)]
		public static NpcPhantomBattleReserveCardInfo Create()
		{
			return new NpcPhantomBattleReserveCardInfo();
		}

		// Token: 0x170033EB RID: 13291
		// (get) Token: 0x0600FE55 RID: 65109 RVA: 0x00251918 File Offset: 0x0024FB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170033EC RID: 13292
		// (get) Token: 0x0600FE56 RID: 65110 RVA: 0x0025191B File Offset: 0x0024FB1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomBattleReserveCardInfo.Descriptor;
			}
		}

		// Token: 0x0600FE57 RID: 65111 RVA: 0x00251922 File Offset: 0x0024FB22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleReserveCardInfo()
		{
		}

		// Token: 0x0600FE58 RID: 65112 RVA: 0x0025192A File Offset: 0x0024FB2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleReserveCardInfo(NpcPhantomBattleReserveCardInfo other) : this()
		{
			this.reserveNum_ = other.reserveNum_;
			this.handCardNum_ = other.handCardNum_;
			this.curCardLibraryNum_ = other.curCardLibraryNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FE59 RID: 65113 RVA: 0x00251967 File Offset: 0x0024FB67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleReserveCardInfo Clone()
		{
			return new NpcPhantomBattleReserveCardInfo(this);
		}

		// Token: 0x170033ED RID: 13293
		// (get) Token: 0x0600FE5A RID: 65114 RVA: 0x0025196F File Offset: 0x0024FB6F
		// (set) Token: 0x0600FE5B RID: 65115 RVA: 0x00251977 File Offset: 0x0024FB77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ReserveNum
		{
			get
			{
				return this.reserveNum_;
			}
			set
			{
				this.reserveNum_ = value;
			}
		}

		// Token: 0x170033EE RID: 13294
		// (get) Token: 0x0600FE5C RID: 65116 RVA: 0x00251980 File Offset: 0x0024FB80
		// (set) Token: 0x0600FE5D RID: 65117 RVA: 0x00251988 File Offset: 0x0024FB88
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

		// Token: 0x170033EF RID: 13295
		// (get) Token: 0x0600FE5E RID: 65118 RVA: 0x00251991 File Offset: 0x0024FB91
		// (set) Token: 0x0600FE5F RID: 65119 RVA: 0x00251999 File Offset: 0x0024FB99
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

		// Token: 0x0600FE60 RID: 65120 RVA: 0x002519A2 File Offset: 0x0024FBA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomBattleReserveCardInfo);
		}

		// Token: 0x0600FE61 RID: 65121 RVA: 0x002519B0 File Offset: 0x0024FBB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomBattleReserveCardInfo other)
		{
			return other != null && (other == this || (this.ReserveNum == other.ReserveNum && this.HandCardNum == other.HandCardNum && this.CurCardLibraryNum == other.CurCardLibraryNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FE62 RID: 65122 RVA: 0x00251A0C File Offset: 0x0024FC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ReserveNum != 0)
			{
				num ^= this.ReserveNum.GetHashCode();
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

		// Token: 0x0600FE63 RID: 65123 RVA: 0x00251A7D File Offset: 0x0024FC7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FE64 RID: 65124 RVA: 0x00251A8A File Offset: 0x0024FC8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FE65 RID: 65125 RVA: 0x00251A94 File Offset: 0x0024FC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ReserveNum != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ReserveNum);
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

		// Token: 0x0600FE66 RID: 65126 RVA: 0x00251B08 File Offset: 0x0024FD08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ReserveNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ReserveNum);
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

		// Token: 0x0600FE67 RID: 65127 RVA: 0x00251B78 File Offset: 0x0024FD78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NpcPhantomBattleReserveCardInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ReserveNum != 0)
			{
				this.ReserveNum = other.ReserveNum;
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

		// Token: 0x0600FE68 RID: 65128 RVA: 0x00251BDC File Offset: 0x0024FDDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FE69 RID: 65129 RVA: 0x00251BE8 File Offset: 0x0024FDE8
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
					this.ReserveNum = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006566 RID: 25958
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006567 RID: 25959
		public const int ReserveNumFieldNumber = 1;

		// Token: 0x04006568 RID: 25960
		private int reserveNum_;

		// Token: 0x04006569 RID: 25961
		public const int HandCardNumFieldNumber = 2;

		// Token: 0x0400656A RID: 25962
		private int handCardNum_;

		// Token: 0x0400656B RID: 25963
		public const int CurCardLibraryNumFieldNumber = 3;

		// Token: 0x0400656C RID: 25964
		private int curCardLibraryNum_;
	}
}
