using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010FA RID: 4346
	[NetMessage(EMessageId.RoverRogueEventNotify)]
	public sealed class RoverRogueEventNotify : IMessage<RoverRogueEventNotify>, IMessage, IEquatable<RoverRogueEventNotify>, IDeepCloneable<RoverRogueEventNotify>, IBufferMessage
	{
		// Token: 0x060172CF RID: 94927 RVA: 0x0035D0CC File Offset: 0x0035B2CC
		[NullableContext(1)]
		public static RoverRogueEventNotify Create()
		{
			return new RoverRogueEventNotify();
		}

		// Token: 0x17004DA7 RID: 19879
		// (get) Token: 0x060172D0 RID: 94928 RVA: 0x0035D0D3 File Offset: 0x0035B2D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004DA8 RID: 19880
		// (get) Token: 0x060172D1 RID: 94929 RVA: 0x0035D0D6 File Offset: 0x0035B2D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueEventNotify.Descriptor;
			}
		}

		// Token: 0x060172D2 RID: 94930 RVA: 0x0035D0DD File Offset: 0x0035B2DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueEventNotify()
		{
		}

		// Token: 0x060172D3 RID: 94931 RVA: 0x0035D0F0 File Offset: 0x0035B2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueEventNotify(RoverRogueEventNotify other) : this()
		{
			this.eventIncId_ = other.eventIncId_;
			this.choiceList_ = other.choiceList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060172D4 RID: 94932 RVA: 0x0035D126 File Offset: 0x0035B326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueEventNotify Clone()
		{
			return new RoverRogueEventNotify(this);
		}

		// Token: 0x17004DA9 RID: 19881
		// (get) Token: 0x060172D5 RID: 94933 RVA: 0x0035D12E File Offset: 0x0035B32E
		// (set) Token: 0x060172D6 RID: 94934 RVA: 0x0035D136 File Offset: 0x0035B336
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EventIncId
		{
			get
			{
				return this.eventIncId_;
			}
			set
			{
				this.eventIncId_ = value;
			}
		}

		// Token: 0x17004DAA RID: 19882
		// (get) Token: 0x060172D7 RID: 94935 RVA: 0x0035D13F File Offset: 0x0035B33F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ChoiceList
		{
			get
			{
				return this.choiceList_;
			}
		}

		// Token: 0x060172D8 RID: 94936 RVA: 0x0035D147 File Offset: 0x0035B347
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueEventNotify);
		}

		// Token: 0x060172D9 RID: 94937 RVA: 0x0035D158 File Offset: 0x0035B358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueEventNotify other)
		{
			return other != null && (other == this || (this.EventIncId == other.EventIncId && this.choiceList_.Equals(other.choiceList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060172DA RID: 94938 RVA: 0x0035D1A8 File Offset: 0x0035B3A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EventIncId != 0)
			{
				num ^= this.EventIncId.GetHashCode();
			}
			num ^= this.choiceList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060172DB RID: 94939 RVA: 0x0035D1F5 File Offset: 0x0035B3F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060172DC RID: 94940 RVA: 0x0035D202 File Offset: 0x0035B402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060172DD RID: 94941 RVA: 0x0035D20C File Offset: 0x0035B40C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EventIncId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.EventIncId);
			}
			this.choiceList_.WriteTo(ref output, RoverRogueEventNotify._repeated_choiceList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060172DE RID: 94942 RVA: 0x0035D25C File Offset: 0x0035B45C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EventIncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EventIncId);
			}
			num += this.choiceList_.CalculateSize(RoverRogueEventNotify._repeated_choiceList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060172DF RID: 94943 RVA: 0x0035D2B0 File Offset: 0x0035B4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueEventNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EventIncId != 0)
			{
				this.EventIncId = other.EventIncId;
			}
			this.choiceList_.Add(other.choiceList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060172E0 RID: 94944 RVA: 0x0035D2FD File Offset: 0x0035B4FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060172E1 RID: 94945 RVA: 0x0035D308 File Offset: 0x0035B508
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
				if (num != 80U)
				{
					if (num != 104U && num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.choiceList_.AddEntriesFrom(ref input, RoverRogueEventNotify._repeated_choiceList_codec);
					}
				}
				else
				{
					this.EventIncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040089D4 RID: 35284
		private UnknownFieldSet _unknownFields;

		// Token: 0x040089D5 RID: 35285
		public const int EventIncIdFieldNumber = 10;

		// Token: 0x040089D6 RID: 35286
		private int eventIncId_;

		// Token: 0x040089D7 RID: 35287
		public const int ChoiceListFieldNumber = 13;

		// Token: 0x040089D8 RID: 35288
		private static readonly FieldCodec<int> _repeated_choiceList_codec = FieldCodec.ForInt32(106U);

		// Token: 0x040089D9 RID: 35289
		private readonly RepeatedField<int> choiceList_ = new RepeatedField<int>();
	}
}
