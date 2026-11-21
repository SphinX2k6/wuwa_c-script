using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000575 RID: 1397
	[NetMessage(EMessageId.FishingSkinUnlockNotify)]
	public sealed class FishingSkinUnlockNotify : IMessage<FishingSkinUnlockNotify>, IMessage, IEquatable<FishingSkinUnlockNotify>, IDeepCloneable<FishingSkinUnlockNotify>, IBufferMessage
	{
		// Token: 0x0600821E RID: 33310 RVA: 0x0013A069 File Offset: 0x00138269
		[NullableContext(1)]
		public static FishingSkinUnlockNotify Create()
		{
			return new FishingSkinUnlockNotify();
		}

		// Token: 0x17001953 RID: 6483
		// (get) Token: 0x0600821F RID: 33311 RVA: 0x0013A070 File Offset: 0x00138270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001954 RID: 6484
		// (get) Token: 0x06008220 RID: 33312 RVA: 0x0013A073 File Offset: 0x00138273
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingSkinUnlockNotify.Descriptor;
			}
		}

		// Token: 0x06008221 RID: 33313 RVA: 0x0013A07A File Offset: 0x0013827A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkinUnlockNotify()
		{
		}

		// Token: 0x06008222 RID: 33314 RVA: 0x0013A08D File Offset: 0x0013828D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkinUnlockNotify(FishingSkinUnlockNotify other) : this()
		{
			this.unlockSkins_ = other.unlockSkins_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008223 RID: 33315 RVA: 0x0013A0B7 File Offset: 0x001382B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkinUnlockNotify Clone()
		{
			return new FishingSkinUnlockNotify(this);
		}

		// Token: 0x17001955 RID: 6485
		// (get) Token: 0x06008224 RID: 33316 RVA: 0x0013A0BF File Offset: 0x001382BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockSkins
		{
			get
			{
				return this.unlockSkins_;
			}
		}

		// Token: 0x06008225 RID: 33317 RVA: 0x0013A0C7 File Offset: 0x001382C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingSkinUnlockNotify);
		}

		// Token: 0x06008226 RID: 33318 RVA: 0x0013A0D5 File Offset: 0x001382D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingSkinUnlockNotify other)
		{
			return other != null && (other == this || (this.unlockSkins_.Equals(other.unlockSkins_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008227 RID: 33319 RVA: 0x0013A108 File Offset: 0x00138308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockSkins_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008228 RID: 33320 RVA: 0x0013A13C File Offset: 0x0013833C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008229 RID: 33321 RVA: 0x0013A149 File Offset: 0x00138349
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600822A RID: 33322 RVA: 0x0013A152 File Offset: 0x00138352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockSkins_.WriteTo(ref output, FishingSkinUnlockNotify._repeated_unlockSkins_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600822B RID: 33323 RVA: 0x0013A17C File Offset: 0x0013837C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockSkins_.CalculateSize(FishingSkinUnlockNotify._repeated_unlockSkins_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600822C RID: 33324 RVA: 0x0013A1B5 File Offset: 0x001383B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingSkinUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockSkins_.Add(other.unlockSkins_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600822D RID: 33325 RVA: 0x0013A1E3 File Offset: 0x001383E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600822E RID: 33326 RVA: 0x0013A1EC File Offset: 0x001383EC
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
				if (num != 48U && num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unlockSkins_.AddEntriesFrom(ref input, FishingSkinUnlockNotify._repeated_unlockSkins_codec);
				}
			}
		}

		// Token: 0x04004172 RID: 16754
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004173 RID: 16755
		public const int UnlockSkinsFieldNumber = 6;

		// Token: 0x04004174 RID: 16756
		private static readonly FieldCodec<int> _repeated_unlockSkins_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04004175 RID: 16757
		private readonly RepeatedField<int> unlockSkins_ = new RepeatedField<int>();
	}
}
