using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007A5 RID: 1957
	[NetMessage(EMessageId.HookLockPointRequest)]
	public sealed class HookLockPointRequest : IMessage<HookLockPointRequest>, IMessage, IEquatable<HookLockPointRequest>, IDeepCloneable<HookLockPointRequest>, IBufferMessage
	{
		// Token: 0x0600B0A3 RID: 45219 RVA: 0x001A7BFC File Offset: 0x001A5DFC
		[NullableContext(1)]
		public static HookLockPointRequest Create()
		{
			return new HookLockPointRequest();
		}

		// Token: 0x1700239E RID: 9118
		// (get) Token: 0x0600B0A4 RID: 45220 RVA: 0x001A7C03 File Offset: 0x001A5E03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700239F RID: 9119
		// (get) Token: 0x0600B0A5 RID: 45221 RVA: 0x001A7C06 File Offset: 0x001A5E06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HookLockPointRequest.Descriptor;
			}
		}

		// Token: 0x0600B0A6 RID: 45222 RVA: 0x001A7C0D File Offset: 0x001A5E0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointRequest()
		{
		}

		// Token: 0x0600B0A7 RID: 45223 RVA: 0x001A7C15 File Offset: 0x001A5E15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointRequest(HookLockPointRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B0A8 RID: 45224 RVA: 0x001A7C3A File Offset: 0x001A5E3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointRequest Clone()
		{
			return new HookLockPointRequest(this);
		}

		// Token: 0x170023A0 RID: 9120
		// (get) Token: 0x0600B0A9 RID: 45225 RVA: 0x001A7C42 File Offset: 0x001A5E42
		// (set) Token: 0x0600B0AA RID: 45226 RVA: 0x001A7C4A File Offset: 0x001A5E4A
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

		// Token: 0x0600B0AB RID: 45227 RVA: 0x001A7C53 File Offset: 0x001A5E53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HookLockPointRequest);
		}

		// Token: 0x0600B0AC RID: 45228 RVA: 0x001A7C61 File Offset: 0x001A5E61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HookLockPointRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B0AD RID: 45229 RVA: 0x001A7C90 File Offset: 0x001A5E90
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

		// Token: 0x0600B0AE RID: 45230 RVA: 0x001A7CCF File Offset: 0x001A5ECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B0AF RID: 45231 RVA: 0x001A7CDC File Offset: 0x001A5EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B0B0 RID: 45232 RVA: 0x001A7CE5 File Offset: 0x001A5EE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B0B1 RID: 45233 RVA: 0x001A7D18 File Offset: 0x001A5F18
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

		// Token: 0x0600B0B2 RID: 45234 RVA: 0x001A7D56 File Offset: 0x001A5F56
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

		// Token: 0x0600B0B3 RID: 45235 RVA: 0x001A7D87 File Offset: 0x001A5F87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B0B4 RID: 45236 RVA: 0x001A7D90 File Offset: 0x001A5F90
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04004FA4 RID: 20388
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FA5 RID: 20389
		public const int EntityIdFieldNumber = 15;

		// Token: 0x04004FA6 RID: 20390
		private long entityId_;
	}
}
