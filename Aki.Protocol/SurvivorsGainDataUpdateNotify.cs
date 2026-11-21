using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001336 RID: 4918
	[NetMessage(EMessageId.SurvivorsGainDataUpdateNotify)]
	public sealed class SurvivorsGainDataUpdateNotify : IMessage<SurvivorsGainDataUpdateNotify>, IMessage, IEquatable<SurvivorsGainDataUpdateNotify>, IDeepCloneable<SurvivorsGainDataUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601A37F RID: 107391 RVA: 0x003D282C File Offset: 0x003D0A2C
		[NullableContext(1)]
		public static SurvivorsGainDataUpdateNotify Create()
		{
			return new SurvivorsGainDataUpdateNotify();
		}

		// Token: 0x170058CD RID: 22733
		// (get) Token: 0x0601A380 RID: 107392 RVA: 0x003D2833 File Offset: 0x003D0A33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058CE RID: 22734
		// (get) Token: 0x0601A381 RID: 107393 RVA: 0x003D2836 File Offset: 0x003D0A36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsGainDataUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601A382 RID: 107394 RVA: 0x003D283D File Offset: 0x003D0A3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsGainDataUpdateNotify()
		{
		}

		// Token: 0x0601A383 RID: 107395 RVA: 0x003D2868 File Offset: 0x003D0A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsGainDataUpdateNotify(SurvivorsGainDataUpdateNotify other) : this()
		{
			this.adds_ = other.adds_.Clone();
			this.updates_ = other.updates_.Clone();
			this.removes_ = other.removes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A384 RID: 107396 RVA: 0x003D28BF File Offset: 0x003D0ABF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsGainDataUpdateNotify Clone()
		{
			return new SurvivorsGainDataUpdateNotify(this);
		}

		// Token: 0x170058CF RID: 22735
		// (get) Token: 0x0601A385 RID: 107397 RVA: 0x003D28C7 File Offset: 0x003D0AC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SurvivorsGainData> Adds
		{
			get
			{
				return this.adds_;
			}
		}

		// Token: 0x170058D0 RID: 22736
		// (get) Token: 0x0601A386 RID: 107398 RVA: 0x003D28CF File Offset: 0x003D0ACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SurvivorsGainData> Updates
		{
			get
			{
				return this.updates_;
			}
		}

		// Token: 0x170058D1 RID: 22737
		// (get) Token: 0x0601A387 RID: 107399 RVA: 0x003D28D7 File Offset: 0x003D0AD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Removes
		{
			get
			{
				return this.removes_;
			}
		}

		// Token: 0x0601A388 RID: 107400 RVA: 0x003D28DF File Offset: 0x003D0ADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsGainDataUpdateNotify);
		}

		// Token: 0x0601A389 RID: 107401 RVA: 0x003D28F0 File Offset: 0x003D0AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsGainDataUpdateNotify other)
		{
			return other != null && (other == this || (this.adds_.Equals(other.adds_) && this.updates_.Equals(other.updates_) && this.removes_.Equals(other.removes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A38A RID: 107402 RVA: 0x003D2958 File Offset: 0x003D0B58
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

		// Token: 0x0601A38B RID: 107403 RVA: 0x003D29A8 File Offset: 0x003D0BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A38C RID: 107404 RVA: 0x003D29B5 File Offset: 0x003D0BB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A38D RID: 107405 RVA: 0x003D29C0 File Offset: 0x003D0BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.updates_.WriteTo(ref output, SurvivorsGainDataUpdateNotify._repeated_updates_codec);
			this.removes_.WriteTo(ref output, SurvivorsGainDataUpdateNotify._repeated_removes_codec);
			this.adds_.WriteTo(ref output, SurvivorsGainDataUpdateNotify._repeated_adds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A38E RID: 107406 RVA: 0x003D2A14 File Offset: 0x003D0C14
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

		// Token: 0x0601A38F RID: 107407 RVA: 0x003D2A74 File Offset: 0x003D0C74
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

		// Token: 0x0601A390 RID: 107408 RVA: 0x003D2ACF File Offset: 0x003D0CCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A391 RID: 107409 RVA: 0x003D2AD8 File Offset: 0x003D0CD8
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
				if (num <= 64U)
				{
					if (num == 34U)
					{
						this.updates_.AddEntriesFrom(ref input, SurvivorsGainDataUpdateNotify._repeated_updates_codec);
						continue;
					}
					if (num == 64U)
					{
						goto IL_4B;
					}
				}
				else
				{
					if (num == 66U)
					{
						goto IL_4B;
					}
					if (num == 82U)
					{
						this.adds_.AddEntriesFrom(ref input, SurvivorsGainDataUpdateNotify._repeated_adds_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4B:
				this.removes_.AddEntriesFrom(ref input, SurvivorsGainDataUpdateNotify._repeated_removes_codec);
			}
		}

		// Token: 0x04009A36 RID: 39478
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A37 RID: 39479
		public const int AddsFieldNumber = 10;

		// Token: 0x04009A38 RID: 39480
		private static readonly FieldCodec<SurvivorsGainData> _repeated_adds_codec = FieldCodec.ForMessage<SurvivorsGainData>(82U, SurvivorsGainData.Parser);

		// Token: 0x04009A39 RID: 39481
		private readonly RepeatedField<SurvivorsGainData> adds_ = new RepeatedField<SurvivorsGainData>();

		// Token: 0x04009A3A RID: 39482
		public const int UpdatesFieldNumber = 4;

		// Token: 0x04009A3B RID: 39483
		private static readonly FieldCodec<SurvivorsGainData> _repeated_updates_codec = FieldCodec.ForMessage<SurvivorsGainData>(34U, SurvivorsGainData.Parser);

		// Token: 0x04009A3C RID: 39484
		private readonly RepeatedField<SurvivorsGainData> updates_ = new RepeatedField<SurvivorsGainData>();

		// Token: 0x04009A3D RID: 39485
		public const int RemovesFieldNumber = 8;

		// Token: 0x04009A3E RID: 39486
		private static readonly FieldCodec<int> _repeated_removes_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04009A3F RID: 39487
		private readonly RepeatedField<int> removes_ = new RepeatedField<int>();
	}
}
