using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000073 RID: 115
	[NetMessage(EMessageId.ActionOperationScreenNotify)]
	public sealed class ActionOperationScreenNotify : IMessage<ActionOperationScreenNotify>, IMessage, IEquatable<ActionOperationScreenNotify>, IDeepCloneable<ActionOperationScreenNotify>, IBufferMessage
	{
		// Token: 0x060017AC RID: 6060 RVA: 0x0003E345 File Offset: 0x0003C545
		[NullableContext(1)]
		public static ActionOperationScreenNotify Create()
		{
			return new ActionOperationScreenNotify();
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060017AD RID: 6061 RVA: 0x0003E34C File Offset: 0x0003C54C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060017AE RID: 6062 RVA: 0x0003E34F File Offset: 0x0003C54F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActionOperationScreenNotify.Descriptor;
			}
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x0003E356 File Offset: 0x0003C556
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionOperationScreenNotify()
		{
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x0003E36C File Offset: 0x0003C56C
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

		// Token: 0x060017B1 RID: 6065 RVA: 0x0003E3DC File Offset: 0x0003C5DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionOperationScreenNotify Clone()
		{
			return new ActionOperationScreenNotify(this);
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060017B2 RID: 6066 RVA: 0x0003E3E4 File Offset: 0x0003C5E4
		// (set) Token: 0x060017B3 RID: 6067 RVA: 0x0003E3EC File Offset: 0x0003C5EC
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

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060017B4 RID: 6068 RVA: 0x0003E3F5 File Offset: 0x0003C5F5
		// (set) Token: 0x060017B5 RID: 6069 RVA: 0x0003E3FD File Offset: 0x0003C5FD
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

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060017B6 RID: 6070 RVA: 0x0003E406 File Offset: 0x0003C606
		// (set) Token: 0x060017B7 RID: 6071 RVA: 0x0003E40E File Offset: 0x0003C60E
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

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060017B8 RID: 6072 RVA: 0x0003E417 File Offset: 0x0003C617
		// (set) Token: 0x060017B9 RID: 6073 RVA: 0x0003E41F File Offset: 0x0003C61F
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

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060017BA RID: 6074 RVA: 0x0003E432 File Offset: 0x0003C632
		// (set) Token: 0x060017BB RID: 6075 RVA: 0x0003E43A File Offset: 0x0003C63A
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

		// Token: 0x060017BC RID: 6076 RVA: 0x0003E443 File Offset: 0x0003C643
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActionOperationScreenNotify);
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x0003E454 File Offset: 0x0003C654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActionOperationScreenNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.IncId == other.IncId && this.Type == other.Type && !(this.Params != other.Params) && object.Equals(this.GameCtx, other.GameCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x0003E4D8 File Offset: 0x0003C6D8
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

		// Token: 0x060017BF RID: 6079 RVA: 0x0003E580 File Offset: 0x0003C780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x0003E58D File Offset: 0x0003C78D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x0003E598 File Offset: 0x0003C798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.PlayerId);
			}
			if (this.Type != ActionScreenOperationType.Close)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.Type);
			}
			if (this.gameCtx_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.GameCtx);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.IncId);
			}
			if (this.Params.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteString(this.Params);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x0003E64C File Offset: 0x0003C84C
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

		// Token: 0x060017C3 RID: 6083 RVA: 0x0003E6F0 File Offset: 0x0003C8F0
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

		// Token: 0x060017C4 RID: 6084 RVA: 0x0003E799 File Offset: 0x0003C999
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060017C5 RID: 6085 RVA: 0x0003E7A4 File Offset: 0x0003C9A4
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
				if (num <= 56U)
				{
					if (num == 48U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.Type = (ActionScreenOperationType)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						if (this.gameCtx_ == null)
						{
							this.GameCtx = new GameCtxPb();
						}
						input.ReadMessage(this.GameCtx);
						continue;
					}
					if (num == 88U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
					if (num == 122U)
					{
						this.Params = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002142 RID: 8514
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002143 RID: 8515
		public const int PlayerIdFieldNumber = 6;

		// Token: 0x04002144 RID: 8516
		private int playerId_;

		// Token: 0x04002145 RID: 8517
		public const int IncIdFieldNumber = 11;

		// Token: 0x04002146 RID: 8518
		private int incId_;

		// Token: 0x04002147 RID: 8519
		public const int TypeFieldNumber = 7;

		// Token: 0x04002148 RID: 8520
		private ActionScreenOperationType type_;

		// Token: 0x04002149 RID: 8521
		public const int ParamsFieldNumber = 15;

		// Token: 0x0400214A RID: 8522
		private string params_ = "";

		// Token: 0x0400214B RID: 8523
		public const int GameCtxFieldNumber = 9;

		// Token: 0x0400214C RID: 8524
		private GameCtxPb gameCtx_;
	}
}
