using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000DB RID: 219
	public sealed class AiRoleComponentPb : IMessage<AiRoleComponentPb>, IMessage, IEquatable<AiRoleComponentPb>, IDeepCloneable<AiRoleComponentPb>, IBufferMessage
	{
		// Token: 0x060020D5 RID: 8405 RVA: 0x00058490 File Offset: 0x00056690
		[NullableContext(1)]
		public static AiRoleComponentPb Create()
		{
			return new AiRoleComponentPb();
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x060020D6 RID: 8406 RVA: 0x00058497 File Offset: 0x00056697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x060020D7 RID: 8407 RVA: 0x0005849A File Offset: 0x0005669A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiRoleComponentPb.Descriptor;
			}
		}

		// Token: 0x060020D8 RID: 8408 RVA: 0x000584A1 File Offset: 0x000566A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiRoleComponentPb()
		{
		}

		// Token: 0x060020D9 RID: 8409 RVA: 0x000584A9 File Offset: 0x000566A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiRoleComponentPb(AiRoleComponentPb other) : this()
		{
			this.isAiRole_ = other.isAiRole_;
			this.contextId_ = other.contextId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060020DA RID: 8410 RVA: 0x000584DA File Offset: 0x000566DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiRoleComponentPb Clone()
		{
			return new AiRoleComponentPb(this);
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x060020DB RID: 8411 RVA: 0x000584E2 File Offset: 0x000566E2
		// (set) Token: 0x060020DC RID: 8412 RVA: 0x000584EA File Offset: 0x000566EA
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

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x060020DD RID: 8413 RVA: 0x000584F3 File Offset: 0x000566F3
		// (set) Token: 0x060020DE RID: 8414 RVA: 0x000584FB File Offset: 0x000566FB
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

		// Token: 0x060020DF RID: 8415 RVA: 0x00058504 File Offset: 0x00056704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiRoleComponentPb);
		}

		// Token: 0x060020E0 RID: 8416 RVA: 0x00058512 File Offset: 0x00056712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiRoleComponentPb other)
		{
			return other != null && (other == this || (this.IsAiRole == other.IsAiRole && this.ContextId == other.ContextId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060020E1 RID: 8417 RVA: 0x00058550 File Offset: 0x00056750
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

		// Token: 0x060020E2 RID: 8418 RVA: 0x000585A8 File Offset: 0x000567A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060020E3 RID: 8419 RVA: 0x000585B5 File Offset: 0x000567B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060020E4 RID: 8420 RVA: 0x000585C0 File Offset: 0x000567C0
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

		// Token: 0x060020E5 RID: 8421 RVA: 0x00058618 File Offset: 0x00056818
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

		// Token: 0x060020E6 RID: 8422 RVA: 0x00058664 File Offset: 0x00056864
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

		// Token: 0x060020E7 RID: 8423 RVA: 0x000586B4 File Offset: 0x000568B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060020E8 RID: 8424 RVA: 0x000586C0 File Offset: 0x000568C0
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

		// Token: 0x04002410 RID: 9232
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002411 RID: 9233
		public const int IsAiRoleFieldNumber = 1;

		// Token: 0x04002412 RID: 9234
		private bool isAiRole_;

		// Token: 0x04002413 RID: 9235
		public const int ContextIdFieldNumber = 2;

		// Token: 0x04002414 RID: 9236
		private long contextId_;
	}
}
