using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BF9 RID: 3065
	[NetMessage(EMessageId.PayShopUpdateRequest)]
	public sealed class PayShopUpdateRequest : IMessage<PayShopUpdateRequest>, IMessage, IEquatable<PayShopUpdateRequest>, IDeepCloneable<PayShopUpdateRequest>, IBufferMessage
	{
		// Token: 0x06010A2A RID: 68138 RVA: 0x0026F785 File Offset: 0x0026D985
		[NullableContext(1)]
		public static PayShopUpdateRequest Create()
		{
			return new PayShopUpdateRequest();
		}

		// Token: 0x170036D2 RID: 14034
		// (get) Token: 0x06010A2B RID: 68139 RVA: 0x0026F78C File Offset: 0x0026D98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170036D3 RID: 14035
		// (get) Token: 0x06010A2C RID: 68140 RVA: 0x0026F78F File Offset: 0x0026D98F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayShopUpdateRequest.Descriptor;
			}
		}

		// Token: 0x06010A2D RID: 68141 RVA: 0x0026F796 File Offset: 0x0026D996
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopUpdateRequest()
		{
		}

		// Token: 0x06010A2E RID: 68142 RVA: 0x0026F79E File Offset: 0x0026D99E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopUpdateRequest(PayShopUpdateRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010A2F RID: 68143 RVA: 0x0026F7C3 File Offset: 0x0026D9C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopUpdateRequest Clone()
		{
			return new PayShopUpdateRequest(this);
		}

		// Token: 0x170036D4 RID: 14036
		// (get) Token: 0x06010A30 RID: 68144 RVA: 0x0026F7CB File Offset: 0x0026D9CB
		// (set) Token: 0x06010A31 RID: 68145 RVA: 0x0026F7D3 File Offset: 0x0026D9D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
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

		// Token: 0x06010A32 RID: 68146 RVA: 0x0026F7DC File Offset: 0x0026D9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayShopUpdateRequest);
		}

		// Token: 0x06010A33 RID: 68147 RVA: 0x0026F7EA File Offset: 0x0026D9EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayShopUpdateRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010A34 RID: 68148 RVA: 0x0026F818 File Offset: 0x0026DA18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010A35 RID: 68149 RVA: 0x0026F857 File Offset: 0x0026DA57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010A36 RID: 68150 RVA: 0x0026F864 File Offset: 0x0026DA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010A37 RID: 68151 RVA: 0x0026F86D File Offset: 0x0026DA6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010A38 RID: 68152 RVA: 0x0026F8A0 File Offset: 0x0026DAA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010A39 RID: 68153 RVA: 0x0026F8DE File Offset: 0x0026DADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PayShopUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010A3A RID: 68154 RVA: 0x0026F90F File Offset: 0x0026DB0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010A3B RID: 68155 RVA: 0x0026F918 File Offset: 0x0026DB18
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040069C1 RID: 27073
		private UnknownFieldSet _unknownFields;

		// Token: 0x040069C2 RID: 27074
		public const int IdFieldNumber = 13;

		// Token: 0x040069C3 RID: 27075
		private int id_;
	}
}
