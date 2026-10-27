using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002BC RID: 700
	[NetMessage(EMessageId.CommonOrganResetTimeRequest)]
	public sealed class CommonOrganResetTimeRequest : IMessage<CommonOrganResetTimeRequest>, IMessage, IEquatable<CommonOrganResetTimeRequest>, IDeepCloneable<CommonOrganResetTimeRequest>, IBufferMessage
	{
		// Token: 0x06004830 RID: 18480 RVA: 0x000B1083 File Offset: 0x000AF283
		[NullableContext(1)]
		public static CommonOrganResetTimeRequest Create()
		{
			return new CommonOrganResetTimeRequest();
		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x06004831 RID: 18481 RVA: 0x000B108A File Offset: 0x000AF28A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x06004832 RID: 18482 RVA: 0x000B108D File Offset: 0x000AF28D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CommonOrganResetTimeRequest.Descriptor;
			}
		}

		// Token: 0x06004833 RID: 18483 RVA: 0x000B1094 File Offset: 0x000AF294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonOrganResetTimeRequest()
		{
		}

		// Token: 0x06004834 RID: 18484 RVA: 0x000B109C File Offset: 0x000AF29C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonOrganResetTimeRequest(CommonOrganResetTimeRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004835 RID: 18485 RVA: 0x000B10C1 File Offset: 0x000AF2C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonOrganResetTimeRequest Clone()
		{
			return new CommonOrganResetTimeRequest(this);
		}

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x06004836 RID: 18486 RVA: 0x000B10C9 File Offset: 0x000AF2C9
		// (set) Token: 0x06004837 RID: 18487 RVA: 0x000B10D1 File Offset: 0x000AF2D1
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

		// Token: 0x06004838 RID: 18488 RVA: 0x000B10DA File Offset: 0x000AF2DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CommonOrganResetTimeRequest);
		}

		// Token: 0x06004839 RID: 18489 RVA: 0x000B10E8 File Offset: 0x000AF2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CommonOrganResetTimeRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600483A RID: 18490 RVA: 0x000B1118 File Offset: 0x000AF318
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

		// Token: 0x0600483B RID: 18491 RVA: 0x000B1157 File Offset: 0x000AF357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600483C RID: 18492 RVA: 0x000B1164 File Offset: 0x000AF364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600483D RID: 18493 RVA: 0x000B116D File Offset: 0x000AF36D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600483E RID: 18494 RVA: 0x000B11A0 File Offset: 0x000AF3A0
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

		// Token: 0x0600483F RID: 18495 RVA: 0x000B11DE File Offset: 0x000AF3DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CommonOrganResetTimeRequest other)
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

		// Token: 0x06004840 RID: 18496 RVA: 0x000B120F File Offset: 0x000AF40F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004841 RID: 18497 RVA: 0x000B1218 File Offset: 0x000AF418
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002FD2 RID: 12242
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FD3 RID: 12243
		public const int EntityIdFieldNumber = 10;

		// Token: 0x04002FD4 RID: 12244
		private long entityId_;
	}
}
