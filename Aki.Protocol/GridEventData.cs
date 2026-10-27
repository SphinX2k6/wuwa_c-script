using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000718 RID: 1816
	public sealed class GridEventData : IMessage<GridEventData>, IMessage, IEquatable<GridEventData>, IDeepCloneable<GridEventData>, IBufferMessage
	{
		// Token: 0x0600A508 RID: 42248 RVA: 0x0018E1A3 File Offset: 0x0018C3A3
		[NullableContext(1)]
		public static GridEventData Create()
		{
			return new GridEventData();
		}

		// Token: 0x1700212C RID: 8492
		// (get) Token: 0x0600A509 RID: 42249 RVA: 0x0018E1AA File Offset: 0x0018C3AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700212D RID: 8493
		// (get) Token: 0x0600A50A RID: 42250 RVA: 0x0018E1AD File Offset: 0x0018C3AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GridEventData.Descriptor;
			}
		}

		// Token: 0x0600A50B RID: 42251 RVA: 0x0018E1B4 File Offset: 0x0018C3B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridEventData()
		{
		}

		// Token: 0x0600A50C RID: 42252 RVA: 0x0018E1C8 File Offset: 0x0018C3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridEventData(GridEventData other) : this()
		{
			this.gridIndex_ = other.gridIndex_;
			this.eventId_ = other.eventId_;
			this.state_ = other.state_;
			this.isInjured_ = other.isInjured_;
			this.steps_ = other.steps_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A50D RID: 42253 RVA: 0x0018E22D File Offset: 0x0018C42D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridEventData Clone()
		{
			return new GridEventData(this);
		}

		// Token: 0x1700212E RID: 8494
		// (get) Token: 0x0600A50E RID: 42254 RVA: 0x0018E235 File Offset: 0x0018C435
		// (set) Token: 0x0600A50F RID: 42255 RVA: 0x0018E23D File Offset: 0x0018C43D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GridIndex
		{
			get
			{
				return this.gridIndex_;
			}
			set
			{
				this.gridIndex_ = value;
			}
		}

		// Token: 0x1700212F RID: 8495
		// (get) Token: 0x0600A510 RID: 42256 RVA: 0x0018E246 File Offset: 0x0018C446
		// (set) Token: 0x0600A511 RID: 42257 RVA: 0x0018E24E File Offset: 0x0018C44E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EventId
		{
			get
			{
				return this.eventId_;
			}
			set
			{
				this.eventId_ = value;
			}
		}

		// Token: 0x17002130 RID: 8496
		// (get) Token: 0x0600A512 RID: 42258 RVA: 0x0018E257 File Offset: 0x0018C457
		// (set) Token: 0x0600A513 RID: 42259 RVA: 0x0018E25F File Offset: 0x0018C45F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridEventState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x17002131 RID: 8497
		// (get) Token: 0x0600A514 RID: 42260 RVA: 0x0018E268 File Offset: 0x0018C468
		// (set) Token: 0x0600A515 RID: 42261 RVA: 0x0018E270 File Offset: 0x0018C470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsInjured
		{
			get
			{
				return this.isInjured_;
			}
			set
			{
				this.isInjured_ = value;
			}
		}

		// Token: 0x17002132 RID: 8498
		// (get) Token: 0x0600A516 RID: 42262 RVA: 0x0018E279 File Offset: 0x0018C479
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Steps
		{
			get
			{
				return this.steps_;
			}
		}

		// Token: 0x0600A517 RID: 42263 RVA: 0x0018E281 File Offset: 0x0018C481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GridEventData);
		}

		// Token: 0x0600A518 RID: 42264 RVA: 0x0018E290 File Offset: 0x0018C490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GridEventData other)
		{
			return other != null && (other == this || (this.GridIndex == other.GridIndex && this.EventId == other.EventId && this.State == other.State && this.IsInjured == other.IsInjured && this.steps_.Equals(other.steps_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A519 RID: 42265 RVA: 0x0018E310 File Offset: 0x0018C510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GridIndex != 0)
			{
				num ^= this.GridIndex.GetHashCode();
			}
			if (this.EventId != 0)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this.State != GridEventState.UnTrigger)
			{
				num ^= this.State.GetHashCode();
			}
			if (this.IsInjured)
			{
				num ^= this.IsInjured.GetHashCode();
			}
			num ^= this.steps_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A51A RID: 42266 RVA: 0x0018E3AE File Offset: 0x0018C5AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A51B RID: 42267 RVA: 0x0018E3BB File Offset: 0x0018C5BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A51C RID: 42268 RVA: 0x0018E3C4 File Offset: 0x0018C5C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GridIndex != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GridIndex);
			}
			if (this.EventId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.EventId);
			}
			if (this.State != GridEventState.UnTrigger)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.State);
			}
			if (this.IsInjured)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsInjured);
			}
			this.steps_.WriteTo(ref output, GridEventData._repeated_steps_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A51D RID: 42269 RVA: 0x0018E468 File Offset: 0x0018C668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GridIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GridIndex);
			}
			if (this.EventId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EventId);
			}
			if (this.State != GridEventState.UnTrigger)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this.IsInjured)
			{
				num += 2;
			}
			num += this.steps_.CalculateSize(GridEventData._repeated_steps_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A51E RID: 42270 RVA: 0x0018E4F8 File Offset: 0x0018C6F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GridEventData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GridIndex != 0)
			{
				this.GridIndex = other.GridIndex;
			}
			if (other.EventId != 0)
			{
				this.EventId = other.EventId;
			}
			if (other.State != GridEventState.UnTrigger)
			{
				this.State = other.State;
			}
			if (other.IsInjured)
			{
				this.IsInjured = other.IsInjured;
			}
			this.steps_.Add(other.steps_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A51F RID: 42271 RVA: 0x0018E581 File Offset: 0x0018C781
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A520 RID: 42272 RVA: 0x0018E58C File Offset: 0x0018C78C
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
						this.GridIndex = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.EventId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.State = (GridEventState)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.IsInjured = input.ReadBool();
						continue;
					}
					if (num == 40U || num == 42U)
					{
						this.steps_.AddEntriesFrom(ref input, GridEventData._repeated_steps_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004BEC RID: 19436
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BED RID: 19437
		public const int GridIndexFieldNumber = 1;

		// Token: 0x04004BEE RID: 19438
		private int gridIndex_;

		// Token: 0x04004BEF RID: 19439
		public const int EventIdFieldNumber = 2;

		// Token: 0x04004BF0 RID: 19440
		private int eventId_;

		// Token: 0x04004BF1 RID: 19441
		public const int StateFieldNumber = 3;

		// Token: 0x04004BF2 RID: 19442
		private GridEventState state_;

		// Token: 0x04004BF3 RID: 19443
		public const int IsInjuredFieldNumber = 4;

		// Token: 0x04004BF4 RID: 19444
		private bool isInjured_;

		// Token: 0x04004BF5 RID: 19445
		public const int StepsFieldNumber = 5;

		// Token: 0x04004BF6 RID: 19446
		private static readonly FieldCodec<int> _repeated_steps_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04004BF7 RID: 19447
		private readonly RepeatedField<int> steps_ = new RepeatedField<int>();
	}
}
