using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007B4 RID: 1972
	[NetMessage(EMessageId.HookLockPointExitRequest)]
	public sealed class HookLockPointExitRequest : IMessage<HookLockPointExitRequest>, IMessage, IEquatable<HookLockPointExitRequest>, IDeepCloneable<HookLockPointExitRequest>, IBufferMessage
	{
		// Token: 0x0600B19B RID: 45467 RVA: 0x001A9B68 File Offset: 0x001A7D68
		[NullableContext(1)]
		public static HookLockPointExitRequest Create()
		{
			return new HookLockPointExitRequest();
		}

		// Token: 0x170023D7 RID: 9175
		// (get) Token: 0x0600B19C RID: 45468 RVA: 0x001A9B6F File Offset: 0x001A7D6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023D8 RID: 9176
		// (get) Token: 0x0600B19D RID: 45469 RVA: 0x001A9B72 File Offset: 0x001A7D72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HookLockPointExitRequest.Descriptor;
			}
		}

		// Token: 0x0600B19E RID: 45470 RVA: 0x001A9B79 File Offset: 0x001A7D79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointExitRequest()
		{
		}

		// Token: 0x0600B19F RID: 45471 RVA: 0x001A9B81 File Offset: 0x001A7D81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointExitRequest(HookLockPointExitRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.hookLockPointExitWay_ = other.hookLockPointExitWay_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B1A0 RID: 45472 RVA: 0x001A9BB2 File Offset: 0x001A7DB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointExitRequest Clone()
		{
			return new HookLockPointExitRequest(this);
		}

		// Token: 0x170023D9 RID: 9177
		// (get) Token: 0x0600B1A1 RID: 45473 RVA: 0x001A9BBA File Offset: 0x001A7DBA
		// (set) Token: 0x0600B1A2 RID: 45474 RVA: 0x001A9BC2 File Offset: 0x001A7DC2
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

		// Token: 0x170023DA RID: 9178
		// (get) Token: 0x0600B1A3 RID: 45475 RVA: 0x001A9BCB File Offset: 0x001A7DCB
		// (set) Token: 0x0600B1A4 RID: 45476 RVA: 0x001A9BD3 File Offset: 0x001A7DD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointExitWay HookLockPointExitWay
		{
			get
			{
				return this.hookLockPointExitWay_;
			}
			set
			{
				this.hookLockPointExitWay_ = value;
			}
		}

		// Token: 0x0600B1A5 RID: 45477 RVA: 0x001A9BDC File Offset: 0x001A7DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HookLockPointExitRequest);
		}

		// Token: 0x0600B1A6 RID: 45478 RVA: 0x001A9BEA File Offset: 0x001A7DEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HookLockPointExitRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.HookLockPointExitWay == other.HookLockPointExitWay && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B1A7 RID: 45479 RVA: 0x001A9C28 File Offset: 0x001A7E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.HookLockPointExitWay != HookLockPointExitWay.Midway)
			{
				num ^= this.HookLockPointExitWay.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B1A8 RID: 45480 RVA: 0x001A9C86 File Offset: 0x001A7E86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B1A9 RID: 45481 RVA: 0x001A9C93 File Offset: 0x001A7E93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B1AA RID: 45482 RVA: 0x001A9C9C File Offset: 0x001A7E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HookLockPointExitWay != HookLockPointExitWay.Midway)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.HookLockPointExitWay);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B1AB RID: 45483 RVA: 0x001A9CF8 File Offset: 0x001A7EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.HookLockPointExitWay != HookLockPointExitWay.Midway)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.HookLockPointExitWay);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B1AC RID: 45484 RVA: 0x001A9D50 File Offset: 0x001A7F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HookLockPointExitRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.HookLockPointExitWay != HookLockPointExitWay.Midway)
			{
				this.HookLockPointExitWay = other.HookLockPointExitWay;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B1AD RID: 45485 RVA: 0x001A9DA0 File Offset: 0x001A7FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B1AE RID: 45486 RVA: 0x001A9DAC File Offset: 0x001A7FAC
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
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.HookLockPointExitWay = (HookLockPointExitWay)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004F98 RID: 20376
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F99 RID: 20377
		public const int EntityIdFieldNumber = 7;

		// Token: 0x04004F9A RID: 20378
		private long entityId_;

		// Token: 0x04004F9B RID: 20379
		public const int HookLockPointExitWayFieldNumber = 2;

		// Token: 0x04004F9C RID: 20380
		private HookLockPointExitWay hookLockPointExitWay_;
	}
}
