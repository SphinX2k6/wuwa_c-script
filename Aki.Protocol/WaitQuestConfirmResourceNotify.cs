using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200155D RID: 5469
	[NetMessage(EMessageId.WaitQuestConfirmResourceNotify)]
	public sealed class WaitQuestConfirmResourceNotify : IMessage<WaitQuestConfirmResourceNotify>, IMessage, IEquatable<WaitQuestConfirmResourceNotify>, IDeepCloneable<WaitQuestConfirmResourceNotify>, IBufferMessage
	{
		// Token: 0x0601CF78 RID: 118648 RVA: 0x004325B5 File Offset: 0x004307B5
		[NullableContext(1)]
		public static WaitQuestConfirmResourceNotify Create()
		{
			return new WaitQuestConfirmResourceNotify();
		}

		// Token: 0x17006204 RID: 25092
		// (get) Token: 0x0601CF79 RID: 118649 RVA: 0x004325BC File Offset: 0x004307BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006205 RID: 25093
		// (get) Token: 0x0601CF7A RID: 118650 RVA: 0x004325BF File Offset: 0x004307BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WaitQuestConfirmResourceNotify.Descriptor;
			}
		}

		// Token: 0x0601CF7B RID: 118651 RVA: 0x004325C6 File Offset: 0x004307C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WaitQuestConfirmResourceNotify()
		{
		}

		// Token: 0x0601CF7C RID: 118652 RVA: 0x004325D9 File Offset: 0x004307D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WaitQuestConfirmResourceNotify(WaitQuestConfirmResourceNotify other) : this()
		{
			this.lackResourceQuestIds_ = other.lackResourceQuestIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CF7D RID: 118653 RVA: 0x00432603 File Offset: 0x00430803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WaitQuestConfirmResourceNotify Clone()
		{
			return new WaitQuestConfirmResourceNotify(this);
		}

		// Token: 0x17006206 RID: 25094
		// (get) Token: 0x0601CF7E RID: 118654 RVA: 0x0043260B File Offset: 0x0043080B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> LackResourceQuestIds
		{
			get
			{
				return this.lackResourceQuestIds_;
			}
		}

		// Token: 0x0601CF7F RID: 118655 RVA: 0x00432613 File Offset: 0x00430813
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WaitQuestConfirmResourceNotify);
		}

		// Token: 0x0601CF80 RID: 118656 RVA: 0x00432621 File Offset: 0x00430821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WaitQuestConfirmResourceNotify other)
		{
			return other != null && (other == this || (this.lackResourceQuestIds_.Equals(other.lackResourceQuestIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CF81 RID: 118657 RVA: 0x00432654 File Offset: 0x00430854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.lackResourceQuestIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CF82 RID: 118658 RVA: 0x00432688 File Offset: 0x00430888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CF83 RID: 118659 RVA: 0x00432695 File Offset: 0x00430895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CF84 RID: 118660 RVA: 0x0043269E File Offset: 0x0043089E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.lackResourceQuestIds_.WriteTo(ref output, WaitQuestConfirmResourceNotify._repeated_lackResourceQuestIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CF85 RID: 118661 RVA: 0x004326C8 File Offset: 0x004308C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.lackResourceQuestIds_.CalculateSize(WaitQuestConfirmResourceNotify._repeated_lackResourceQuestIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CF86 RID: 118662 RVA: 0x00432701 File Offset: 0x00430901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WaitQuestConfirmResourceNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.lackResourceQuestIds_.Add(other.lackResourceQuestIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CF87 RID: 118663 RVA: 0x0043272F File Offset: 0x0043092F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CF88 RID: 118664 RVA: 0x00432738 File Offset: 0x00430938
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
				if (num != 40U && num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.lackResourceQuestIds_.AddEntriesFrom(ref input, WaitQuestConfirmResourceNotify._repeated_lackResourceQuestIds_codec);
				}
			}
		}

		// Token: 0x0400A680 RID: 42624
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A681 RID: 42625
		public const int LackResourceQuestIdsFieldNumber = 5;

		// Token: 0x0400A682 RID: 42626
		private static readonly FieldCodec<int> _repeated_lackResourceQuestIds_codec = FieldCodec.ForInt32(42U);

		// Token: 0x0400A683 RID: 42627
		private readonly RepeatedField<int> lackResourceQuestIds_ = new RepeatedField<int>();
	}
}
