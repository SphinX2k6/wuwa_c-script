using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008FE RID: 2302
	[NetMessage(EMessageId.LevelPlayInfoNotify)]
	public sealed class LevelPlayInfoNotify : IMessage<LevelPlayInfoNotify>, IMessage, IEquatable<LevelPlayInfoNotify>, IDeepCloneable<LevelPlayInfoNotify>, IBufferMessage
	{
		// Token: 0x0600CB64 RID: 52068 RVA: 0x001E0182 File Offset: 0x001DE382
		[NullableContext(1)]
		public static LevelPlayInfoNotify Create()
		{
			return new LevelPlayInfoNotify();
		}

		// Token: 0x17002913 RID: 10515
		// (get) Token: 0x0600CB65 RID: 52069 RVA: 0x001E0189 File Offset: 0x001DE389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002914 RID: 10516
		// (get) Token: 0x0600CB66 RID: 52070 RVA: 0x001E018C File Offset: 0x001DE38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600CB67 RID: 52071 RVA: 0x001E0193 File Offset: 0x001DE393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayInfoNotify()
		{
		}

		// Token: 0x0600CB68 RID: 52072 RVA: 0x001E01A6 File Offset: 0x001DE3A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayInfoNotify(LevelPlayInfoNotify other) : this()
		{
			this.levelPlayInfo_ = other.levelPlayInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CB69 RID: 52073 RVA: 0x001E01D0 File Offset: 0x001DE3D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayInfoNotify Clone()
		{
			return new LevelPlayInfoNotify(this);
		}

		// Token: 0x17002915 RID: 10517
		// (get) Token: 0x0600CB6A RID: 52074 RVA: 0x001E01D8 File Offset: 0x001DE3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LevelPlayInfo> LevelPlayInfo
		{
			get
			{
				return this.levelPlayInfo_;
			}
		}

		// Token: 0x0600CB6B RID: 52075 RVA: 0x001E01E0 File Offset: 0x001DE3E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayInfoNotify);
		}

		// Token: 0x0600CB6C RID: 52076 RVA: 0x001E01EE File Offset: 0x001DE3EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayInfoNotify other)
		{
			return other != null && (other == this || (this.levelPlayInfo_.Equals(other.levelPlayInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CB6D RID: 52077 RVA: 0x001E0224 File Offset: 0x001DE424
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

		// Token: 0x0600CB6E RID: 52078 RVA: 0x001E0258 File Offset: 0x001DE458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CB6F RID: 52079 RVA: 0x001E0265 File Offset: 0x001DE465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CB70 RID: 52080 RVA: 0x001E026E File Offset: 0x001DE46E
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

		// Token: 0x0600CB71 RID: 52081 RVA: 0x001E0298 File Offset: 0x001DE498
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

		// Token: 0x0600CB72 RID: 52082 RVA: 0x001E02D1 File Offset: 0x001DE4D1
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

		// Token: 0x0600CB73 RID: 52083 RVA: 0x001E02FF File Offset: 0x001DE4FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CB74 RID: 52084 RVA: 0x001E0308 File Offset: 0x001DE508
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.levelPlayInfo_.AddEntriesFrom(ref input, LevelPlayInfoNotify._repeated_levelPlayInfo_codec);
				}
			}
		}

		// Token: 0x04005669 RID: 22121
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400566A RID: 22122
		public const int LevelPlayInfoFieldNumber = 6;

		// Token: 0x0400566B RID: 22123
		private static readonly FieldCodec<LevelPlayInfo> _repeated_levelPlayInfo_codec = FieldCodec.ForMessage<LevelPlayInfo>(50U, Aki.Protocol.LevelPlayInfo.Parser);

		// Token: 0x0400566C RID: 22124
		private readonly RepeatedField<LevelPlayInfo> levelPlayInfo_ = new RepeatedField<LevelPlayInfo>();
	}
}
