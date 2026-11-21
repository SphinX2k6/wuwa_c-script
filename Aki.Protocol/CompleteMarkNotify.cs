using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002C9 RID: 713
	[NetMessage(EMessageId.CompleteMarkNotify)]
	public sealed class CompleteMarkNotify : IMessage<CompleteMarkNotify>, IMessage, IEquatable<CompleteMarkNotify>, IDeepCloneable<CompleteMarkNotify>, IBufferMessage
	{
		// Token: 0x0600497F RID: 18815 RVA: 0x000B4297 File Offset: 0x000B2497
		[NullableContext(1)]
		public static CompleteMarkNotify Create()
		{
			return new CompleteMarkNotify();
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x06004980 RID: 18816 RVA: 0x000B429E File Offset: 0x000B249E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x06004981 RID: 18817 RVA: 0x000B42A1 File Offset: 0x000B24A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CompleteMarkNotify.Descriptor;
			}
		}

		// Token: 0x06004982 RID: 18818 RVA: 0x000B42A8 File Offset: 0x000B24A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CompleteMarkNotify()
		{
		}

		// Token: 0x06004983 RID: 18819 RVA: 0x000B42BB File Offset: 0x000B24BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CompleteMarkNotify(CompleteMarkNotify other) : this()
		{
			this.markIds_ = other.markIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004984 RID: 18820 RVA: 0x000B42E5 File Offset: 0x000B24E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CompleteMarkNotify Clone()
		{
			return new CompleteMarkNotify(this);
		}

		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x06004985 RID: 18821 RVA: 0x000B42ED File Offset: 0x000B24ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MarkIds
		{
			get
			{
				return this.markIds_;
			}
		}

		// Token: 0x06004986 RID: 18822 RVA: 0x000B42F5 File Offset: 0x000B24F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CompleteMarkNotify);
		}

		// Token: 0x06004987 RID: 18823 RVA: 0x000B4303 File Offset: 0x000B2503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CompleteMarkNotify other)
		{
			return other != null && (other == this || (this.markIds_.Equals(other.markIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004988 RID: 18824 RVA: 0x000B4338 File Offset: 0x000B2538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.markIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004989 RID: 18825 RVA: 0x000B436C File Offset: 0x000B256C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600498A RID: 18826 RVA: 0x000B4379 File Offset: 0x000B2579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600498B RID: 18827 RVA: 0x000B4382 File Offset: 0x000B2582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.markIds_.WriteTo(ref output, CompleteMarkNotify._repeated_markIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600498C RID: 18828 RVA: 0x000B43AC File Offset: 0x000B25AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.markIds_.CalculateSize(CompleteMarkNotify._repeated_markIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600498D RID: 18829 RVA: 0x000B43E5 File Offset: 0x000B25E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CompleteMarkNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.markIds_.Add(other.markIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600498E RID: 18830 RVA: 0x000B4413 File Offset: 0x000B2613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600498F RID: 18831 RVA: 0x000B441C File Offset: 0x000B261C
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
				if (num != 80U && num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.markIds_.AddEntriesFrom(ref input, CompleteMarkNotify._repeated_markIds_codec);
				}
			}
		}

		// Token: 0x04003085 RID: 12421
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003086 RID: 12422
		public const int MarkIdsFieldNumber = 10;

		// Token: 0x04003087 RID: 12423
		private static readonly FieldCodec<int> _repeated_markIds_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04003088 RID: 12424
		private readonly RepeatedField<int> markIds_ = new RepeatedField<int>();
	}
}
