using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008ED RID: 2285
	[NetMessage(EMessageId.LevelPlayInfoNotify)]
	public sealed class LevelPlayInfoNotify : IMessage<LevelPlayInfoNotify>, IMessage, IEquatable<LevelPlayInfoNotify>, IDeepCloneable<LevelPlayInfoNotify>, IBufferMessage
	{
		// Token: 0x0600CA48 RID: 51784 RVA: 0x001DDEA6 File Offset: 0x001DC0A6
		[NullableContext(1)]
		public static LevelPlayInfoNotify Create()
		{
			return new LevelPlayInfoNotify();
		}

		// Token: 0x170028D4 RID: 10452
		// (get) Token: 0x0600CA49 RID: 51785 RVA: 0x001DDEAD File Offset: 0x001DC0AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028D5 RID: 10453
		// (get) Token: 0x0600CA4A RID: 51786 RVA: 0x001DDEB0 File Offset: 0x001DC0B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600CA4B RID: 51787 RVA: 0x001DDEB7 File Offset: 0x001DC0B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayInfoNotify()
		{
		}

		// Token: 0x0600CA4C RID: 51788 RVA: 0x001DDECA File Offset: 0x001DC0CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayInfoNotify(LevelPlayInfoNotify other) : this()
		{
			this.levelPlayInfo_ = other.levelPlayInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CA4D RID: 51789 RVA: 0x001DDEF4 File Offset: 0x001DC0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayInfoNotify Clone()
		{
			return new LevelPlayInfoNotify(this);
		}

		// Token: 0x170028D6 RID: 10454
		// (get) Token: 0x0600CA4E RID: 51790 RVA: 0x001DDEFC File Offset: 0x001DC0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LevelPlayInfo> LevelPlayInfo
		{
			get
			{
				return this.levelPlayInfo_;
			}
		}

		// Token: 0x0600CA4F RID: 51791 RVA: 0x001DDF04 File Offset: 0x001DC104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayInfoNotify);
		}

		// Token: 0x0600CA50 RID: 51792 RVA: 0x001DDF12 File Offset: 0x001DC112
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayInfoNotify other)
		{
			return other != null && (other == this || (this.levelPlayInfo_.Equals(other.levelPlayInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CA51 RID: 51793 RVA: 0x001DDF48 File Offset: 0x001DC148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.levelPlayInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CA52 RID: 51794 RVA: 0x001DDF7C File Offset: 0x001DC17C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CA53 RID: 51795 RVA: 0x001DDF89 File Offset: 0x001DC189
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CA54 RID: 51796 RVA: 0x001DDF92 File Offset: 0x001DC192
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.levelPlayInfo_.WriteTo(ref output, LevelPlayInfoNotify._repeated_levelPlayInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CA55 RID: 51797 RVA: 0x001DDFBC File Offset: 0x001DC1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.levelPlayInfo_.CalculateSize(LevelPlayInfoNotify._repeated_levelPlayInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CA56 RID: 51798 RVA: 0x001DDFF5 File Offset: 0x001DC1F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.levelPlayInfo_.Add(other.levelPlayInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CA57 RID: 51799 RVA: 0x001DE023 File Offset: 0x001DC223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CA58 RID: 51800 RVA: 0x001DE02C File Offset: 0x001DC22C
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.levelPlayInfo_.AddEntriesFrom(ref input, LevelPlayInfoNotify._repeated_levelPlayInfo_codec);
				}
			}
		}

		// Token: 0x04005670 RID: 22128
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005671 RID: 22129
		public const int LevelPlayInfoFieldNumber = 11;

		// Token: 0x04005672 RID: 22130
		private static readonly FieldCodec<LevelPlayInfo> _repeated_levelPlayInfo_codec = FieldCodec.ForMessage<LevelPlayInfo>(90U, Aki.Protocol.LevelPlayInfo.Parser);

		// Token: 0x04005673 RID: 22131
		private readonly RepeatedField<LevelPlayInfo> levelPlayInfo_ = new RepeatedField<LevelPlayInfo>();
	}
}
