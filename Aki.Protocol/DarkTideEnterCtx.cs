using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200039F RID: 927
	public sealed class DarkTideEnterCtx : IMessage<DarkTideEnterCtx>, IMessage, IEquatable<DarkTideEnterCtx>, IDeepCloneable<DarkTideEnterCtx>, IBufferMessage
	{
		// Token: 0x06005B95 RID: 23445 RVA: 0x000DEFB2 File Offset: 0x000DD1B2
		[NullableContext(1)]
		public static DarkTideEnterCtx Create()
		{
			return new DarkTideEnterCtx();
		}

		// Token: 0x170010F4 RID: 4340
		// (get) Token: 0x06005B96 RID: 23446 RVA: 0x000DEFB9 File Offset: 0x000DD1B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010F5 RID: 4341
		// (get) Token: 0x06005B97 RID: 23447 RVA: 0x000DEFBC File Offset: 0x000DD1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DarkTideEnterCtx.Descriptor;
			}
		}

		// Token: 0x06005B98 RID: 23448 RVA: 0x000DEFC3 File Offset: 0x000DD1C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideEnterCtx()
		{
		}

		// Token: 0x06005B99 RID: 23449 RVA: 0x000DEFCB File Offset: 0x000DD1CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideEnterCtx(DarkTideEnterCtx other) : this()
		{
			this.instanceId_ = other.instanceId_;
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005B9A RID: 23450 RVA: 0x000DEFFC File Offset: 0x000DD1FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideEnterCtx Clone()
		{
			return new DarkTideEnterCtx(this);
		}

		// Token: 0x170010F6 RID: 4342
		// (get) Token: 0x06005B9B RID: 23451 RVA: 0x000DF004 File Offset: 0x000DD204
		// (set) Token: 0x06005B9C RID: 23452 RVA: 0x000DF00C File Offset: 0x000DD20C
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

		// Token: 0x170010F7 RID: 4343
		// (get) Token: 0x06005B9D RID: 23453 RVA: 0x000DF015 File Offset: 0x000DD215
		// (set) Token: 0x06005B9E RID: 23454 RVA: 0x000DF01D File Offset: 0x000DD21D
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

		// Token: 0x06005B9F RID: 23455 RVA: 0x000DF026 File Offset: 0x000DD226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DarkTideEnterCtx);
		}

		// Token: 0x06005BA0 RID: 23456 RVA: 0x000DF034 File Offset: 0x000DD234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DarkTideEnterCtx other)
		{
			return other != null && (other == this || (this.InstanceId == other.InstanceId && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005BA1 RID: 23457 RVA: 0x000DF074 File Offset: 0x000DD274
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

		// Token: 0x06005BA2 RID: 23458 RVA: 0x000DF0CC File Offset: 0x000DD2CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005BA3 RID: 23459 RVA: 0x000DF0D9 File Offset: 0x000DD2D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005BA4 RID: 23460 RVA: 0x000DF0E4 File Offset: 0x000DD2E4
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

		// Token: 0x06005BA5 RID: 23461 RVA: 0x000DF13C File Offset: 0x000DD33C
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

		// Token: 0x06005BA6 RID: 23462 RVA: 0x000DF194 File Offset: 0x000DD394
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

		// Token: 0x06005BA7 RID: 23463 RVA: 0x000DF1E4 File Offset: 0x000DD3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005BA8 RID: 23464 RVA: 0x000DF1F0 File Offset: 0x000DD3F0
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

		// Token: 0x04003663 RID: 13923
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003664 RID: 13924
		public const int InstanceIdFieldNumber = 1;

		// Token: 0x04003665 RID: 13925
		private int instanceId_;

		// Token: 0x04003666 RID: 13926
		public const int RoleIdFieldNumber = 2;

		// Token: 0x04003667 RID: 13927
		private int roleId_;
	}
}
