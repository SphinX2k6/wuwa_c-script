using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FFA RID: 4090
	[NetMessage(EMessageId.RogueResOpDataNotify)]
	public sealed class RogueResOpDataNotify : IMessage<RogueResOpDataNotify>, IMessage, IEquatable<RogueResOpDataNotify>, IDeepCloneable<RogueResOpDataNotify>, IBufferMessage
	{
		// Token: 0x06015DD8 RID: 89560 RVA: 0x0032D669 File Offset: 0x0032B869
		[NullableContext(1)]
		public static RogueResOpDataNotify Create()
		{
			return new RogueResOpDataNotify();
		}

		// Token: 0x17004904 RID: 18692
		// (get) Token: 0x06015DD9 RID: 89561 RVA: 0x0032D670 File Offset: 0x0032B870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004905 RID: 18693
		// (get) Token: 0x06015DDA RID: 89562 RVA: 0x0032D673 File Offset: 0x0032B873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResOpDataNotify.Descriptor;
			}
		}

		// Token: 0x06015DDB RID: 89563 RVA: 0x0032D67A File Offset: 0x0032B87A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOpDataNotify()
		{
		}

		// Token: 0x06015DDC RID: 89564 RVA: 0x0032D68D File Offset: 0x0032B88D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOpDataNotify(RogueResOpDataNotify other) : this()
		{
			this.rogueResOpDatas_ = other.rogueResOpDatas_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015DDD RID: 89565 RVA: 0x0032D6B7 File Offset: 0x0032B8B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOpDataNotify Clone()
		{
			return new RogueResOpDataNotify(this);
		}

		// Token: 0x17004906 RID: 18694
		// (get) Token: 0x06015DDE RID: 89566 RVA: 0x0032D6BF File Offset: 0x0032B8BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueResOpData> RogueResOpDatas
		{
			get
			{
				return this.rogueResOpDatas_;
			}
		}

		// Token: 0x06015DDF RID: 89567 RVA: 0x0032D6C7 File Offset: 0x0032B8C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResOpDataNotify);
		}

		// Token: 0x06015DE0 RID: 89568 RVA: 0x0032D6D5 File Offset: 0x0032B8D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResOpDataNotify other)
		{
			return other != null && (other == this || (this.rogueResOpDatas_.Equals(other.rogueResOpDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015DE1 RID: 89569 RVA: 0x0032D708 File Offset: 0x0032B908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rogueResOpDatas_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015DE2 RID: 89570 RVA: 0x0032D73C File Offset: 0x0032B93C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015DE3 RID: 89571 RVA: 0x0032D749 File Offset: 0x0032B949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015DE4 RID: 89572 RVA: 0x0032D752 File Offset: 0x0032B952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rogueResOpDatas_.WriteTo(ref output, RogueResOpDataNotify._repeated_rogueResOpDatas_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015DE5 RID: 89573 RVA: 0x0032D77C File Offset: 0x0032B97C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rogueResOpDatas_.CalculateSize(RogueResOpDataNotify._repeated_rogueResOpDatas_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015DE6 RID: 89574 RVA: 0x0032D7B5 File Offset: 0x0032B9B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResOpDataNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.rogueResOpDatas_.Add(other.rogueResOpDatas_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015DE7 RID: 89575 RVA: 0x0032D7E3 File Offset: 0x0032B9E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015DE8 RID: 89576 RVA: 0x0032D7EC File Offset: 0x0032B9EC
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rogueResOpDatas_.AddEntriesFrom(ref input, RogueResOpDataNotify._repeated_rogueResOpDatas_codec);
				}
			}
		}

		// Token: 0x04008326 RID: 33574
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008327 RID: 33575
		public const int RogueResOpDatasFieldNumber = 14;

		// Token: 0x04008328 RID: 33576
		private static readonly FieldCodec<RogueResOpData> _repeated_rogueResOpDatas_codec = FieldCodec.ForMessage<RogueResOpData>(114U, RogueResOpData.Parser);

		// Token: 0x04008329 RID: 33577
		private readonly RepeatedField<RogueResOpData> rogueResOpDatas_ = new RepeatedField<RogueResOpData>();
	}
}
