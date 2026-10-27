using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000069 RID: 105
	[NetMessage(EMessageId.ActionErrorCodeNotify)]
	public sealed class ActionErrorCodeNotify : IMessage<ActionErrorCodeNotify>, IMessage, IEquatable<ActionErrorCodeNotify>, IDeepCloneable<ActionErrorCodeNotify>, IBufferMessage
	{
		// Token: 0x060016C2 RID: 5826 RVA: 0x0003B98B File Offset: 0x00039B8B
		[NullableContext(1)]
		public static ActionErrorCodeNotify Create()
		{
			return new ActionErrorCodeNotify();
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060016C3 RID: 5827 RVA: 0x0003B992 File Offset: 0x00039B92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060016C4 RID: 5828 RVA: 0x0003B995 File Offset: 0x00039B95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActionErrorCodeNotify.Descriptor;
			}
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x0003B99C File Offset: 0x00039B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionErrorCodeNotify()
		{
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x0003B9A4 File Offset: 0x00039BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionErrorCodeNotify(ActionErrorCodeNotify other) : this()
		{
			this.incId_ = other.incId_;
			this.gameCtx_ = ((other.gameCtx_ != null) ? other.gameCtx_.Clone() : null);
			this.index_ = other.index_;
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x0003BA08 File Offset: 0x00039C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionErrorCodeNotify Clone()
		{
			return new ActionErrorCodeNotify(this);
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060016C8 RID: 5832 RVA: 0x0003BA10 File Offset: 0x00039C10
		// (set) Token: 0x060016C9 RID: 5833 RVA: 0x0003BA18 File Offset: 0x00039C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060016CA RID: 5834 RVA: 0x0003BA21 File Offset: 0x00039C21
		// (set) Token: 0x060016CB RID: 5835 RVA: 0x0003BA29 File Offset: 0x00039C29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameCtxPb GameCtx
		{
			get
			{
				return this.gameCtx_;
			}
			set
			{
				this.gameCtx_ = value;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060016CC RID: 5836 RVA: 0x0003BA32 File Offset: 0x00039C32
		// (set) Token: 0x060016CD RID: 5837 RVA: 0x0003BA3A File Offset: 0x00039C3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060016CE RID: 5838 RVA: 0x0003BA43 File Offset: 0x00039C43
		// (set) Token: 0x060016CF RID: 5839 RVA: 0x0003BA4B File Offset: 0x00039C4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x0003BA54 File Offset: 0x00039C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActionErrorCodeNotify);
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x0003BA64 File Offset: 0x00039C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActionErrorCodeNotify other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && object.Equals(this.GameCtx, other.GameCtx) && this.Index == other.Index && this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x0003BAD4 File Offset: 0x00039CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.gameCtx_ != null)
			{
				num ^= this.GameCtx.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x0003BB61 File Offset: 0x00039D61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x0003BB6E File Offset: 0x00039D6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x0003BB78 File Offset: 0x00039D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Index);
			}
			if (this.gameCtx_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.GameCtx);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.Code);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x0003BC0C File Offset: 0x00039E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.gameCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameCtx);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x0003BC94 File Offset: 0x00039E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActionErrorCodeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.gameCtx_ != null)
			{
				if (this.gameCtx_ == null)
				{
					this.GameCtx = new GameCtxPb();
				}
				this.GameCtx.MergeFrom(other.GameCtx);
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x0003BD24 File Offset: 0x00039F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x0003BD30 File Offset: 0x00039F30
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
				if (num <= 90U)
				{
					if (num == 80U)
					{
						this.Index = input.ReadInt32();
						continue;
					}
					if (num == 90U)
					{
						if (this.gameCtx_ == null)
						{
							this.GameCtx = new GameCtxPb();
						}
						input.ReadMessage(this.GameCtx);
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 112U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040020F6 RID: 8438
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020F7 RID: 8439
		public const int IncIdFieldNumber = 14;

		// Token: 0x040020F8 RID: 8440
		private int incId_;

		// Token: 0x040020F9 RID: 8441
		public const int GameCtxFieldNumber = 11;

		// Token: 0x040020FA RID: 8442
		private GameCtxPb gameCtx_;

		// Token: 0x040020FB RID: 8443
		public const int IndexFieldNumber = 10;

		// Token: 0x040020FC RID: 8444
		private int index_;

		// Token: 0x040020FD RID: 8445
		public const int CodeFieldNumber = 13;

		// Token: 0x040020FE RID: 8446
		private ErrorCode code_;
	}
}
