using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002B1 RID: 689
	public sealed class ClientTriggerTeleportPb : IMessage<ClientTriggerTeleportPb>, IMessage, IEquatable<ClientTriggerTeleportPb>, IDeepCloneable<ClientTriggerTeleportPb>, IBufferMessage
	{
		// Token: 0x0600478E RID: 18318 RVA: 0x000AFFA3 File Offset: 0x000AE1A3
		[NullableContext(1)]
		public static ClientTriggerTeleportPb Create()
		{
			return new ClientTriggerTeleportPb();
		}

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x0600478F RID: 18319 RVA: 0x000AFFAA File Offset: 0x000AE1AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x06004790 RID: 18320 RVA: 0x000AFFAD File Offset: 0x000AE1AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientTriggerTeleportPb.Descriptor;
			}
		}

		// Token: 0x06004791 RID: 18321 RVA: 0x000AFFB4 File Offset: 0x000AE1B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientTriggerTeleportPb()
		{
		}

		// Token: 0x06004792 RID: 18322 RVA: 0x000AFFBC File Offset: 0x000AE1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientTriggerTeleportPb(ClientTriggerTeleportPb other) : this()
		{
			this.actionCtx_ = ((other.actionCtx_ != null) ? other.actionCtx_.Clone() : null);
			this.index_ = other.index_;
			this.streamingSourceConditionIndex_ = other.streamingSourceConditionIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004793 RID: 18323 RVA: 0x000B0014 File Offset: 0x000AE214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientTriggerTeleportPb Clone()
		{
			return new ClientTriggerTeleportPb(this);
		}

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x06004794 RID: 18324 RVA: 0x000B001C File Offset: 0x000AE21C
		// (set) Token: 0x06004795 RID: 18325 RVA: 0x000B0024 File Offset: 0x000AE224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameCtxPb ActionCtx
		{
			get
			{
				return this.actionCtx_;
			}
			set
			{
				this.actionCtx_ = value;
			}
		}

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x06004796 RID: 18326 RVA: 0x000B002D File Offset: 0x000AE22D
		// (set) Token: 0x06004797 RID: 18327 RVA: 0x000B0035 File Offset: 0x000AE235
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

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x06004798 RID: 18328 RVA: 0x000B003E File Offset: 0x000AE23E
		// (set) Token: 0x06004799 RID: 18329 RVA: 0x000B0046 File Offset: 0x000AE246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StreamingSourceConditionIndex
		{
			get
			{
				return this.streamingSourceConditionIndex_;
			}
			set
			{
				this.streamingSourceConditionIndex_ = value;
			}
		}

		// Token: 0x0600479A RID: 18330 RVA: 0x000B004F File Offset: 0x000AE24F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientTriggerTeleportPb);
		}

		// Token: 0x0600479B RID: 18331 RVA: 0x000B0060 File Offset: 0x000AE260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientTriggerTeleportPb other)
		{
			return other != null && (other == this || (object.Equals(this.ActionCtx, other.ActionCtx) && this.Index == other.Index && this.StreamingSourceConditionIndex == other.StreamingSourceConditionIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600479C RID: 18332 RVA: 0x000B00C0 File Offset: 0x000AE2C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.actionCtx_ != null)
			{
				num ^= this.ActionCtx.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.StreamingSourceConditionIndex != 0)
			{
				num ^= this.StreamingSourceConditionIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600479D RID: 18333 RVA: 0x000B012E File Offset: 0x000AE32E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600479E RID: 18334 RVA: 0x000B013B File Offset: 0x000AE33B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600479F RID: 18335 RVA: 0x000B0144 File Offset: 0x000AE344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.actionCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ActionCtx);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Index);
			}
			if (this.StreamingSourceConditionIndex != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.StreamingSourceConditionIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060047A0 RID: 18336 RVA: 0x000B01BC File Offset: 0x000AE3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.actionCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ActionCtx);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.StreamingSourceConditionIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StreamingSourceConditionIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060047A1 RID: 18337 RVA: 0x000B022C File Offset: 0x000AE42C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClientTriggerTeleportPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.actionCtx_ != null)
			{
				if (this.actionCtx_ == null)
				{
					this.ActionCtx = new GameCtxPb();
				}
				this.ActionCtx.MergeFrom(other.ActionCtx);
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.StreamingSourceConditionIndex != 0)
			{
				this.StreamingSourceConditionIndex = other.StreamingSourceConditionIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060047A2 RID: 18338 RVA: 0x000B02A8 File Offset: 0x000AE4A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060047A3 RID: 18339 RVA: 0x000B02B4 File Offset: 0x000AE4B4
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.StreamingSourceConditionIndex = input.ReadInt32();
						}
					}
					else
					{
						this.Index = input.ReadInt32();
					}
				}
				else
				{
					if (this.actionCtx_ == null)
					{
						this.ActionCtx = new GameCtxPb();
					}
					input.ReadMessage(this.ActionCtx);
				}
			}
		}

		// Token: 0x04002FF9 RID: 12281
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FFA RID: 12282
		public const int ActionCtxFieldNumber = 1;

		// Token: 0x04002FFB RID: 12283
		private GameCtxPb actionCtx_;

		// Token: 0x04002FFC RID: 12284
		public const int IndexFieldNumber = 2;

		// Token: 0x04002FFD RID: 12285
		private int index_;

		// Token: 0x04002FFE RID: 12286
		public const int StreamingSourceConditionIndexFieldNumber = 3;

		// Token: 0x04002FFF RID: 12287
		private int streamingSourceConditionIndex_;
	}
}
