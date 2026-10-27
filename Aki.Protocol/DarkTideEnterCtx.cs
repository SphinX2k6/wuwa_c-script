using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003A4 RID: 932
	public sealed class DarkTideEnterCtx : IMessage<DarkTideEnterCtx>, IMessage, IEquatable<DarkTideEnterCtx>, IDeepCloneable<DarkTideEnterCtx>, IBufferMessage
	{
		// Token: 0x06005BBD RID: 23485 RVA: 0x000DF171 File Offset: 0x000DD371
		[NullableContext(1)]
		public static DarkTideEnterCtx Create()
		{
			return new DarkTideEnterCtx();
		}

		// Token: 0x17001100 RID: 4352
		// (get) Token: 0x06005BBE RID: 23486 RVA: 0x000DF178 File Offset: 0x000DD378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001101 RID: 4353
		// (get) Token: 0x06005BBF RID: 23487 RVA: 0x000DF17B File Offset: 0x000DD37B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DarkTideEnterCtx.Descriptor;
			}
		}

		// Token: 0x06005BC0 RID: 23488 RVA: 0x000DF182 File Offset: 0x000DD382
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideEnterCtx()
		{
		}

		// Token: 0x06005BC1 RID: 23489 RVA: 0x000DF18A File Offset: 0x000DD38A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideEnterCtx(DarkTideEnterCtx other) : this()
		{
			this.instanceId_ = other.instanceId_;
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005BC2 RID: 23490 RVA: 0x000DF1BB File Offset: 0x000DD3BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideEnterCtx Clone()
		{
			return new DarkTideEnterCtx(this);
		}

		// Token: 0x17001102 RID: 4354
		// (get) Token: 0x06005BC3 RID: 23491 RVA: 0x000DF1C3 File Offset: 0x000DD3C3
		// (set) Token: 0x06005BC4 RID: 23492 RVA: 0x000DF1CB File Offset: 0x000DD3CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstanceId
		{
			get
			{
				return this.instanceId_;
			}
			set
			{
				this.instanceId_ = value;
			}
		}

		// Token: 0x17001103 RID: 4355
		// (get) Token: 0x06005BC5 RID: 23493 RVA: 0x000DF1D4 File Offset: 0x000DD3D4
		// (set) Token: 0x06005BC6 RID: 23494 RVA: 0x000DF1DC File Offset: 0x000DD3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x06005BC7 RID: 23495 RVA: 0x000DF1E5 File Offset: 0x000DD3E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DarkTideEnterCtx);
		}

		// Token: 0x06005BC8 RID: 23496 RVA: 0x000DF1F3 File Offset: 0x000DD3F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DarkTideEnterCtx other)
		{
			return other != null && (other == this || (this.InstanceId == other.InstanceId && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005BC9 RID: 23497 RVA: 0x000DF234 File Offset: 0x000DD434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstanceId != 0)
			{
				num ^= this.InstanceId.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005BCA RID: 23498 RVA: 0x000DF28C File Offset: 0x000DD48C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005BCB RID: 23499 RVA: 0x000DF299 File Offset: 0x000DD499
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005BCC RID: 23500 RVA: 0x000DF2A4 File Offset: 0x000DD4A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstanceId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InstanceId);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005BCD RID: 23501 RVA: 0x000DF2FC File Offset: 0x000DD4FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstanceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstanceId);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005BCE RID: 23502 RVA: 0x000DF354 File Offset: 0x000DD554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DarkTideEnterCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstanceId != 0)
			{
				this.InstanceId = other.InstanceId;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005BCF RID: 23503 RVA: 0x000DF3A4 File Offset: 0x000DD5A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005BD0 RID: 23504 RVA: 0x000DF3B0 File Offset: 0x000DD5B0
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RoleId = input.ReadInt32();
					}
				}
				else
				{
					this.InstanceId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003618 RID: 13848
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003619 RID: 13849
		public const int InstanceIdFieldNumber = 1;

		// Token: 0x0400361A RID: 13850
		private int instanceId_;

		// Token: 0x0400361B RID: 13851
		public const int RoleIdFieldNumber = 2;

		// Token: 0x0400361C RID: 13852
		private int roleId_;
	}
}
