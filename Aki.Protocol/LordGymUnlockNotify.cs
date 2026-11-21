using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000955 RID: 2389
	[NetMessage(EMessageId.LordGymUnlockNotify)]
	public sealed class LordGymUnlockNotify : IMessage<LordGymUnlockNotify>, IMessage, IEquatable<LordGymUnlockNotify>, IDeepCloneable<LordGymUnlockNotify>, IBufferMessage
	{
		// Token: 0x0600D2D8 RID: 53976 RVA: 0x001F179D File Offset: 0x001EF99D
		[NullableContext(1)]
		public static LordGymUnlockNotify Create()
		{
			return new LordGymUnlockNotify();
		}

		// Token: 0x17002AB1 RID: 10929
		// (get) Token: 0x0600D2D9 RID: 53977 RVA: 0x001F17A4 File Offset: 0x001EF9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002AB2 RID: 10930
		// (get) Token: 0x0600D2DA RID: 53978 RVA: 0x001F17A7 File Offset: 0x001EF9A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LordGymUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0600D2DB RID: 53979 RVA: 0x001F17AE File Offset: 0x001EF9AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymUnlockNotify()
		{
		}

		// Token: 0x0600D2DC RID: 53980 RVA: 0x001F17C1 File Offset: 0x001EF9C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymUnlockNotify(LordGymUnlockNotify other) : this()
		{
			this.unlockLoadGymIds_ = other.unlockLoadGymIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D2DD RID: 53981 RVA: 0x001F17EB File Offset: 0x001EF9EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymUnlockNotify Clone()
		{
			return new LordGymUnlockNotify(this);
		}

		// Token: 0x17002AB3 RID: 10931
		// (get) Token: 0x0600D2DE RID: 53982 RVA: 0x001F17F3 File Offset: 0x001EF9F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockLoadGymIds
		{
			get
			{
				return this.unlockLoadGymIds_;
			}
		}

		// Token: 0x0600D2DF RID: 53983 RVA: 0x001F17FB File Offset: 0x001EF9FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LordGymUnlockNotify);
		}

		// Token: 0x0600D2E0 RID: 53984 RVA: 0x001F1809 File Offset: 0x001EFA09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LordGymUnlockNotify other)
		{
			return other != null && (other == this || (this.unlockLoadGymIds_.Equals(other.unlockLoadGymIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D2E1 RID: 53985 RVA: 0x001F183C File Offset: 0x001EFA3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockLoadGymIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D2E2 RID: 53986 RVA: 0x001F1870 File Offset: 0x001EFA70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D2E3 RID: 53987 RVA: 0x001F187D File Offset: 0x001EFA7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D2E4 RID: 53988 RVA: 0x001F1886 File Offset: 0x001EFA86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockLoadGymIds_.WriteTo(ref output, LordGymUnlockNotify._repeated_unlockLoadGymIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D2E5 RID: 53989 RVA: 0x001F18B0 File Offset: 0x001EFAB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockLoadGymIds_.CalculateSize(LordGymUnlockNotify._repeated_unlockLoadGymIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D2E6 RID: 53990 RVA: 0x001F18E9 File Offset: 0x001EFAE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LordGymUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockLoadGymIds_.Add(other.unlockLoadGymIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D2E7 RID: 53991 RVA: 0x001F1917 File Offset: 0x001EFB17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D2E8 RID: 53992 RVA: 0x001F1920 File Offset: 0x001EFB20
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
					this.unlockLoadGymIds_.AddEntriesFrom(ref input, LordGymUnlockNotify._repeated_unlockLoadGymIds_codec);
				}
			}
		}

		// Token: 0x04005910 RID: 22800
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005911 RID: 22801
		public const int UnlockLoadGymIdsFieldNumber = 13;

		// Token: 0x04005912 RID: 22802
		private static readonly FieldCodec<int> _repeated_unlockLoadGymIds_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04005913 RID: 22803
		private readonly RepeatedField<int> unlockLoadGymIds_ = new RepeatedField<int>();
	}
}
