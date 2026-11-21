using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200006F RID: 111
	[NetMessage(EMessageId.ActionGroupCreateNotify)]
	public sealed class ActionGroupCreateNotify : IMessage<ActionGroupCreateNotify>, IMessage, IEquatable<ActionGroupCreateNotify>, IDeepCloneable<ActionGroupCreateNotify>, IBufferMessage
	{
		// Token: 0x0600176F RID: 5999 RVA: 0x0003D2A3 File Offset: 0x0003B4A3
		[NullableContext(1)]
		public static ActionGroupCreateNotify Create()
		{
			return new ActionGroupCreateNotify();
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06001770 RID: 6000 RVA: 0x0003D2AA File Offset: 0x0003B4AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06001771 RID: 6001 RVA: 0x0003D2AD File Offset: 0x0003B4AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActionGroupCreateNotify.Descriptor;
			}
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x0003D2B4 File Offset: 0x0003B4B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionGroupCreateNotify()
		{
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x0003D2BC File Offset: 0x0003B4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionGroupCreateNotify(ActionGroupCreateNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.incId_ = other.incId_;
			this.gameCtx_ = ((other.gameCtx_ != null) ? other.gameCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001774 RID: 6004 RVA: 0x0003D314 File Offset: 0x0003B514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionGroupCreateNotify Clone()
		{
			return new ActionGroupCreateNotify(this);
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06001775 RID: 6005 RVA: 0x0003D31C File Offset: 0x0003B51C
		// (set) Token: 0x06001776 RID: 6006 RVA: 0x0003D324 File Offset: 0x0003B524
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

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06001777 RID: 6007 RVA: 0x0003D32D File Offset: 0x0003B52D
		// (set) Token: 0x06001778 RID: 6008 RVA: 0x0003D335 File Offset: 0x0003B535
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

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06001779 RID: 6009 RVA: 0x0003D33E File Offset: 0x0003B53E
		// (set) Token: 0x0600177A RID: 6010 RVA: 0x0003D346 File Offset: 0x0003B546
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

		// Token: 0x0600177B RID: 6011 RVA: 0x0003D34F File Offset: 0x0003B54F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActionGroupCreateNotify);
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x0003D360 File Offset: 0x0003B560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActionGroupCreateNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.IncId == other.IncId && object.Equals(this.GameCtx, other.GameCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600177D RID: 6013 RVA: 0x0003D3C0 File Offset: 0x0003B5C0
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

		// Token: 0x0600177E RID: 6014 RVA: 0x0003D42E File Offset: 0x0003B62E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600177F RID: 6015 RVA: 0x0003D43B File Offset: 0x0003B63B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x0003D444 File Offset: 0x0003B644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.gameCtx_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.GameCtx);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.PlayerId);
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

		// Token: 0x06001781 RID: 6017 RVA: 0x0003D4BC File Offset: 0x0003B6BC
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

		// Token: 0x06001782 RID: 6018 RVA: 0x0003D52C File Offset: 0x0003B72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActionGroupCreateNotify other)
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

		// Token: 0x06001783 RID: 6019 RVA: 0x0003D5A8 File Offset: 0x0003B7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x0003D5B4 File Offset: 0x0003B7B4
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
				if (num != 18U)
				{
					if (num != 88U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IncId = input.ReadInt32();
						}
					}
					else
					{
						this.PlayerId = input.ReadInt32();
					}
				}
				else
				{
					if (this.gameCtx_ == null)
					{
						this.GameCtx = new GameCtxPb();
					}
					input.ReadMessage(this.GameCtx);
				}
			}
		}

		// Token: 0x04002174 RID: 8564
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002175 RID: 8565
		public const int PlayerIdFieldNumber = 11;

		// Token: 0x04002176 RID: 8566
		private int playerId_;

		// Token: 0x04002177 RID: 8567
		public const int IncIdFieldNumber = 14;

		// Token: 0x04002178 RID: 8568
		private int incId_;

		// Token: 0x04002179 RID: 8569
		public const int GameCtxFieldNumber = 2;

		// Token: 0x0400217A RID: 8570
		private GameCtxPb gameCtx_;
	}
}
