using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F76 RID: 3958
	public sealed class RogueGotoLevelPlayOp : IMessage<RogueGotoLevelPlayOp>, IMessage, IEquatable<RogueGotoLevelPlayOp>, IDeepCloneable<RogueGotoLevelPlayOp>, IBufferMessage
	{
		// Token: 0x0601531D RID: 86813 RVA: 0x00313931 File Offset: 0x00311B31
		[NullableContext(1)]
		public static RogueGotoLevelPlayOp Create()
		{
			return new RogueGotoLevelPlayOp();
		}

		// Token: 0x17004696 RID: 18070
		// (get) Token: 0x0601531E RID: 86814 RVA: 0x00313938 File Offset: 0x00311B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004697 RID: 18071
		// (get) Token: 0x0601531F RID: 86815 RVA: 0x0031393B File Offset: 0x00311B3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueGotoLevelPlayOp.Descriptor;
			}
		}

		// Token: 0x06015320 RID: 86816 RVA: 0x00313942 File Offset: 0x00311B42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGotoLevelPlayOp()
		{
		}

		// Token: 0x06015321 RID: 86817 RVA: 0x0031394C File Offset: 0x00311B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGotoLevelPlayOp(RogueGotoLevelPlayOp other) : this()
		{
			this.isFormation_ = other.isFormation_;
			this.roomId_ = other.roomId_;
			this.rommType_ = other.rommType_;
			this.canSkipBattle_ = other.canSkipBattle_;
			this.rogueResSubLevelData_ = ((other.rogueResSubLevelData_ != null) ? other.rogueResSubLevelData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015322 RID: 86818 RVA: 0x003139BC File Offset: 0x00311BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGotoLevelPlayOp Clone()
		{
			return new RogueGotoLevelPlayOp(this);
		}

		// Token: 0x17004698 RID: 18072
		// (get) Token: 0x06015323 RID: 86819 RVA: 0x003139C4 File Offset: 0x00311BC4
		// (set) Token: 0x06015324 RID: 86820 RVA: 0x003139CC File Offset: 0x00311BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFormation
		{
			get
			{
				return this.isFormation_;
			}
			set
			{
				this.isFormation_ = value;
			}
		}

		// Token: 0x17004699 RID: 18073
		// (get) Token: 0x06015325 RID: 86821 RVA: 0x003139D5 File Offset: 0x00311BD5
		// (set) Token: 0x06015326 RID: 86822 RVA: 0x003139DD File Offset: 0x00311BDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoomId
		{
			get
			{
				return this.roomId_;
			}
			set
			{
				this.roomId_ = value;
			}
		}

		// Token: 0x1700469A RID: 18074
		// (get) Token: 0x06015327 RID: 86823 RVA: 0x003139E6 File Offset: 0x00311BE6
		// (set) Token: 0x06015328 RID: 86824 RVA: 0x003139EE File Offset: 0x00311BEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RommType
		{
			get
			{
				return this.rommType_;
			}
			set
			{
				this.rommType_ = value;
			}
		}

		// Token: 0x1700469B RID: 18075
		// (get) Token: 0x06015329 RID: 86825 RVA: 0x003139F7 File Offset: 0x00311BF7
		// (set) Token: 0x0601532A RID: 86826 RVA: 0x003139FF File Offset: 0x00311BFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanSkipBattle
		{
			get
			{
				return this.canSkipBattle_;
			}
			set
			{
				this.canSkipBattle_ = value;
			}
		}

		// Token: 0x1700469C RID: 18076
		// (get) Token: 0x0601532B RID: 86827 RVA: 0x00313A08 File Offset: 0x00311C08
		// (set) Token: 0x0601532C RID: 86828 RVA: 0x00313A10 File Offset: 0x00311C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResSubLevelData RogueResSubLevelData
		{
			get
			{
				return this.rogueResSubLevelData_;
			}
			set
			{
				this.rogueResSubLevelData_ = value;
			}
		}

		// Token: 0x0601532D RID: 86829 RVA: 0x00313A19 File Offset: 0x00311C19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueGotoLevelPlayOp);
		}

		// Token: 0x0601532E RID: 86830 RVA: 0x00313A28 File Offset: 0x00311C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueGotoLevelPlayOp other)
		{
			return other != null && (other == this || (this.IsFormation == other.IsFormation && this.RoomId == other.RoomId && this.RommType == other.RommType && this.CanSkipBattle == other.CanSkipBattle && object.Equals(this.RogueResSubLevelData, other.RogueResSubLevelData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601532F RID: 86831 RVA: 0x00313AA8 File Offset: 0x00311CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsFormation)
			{
				num ^= this.IsFormation.GetHashCode();
			}
			if (this.RoomId != 0)
			{
				num ^= this.RoomId.GetHashCode();
			}
			if (this.RommType != 0)
			{
				num ^= this.RommType.GetHashCode();
			}
			if (this.CanSkipBattle)
			{
				num ^= this.CanSkipBattle.GetHashCode();
			}
			if (this.rogueResSubLevelData_ != null)
			{
				num ^= this.RogueResSubLevelData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015330 RID: 86832 RVA: 0x00313B48 File Offset: 0x00311D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015331 RID: 86833 RVA: 0x00313B55 File Offset: 0x00311D55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015332 RID: 86834 RVA: 0x00313B60 File Offset: 0x00311D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsFormation)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsFormation);
			}
			if (this.RoomId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RoomId);
			}
			if (this.RommType != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RommType);
			}
			if (this.CanSkipBattle)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.CanSkipBattle);
			}
			if (this.rogueResSubLevelData_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.RogueResSubLevelData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015333 RID: 86835 RVA: 0x00313C0C File Offset: 0x00311E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsFormation)
			{
				num += 2;
			}
			if (this.RoomId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoomId);
			}
			if (this.RommType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RommType);
			}
			if (this.CanSkipBattle)
			{
				num += 2;
			}
			if (this.rogueResSubLevelData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueResSubLevelData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015334 RID: 86836 RVA: 0x00313C94 File Offset: 0x00311E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueGotoLevelPlayOp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsFormation)
			{
				this.IsFormation = other.IsFormation;
			}
			if (other.RoomId != 0)
			{
				this.RoomId = other.RoomId;
			}
			if (other.RommType != 0)
			{
				this.RommType = other.RommType;
			}
			if (other.CanSkipBattle)
			{
				this.CanSkipBattle = other.CanSkipBattle;
			}
			if (other.rogueResSubLevelData_ != null)
			{
				if (this.rogueResSubLevelData_ == null)
				{
					this.RogueResSubLevelData = new RogueResSubLevelData();
				}
				this.RogueResSubLevelData.MergeFrom(other.RogueResSubLevelData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015335 RID: 86837 RVA: 0x00313D38 File Offset: 0x00311F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015336 RID: 86838 RVA: 0x00313D44 File Offset: 0x00311F44
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.IsFormation = input.ReadBool();
						continue;
					}
					if (num == 24U)
					{
						this.RoomId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.RommType = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.CanSkipBattle = input.ReadBool();
						continue;
					}
					if (num == 50U)
					{
						if (this.rogueResSubLevelData_ == null)
						{
							this.RogueResSubLevelData = new RogueResSubLevelData();
						}
						input.ReadMessage(this.RogueResSubLevelData);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007FF9 RID: 32761
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007FFA RID: 32762
		public const int IsFormationFieldNumber = 1;

		// Token: 0x04007FFB RID: 32763
		private bool isFormation_;

		// Token: 0x04007FFC RID: 32764
		public const int RoomIdFieldNumber = 3;

		// Token: 0x04007FFD RID: 32765
		private int roomId_;

		// Token: 0x04007FFE RID: 32766
		public const int RommTypeFieldNumber = 4;

		// Token: 0x04007FFF RID: 32767
		private int rommType_;

		// Token: 0x04008000 RID: 32768
		public const int CanSkipBattleFieldNumber = 5;

		// Token: 0x04008001 RID: 32769
		private bool canSkipBattle_;

		// Token: 0x04008002 RID: 32770
		public const int RogueResSubLevelDataFieldNumber = 6;

		// Token: 0x04008003 RID: 32771
		private RogueResSubLevelData rogueResSubLevelData_;
	}
}
