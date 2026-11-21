using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200006A RID: 106
	[NetMessage(EMessageId.ActionErrorCodeNotify)]
	public sealed class ActionErrorCodeNotify : IMessage<ActionErrorCodeNotify>, IMessage, IEquatable<ActionErrorCodeNotify>, IDeepCloneable<ActionErrorCodeNotify>, IBufferMessage
	{
		// Token: 0x06001705 RID: 5893 RVA: 0x0003C330 File Offset: 0x0003A530
		[NullableContext(1)]
		public static ActionErrorCodeNotify Create()
		{
			return new ActionErrorCodeNotify();
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06001706 RID: 5894 RVA: 0x0003C337 File Offset: 0x0003A537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06001707 RID: 5895 RVA: 0x0003C33A File Offset: 0x0003A53A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActionErrorCodeNotify.Descriptor;
			}
		}

		// Token: 0x06001708 RID: 5896 RVA: 0x0003C341 File Offset: 0x0003A541
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionErrorCodeNotify()
		{
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x0003C34C File Offset: 0x0003A54C
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

		// Token: 0x0600170A RID: 5898 RVA: 0x0003C3B0 File Offset: 0x0003A5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionErrorCodeNotify Clone()
		{
			return new ActionErrorCodeNotify(this);
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x0600170B RID: 5899 RVA: 0x0003C3B8 File Offset: 0x0003A5B8
		// (set) Token: 0x0600170C RID: 5900 RVA: 0x0003C3C0 File Offset: 0x0003A5C0
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

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600170D RID: 5901 RVA: 0x0003C3C9 File Offset: 0x0003A5C9
		// (set) Token: 0x0600170E RID: 5902 RVA: 0x0003C3D1 File Offset: 0x0003A5D1
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

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600170F RID: 5903 RVA: 0x0003C3DA File Offset: 0x0003A5DA
		// (set) Token: 0x06001710 RID: 5904 RVA: 0x0003C3E2 File Offset: 0x0003A5E2
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

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06001711 RID: 5905 RVA: 0x0003C3EB File Offset: 0x0003A5EB
		// (set) Token: 0x06001712 RID: 5906 RVA: 0x0003C3F3 File Offset: 0x0003A5F3
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

		// Token: 0x06001713 RID: 5907 RVA: 0x0003C3FC File Offset: 0x0003A5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActionErrorCodeNotify);
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x0003C40C File Offset: 0x0003A60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActionErrorCodeNotify other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && object.Equals(this.GameCtx, other.GameCtx) && this.Index == other.Index && this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x0003C47C File Offset: 0x0003A67C
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

		// Token: 0x06001716 RID: 5910 RVA: 0x0003C509 File Offset: 0x0003A709
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x0003C516 File Offset: 0x0003A716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001718 RID: 5912 RVA: 0x0003C520 File Offset: 0x0003A720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.gameCtx_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.GameCtx);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.Code);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.IncId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001719 RID: 5913 RVA: 0x0003C5B4 File Offset: 0x0003A7B4
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

		// Token: 0x0600171A RID: 5914 RVA: 0x0003C63C File Offset: 0x0003A83C
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

		// Token: 0x0600171B RID: 5915 RVA: 0x0003C6CC File Offset: 0x0003A8CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x0003C6D8 File Offset: 0x0003A8D8
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
				if (num <= 64U)
				{
					if (num == 18U)
					{
						if (this.gameCtx_ == null)
						{
							this.GameCtx = new GameCtxPb();
						}
						input.ReadMessage(this.GameCtx);
						continue;
					}
					if (num == 64U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.Index = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002155 RID: 8533
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002156 RID: 8534
		public const int IncIdFieldNumber = 10;

		// Token: 0x04002157 RID: 8535
		private int incId_;

		// Token: 0x04002158 RID: 8536
		public const int GameCtxFieldNumber = 2;

		// Token: 0x04002159 RID: 8537
		private GameCtxPb gameCtx_;

		// Token: 0x0400215A RID: 8538
		public const int IndexFieldNumber = 14;

		// Token: 0x0400215B RID: 8539
		private int index_;

		// Token: 0x0400215C RID: 8540
		public const int CodeFieldNumber = 8;

		// Token: 0x0400215D RID: 8541
		private ErrorCode code_;
	}
}
