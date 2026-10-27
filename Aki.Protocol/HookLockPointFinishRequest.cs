using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007B6 RID: 1974
	[NetMessage(EMessageId.HookLockPointFinishRequest)]
	public sealed class HookLockPointFinishRequest : IMessage<HookLockPointFinishRequest>, IMessage, IEquatable<HookLockPointFinishRequest>, IDeepCloneable<HookLockPointFinishRequest>, IBufferMessage
	{
		// Token: 0x0600B1C1 RID: 45505 RVA: 0x001A9FE5 File Offset: 0x001A81E5
		[NullableContext(1)]
		public static HookLockPointFinishRequest Create()
		{
			return new HookLockPointFinishRequest();
		}

		// Token: 0x170023DE RID: 9182
		// (get) Token: 0x0600B1C2 RID: 45506 RVA: 0x001A9FEC File Offset: 0x001A81EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023DF RID: 9183
		// (get) Token: 0x0600B1C3 RID: 45507 RVA: 0x001A9FEF File Offset: 0x001A81EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HookLockPointFinishRequest.Descriptor;
			}
		}

		// Token: 0x0600B1C4 RID: 45508 RVA: 0x001A9FF6 File Offset: 0x001A81F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointFinishRequest()
		{
		}

		// Token: 0x0600B1C5 RID: 45509 RVA: 0x001A9FFE File Offset: 0x001A81FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointFinishRequest(HookLockPointFinishRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B1C6 RID: 45510 RVA: 0x001AA023 File Offset: 0x001A8223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointFinishRequest Clone()
		{
			return new HookLockPointFinishRequest(this);
		}

		// Token: 0x170023E0 RID: 9184
		// (get) Token: 0x0600B1C7 RID: 45511 RVA: 0x001AA02B File Offset: 0x001A822B
		// (set) Token: 0x0600B1C8 RID: 45512 RVA: 0x001AA033 File Offset: 0x001A8233
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

		// Token: 0x0600B1C9 RID: 45513 RVA: 0x001AA03C File Offset: 0x001A823C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HookLockPointFinishRequest);
		}

		// Token: 0x0600B1CA RID: 45514 RVA: 0x001AA04A File Offset: 0x001A824A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HookLockPointFinishRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B1CB RID: 45515 RVA: 0x001AA078 File Offset: 0x001A8278
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

		// Token: 0x0600B1CC RID: 45516 RVA: 0x001AA0B7 File Offset: 0x001A82B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B1CD RID: 45517 RVA: 0x001AA0C4 File Offset: 0x001A82C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B1CE RID: 45518 RVA: 0x001AA0CD File Offset: 0x001A82CD
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

		// Token: 0x0600B1CF RID: 45519 RVA: 0x001AA100 File Offset: 0x001A8300
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

		// Token: 0x0600B1D0 RID: 45520 RVA: 0x001AA13E File Offset: 0x001A833E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HookLockPointFinishRequest other)
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

		// Token: 0x0600B1D1 RID: 45521 RVA: 0x001AA16F File Offset: 0x001A836F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B1D2 RID: 45522 RVA: 0x001AA178 File Offset: 0x001A8378
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

		// Token: 0x04004FA0 RID: 20384
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FA1 RID: 20385
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04004FA2 RID: 20386
		private long entityId_;
	}
}
