using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FD0 RID: 4048
	[NetMessage(EMessageId.RogueResGainDataUpdateNotify)]
	public sealed class RogueResGainDataUpdateNotify : IMessage<RogueResGainDataUpdateNotify>, IMessage, IEquatable<RogueResGainDataUpdateNotify>, IDeepCloneable<RogueResGainDataUpdateNotify>, IBufferMessage
	{
		// Token: 0x06015AA4 RID: 88740 RVA: 0x00325CF7 File Offset: 0x00323EF7
		[NullableContext(1)]
		public static RogueResGainDataUpdateNotify Create()
		{
			return new RogueResGainDataUpdateNotify();
		}

		// Token: 0x1700484B RID: 18507
		// (get) Token: 0x06015AA5 RID: 88741 RVA: 0x00325CFE File Offset: 0x00323EFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700484C RID: 18508
		// (get) Token: 0x06015AA6 RID: 88742 RVA: 0x00325D01 File Offset: 0x00323F01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResGainDataUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06015AA7 RID: 88743 RVA: 0x00325D08 File Offset: 0x00323F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGainDataUpdateNotify()
		{
		}

		// Token: 0x06015AA8 RID: 88744 RVA: 0x00325D34 File Offset: 0x00323F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGainDataUpdateNotify(RogueResGainDataUpdateNotify other) : this()
		{
			this.adds_ = other.adds_.Clone();
			this.updates_ = other.updates_.Clone();
			this.removes_ = other.removes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015AA9 RID: 88745 RVA: 0x00325D8B File Offset: 0x00323F8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGainDataUpdateNotify Clone()
		{
			return new RogueResGainDataUpdateNotify(this);
		}

		// Token: 0x1700484D RID: 18509
		// (get) Token: 0x06015AAA RID: 88746 RVA: 0x00325D93 File Offset: 0x00323F93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueResGainData> Adds
		{
			get
			{
				return this.adds_;
			}
		}

		// Token: 0x1700484E RID: 18510
		// (get) Token: 0x06015AAB RID: 88747 RVA: 0x00325D9B File Offset: 0x00323F9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueResGainData> Updates
		{
			get
			{
				return this.updates_;
			}
		}

		// Token: 0x1700484F RID: 18511
		// (get) Token: 0x06015AAC RID: 88748 RVA: 0x00325DA3 File Offset: 0x00323FA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Removes
		{
			get
			{
				return this.removes_;
			}
		}

		// Token: 0x06015AAD RID: 88749 RVA: 0x00325DAB File Offset: 0x00323FAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResGainDataUpdateNotify);
		}

		// Token: 0x06015AAE RID: 88750 RVA: 0x00325DBC File Offset: 0x00323FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResGainDataUpdateNotify other)
		{
			return other != null && (other == this || (this.adds_.Equals(other.adds_) && this.updates_.Equals(other.updates_) && this.removes_.Equals(other.removes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015AAF RID: 88751 RVA: 0x00325E24 File Offset: 0x00324024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.adds_.GetHashCode();
			num ^= this.updates_.GetHashCode();
			num ^= this.removes_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015AB0 RID: 88752 RVA: 0x00325E74 File Offset: 0x00324074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015AB1 RID: 88753 RVA: 0x00325E81 File Offset: 0x00324081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015AB2 RID: 88754 RVA: 0x00325E8C File Offset: 0x0032408C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.adds_.WriteTo(ref output, RogueResGainDataUpdateNotify._repeated_adds_codec);
			this.removes_.WriteTo(ref output, RogueResGainDataUpdateNotify._repeated_removes_codec);
			this.updates_.WriteTo(ref output, RogueResGainDataUpdateNotify._repeated_updates_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015AB3 RID: 88755 RVA: 0x00325EE0 File Offset: 0x003240E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.adds_.CalculateSize(RogueResGainDataUpdateNotify._repeated_adds_codec);
			num += this.updates_.CalculateSize(RogueResGainDataUpdateNotify._repeated_updates_codec);
			num += this.removes_.CalculateSize(RogueResGainDataUpdateNotify._repeated_removes_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015AB4 RID: 88756 RVA: 0x00325F40 File Offset: 0x00324140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResGainDataUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.adds_.Add(other.adds_);
			this.updates_.Add(other.updates_);
			this.removes_.Add(other.removes_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015AB5 RID: 88757 RVA: 0x00325F9B File Offset: 0x0032419B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015AB6 RID: 88758 RVA: 0x00325FA4 File Offset: 0x003241A4
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
				if (num <= 80U)
				{
					if (num == 18U)
					{
						this.adds_.AddEntriesFrom(ref input, RogueResGainDataUpdateNotify._repeated_adds_codec);
						continue;
					}
					if (num == 80U)
					{
						goto IL_4B;
					}
				}
				else
				{
					if (num == 82U)
					{
						goto IL_4B;
					}
					if (num == 106U)
					{
						this.updates_.AddEntriesFrom(ref input, RogueResGainDataUpdateNotify._repeated_updates_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4B:
				this.removes_.AddEntriesFrom(ref input, RogueResGainDataUpdateNotify._repeated_removes_codec);
			}
		}

		// Token: 0x04008281 RID: 33409
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008282 RID: 33410
		public const int AddsFieldNumber = 2;

		// Token: 0x04008283 RID: 33411
		private static readonly FieldCodec<RogueResGainData> _repeated_adds_codec = FieldCodec.ForMessage<RogueResGainData>(18U, RogueResGainData.Parser);

		// Token: 0x04008284 RID: 33412
		private readonly RepeatedField<RogueResGainData> adds_ = new RepeatedField<RogueResGainData>();

		// Token: 0x04008285 RID: 33413
		public const int UpdatesFieldNumber = 13;

		// Token: 0x04008286 RID: 33414
		private static readonly FieldCodec<RogueResGainData> _repeated_updates_codec = FieldCodec.ForMessage<RogueResGainData>(106U, RogueResGainData.Parser);

		// Token: 0x04008287 RID: 33415
		private readonly RepeatedField<RogueResGainData> updates_ = new RepeatedField<RogueResGainData>();

		// Token: 0x04008288 RID: 33416
		public const int RemovesFieldNumber = 10;

		// Token: 0x04008289 RID: 33417
		private static readonly FieldCodec<int> _repeated_removes_codec = FieldCodec.ForInt32(82U);

		// Token: 0x0400828A RID: 33418
		private readonly RepeatedField<int> removes_ = new RepeatedField<int>();
	}
}
