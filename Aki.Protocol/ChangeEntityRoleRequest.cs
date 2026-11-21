using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200024F RID: 591
	[NetMessage(EMessageId.ChangeEntityRoleRequest)]
	public sealed class ChangeEntityRoleRequest : IMessage<ChangeEntityRoleRequest>, IMessage, IEquatable<ChangeEntityRoleRequest>, IDeepCloneable<ChangeEntityRoleRequest>, IBufferMessage
	{
		// Token: 0x06003F4C RID: 16204 RVA: 0x0009C439 File Offset: 0x0009A639
		[NullableContext(1)]
		public static ChangeEntityRoleRequest Create()
		{
			return new ChangeEntityRoleRequest();
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06003F4D RID: 16205 RVA: 0x0009C440 File Offset: 0x0009A640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06003F4E RID: 16206 RVA: 0x0009C443 File Offset: 0x0009A643
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeEntityRoleRequest.Descriptor;
			}
		}

		// Token: 0x06003F4F RID: 16207 RVA: 0x0009C44A File Offset: 0x0009A64A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeEntityRoleRequest()
		{
		}

		// Token: 0x06003F50 RID: 16208 RVA: 0x0009C452 File Offset: 0x0009A652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeEntityRoleRequest(ChangeEntityRoleRequest other) : this()
		{
			this.id_ = other.id_;
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003F51 RID: 16209 RVA: 0x0009C483 File Offset: 0x0009A683
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeEntityRoleRequest Clone()
		{
			return new ChangeEntityRoleRequest(this);
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06003F52 RID: 16210 RVA: 0x0009C48B File Offset: 0x0009A68B
		// (set) Token: 0x06003F53 RID: 16211 RVA: 0x0009C493 File Offset: 0x0009A693
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

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x06003F54 RID: 16212 RVA: 0x0009C49C File Offset: 0x0009A69C
		// (set) Token: 0x06003F55 RID: 16213 RVA: 0x0009C4A4 File Offset: 0x0009A6A4
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

		// Token: 0x06003F56 RID: 16214 RVA: 0x0009C4AD File Offset: 0x0009A6AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeEntityRoleRequest);
		}

		// Token: 0x06003F57 RID: 16215 RVA: 0x0009C4BB File Offset: 0x0009A6BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeEntityRoleRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003F58 RID: 16216 RVA: 0x0009C4FC File Offset: 0x0009A6FC
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

		// Token: 0x06003F59 RID: 16217 RVA: 0x0009C554 File Offset: 0x0009A754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003F5A RID: 16218 RVA: 0x0009C561 File Offset: 0x0009A761
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003F5B RID: 16219 RVA: 0x0009C56C File Offset: 0x0009A76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.Id);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003F5C RID: 16220 RVA: 0x0009C5C8 File Offset: 0x0009A7C8
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

		// Token: 0x06003F5D RID: 16221 RVA: 0x0009C620 File Offset: 0x0009A820
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

		// Token: 0x06003F5E RID: 16222 RVA: 0x0009C670 File Offset: 0x0009A870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003F5F RID: 16223 RVA: 0x0009C67C File Offset: 0x0009A87C
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
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PlayerId = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002D70 RID: 11632
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D71 RID: 11633
		public const int IdFieldNumber = 3;

		// Token: 0x04002D72 RID: 11634
		private long id_;

		// Token: 0x04002D73 RID: 11635
		public const int PlayerIdFieldNumber = 5;

		// Token: 0x04002D74 RID: 11636
		private int playerId_;
	}
}
