using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F07 RID: 3847
	[NetMessage(EMessageId.RenjuExitMatchedActionRequest)]
	public sealed class RenjuExitMatchedActionRequest : IMessage<RenjuExitMatchedActionRequest>, IMessage, IEquatable<RenjuExitMatchedActionRequest>, IDeepCloneable<RenjuExitMatchedActionRequest>, IBufferMessage
	{
		// Token: 0x060149FB RID: 84475 RVA: 0x002FEF6A File Offset: 0x002FD16A
		[NullableContext(1)]
		public static RenjuExitMatchedActionRequest Create()
		{
			return new RenjuExitMatchedActionRequest();
		}

		// Token: 0x17004493 RID: 17555
		// (get) Token: 0x060149FC RID: 84476 RVA: 0x002FEF71 File Offset: 0x002FD171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004494 RID: 17556
		// (get) Token: 0x060149FD RID: 84477 RVA: 0x002FEF74 File Offset: 0x002FD174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RenjuExitMatchedActionRequest.Descriptor;
			}
		}

		// Token: 0x060149FE RID: 84478 RVA: 0x002FEF7B File Offset: 0x002FD17B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenjuExitMatchedActionRequest()
		{
		}

		// Token: 0x060149FF RID: 84479 RVA: 0x002FEF83 File Offset: 0x002FD183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenjuExitMatchedActionRequest(RenjuExitMatchedActionRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014A00 RID: 84480 RVA: 0x002FEFA8 File Offset: 0x002FD1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenjuExitMatchedActionRequest Clone()
		{
			return new RenjuExitMatchedActionRequest(this);
		}

		// Token: 0x17004495 RID: 17557
		// (get) Token: 0x06014A01 RID: 84481 RVA: 0x002FEFB0 File Offset: 0x002FD1B0
		// (set) Token: 0x06014A02 RID: 84482 RVA: 0x002FEFB8 File Offset: 0x002FD1B8
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

		// Token: 0x06014A03 RID: 84483 RVA: 0x002FEFC1 File Offset: 0x002FD1C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RenjuExitMatchedActionRequest);
		}

		// Token: 0x06014A04 RID: 84484 RVA: 0x002FEFCF File Offset: 0x002FD1CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RenjuExitMatchedActionRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014A05 RID: 84485 RVA: 0x002FF000 File Offset: 0x002FD200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014A06 RID: 84486 RVA: 0x002FF03F File Offset: 0x002FD23F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014A07 RID: 84487 RVA: 0x002FF04C File Offset: 0x002FD24C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014A08 RID: 84488 RVA: 0x002FF055 File Offset: 0x002FD255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014A09 RID: 84489 RVA: 0x002FF088 File Offset: 0x002FD288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014A0A RID: 84490 RVA: 0x002FF0C6 File Offset: 0x002FD2C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RenjuExitMatchedActionRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014A0B RID: 84491 RVA: 0x002FF0F7 File Offset: 0x002FD2F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014A0C RID: 84492 RVA: 0x002FF100 File Offset: 0x002FD300
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
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007D30 RID: 32048
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D31 RID: 32049
		public const int EntityIdFieldNumber = 14;

		// Token: 0x04007D32 RID: 32050
		private long entityId_;
	}
}
