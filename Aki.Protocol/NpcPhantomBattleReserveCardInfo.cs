using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B66 RID: 2918
	public sealed class NpcPhantomBattleReserveCardInfo : IMessage<NpcPhantomBattleReserveCardInfo>, IMessage, IEquatable<NpcPhantomBattleReserveCardInfo>, IDeepCloneable<NpcPhantomBattleReserveCardInfo>, IBufferMessage
	{
		// Token: 0x0600FD50 RID: 64848 RVA: 0x0024FA41 File Offset: 0x0024DC41
		[NullableContext(1)]
		public static NpcPhantomBattleReserveCardInfo Create()
		{
			return new NpcPhantomBattleReserveCardInfo();
		}

		// Token: 0x170033B2 RID: 13234
		// (get) Token: 0x0600FD51 RID: 64849 RVA: 0x0024FA48 File Offset: 0x0024DC48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170033B3 RID: 13235
		// (get) Token: 0x0600FD52 RID: 64850 RVA: 0x0024FA4B File Offset: 0x0024DC4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomBattleReserveCardInfo.Descriptor;
			}
		}

		// Token: 0x0600FD53 RID: 64851 RVA: 0x0024FA52 File Offset: 0x0024DC52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleReserveCardInfo()
		{
		}

		// Token: 0x0600FD54 RID: 64852 RVA: 0x0024FA5A File Offset: 0x0024DC5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleReserveCardInfo(NpcPhantomBattleReserveCardInfo other) : this()
		{
			this.reserveNum_ = other.reserveNum_;
			this.handCardNum_ = other.handCardNum_;
			this.curCardLibraryNum_ = other.curCardLibraryNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FD55 RID: 64853 RVA: 0x0024FA97 File Offset: 0x0024DC97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleReserveCardInfo Clone()
		{
			return new NpcPhantomBattleReserveCardInfo(this);
		}

		// Token: 0x170033B4 RID: 13236
		// (get) Token: 0x0600FD56 RID: 64854 RVA: 0x0024FA9F File Offset: 0x0024DC9F
		// (set) Token: 0x0600FD57 RID: 64855 RVA: 0x0024FAA7 File Offset: 0x0024DCA7
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

		// Token: 0x170033B5 RID: 13237
		// (get) Token: 0x0600FD58 RID: 64856 RVA: 0x0024FAB0 File Offset: 0x0024DCB0
		// (set) Token: 0x0600FD59 RID: 64857 RVA: 0x0024FAB8 File Offset: 0x0024DCB8
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

		// Token: 0x170033B6 RID: 13238
		// (get) Token: 0x0600FD5A RID: 64858 RVA: 0x0024FAC1 File Offset: 0x0024DCC1
		// (set) Token: 0x0600FD5B RID: 64859 RVA: 0x0024FAC9 File Offset: 0x0024DCC9
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

		// Token: 0x0600FD5C RID: 64860 RVA: 0x0024FAD2 File Offset: 0x0024DCD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomBattleReserveCardInfo);
		}

		// Token: 0x0600FD5D RID: 64861 RVA: 0x0024FAE0 File Offset: 0x0024DCE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomBattleReserveCardInfo other)
		{
			return other != null && (other == this || (this.ReserveNum == other.ReserveNum && this.HandCardNum == other.HandCardNum && this.CurCardLibraryNum == other.CurCardLibraryNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FD5E RID: 64862 RVA: 0x0024FB3C File Offset: 0x0024DD3C
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

		// Token: 0x0600FD5F RID: 64863 RVA: 0x0024FBAD File Offset: 0x0024DDAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FD60 RID: 64864 RVA: 0x0024FBBA File Offset: 0x0024DDBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FD61 RID: 64865 RVA: 0x0024FBC4 File Offset: 0x0024DDC4
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

		// Token: 0x0600FD62 RID: 64866 RVA: 0x0024FC38 File Offset: 0x0024DE38
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

		// Token: 0x0600FD63 RID: 64867 RVA: 0x0024FCA8 File Offset: 0x0024DEA8
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

		// Token: 0x0600FD64 RID: 64868 RVA: 0x0024FD0C File Offset: 0x0024DF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FD65 RID: 64869 RVA: 0x0024FD18 File Offset: 0x0024DF18
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

		// Token: 0x04006576 RID: 25974
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006577 RID: 25975
		public const int ReserveNumFieldNumber = 1;

		// Token: 0x04006578 RID: 25976
		private int reserveNum_;

		// Token: 0x04006579 RID: 25977
		public const int HandCardNumFieldNumber = 2;

		// Token: 0x0400657A RID: 25978
		private int handCardNum_;

		// Token: 0x0400657B RID: 25979
		public const int CurCardLibraryNumFieldNumber = 3;

		// Token: 0x0400657C RID: 25980
		private int curCardLibraryNum_;
	}
}
