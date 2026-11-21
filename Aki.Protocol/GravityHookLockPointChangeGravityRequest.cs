using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000700 RID: 1792
	[NetMessage(EMessageId.GravityHookLockPointChangeGravityRequest)]
	public sealed class GravityHookLockPointChangeGravityRequest : IMessage<GravityHookLockPointChangeGravityRequest>, IMessage, IEquatable<GravityHookLockPointChangeGravityRequest>, IDeepCloneable<GravityHookLockPointChangeGravityRequest>, IBufferMessage
	{
		// Token: 0x0600A368 RID: 41832 RVA: 0x0018AEFD File Offset: 0x001890FD
		[NullableContext(1)]
		public static GravityHookLockPointChangeGravityRequest Create()
		{
			return new GravityHookLockPointChangeGravityRequest();
		}

		// Token: 0x170020D5 RID: 8405
		// (get) Token: 0x0600A369 RID: 41833 RVA: 0x0018AF04 File Offset: 0x00189104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020D6 RID: 8406
		// (get) Token: 0x0600A36A RID: 41834 RVA: 0x0018AF07 File Offset: 0x00189107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GravityHookLockPointChangeGravityRequest.Descriptor;
			}
		}

		// Token: 0x0600A36B RID: 41835 RVA: 0x0018AF0E File Offset: 0x0018910E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityHookLockPointChangeGravityRequest()
		{
		}

		// Token: 0x0600A36C RID: 41836 RVA: 0x0018AF16 File Offset: 0x00189116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityHookLockPointChangeGravityRequest(GravityHookLockPointChangeGravityRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A36D RID: 41837 RVA: 0x0018AF3B File Offset: 0x0018913B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityHookLockPointChangeGravityRequest Clone()
		{
			return new GravityHookLockPointChangeGravityRequest(this);
		}

		// Token: 0x170020D7 RID: 8407
		// (get) Token: 0x0600A36E RID: 41838 RVA: 0x0018AF43 File Offset: 0x00189143
		// (set) Token: 0x0600A36F RID: 41839 RVA: 0x0018AF4B File Offset: 0x0018914B
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

		// Token: 0x0600A370 RID: 41840 RVA: 0x0018AF54 File Offset: 0x00189154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GravityHookLockPointChangeGravityRequest);
		}

		// Token: 0x0600A371 RID: 41841 RVA: 0x0018AF62 File Offset: 0x00189162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GravityHookLockPointChangeGravityRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A372 RID: 41842 RVA: 0x0018AF90 File Offset: 0x00189190
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

		// Token: 0x0600A373 RID: 41843 RVA: 0x0018AFCF File Offset: 0x001891CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A374 RID: 41844 RVA: 0x0018AFDC File Offset: 0x001891DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A375 RID: 41845 RVA: 0x0018AFE5 File Offset: 0x001891E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A376 RID: 41846 RVA: 0x0018B018 File Offset: 0x00189218
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

		// Token: 0x0600A377 RID: 41847 RVA: 0x0018B056 File Offset: 0x00189256
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

		// Token: 0x0600A378 RID: 41848 RVA: 0x0018B087 File Offset: 0x00189287
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A379 RID: 41849 RVA: 0x0018B090 File Offset: 0x00189290
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04004BD7 RID: 19415
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BD8 RID: 19416
		public const int EntityIdFieldNumber = 6;

		// Token: 0x04004BD9 RID: 19417
		private long entityId_;
	}
}
