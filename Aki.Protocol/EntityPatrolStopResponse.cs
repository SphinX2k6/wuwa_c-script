using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000498 RID: 1176
	[NetMessage(EMessageId.EntityPatrolStopResponse)]
	public sealed class EntityPatrolStopResponse : IMessage<EntityPatrolStopResponse>, IMessage, IEquatable<EntityPatrolStopResponse>, IDeepCloneable<EntityPatrolStopResponse>, IBufferMessage
	{
		// Token: 0x06007097 RID: 28823 RVA: 0x0011497D File Offset: 0x00112B7D
		[NullableContext(1)]
		public static EntityPatrolStopResponse Create()
		{
			return new EntityPatrolStopResponse();
		}

		// Token: 0x170015AF RID: 5551
		// (get) Token: 0x06007098 RID: 28824 RVA: 0x00114984 File Offset: 0x00112B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015B0 RID: 5552
		// (get) Token: 0x06007099 RID: 28825 RVA: 0x00114987 File Offset: 0x00112B87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityPatrolStopResponse.Descriptor;
			}
		}

		// Token: 0x0600709A RID: 28826 RVA: 0x0011498E File Offset: 0x00112B8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolStopResponse()
		{
		}

		// Token: 0x0600709B RID: 28827 RVA: 0x00114996 File Offset: 0x00112B96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolStopResponse(EntityPatrolStopResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600709C RID: 28828 RVA: 0x001149BB File Offset: 0x00112BBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolStopResponse Clone()
		{
			return new EntityPatrolStopResponse(this);
		}

		// Token: 0x170015B1 RID: 5553
		// (get) Token: 0x0600709D RID: 28829 RVA: 0x001149C3 File Offset: 0x00112BC3
		// (set) Token: 0x0600709E RID: 28830 RVA: 0x001149CB File Offset: 0x00112BCB
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

		// Token: 0x0600709F RID: 28831 RVA: 0x001149D4 File Offset: 0x00112BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityPatrolStopResponse);
		}

		// Token: 0x060070A0 RID: 28832 RVA: 0x001149E2 File Offset: 0x00112BE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityPatrolStopResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060070A1 RID: 28833 RVA: 0x00114A10 File Offset: 0x00112C10
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

		// Token: 0x060070A2 RID: 28834 RVA: 0x00114A55 File Offset: 0x00112C55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060070A3 RID: 28835 RVA: 0x00114A62 File Offset: 0x00112C62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060070A4 RID: 28836 RVA: 0x00114A6B File Offset: 0x00112C6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060070A5 RID: 28837 RVA: 0x00114AA0 File Offset: 0x00112CA0
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

		// Token: 0x060070A6 RID: 28838 RVA: 0x00114ADE File Offset: 0x00112CDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityPatrolStopResponse other)
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

		// Token: 0x060070A7 RID: 28839 RVA: 0x00114B0F File Offset: 0x00112D0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060070A8 RID: 28840 RVA: 0x00114B18 File Offset: 0x00112D18
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003C99 RID: 15513
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C9A RID: 15514
		public const int CodeFieldNumber = 9;

		// Token: 0x04003C9B RID: 15515
		private ErrorCode code_;
	}
}
