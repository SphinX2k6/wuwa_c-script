using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001346 RID: 4934
	[NetMessage(EMessageId.SurvivorsOpDataUpdateNotify)]
	public sealed class SurvivorsOpDataUpdateNotify : IMessage<SurvivorsOpDataUpdateNotify>, IMessage, IEquatable<SurvivorsOpDataUpdateNotify>, IDeepCloneable<SurvivorsOpDataUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601A4BF RID: 107711 RVA: 0x003D5668 File Offset: 0x003D3868
		[NullableContext(1)]
		public static SurvivorsOpDataUpdateNotify Create()
		{
			return new SurvivorsOpDataUpdateNotify();
		}

		// Token: 0x17005911 RID: 22801
		// (get) Token: 0x0601A4C0 RID: 107712 RVA: 0x003D566F File Offset: 0x003D386F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005912 RID: 22802
		// (get) Token: 0x0601A4C1 RID: 107713 RVA: 0x003D5672 File Offset: 0x003D3872
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsOpDataUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601A4C2 RID: 107714 RVA: 0x003D5679 File Offset: 0x003D3879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOpDataUpdateNotify()
		{
		}

		// Token: 0x0601A4C3 RID: 107715 RVA: 0x003D56A4 File Offset: 0x003D38A4
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

		// Token: 0x0601A4C4 RID: 107716 RVA: 0x003D5707 File Offset: 0x003D3907
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOpDataUpdateNotify Clone()
		{
			return new SurvivorsOpDataUpdateNotify(this);
		}

		// Token: 0x17005913 RID: 22803
		// (get) Token: 0x0601A4C5 RID: 107717 RVA: 0x003D570F File Offset: 0x003D390F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SurvivorsOpData> Adds
		{
			get
			{
				return this.adds_;
			}
		}

		// Token: 0x17005914 RID: 22804
		// (get) Token: 0x0601A4C6 RID: 107718 RVA: 0x003D5717 File Offset: 0x003D3917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SurvivorsOpData> Updates
		{
			get
			{
				return this.updates_;
			}
		}

		// Token: 0x17005915 RID: 22805
		// (get) Token: 0x0601A4C7 RID: 107719 RVA: 0x003D571F File Offset: 0x003D391F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Removes
		{
			get
			{
				return this.removes_;
			}
		}

		// Token: 0x17005916 RID: 22806
		// (get) Token: 0x0601A4C8 RID: 107720 RVA: 0x003D5727 File Offset: 0x003D3927
		// (set) Token: 0x0601A4C9 RID: 107721 RVA: 0x003D572F File Offset: 0x003D392F
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

		// Token: 0x0601A4CA RID: 107722 RVA: 0x003D5738 File Offset: 0x003D3938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsOpDataUpdateNotify);
		}

		// Token: 0x0601A4CB RID: 107723 RVA: 0x003D5748 File Offset: 0x003D3948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsOpDataUpdateNotify other)
		{
			return other != null && (other == this || (this.adds_.Equals(other.adds_) && this.updates_.Equals(other.updates_) && this.removes_.Equals(other.removes_) && this.ForceIncId == other.ForceIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A4CC RID: 107724 RVA: 0x003D57C0 File Offset: 0x003D39C0
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

		// Token: 0x0601A4CD RID: 107725 RVA: 0x003D5829 File Offset: 0x003D3A29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A4CE RID: 107726 RVA: 0x003D5836 File Offset: 0x003D3A36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A4CF RID: 107727 RVA: 0x003D5840 File Offset: 0x003D3A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ForceIncId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ForceIncId);
			}
			this.updates_.WriteTo(ref output, SurvivorsOpDataUpdateNotify._repeated_updates_codec);
			this.adds_.WriteTo(ref output, SurvivorsOpDataUpdateNotify._repeated_adds_codec);
			this.removes_.WriteTo(ref output, SurvivorsOpDataUpdateNotify._repeated_removes_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A4D0 RID: 107728 RVA: 0x003D58B0 File Offset: 0x003D3AB0
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

		// Token: 0x0601A4D1 RID: 107729 RVA: 0x003D5928 File Offset: 0x003D3B28
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

		// Token: 0x0601A4D2 RID: 107730 RVA: 0x003D5997 File Offset: 0x003D3B97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A4D3 RID: 107731 RVA: 0x003D59A0 File Offset: 0x003D3BA0
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
				if (num <= 50U)
				{
					if (num == 8U)
					{
						this.ForceIncId = input.ReadInt32();
						continue;
					}
					if (num == 50U)
					{
						this.updates_.AddEntriesFrom(ref input, SurvivorsOpDataUpdateNotify._repeated_updates_codec);
						continue;
					}
				}
				else
				{
					if (num == 82U)
					{
						this.adds_.AddEntriesFrom(ref input, SurvivorsOpDataUpdateNotify._repeated_adds_codec);
						continue;
					}
					if (num == 88U || num == 90U)
					{
						this.removes_.AddEntriesFrom(ref input, SurvivorsOpDataUpdateNotify._repeated_removes_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009A92 RID: 39570
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A93 RID: 39571
		public const int AddsFieldNumber = 10;

		// Token: 0x04009A94 RID: 39572
		private static readonly FieldCodec<SurvivorsOpData> _repeated_adds_codec = FieldCodec.ForMessage<SurvivorsOpData>(82U, SurvivorsOpData.Parser);

		// Token: 0x04009A95 RID: 39573
		private readonly RepeatedField<SurvivorsOpData> adds_ = new RepeatedField<SurvivorsOpData>();

		// Token: 0x04009A96 RID: 39574
		public const int UpdatesFieldNumber = 6;

		// Token: 0x04009A97 RID: 39575
		private static readonly FieldCodec<SurvivorsOpData> _repeated_updates_codec = FieldCodec.ForMessage<SurvivorsOpData>(50U, SurvivorsOpData.Parser);

		// Token: 0x04009A98 RID: 39576
		private readonly RepeatedField<SurvivorsOpData> updates_ = new RepeatedField<SurvivorsOpData>();

		// Token: 0x04009A99 RID: 39577
		public const int RemovesFieldNumber = 11;

		// Token: 0x04009A9A RID: 39578
		private static readonly FieldCodec<int> _repeated_removes_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04009A9B RID: 39579
		private readonly RepeatedField<int> removes_ = new RepeatedField<int>();

		// Token: 0x04009A9C RID: 39580
		public const int ForceIncIdFieldNumber = 1;

		// Token: 0x04009A9D RID: 39581
		private int forceIncId_;
	}
}
