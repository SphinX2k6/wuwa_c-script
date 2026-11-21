using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000304 RID: 772
	[NetMessage(EMessageId.CoopRoleRewardRequest)]
	public sealed class CoopRoleRewardRequest : IMessage<CoopRoleRewardRequest>, IMessage, IEquatable<CoopRoleRewardRequest>, IDeepCloneable<CoopRoleRewardRequest>, IBufferMessage
	{
		// Token: 0x06004E3C RID: 20028 RVA: 0x000BE7E5 File Offset: 0x000BC9E5
		[NullableContext(1)]
		public static CoopRoleRewardRequest Create()
		{
			return new CoopRoleRewardRequest();
		}

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x06004E3D RID: 20029 RVA: 0x000BE7EC File Offset: 0x000BC9EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x06004E3E RID: 20030 RVA: 0x000BE7EF File Offset: 0x000BC9EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CoopRoleRewardRequest.Descriptor;
			}
		}

		// Token: 0x06004E3F RID: 20031 RVA: 0x000BE7F6 File Offset: 0x000BC9F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopRoleRewardRequest()
		{
		}

		// Token: 0x06004E40 RID: 20032 RVA: 0x000BE7FE File Offset: 0x000BC9FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopRoleRewardRequest(CoopRoleRewardRequest other) : this()
		{
			this.coopId_ = other.coopId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004E41 RID: 20033 RVA: 0x000BE823 File Offset: 0x000BCA23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopRoleRewardRequest Clone()
		{
			return new CoopRoleRewardRequest(this);
		}

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x06004E42 RID: 20034 RVA: 0x000BE82B File Offset: 0x000BCA2B
		// (set) Token: 0x06004E43 RID: 20035 RVA: 0x000BE833 File Offset: 0x000BCA33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CoopId
		{
			get
			{
				return this.coopId_;
			}
			set
			{
				this.coopId_ = value;
			}
		}

		// Token: 0x06004E44 RID: 20036 RVA: 0x000BE83C File Offset: 0x000BCA3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CoopRoleRewardRequest);
		}

		// Token: 0x06004E45 RID: 20037 RVA: 0x000BE84A File Offset: 0x000BCA4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CoopRoleRewardRequest other)
		{
			return other != null && (other == this || (this.CoopId == other.CoopId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004E46 RID: 20038 RVA: 0x000BE878 File Offset: 0x000BCA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CoopId != 0)
			{
				num ^= this.CoopId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004E47 RID: 20039 RVA: 0x000BE8B7 File Offset: 0x000BCAB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004E48 RID: 20040 RVA: 0x000BE8C4 File Offset: 0x000BCAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004E49 RID: 20041 RVA: 0x000BE8CD File Offset: 0x000BCACD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CoopId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CoopId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004E4A RID: 20042 RVA: 0x000BE900 File Offset: 0x000BCB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CoopId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CoopId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004E4B RID: 20043 RVA: 0x000BE93E File Offset: 0x000BCB3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CoopRoleRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CoopId != 0)
			{
				this.CoopId = other.CoopId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004E4C RID: 20044 RVA: 0x000BE96F File Offset: 0x000BCB6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004E4D RID: 20045 RVA: 0x000BE978 File Offset: 0x000BCB78
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CoopId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040031E2 RID: 12770
		private UnknownFieldSet _unknownFields;

		// Token: 0x040031E3 RID: 12771
		public const int CoopIdFieldNumber = 2;

		// Token: 0x040031E4 RID: 12772
		private int coopId_;
	}
}
