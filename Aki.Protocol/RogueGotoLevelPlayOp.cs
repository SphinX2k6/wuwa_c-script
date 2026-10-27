using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F86 RID: 3974
	public sealed class RogueGotoLevelPlayOp : IMessage<RogueGotoLevelPlayOp>, IMessage, IEquatable<RogueGotoLevelPlayOp>, IDeepCloneable<RogueGotoLevelPlayOp>, IBufferMessage
	{
		// Token: 0x06015402 RID: 87042 RVA: 0x00314FE5 File Offset: 0x003131E5
		[NullableContext(1)]
		public static RogueGotoLevelPlayOp Create()
		{
			return new RogueGotoLevelPlayOp();
		}

		// Token: 0x170046C0 RID: 18112
		// (get) Token: 0x06015403 RID: 87043 RVA: 0x00314FEC File Offset: 0x003131EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170046C1 RID: 18113
		// (get) Token: 0x06015404 RID: 87044 RVA: 0x00314FEF File Offset: 0x003131EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueGotoLevelPlayOp.Descriptor;
			}
		}

		// Token: 0x06015405 RID: 87045 RVA: 0x00314FF6 File Offset: 0x003131F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGotoLevelPlayOp()
		{
		}

		// Token: 0x06015406 RID: 87046 RVA: 0x00315000 File Offset: 0x00313200
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

		// Token: 0x06015407 RID: 87047 RVA: 0x00315070 File Offset: 0x00313270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGotoLevelPlayOp Clone()
		{
			return new RogueGotoLevelPlayOp(this);
		}

		// Token: 0x170046C2 RID: 18114
		// (get) Token: 0x06015408 RID: 87048 RVA: 0x00315078 File Offset: 0x00313278
		// (set) Token: 0x06015409 RID: 87049 RVA: 0x00315080 File Offset: 0x00313280
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

		// Token: 0x170046C3 RID: 18115
		// (get) Token: 0x0601540A RID: 87050 RVA: 0x00315089 File Offset: 0x00313289
		// (set) Token: 0x0601540B RID: 87051 RVA: 0x00315091 File Offset: 0x00313291
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

		// Token: 0x170046C4 RID: 18116
		// (get) Token: 0x0601540C RID: 87052 RVA: 0x0031509A File Offset: 0x0031329A
		// (set) Token: 0x0601540D RID: 87053 RVA: 0x003150A2 File Offset: 0x003132A2
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

		// Token: 0x170046C5 RID: 18117
		// (get) Token: 0x0601540E RID: 87054 RVA: 0x003150AB File Offset: 0x003132AB
		// (set) Token: 0x0601540F RID: 87055 RVA: 0x003150B3 File Offset: 0x003132B3
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

		// Token: 0x170046C6 RID: 18118
		// (get) Token: 0x06015410 RID: 87056 RVA: 0x003150BC File Offset: 0x003132BC
		// (set) Token: 0x06015411 RID: 87057 RVA: 0x003150C4 File Offset: 0x003132C4
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

		// Token: 0x06015412 RID: 87058 RVA: 0x003150CD File Offset: 0x003132CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueGotoLevelPlayOp);
		}

		// Token: 0x06015413 RID: 87059 RVA: 0x003150DC File Offset: 0x003132DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueGotoLevelPlayOp other)
		{
			return other != null && (other == this || (this.IsFormation == other.IsFormation && this.RoomId == other.RoomId && this.RommType == other.RommType && this.CanSkipBattle == other.CanSkipBattle && object.Equals(this.RogueResSubLevelData, other.RogueResSubLevelData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015414 RID: 87060 RVA: 0x0031515C File Offset: 0x0031335C
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

		// Token: 0x06015415 RID: 87061 RVA: 0x003151FC File Offset: 0x003133FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015416 RID: 87062 RVA: 0x00315209 File Offset: 0x00313409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015417 RID: 87063 RVA: 0x00315214 File Offset: 0x00313414
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

		// Token: 0x06015418 RID: 87064 RVA: 0x003152C0 File Offset: 0x003134C0
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

		// Token: 0x06015419 RID: 87065 RVA: 0x00315348 File Offset: 0x00313548
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

		// Token: 0x0601541A RID: 87066 RVA: 0x003153EC File Offset: 0x003135EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601541B RID: 87067 RVA: 0x003153F8 File Offset: 0x003135F8
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

		// Token: 0x04007FCF RID: 32719
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007FD0 RID: 32720
		public const int IsFormationFieldNumber = 1;

		// Token: 0x04007FD1 RID: 32721
		private bool isFormation_;

		// Token: 0x04007FD2 RID: 32722
		public const int RoomIdFieldNumber = 3;

		// Token: 0x04007FD3 RID: 32723
		private int roomId_;

		// Token: 0x04007FD4 RID: 32724
		public const int RommTypeFieldNumber = 4;

		// Token: 0x04007FD5 RID: 32725
		private int rommType_;

		// Token: 0x04007FD6 RID: 32726
		public const int CanSkipBattleFieldNumber = 5;

		// Token: 0x04007FD7 RID: 32727
		private bool canSkipBattle_;

		// Token: 0x04007FD8 RID: 32728
		public const int RogueResSubLevelDataFieldNumber = 6;

		// Token: 0x04007FD9 RID: 32729
		private RogueResSubLevelData rogueResSubLevelData_;
	}
}
