using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001196 RID: 4502
	[NetMessage(EMessageId.ScheduleNpcUpdatePosRequest)]
	public sealed class ScheduleNpcUpdatePosRequest : IMessage<ScheduleNpcUpdatePosRequest>, IMessage, IEquatable<ScheduleNpcUpdatePosRequest>, IDeepCloneable<ScheduleNpcUpdatePosRequest>, IBufferMessage
	{
		// Token: 0x06017FE5 RID: 98277 RVA: 0x0037C0F9 File Offset: 0x0037A2F9
		[NullableContext(1)]
		public static ScheduleNpcUpdatePosRequest Create()
		{
			return new ScheduleNpcUpdatePosRequest();
		}

		// Token: 0x170050A2 RID: 20642
		// (get) Token: 0x06017FE6 RID: 98278 RVA: 0x0037C100 File Offset: 0x0037A300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170050A3 RID: 20643
		// (get) Token: 0x06017FE7 RID: 98279 RVA: 0x0037C103 File Offset: 0x0037A303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ScheduleNpcUpdatePosRequest.Descriptor;
			}
		}

		// Token: 0x06017FE8 RID: 98280 RVA: 0x0037C10A File Offset: 0x0037A30A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScheduleNpcUpdatePosRequest()
		{
		}

		// Token: 0x06017FE9 RID: 98281 RVA: 0x0037C112 File Offset: 0x0037A312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScheduleNpcUpdatePosRequest(ScheduleNpcUpdatePosRequest other) : this()
		{
			this.instId_ = other.instId_;
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017FEA RID: 98282 RVA: 0x0037C143 File Offset: 0x0037A343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScheduleNpcUpdatePosRequest Clone()
		{
			return new ScheduleNpcUpdatePosRequest(this);
		}

		// Token: 0x170050A4 RID: 20644
		// (get) Token: 0x06017FEB RID: 98283 RVA: 0x0037C14B File Offset: 0x0037A34B
		// (set) Token: 0x06017FEC RID: 98284 RVA: 0x0037C153 File Offset: 0x0037A353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x170050A5 RID: 20645
		// (get) Token: 0x06017FED RID: 98285 RVA: 0x0037C15C File Offset: 0x0037A35C
		// (set) Token: 0x06017FEE RID: 98286 RVA: 0x0037C164 File Offset: 0x0037A364
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

		// Token: 0x06017FEF RID: 98287 RVA: 0x0037C16D File Offset: 0x0037A36D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ScheduleNpcUpdatePosRequest);
		}

		// Token: 0x06017FF0 RID: 98288 RVA: 0x0037C17B File Offset: 0x0037A37B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ScheduleNpcUpdatePosRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017FF1 RID: 98289 RVA: 0x0037C1BC File Offset: 0x0037A3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
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

		// Token: 0x06017FF2 RID: 98290 RVA: 0x0037C214 File Offset: 0x0037A414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017FF3 RID: 98291 RVA: 0x0037C221 File Offset: 0x0037A421
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017FF4 RID: 98292 RVA: 0x0037C22C File Offset: 0x0037A42C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityId);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017FF5 RID: 98293 RVA: 0x0037C288 File Offset: 0x0037A488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
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

		// Token: 0x06017FF6 RID: 98294 RVA: 0x0037C2E0 File Offset: 0x0037A4E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ScheduleNpcUpdatePosRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017FF7 RID: 98295 RVA: 0x0037C330 File Offset: 0x0037A530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017FF8 RID: 98296 RVA: 0x0037C33C File Offset: 0x0037A53C
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
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.InstId = input.ReadInt32();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04008E1E RID: 36382
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E1F RID: 36383
		public const int InstIdFieldNumber = 9;

		// Token: 0x04008E20 RID: 36384
		private int instId_;

		// Token: 0x04008E21 RID: 36385
		public const int EntityIdFieldNumber = 2;

		// Token: 0x04008E22 RID: 36386
		private long entityId_;
	}
}
