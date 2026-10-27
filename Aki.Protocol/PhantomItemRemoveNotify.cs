using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CDF RID: 3295
	[NetMessage(EMessageId.PhantomItemRemoveNotify)]
	public sealed class PhantomItemRemoveNotify : IMessage<PhantomItemRemoveNotify>, IMessage, IEquatable<PhantomItemRemoveNotify>, IDeepCloneable<PhantomItemRemoveNotify>, IBufferMessage
	{
		// Token: 0x06011D4A RID: 73034 RVA: 0x0029BE80 File Offset: 0x0029A080
		[NullableContext(1)]
		public static PhantomItemRemoveNotify Create()
		{
			return new PhantomItemRemoveNotify();
		}

		// Token: 0x17003B18 RID: 15128
		// (get) Token: 0x06011D4B RID: 73035 RVA: 0x0029BE87 File Offset: 0x0029A087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B19 RID: 15129
		// (get) Token: 0x06011D4C RID: 73036 RVA: 0x0029BE8A File Offset: 0x0029A08A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomItemRemoveNotify.Descriptor;
			}
		}

		// Token: 0x06011D4D RID: 73037 RVA: 0x0029BE91 File Offset: 0x0029A091
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItemRemoveNotify()
		{
		}

		// Token: 0x06011D4E RID: 73038 RVA: 0x0029BEA4 File Offset: 0x0029A0A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItemRemoveNotify(PhantomItemRemoveNotify other) : this()
		{
			this.phantomItemIncrIdList_ = other.phantomItemIncrIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011D4F RID: 73039 RVA: 0x0029BECE File Offset: 0x0029A0CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItemRemoveNotify Clone()
		{
			return new PhantomItemRemoveNotify(this);
		}

		// Token: 0x17003B1A RID: 15130
		// (get) Token: 0x06011D50 RID: 73040 RVA: 0x0029BED6 File Offset: 0x0029A0D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PhantomItemIncrIdList
		{
			get
			{
				return this.phantomItemIncrIdList_;
			}
		}

		// Token: 0x06011D51 RID: 73041 RVA: 0x0029BEDE File Offset: 0x0029A0DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomItemRemoveNotify);
		}

		// Token: 0x06011D52 RID: 73042 RVA: 0x0029BEEC File Offset: 0x0029A0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomItemRemoveNotify other)
		{
			return other != null && (other == this || (this.phantomItemIncrIdList_.Equals(other.phantomItemIncrIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011D53 RID: 73043 RVA: 0x0029BF20 File Offset: 0x0029A120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.phantomItemIncrIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011D54 RID: 73044 RVA: 0x0029BF54 File Offset: 0x0029A154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011D55 RID: 73045 RVA: 0x0029BF61 File Offset: 0x0029A161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011D56 RID: 73046 RVA: 0x0029BF6A File Offset: 0x0029A16A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomItemIncrIdList_.WriteTo(ref output, PhantomItemRemoveNotify._repeated_phantomItemIncrIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011D57 RID: 73047 RVA: 0x0029BF94 File Offset: 0x0029A194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantomItemIncrIdList_.CalculateSize(PhantomItemRemoveNotify._repeated_phantomItemIncrIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011D58 RID: 73048 RVA: 0x0029BFCD File Offset: 0x0029A1CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomItemRemoveNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.phantomItemIncrIdList_.Add(other.phantomItemIncrIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011D59 RID: 73049 RVA: 0x0029BFFB File Offset: 0x0029A1FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011D5A RID: 73050 RVA: 0x0029C004 File Offset: 0x0029A204
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
				if (num != 104U && num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.phantomItemIncrIdList_.AddEntriesFrom(ref input, PhantomItemRemoveNotify._repeated_phantomItemIncrIdList_codec);
				}
			}
		}

		// Token: 0x04006FFA RID: 28666
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006FFB RID: 28667
		public const int PhantomItemIncrIdListFieldNumber = 13;

		// Token: 0x04006FFC RID: 28668
		private static readonly FieldCodec<int> _repeated_phantomItemIncrIdList_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04006FFD RID: 28669
		private readonly RepeatedField<int> phantomItemIncrIdList_ = new RepeatedField<int>();
	}
}
