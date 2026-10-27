using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200024A RID: 586
	[NetMessage(EMessageId.ChangeEntityRoleRequest)]
	public sealed class ChangeEntityRoleRequest : IMessage<ChangeEntityRoleRequest>, IMessage, IEquatable<ChangeEntityRoleRequest>, IDeepCloneable<ChangeEntityRoleRequest>, IBufferMessage
	{
		// Token: 0x06003EA7 RID: 16039 RVA: 0x0009A819 File Offset: 0x00098A19
		[NullableContext(1)]
		public static ChangeEntityRoleRequest Create()
		{
			return new ChangeEntityRoleRequest();
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x06003EA8 RID: 16040 RVA: 0x0009A820 File Offset: 0x00098A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x06003EA9 RID: 16041 RVA: 0x0009A823 File Offset: 0x00098A23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeEntityRoleRequest.Descriptor;
			}
		}

		// Token: 0x06003EAA RID: 16042 RVA: 0x0009A82A File Offset: 0x00098A2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeEntityRoleRequest()
		{
		}

		// Token: 0x06003EAB RID: 16043 RVA: 0x0009A832 File Offset: 0x00098A32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeEntityRoleRequest(ChangeEntityRoleRequest other) : this()
		{
			this.id_ = other.id_;
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003EAC RID: 16044 RVA: 0x0009A863 File Offset: 0x00098A63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeEntityRoleRequest Clone()
		{
			return new ChangeEntityRoleRequest(this);
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06003EAD RID: 16045 RVA: 0x0009A86B File Offset: 0x00098A6B
		// (set) Token: 0x06003EAE RID: 16046 RVA: 0x0009A873 File Offset: 0x00098A73
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

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06003EAF RID: 16047 RVA: 0x0009A87C File Offset: 0x00098A7C
		// (set) Token: 0x06003EB0 RID: 16048 RVA: 0x0009A884 File Offset: 0x00098A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x06003EB1 RID: 16049 RVA: 0x0009A88D File Offset: 0x00098A8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeEntityRoleRequest);
		}

		// Token: 0x06003EB2 RID: 16050 RVA: 0x0009A89B File Offset: 0x00098A9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeEntityRoleRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003EB3 RID: 16051 RVA: 0x0009A8DC File Offset: 0x00098ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003EB4 RID: 16052 RVA: 0x0009A934 File Offset: 0x00098B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003EB5 RID: 16053 RVA: 0x0009A941 File Offset: 0x00098B41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003EB6 RID: 16054 RVA: 0x0009A94C File Offset: 0x00098B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003EB7 RID: 16055 RVA: 0x0009A9A4 File Offset: 0x00098BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003EB8 RID: 16056 RVA: 0x0009A9FC File Offset: 0x00098BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeEntityRoleRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003EB9 RID: 16057 RVA: 0x0009AA4C File Offset: 0x00098C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003EBA RID: 16058 RVA: 0x0009AA58 File Offset: 0x00098C58
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
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt64();
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002CEE RID: 11502
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CEF RID: 11503
		public const int IdFieldNumber = 14;

		// Token: 0x04002CF0 RID: 11504
		private long id_;

		// Token: 0x04002CF1 RID: 11505
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04002CF2 RID: 11506
		private int playerId_;
	}
}
