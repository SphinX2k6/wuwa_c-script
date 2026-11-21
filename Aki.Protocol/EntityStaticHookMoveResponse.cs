using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004B1 RID: 1201
	[NetMessage(EMessageId.EntityStaticHookMoveResponse)]
	public sealed class EntityStaticHookMoveResponse : IMessage<EntityStaticHookMoveResponse>, IMessage, IEquatable<EntityStaticHookMoveResponse>, IDeepCloneable<EntityStaticHookMoveResponse>, IBufferMessage
	{
		// Token: 0x060072D6 RID: 29398 RVA: 0x0011A2FD File Offset: 0x001184FD
		[NullableContext(1)]
		public static EntityStaticHookMoveResponse Create()
		{
			return new EntityStaticHookMoveResponse();
		}

		// Token: 0x17001639 RID: 5689
		// (get) Token: 0x060072D7 RID: 29399 RVA: 0x0011A304 File Offset: 0x00118504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700163A RID: 5690
		// (get) Token: 0x060072D8 RID: 29400 RVA: 0x0011A307 File Offset: 0x00118507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityStaticHookMoveResponse.Descriptor;
			}
		}

		// Token: 0x060072D9 RID: 29401 RVA: 0x0011A30E File Offset: 0x0011850E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStaticHookMoveResponse()
		{
		}

		// Token: 0x060072DA RID: 29402 RVA: 0x0011A316 File Offset: 0x00118516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStaticHookMoveResponse(EntityStaticHookMoveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060072DB RID: 29403 RVA: 0x0011A33B File Offset: 0x0011853B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStaticHookMoveResponse Clone()
		{
			return new EntityStaticHookMoveResponse(this);
		}

		// Token: 0x1700163B RID: 5691
		// (get) Token: 0x060072DC RID: 29404 RVA: 0x0011A343 File Offset: 0x00118543
		// (set) Token: 0x060072DD RID: 29405 RVA: 0x0011A34B File Offset: 0x0011854B
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

		// Token: 0x060072DE RID: 29406 RVA: 0x0011A354 File Offset: 0x00118554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityStaticHookMoveResponse);
		}

		// Token: 0x060072DF RID: 29407 RVA: 0x0011A362 File Offset: 0x00118562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityStaticHookMoveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060072E0 RID: 29408 RVA: 0x0011A390 File Offset: 0x00118590
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

		// Token: 0x060072E1 RID: 29409 RVA: 0x0011A3D5 File Offset: 0x001185D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060072E2 RID: 29410 RVA: 0x0011A3E2 File Offset: 0x001185E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060072E3 RID: 29411 RVA: 0x0011A3EB File Offset: 0x001185EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060072E4 RID: 29412 RVA: 0x0011A420 File Offset: 0x00118620
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

		// Token: 0x060072E5 RID: 29413 RVA: 0x0011A45E File Offset: 0x0011865E
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

		// Token: 0x060072E6 RID: 29414 RVA: 0x0011A48F File Offset: 0x0011868F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060072E7 RID: 29415 RVA: 0x0011A498 File Offset: 0x00118698
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003D57 RID: 15703
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D58 RID: 15704
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04003D59 RID: 15705
		private ErrorCode errorCode_;
	}
}
