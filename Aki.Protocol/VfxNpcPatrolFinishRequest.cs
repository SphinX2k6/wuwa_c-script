using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014DC RID: 5340
	[NetMessage(EMessageId.VfxNpcPatrolFinishRequest)]
	public sealed class VfxNpcPatrolFinishRequest : IMessage<VfxNpcPatrolFinishRequest>, IMessage, IEquatable<VfxNpcPatrolFinishRequest>, IDeepCloneable<VfxNpcPatrolFinishRequest>, IBufferMessage
	{
		// Token: 0x0601C3D3 RID: 115667 RVA: 0x00414D9F File Offset: 0x00412F9F
		[NullableContext(1)]
		public static VfxNpcPatrolFinishRequest Create()
		{
			return new VfxNpcPatrolFinishRequest();
		}

		// Token: 0x17005F36 RID: 24374
		// (get) Token: 0x0601C3D4 RID: 115668 RVA: 0x00414DA6 File Offset: 0x00412FA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F37 RID: 24375
		// (get) Token: 0x0601C3D5 RID: 115669 RVA: 0x00414DA9 File Offset: 0x00412FA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VfxNpcPatrolFinishRequest.Descriptor;
			}
		}

		// Token: 0x0601C3D6 RID: 115670 RVA: 0x00414DB0 File Offset: 0x00412FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VfxNpcPatrolFinishRequest()
		{
		}

		// Token: 0x0601C3D7 RID: 115671 RVA: 0x00414DB8 File Offset: 0x00412FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VfxNpcPatrolFinishRequest(VfxNpcPatrolFinishRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C3D8 RID: 115672 RVA: 0x00414DDD File Offset: 0x00412FDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VfxNpcPatrolFinishRequest Clone()
		{
			return new VfxNpcPatrolFinishRequest(this);
		}

		// Token: 0x17005F38 RID: 24376
		// (get) Token: 0x0601C3D9 RID: 115673 RVA: 0x00414DE5 File Offset: 0x00412FE5
		// (set) Token: 0x0601C3DA RID: 115674 RVA: 0x00414DED File Offset: 0x00412FED
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

		// Token: 0x0601C3DB RID: 115675 RVA: 0x00414DF6 File Offset: 0x00412FF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VfxNpcPatrolFinishRequest);
		}

		// Token: 0x0601C3DC RID: 115676 RVA: 0x00414E04 File Offset: 0x00413004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VfxNpcPatrolFinishRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C3DD RID: 115677 RVA: 0x00414E34 File Offset: 0x00413034
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

		// Token: 0x0601C3DE RID: 115678 RVA: 0x00414E73 File Offset: 0x00413073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C3DF RID: 115679 RVA: 0x00414E80 File Offset: 0x00413080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C3E0 RID: 115680 RVA: 0x00414E89 File Offset: 0x00413089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C3E1 RID: 115681 RVA: 0x00414EBC File Offset: 0x004130BC
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

		// Token: 0x0601C3E2 RID: 115682 RVA: 0x00414EFA File Offset: 0x004130FA
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

		// Token: 0x0601C3E3 RID: 115683 RVA: 0x00414F2B File Offset: 0x0041312B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C3E4 RID: 115684 RVA: 0x00414F34 File Offset: 0x00413134
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400A1ED RID: 41453
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A1EE RID: 41454
		public const int EntityIdFieldNumber = 12;

		// Token: 0x0400A1EF RID: 41455
		private long entityId_;
	}
}
