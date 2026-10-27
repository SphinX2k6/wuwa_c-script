using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012D7 RID: 4823
	[NetMessage(EMessageId.SurvivorsOpDataUpdateNotify)]
	public sealed class SurvivorsOpDataUpdateNotify : IMessage<SurvivorsOpDataUpdateNotify>, IMessage, IEquatable<SurvivorsOpDataUpdateNotify>, IDeepCloneable<SurvivorsOpDataUpdateNotify>, IBufferMessage
	{
		// Token: 0x06019A89 RID: 105097 RVA: 0x003BAF35 File Offset: 0x003B9135
		[NullableContext(1)]
		public static SurvivorsOpDataUpdateNotify Create()
		{
			return new SurvivorsOpDataUpdateNotify();
		}

		// Token: 0x17005690 RID: 22160
		// (get) Token: 0x06019A8A RID: 105098 RVA: 0x003BAF3C File Offset: 0x003B913C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005691 RID: 22161
		// (get) Token: 0x06019A8B RID: 105099 RVA: 0x003BAF3F File Offset: 0x003B913F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsOpDataUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06019A8C RID: 105100 RVA: 0x003BAF46 File Offset: 0x003B9146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOpDataUpdateNotify()
		{
		}

		// Token: 0x06019A8D RID: 105101 RVA: 0x003BAF70 File Offset: 0x003B9170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOpDataUpdateNotify(SurvivorsOpDataUpdateNotify other) : this()
		{
			this.adds_ = other.adds_.Clone();
			this.updates_ = other.updates_.Clone();
			this.removes_ = other.removes_.Clone();
			this.forceIncId_ = other.forceIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019A8E RID: 105102 RVA: 0x003BAFD3 File Offset: 0x003B91D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOpDataUpdateNotify Clone()
		{
			return new SurvivorsOpDataUpdateNotify(this);
		}

		// Token: 0x17005692 RID: 22162
		// (get) Token: 0x06019A8F RID: 105103 RVA: 0x003BAFDB File Offset: 0x003B91DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SurvivorsOpData> Adds
		{
			get
			{
				return this.adds_;
			}
		}

		// Token: 0x17005693 RID: 22163
		// (get) Token: 0x06019A90 RID: 105104 RVA: 0x003BAFE3 File Offset: 0x003B91E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SurvivorsOpData> Updates
		{
			get
			{
				return this.updates_;
			}
		}

		// Token: 0x17005694 RID: 22164
		// (get) Token: 0x06019A91 RID: 105105 RVA: 0x003BAFEB File Offset: 0x003B91EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Removes
		{
			get
			{
				return this.removes_;
			}
		}

		// Token: 0x17005695 RID: 22165
		// (get) Token: 0x06019A92 RID: 105106 RVA: 0x003BAFF3 File Offset: 0x003B91F3
		// (set) Token: 0x06019A93 RID: 105107 RVA: 0x003BAFFB File Offset: 0x003B91FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ForceIncId
		{
			get
			{
				return this.forceIncId_;
			}
			set
			{
				this.forceIncId_ = value;
			}
		}

		// Token: 0x06019A94 RID: 105108 RVA: 0x003BB004 File Offset: 0x003B9204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsOpDataUpdateNotify);
		}

		// Token: 0x06019A95 RID: 105109 RVA: 0x003BB014 File Offset: 0x003B9214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsOpDataUpdateNotify other)
		{
			return other != null && (other == this || (this.adds_.Equals(other.adds_) && this.updates_.Equals(other.updates_) && this.removes_.Equals(other.removes_) && this.ForceIncId == other.ForceIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019A96 RID: 105110 RVA: 0x003BB08C File Offset: 0x003B928C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.adds_.GetHashCode();
			num ^= this.updates_.GetHashCode();
			num ^= this.removes_.GetHashCode();
			if (this.ForceIncId != 0)
			{
				num ^= this.ForceIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019A97 RID: 105111 RVA: 0x003BB0F5 File Offset: 0x003B92F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019A98 RID: 105112 RVA: 0x003BB102 File Offset: 0x003B9302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019A99 RID: 105113 RVA: 0x003BB10C File Offset: 0x003B930C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.updates_.WriteTo(ref output, SurvivorsOpDataUpdateNotify._repeated_updates_codec);
			if (this.ForceIncId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ForceIncId);
			}
			this.adds_.WriteTo(ref output, SurvivorsOpDataUpdateNotify._repeated_adds_codec);
			this.removes_.WriteTo(ref output, SurvivorsOpDataUpdateNotify._repeated_removes_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019A9A RID: 105114 RVA: 0x003BB17C File Offset: 0x003B937C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.adds_.CalculateSize(SurvivorsOpDataUpdateNotify._repeated_adds_codec);
			num += this.updates_.CalculateSize(SurvivorsOpDataUpdateNotify._repeated_updates_codec);
			num += this.removes_.CalculateSize(SurvivorsOpDataUpdateNotify._repeated_removes_codec);
			if (this.ForceIncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ForceIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019A9B RID: 105115 RVA: 0x003BB1F4 File Offset: 0x003B93F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsOpDataUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.adds_.Add(other.adds_);
			this.updates_.Add(other.updates_);
			this.removes_.Add(other.removes_);
			if (other.ForceIncId != 0)
			{
				this.ForceIncId = other.ForceIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019A9C RID: 105116 RVA: 0x003BB263 File Offset: 0x003B9463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019A9D RID: 105117 RVA: 0x003BB26C File Offset: 0x003B946C
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
				if (num <= 48U)
				{
					if (num == 10U)
					{
						this.updates_.AddEntriesFrom(ref input, SurvivorsOpDataUpdateNotify._repeated_updates_codec);
						continue;
					}
					if (num == 48U)
					{
						this.ForceIncId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						this.adds_.AddEntriesFrom(ref input, SurvivorsOpDataUpdateNotify._repeated_adds_codec);
						continue;
					}
					if (num == 112U || num == 114U)
					{
						this.removes_.AddEntriesFrom(ref input, SurvivorsOpDataUpdateNotify._repeated_removes_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009668 RID: 38504
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009669 RID: 38505
		public const int AddsFieldNumber = 12;

		// Token: 0x0400966A RID: 38506
		private static readonly FieldCodec<SurvivorsOpData> _repeated_adds_codec = FieldCodec.ForMessage<SurvivorsOpData>(98U, SurvivorsOpData.Parser);

		// Token: 0x0400966B RID: 38507
		private readonly RepeatedField<SurvivorsOpData> adds_ = new RepeatedField<SurvivorsOpData>();

		// Token: 0x0400966C RID: 38508
		public const int UpdatesFieldNumber = 1;

		// Token: 0x0400966D RID: 38509
		private static readonly FieldCodec<SurvivorsOpData> _repeated_updates_codec = FieldCodec.ForMessage<SurvivorsOpData>(10U, SurvivorsOpData.Parser);

		// Token: 0x0400966E RID: 38510
		private readonly RepeatedField<SurvivorsOpData> updates_ = new RepeatedField<SurvivorsOpData>();

		// Token: 0x0400966F RID: 38511
		public const int RemovesFieldNumber = 14;

		// Token: 0x04009670 RID: 38512
		private static readonly FieldCodec<int> _repeated_removes_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04009671 RID: 38513
		private readonly RepeatedField<int> removes_ = new RepeatedField<int>();

		// Token: 0x04009672 RID: 38514
		public const int ForceIncIdFieldNumber = 6;

		// Token: 0x04009673 RID: 38515
		private int forceIncId_;
	}
}
