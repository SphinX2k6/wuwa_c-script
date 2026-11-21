using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B62 RID: 2914
	public sealed class NpcPhantomBattleEvolveInfo : IMessage<NpcPhantomBattleEvolveInfo>, IMessage, IEquatable<NpcPhantomBattleEvolveInfo>, IDeepCloneable<NpcPhantomBattleEvolveInfo>, IBufferMessage
	{
		// Token: 0x0600FCDA RID: 64730 RVA: 0x0024DBEF File Offset: 0x0024BDEF
		[NullableContext(1)]
		public static NpcPhantomBattleEvolveInfo Create()
		{
			return new NpcPhantomBattleEvolveInfo();
		}

		// Token: 0x1700338F RID: 13199
		// (get) Token: 0x0600FCDB RID: 64731 RVA: 0x0024DBF6 File Offset: 0x0024BDF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003390 RID: 13200
		// (get) Token: 0x0600FCDC RID: 64732 RVA: 0x0024DBF9 File Offset: 0x0024BDF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomBattleEvolveInfo.Descriptor;
			}
		}

		// Token: 0x0600FCDD RID: 64733 RVA: 0x0024DC00 File Offset: 0x0024BE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleEvolveInfo()
		{
		}

		// Token: 0x0600FCDE RID: 64734 RVA: 0x0024DC08 File Offset: 0x0024BE08
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

		// Token: 0x0600FCDF RID: 64735 RVA: 0x0024DC6C File Offset: 0x0024BE6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleEvolveInfo Clone()
		{
			return new NpcPhantomBattleEvolveInfo(this);
		}

		// Token: 0x17003391 RID: 13201
		// (get) Token: 0x0600FCE0 RID: 64736 RVA: 0x0024DC74 File Offset: 0x0024BE74
		// (set) Token: 0x0600FCE1 RID: 64737 RVA: 0x0024DC7C File Offset: 0x0024BE7C
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

		// Token: 0x17003392 RID: 13202
		// (get) Token: 0x0600FCE2 RID: 64738 RVA: 0x0024DC85 File Offset: 0x0024BE85
		// (set) Token: 0x0600FCE3 RID: 64739 RVA: 0x0024DC8D File Offset: 0x0024BE8D
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

		// Token: 0x17003393 RID: 13203
		// (get) Token: 0x0600FCE4 RID: 64740 RVA: 0x0024DC96 File Offset: 0x0024BE96
		// (set) Token: 0x0600FCE5 RID: 64741 RVA: 0x0024DC9E File Offset: 0x0024BE9E
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

		// Token: 0x17003394 RID: 13204
		// (get) Token: 0x0600FCE6 RID: 64742 RVA: 0x0024DCA7 File Offset: 0x0024BEA7
		// (set) Token: 0x0600FCE7 RID: 64743 RVA: 0x0024DCAF File Offset: 0x0024BEAF
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

		// Token: 0x0600FCE8 RID: 64744 RVA: 0x0024DCB8 File Offset: 0x0024BEB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomBattleEvolveInfo);
		}

		// Token: 0x0600FCE9 RID: 64745 RVA: 0x0024DCC8 File Offset: 0x0024BEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomBattleEvolveInfo other)
		{
			return other != null && (other == this || (object.Equals(this.PhantomBattleFighterInfo, other.PhantomBattleFighterInfo) && this.CanEvolveNum == other.CanEvolveNum && this.HandCardNum == other.HandCardNum && this.CardLibraryNum == other.CardLibraryNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FCEA RID: 64746 RVA: 0x0024DD38 File Offset: 0x0024BF38
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

		// Token: 0x0600FCEB RID: 64747 RVA: 0x0024DDBF File Offset: 0x0024BFBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FCEC RID: 64748 RVA: 0x0024DDCC File Offset: 0x0024BFCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FCED RID: 64749 RVA: 0x0024DDD8 File Offset: 0x0024BFD8
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

		// Token: 0x0600FCEE RID: 64750 RVA: 0x0024DE6C File Offset: 0x0024C06C
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

		// Token: 0x0600FCEF RID: 64751 RVA: 0x0024DEF4 File Offset: 0x0024C0F4
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

		// Token: 0x0600FCF0 RID: 64752 RVA: 0x0024DF84 File Offset: 0x0024C184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FCF1 RID: 64753 RVA: 0x0024DF90 File Offset: 0x0024C190
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

		// Token: 0x0400654D RID: 25933
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400654E RID: 25934
		public const int PhantomBattleFighterInfoFieldNumber = 1;

		// Token: 0x0400654F RID: 25935
		private PhantomBattleFighterInfo phantomBattleFighterInfo_;

		// Token: 0x04006550 RID: 25936
		public const int CanEvolveNumFieldNumber = 2;

		// Token: 0x04006551 RID: 25937
		private int canEvolveNum_;

		// Token: 0x04006552 RID: 25938
		public const int HandCardNumFieldNumber = 3;

		// Token: 0x04006553 RID: 25939
		private int handCardNum_;

		// Token: 0x04006554 RID: 25940
		public const int CardLibraryNumFieldNumber = 4;

		// Token: 0x04006555 RID: 25941
		private int cardLibraryNum_;
	}
}
