using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001460 RID: 5216
	[NetMessage(EMessageId.TreasureBoxSlotAllInfoNotify)]
	public sealed class TreasureBoxSlotAllInfoNotify : IMessage<TreasureBoxSlotAllInfoNotify>, IMessage, IEquatable<TreasureBoxSlotAllInfoNotify>, IDeepCloneable<TreasureBoxSlotAllInfoNotify>, IBufferMessage
	{
		// Token: 0x0601B9D8 RID: 113112 RVA: 0x003FF220 File Offset: 0x003FD420
		[NullableContext(1)]
		public static TreasureBoxSlotAllInfoNotify Create()
		{
			return new TreasureBoxSlotAllInfoNotify();
		}

		// Token: 0x17005D1A RID: 23834
		// (get) Token: 0x0601B9D9 RID: 113113 RVA: 0x003FF227 File Offset: 0x003FD427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D1B RID: 23835
		// (get) Token: 0x0601B9DA RID: 113114 RVA: 0x003FF22A File Offset: 0x003FD42A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TreasureBoxSlotAllInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601B9DB RID: 113115 RVA: 0x003FF231 File Offset: 0x003FD431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureBoxSlotAllInfoNotify()
		{
		}

		// Token: 0x0601B9DC RID: 113116 RVA: 0x003FF244 File Offset: 0x003FD444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureBoxSlotAllInfoNotify(TreasureBoxSlotAllInfoNotify other) : this()
		{
			this.allTreasureBoxSlotInfo_ = other.allTreasureBoxSlotInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B9DD RID: 113117 RVA: 0x003FF26E File Offset: 0x003FD46E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureBoxSlotAllInfoNotify Clone()
		{
			return new TreasureBoxSlotAllInfoNotify(this);
		}

		// Token: 0x17005D1C RID: 23836
		// (get) Token: 0x0601B9DE RID: 113118 RVA: 0x003FF276 File Offset: 0x003FD476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TreasureBoxSlotInfo> AllTreasureBoxSlotInfo
		{
			get
			{
				return this.allTreasureBoxSlotInfo_;
			}
		}

		// Token: 0x0601B9DF RID: 113119 RVA: 0x003FF27E File Offset: 0x003FD47E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TreasureBoxSlotAllInfoNotify);
		}

		// Token: 0x0601B9E0 RID: 113120 RVA: 0x003FF28C File Offset: 0x003FD48C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TreasureBoxSlotAllInfoNotify other)
		{
			return other != null && (other == this || (this.allTreasureBoxSlotInfo_.Equals(other.allTreasureBoxSlotInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B9E1 RID: 113121 RVA: 0x003FF2C0 File Offset: 0x003FD4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.allTreasureBoxSlotInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B9E2 RID: 113122 RVA: 0x003FF2F4 File Offset: 0x003FD4F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B9E3 RID: 113123 RVA: 0x003FF301 File Offset: 0x003FD501
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B9E4 RID: 113124 RVA: 0x003FF30A File Offset: 0x003FD50A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.allTreasureBoxSlotInfo_.WriteTo(ref output, TreasureBoxSlotAllInfoNotify._repeated_allTreasureBoxSlotInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B9E5 RID: 113125 RVA: 0x003FF334 File Offset: 0x003FD534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.allTreasureBoxSlotInfo_.CalculateSize(TreasureBoxSlotAllInfoNotify._repeated_allTreasureBoxSlotInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B9E6 RID: 113126 RVA: 0x003FF36D File Offset: 0x003FD56D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TreasureBoxSlotAllInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.allTreasureBoxSlotInfo_.Add(other.allTreasureBoxSlotInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B9E7 RID: 113127 RVA: 0x003FF39B File Offset: 0x003FD59B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B9E8 RID: 113128 RVA: 0x003FF3A4 File Offset: 0x003FD5A4
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.allTreasureBoxSlotInfo_.AddEntriesFrom(ref input, TreasureBoxSlotAllInfoNotify._repeated_allTreasureBoxSlotInfo_codec);
				}
			}
		}

		// Token: 0x04009F1E RID: 40734
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F1F RID: 40735
		public const int AllTreasureBoxSlotInfoFieldNumber = 8;

		// Token: 0x04009F20 RID: 40736
		private static readonly FieldCodec<TreasureBoxSlotInfo> _repeated_allTreasureBoxSlotInfo_codec = FieldCodec.ForMessage<TreasureBoxSlotInfo>(66U, TreasureBoxSlotInfo.Parser);

		// Token: 0x04009F21 RID: 40737
		private readonly RepeatedField<TreasureBoxSlotInfo> allTreasureBoxSlotInfo_ = new RepeatedField<TreasureBoxSlotInfo>();
	}
}
