using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002B3 RID: 691
	public sealed class CombatCommon : IMessage<CombatCommon>, IMessage, IEquatable<CombatCommon>, IDeepCloneable<CombatCommon>, IBufferMessage
	{
		// Token: 0x060047B8 RID: 18360 RVA: 0x000B05CB File Offset: 0x000AE7CB
		[NullableContext(1)]
		public static CombatCommon Create()
		{
			return new CombatCommon();
		}

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x060047B9 RID: 18361 RVA: 0x000B05D2 File Offset: 0x000AE7D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x060047BA RID: 18362 RVA: 0x000B05D5 File Offset: 0x000AE7D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatCommon.Descriptor;
			}
		}

		// Token: 0x060047BB RID: 18363 RVA: 0x000B05DC File Offset: 0x000AE7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatCommon()
		{
		}

		// Token: 0x060047BC RID: 18364 RVA: 0x000B05E4 File Offset: 0x000AE7E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatCommon(CombatCommon other) : this()
		{
			this.preMessageId_ = other.preMessageId_;
			this.messageId_ = other.messageId_;
			this.originator_ = other.originator_;
			this.timeStamp_ = other.timeStamp_;
			this.entityId_ = other.entityId_;
			this.isServerRequest_ = other.isServerRequest_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060047BD RID: 18365 RVA: 0x000B0650 File Offset: 0x000AE850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatCommon Clone()
		{
			return new CombatCommon(this);
		}

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x060047BE RID: 18366 RVA: 0x000B0658 File Offset: 0x000AE858
		// (set) Token: 0x060047BF RID: 18367 RVA: 0x000B0660 File Offset: 0x000AE860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PreMessageId
		{
			get
			{
				return this.preMessageId_;
			}
			set
			{
				this.preMessageId_ = value;
			}
		}

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x060047C0 RID: 18368 RVA: 0x000B0669 File Offset: 0x000AE869
		// (set) Token: 0x060047C1 RID: 18369 RVA: 0x000B0671 File Offset: 0x000AE871
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long MessageId
		{
			get
			{
				return this.messageId_;
			}
			set
			{
				this.messageId_ = value;
			}
		}

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x060047C2 RID: 18370 RVA: 0x000B067A File Offset: 0x000AE87A
		// (set) Token: 0x060047C3 RID: 18371 RVA: 0x000B0682 File Offset: 0x000AE882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Originator
		{
			get
			{
				return this.originator_;
			}
			set
			{
				this.originator_ = value;
			}
		}

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x060047C4 RID: 18372 RVA: 0x000B068B File Offset: 0x000AE88B
		// (set) Token: 0x060047C5 RID: 18373 RVA: 0x000B0693 File Offset: 0x000AE893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float TimeStamp
		{
			get
			{
				return this.timeStamp_;
			}
			set
			{
				this.timeStamp_ = value;
			}
		}

		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x060047C6 RID: 18374 RVA: 0x000B069C File Offset: 0x000AE89C
		// (set) Token: 0x060047C7 RID: 18375 RVA: 0x000B06A4 File Offset: 0x000AE8A4
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

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x060047C8 RID: 18376 RVA: 0x000B06AD File Offset: 0x000AE8AD
		// (set) Token: 0x060047C9 RID: 18377 RVA: 0x000B06B5 File Offset: 0x000AE8B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsServerRequest
		{
			get
			{
				return this.isServerRequest_;
			}
			set
			{
				this.isServerRequest_ = value;
			}
		}

		// Token: 0x060047CA RID: 18378 RVA: 0x000B06BE File Offset: 0x000AE8BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatCommon);
		}

		// Token: 0x060047CB RID: 18379 RVA: 0x000B06CC File Offset: 0x000AE8CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatCommon other)
		{
			return other != null && (other == this || (this.PreMessageId == other.PreMessageId && this.MessageId == other.MessageId && this.Originator == other.Originator && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.TimeStamp, other.TimeStamp) && this.EntityId == other.EntityId && this.IsServerRequest == other.IsServerRequest && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060047CC RID: 18380 RVA: 0x000B0760 File Offset: 0x000AE960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PreMessageId != 0L)
			{
				num ^= this.PreMessageId.GetHashCode();
			}
			if (this.MessageId != 0L)
			{
				num ^= this.MessageId.GetHashCode();
			}
			if (this.Originator != 0L)
			{
				num ^= this.Originator.GetHashCode();
			}
			if (this.TimeStamp != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.TimeStamp);
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.IsServerRequest)
			{
				num ^= this.IsServerRequest.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060047CD RID: 18381 RVA: 0x000B0823 File Offset: 0x000AEA23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060047CE RID: 18382 RVA: 0x000B0830 File Offset: 0x000AEA30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060047CF RID: 18383 RVA: 0x000B083C File Offset: 0x000AEA3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PreMessageId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.PreMessageId);
			}
			if (this.MessageId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.MessageId);
			}
			if (this.Originator != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.Originator);
			}
			if (this.TimeStamp != 0f)
			{
				output.WriteRawTag(37);
				output.WriteFloat(this.TimeStamp);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EntityId);
			}
			if (this.IsServerRequest)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsServerRequest);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060047D0 RID: 18384 RVA: 0x000B090C File Offset: 0x000AEB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PreMessageId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.PreMessageId);
			}
			if (this.MessageId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.MessageId);
			}
			if (this.Originator != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Originator);
			}
			if (this.TimeStamp != 0f)
			{
				num += 5;
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.IsServerRequest)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060047D1 RID: 18385 RVA: 0x000B09B0 File Offset: 0x000AEBB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombatCommon other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PreMessageId != 0L)
			{
				this.PreMessageId = other.PreMessageId;
			}
			if (other.MessageId != 0L)
			{
				this.MessageId = other.MessageId;
			}
			if (other.Originator != 0L)
			{
				this.Originator = other.Originator;
			}
			if (other.TimeStamp != 0f)
			{
				this.TimeStamp = other.TimeStamp;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.IsServerRequest)
			{
				this.IsServerRequest = other.IsServerRequest;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060047D2 RID: 18386 RVA: 0x000B0A55 File Offset: 0x000AEC55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060047D3 RID: 18387 RVA: 0x000B0A60 File Offset: 0x000AEC60
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.PreMessageId = input.ReadInt64();
						continue;
					}
					if (num == 16U)
					{
						this.MessageId = input.ReadInt64();
						continue;
					}
					if (num == 24U)
					{
						this.Originator = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 37U)
					{
						this.TimeStamp = input.ReadFloat();
						continue;
					}
					if (num == 40U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 48U)
					{
						this.IsServerRequest = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003005 RID: 12293
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003006 RID: 12294
		public const int PreMessageIdFieldNumber = 1;

		// Token: 0x04003007 RID: 12295
		private long preMessageId_;

		// Token: 0x04003008 RID: 12296
		public const int MessageIdFieldNumber = 2;

		// Token: 0x04003009 RID: 12297
		private long messageId_;

		// Token: 0x0400300A RID: 12298
		public const int OriginatorFieldNumber = 3;

		// Token: 0x0400300B RID: 12299
		private long originator_;

		// Token: 0x0400300C RID: 12300
		public const int TimeStampFieldNumber = 4;

		// Token: 0x0400300D RID: 12301
		private float timeStamp_;

		// Token: 0x0400300E RID: 12302
		public const int EntityIdFieldNumber = 5;

		// Token: 0x0400300F RID: 12303
		private long entityId_;

		// Token: 0x04003010 RID: 12304
		public const int IsServerRequestFieldNumber = 6;

		// Token: 0x04003011 RID: 12305
		private bool isServerRequest_;
	}
}
