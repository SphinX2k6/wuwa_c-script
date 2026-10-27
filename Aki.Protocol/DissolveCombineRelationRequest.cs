using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003E2 RID: 994
	[NetMessage(EMessageId.DissolveCombineRelationRequest)]
	public sealed class DissolveCombineRelationRequest : IMessage<DissolveCombineRelationRequest>, IMessage, IEquatable<DissolveCombineRelationRequest>, IDeepCloneable<DissolveCombineRelationRequest>, IBufferMessage
	{
		// Token: 0x060060A1 RID: 24737 RVA: 0x000E9936 File Offset: 0x000E7B36
		[NullableContext(1)]
		public static DissolveCombineRelationRequest Create()
		{
			return new DissolveCombineRelationRequest();
		}

		// Token: 0x17001201 RID: 4609
		// (get) Token: 0x060060A2 RID: 24738 RVA: 0x000E993D File Offset: 0x000E7B3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001202 RID: 4610
		// (get) Token: 0x060060A3 RID: 24739 RVA: 0x000E9940 File Offset: 0x000E7B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DissolveCombineRelationRequest.Descriptor;
			}
		}

		// Token: 0x060060A4 RID: 24740 RVA: 0x000E9947 File Offset: 0x000E7B47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DissolveCombineRelationRequest()
		{
		}

		// Token: 0x060060A5 RID: 24741 RVA: 0x000E994F File Offset: 0x000E7B4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DissolveCombineRelationRequest(DissolveCombineRelationRequest other) : this()
		{
			this.entityA_ = other.entityA_;
			this.entityB_ = other.entityB_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060060A6 RID: 24742 RVA: 0x000E9980 File Offset: 0x000E7B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DissolveCombineRelationRequest Clone()
		{
			return new DissolveCombineRelationRequest(this);
		}

		// Token: 0x17001203 RID: 4611
		// (get) Token: 0x060060A7 RID: 24743 RVA: 0x000E9988 File Offset: 0x000E7B88
		// (set) Token: 0x060060A8 RID: 24744 RVA: 0x000E9990 File Offset: 0x000E7B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityA
		{
			get
			{
				return this.entityA_;
			}
			set
			{
				this.entityA_ = value;
			}
		}

		// Token: 0x17001204 RID: 4612
		// (get) Token: 0x060060A9 RID: 24745 RVA: 0x000E9999 File Offset: 0x000E7B99
		// (set) Token: 0x060060AA RID: 24746 RVA: 0x000E99A1 File Offset: 0x000E7BA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityB
		{
			get
			{
				return this.entityB_;
			}
			set
			{
				this.entityB_ = value;
			}
		}

		// Token: 0x060060AB RID: 24747 RVA: 0x000E99AA File Offset: 0x000E7BAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DissolveCombineRelationRequest);
		}

		// Token: 0x060060AC RID: 24748 RVA: 0x000E99B8 File Offset: 0x000E7BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DissolveCombineRelationRequest other)
		{
			return other != null && (other == this || (this.EntityA == other.EntityA && this.EntityB == other.EntityB && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060060AD RID: 24749 RVA: 0x000E99F8 File Offset: 0x000E7BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityA != 0L)
			{
				num ^= this.EntityA.GetHashCode();
			}
			if (this.EntityB != 0L)
			{
				num ^= this.EntityB.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060060AE RID: 24750 RVA: 0x000E9A50 File Offset: 0x000E7C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060060AF RID: 24751 RVA: 0x000E9A5D File Offset: 0x000E7C5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060060B0 RID: 24752 RVA: 0x000E9A68 File Offset: 0x000E7C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityB != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EntityB);
			}
			if (this.EntityA != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.EntityA);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060060B1 RID: 24753 RVA: 0x000E9AC4 File Offset: 0x000E7CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityA != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityA);
			}
			if (this.EntityB != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityB);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060060B2 RID: 24754 RVA: 0x000E9B1C File Offset: 0x000E7D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DissolveCombineRelationRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityA != 0L)
			{
				this.EntityA = other.EntityA;
			}
			if (other.EntityB != 0L)
			{
				this.EntityB = other.EntityB;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060060B3 RID: 24755 RVA: 0x000E9B6C File Offset: 0x000E7D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060060B4 RID: 24756 RVA: 0x000E9B78 File Offset: 0x000E7D78
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
				if (num != 24U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityA = input.ReadInt64();
					}
				}
				else
				{
					this.EntityB = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400376D RID: 14189
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400376E RID: 14190
		public const int EntityAFieldNumber = 10;

		// Token: 0x0400376F RID: 14191
		private long entityA_;

		// Token: 0x04003770 RID: 14192
		public const int EntityBFieldNumber = 3;

		// Token: 0x04003771 RID: 14193
		private long entityB_;
	}
}
