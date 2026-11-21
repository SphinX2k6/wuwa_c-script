using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000494 RID: 1172
	[NetMessage(EMessageId.EntityPatrolChangeDirResponse)]
	public sealed class EntityPatrolChangeDirResponse : IMessage<EntityPatrolChangeDirResponse>, IMessage, IEquatable<EntityPatrolChangeDirResponse>, IDeepCloneable<EntityPatrolChangeDirResponse>, IBufferMessage
	{
		// Token: 0x0600704D RID: 28749 RVA: 0x00114153 File Offset: 0x00112353
		[NullableContext(1)]
		public static EntityPatrolChangeDirResponse Create()
		{
			return new EntityPatrolChangeDirResponse();
		}

		// Token: 0x170015A2 RID: 5538
		// (get) Token: 0x0600704E RID: 28750 RVA: 0x0011415A File Offset: 0x0011235A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015A3 RID: 5539
		// (get) Token: 0x0600704F RID: 28751 RVA: 0x0011415D File Offset: 0x0011235D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityPatrolChangeDirResponse.Descriptor;
			}
		}

		// Token: 0x06007050 RID: 28752 RVA: 0x00114164 File Offset: 0x00112364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolChangeDirResponse()
		{
		}

		// Token: 0x06007051 RID: 28753 RVA: 0x0011416C File Offset: 0x0011236C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolChangeDirResponse(EntityPatrolChangeDirResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007052 RID: 28754 RVA: 0x00114191 File Offset: 0x00112391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolChangeDirResponse Clone()
		{
			return new EntityPatrolChangeDirResponse(this);
		}

		// Token: 0x170015A4 RID: 5540
		// (get) Token: 0x06007053 RID: 28755 RVA: 0x00114199 File Offset: 0x00112399
		// (set) Token: 0x06007054 RID: 28756 RVA: 0x001141A1 File Offset: 0x001123A1
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

		// Token: 0x06007055 RID: 28757 RVA: 0x001141AA File Offset: 0x001123AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityPatrolChangeDirResponse);
		}

		// Token: 0x06007056 RID: 28758 RVA: 0x001141B8 File Offset: 0x001123B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityPatrolChangeDirResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007057 RID: 28759 RVA: 0x001141E8 File Offset: 0x001123E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06007058 RID: 28760 RVA: 0x0011422D File Offset: 0x0011242D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007059 RID: 28761 RVA: 0x0011423A File Offset: 0x0011243A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600705A RID: 28762 RVA: 0x00114243 File Offset: 0x00112443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600705B RID: 28763 RVA: 0x00114278 File Offset: 0x00112478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600705C RID: 28764 RVA: 0x001142B6 File Offset: 0x001124B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityPatrolChangeDirResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600705D RID: 28765 RVA: 0x001142E7 File Offset: 0x001124E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600705E RID: 28766 RVA: 0x001142F0 File Offset: 0x001124F0
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003C8B RID: 15499
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C8C RID: 15500
		public const int CodeFieldNumber = 8;

		// Token: 0x04003C8D RID: 15501
		private ErrorCode code_;
	}
}
