using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B61 RID: 2913
	public sealed class NpcPhantomBattleEnterSlotInfo : IMessage<NpcPhantomBattleEnterSlotInfo>, IMessage, IEquatable<NpcPhantomBattleEnterSlotInfo>, IDeepCloneable<NpcPhantomBattleEnterSlotInfo>, IBufferMessage
	{
		// Token: 0x0600FCC6 RID: 64710 RVA: 0x0024D900 File Offset: 0x0024BB00
		[NullableContext(1)]
		public static NpcPhantomBattleEnterSlotInfo Create()
		{
			return new NpcPhantomBattleEnterSlotInfo();
		}

		// Token: 0x1700338B RID: 13195
		// (get) Token: 0x0600FCC7 RID: 64711 RVA: 0x0024D907 File Offset: 0x0024BB07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700338C RID: 13196
		// (get) Token: 0x0600FCC8 RID: 64712 RVA: 0x0024D90A File Offset: 0x0024BB0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomBattleEnterSlotInfo.Descriptor;
			}
		}

		// Token: 0x0600FCC9 RID: 64713 RVA: 0x0024D911 File Offset: 0x0024BB11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleEnterSlotInfo()
		{
		}

		// Token: 0x0600FCCA RID: 64714 RVA: 0x0024D91C File Offset: 0x0024BB1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleEnterSlotInfo(NpcPhantomBattleEnterSlotInfo other) : this()
		{
			this.phantomBattleFighterInfo_ = ((other.phantomBattleFighterInfo_ != null) ? other.phantomBattleFighterInfo_.Clone() : null);
			this.curHandNum_ = other.curHandNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FCCB RID: 64715 RVA: 0x0024D968 File Offset: 0x0024BB68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleEnterSlotInfo Clone()
		{
			return new NpcPhantomBattleEnterSlotInfo(this);
		}

		// Token: 0x1700338D RID: 13197
		// (get) Token: 0x0600FCCC RID: 64716 RVA: 0x0024D970 File Offset: 0x0024BB70
		// (set) Token: 0x0600FCCD RID: 64717 RVA: 0x0024D978 File Offset: 0x0024BB78
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

		// Token: 0x1700338E RID: 13198
		// (get) Token: 0x0600FCCE RID: 64718 RVA: 0x0024D981 File Offset: 0x0024BB81
		// (set) Token: 0x0600FCCF RID: 64719 RVA: 0x0024D989 File Offset: 0x0024BB89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurHandNum
		{
			get
			{
				return this.curHandNum_;
			}
			set
			{
				this.curHandNum_ = value;
			}
		}

		// Token: 0x0600FCD0 RID: 64720 RVA: 0x0024D992 File Offset: 0x0024BB92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomBattleEnterSlotInfo);
		}

		// Token: 0x0600FCD1 RID: 64721 RVA: 0x0024D9A0 File Offset: 0x0024BBA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomBattleEnterSlotInfo other)
		{
			return other != null && (other == this || (object.Equals(this.PhantomBattleFighterInfo, other.PhantomBattleFighterInfo) && this.CurHandNum == other.CurHandNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FCD2 RID: 64722 RVA: 0x0024D9F0 File Offset: 0x0024BBF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.phantomBattleFighterInfo_ != null)
			{
				num ^= this.PhantomBattleFighterInfo.GetHashCode();
			}
			if (this.CurHandNum != 0)
			{
				num ^= this.CurHandNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FCD3 RID: 64723 RVA: 0x0024DA45 File Offset: 0x0024BC45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FCD4 RID: 64724 RVA: 0x0024DA52 File Offset: 0x0024BC52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FCD5 RID: 64725 RVA: 0x0024DA5C File Offset: 0x0024BC5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.phantomBattleFighterInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.PhantomBattleFighterInfo);
			}
			if (this.CurHandNum != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CurHandNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FCD6 RID: 64726 RVA: 0x0024DAB8 File Offset: 0x0024BCB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.phantomBattleFighterInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleFighterInfo);
			}
			if (this.CurHandNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurHandNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FCD7 RID: 64727 RVA: 0x0024DB10 File Offset: 0x0024BD10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NpcPhantomBattleEnterSlotInfo other)
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
			if (other.CurHandNum != 0)
			{
				this.CurHandNum = other.CurHandNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FCD8 RID: 64728 RVA: 0x0024DB78 File Offset: 0x0024BD78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FCD9 RID: 64729 RVA: 0x0024DB84 File Offset: 0x0024BD84
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CurHandNum = input.ReadInt32();
					}
				}
				else
				{
					if (this.phantomBattleFighterInfo_ == null)
					{
						this.PhantomBattleFighterInfo = new PhantomBattleFighterInfo();
					}
					input.ReadMessage(this.PhantomBattleFighterInfo);
				}
			}
		}

		// Token: 0x04006548 RID: 25928
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006549 RID: 25929
		public const int PhantomBattleFighterInfoFieldNumber = 1;

		// Token: 0x0400654A RID: 25930
		private PhantomBattleFighterInfo phantomBattleFighterInfo_;

		// Token: 0x0400654B RID: 25931
		public const int CurHandNumFieldNumber = 2;

		// Token: 0x0400654C RID: 25932
		private int curHandNum_;
	}
}
