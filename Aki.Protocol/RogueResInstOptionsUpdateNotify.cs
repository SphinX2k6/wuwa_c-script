using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FED RID: 4077
	[NetMessage(EMessageId.RogueResInstOptionsUpdateNotify)]
	public sealed class RogueResInstOptionsUpdateNotify : IMessage<RogueResInstOptionsUpdateNotify>, IMessage, IEquatable<RogueResInstOptionsUpdateNotify>, IDeepCloneable<RogueResInstOptionsUpdateNotify>, IBufferMessage
	{
		// Token: 0x06015CC8 RID: 89288 RVA: 0x0032AC0B File Offset: 0x00328E0B
		[NullableContext(1)]
		public static RogueResInstOptionsUpdateNotify Create()
		{
			return new RogueResInstOptionsUpdateNotify();
		}

		// Token: 0x170048C9 RID: 18633
		// (get) Token: 0x06015CC9 RID: 89289 RVA: 0x0032AC12 File Offset: 0x00328E12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048CA RID: 18634
		// (get) Token: 0x06015CCA RID: 89290 RVA: 0x0032AC15 File Offset: 0x00328E15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResInstOptionsUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06015CCB RID: 89291 RVA: 0x0032AC1C File Offset: 0x00328E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstOptionsUpdateNotify()
		{
		}

		// Token: 0x06015CCC RID: 89292 RVA: 0x0032AC48 File Offset: 0x00328E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstOptionsUpdateNotify(RogueResInstOptionsUpdateNotify other) : this()
		{
			this.adds_ = other.adds_.Clone();
			this.updates_ = other.updates_.Clone();
			this.removes_ = other.removes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015CCD RID: 89293 RVA: 0x0032AC9F File Offset: 0x00328E9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstOptionsUpdateNotify Clone()
		{
			return new RogueResInstOptionsUpdateNotify(this);
		}

		// Token: 0x170048CB RID: 18635
		// (get) Token: 0x06015CCE RID: 89294 RVA: 0x0032ACA7 File Offset: 0x00328EA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, RogueResOption> Adds
		{
			get
			{
				return this.adds_;
			}
		}

		// Token: 0x170048CC RID: 18636
		// (get) Token: 0x06015CCF RID: 89295 RVA: 0x0032ACAF File Offset: 0x00328EAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, RogueResOption> Updates
		{
			get
			{
				return this.updates_;
			}
		}

		// Token: 0x170048CD RID: 18637
		// (get) Token: 0x06015CD0 RID: 89296 RVA: 0x0032ACB7 File Offset: 0x00328EB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Removes
		{
			get
			{
				return this.removes_;
			}
		}

		// Token: 0x06015CD1 RID: 89297 RVA: 0x0032ACBF File Offset: 0x00328EBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResInstOptionsUpdateNotify);
		}

		// Token: 0x06015CD2 RID: 89298 RVA: 0x0032ACD0 File Offset: 0x00328ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResInstOptionsUpdateNotify other)
		{
			return other != null && (other == this || (this.Adds.Equals(other.Adds) && this.Updates.Equals(other.Updates) && this.removes_.Equals(other.removes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015CD3 RID: 89299 RVA: 0x0032AD38 File Offset: 0x00328F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.Adds.GetHashCode();
			num ^= this.Updates.GetHashCode();
			num ^= this.removes_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015CD4 RID: 89300 RVA: 0x0032AD88 File Offset: 0x00328F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015CD5 RID: 89301 RVA: 0x0032AD95 File Offset: 0x00328F95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015CD6 RID: 89302 RVA: 0x0032ADA0 File Offset: 0x00328FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.removes_.WriteTo(ref output, RogueResInstOptionsUpdateNotify._repeated_removes_codec);
			this.adds_.WriteTo(ref output, RogueResInstOptionsUpdateNotify._map_adds_codec);
			this.updates_.WriteTo(ref output, RogueResInstOptionsUpdateNotify._map_updates_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015CD7 RID: 89303 RVA: 0x0032ADF4 File Offset: 0x00328FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.adds_.CalculateSize(RogueResInstOptionsUpdateNotify._map_adds_codec);
			num += this.updates_.CalculateSize(RogueResInstOptionsUpdateNotify._map_updates_codec);
			num += this.removes_.CalculateSize(RogueResInstOptionsUpdateNotify._repeated_removes_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015CD8 RID: 89304 RVA: 0x0032AE54 File Offset: 0x00329054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResInstOptionsUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.adds_.MergeFrom(other.adds_);
			this.updates_.MergeFrom(other.updates_);
			this.removes_.Add(other.removes_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015CD9 RID: 89305 RVA: 0x0032AEAF File Offset: 0x003290AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015CDA RID: 89306 RVA: 0x0032AEB8 File Offset: 0x003290B8
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
				if (num <= 74U)
				{
					if (num == 72U || num == 74U)
					{
						this.removes_.AddEntriesFrom(ref input, RogueResInstOptionsUpdateNotify._repeated_removes_codec);
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						this.adds_.AddEntriesFrom(ref input, RogueResInstOptionsUpdateNotify._map_adds_codec);
						continue;
					}
					if (num == 106U)
					{
						this.updates_.AddEntriesFrom(ref input, RogueResInstOptionsUpdateNotify._map_updates_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040082DF RID: 33503
		private UnknownFieldSet _unknownFields;

		// Token: 0x040082E0 RID: 33504
		public const int AddsFieldNumber = 12;

		// Token: 0x040082E1 RID: 33505
		private static readonly MapField<int, RogueResOption>.Codec _map_adds_codec = new MapField<int, RogueResOption>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<RogueResOption>(18U, RogueResOption.Parser), 98U);

		// Token: 0x040082E2 RID: 33506
		private readonly MapField<int, RogueResOption> adds_ = new MapField<int, RogueResOption>();

		// Token: 0x040082E3 RID: 33507
		public const int UpdatesFieldNumber = 13;

		// Token: 0x040082E4 RID: 33508
		private static readonly MapField<int, RogueResOption>.Codec _map_updates_codec = new MapField<int, RogueResOption>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<RogueResOption>(18U, RogueResOption.Parser), 106U);

		// Token: 0x040082E5 RID: 33509
		private readonly MapField<int, RogueResOption> updates_ = new MapField<int, RogueResOption>();

		// Token: 0x040082E6 RID: 33510
		public const int RemovesFieldNumber = 9;

		// Token: 0x040082E7 RID: 33511
		private static readonly FieldCodec<int> _repeated_removes_codec = FieldCodec.ForInt32(74U);

		// Token: 0x040082E8 RID: 33512
		private readonly RepeatedField<int> removes_ = new RepeatedField<int>();
	}
}
