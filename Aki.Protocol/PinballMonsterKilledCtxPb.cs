using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D42 RID: 3394
	public sealed class PinballMonsterKilledCtxPb : IMessage<PinballMonsterKilledCtxPb>, IMessage, IEquatable<PinballMonsterKilledCtxPb>, IDeepCloneable<PinballMonsterKilledCtxPb>, IBufferMessage
	{
		// Token: 0x06012554 RID: 75092 RVA: 0x002AD754 File Offset: 0x002AB954
		[NullableContext(1)]
		public static PinballMonsterKilledCtxPb Create()
		{
			return new PinballMonsterKilledCtxPb();
		}

		// Token: 0x17003CC1 RID: 15553
		// (get) Token: 0x06012555 RID: 75093 RVA: 0x002AD75B File Offset: 0x002AB95B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CC2 RID: 15554
		// (get) Token: 0x06012556 RID: 75094 RVA: 0x002AD75E File Offset: 0x002AB95E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballMonsterKilledCtxPb.Descriptor;
			}
		}

		// Token: 0x06012557 RID: 75095 RVA: 0x002AD765 File Offset: 0x002AB965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballMonsterKilledCtxPb()
		{
		}

		// Token: 0x06012558 RID: 75096 RVA: 0x002AD76D File Offset: 0x002AB96D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballMonsterKilledCtxPb(PinballMonsterKilledCtxPb other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012559 RID: 75097 RVA: 0x002AD792 File Offset: 0x002AB992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballMonsterKilledCtxPb Clone()
		{
			return new PinballMonsterKilledCtxPb(this);
		}

		// Token: 0x17003CC3 RID: 15555
		// (get) Token: 0x0601255A RID: 75098 RVA: 0x002AD79A File Offset: 0x002AB99A
		// (set) Token: 0x0601255B RID: 75099 RVA: 0x002AD7A2 File Offset: 0x002AB9A2
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

		// Token: 0x0601255C RID: 75100 RVA: 0x002AD7AB File Offset: 0x002AB9AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballMonsterKilledCtxPb);
		}

		// Token: 0x0601255D RID: 75101 RVA: 0x002AD7B9 File Offset: 0x002AB9B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballMonsterKilledCtxPb other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601255E RID: 75102 RVA: 0x002AD7E8 File Offset: 0x002AB9E8
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

		// Token: 0x0601255F RID: 75103 RVA: 0x002AD827 File Offset: 0x002ABA27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012560 RID: 75104 RVA: 0x002AD834 File Offset: 0x002ABA34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012561 RID: 75105 RVA: 0x002AD83D File Offset: 0x002ABA3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012562 RID: 75106 RVA: 0x002AD870 File Offset: 0x002ABA70
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

		// Token: 0x06012563 RID: 75107 RVA: 0x002AD8AE File Offset: 0x002ABAAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballMonsterKilledCtxPb other)
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

		// Token: 0x06012564 RID: 75108 RVA: 0x002AD8DF File Offset: 0x002ABADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012565 RID: 75109 RVA: 0x002AD8E8 File Offset: 0x002ABAE8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040072A0 RID: 29344
		private UnknownFieldSet _unknownFields;

		// Token: 0x040072A1 RID: 29345
		public const int EntityIdFieldNumber = 1;

		// Token: 0x040072A2 RID: 29346
		private long entityId_;
	}
}
