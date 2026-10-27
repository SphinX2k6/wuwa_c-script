using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002AB RID: 683
	public sealed class ClientTriggerTeleportPb : IMessage<ClientTriggerTeleportPb>, IMessage, IEquatable<ClientTriggerTeleportPb>, IDeepCloneable<ClientTriggerTeleportPb>, IBufferMessage
	{
		// Token: 0x060046C7 RID: 18119 RVA: 0x000ADD93 File Offset: 0x000ABF93
		[NullableContext(1)]
		public static ClientTriggerTeleportPb Create()
		{
			return new ClientTriggerTeleportPb();
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x060046C8 RID: 18120 RVA: 0x000ADD9A File Offset: 0x000ABF9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x060046C9 RID: 18121 RVA: 0x000ADD9D File Offset: 0x000ABF9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientTriggerTeleportPb.Descriptor;
			}
		}

		// Token: 0x060046CA RID: 18122 RVA: 0x000ADDA4 File Offset: 0x000ABFA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientTriggerTeleportPb()
		{
		}

		// Token: 0x060046CB RID: 18123 RVA: 0x000ADDAC File Offset: 0x000ABFAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientTriggerTeleportPb(ClientTriggerTeleportPb other) : this()
		{
			this.actionCtx_ = ((other.actionCtx_ != null) ? other.actionCtx_.Clone() : null);
			this.index_ = other.index_;
			this.streamingSourceConditionIndex_ = other.streamingSourceConditionIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060046CC RID: 18124 RVA: 0x000ADE04 File Offset: 0x000AC004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientTriggerTeleportPb Clone()
		{
			return new ClientTriggerTeleportPb(this);
		}

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x060046CD RID: 18125 RVA: 0x000ADE0C File Offset: 0x000AC00C
		// (set) Token: 0x060046CE RID: 18126 RVA: 0x000ADE14 File Offset: 0x000AC014
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

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x060046CF RID: 18127 RVA: 0x000ADE1D File Offset: 0x000AC01D
		// (set) Token: 0x060046D0 RID: 18128 RVA: 0x000ADE25 File Offset: 0x000AC025
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

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x060046D1 RID: 18129 RVA: 0x000ADE2E File Offset: 0x000AC02E
		// (set) Token: 0x060046D2 RID: 18130 RVA: 0x000ADE36 File Offset: 0x000AC036
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

		// Token: 0x060046D3 RID: 18131 RVA: 0x000ADE3F File Offset: 0x000AC03F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientTriggerTeleportPb);
		}

		// Token: 0x060046D4 RID: 18132 RVA: 0x000ADE50 File Offset: 0x000AC050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientTriggerTeleportPb other)
		{
			return other != null && (other == this || (object.Equals(this.ActionCtx, other.ActionCtx) && this.Index == other.Index && this.StreamingSourceConditionIndex == other.StreamingSourceConditionIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060046D5 RID: 18133 RVA: 0x000ADEB0 File Offset: 0x000AC0B0
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

		// Token: 0x060046D6 RID: 18134 RVA: 0x000ADF1E File Offset: 0x000AC11E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060046D7 RID: 18135 RVA: 0x000ADF2B File Offset: 0x000AC12B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060046D8 RID: 18136 RVA: 0x000ADF34 File Offset: 0x000AC134
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

		// Token: 0x060046D9 RID: 18137 RVA: 0x000ADFAC File Offset: 0x000AC1AC
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

		// Token: 0x060046DA RID: 18138 RVA: 0x000AE01C File Offset: 0x000AC21C
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

		// Token: 0x060046DB RID: 18139 RVA: 0x000AE098 File Offset: 0x000AC298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060046DC RID: 18140 RVA: 0x000AE0A4 File Offset: 0x000AC2A4
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

		// Token: 0x04002F66 RID: 12134
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F67 RID: 12135
		public const int ActionCtxFieldNumber = 1;

		// Token: 0x04002F68 RID: 12136
		private GameCtxPb actionCtx_;

		// Token: 0x04002F69 RID: 12137
		public const int IndexFieldNumber = 2;

		// Token: 0x04002F6A RID: 12138
		private int index_;

		// Token: 0x04002F6B RID: 12139
		public const int StreamingSourceConditionIndexFieldNumber = 3;

		// Token: 0x04002F6C RID: 12140
		private int streamingSourceConditionIndex_;
	}
}
