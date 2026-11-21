using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000704 RID: 1796
	public sealed class GridEventData : IMessage<GridEventData>, IMessage, IEquatable<GridEventData>, IDeepCloneable<GridEventData>, IBufferMessage
	{
		// Token: 0x0600A3B2 RID: 41906 RVA: 0x0018B76F File Offset: 0x0018996F
		[NullableContext(1)]
		public static GridEventData Create()
		{
			return new GridEventData();
		}

		// Token: 0x170020E2 RID: 8418
		// (get) Token: 0x0600A3B3 RID: 41907 RVA: 0x0018B776 File Offset: 0x00189976
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020E3 RID: 8419
		// (get) Token: 0x0600A3B4 RID: 41908 RVA: 0x0018B779 File Offset: 0x00189979
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GridEventData.Descriptor;
			}
		}

		// Token: 0x0600A3B5 RID: 41909 RVA: 0x0018B780 File Offset: 0x00189980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridEventData()
		{
		}

		// Token: 0x0600A3B6 RID: 41910 RVA: 0x0018B794 File Offset: 0x00189994
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

		// Token: 0x0600A3B7 RID: 41911 RVA: 0x0018B7F9 File Offset: 0x001899F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridEventData Clone()
		{
			return new GridEventData(this);
		}

		// Token: 0x170020E4 RID: 8420
		// (get) Token: 0x0600A3B8 RID: 41912 RVA: 0x0018B801 File Offset: 0x00189A01
		// (set) Token: 0x0600A3B9 RID: 41913 RVA: 0x0018B809 File Offset: 0x00189A09
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

		// Token: 0x170020E5 RID: 8421
		// (get) Token: 0x0600A3BA RID: 41914 RVA: 0x0018B812 File Offset: 0x00189A12
		// (set) Token: 0x0600A3BB RID: 41915 RVA: 0x0018B81A File Offset: 0x00189A1A
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

		// Token: 0x170020E6 RID: 8422
		// (get) Token: 0x0600A3BC RID: 41916 RVA: 0x0018B823 File Offset: 0x00189A23
		// (set) Token: 0x0600A3BD RID: 41917 RVA: 0x0018B82B File Offset: 0x00189A2B
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

		// Token: 0x170020E7 RID: 8423
		// (get) Token: 0x0600A3BE RID: 41918 RVA: 0x0018B834 File Offset: 0x00189A34
		// (set) Token: 0x0600A3BF RID: 41919 RVA: 0x0018B83C File Offset: 0x00189A3C
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

		// Token: 0x170020E8 RID: 8424
		// (get) Token: 0x0600A3C0 RID: 41920 RVA: 0x0018B845 File Offset: 0x00189A45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Steps
		{
			get
			{
				return this.steps_;
			}
		}

		// Token: 0x0600A3C1 RID: 41921 RVA: 0x0018B84D File Offset: 0x00189A4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GridEventData);
		}

		// Token: 0x0600A3C2 RID: 41922 RVA: 0x0018B85C File Offset: 0x00189A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GridEventData other)
		{
			return other != null && (other == this || (this.GridIndex == other.GridIndex && this.EventId == other.EventId && this.State == other.State && this.IsInjured == other.IsInjured && this.steps_.Equals(other.steps_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A3C3 RID: 41923 RVA: 0x0018B8DC File Offset: 0x00189ADC
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

		// Token: 0x0600A3C4 RID: 41924 RVA: 0x0018B97A File Offset: 0x00189B7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A3C5 RID: 41925 RVA: 0x0018B987 File Offset: 0x00189B87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A3C6 RID: 41926 RVA: 0x0018B990 File Offset: 0x00189B90
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

		// Token: 0x0600A3C7 RID: 41927 RVA: 0x0018BA34 File Offset: 0x00189C34
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

		// Token: 0x0600A3C8 RID: 41928 RVA: 0x0018BAC4 File Offset: 0x00189CC4
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

		// Token: 0x0600A3C9 RID: 41929 RVA: 0x0018BB4D File Offset: 0x00189D4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A3CA RID: 41930 RVA: 0x0018BB58 File Offset: 0x00189D58
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

		// Token: 0x04004BE5 RID: 19429
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BE6 RID: 19430
		public const int GridIndexFieldNumber = 1;

		// Token: 0x04004BE7 RID: 19431
		private int gridIndex_;

		// Token: 0x04004BE8 RID: 19432
		public const int EventIdFieldNumber = 2;

		// Token: 0x04004BE9 RID: 19433
		private int eventId_;

		// Token: 0x04004BEA RID: 19434
		public const int StateFieldNumber = 3;

		// Token: 0x04004BEB RID: 19435
		private GridEventState state_;

		// Token: 0x04004BEC RID: 19436
		public const int IsInjuredFieldNumber = 4;

		// Token: 0x04004BED RID: 19437
		private bool isInjured_;

		// Token: 0x04004BEE RID: 19438
		public const int StepsFieldNumber = 5;

		// Token: 0x04004BEF RID: 19439
		private static readonly FieldCodec<int> _repeated_steps_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04004BF0 RID: 19440
		private readonly RepeatedField<int> steps_ = new RepeatedField<int>();
	}
}
