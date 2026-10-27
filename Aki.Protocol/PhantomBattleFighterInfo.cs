using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C88 RID: 3208
	public sealed class PhantomBattleFighterInfo : IMessage<PhantomBattleFighterInfo>, IMessage, IEquatable<PhantomBattleFighterInfo>, IDeepCloneable<PhantomBattleFighterInfo>, IBufferMessage
	{
		// Token: 0x0601163A RID: 71226 RVA: 0x0028C490 File Offset: 0x0028A690
		[NullableContext(1)]
		public static PhantomBattleFighterInfo Create()
		{
			return new PhantomBattleFighterInfo();
		}

		// Token: 0x17003993 RID: 14739
		// (get) Token: 0x0601163B RID: 71227 RVA: 0x0028C497 File Offset: 0x0028A697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleFighterInfo> Parser
		{
			get
			{
				return PhantomBattleFighterInfo._parser;
			}
		}

		// Token: 0x17003994 RID: 14740
		// (get) Token: 0x0601163C RID: 71228 RVA: 0x0028C49E File Offset: 0x0028A69E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003995 RID: 14741
		// (get) Token: 0x0601163D RID: 71229 RVA: 0x0028C4A1 File Offset: 0x0028A6A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleFighterInfo.Descriptor;
			}
		}

		// Token: 0x0601163E RID: 71230 RVA: 0x0028C4A8 File Offset: 0x0028A6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFighterInfo()
		{
		}

		// Token: 0x0601163F RID: 71231 RVA: 0x0028C4B0 File Offset: 0x0028A6B0
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

		// Token: 0x06011640 RID: 71232 RVA: 0x0028C534 File Offset: 0x0028A734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFighterInfo Clone()
		{
			return new PhantomBattleFighterInfo(this);
		}

		// Token: 0x17003996 RID: 14742
		// (get) Token: 0x06011641 RID: 71233 RVA: 0x0028C53C File Offset: 0x0028A73C
		// (set) Token: 0x06011642 RID: 71234 RVA: 0x0028C544 File Offset: 0x0028A744
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

		// Token: 0x17003997 RID: 14743
		// (get) Token: 0x06011643 RID: 71235 RVA: 0x0028C54D File Offset: 0x0028A74D
		// (set) Token: 0x06011644 RID: 71236 RVA: 0x0028C565 File Offset: 0x0028A765
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

		// Token: 0x17003998 RID: 14744
		// (get) Token: 0x06011645 RID: 71237 RVA: 0x0028C57B File Offset: 0x0028A77B
		// (set) Token: 0x06011646 RID: 71238 RVA: 0x0028C593 File Offset: 0x0028A793
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

		// Token: 0x17003999 RID: 14745
		// (get) Token: 0x06011647 RID: 71239 RVA: 0x0028C5A9 File Offset: 0x0028A7A9
		// (set) Token: 0x06011648 RID: 71240 RVA: 0x0028C5C1 File Offset: 0x0028A7C1
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

		// Token: 0x1700399A RID: 14746
		// (get) Token: 0x06011649 RID: 71241 RVA: 0x0028C5D7 File Offset: 0x0028A7D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFighterInfo.PhantomBattleFighterInfoCtxOneofCase PhantomBattleFighterInfoCtxCase
		{
			get
			{
				return this.phantomBattleFighterInfoCtxCase_;
			}
		}

		// Token: 0x0601164A RID: 71242 RVA: 0x0028C5DF File Offset: 0x0028A7DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearPhantomBattleFighterInfoCtx()
		{
			this.phantomBattleFighterInfoCtxCase_ = PhantomBattleFighterInfo.PhantomBattleFighterInfoCtxOneofCase.None;
			this.phantomBattleFighterInfoCtx_ = null;
		}

		// Token: 0x0601164B RID: 71243 RVA: 0x0028C5EF File Offset: 0x0028A7EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleFighterInfo);
		}

		// Token: 0x0601164C RID: 71244 RVA: 0x0028C600 File Offset: 0x0028A800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleFighterInfo other)
		{
			return other != null && (other == this || (this.UId == other.UId && object.Equals(this.PhantomBattleBoardFighterInfoCtx, other.PhantomBattleBoardFighterInfoCtx) && object.Equals(this.PhantomBattleGamerFighterInfoCtx, other.PhantomBattleGamerFighterInfoCtx) && object.Equals(this.PhantomBattleCardFighterInfoCtx, other.PhantomBattleCardFighterInfoCtx) && this.PhantomBattleFighterInfoCtxCase == other.PhantomBattleFighterInfoCtxCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601164D RID: 71245 RVA: 0x0028C688 File Offset: 0x0028A888
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

		// Token: 0x0601164E RID: 71246 RVA: 0x0028C715 File Offset: 0x0028A915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601164F RID: 71247 RVA: 0x0028C722 File Offset: 0x0028A922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011650 RID: 71248 RVA: 0x0028C72C File Offset: 0x0028A92C
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

		// Token: 0x06011651 RID: 71249 RVA: 0x0028C7C0 File Offset: 0x0028A9C0
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

		// Token: 0x06011652 RID: 71250 RVA: 0x0028C84C File Offset: 0x0028AA4C
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

		// Token: 0x06011653 RID: 71251 RVA: 0x0028C915 File Offset: 0x0028AB15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011654 RID: 71252 RVA: 0x0028C920 File Offset: 0x0028AB20
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

		// Token: 0x04006DD5 RID: 28117
		private static readonly MessageParser<PhantomBattleFighterInfo> _parser = new MessageParser<PhantomBattleFighterInfo>(() => new PhantomBattleFighterInfo());

		// Token: 0x04006DD6 RID: 28118
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006DD7 RID: 28119
		public const int UIdFieldNumber = 1;

		// Token: 0x04006DD8 RID: 28120
		private int uId_;

		// Token: 0x04006DD9 RID: 28121
		public const int PhantomBattleBoardFighterInfoCtxFieldNumber = 2;

		// Token: 0x04006DDA RID: 28122
		public const int PhantomBattleGamerFighterInfoCtxFieldNumber = 3;

		// Token: 0x04006DDB RID: 28123
		public const int PhantomBattleCardFighterInfoCtxFieldNumber = 4;

		// Token: 0x04006DDC RID: 28124
		private object phantomBattleFighterInfoCtx_;

		// Token: 0x04006DDD RID: 28125
		private PhantomBattleFighterInfo.PhantomBattleFighterInfoCtxOneofCase phantomBattleFighterInfoCtxCase_;

		// Token: 0x020018B0 RID: 6320
		public enum PhantomBattleFighterInfoCtxOneofCase
		{
			// Token: 0x0400C8B0 RID: 51376
			None,
			// Token: 0x0400C8B1 RID: 51377
			PhantomBattleBoardFighterInfoCtx = 2,
			// Token: 0x0400C8B2 RID: 51378
			PhantomBattleGamerFighterInfoCtx,
			// Token: 0x0400C8B3 RID: 51379
			PhantomBattleCardFighterInfoCtx
		}
	}
}
