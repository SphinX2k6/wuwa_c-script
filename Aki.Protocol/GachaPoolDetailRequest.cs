using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000696 RID: 1686
	[NetMessage(EMessageId.GachaPoolDetailRequest)]
	public sealed class GachaPoolDetailRequest : IMessage<GachaPoolDetailRequest>, IMessage, IEquatable<GachaPoolDetailRequest>, IDeepCloneable<GachaPoolDetailRequest>, IBufferMessage
	{
		// Token: 0x06009A63 RID: 39523 RVA: 0x00174712 File Offset: 0x00172912
		[NullableContext(1)]
		public static GachaPoolDetailRequest Create()
		{
			return new GachaPoolDetailRequest();
		}

		// Token: 0x17001EDD RID: 7901
		// (get) Token: 0x06009A64 RID: 39524 RVA: 0x00174719 File Offset: 0x00172919
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001EDE RID: 7902
		// (get) Token: 0x06009A65 RID: 39525 RVA: 0x0017471C File Offset: 0x0017291C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaPoolDetailRequest.Descriptor;
			}
		}

		// Token: 0x06009A66 RID: 39526 RVA: 0x00174723 File Offset: 0x00172923
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaPoolDetailRequest()
		{
		}

		// Token: 0x06009A67 RID: 39527 RVA: 0x0017472B File Offset: 0x0017292B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaPoolDetailRequest(GachaPoolDetailRequest other) : this()
		{
			this.poolId_ = other.poolId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009A68 RID: 39528 RVA: 0x00174750 File Offset: 0x00172950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaPoolDetailRequest Clone()
		{
			return new GachaPoolDetailRequest(this);
		}

		// Token: 0x17001EDF RID: 7903
		// (get) Token: 0x06009A69 RID: 39529 RVA: 0x00174758 File Offset: 0x00172958
		// (set) Token: 0x06009A6A RID: 39530 RVA: 0x00174760 File Offset: 0x00172960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PoolId
		{
			get
			{
				return this.poolId_;
			}
			set
			{
				this.poolId_ = value;
			}
		}

		// Token: 0x06009A6B RID: 39531 RVA: 0x00174769 File Offset: 0x00172969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaPoolDetailRequest);
		}

		// Token: 0x06009A6C RID: 39532 RVA: 0x00174777 File Offset: 0x00172977
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaPoolDetailRequest other)
		{
			return other != null && (other == this || (this.PoolId == other.PoolId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009A6D RID: 39533 RVA: 0x001747A8 File Offset: 0x001729A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PoolId != 0)
			{
				num ^= this.PoolId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009A6E RID: 39534 RVA: 0x001747E7 File Offset: 0x001729E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009A6F RID: 39535 RVA: 0x001747F4 File Offset: 0x001729F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009A70 RID: 39536 RVA: 0x001747FD File Offset: 0x001729FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PoolId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.PoolId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009A71 RID: 39537 RVA: 0x00174830 File Offset: 0x00172A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PoolId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PoolId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009A72 RID: 39538 RVA: 0x0017486E File Offset: 0x00172A6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaPoolDetailRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PoolId != 0)
			{
				this.PoolId = other.PoolId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009A73 RID: 39539 RVA: 0x0017489F File Offset: 0x00172A9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009A74 RID: 39540 RVA: 0x001748A8 File Offset: 0x00172AA8
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PoolId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400490A RID: 18698
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400490B RID: 18699
		public const int PoolIdFieldNumber = 5;

		// Token: 0x0400490C RID: 18700
		private int poolId_;
	}
}
