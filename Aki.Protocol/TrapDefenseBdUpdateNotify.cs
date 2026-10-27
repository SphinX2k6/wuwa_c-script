using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200140C RID: 5132
	[NetMessage(EMessageId.TrapDefenseBdUpdateNotify)]
	public sealed class TrapDefenseBdUpdateNotify : IMessage<TrapDefenseBdUpdateNotify>, IMessage, IEquatable<TrapDefenseBdUpdateNotify>, IDeepCloneable<TrapDefenseBdUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601B341 RID: 111425 RVA: 0x003F13C9 File Offset: 0x003EF5C9
		[NullableContext(1)]
		public static TrapDefenseBdUpdateNotify Create()
		{
			return new TrapDefenseBdUpdateNotify();
		}

		// Token: 0x17005BC0 RID: 23488
		// (get) Token: 0x0601B342 RID: 111426 RVA: 0x003F13D0 File Offset: 0x003EF5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BC1 RID: 23489
		// (get) Token: 0x0601B343 RID: 111427 RVA: 0x003F13D3 File Offset: 0x003EF5D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseBdUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601B344 RID: 111428 RVA: 0x003F13DA File Offset: 0x003EF5DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBdUpdateNotify()
		{
		}

		// Token: 0x0601B345 RID: 111429 RVA: 0x003F13ED File Offset: 0x003EF5ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBdUpdateNotify(TrapDefenseBdUpdateNotify other) : this()
		{
			this.unlockBds_ = other.unlockBds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B346 RID: 111430 RVA: 0x003F1417 File Offset: 0x003EF617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBdUpdateNotify Clone()
		{
			return new TrapDefenseBdUpdateNotify(this);
		}

		// Token: 0x17005BC2 RID: 23490
		// (get) Token: 0x0601B347 RID: 111431 RVA: 0x003F141F File Offset: 0x003EF61F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockBds
		{
			get
			{
				return this.unlockBds_;
			}
		}

		// Token: 0x0601B348 RID: 111432 RVA: 0x003F1427 File Offset: 0x003EF627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseBdUpdateNotify);
		}

		// Token: 0x0601B349 RID: 111433 RVA: 0x003F1435 File Offset: 0x003EF635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseBdUpdateNotify other)
		{
			return other != null && (other == this || (this.unlockBds_.Equals(other.unlockBds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B34A RID: 111434 RVA: 0x003F1468 File Offset: 0x003EF668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockBds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B34B RID: 111435 RVA: 0x003F149C File Offset: 0x003EF69C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B34C RID: 111436 RVA: 0x003F14A9 File Offset: 0x003EF6A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B34D RID: 111437 RVA: 0x003F14B2 File Offset: 0x003EF6B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockBds_.WriteTo(ref output, TrapDefenseBdUpdateNotify._repeated_unlockBds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B34E RID: 111438 RVA: 0x003F14DC File Offset: 0x003EF6DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockBds_.CalculateSize(TrapDefenseBdUpdateNotify._repeated_unlockBds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B34F RID: 111439 RVA: 0x003F1515 File Offset: 0x003EF715
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseBdUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockBds_.Add(other.unlockBds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B350 RID: 111440 RVA: 0x003F1543 File Offset: 0x003EF743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B351 RID: 111441 RVA: 0x003F154C File Offset: 0x003EF74C
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
				if (num != 32U && num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unlockBds_.AddEntriesFrom(ref input, TrapDefenseBdUpdateNotify._repeated_unlockBds_codec);
				}
			}
		}

		// Token: 0x04009D60 RID: 40288
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D61 RID: 40289
		public const int UnlockBdsFieldNumber = 4;

		// Token: 0x04009D62 RID: 40290
		private static readonly FieldCodec<int> _repeated_unlockBds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04009D63 RID: 40291
		private readonly RepeatedField<int> unlockBds_ = new RepeatedField<int>();
	}
}
