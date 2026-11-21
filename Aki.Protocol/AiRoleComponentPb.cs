using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000DC RID: 220
	public sealed class AiRoleComponentPb : IMessage<AiRoleComponentPb>, IMessage, IEquatable<AiRoleComponentPb>, IDeepCloneable<AiRoleComponentPb>, IBufferMessage
	{
		// Token: 0x0600211E RID: 8478 RVA: 0x00059144 File Offset: 0x00057344
		[NullableContext(1)]
		public static AiRoleComponentPb Create()
		{
			return new AiRoleComponentPb();
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x0600211F RID: 8479 RVA: 0x0005914B File Offset: 0x0005734B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06002120 RID: 8480 RVA: 0x0005914E File Offset: 0x0005734E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiRoleComponentPb.Descriptor;
			}
		}

		// Token: 0x06002121 RID: 8481 RVA: 0x00059155 File Offset: 0x00057355
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiRoleComponentPb()
		{
		}

		// Token: 0x06002122 RID: 8482 RVA: 0x0005915D File Offset: 0x0005735D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiRoleComponentPb(AiRoleComponentPb other) : this()
		{
			this.isAiRole_ = other.isAiRole_;
			this.contextId_ = other.contextId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002123 RID: 8483 RVA: 0x0005918E File Offset: 0x0005738E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiRoleComponentPb Clone()
		{
			return new AiRoleComponentPb(this);
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06002124 RID: 8484 RVA: 0x00059196 File Offset: 0x00057396
		// (set) Token: 0x06002125 RID: 8485 RVA: 0x0005919E File Offset: 0x0005739E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsAiRole
		{
			get
			{
				return this.isAiRole_;
			}
			set
			{
				this.isAiRole_ = value;
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06002126 RID: 8486 RVA: 0x000591A7 File Offset: 0x000573A7
		// (set) Token: 0x06002127 RID: 8487 RVA: 0x000591AF File Offset: 0x000573AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ContextId
		{
			get
			{
				return this.contextId_;
			}
			set
			{
				this.contextId_ = value;
			}
		}

		// Token: 0x06002128 RID: 8488 RVA: 0x000591B8 File Offset: 0x000573B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiRoleComponentPb);
		}

		// Token: 0x06002129 RID: 8489 RVA: 0x000591C6 File Offset: 0x000573C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiRoleComponentPb other)
		{
			return other != null && (other == this || (this.IsAiRole == other.IsAiRole && this.ContextId == other.ContextId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600212A RID: 8490 RVA: 0x00059204 File Offset: 0x00057404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsAiRole)
			{
				num ^= this.IsAiRole.GetHashCode();
			}
			if (this.ContextId != 0L)
			{
				num ^= this.ContextId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600212B RID: 8491 RVA: 0x0005925C File Offset: 0x0005745C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600212C RID: 8492 RVA: 0x00059269 File Offset: 0x00057469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600212D RID: 8493 RVA: 0x00059274 File Offset: 0x00057474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsAiRole)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsAiRole);
			}
			if (this.ContextId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.ContextId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600212E RID: 8494 RVA: 0x000592CC File Offset: 0x000574CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsAiRole)
			{
				num += 2;
			}
			if (this.ContextId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ContextId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600212F RID: 8495 RVA: 0x00059318 File Offset: 0x00057518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiRoleComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsAiRole)
			{
				this.IsAiRole = other.IsAiRole;
			}
			if (other.ContextId != 0L)
			{
				this.ContextId = other.ContextId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002130 RID: 8496 RVA: 0x00059368 File Offset: 0x00057568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002131 RID: 8497 RVA: 0x00059374 File Offset: 0x00057574
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ContextId = input.ReadInt64();
					}
				}
				else
				{
					this.IsAiRole = input.ReadBool();
				}
			}
		}

		// Token: 0x04002473 RID: 9331
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002474 RID: 9332
		public const int IsAiRoleFieldNumber = 1;

		// Token: 0x04002475 RID: 9333
		private bool isAiRole_;

		// Token: 0x04002476 RID: 9334
		public const int ContextIdFieldNumber = 2;

		// Token: 0x04002477 RID: 9335
		private long contextId_;
	}
}
