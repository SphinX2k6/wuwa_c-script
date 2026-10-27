using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B72 RID: 2930
	public sealed class NpcPhantomBattleEvolveInfo : IMessage<NpcPhantomBattleEvolveInfo>, IMessage, IEquatable<NpcPhantomBattleEvolveInfo>, IDeepCloneable<NpcPhantomBattleEvolveInfo>, IBufferMessage
	{
		// Token: 0x0600FDDE RID: 64990 RVA: 0x0024FABF File Offset: 0x0024DCBF
		[NullableContext(1)]
		public static NpcPhantomBattleEvolveInfo Create()
		{
			return new NpcPhantomBattleEvolveInfo();
		}

		// Token: 0x170033C8 RID: 13256
		// (get) Token: 0x0600FDDF RID: 64991 RVA: 0x0024FAC6 File Offset: 0x0024DCC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170033C9 RID: 13257
		// (get) Token: 0x0600FDE0 RID: 64992 RVA: 0x0024FAC9 File Offset: 0x0024DCC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomBattleEvolveInfo.Descriptor;
			}
		}

		// Token: 0x0600FDE1 RID: 64993 RVA: 0x0024FAD0 File Offset: 0x0024DCD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleEvolveInfo()
		{
		}

		// Token: 0x0600FDE2 RID: 64994 RVA: 0x0024FAD8 File Offset: 0x0024DCD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleEvolveInfo(NpcPhantomBattleEvolveInfo other) : this()
		{
			this.phantomBattleFighterInfo_ = ((other.phantomBattleFighterInfo_ != null) ? other.phantomBattleFighterInfo_.Clone() : null);
			this.canEvolveNum_ = other.canEvolveNum_;
			this.handCardNum_ = other.handCardNum_;
			this.cardLibraryNum_ = other.cardLibraryNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FDE3 RID: 64995 RVA: 0x0024FB3C File Offset: 0x0024DD3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleEvolveInfo Clone()
		{
			return new NpcPhantomBattleEvolveInfo(this);
		}

		// Token: 0x170033CA RID: 13258
		// (get) Token: 0x0600FDE4 RID: 64996 RVA: 0x0024FB44 File Offset: 0x0024DD44
		// (set) Token: 0x0600FDE5 RID: 64997 RVA: 0x0024FB4C File Offset: 0x0024DD4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFighterInfo PhantomBattleFighterInfo
		{
			get
			{
				return this.phantomBattleFighterInfo_;
			}
			set
			{
				this.phantomBattleFighterInfo_ = value;
			}
		}

		// Token: 0x170033CB RID: 13259
		// (get) Token: 0x0600FDE6 RID: 64998 RVA: 0x0024FB55 File Offset: 0x0024DD55
		// (set) Token: 0x0600FDE7 RID: 64999 RVA: 0x0024FB5D File Offset: 0x0024DD5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CanEvolveNum
		{
			get
			{
				return this.canEvolveNum_;
			}
			set
			{
				this.canEvolveNum_ = value;
			}
		}

		// Token: 0x170033CC RID: 13260
		// (get) Token: 0x0600FDE8 RID: 65000 RVA: 0x0024FB66 File Offset: 0x0024DD66
		// (set) Token: 0x0600FDE9 RID: 65001 RVA: 0x0024FB6E File Offset: 0x0024DD6E
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

		// Token: 0x170033CD RID: 13261
		// (get) Token: 0x0600FDEA RID: 65002 RVA: 0x0024FB77 File Offset: 0x0024DD77
		// (set) Token: 0x0600FDEB RID: 65003 RVA: 0x0024FB7F File Offset: 0x0024DD7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardLibraryNum
		{
			get
			{
				return this.cardLibraryNum_;
			}
			set
			{
				this.cardLibraryNum_ = value;
			}
		}

		// Token: 0x0600FDEC RID: 65004 RVA: 0x0024FB88 File Offset: 0x0024DD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomBattleEvolveInfo);
		}

		// Token: 0x0600FDED RID: 65005 RVA: 0x0024FB98 File Offset: 0x0024DD98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomBattleEvolveInfo other)
		{
			return other != null && (other == this || (object.Equals(this.PhantomBattleFighterInfo, other.PhantomBattleFighterInfo) && this.CanEvolveNum == other.CanEvolveNum && this.HandCardNum == other.HandCardNum && this.CardLibraryNum == other.CardLibraryNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FDEE RID: 65006 RVA: 0x0024FC08 File Offset: 0x0024DE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.phantomBattleFighterInfo_ != null)
			{
				num ^= this.PhantomBattleFighterInfo.GetHashCode();
			}
			if (this.CanEvolveNum != 0)
			{
				num ^= this.CanEvolveNum.GetHashCode();
			}
			if (this.HandCardNum != 0)
			{
				num ^= this.HandCardNum.GetHashCode();
			}
			if (this.CardLibraryNum != 0)
			{
				num ^= this.CardLibraryNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FDEF RID: 65007 RVA: 0x0024FC8F File Offset: 0x0024DE8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FDF0 RID: 65008 RVA: 0x0024FC9C File Offset: 0x0024DE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FDF1 RID: 65009 RVA: 0x0024FCA8 File Offset: 0x0024DEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.phantomBattleFighterInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.PhantomBattleFighterInfo);
			}
			if (this.CanEvolveNum != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CanEvolveNum);
			}
			if (this.HandCardNum != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.HandCardNum);
			}
			if (this.CardLibraryNum != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CardLibraryNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FDF2 RID: 65010 RVA: 0x0024FD3C File Offset: 0x0024DF3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.phantomBattleFighterInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleFighterInfo);
			}
			if (this.CanEvolveNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CanEvolveNum);
			}
			if (this.HandCardNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HandCardNum);
			}
			if (this.CardLibraryNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardLibraryNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FDF3 RID: 65011 RVA: 0x0024FDC4 File Offset: 0x0024DFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NpcPhantomBattleEvolveInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.phantomBattleFighterInfo_ != null)
			{
				if (this.phantomBattleFighterInfo_ == null)
				{
					this.PhantomBattleFighterInfo = new PhantomBattleFighterInfo();
				}
				this.PhantomBattleFighterInfo.MergeFrom(other.PhantomBattleFighterInfo);
			}
			if (other.CanEvolveNum != 0)
			{
				this.CanEvolveNum = other.CanEvolveNum;
			}
			if (other.HandCardNum != 0)
			{
				this.HandCardNum = other.HandCardNum;
			}
			if (other.CardLibraryNum != 0)
			{
				this.CardLibraryNum = other.CardLibraryNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FDF4 RID: 65012 RVA: 0x0024FE54 File Offset: 0x0024E054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FDF5 RID: 65013 RVA: 0x0024FE60 File Offset: 0x0024E060
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
				if (num <= 16U)
				{
					if (num == 10U)
					{
						if (this.phantomBattleFighterInfo_ == null)
						{
							this.PhantomBattleFighterInfo = new PhantomBattleFighterInfo();
						}
						input.ReadMessage(this.PhantomBattleFighterInfo);
						continue;
					}
					if (num == 16U)
					{
						this.CanEvolveNum = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.HandCardNum = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.CardLibraryNum = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400653D RID: 25917
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400653E RID: 25918
		public const int PhantomBattleFighterInfoFieldNumber = 1;

		// Token: 0x0400653F RID: 25919
		private PhantomBattleFighterInfo phantomBattleFighterInfo_;

		// Token: 0x04006540 RID: 25920
		public const int CanEvolveNumFieldNumber = 2;

		// Token: 0x04006541 RID: 25921
		private int canEvolveNum_;

		// Token: 0x04006542 RID: 25922
		public const int HandCardNumFieldNumber = 3;

		// Token: 0x04006543 RID: 25923
		private int handCardNum_;

		// Token: 0x04006544 RID: 25924
		public const int CardLibraryNumFieldNumber = 4;

		// Token: 0x04006545 RID: 25925
		private int cardLibraryNum_;
	}
}
