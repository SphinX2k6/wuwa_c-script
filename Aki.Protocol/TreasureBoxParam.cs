using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200145F RID: 5215
	public sealed class TreasureBoxParam : IMessage<TreasureBoxParam>, IMessage, IEquatable<TreasureBoxParam>, IDeepCloneable<TreasureBoxParam>, IBufferMessage
	{
		// Token: 0x0601B9C4 RID: 113092 RVA: 0x003FEF75 File Offset: 0x003FD175
		[NullableContext(1)]
		public static TreasureBoxParam Create()
		{
			return new TreasureBoxParam();
		}

		// Token: 0x17005D16 RID: 23830
		// (get) Token: 0x0601B9C5 RID: 113093 RVA: 0x003FEF7C File Offset: 0x003FD17C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D17 RID: 23831
		// (get) Token: 0x0601B9C6 RID: 113094 RVA: 0x003FEF7F File Offset: 0x003FD17F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TreasureBoxParam.Descriptor;
			}
		}

		// Token: 0x0601B9C7 RID: 113095 RVA: 0x003FEF86 File Offset: 0x003FD186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureBoxParam()
		{
		}

		// Token: 0x0601B9C8 RID: 113096 RVA: 0x003FEF99 File Offset: 0x003FD199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureBoxParam(TreasureBoxParam other) : this()
		{
			this.treasureBox_ = other.treasureBox_.Clone();
			this.detectionSlotId_ = other.detectionSlotId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B9C9 RID: 113097 RVA: 0x003FEFCF File Offset: 0x003FD1CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureBoxParam Clone()
		{
			return new TreasureBoxParam(this);
		}

		// Token: 0x17005D18 RID: 23832
		// (get) Token: 0x0601B9CA RID: 113098 RVA: 0x003FEFD7 File Offset: 0x003FD1D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MarkPointRequestInfo> TreasureBox
		{
			get
			{
				return this.treasureBox_;
			}
		}

		// Token: 0x17005D19 RID: 23833
		// (get) Token: 0x0601B9CB RID: 113099 RVA: 0x003FEFDF File Offset: 0x003FD1DF
		// (set) Token: 0x0601B9CC RID: 113100 RVA: 0x003FEFE7 File Offset: 0x003FD1E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long DetectionSlotId
		{
			get
			{
				return this.detectionSlotId_;
			}
			set
			{
				this.detectionSlotId_ = value;
			}
		}

		// Token: 0x0601B9CD RID: 113101 RVA: 0x003FEFF0 File Offset: 0x003FD1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TreasureBoxParam);
		}

		// Token: 0x0601B9CE RID: 113102 RVA: 0x003FF000 File Offset: 0x003FD200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TreasureBoxParam other)
		{
			return other != null && (other == this || (this.treasureBox_.Equals(other.treasureBox_) && this.DetectionSlotId == other.DetectionSlotId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B9CF RID: 113103 RVA: 0x003FF050 File Offset: 0x003FD250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.treasureBox_.GetHashCode();
			if (this.DetectionSlotId != 0L)
			{
				num ^= this.DetectionSlotId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B9D0 RID: 113104 RVA: 0x003FF09D File Offset: 0x003FD29D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B9D1 RID: 113105 RVA: 0x003FF0AA File Offset: 0x003FD2AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B9D2 RID: 113106 RVA: 0x003FF0B4 File Offset: 0x003FD2B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.treasureBox_.WriteTo(ref output, TreasureBoxParam._repeated_treasureBox_codec);
			if (this.DetectionSlotId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.DetectionSlotId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B9D3 RID: 113107 RVA: 0x003FF104 File Offset: 0x003FD304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.treasureBox_.CalculateSize(TreasureBoxParam._repeated_treasureBox_codec);
			if (this.DetectionSlotId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.DetectionSlotId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B9D4 RID: 113108 RVA: 0x003FF158 File Offset: 0x003FD358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TreasureBoxParam other)
		{
			if (other == null)
			{
				return;
			}
			this.treasureBox_.Add(other.treasureBox_);
			if (other.DetectionSlotId != 0L)
			{
				this.DetectionSlotId = other.DetectionSlotId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B9D5 RID: 113109 RVA: 0x003FF1A5 File Offset: 0x003FD3A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B9D6 RID: 113110 RVA: 0x003FF1B0 File Offset: 0x003FD3B0
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.DetectionSlotId = input.ReadInt64();
					}
				}
				else
				{
					this.treasureBox_.AddEntriesFrom(ref input, TreasureBoxParam._repeated_treasureBox_codec);
				}
			}
		}

		// Token: 0x04009F18 RID: 40728
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F19 RID: 40729
		public const int TreasureBoxFieldNumber = 1;

		// Token: 0x04009F1A RID: 40730
		private static readonly FieldCodec<MarkPointRequestInfo> _repeated_treasureBox_codec = FieldCodec.ForMessage<MarkPointRequestInfo>(10U, MarkPointRequestInfo.Parser);

		// Token: 0x04009F1B RID: 40731
		private readonly RepeatedField<MarkPointRequestInfo> treasureBox_ = new RepeatedField<MarkPointRequestInfo>();

		// Token: 0x04009F1C RID: 40732
		public const int DetectionSlotIdFieldNumber = 2;

		// Token: 0x04009F1D RID: 40733
		private long detectionSlotId_;
	}
}
