using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004C8 RID: 1224
	[NetMessage(EMessageId.EntityStaticHookMoveResponse)]
	public sealed class EntityStaticHookMoveResponse : IMessage<EntityStaticHookMoveResponse>, IMessage, IEquatable<EntityStaticHookMoveResponse>, IDeepCloneable<EntityStaticHookMoveResponse>, IBufferMessage
	{
		// Token: 0x06007466 RID: 29798 RVA: 0x0011D415 File Offset: 0x0011B615
		[NullableContext(1)]
		public static EntityStaticHookMoveResponse Create()
		{
			return new EntityStaticHookMoveResponse();
		}

		// Token: 0x1700168E RID: 5774
		// (get) Token: 0x06007467 RID: 29799 RVA: 0x0011D41C File Offset: 0x0011B61C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700168F RID: 5775
		// (get) Token: 0x06007468 RID: 29800 RVA: 0x0011D41F File Offset: 0x0011B61F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityStaticHookMoveResponse.Descriptor;
			}
		}

		// Token: 0x06007469 RID: 29801 RVA: 0x0011D426 File Offset: 0x0011B626
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStaticHookMoveResponse()
		{
		}

		// Token: 0x0600746A RID: 29802 RVA: 0x0011D42E File Offset: 0x0011B62E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStaticHookMoveResponse(EntityStaticHookMoveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600746B RID: 29803 RVA: 0x0011D453 File Offset: 0x0011B653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStaticHookMoveResponse Clone()
		{
			return new EntityStaticHookMoveResponse(this);
		}

		// Token: 0x17001690 RID: 5776
		// (get) Token: 0x0600746C RID: 29804 RVA: 0x0011D45B File Offset: 0x0011B65B
		// (set) Token: 0x0600746D RID: 29805 RVA: 0x0011D463 File Offset: 0x0011B663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x0600746E RID: 29806 RVA: 0x0011D46C File Offset: 0x0011B66C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityStaticHookMoveResponse);
		}

		// Token: 0x0600746F RID: 29807 RVA: 0x0011D47A File Offset: 0x0011B67A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityStaticHookMoveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007470 RID: 29808 RVA: 0x0011D4A8 File Offset: 0x0011B6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007471 RID: 29809 RVA: 0x0011D4ED File Offset: 0x0011B6ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007472 RID: 29810 RVA: 0x0011D4FA File Offset: 0x0011B6FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007473 RID: 29811 RVA: 0x0011D503 File Offset: 0x0011B703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007474 RID: 29812 RVA: 0x0011D538 File Offset: 0x0011B738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007475 RID: 29813 RVA: 0x0011D576 File Offset: 0x0011B776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityStaticHookMoveResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007476 RID: 29814 RVA: 0x0011D5A7 File Offset: 0x0011B7A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007477 RID: 29815 RVA: 0x0011D5B0 File Offset: 0x0011B7B0
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003D6B RID: 15723
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D6C RID: 15724
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04003D6D RID: 15725
		private ErrorCode errorCode_;
	}
}
