using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C78 RID: 3192
	public sealed class PhantomBattleFighterInfo : IMessage<PhantomBattleFighterInfo>, IMessage, IEquatable<PhantomBattleFighterInfo>, IDeepCloneable<PhantomBattleFighterInfo>, IBufferMessage
	{
		// Token: 0x0601153A RID: 70970 RVA: 0x0028A724 File Offset: 0x00288924
		[NullableContext(1)]
		public static PhantomBattleFighterInfo Create()
		{
			return new PhantomBattleFighterInfo();
		}

		// Token: 0x1700395C RID: 14684
		// (get) Token: 0x0601153B RID: 70971 RVA: 0x0028A72B File Offset: 0x0028892B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleFighterInfo> Parser
		{
			get
			{
				return PhantomBattleFighterInfo._parser;
			}
		}

		// Token: 0x1700395D RID: 14685
		// (get) Token: 0x0601153C RID: 70972 RVA: 0x0028A732 File Offset: 0x00288932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700395E RID: 14686
		// (get) Token: 0x0601153D RID: 70973 RVA: 0x0028A735 File Offset: 0x00288935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleFighterInfo.Descriptor;
			}
		}

		// Token: 0x0601153E RID: 70974 RVA: 0x0028A73C File Offset: 0x0028893C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFighterInfo()
		{
		}

		// Token: 0x0601153F RID: 70975 RVA: 0x0028A744 File Offset: 0x00288944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFighterInfo(PhantomBattleFighterInfo other) : this()
		{
			this.uId_ = other.uId_;
			switch (other.PhantomBattleFighterInfoCtxCase)
			{
			case PhantomBattleFighterInfo.PhantomBattleFighterInfoCtxOneofCase.PhantomBattleBoardFighterInfoCtx:
				this.PhantomBattleBoardFighterInfoCtx = other.PhantomBattleBoardFighterInfoCtx.Clone();
				break;
			case PhantomBattleFighterInfo.PhantomBattleFighterInfoCtxOneofCase.PhantomBattleGamerFighterInfoCtx:
				this.PhantomBattleGamerFighterInfoCtx = other.PhantomBattleGamerFighterInfoCtx.Clone();
				break;
			case PhantomBattleFighterInfo.PhantomBattleFighterInfoCtxOneofCase.PhantomBattleCardFighterInfoCtx:
				this.PhantomBattleCardFighterInfoCtx = other.PhantomBattleCardFighterInfoCtx.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011540 RID: 70976 RVA: 0x0028A7C8 File Offset: 0x002889C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFighterInfo Clone()
		{
			return new PhantomBattleFighterInfo(this);
		}

		// Token: 0x1700395F RID: 14687
		// (get) Token: 0x06011541 RID: 70977 RVA: 0x0028A7D0 File Offset: 0x002889D0
		// (set) Token: 0x06011542 RID: 70978 RVA: 0x0028A7D8 File Offset: 0x002889D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UId
		{
			get
			{
				return this.uId_;
			}
			set
			{
				this.uId_ = value;
			}
		}

		// Token: 0x17003960 RID: 14688
		// (get) Token: 0x06011543 RID: 70979 RVA: 0x0028A7E1 File Offset: 0x002889E1
		// (set) Token: 0x06011544 RID: 70980 RVA: 0x0028A7F9 File Offset: 0x002889F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBoardFighterInfoCtx PhantomBattleBoardFighterInfoCtx
		{
			get
			{
				if (this.phantomBattleFighterInfoCtxCase_ != PhantomBattleFighterInfo.PhantomBattleFighterInfoCtxOneofCase.PhantomBattleBoardFighterInfoCtx)
				{
					return null;
				}
				return (PhantomBattleBoardFighterInfoCtx)this.phantomBattleFighterInfoCtx_;
			}
			set
			{
				this.phantomBattleFighterInfoCtx_ = value;
				this.phantomBattleFighterInfoCtxCase_ = ((value == null) ? PhantomBattleFighterInfo.PhantomBattleFighterInfoCtxOneofCase.None : PhantomBattleFighterInfo.PhantomBattleFighterInfoCtxOneofCase.PhantomBattleBoardFighterInfoCtx);
			}
		}

		// Token: 0x17003961 RID: 14689
		// (get) Token: 0x06011545 RID: 70981 RVA: 0x0028A80F File Offset: 0x00288A0F
		// (set) Token: 0x06011546 RID: 70982 RVA: 0x0028A827 File Offset: 0x00288A27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleGamerFighterInfoCtx PhantomBattleGamerFighterInfoCtx
		{
			get
			{
				if (this.phantomBattleFighterInfoCtxCase_ != PhantomBattleFighterInfo.PhantomBattleFighterInfoCtxOneofCase.PhantomBattleGamerFighterInfoCtx)
				{
					return null;
				}
				return (PhantomBattleGamerFighterInfoCtx)this.phantomBattleFighterInfoCtx_;
			}
			set
			{
				this.phantomBattleFighterInfoCtx_ = value;
				this.phantomBattleFighterInfoCtxCase_ = ((value == null) ? PhantomBattleFighterInfo.PhantomBattleFighterInfoCtxOneofCase.None : PhantomBattleFighterInfo.PhantomBattleFighterInfoCtxOneofCase.PhantomBattleGamerFighterInfoCtx);
			}
		}

		// Token: 0x17003962 RID: 14690
		// (get) Token: 0x06011547 RID: 70983 RVA: 0x0028A83D File Offset: 0x00288A3D
		// (set) Token: 0x06011548 RID: 70984 RVA: 0x0028A855 File Offset: 0x00288A55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardFighterInfoCtx PhantomBattleCardFighterInfoCtx
		{
			get
			{
				if (this.phantomBattleFighterInfoCtxCase_ != PhantomBattleFighterInfo.PhantomBattleFighterInfoCtxOneofCase.PhantomBattleCardFighterInfoCtx)
				{
					return null;
				}
				return (PhantomBattleCardFighterInfoCtx)this.phantomBattleFighterInfoCtx_;
			}
			set
			{
				this.phantomBattleFighterInfoCtx_ = value;
				this.phantomBattleFighterInfoCtxCase_ = ((value == null) ? PhantomBattleFighterInfo.PhantomBattleFighterInfoCtxOneofCase.None : PhantomBattleFighterInfo.PhantomBattleFighterInfoCtxOneofCase.PhantomBattleCardFighterInfoCtx);
			}
		}

		// Token: 0x17003963 RID: 14691
		// (get) Token: 0x06011549 RID: 70985 RVA: 0x0028A86B File Offset: 0x00288A6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFighterInfo.PhantomBattleFighterInfoCtxOneofCase PhantomBattleFighterInfoCtxCase
		{
			get
			{
				return this.phantomBattleFighterInfoCtxCase_;
			}
		}

		// Token: 0x0601154A RID: 70986 RVA: 0x0028A873 File Offset: 0x00288A73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearPhantomBattleFighterInfoCtx()
		{
			this.phantomBattleFighterInfoCtxCase_ = PhantomBattleFighterInfo.PhantomBattleFighterInfoCtxOneofCase.None;
			this.phantomBattleFighterInfoCtx_ = null;
		}

		// Token: 0x0601154B RID: 70987 RVA: 0x0028A883 File Offset: 0x00288A83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleFighterInfo);
		}

		// Token: 0x0601154C RID: 70988 RVA: 0x0028A894 File Offset: 0x00288A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleFighterInfo other)
		{
			return other != null && (other == this || (this.UId == other.UId && object.Equals(this.PhantomBattleBoardFighterInfoCtx, other.PhantomBattleBoardFighterInfoCtx) && object.Equals(this.PhantomBattleGamerFighterInfoCtx, other.PhantomBattleGamerFighterInfoCtx) && object.Equals(this.PhantomBattleCardFighterInfoCtx, other.PhantomBattleCardFighterInfoCtx) && this.PhantomBattleFighterInfoCtxCase == other.PhantomBattleFighterInfoCtxCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601154D RID: 70989 RVA: 0x0028A91C File Offset: 0x00288B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.UId != 0)
			{
				num ^= this.UId.GetHashCode();
			}
			if (this.phantomBattleFighterInfoCtxCase_ == PhantomBattleFighterInfo.PhantomBattleFighterInfoCtxOneofCase.PhantomBattleBoardFighterInfoCtx)
			{
				num ^= this.PhantomBattleBoardFighterInfoCtx.GetHashCode();
			}
			if (this.phantomBattleFighterInfoCtxCase_ == PhantomBattleFighterInfo.PhantomBattleFighterInfoCtxOneofCase.PhantomBattleGamerFighterInfoCtx)
			{
				num ^= this.PhantomBattleGamerFighterInfoCtx.GetHashCode();
			}
			if (this.phantomBattleFighterInfoCtxCase_ == PhantomBattleFighterInfo.PhantomBattleFighterInfoCtxOneofCase.PhantomBattleCardFighterInfoCtx)
			{
				num ^= this.PhantomBattleCardFighterInfoCtx.GetHashCode();
			}
			num ^= (int)this.phantomBattleFighterInfoCtxCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601154E RID: 70990 RVA: 0x0028A9A9 File Offset: 0x00288BA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601154F RID: 70991 RVA: 0x0028A9B6 File Offset: 0x00288BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011550 RID: 70992 RVA: 0x0028A9C0 File Offset: 0x00288BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.UId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.UId);
			}
			if (this.phantomBattleFighterInfoCtxCase_ == PhantomBattleFighterInfo.PhantomBattleFighterInfoCtxOneofCase.PhantomBattleBoardFighterInfoCtx)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.PhantomBattleBoardFighterInfoCtx);
			}
			if (this.phantomBattleFighterInfoCtxCase_ == PhantomBattleFighterInfo.PhantomBattleFighterInfoCtxOneofCase.PhantomBattleGamerFighterInfoCtx)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.PhantomBattleGamerFighterInfoCtx);
			}
			if (this.phantomBattleFighterInfoCtxCase_ == PhantomBattleFighterInfo.PhantomBattleFighterInfoCtxOneofCase.PhantomBattleCardFighterInfoCtx)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.PhantomBattleCardFighterInfoCtx);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011551 RID: 70993 RVA: 0x0028AA54 File Offset: 0x00288C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.UId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UId);
			}
			if (this.phantomBattleFighterInfoCtxCase_ == PhantomBattleFighterInfo.PhantomBattleFighterInfoCtxOneofCase.PhantomBattleBoardFighterInfoCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleBoardFighterInfoCtx);
			}
			if (this.phantomBattleFighterInfoCtxCase_ == PhantomBattleFighterInfo.PhantomBattleFighterInfoCtxOneofCase.PhantomBattleGamerFighterInfoCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleGamerFighterInfoCtx);
			}
			if (this.phantomBattleFighterInfoCtxCase_ == PhantomBattleFighterInfo.PhantomBattleFighterInfoCtxOneofCase.PhantomBattleCardFighterInfoCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleCardFighterInfoCtx);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011552 RID: 70994 RVA: 0x0028AAE0 File Offset: 0x00288CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleFighterInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.UId != 0)
			{
				this.UId = other.UId;
			}
			switch (other.PhantomBattleFighterInfoCtxCase)
			{
			case PhantomBattleFighterInfo.PhantomBattleFighterInfoCtxOneofCase.PhantomBattleBoardFighterInfoCtx:
				if (this.PhantomBattleBoardFighterInfoCtx == null)
				{
					this.PhantomBattleBoardFighterInfoCtx = new PhantomBattleBoardFighterInfoCtx();
				}
				this.PhantomBattleBoardFighterInfoCtx.MergeFrom(other.PhantomBattleBoardFighterInfoCtx);
				break;
			case PhantomBattleFighterInfo.PhantomBattleFighterInfoCtxOneofCase.PhantomBattleGamerFighterInfoCtx:
				if (this.PhantomBattleGamerFighterInfoCtx == null)
				{
					this.PhantomBattleGamerFighterInfoCtx = new PhantomBattleGamerFighterInfoCtx();
				}
				this.PhantomBattleGamerFighterInfoCtx.MergeFrom(other.PhantomBattleGamerFighterInfoCtx);
				break;
			case PhantomBattleFighterInfo.PhantomBattleFighterInfoCtxOneofCase.PhantomBattleCardFighterInfoCtx:
				if (this.PhantomBattleCardFighterInfoCtx == null)
				{
					this.PhantomBattleCardFighterInfoCtx = new PhantomBattleCardFighterInfoCtx();
				}
				this.PhantomBattleCardFighterInfoCtx.MergeFrom(other.PhantomBattleCardFighterInfoCtx);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011553 RID: 70995 RVA: 0x0028ABA9 File Offset: 0x00288DA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011554 RID: 70996 RVA: 0x0028ABB4 File Offset: 0x00288DB4
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
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.UId = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						PhantomBattleBoardFighterInfoCtx phantomBattleBoardFighterInfoCtx = new PhantomBattleBoardFighterInfoCtx();
						if (this.phantomBattleFighterInfoCtxCase_ == PhantomBattleFighterInfo.PhantomBattleFighterInfoCtxOneofCase.PhantomBattleBoardFighterInfoCtx)
						{
							phantomBattleBoardFighterInfoCtx.MergeFrom(this.PhantomBattleBoardFighterInfoCtx);
						}
						input.ReadMessage(phantomBattleBoardFighterInfoCtx);
						this.PhantomBattleBoardFighterInfoCtx = phantomBattleBoardFighterInfoCtx;
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						PhantomBattleGamerFighterInfoCtx phantomBattleGamerFighterInfoCtx = new PhantomBattleGamerFighterInfoCtx();
						if (this.phantomBattleFighterInfoCtxCase_ == PhantomBattleFighterInfo.PhantomBattleFighterInfoCtxOneofCase.PhantomBattleGamerFighterInfoCtx)
						{
							phantomBattleGamerFighterInfoCtx.MergeFrom(this.PhantomBattleGamerFighterInfoCtx);
						}
						input.ReadMessage(phantomBattleGamerFighterInfoCtx);
						this.PhantomBattleGamerFighterInfoCtx = phantomBattleGamerFighterInfoCtx;
						continue;
					}
					if (num == 34U)
					{
						PhantomBattleCardFighterInfoCtx phantomBattleCardFighterInfoCtx = new PhantomBattleCardFighterInfoCtx();
						if (this.phantomBattleFighterInfoCtxCase_ == PhantomBattleFighterInfo.PhantomBattleFighterInfoCtxOneofCase.PhantomBattleCardFighterInfoCtx)
						{
							phantomBattleCardFighterInfoCtx.MergeFrom(this.PhantomBattleCardFighterInfoCtx);
						}
						input.ReadMessage(phantomBattleCardFighterInfoCtx);
						this.PhantomBattleCardFighterInfoCtx = phantomBattleCardFighterInfoCtx;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006DE9 RID: 28137
		private static readonly MessageParser<PhantomBattleFighterInfo> _parser = new MessageParser<PhantomBattleFighterInfo>(() => new PhantomBattleFighterInfo());

		// Token: 0x04006DEA RID: 28138
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006DEB RID: 28139
		public const int UIdFieldNumber = 1;

		// Token: 0x04006DEC RID: 28140
		private int uId_;

		// Token: 0x04006DED RID: 28141
		public const int PhantomBattleBoardFighterInfoCtxFieldNumber = 2;

		// Token: 0x04006DEE RID: 28142
		public const int PhantomBattleGamerFighterInfoCtxFieldNumber = 3;

		// Token: 0x04006DEF RID: 28143
		public const int PhantomBattleCardFighterInfoCtxFieldNumber = 4;

		// Token: 0x04006DF0 RID: 28144
		private object phantomBattleFighterInfoCtx_;

		// Token: 0x04006DF1 RID: 28145
		private PhantomBattleFighterInfo.PhantomBattleFighterInfoCtxOneofCase phantomBattleFighterInfoCtxCase_;

		// Token: 0x02001928 RID: 6440
		public enum PhantomBattleFighterInfoCtxOneofCase
		{
			// Token: 0x0400CDDB RID: 52699
			None,
			// Token: 0x0400CDDC RID: 52700
			PhantomBattleBoardFighterInfoCtx = 2,
			// Token: 0x0400CDDD RID: 52701
			PhantomBattleGamerFighterInfoCtx,
			// Token: 0x0400CDDE RID: 52702
			PhantomBattleCardFighterInfoCtx
		}
	}
}
