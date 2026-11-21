using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013E8 RID: 5096
	public sealed class TimelineTrackComponentPb : IMessage<TimelineTrackComponentPb>, IMessage, IEquatable<TimelineTrackComponentPb>, IDeepCloneable<TimelineTrackComponentPb>, IBufferMessage
	{
		// Token: 0x0601B1B4 RID: 111028 RVA: 0x003F21F8 File Offset: 0x003F03F8
		[NullableContext(1)]
		public static TimelineTrackComponentPb Create()
		{
			return new TimelineTrackComponentPb();
		}

		// Token: 0x17005BCA RID: 23498
		// (get) Token: 0x0601B1B5 RID: 111029 RVA: 0x003F21FF File Offset: 0x003F03FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BCB RID: 23499
		// (get) Token: 0x0601B1B6 RID: 111030 RVA: 0x003F2202 File Offset: 0x003F0402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimelineTrackComponentPb.Descriptor;
			}
		}

		// Token: 0x0601B1B7 RID: 111031 RVA: 0x003F2209 File Offset: 0x003F0409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTrackComponentPb()
		{
		}

		// Token: 0x0601B1B8 RID: 111032 RVA: 0x003F221C File Offset: 0x003F041C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTrackComponentPb(TimelineTrackComponentPb other) : this()
		{
			this.index_ = other.index_;
			this.controlDatas_ = other.controlDatas_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B1B9 RID: 111033 RVA: 0x003F2252 File Offset: 0x003F0452
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTrackComponentPb Clone()
		{
			return new TimelineTrackComponentPb(this);
		}

		// Token: 0x17005BCC RID: 23500
		// (get) Token: 0x0601B1BA RID: 111034 RVA: 0x003F225A File Offset: 0x003F045A
		// (set) Token: 0x0601B1BB RID: 111035 RVA: 0x003F2262 File Offset: 0x003F0462
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x17005BCD RID: 23501
		// (get) Token: 0x0601B1BC RID: 111036 RVA: 0x003F226B File Offset: 0x003F046B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TimelineTrackControlDataPb> ControlDatas
		{
			get
			{
				return this.controlDatas_;
			}
		}

		// Token: 0x0601B1BD RID: 111037 RVA: 0x003F2273 File Offset: 0x003F0473
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimelineTrackComponentPb);
		}

		// Token: 0x0601B1BE RID: 111038 RVA: 0x003F2284 File Offset: 0x003F0484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimelineTrackComponentPb other)
		{
			return other != null && (other == this || (this.Index == other.Index && this.controlDatas_.Equals(other.controlDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B1BF RID: 111039 RVA: 0x003F22D4 File Offset: 0x003F04D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			num ^= this.controlDatas_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B1C0 RID: 111040 RVA: 0x003F2321 File Offset: 0x003F0521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B1C1 RID: 111041 RVA: 0x003F232E File Offset: 0x003F052E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B1C2 RID: 111042 RVA: 0x003F2338 File Offset: 0x003F0538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Index);
			}
			this.controlDatas_.WriteTo(ref output, TimelineTrackComponentPb._repeated_controlDatas_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B1C3 RID: 111043 RVA: 0x003F2388 File Offset: 0x003F0588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			num += this.controlDatas_.CalculateSize(TimelineTrackComponentPb._repeated_controlDatas_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B1C4 RID: 111044 RVA: 0x003F23DC File Offset: 0x003F05DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TimelineTrackComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this.controlDatas_.Add(other.controlDatas_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B1C5 RID: 111045 RVA: 0x003F2429 File Offset: 0x003F0629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B1C6 RID: 111046 RVA: 0x003F2434 File Offset: 0x003F0634
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
						this.controlDatas_.AddEntriesFrom(ref input, TimelineTrackComponentPb._repeated_controlDatas_codec);
					}
				}
				else
				{
					this.Index = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009E40 RID: 40512
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E41 RID: 40513
		public const int IndexFieldNumber = 1;

		// Token: 0x04009E42 RID: 40514
		private int index_;

		// Token: 0x04009E43 RID: 40515
		public const int ControlDatasFieldNumber = 2;

		// Token: 0x04009E44 RID: 40516
		private static readonly FieldCodec<TimelineTrackControlDataPb> _repeated_controlDatas_codec = FieldCodec.ForMessage<TimelineTrackControlDataPb>(18U, TimelineTrackControlDataPb.Parser);

		// Token: 0x04009E45 RID: 40517
		private readonly RepeatedField<TimelineTrackControlDataPb> controlDatas_ = new RepeatedField<TimelineTrackControlDataPb>();
	}
}
