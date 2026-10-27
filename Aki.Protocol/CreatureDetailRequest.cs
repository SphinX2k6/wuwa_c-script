using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000318 RID: 792
	[NetMessage(EMessageId.CreatureDetailRequest)]
	public sealed class CreatureDetailRequest : IMessage<CreatureDetailRequest>, IMessage, IEquatable<CreatureDetailRequest>, IDeepCloneable<CreatureDetailRequest>, IBufferMessage
	{
		// Token: 0x06004FD9 RID: 20441 RVA: 0x000C2C58 File Offset: 0x000C0E58
		[NullableContext(1)]
		public static CreatureDetailRequest Create()
		{
			return new CreatureDetailRequest();
		}

		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x06004FDA RID: 20442 RVA: 0x000C2C5F File Offset: 0x000C0E5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x06004FDB RID: 20443 RVA: 0x000C2C62 File Offset: 0x000C0E62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreatureDetailRequest.Descriptor;
			}
		}

		// Token: 0x06004FDC RID: 20444 RVA: 0x000C2C69 File Offset: 0x000C0E69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreatureDetailRequest()
		{
		}

		// Token: 0x06004FDD RID: 20445 RVA: 0x000C2C71 File Offset: 0x000C0E71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreatureDetailRequest(CreatureDetailRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004FDE RID: 20446 RVA: 0x000C2C96 File Offset: 0x000C0E96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreatureDetailRequest Clone()
		{
			return new CreatureDetailRequest(this);
		}

		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x06004FDF RID: 20447 RVA: 0x000C2C9E File Offset: 0x000C0E9E
		// (set) Token: 0x06004FE0 RID: 20448 RVA: 0x000C2CA6 File Offset: 0x000C0EA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x06004FE1 RID: 20449 RVA: 0x000C2CAF File Offset: 0x000C0EAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreatureDetailRequest);
		}

		// Token: 0x06004FE2 RID: 20450 RVA: 0x000C2CBD File Offset: 0x000C0EBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CreatureDetailRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004FE3 RID: 20451 RVA: 0x000C2CEC File Offset: 0x000C0EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004FE4 RID: 20452 RVA: 0x000C2D2B File Offset: 0x000C0F2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004FE5 RID: 20453 RVA: 0x000C2D38 File Offset: 0x000C0F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004FE6 RID: 20454 RVA: 0x000C2D41 File Offset: 0x000C0F41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004FE7 RID: 20455 RVA: 0x000C2D74 File Offset: 0x000C0F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004FE8 RID: 20456 RVA: 0x000C2DB2 File Offset: 0x000C0FB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CreatureDetailRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004FE9 RID: 20457 RVA: 0x000C2DE3 File Offset: 0x000C0FE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004FEA RID: 20458 RVA: 0x000C2DEC File Offset: 0x000C0FEC
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
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003231 RID: 12849
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003232 RID: 12850
		public const int IdFieldNumber = 4;

		// Token: 0x04003233 RID: 12851
		private long id_;
	}
}
