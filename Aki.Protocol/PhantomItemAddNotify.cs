using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CDE RID: 3294
	[NetMessage(EMessageId.PhantomItemAddNotify)]
	public sealed class PhantomItemAddNotify : IMessage<PhantomItemAddNotify>, IMessage, IEquatable<PhantomItemAddNotify>, IDeepCloneable<PhantomItemAddNotify>, IBufferMessage
	{
		// Token: 0x06011D36 RID: 73014 RVA: 0x0029BBD6 File Offset: 0x00299DD6
		[NullableContext(1)]
		public static PhantomItemAddNotify Create()
		{
			return new PhantomItemAddNotify();
		}

		// Token: 0x17003B14 RID: 15124
		// (get) Token: 0x06011D37 RID: 73015 RVA: 0x0029BBDD File Offset: 0x00299DDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B15 RID: 15125
		// (get) Token: 0x06011D38 RID: 73016 RVA: 0x0029BBE0 File Offset: 0x00299DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomItemAddNotify.Descriptor;
			}
		}

		// Token: 0x06011D39 RID: 73017 RVA: 0x0029BBE7 File Offset: 0x00299DE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItemAddNotify()
		{
		}

		// Token: 0x06011D3A RID: 73018 RVA: 0x0029BBFA File Offset: 0x00299DFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItemAddNotify(PhantomItemAddNotify other) : this()
		{
			this.phantomItemList_ = other.phantomItemList_.Clone();
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011D3B RID: 73019 RVA: 0x0029BC30 File Offset: 0x00299E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItemAddNotify Clone()
		{
			return new PhantomItemAddNotify(this);
		}

		// Token: 0x17003B16 RID: 15126
		// (get) Token: 0x06011D3C RID: 73020 RVA: 0x0029BC38 File Offset: 0x00299E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomItem> PhantomItemList
		{
			get
			{
				return this.phantomItemList_;
			}
		}

		// Token: 0x17003B17 RID: 15127
		// (get) Token: 0x06011D3D RID: 73021 RVA: 0x0029BC40 File Offset: 0x00299E40
		// (set) Token: 0x06011D3E RID: 73022 RVA: 0x0029BC48 File Offset: 0x00299E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x06011D3F RID: 73023 RVA: 0x0029BC51 File Offset: 0x00299E51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomItemAddNotify);
		}

		// Token: 0x06011D40 RID: 73024 RVA: 0x0029BC60 File Offset: 0x00299E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomItemAddNotify other)
		{
			return other != null && (other == this || (this.phantomItemList_.Equals(other.phantomItemList_) && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011D41 RID: 73025 RVA: 0x0029BCB0 File Offset: 0x00299EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.phantomItemList_.GetHashCode();
			if (this.Reason != 0)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011D42 RID: 73026 RVA: 0x0029BCFD File Offset: 0x00299EFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011D43 RID: 73027 RVA: 0x0029BD0A File Offset: 0x00299F0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011D44 RID: 73028 RVA: 0x0029BD14 File Offset: 0x00299F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomItemList_.WriteTo(ref output, PhantomItemAddNotify._repeated_phantomItemList_codec);
			if (this.Reason != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Reason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011D45 RID: 73029 RVA: 0x0029BD64 File Offset: 0x00299F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantomItemList_.CalculateSize(PhantomItemAddNotify._repeated_phantomItemList_codec);
			if (this.Reason != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Reason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011D46 RID: 73030 RVA: 0x0029BDB8 File Offset: 0x00299FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomItemAddNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.phantomItemList_.Add(other.phantomItemList_);
			if (other.Reason != 0)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011D47 RID: 73031 RVA: 0x0029BE05 File Offset: 0x0029A005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011D48 RID: 73032 RVA: 0x0029BE10 File Offset: 0x0029A010
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
				if (num != 26U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Reason = input.ReadInt32();
					}
				}
				else
				{
					this.phantomItemList_.AddEntriesFrom(ref input, PhantomItemAddNotify._repeated_phantomItemList_codec);
				}
			}
		}

		// Token: 0x04006FF4 RID: 28660
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006FF5 RID: 28661
		public const int PhantomItemListFieldNumber = 3;

		// Token: 0x04006FF6 RID: 28662
		private static readonly FieldCodec<PhantomItem> _repeated_phantomItemList_codec = FieldCodec.ForMessage<PhantomItem>(26U, PhantomItem.Parser);

		// Token: 0x04006FF7 RID: 28663
		private readonly RepeatedField<PhantomItem> phantomItemList_ = new RepeatedField<PhantomItem>();

		// Token: 0x04006FF8 RID: 28664
		public const int ReasonFieldNumber = 13;

		// Token: 0x04006FF9 RID: 28665
		private int reason_;
	}
}
