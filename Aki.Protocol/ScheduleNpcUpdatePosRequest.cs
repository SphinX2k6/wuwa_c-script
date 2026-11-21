using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011D0 RID: 4560
	[NetMessage(EMessageId.ScheduleNpcUpdatePosRequest)]
	public sealed class ScheduleNpcUpdatePosRequest : IMessage<ScheduleNpcUpdatePosRequest>, IMessage, IEquatable<ScheduleNpcUpdatePosRequest>, IDeepCloneable<ScheduleNpcUpdatePosRequest>, IBufferMessage
	{
		// Token: 0x06018586 RID: 99718 RVA: 0x0038B439 File Offset: 0x00389639
		[NullableContext(1)]
		public static ScheduleNpcUpdatePosRequest Create()
		{
			return new ScheduleNpcUpdatePosRequest();
		}

		// Token: 0x1700520E RID: 21006
		// (get) Token: 0x06018587 RID: 99719 RVA: 0x0038B440 File Offset: 0x00389640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700520F RID: 21007
		// (get) Token: 0x06018588 RID: 99720 RVA: 0x0038B443 File Offset: 0x00389643
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ScheduleNpcUpdatePosRequest.Descriptor;
			}
		}

		// Token: 0x06018589 RID: 99721 RVA: 0x0038B44A File Offset: 0x0038964A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScheduleNpcUpdatePosRequest()
		{
		}

		// Token: 0x0601858A RID: 99722 RVA: 0x0038B452 File Offset: 0x00389652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScheduleNpcUpdatePosRequest(ScheduleNpcUpdatePosRequest other) : this()
		{
			this.instId_ = other.instId_;
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601858B RID: 99723 RVA: 0x0038B483 File Offset: 0x00389683
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScheduleNpcUpdatePosRequest Clone()
		{
			return new ScheduleNpcUpdatePosRequest(this);
		}

		// Token: 0x17005210 RID: 21008
		// (get) Token: 0x0601858C RID: 99724 RVA: 0x0038B48B File Offset: 0x0038968B
		// (set) Token: 0x0601858D RID: 99725 RVA: 0x0038B493 File Offset: 0x00389693
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

		// Token: 0x17005211 RID: 21009
		// (get) Token: 0x0601858E RID: 99726 RVA: 0x0038B49C File Offset: 0x0038969C
		// (set) Token: 0x0601858F RID: 99727 RVA: 0x0038B4A4 File Offset: 0x003896A4
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

		// Token: 0x06018590 RID: 99728 RVA: 0x0038B4AD File Offset: 0x003896AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ScheduleNpcUpdatePosRequest);
		}

		// Token: 0x06018591 RID: 99729 RVA: 0x0038B4BB File Offset: 0x003896BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ScheduleNpcUpdatePosRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018592 RID: 99730 RVA: 0x0038B4FC File Offset: 0x003896FC
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

		// Token: 0x06018593 RID: 99731 RVA: 0x0038B554 File Offset: 0x00389754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018594 RID: 99732 RVA: 0x0038B561 File Offset: 0x00389761
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018595 RID: 99733 RVA: 0x0038B56C File Offset: 0x0038976C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.EntityId);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018596 RID: 99734 RVA: 0x0038B5C8 File Offset: 0x003897C8
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

		// Token: 0x06018597 RID: 99735 RVA: 0x0038B620 File Offset: 0x00389820
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

		// Token: 0x06018598 RID: 99736 RVA: 0x0038B670 File Offset: 0x00389870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018599 RID: 99737 RVA: 0x0038B67C File Offset: 0x0038987C
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
				if (num != 80U)
				{
					if (num != 112U)
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

		// Token: 0x040090B1 RID: 37041
		private UnknownFieldSet _unknownFields;

		// Token: 0x040090B2 RID: 37042
		public const int InstIdFieldNumber = 14;

		// Token: 0x040090B3 RID: 37043
		private int instId_;

		// Token: 0x040090B4 RID: 37044
		public const int EntityIdFieldNumber = 10;

		// Token: 0x040090B5 RID: 37045
		private long entityId_;
	}
}
