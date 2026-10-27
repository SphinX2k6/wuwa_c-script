using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012C7 RID: 4807
	[NetMessage(EMessageId.SurvivorsGainDataUpdateNotify)]
	public sealed class SurvivorsGainDataUpdateNotify : IMessage<SurvivorsGainDataUpdateNotify>, IMessage, IEquatable<SurvivorsGainDataUpdateNotify>, IDeepCloneable<SurvivorsGainDataUpdateNotify>, IBufferMessage
	{
		// Token: 0x06019949 RID: 104777 RVA: 0x003B80F0 File Offset: 0x003B62F0
		[NullableContext(1)]
		public static SurvivorsGainDataUpdateNotify Create()
		{
			return new SurvivorsGainDataUpdateNotify();
		}

		// Token: 0x1700564C RID: 22092
		// (get) Token: 0x0601994A RID: 104778 RVA: 0x003B80F7 File Offset: 0x003B62F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700564D RID: 22093
		// (get) Token: 0x0601994B RID: 104779 RVA: 0x003B80FA File Offset: 0x003B62FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsGainDataUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601994C RID: 104780 RVA: 0x003B8101 File Offset: 0x003B6301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsGainDataUpdateNotify()
		{
		}

		// Token: 0x0601994D RID: 104781 RVA: 0x003B812C File Offset: 0x003B632C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsGainDataUpdateNotify(SurvivorsGainDataUpdateNotify other) : this()
		{
			this.adds_ = other.adds_.Clone();
			this.updates_ = other.updates_.Clone();
			this.removes_ = other.removes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601994E RID: 104782 RVA: 0x003B8183 File Offset: 0x003B6383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsGainDataUpdateNotify Clone()
		{
			return new SurvivorsGainDataUpdateNotify(this);
		}

		// Token: 0x1700564E RID: 22094
		// (get) Token: 0x0601994F RID: 104783 RVA: 0x003B818B File Offset: 0x003B638B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SurvivorsGainData> Adds
		{
			get
			{
				return this.adds_;
			}
		}

		// Token: 0x1700564F RID: 22095
		// (get) Token: 0x06019950 RID: 104784 RVA: 0x003B8193 File Offset: 0x003B6393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SurvivorsGainData> Updates
		{
			get
			{
				return this.updates_;
			}
		}

		// Token: 0x17005650 RID: 22096
		// (get) Token: 0x06019951 RID: 104785 RVA: 0x003B819B File Offset: 0x003B639B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Removes
		{
			get
			{
				return this.removes_;
			}
		}

		// Token: 0x06019952 RID: 104786 RVA: 0x003B81A3 File Offset: 0x003B63A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsGainDataUpdateNotify);
		}

		// Token: 0x06019953 RID: 104787 RVA: 0x003B81B4 File Offset: 0x003B63B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsGainDataUpdateNotify other)
		{
			return other != null && (other == this || (this.adds_.Equals(other.adds_) && this.updates_.Equals(other.updates_) && this.removes_.Equals(other.removes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019954 RID: 104788 RVA: 0x003B821C File Offset: 0x003B641C
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

		// Token: 0x06019955 RID: 104789 RVA: 0x003B826C File Offset: 0x003B646C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019956 RID: 104790 RVA: 0x003B8279 File Offset: 0x003B6479
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019957 RID: 104791 RVA: 0x003B8284 File Offset: 0x003B6484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.updates_.WriteTo(ref output, SurvivorsGainDataUpdateNotify._repeated_updates_codec);
			this.adds_.WriteTo(ref output, SurvivorsGainDataUpdateNotify._repeated_adds_codec);
			this.removes_.WriteTo(ref output, SurvivorsGainDataUpdateNotify._repeated_removes_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019958 RID: 104792 RVA: 0x003B82D8 File Offset: 0x003B64D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.adds_.CalculateSize(SurvivorsGainDataUpdateNotify._repeated_adds_codec);
			num += this.updates_.CalculateSize(SurvivorsGainDataUpdateNotify._repeated_updates_codec);
			num += this.removes_.CalculateSize(SurvivorsGainDataUpdateNotify._repeated_removes_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019959 RID: 104793 RVA: 0x003B8338 File Offset: 0x003B6538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsGainDataUpdateNotify other)
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

		// Token: 0x0601995A RID: 104794 RVA: 0x003B8393 File Offset: 0x003B6593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601995B RID: 104795 RVA: 0x003B839C File Offset: 0x003B659C
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
				if (num <= 66U)
				{
					if (num == 26U)
					{
						this.updates_.AddEntriesFrom(ref input, SurvivorsGainDataUpdateNotify._repeated_updates_codec);
						continue;
					}
					if (num == 66U)
					{
						this.adds_.AddEntriesFrom(ref input, SurvivorsGainDataUpdateNotify._repeated_adds_codec);
						continue;
					}
				}
				else if (num == 120U || num == 122U)
				{
					this.removes_.AddEntriesFrom(ref input, SurvivorsGainDataUpdateNotify._repeated_removes_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400960C RID: 38412
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400960D RID: 38413
		public const int AddsFieldNumber = 8;

		// Token: 0x0400960E RID: 38414
		private static readonly FieldCodec<SurvivorsGainData> _repeated_adds_codec = FieldCodec.ForMessage<SurvivorsGainData>(66U, SurvivorsGainData.Parser);

		// Token: 0x0400960F RID: 38415
		private readonly RepeatedField<SurvivorsGainData> adds_ = new RepeatedField<SurvivorsGainData>();

		// Token: 0x04009610 RID: 38416
		public const int UpdatesFieldNumber = 3;

		// Token: 0x04009611 RID: 38417
		private static readonly FieldCodec<SurvivorsGainData> _repeated_updates_codec = FieldCodec.ForMessage<SurvivorsGainData>(26U, SurvivorsGainData.Parser);

		// Token: 0x04009612 RID: 38418
		private readonly RepeatedField<SurvivorsGainData> updates_ = new RepeatedField<SurvivorsGainData>();

		// Token: 0x04009613 RID: 38419
		public const int RemovesFieldNumber = 15;

		// Token: 0x04009614 RID: 38420
		private static readonly FieldCodec<int> _repeated_removes_codec = FieldCodec.ForInt32(122U);

		// Token: 0x04009615 RID: 38421
		private readonly RepeatedField<int> removes_ = new RepeatedField<int>();
	}
}
