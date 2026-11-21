using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014D2 RID: 5330
	public sealed class TreasureBoxParam : IMessage<TreasureBoxParam>, IMessage, IEquatable<TreasureBoxParam>, IDeepCloneable<TreasureBoxParam>, IBufferMessage
	{
		// Token: 0x0601C44F RID: 115791 RVA: 0x0041A244 File Offset: 0x00418444
		[NullableContext(1)]
		public static TreasureBoxParam Create()
		{
			return new TreasureBoxParam();
		}

		// Token: 0x17005FAB RID: 24491
		// (get) Token: 0x0601C450 RID: 115792 RVA: 0x0041A24B File Offset: 0x0041844B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FAC RID: 24492
		// (get) Token: 0x0601C451 RID: 115793 RVA: 0x0041A24E File Offset: 0x0041844E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TreasureBoxParam.Descriptor;
			}
		}

		// Token: 0x0601C452 RID: 115794 RVA: 0x0041A255 File Offset: 0x00418455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureBoxParam()
		{
		}

		// Token: 0x0601C453 RID: 115795 RVA: 0x0041A268 File Offset: 0x00418468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureBoxParam(TreasureBoxParam other) : this()
		{
			this.treasureBox_ = other.treasureBox_.Clone();
			this.detectionSlotId_ = other.detectionSlotId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C454 RID: 115796 RVA: 0x0041A29E File Offset: 0x0041849E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureBoxParam Clone()
		{
			return new TreasureBoxParam(this);
		}

		// Token: 0x17005FAD RID: 24493
		// (get) Token: 0x0601C455 RID: 115797 RVA: 0x0041A2A6 File Offset: 0x004184A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MarkPointRequestInfo> TreasureBox
		{
			get
			{
				return this.treasureBox_;
			}
		}

		// Token: 0x17005FAE RID: 24494
		// (get) Token: 0x0601C456 RID: 115798 RVA: 0x0041A2AE File Offset: 0x004184AE
		// (set) Token: 0x0601C457 RID: 115799 RVA: 0x0041A2B6 File Offset: 0x004184B6
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

		// Token: 0x0601C458 RID: 115800 RVA: 0x0041A2BF File Offset: 0x004184BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TreasureBoxParam);
		}

		// Token: 0x0601C459 RID: 115801 RVA: 0x0041A2D0 File Offset: 0x004184D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TreasureBoxParam other)
		{
			return other != null && (other == this || (this.treasureBox_.Equals(other.treasureBox_) && this.DetectionSlotId == other.DetectionSlotId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C45A RID: 115802 RVA: 0x0041A320 File Offset: 0x00418520
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

		// Token: 0x0601C45B RID: 115803 RVA: 0x0041A36D File Offset: 0x0041856D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C45C RID: 115804 RVA: 0x0041A37A File Offset: 0x0041857A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C45D RID: 115805 RVA: 0x0041A384 File Offset: 0x00418584
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

		// Token: 0x0601C45E RID: 115806 RVA: 0x0041A3D4 File Offset: 0x004185D4
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

		// Token: 0x0601C45F RID: 115807 RVA: 0x0041A428 File Offset: 0x00418628
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

		// Token: 0x0601C460 RID: 115808 RVA: 0x0041A475 File Offset: 0x00418675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C461 RID: 115809 RVA: 0x0041A480 File Offset: 0x00418680
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

		// Token: 0x0400A35F RID: 41823
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A360 RID: 41824
		public const int TreasureBoxFieldNumber = 1;

		// Token: 0x0400A361 RID: 41825
		private static readonly FieldCodec<MarkPointRequestInfo> _repeated_treasureBox_codec = FieldCodec.ForMessage<MarkPointRequestInfo>(10U, MarkPointRequestInfo.Parser);

		// Token: 0x0400A362 RID: 41826
		private readonly RepeatedField<MarkPointRequestInfo> treasureBox_ = new RepeatedField<MarkPointRequestInfo>();

		// Token: 0x0400A363 RID: 41827
		public const int DetectionSlotIdFieldNumber = 2;

		// Token: 0x0400A364 RID: 41828
		private long detectionSlotId_;
	}
}
