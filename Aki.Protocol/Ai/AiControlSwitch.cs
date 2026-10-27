using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x020016AA RID: 5802
	public sealed class AiControlSwitch : IMessage<AiControlSwitch>, IMessage, IEquatable<AiControlSwitch>, IDeepCloneable<AiControlSwitch>, IBufferMessage
	{
		// Token: 0x0601D125 RID: 119077 RVA: 0x00441279 File Offset: 0x0043F479
		[NullableContext(1)]
		public static AiControlSwitch Create()
		{
			return new AiControlSwitch();
		}

		// Token: 0x170062A3 RID: 25251
		// (get) Token: 0x0601D126 RID: 119078 RVA: 0x00441280 File Offset: 0x0043F480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AiControlSwitch> Parser
		{
			get
			{
				return AiControlSwitch._parser;
			}
		}

		// Token: 0x170062A4 RID: 25252
		// (get) Token: 0x0601D127 RID: 119079 RVA: 0x00441287 File Offset: 0x0043F487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062A5 RID: 25253
		// (get) Token: 0x0601D128 RID: 119080 RVA: 0x0044128A File Offset: 0x0043F48A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiControlSwitch.Descriptor;
			}
		}

		// Token: 0x0601D129 RID: 119081 RVA: 0x00441291 File Offset: 0x0043F491
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiControlSwitch()
		{
		}

		// Token: 0x0601D12A RID: 119082 RVA: 0x0044129C File Offset: 0x0043F49C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiControlSwitch(AiControlSwitch other) : this()
		{
			this.entityId_ = other.entityId_;
			this.aiInfo_ = ((other.aiInfo_ != null) ? other.aiInfo_.Clone() : null);
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D12B RID: 119083 RVA: 0x004412F4 File Offset: 0x0043F4F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiControlSwitch Clone()
		{
			return new AiControlSwitch(this);
		}

		// Token: 0x170062A6 RID: 25254
		// (get) Token: 0x0601D12C RID: 119084 RVA: 0x004412FC File Offset: 0x0043F4FC
		// (set) Token: 0x0601D12D RID: 119085 RVA: 0x00441304 File Offset: 0x0043F504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x170062A7 RID: 25255
		// (get) Token: 0x0601D12E RID: 119086 RVA: 0x0044130D File Offset: 0x0043F50D
		// (set) Token: 0x0601D12F RID: 119087 RVA: 0x00441315 File Offset: 0x0043F515
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformation AiInfo
		{
			get
			{
				return this.aiInfo_;
			}
			set
			{
				this.aiInfo_ = value;
			}
		}

		// Token: 0x170062A8 RID: 25256
		// (get) Token: 0x0601D130 RID: 119088 RVA: 0x0044131E File Offset: 0x0043F51E
		// (set) Token: 0x0601D131 RID: 119089 RVA: 0x00441326 File Offset: 0x0043F526
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

		// Token: 0x0601D132 RID: 119090 RVA: 0x0044132F File Offset: 0x0043F52F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiControlSwitch);
		}

		// Token: 0x0601D133 RID: 119091 RVA: 0x00441340 File Offset: 0x0043F540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiControlSwitch other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.AiInfo, other.AiInfo) && this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D134 RID: 119092 RVA: 0x004413A0 File Offset: 0x0043F5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.aiInfo_ != null)
			{
				num ^= this.AiInfo.GetHashCode();
			}
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D135 RID: 119093 RVA: 0x0044140E File Offset: 0x0043F60E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D136 RID: 119094 RVA: 0x0044141B File Offset: 0x0043F61B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D137 RID: 119095 RVA: 0x00441424 File Offset: 0x0043F624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.aiInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.AiInfo);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D138 RID: 119096 RVA: 0x00441498 File Offset: 0x0043F698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.aiInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AiInfo);
			}
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D139 RID: 119097 RVA: 0x00441508 File Offset: 0x0043F708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiControlSwitch other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.aiInfo_ != null)
			{
				if (this.aiInfo_ == null)
				{
					this.AiInfo = new AiInformation();
				}
				this.AiInfo.MergeFrom(other.AiInfo);
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D13A RID: 119098 RVA: 0x00441584 File Offset: 0x0043F784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D13B RID: 119099 RVA: 0x00441590 File Offset: 0x0043F790
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.PlayerId = input.ReadInt32();
						}
					}
					else
					{
						if (this.aiInfo_ == null)
						{
							this.AiInfo = new AiInformation();
						}
						input.ReadMessage(this.AiInfo);
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400C428 RID: 50216
		private static readonly MessageParser<AiControlSwitch> _parser = new MessageParser<AiControlSwitch>(() => new AiControlSwitch());

		// Token: 0x0400C429 RID: 50217
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C42A RID: 50218
		public const int EntityIdFieldNumber = 1;

		// Token: 0x0400C42B RID: 50219
		private long entityId_;

		// Token: 0x0400C42C RID: 50220
		public const int AiInfoFieldNumber = 2;

		// Token: 0x0400C42D RID: 50221
		private AiInformation aiInfo_;

		// Token: 0x0400C42E RID: 50222
		public const int PlayerIdFieldNumber = 3;

		// Token: 0x0400C42F RID: 50223
		private int playerId_;
	}
}
