using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200022E RID: 558
	[NetMessage(EMessageId.CalabashSkinUpdateNotify)]
	public sealed class CalabashSkinUpdateNotify : IMessage<CalabashSkinUpdateNotify>, IMessage, IEquatable<CalabashSkinUpdateNotify>, IDeepCloneable<CalabashSkinUpdateNotify>, IBufferMessage
	{
		// Token: 0x06003CC4 RID: 15556 RVA: 0x00097190 File Offset: 0x00095390
		[NullableContext(1)]
		public static CalabashSkinUpdateNotify Create()
		{
			return new CalabashSkinUpdateNotify();
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06003CC5 RID: 15557 RVA: 0x00097197 File Offset: 0x00095397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06003CC6 RID: 15558 RVA: 0x0009719A File Offset: 0x0009539A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CalabashSkinUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06003CC7 RID: 15559 RVA: 0x000971A1 File Offset: 0x000953A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashSkinUpdateNotify()
		{
		}

		// Token: 0x06003CC8 RID: 15560 RVA: 0x000971B4 File Offset: 0x000953B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashSkinUpdateNotify(CalabashSkinUpdateNotify other) : this()
		{
			this.skinIds_ = other.skinIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003CC9 RID: 15561 RVA: 0x000971DE File Offset: 0x000953DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashSkinUpdateNotify Clone()
		{
			return new CalabashSkinUpdateNotify(this);
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06003CCA RID: 15562 RVA: 0x000971E6 File Offset: 0x000953E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkinIds
		{
			get
			{
				return this.skinIds_;
			}
		}

		// Token: 0x06003CCB RID: 15563 RVA: 0x000971EE File Offset: 0x000953EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CalabashSkinUpdateNotify);
		}

		// Token: 0x06003CCC RID: 15564 RVA: 0x000971FC File Offset: 0x000953FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CalabashSkinUpdateNotify other)
		{
			return other != null && (other == this || (this.skinIds_.Equals(other.skinIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003CCD RID: 15565 RVA: 0x00097230 File Offset: 0x00095430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.skinIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003CCE RID: 15566 RVA: 0x00097264 File Offset: 0x00095464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003CCF RID: 15567 RVA: 0x00097271 File Offset: 0x00095471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003CD0 RID: 15568 RVA: 0x0009727A File Offset: 0x0009547A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.skinIds_.WriteTo(ref output, CalabashSkinUpdateNotify._repeated_skinIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003CD1 RID: 15569 RVA: 0x000972A4 File Offset: 0x000954A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.skinIds_.CalculateSize(CalabashSkinUpdateNotify._repeated_skinIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003CD2 RID: 15570 RVA: 0x000972DD File Offset: 0x000954DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CalabashSkinUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.skinIds_.Add(other.skinIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003CD3 RID: 15571 RVA: 0x0009730B File Offset: 0x0009550B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003CD4 RID: 15572 RVA: 0x00097314 File Offset: 0x00095514
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
				if (num != 96U && num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.skinIds_.AddEntriesFrom(ref input, CalabashSkinUpdateNotify._repeated_skinIds_codec);
				}
			}
		}

		// Token: 0x04002CD5 RID: 11477
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CD6 RID: 11478
		public const int SkinIdsFieldNumber = 12;

		// Token: 0x04002CD7 RID: 11479
		private static readonly FieldCodec<int> _repeated_skinIds_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04002CD8 RID: 11480
		private readonly RepeatedField<int> skinIds_ = new RepeatedField<int>();
	}
}
