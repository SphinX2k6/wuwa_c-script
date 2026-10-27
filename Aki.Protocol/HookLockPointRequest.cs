using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007B9 RID: 1977
	[NetMessage(EMessageId.HookLockPointRequest)]
	public sealed class HookLockPointRequest : IMessage<HookLockPointRequest>, IMessage, IEquatable<HookLockPointRequest>, IDeepCloneable<HookLockPointRequest>, IBufferMessage
	{
		// Token: 0x0600B1F9 RID: 45561 RVA: 0x001AA62C File Offset: 0x001A882C
		[NullableContext(1)]
		public static HookLockPointRequest Create()
		{
			return new HookLockPointRequest();
		}

		// Token: 0x170023E8 RID: 9192
		// (get) Token: 0x0600B1FA RID: 45562 RVA: 0x001AA633 File Offset: 0x001A8833
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023E9 RID: 9193
		// (get) Token: 0x0600B1FB RID: 45563 RVA: 0x001AA636 File Offset: 0x001A8836
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HookLockPointRequest.Descriptor;
			}
		}

		// Token: 0x0600B1FC RID: 45564 RVA: 0x001AA63D File Offset: 0x001A883D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointRequest()
		{
		}

		// Token: 0x0600B1FD RID: 45565 RVA: 0x001AA645 File Offset: 0x001A8845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointRequest(HookLockPointRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B1FE RID: 45566 RVA: 0x001AA66A File Offset: 0x001A886A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointRequest Clone()
		{
			return new HookLockPointRequest(this);
		}

		// Token: 0x170023EA RID: 9194
		// (get) Token: 0x0600B1FF RID: 45567 RVA: 0x001AA672 File Offset: 0x001A8872
		// (set) Token: 0x0600B200 RID: 45568 RVA: 0x001AA67A File Offset: 0x001A887A
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

		// Token: 0x0600B201 RID: 45569 RVA: 0x001AA683 File Offset: 0x001A8883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HookLockPointRequest);
		}

		// Token: 0x0600B202 RID: 45570 RVA: 0x001AA691 File Offset: 0x001A8891
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HookLockPointRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B203 RID: 45571 RVA: 0x001AA6C0 File Offset: 0x001A88C0
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

		// Token: 0x0600B204 RID: 45572 RVA: 0x001AA6FF File Offset: 0x001A88FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B205 RID: 45573 RVA: 0x001AA70C File Offset: 0x001A890C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B206 RID: 45574 RVA: 0x001AA715 File Offset: 0x001A8915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B207 RID: 45575 RVA: 0x001AA748 File Offset: 0x001A8948
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

		// Token: 0x0600B208 RID: 45576 RVA: 0x001AA786 File Offset: 0x001A8986
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HookLockPointRequest other)
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

		// Token: 0x0600B209 RID: 45577 RVA: 0x001AA7B7 File Offset: 0x001A89B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B20A RID: 45578 RVA: 0x001AA7C0 File Offset: 0x001A89C0
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
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04004FAB RID: 20395
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FAC RID: 20396
		public const int EntityIdFieldNumber = 2;

		// Token: 0x04004FAD RID: 20397
		private long entityId_;
	}
}
