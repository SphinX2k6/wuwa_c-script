using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001552 RID: 5458
	[NetMessage(EMessageId.VfxNpcPatrolFinishRequest)]
	public sealed class VfxNpcPatrolFinishRequest : IMessage<VfxNpcPatrolFinishRequest>, IMessage, IEquatable<VfxNpcPatrolFinishRequest>, IDeepCloneable<VfxNpcPatrolFinishRequest>, IBufferMessage
	{
		// Token: 0x0601CE9A RID: 118426 RVA: 0x0043085B File Offset: 0x0042EA5B
		[NullableContext(1)]
		public static VfxNpcPatrolFinishRequest Create()
		{
			return new VfxNpcPatrolFinishRequest();
		}

		// Token: 0x170061D7 RID: 25047
		// (get) Token: 0x0601CE9B RID: 118427 RVA: 0x00430862 File Offset: 0x0042EA62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170061D8 RID: 25048
		// (get) Token: 0x0601CE9C RID: 118428 RVA: 0x00430865 File Offset: 0x0042EA65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VfxNpcPatrolFinishRequest.Descriptor;
			}
		}

		// Token: 0x0601CE9D RID: 118429 RVA: 0x0043086C File Offset: 0x0042EA6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VfxNpcPatrolFinishRequest()
		{
		}

		// Token: 0x0601CE9E RID: 118430 RVA: 0x00430874 File Offset: 0x0042EA74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VfxNpcPatrolFinishRequest(VfxNpcPatrolFinishRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CE9F RID: 118431 RVA: 0x00430899 File Offset: 0x0042EA99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VfxNpcPatrolFinishRequest Clone()
		{
			return new VfxNpcPatrolFinishRequest(this);
		}

		// Token: 0x170061D9 RID: 25049
		// (get) Token: 0x0601CEA0 RID: 118432 RVA: 0x004308A1 File Offset: 0x0042EAA1
		// (set) Token: 0x0601CEA1 RID: 118433 RVA: 0x004308A9 File Offset: 0x0042EAA9
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

		// Token: 0x0601CEA2 RID: 118434 RVA: 0x004308B2 File Offset: 0x0042EAB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VfxNpcPatrolFinishRequest);
		}

		// Token: 0x0601CEA3 RID: 118435 RVA: 0x004308C0 File Offset: 0x0042EAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VfxNpcPatrolFinishRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CEA4 RID: 118436 RVA: 0x004308F0 File Offset: 0x0042EAF0
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

		// Token: 0x0601CEA5 RID: 118437 RVA: 0x0043092F File Offset: 0x0042EB2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CEA6 RID: 118438 RVA: 0x0043093C File Offset: 0x0042EB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CEA7 RID: 118439 RVA: 0x00430945 File Offset: 0x0042EB45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CEA8 RID: 118440 RVA: 0x00430978 File Offset: 0x0042EB78
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

		// Token: 0x0601CEA9 RID: 118441 RVA: 0x004309B6 File Offset: 0x0042EBB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VfxNpcPatrolFinishRequest other)
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

		// Token: 0x0601CEAA RID: 118442 RVA: 0x004309E7 File Offset: 0x0042EBE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CEAB RID: 118443 RVA: 0x004309F0 File Offset: 0x0042EBF0
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400A646 RID: 42566
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A647 RID: 42567
		public const int EntityIdFieldNumber = 11;

		// Token: 0x0400A648 RID: 42568
		private long entityId_;
	}
}
