using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000966 RID: 2406
	[NetMessage(EMessageId.LordGymUnlockNotify)]
	public sealed class LordGymUnlockNotify : IMessage<LordGymUnlockNotify>, IMessage, IEquatable<LordGymUnlockNotify>, IDeepCloneable<LordGymUnlockNotify>, IBufferMessage
	{
		// Token: 0x0600D3F2 RID: 54258 RVA: 0x001F3985 File Offset: 0x001F1B85
		[NullableContext(1)]
		public static LordGymUnlockNotify Create()
		{
			return new LordGymUnlockNotify();
		}

		// Token: 0x17002AEF RID: 10991
		// (get) Token: 0x0600D3F3 RID: 54259 RVA: 0x001F398C File Offset: 0x001F1B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002AF0 RID: 10992
		// (get) Token: 0x0600D3F4 RID: 54260 RVA: 0x001F398F File Offset: 0x001F1B8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LordGymUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0600D3F5 RID: 54261 RVA: 0x001F3996 File Offset: 0x001F1B96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymUnlockNotify()
		{
		}

		// Token: 0x0600D3F6 RID: 54262 RVA: 0x001F39A9 File Offset: 0x001F1BA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymUnlockNotify(LordGymUnlockNotify other) : this()
		{
			this.unlockLoadGymIds_ = other.unlockLoadGymIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D3F7 RID: 54263 RVA: 0x001F39D3 File Offset: 0x001F1BD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymUnlockNotify Clone()
		{
			return new LordGymUnlockNotify(this);
		}

		// Token: 0x17002AF1 RID: 10993
		// (get) Token: 0x0600D3F8 RID: 54264 RVA: 0x001F39DB File Offset: 0x001F1BDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockLoadGymIds
		{
			get
			{
				return this.unlockLoadGymIds_;
			}
		}

		// Token: 0x0600D3F9 RID: 54265 RVA: 0x001F39E3 File Offset: 0x001F1BE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LordGymUnlockNotify);
		}

		// Token: 0x0600D3FA RID: 54266 RVA: 0x001F39F1 File Offset: 0x001F1BF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LordGymUnlockNotify other)
		{
			return other != null && (other == this || (this.unlockLoadGymIds_.Equals(other.unlockLoadGymIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D3FB RID: 54267 RVA: 0x001F3A24 File Offset: 0x001F1C24
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

		// Token: 0x0600D3FC RID: 54268 RVA: 0x001F3A58 File Offset: 0x001F1C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D3FD RID: 54269 RVA: 0x001F3A65 File Offset: 0x001F1C65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D3FE RID: 54270 RVA: 0x001F3A6E File Offset: 0x001F1C6E
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

		// Token: 0x0600D3FF RID: 54271 RVA: 0x001F3A98 File Offset: 0x001F1C98
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

		// Token: 0x0600D400 RID: 54272 RVA: 0x001F3AD1 File Offset: 0x001F1CD1
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

		// Token: 0x0600D401 RID: 54273 RVA: 0x001F3AFF File Offset: 0x001F1CFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D402 RID: 54274 RVA: 0x001F3B08 File Offset: 0x001F1D08
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
					this.unlockLoadGymIds_.AddEntriesFrom(ref input, LordGymUnlockNotify._repeated_unlockLoadGymIds_codec);
				}
			}
		}

		// Token: 0x04005907 RID: 22791
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005908 RID: 22792
		public const int UnlockLoadGymIdsFieldNumber = 5;

		// Token: 0x04005909 RID: 22793
		private static readonly FieldCodec<int> _repeated_unlockLoadGymIds_codec = FieldCodec.ForInt32(42U);

		// Token: 0x0400590A RID: 22794
		private readonly RepeatedField<int> unlockLoadGymIds_ = new RepeatedField<int>();
	}
}
