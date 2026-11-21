using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007A0 RID: 1952
	[NetMessage(EMessageId.HookLockPointExitRequest)]
	public sealed class HookLockPointExitRequest : IMessage<HookLockPointExitRequest>, IMessage, IEquatable<HookLockPointExitRequest>, IDeepCloneable<HookLockPointExitRequest>, IBufferMessage
	{
		// Token: 0x0600B045 RID: 45125 RVA: 0x001A7138 File Offset: 0x001A5338
		[NullableContext(1)]
		public static HookLockPointExitRequest Create()
		{
			return new HookLockPointExitRequest();
		}

		// Token: 0x1700238D RID: 9101
		// (get) Token: 0x0600B046 RID: 45126 RVA: 0x001A713F File Offset: 0x001A533F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700238E RID: 9102
		// (get) Token: 0x0600B047 RID: 45127 RVA: 0x001A7142 File Offset: 0x001A5342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HookLockPointExitRequest.Descriptor;
			}
		}

		// Token: 0x0600B048 RID: 45128 RVA: 0x001A7149 File Offset: 0x001A5349
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointExitRequest()
		{
		}

		// Token: 0x0600B049 RID: 45129 RVA: 0x001A7151 File Offset: 0x001A5351
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointExitRequest(HookLockPointExitRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.hookLockPointExitWay_ = other.hookLockPointExitWay_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B04A RID: 45130 RVA: 0x001A7182 File Offset: 0x001A5382
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointExitRequest Clone()
		{
			return new HookLockPointExitRequest(this);
		}

		// Token: 0x1700238F RID: 9103
		// (get) Token: 0x0600B04B RID: 45131 RVA: 0x001A718A File Offset: 0x001A538A
		// (set) Token: 0x0600B04C RID: 45132 RVA: 0x001A7192 File Offset: 0x001A5392
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

		// Token: 0x17002390 RID: 9104
		// (get) Token: 0x0600B04D RID: 45133 RVA: 0x001A719B File Offset: 0x001A539B
		// (set) Token: 0x0600B04E RID: 45134 RVA: 0x001A71A3 File Offset: 0x001A53A3
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

		// Token: 0x0600B04F RID: 45135 RVA: 0x001A71AC File Offset: 0x001A53AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HookLockPointExitRequest);
		}

		// Token: 0x0600B050 RID: 45136 RVA: 0x001A71BA File Offset: 0x001A53BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HookLockPointExitRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.HookLockPointExitWay == other.HookLockPointExitWay && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B051 RID: 45137 RVA: 0x001A71F8 File Offset: 0x001A53F8
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

		// Token: 0x0600B052 RID: 45138 RVA: 0x001A7256 File Offset: 0x001A5456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B053 RID: 45139 RVA: 0x001A7263 File Offset: 0x001A5463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B054 RID: 45140 RVA: 0x001A726C File Offset: 0x001A546C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EntityId);
			}
			if (this.HookLockPointExitWay != HookLockPointExitWay.Midway)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.HookLockPointExitWay);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B055 RID: 45141 RVA: 0x001A72C8 File Offset: 0x001A54C8
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

		// Token: 0x0600B056 RID: 45142 RVA: 0x001A7320 File Offset: 0x001A5520
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

		// Token: 0x0600B057 RID: 45143 RVA: 0x001A7370 File Offset: 0x001A5570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B058 RID: 45144 RVA: 0x001A737C File Offset: 0x001A557C
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
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.HookLockPointExitWay = (HookLockPointExitWay)input.ReadEnum();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04004F91 RID: 20369
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F92 RID: 20370
		public const int EntityIdFieldNumber = 3;

		// Token: 0x04004F93 RID: 20371
		private long entityId_;

		// Token: 0x04004F94 RID: 20372
		public const int HookLockPointExitWayFieldNumber = 4;

		// Token: 0x04004F95 RID: 20373
		private HookLockPointExitWay hookLockPointExitWay_;
	}
}
