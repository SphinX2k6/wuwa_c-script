using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000074 RID: 116
	[NetMessage(EMessageId.ActionOperationScreenNotify)]
	public sealed class ActionOperationScreenNotify : IMessage<ActionOperationScreenNotify>, IMessage, IEquatable<ActionOperationScreenNotify>, IDeepCloneable<ActionOperationScreenNotify>, IBufferMessage
	{
		// Token: 0x060017EF RID: 6127 RVA: 0x0003ECE9 File Offset: 0x0003CEE9
		[NullableContext(1)]
		public static ActionOperationScreenNotify Create()
		{
			return new ActionOperationScreenNotify();
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060017F0 RID: 6128 RVA: 0x0003ECF0 File Offset: 0x0003CEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060017F1 RID: 6129 RVA: 0x0003ECF3 File Offset: 0x0003CEF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActionOperationScreenNotify.Descriptor;
			}
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x0003ECFA File Offset: 0x0003CEFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionOperationScreenNotify()
		{
		}

		// Token: 0x060017F3 RID: 6131 RVA: 0x0003ED10 File Offset: 0x0003CF10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionOperationScreenNotify(ActionOperationScreenNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.incId_ = other.incId_;
			this.type_ = other.type_;
			this.params_ = other.params_;
			this.gameCtx_ = ((other.gameCtx_ != null) ? other.gameCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x0003ED80 File Offset: 0x0003CF80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionOperationScreenNotify Clone()
		{
			return new ActionOperationScreenNotify(this);
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060017F5 RID: 6133 RVA: 0x0003ED88 File Offset: 0x0003CF88
		// (set) Token: 0x060017F6 RID: 6134 RVA: 0x0003ED90 File Offset: 0x0003CF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060017F7 RID: 6135 RVA: 0x0003ED99 File Offset: 0x0003CF99
		// (set) Token: 0x060017F8 RID: 6136 RVA: 0x0003EDA1 File Offset: 0x0003CFA1
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

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060017F9 RID: 6137 RVA: 0x0003EDAA File Offset: 0x0003CFAA
		// (set) Token: 0x060017FA RID: 6138 RVA: 0x0003EDB2 File Offset: 0x0003CFB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionScreenOperationType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060017FB RID: 6139 RVA: 0x0003EDBB File Offset: 0x0003CFBB
		// (set) Token: 0x060017FC RID: 6140 RVA: 0x0003EDC3 File Offset: 0x0003CFC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Params
		{
			get
			{
				return this.params_;
			}
			set
			{
				this.params_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060017FD RID: 6141 RVA: 0x0003EDD6 File Offset: 0x0003CFD6
		// (set) Token: 0x060017FE RID: 6142 RVA: 0x0003EDDE File Offset: 0x0003CFDE
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

		// Token: 0x060017FF RID: 6143 RVA: 0x0003EDE7 File Offset: 0x0003CFE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActionOperationScreenNotify);
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x0003EDF8 File Offset: 0x0003CFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActionOperationScreenNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.IncId == other.IncId && this.Type == other.Type && !(this.Params != other.Params) && object.Equals(this.GameCtx, other.GameCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x0003EE7C File Offset: 0x0003D07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.Type != ActionScreenOperationType.Close)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.Params.Length != 0)
			{
				num ^= this.Params.GetHashCode();
			}
			if (this.gameCtx_ != null)
			{
				num ^= this.GameCtx.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x0003EF24 File Offset: 0x0003D124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001803 RID: 6147 RVA: 0x0003EF31 File Offset: 0x0003D131
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001804 RID: 6148 RVA: 0x0003EF3C File Offset: 0x0003D13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.gameCtx_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.GameCtx);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.IncId);
			}
			if (this.Type != ActionScreenOperationType.Close)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.Type);
			}
			if (this.Params.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteString(this.Params);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001805 RID: 6149 RVA: 0x0003EFF0 File Offset: 0x0003D1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.Type != ActionScreenOperationType.Close)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.Params.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Params);
			}
			if (this.gameCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameCtx);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x0003F094 File Offset: 0x0003D294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActionOperationScreenNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.Type != ActionScreenOperationType.Close)
			{
				this.Type = other.Type;
			}
			if (other.Params.Length != 0)
			{
				this.Params = other.Params;
			}
			if (other.gameCtx_ != null)
			{
				if (this.gameCtx_ == null)
				{
					this.GameCtx = new GameCtxPb();
				}
				this.GameCtx.MergeFrom(other.GameCtx);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x0003F13D File Offset: 0x0003D33D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x0003F148 File Offset: 0x0003D348
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
				if (num <= 32U)
				{
					if (num == 26U)
					{
						if (this.gameCtx_ == null)
						{
							this.GameCtx = new GameCtxPb();
						}
						input.ReadMessage(this.GameCtx);
						continue;
					}
					if (num == 32U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.Type = (ActionScreenOperationType)input.ReadEnum();
						continue;
					}
					if (num == 98U)
					{
						this.Params = input.ReadString();
						continue;
					}
					if (num == 104U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040021A1 RID: 8609
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021A2 RID: 8610
		public const int PlayerIdFieldNumber = 13;

		// Token: 0x040021A3 RID: 8611
		private int playerId_;

		// Token: 0x040021A4 RID: 8612
		public const int IncIdFieldNumber = 4;

		// Token: 0x040021A5 RID: 8613
		private int incId_;

		// Token: 0x040021A6 RID: 8614
		public const int TypeFieldNumber = 6;

		// Token: 0x040021A7 RID: 8615
		private ActionScreenOperationType type_;

		// Token: 0x040021A8 RID: 8616
		public const int ParamsFieldNumber = 12;

		// Token: 0x040021A9 RID: 8617
		private string params_ = "";

		// Token: 0x040021AA RID: 8618
		public const int GameCtxFieldNumber = 3;

		// Token: 0x040021AB RID: 8619
		private GameCtxPb gameCtx_;
	}
}
