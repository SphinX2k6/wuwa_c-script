using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001375 RID: 4981
	public sealed class TimelineTrackComponentPb : IMessage<TimelineTrackComponentPb>, IMessage, IEquatable<TimelineTrackComponentPb>, IDeepCloneable<TimelineTrackComponentPb>, IBufferMessage
	{
		// Token: 0x0601A72B RID: 108331 RVA: 0x003D6FE4 File Offset: 0x003D51E4
		[NullableContext(1)]
		public static TimelineTrackComponentPb Create()
		{
			return new TimelineTrackComponentPb();
		}

		// Token: 0x17005936 RID: 22838
		// (get) Token: 0x0601A72C RID: 108332 RVA: 0x003D6FEB File Offset: 0x003D51EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005937 RID: 22839
		// (get) Token: 0x0601A72D RID: 108333 RVA: 0x003D6FEE File Offset: 0x003D51EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimelineTrackComponentPb.Descriptor;
			}
		}

		// Token: 0x0601A72E RID: 108334 RVA: 0x003D6FF5 File Offset: 0x003D51F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTrackComponentPb()
		{
		}

		// Token: 0x0601A72F RID: 108335 RVA: 0x003D7008 File Offset: 0x003D5208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTrackComponentPb(TimelineTrackComponentPb other) : this()
		{
			this.index_ = other.index_;
			this.controlDatas_ = other.controlDatas_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A730 RID: 108336 RVA: 0x003D703E File Offset: 0x003D523E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTrackComponentPb Clone()
		{
			return new TimelineTrackComponentPb(this);
		}

		// Token: 0x17005938 RID: 22840
		// (get) Token: 0x0601A731 RID: 108337 RVA: 0x003D7046 File Offset: 0x003D5246
		// (set) Token: 0x0601A732 RID: 108338 RVA: 0x003D704E File Offset: 0x003D524E
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

		// Token: 0x17005939 RID: 22841
		// (get) Token: 0x0601A733 RID: 108339 RVA: 0x003D7057 File Offset: 0x003D5257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TimelineTrackControlDataPb> ControlDatas
		{
			get
			{
				return this.controlDatas_;
			}
		}

		// Token: 0x0601A734 RID: 108340 RVA: 0x003D705F File Offset: 0x003D525F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimelineTrackComponentPb);
		}

		// Token: 0x0601A735 RID: 108341 RVA: 0x003D7070 File Offset: 0x003D5270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimelineTrackComponentPb other)
		{
			return other != null && (other == this || (this.Index == other.Index && this.controlDatas_.Equals(other.controlDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A736 RID: 108342 RVA: 0x003D70C0 File Offset: 0x003D52C0
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

		// Token: 0x0601A737 RID: 108343 RVA: 0x003D710D File Offset: 0x003D530D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A738 RID: 108344 RVA: 0x003D711A File Offset: 0x003D531A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A739 RID: 108345 RVA: 0x003D7124 File Offset: 0x003D5324
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

		// Token: 0x0601A73A RID: 108346 RVA: 0x003D7174 File Offset: 0x003D5374
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

		// Token: 0x0601A73B RID: 108347 RVA: 0x003D71C8 File Offset: 0x003D53C8
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

		// Token: 0x0601A73C RID: 108348 RVA: 0x003D7215 File Offset: 0x003D5415
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A73D RID: 108349 RVA: 0x003D7220 File Offset: 0x003D5420
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

		// Token: 0x040099FB RID: 39419
		private UnknownFieldSet _unknownFields;

		// Token: 0x040099FC RID: 39420
		public const int IndexFieldNumber = 1;

		// Token: 0x040099FD RID: 39421
		private int index_;

		// Token: 0x040099FE RID: 39422
		public const int ControlDatasFieldNumber = 2;

		// Token: 0x040099FF RID: 39423
		private static readonly FieldCodec<TimelineTrackControlDataPb> _repeated_controlDatas_codec = FieldCodec.ForMessage<TimelineTrackControlDataPb>(18U, TimelineTrackControlDataPb.Parser);

		// Token: 0x04009A00 RID: 39424
		private readonly RepeatedField<TimelineTrackControlDataPb> controlDatas_ = new RepeatedField<TimelineTrackControlDataPb>();
	}
}
