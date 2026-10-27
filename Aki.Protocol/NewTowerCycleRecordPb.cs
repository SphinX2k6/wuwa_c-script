using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B31 RID: 2865
	public sealed class NewTowerCycleRecordPb : IMessage<NewTowerCycleRecordPb>, IMessage, IEquatable<NewTowerCycleRecordPb>, IDeepCloneable<NewTowerCycleRecordPb>, IBufferMessage
	{
		// Token: 0x0600F8B6 RID: 63670 RVA: 0x0024482B File Offset: 0x00242A2B
		[NullableContext(1)]
		public static NewTowerCycleRecordPb Create()
		{
			return new NewTowerCycleRecordPb();
		}

		// Token: 0x170032B4 RID: 12980
		// (get) Token: 0x0600F8B7 RID: 63671 RVA: 0x00244832 File Offset: 0x00242A32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032B5 RID: 12981
		// (get) Token: 0x0600F8B8 RID: 63672 RVA: 0x00244835 File Offset: 0x00242A35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerCycleRecordPb.Descriptor;
			}
		}

		// Token: 0x0600F8B9 RID: 63673 RVA: 0x0024483C File Offset: 0x00242A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerCycleRecordPb()
		{
		}

		// Token: 0x0600F8BA RID: 63674 RVA: 0x0024484F File Offset: 0x00242A4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerCycleRecordPb(NewTowerCycleRecordPb other) : this()
		{
			this.cycleId_ = other.cycleId_;
			this.newTowerLevelRecordPbs_ = other.newTowerLevelRecordPbs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F8BB RID: 63675 RVA: 0x00244885 File Offset: 0x00242A85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerCycleRecordPb Clone()
		{
			return new NewTowerCycleRecordPb(this);
		}

		// Token: 0x170032B6 RID: 12982
		// (get) Token: 0x0600F8BC RID: 63676 RVA: 0x0024488D File Offset: 0x00242A8D
		// (set) Token: 0x0600F8BD RID: 63677 RVA: 0x00244895 File Offset: 0x00242A95
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

		// Token: 0x170032B7 RID: 12983
		// (get) Token: 0x0600F8BE RID: 63678 RVA: 0x0024489E File Offset: 0x00242A9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NewTowerLevelRecordPb> NewTowerLevelRecordPbs
		{
			get
			{
				return this.newTowerLevelRecordPbs_;
			}
		}

		// Token: 0x0600F8BF RID: 63679 RVA: 0x002448A6 File Offset: 0x00242AA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerCycleRecordPb);
		}

		// Token: 0x0600F8C0 RID: 63680 RVA: 0x002448B4 File Offset: 0x00242AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerCycleRecordPb other)
		{
			return other != null && (other == this || (this.CycleId == other.CycleId && this.newTowerLevelRecordPbs_.Equals(other.newTowerLevelRecordPbs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F8C1 RID: 63681 RVA: 0x00244904 File Offset: 0x00242B04
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

		// Token: 0x0600F8C2 RID: 63682 RVA: 0x00244951 File Offset: 0x00242B51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F8C3 RID: 63683 RVA: 0x0024495E File Offset: 0x00242B5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F8C4 RID: 63684 RVA: 0x00244968 File Offset: 0x00242B68
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

		// Token: 0x0600F8C5 RID: 63685 RVA: 0x002449B8 File Offset: 0x00242BB8
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

		// Token: 0x0600F8C6 RID: 63686 RVA: 0x00244A0C File Offset: 0x00242C0C
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

		// Token: 0x0600F8C7 RID: 63687 RVA: 0x00244A59 File Offset: 0x00242C59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F8C8 RID: 63688 RVA: 0x00244A64 File Offset: 0x00242C64
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

		// Token: 0x040063BF RID: 25535
		private UnknownFieldSet _unknownFields;

		// Token: 0x040063C0 RID: 25536
		public const int CycleIdFieldNumber = 1;

		// Token: 0x040063C1 RID: 25537
		private int cycleId_;

		// Token: 0x040063C2 RID: 25538
		public const int NewTowerLevelRecordPbsFieldNumber = 2;

		// Token: 0x040063C3 RID: 25539
		private static readonly FieldCodec<NewTowerLevelRecordPb> _repeated_newTowerLevelRecordPbs_codec = FieldCodec.ForMessage<NewTowerLevelRecordPb>(18U, NewTowerLevelRecordPb.Parser);

		// Token: 0x040063C4 RID: 25540
		private readonly RepeatedField<NewTowerLevelRecordPb> newTowerLevelRecordPbs_ = new RepeatedField<NewTowerLevelRecordPb>();
	}
}
