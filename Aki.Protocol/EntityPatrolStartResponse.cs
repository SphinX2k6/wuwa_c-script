using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000496 RID: 1174
	[NetMessage(EMessageId.EntityPatrolStartResponse)]
	public sealed class EntityPatrolStartResponse : IMessage<EntityPatrolStartResponse>, IMessage, IEquatable<EntityPatrolStartResponse>, IDeepCloneable<EntityPatrolStartResponse>, IBufferMessage
	{
		// Token: 0x06007073 RID: 28787 RVA: 0x001145C4 File Offset: 0x001127C4
		[NullableContext(1)]
		public static EntityPatrolStartResponse Create()
		{
			return new EntityPatrolStartResponse();
		}

		// Token: 0x170015A9 RID: 5545
		// (get) Token: 0x06007074 RID: 28788 RVA: 0x001145CB File Offset: 0x001127CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015AA RID: 5546
		// (get) Token: 0x06007075 RID: 28789 RVA: 0x001145CE File Offset: 0x001127CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityPatrolStartResponse.Descriptor;
			}
		}

		// Token: 0x06007076 RID: 28790 RVA: 0x001145D5 File Offset: 0x001127D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolStartResponse()
		{
		}

		// Token: 0x06007077 RID: 28791 RVA: 0x001145DD File Offset: 0x001127DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolStartResponse(EntityPatrolStartResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007078 RID: 28792 RVA: 0x00114602 File Offset: 0x00112802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolStartResponse Clone()
		{
			return new EntityPatrolStartResponse(this);
		}

		// Token: 0x170015AB RID: 5547
		// (get) Token: 0x06007079 RID: 28793 RVA: 0x0011460A File Offset: 0x0011280A
		// (set) Token: 0x0600707A RID: 28794 RVA: 0x00114612 File Offset: 0x00112812
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

		// Token: 0x0600707B RID: 28795 RVA: 0x0011461B File Offset: 0x0011281B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityPatrolStartResponse);
		}

		// Token: 0x0600707C RID: 28796 RVA: 0x00114629 File Offset: 0x00112829
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityPatrolStartResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600707D RID: 28797 RVA: 0x00114658 File Offset: 0x00112858
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

		// Token: 0x0600707E RID: 28798 RVA: 0x0011469D File Offset: 0x0011289D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600707F RID: 28799 RVA: 0x001146AA File Offset: 0x001128AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007080 RID: 28800 RVA: 0x001146B3 File Offset: 0x001128B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007081 RID: 28801 RVA: 0x001146E8 File Offset: 0x001128E8
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

		// Token: 0x06007082 RID: 28802 RVA: 0x00114726 File Offset: 0x00112926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityPatrolStartResponse other)
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

		// Token: 0x06007083 RID: 28803 RVA: 0x00114757 File Offset: 0x00112957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007084 RID: 28804 RVA: 0x00114760 File Offset: 0x00112960
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003C93 RID: 15507
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C94 RID: 15508
		public const int CodeFieldNumber = 4;

		// Token: 0x04003C95 RID: 15509
		private ErrorCode code_;
	}
}
