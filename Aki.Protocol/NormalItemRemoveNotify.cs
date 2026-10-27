using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B5D RID: 2909
	[NetMessage(EMessageId.NormalItemRemoveNotify)]
	public sealed class NormalItemRemoveNotify : IMessage<NormalItemRemoveNotify>, IMessage, IEquatable<NormalItemRemoveNotify>, IDeepCloneable<NormalItemRemoveNotify>, IBufferMessage
	{
		// Token: 0x0600FC22 RID: 64546 RVA: 0x0024BA67 File Offset: 0x00249C67
		[NullableContext(1)]
		public static NormalItemRemoveNotify Create()
		{
			return new NormalItemRemoveNotify();
		}

		// Token: 0x17003368 RID: 13160
		// (get) Token: 0x0600FC23 RID: 64547 RVA: 0x0024BA6E File Offset: 0x00249C6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003369 RID: 13161
		// (get) Token: 0x0600FC24 RID: 64548 RVA: 0x0024BA71 File Offset: 0x00249C71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NormalItemRemoveNotify.Descriptor;
			}
		}

		// Token: 0x0600FC25 RID: 64549 RVA: 0x0024BA78 File Offset: 0x00249C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalItemRemoveNotify()
		{
		}

		// Token: 0x0600FC26 RID: 64550 RVA: 0x0024BA8B File Offset: 0x00249C8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalItemRemoveNotify(NormalItemRemoveNotify other) : this()
		{
			this.normalItemIdList_ = other.normalItemIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FC27 RID: 64551 RVA: 0x0024BAB5 File Offset: 0x00249CB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalItemRemoveNotify Clone()
		{
			return new NormalItemRemoveNotify(this);
		}

		// Token: 0x1700336A RID: 13162
		// (get) Token: 0x0600FC28 RID: 64552 RVA: 0x0024BABD File Offset: 0x00249CBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> NormalItemIdList
		{
			get
			{
				return this.normalItemIdList_;
			}
		}

		// Token: 0x0600FC29 RID: 64553 RVA: 0x0024BAC5 File Offset: 0x00249CC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NormalItemRemoveNotify);
		}

		// Token: 0x0600FC2A RID: 64554 RVA: 0x0024BAD3 File Offset: 0x00249CD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NormalItemRemoveNotify other)
		{
			return other != null && (other == this || (this.normalItemIdList_.Equals(other.normalItemIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FC2B RID: 64555 RVA: 0x0024BB08 File Offset: 0x00249D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.normalItemIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FC2C RID: 64556 RVA: 0x0024BB3C File Offset: 0x00249D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FC2D RID: 64557 RVA: 0x0024BB49 File Offset: 0x00249D49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FC2E RID: 64558 RVA: 0x0024BB52 File Offset: 0x00249D52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.normalItemIdList_.WriteTo(ref output, NormalItemRemoveNotify._repeated_normalItemIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FC2F RID: 64559 RVA: 0x0024BB7C File Offset: 0x00249D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.normalItemIdList_.CalculateSize(NormalItemRemoveNotify._repeated_normalItemIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FC30 RID: 64560 RVA: 0x0024BBB5 File Offset: 0x00249DB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NormalItemRemoveNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.normalItemIdList_.Add(other.normalItemIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FC31 RID: 64561 RVA: 0x0024BBE3 File Offset: 0x00249DE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FC32 RID: 64562 RVA: 0x0024BBEC File Offset: 0x00249DEC
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
				if (num != 64U && num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.normalItemIdList_.AddEntriesFrom(ref input, NormalItemRemoveNotify._repeated_normalItemIdList_codec);
				}
			}
		}

		// Token: 0x040064B4 RID: 25780
		private UnknownFieldSet _unknownFields;

		// Token: 0x040064B5 RID: 25781
		public const int NormalItemIdListFieldNumber = 8;

		// Token: 0x040064B6 RID: 25782
		private static readonly FieldCodec<int> _repeated_normalItemIdList_codec = FieldCodec.ForInt32(66U);

		// Token: 0x040064B7 RID: 25783
		private readonly RepeatedField<int> normalItemIdList_ = new RepeatedField<int>();
	}
}
