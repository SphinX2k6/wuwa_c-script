using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013DD RID: 5085
	[NetMessage(EMessageId.ThrowDamageRequest)]
	public sealed class ThrowDamageRequest : IMessage<ThrowDamageRequest>, IMessage, IEquatable<ThrowDamageRequest>, IDeepCloneable<ThrowDamageRequest>, IBufferMessage
	{
		// Token: 0x0601B0C9 RID: 110793 RVA: 0x003F0008 File Offset: 0x003EE208
		[NullableContext(1)]
		public static ThrowDamageRequest Create()
		{
			return new ThrowDamageRequest();
		}

		// Token: 0x17005B96 RID: 23446
		// (get) Token: 0x0601B0CA RID: 110794 RVA: 0x003F000F File Offset: 0x003EE20F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B97 RID: 23447
		// (get) Token: 0x0601B0CB RID: 110795 RVA: 0x003F0012 File Offset: 0x003EE212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThrowDamageRequest.Descriptor;
			}
		}

		// Token: 0x0601B0CC RID: 110796 RVA: 0x003F0019 File Offset: 0x003EE219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThrowDamageRequest()
		{
		}

		// Token: 0x0601B0CD RID: 110797 RVA: 0x003F0021 File Offset: 0x003EE221
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThrowDamageRequest(ThrowDamageRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.calculateId_ = other.calculateId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B0CE RID: 110798 RVA: 0x003F0052 File Offset: 0x003EE252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThrowDamageRequest Clone()
		{
			return new ThrowDamageRequest(this);
		}

		// Token: 0x17005B98 RID: 23448
		// (get) Token: 0x0601B0CF RID: 110799 RVA: 0x003F005A File Offset: 0x003EE25A
		// (set) Token: 0x0601B0D0 RID: 110800 RVA: 0x003F0062 File Offset: 0x003EE262
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

		// Token: 0x17005B99 RID: 23449
		// (get) Token: 0x0601B0D1 RID: 110801 RVA: 0x003F006B File Offset: 0x003EE26B
		// (set) Token: 0x0601B0D2 RID: 110802 RVA: 0x003F0073 File Offset: 0x003EE273
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CalculateId
		{
			get
			{
				return this.calculateId_;
			}
			set
			{
				this.calculateId_ = value;
			}
		}

		// Token: 0x0601B0D3 RID: 110803 RVA: 0x003F007C File Offset: 0x003EE27C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThrowDamageRequest);
		}

		// Token: 0x0601B0D4 RID: 110804 RVA: 0x003F008A File Offset: 0x003EE28A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThrowDamageRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.CalculateId == other.CalculateId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B0D5 RID: 110805 RVA: 0x003F00C8 File Offset: 0x003EE2C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.CalculateId != 0L)
			{
				num ^= this.CalculateId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B0D6 RID: 110806 RVA: 0x003F0120 File Offset: 0x003EE320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B0D7 RID: 110807 RVA: 0x003F012D File Offset: 0x003EE32D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B0D8 RID: 110808 RVA: 0x003F0138 File Offset: 0x003EE338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.EntityId);
			}
			if (this.CalculateId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.CalculateId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B0D9 RID: 110809 RVA: 0x003F0194 File Offset: 0x003EE394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.CalculateId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CalculateId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B0DA RID: 110810 RVA: 0x003F01EC File Offset: 0x003EE3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ThrowDamageRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.CalculateId != 0L)
			{
				this.CalculateId = other.CalculateId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B0DB RID: 110811 RVA: 0x003F023C File Offset: 0x003EE43C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B0DC RID: 110812 RVA: 0x003F0248 File Offset: 0x003EE448
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
				if (num != 32U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CalculateId = input.ReadInt64();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04009DF7 RID: 40439
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DF8 RID: 40440
		public const int EntityIdFieldNumber = 4;

		// Token: 0x04009DF9 RID: 40441
		private long entityId_;

		// Token: 0x04009DFA RID: 40442
		public const int CalculateIdFieldNumber = 7;

		// Token: 0x04009DFB RID: 40443
		private long calculateId_;
	}
}
