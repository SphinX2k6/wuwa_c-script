using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B20 RID: 2848
	public sealed class NewTowerCycleRecordPb : IMessage<NewTowerCycleRecordPb>, IMessage, IEquatable<NewTowerCycleRecordPb>, IDeepCloneable<NewTowerCycleRecordPb>, IBufferMessage
	{
		// Token: 0x0600F79C RID: 63388 RVA: 0x0024260F File Offset: 0x0024080F
		[NullableContext(1)]
		public static NewTowerCycleRecordPb Create()
		{
			return new NewTowerCycleRecordPb();
		}

		// Token: 0x17003276 RID: 12918
		// (get) Token: 0x0600F79D RID: 63389 RVA: 0x00242616 File Offset: 0x00240816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003277 RID: 12919
		// (get) Token: 0x0600F79E RID: 63390 RVA: 0x00242619 File Offset: 0x00240819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerCycleRecordPb.Descriptor;
			}
		}

		// Token: 0x0600F79F RID: 63391 RVA: 0x00242620 File Offset: 0x00240820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerCycleRecordPb()
		{
		}

		// Token: 0x0600F7A0 RID: 63392 RVA: 0x00242633 File Offset: 0x00240833
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerCycleRecordPb(NewTowerCycleRecordPb other) : this()
		{
			this.cycleId_ = other.cycleId_;
			this.newTowerLevelRecordPbs_ = other.newTowerLevelRecordPbs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F7A1 RID: 63393 RVA: 0x00242669 File Offset: 0x00240869
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerCycleRecordPb Clone()
		{
			return new NewTowerCycleRecordPb(this);
		}

		// Token: 0x17003278 RID: 12920
		// (get) Token: 0x0600F7A2 RID: 63394 RVA: 0x00242671 File Offset: 0x00240871
		// (set) Token: 0x0600F7A3 RID: 63395 RVA: 0x00242679 File Offset: 0x00240879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CycleId
		{
			get
			{
				return this.cycleId_;
			}
			set
			{
				this.cycleId_ = value;
			}
		}

		// Token: 0x17003279 RID: 12921
		// (get) Token: 0x0600F7A4 RID: 63396 RVA: 0x00242682 File Offset: 0x00240882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NewTowerLevelRecordPb> NewTowerLevelRecordPbs
		{
			get
			{
				return this.newTowerLevelRecordPbs_;
			}
		}

		// Token: 0x0600F7A5 RID: 63397 RVA: 0x0024268A File Offset: 0x0024088A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerCycleRecordPb);
		}

		// Token: 0x0600F7A6 RID: 63398 RVA: 0x00242698 File Offset: 0x00240898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerCycleRecordPb other)
		{
			return other != null && (other == this || (this.CycleId == other.CycleId && this.newTowerLevelRecordPbs_.Equals(other.newTowerLevelRecordPbs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F7A7 RID: 63399 RVA: 0x002426E8 File Offset: 0x002408E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CycleId != 0)
			{
				num ^= this.CycleId.GetHashCode();
			}
			num ^= this.newTowerLevelRecordPbs_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F7A8 RID: 63400 RVA: 0x00242735 File Offset: 0x00240935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F7A9 RID: 63401 RVA: 0x00242742 File Offset: 0x00240942
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F7AA RID: 63402 RVA: 0x0024274C File Offset: 0x0024094C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CycleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CycleId);
			}
			this.newTowerLevelRecordPbs_.WriteTo(ref output, NewTowerCycleRecordPb._repeated_newTowerLevelRecordPbs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F7AB RID: 63403 RVA: 0x0024279C File Offset: 0x0024099C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CycleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CycleId);
			}
			num += this.newTowerLevelRecordPbs_.CalculateSize(NewTowerCycleRecordPb._repeated_newTowerLevelRecordPbs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F7AC RID: 63404 RVA: 0x002427F0 File Offset: 0x002409F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerCycleRecordPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CycleId != 0)
			{
				this.CycleId = other.CycleId;
			}
			this.newTowerLevelRecordPbs_.Add(other.newTowerLevelRecordPbs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F7AD RID: 63405 RVA: 0x0024283D File Offset: 0x00240A3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F7AE RID: 63406 RVA: 0x00242848 File Offset: 0x00240A48
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.newTowerLevelRecordPbs_.AddEntriesFrom(ref input, NewTowerCycleRecordPb._repeated_newTowerLevelRecordPbs_codec);
					}
				}
				else
				{
					this.CycleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040063C8 RID: 25544
		private UnknownFieldSet _unknownFields;

		// Token: 0x040063C9 RID: 25545
		public const int CycleIdFieldNumber = 1;

		// Token: 0x040063CA RID: 25546
		private int cycleId_;

		// Token: 0x040063CB RID: 25547
		public const int NewTowerLevelRecordPbsFieldNumber = 2;

		// Token: 0x040063CC RID: 25548
		private static readonly FieldCodec<NewTowerLevelRecordPb> _repeated_newTowerLevelRecordPbs_codec = FieldCodec.ForMessage<NewTowerLevelRecordPb>(18U, NewTowerLevelRecordPb.Parser);

		// Token: 0x040063CD RID: 25549
		private readonly RepeatedField<NewTowerLevelRecordPb> newTowerLevelRecordPbs_ = new RepeatedField<NewTowerLevelRecordPb>();
	}
}
