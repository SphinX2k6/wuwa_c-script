using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003D3 RID: 979
	[NetMessage(EMessageId.DollGarbInsertCoinRequest)]
	public sealed class DollGarbInsertCoinRequest : IMessage<DollGarbInsertCoinRequest>, IMessage, IEquatable<DollGarbInsertCoinRequest>, IDeepCloneable<DollGarbInsertCoinRequest>, IBufferMessage
	{
		// Token: 0x06005FAB RID: 24491 RVA: 0x000E7ADC File Offset: 0x000E5CDC
		[NullableContext(1)]
		public static DollGarbInsertCoinRequest Create()
		{
			return new DollGarbInsertCoinRequest();
		}

		// Token: 0x170011CA RID: 4554
		// (get) Token: 0x06005FAC RID: 24492 RVA: 0x000E7AE3 File Offset: 0x000E5CE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011CB RID: 4555
		// (get) Token: 0x06005FAD RID: 24493 RVA: 0x000E7AE6 File Offset: 0x000E5CE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollGarbInsertCoinRequest.Descriptor;
			}
		}

		// Token: 0x06005FAE RID: 24494 RVA: 0x000E7AED File Offset: 0x000E5CED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGarbInsertCoinRequest()
		{
		}

		// Token: 0x06005FAF RID: 24495 RVA: 0x000E7AF5 File Offset: 0x000E5CF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGarbInsertCoinRequest(DollGarbInsertCoinRequest other) : this()
		{
			this.entityIncId_ = other.entityIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005FB0 RID: 24496 RVA: 0x000E7B1A File Offset: 0x000E5D1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGarbInsertCoinRequest Clone()
		{
			return new DollGarbInsertCoinRequest(this);
		}

		// Token: 0x170011CC RID: 4556
		// (get) Token: 0x06005FB1 RID: 24497 RVA: 0x000E7B22 File Offset: 0x000E5D22
		// (set) Token: 0x06005FB2 RID: 24498 RVA: 0x000E7B2A File Offset: 0x000E5D2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityIncId
		{
			get
			{
				return this.entityIncId_;
			}
			set
			{
				this.entityIncId_ = value;
			}
		}

		// Token: 0x06005FB3 RID: 24499 RVA: 0x000E7B33 File Offset: 0x000E5D33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollGarbInsertCoinRequest);
		}

		// Token: 0x06005FB4 RID: 24500 RVA: 0x000E7B41 File Offset: 0x000E5D41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollGarbInsertCoinRequest other)
		{
			return other != null && (other == this || (this.EntityIncId == other.EntityIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005FB5 RID: 24501 RVA: 0x000E7B70 File Offset: 0x000E5D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityIncId != 0L)
			{
				num ^= this.EntityIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005FB6 RID: 24502 RVA: 0x000E7BAF File Offset: 0x000E5DAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005FB7 RID: 24503 RVA: 0x000E7BBC File Offset: 0x000E5DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005FB8 RID: 24504 RVA: 0x000E7BC5 File Offset: 0x000E5DC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityIncId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.EntityIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005FB9 RID: 24505 RVA: 0x000E7BF8 File Offset: 0x000E5DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005FBA RID: 24506 RVA: 0x000E7C36 File Offset: 0x000E5E36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DollGarbInsertCoinRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityIncId != 0L)
			{
				this.EntityIncId = other.EntityIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005FBB RID: 24507 RVA: 0x000E7C67 File Offset: 0x000E5E67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005FBC RID: 24508 RVA: 0x000E7C70 File Offset: 0x000E5E70
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityIncId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003781 RID: 14209
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003782 RID: 14210
		public const int EntityIncIdFieldNumber = 12;

		// Token: 0x04003783 RID: 14211
		private long entityIncId_;
	}
}
