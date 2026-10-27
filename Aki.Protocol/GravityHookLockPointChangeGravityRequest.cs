using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000714 RID: 1812
	[NetMessage(EMessageId.GravityHookLockPointChangeGravityRequest)]
	public sealed class GravityHookLockPointChangeGravityRequest : IMessage<GravityHookLockPointChangeGravityRequest>, IMessage, IEquatable<GravityHookLockPointChangeGravityRequest>, IDeepCloneable<GravityHookLockPointChangeGravityRequest>, IBufferMessage
	{
		// Token: 0x0600A4BE RID: 42174 RVA: 0x0018D931 File Offset: 0x0018BB31
		[NullableContext(1)]
		public static GravityHookLockPointChangeGravityRequest Create()
		{
			return new GravityHookLockPointChangeGravityRequest();
		}

		// Token: 0x1700211F RID: 8479
		// (get) Token: 0x0600A4BF RID: 42175 RVA: 0x0018D938 File Offset: 0x0018BB38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002120 RID: 8480
		// (get) Token: 0x0600A4C0 RID: 42176 RVA: 0x0018D93B File Offset: 0x0018BB3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GravityHookLockPointChangeGravityRequest.Descriptor;
			}
		}

		// Token: 0x0600A4C1 RID: 42177 RVA: 0x0018D942 File Offset: 0x0018BB42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityHookLockPointChangeGravityRequest()
		{
		}

		// Token: 0x0600A4C2 RID: 42178 RVA: 0x0018D94A File Offset: 0x0018BB4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityHookLockPointChangeGravityRequest(GravityHookLockPointChangeGravityRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A4C3 RID: 42179 RVA: 0x0018D96F File Offset: 0x0018BB6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityHookLockPointChangeGravityRequest Clone()
		{
			return new GravityHookLockPointChangeGravityRequest(this);
		}

		// Token: 0x17002121 RID: 8481
		// (get) Token: 0x0600A4C4 RID: 42180 RVA: 0x0018D977 File Offset: 0x0018BB77
		// (set) Token: 0x0600A4C5 RID: 42181 RVA: 0x0018D97F File Offset: 0x0018BB7F
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

		// Token: 0x0600A4C6 RID: 42182 RVA: 0x0018D988 File Offset: 0x0018BB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GravityHookLockPointChangeGravityRequest);
		}

		// Token: 0x0600A4C7 RID: 42183 RVA: 0x0018D996 File Offset: 0x0018BB96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GravityHookLockPointChangeGravityRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A4C8 RID: 42184 RVA: 0x0018D9C4 File Offset: 0x0018BBC4
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

		// Token: 0x0600A4C9 RID: 42185 RVA: 0x0018DA03 File Offset: 0x0018BC03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A4CA RID: 42186 RVA: 0x0018DA10 File Offset: 0x0018BC10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A4CB RID: 42187 RVA: 0x0018DA19 File Offset: 0x0018BC19
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

		// Token: 0x0600A4CC RID: 42188 RVA: 0x0018DA4C File Offset: 0x0018BC4C
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

		// Token: 0x0600A4CD RID: 42189 RVA: 0x0018DA8A File Offset: 0x0018BC8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GravityHookLockPointChangeGravityRequest other)
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

		// Token: 0x0600A4CE RID: 42190 RVA: 0x0018DABB File Offset: 0x0018BCBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A4CF RID: 42191 RVA: 0x0018DAC4 File Offset: 0x0018BCC4
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

		// Token: 0x04004BDE RID: 19422
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BDF RID: 19423
		public const int EntityIdFieldNumber = 12;

		// Token: 0x04004BE0 RID: 19424
		private long entityId_;
	}
}
