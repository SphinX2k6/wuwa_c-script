using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014D3 RID: 5331
	[NetMessage(EMessageId.TreasureBoxSlotAllInfoNotify)]
	public sealed class TreasureBoxSlotAllInfoNotify : IMessage<TreasureBoxSlotAllInfoNotify>, IMessage, IEquatable<TreasureBoxSlotAllInfoNotify>, IDeepCloneable<TreasureBoxSlotAllInfoNotify>, IBufferMessage
	{
		// Token: 0x0601C463 RID: 115811 RVA: 0x0041A4F0 File Offset: 0x004186F0
		[NullableContext(1)]
		public static TreasureBoxSlotAllInfoNotify Create()
		{
			return new TreasureBoxSlotAllInfoNotify();
		}

		// Token: 0x17005FAF RID: 24495
		// (get) Token: 0x0601C464 RID: 115812 RVA: 0x0041A4F7 File Offset: 0x004186F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FB0 RID: 24496
		// (get) Token: 0x0601C465 RID: 115813 RVA: 0x0041A4FA File Offset: 0x004186FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TreasureBoxSlotAllInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601C466 RID: 115814 RVA: 0x0041A501 File Offset: 0x00418701
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureBoxSlotAllInfoNotify()
		{
		}

		// Token: 0x0601C467 RID: 115815 RVA: 0x0041A514 File Offset: 0x00418714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureBoxSlotAllInfoNotify(TreasureBoxSlotAllInfoNotify other) : this()
		{
			this.allTreasureBoxSlotInfo_ = other.allTreasureBoxSlotInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C468 RID: 115816 RVA: 0x0041A53E File Offset: 0x0041873E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureBoxSlotAllInfoNotify Clone()
		{
			return new TreasureBoxSlotAllInfoNotify(this);
		}

		// Token: 0x17005FB1 RID: 24497
		// (get) Token: 0x0601C469 RID: 115817 RVA: 0x0041A546 File Offset: 0x00418746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TreasureBoxSlotInfo> AllTreasureBoxSlotInfo
		{
			get
			{
				return this.allTreasureBoxSlotInfo_;
			}
		}

		// Token: 0x0601C46A RID: 115818 RVA: 0x0041A54E File Offset: 0x0041874E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TreasureBoxSlotAllInfoNotify);
		}

		// Token: 0x0601C46B RID: 115819 RVA: 0x0041A55C File Offset: 0x0041875C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TreasureBoxSlotAllInfoNotify other)
		{
			return other != null && (other == this || (this.allTreasureBoxSlotInfo_.Equals(other.allTreasureBoxSlotInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C46C RID: 115820 RVA: 0x0041A590 File Offset: 0x00418790
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

		// Token: 0x0601C46D RID: 115821 RVA: 0x0041A5C4 File Offset: 0x004187C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C46E RID: 115822 RVA: 0x0041A5D1 File Offset: 0x004187D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C46F RID: 115823 RVA: 0x0041A5DA File Offset: 0x004187DA
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

		// Token: 0x0601C470 RID: 115824 RVA: 0x0041A604 File Offset: 0x00418804
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

		// Token: 0x0601C471 RID: 115825 RVA: 0x0041A63D File Offset: 0x0041883D
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

		// Token: 0x0601C472 RID: 115826 RVA: 0x0041A66B File Offset: 0x0041886B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C473 RID: 115827 RVA: 0x0041A674 File Offset: 0x00418874
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

		// Token: 0x0400A365 RID: 41829
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A366 RID: 41830
		public const int AllTreasureBoxSlotInfoFieldNumber = 8;

		// Token: 0x0400A367 RID: 41831
		private static readonly FieldCodec<TreasureBoxSlotInfo> _repeated_allTreasureBoxSlotInfo_codec = FieldCodec.ForMessage<TreasureBoxSlotInfo>(66U, TreasureBoxSlotInfo.Parser);

		// Token: 0x0400A368 RID: 41832
		private readonly RepeatedField<TreasureBoxSlotInfo> allTreasureBoxSlotInfo_ = new RepeatedField<TreasureBoxSlotInfo>();
	}
}
