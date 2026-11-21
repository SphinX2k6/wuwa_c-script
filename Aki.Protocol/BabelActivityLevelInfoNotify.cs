using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000148 RID: 328
	[NetMessage(EMessageId.BabelActivityLevelInfoNotify)]
	public sealed class BabelActivityLevelInfoNotify : IMessage<BabelActivityLevelInfoNotify>, IMessage, IEquatable<BabelActivityLevelInfoNotify>, IDeepCloneable<BabelActivityLevelInfoNotify>, IBufferMessage
	{
		// Token: 0x06002A6C RID: 10860 RVA: 0x0006F85F File Offset: 0x0006DA5F
		[NullableContext(1)]
		public static BabelActivityLevelInfoNotify Create()
		{
			return new BabelActivityLevelInfoNotify();
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06002A6D RID: 10861 RVA: 0x0006F866 File Offset: 0x0006DA66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06002A6E RID: 10862 RVA: 0x0006F869 File Offset: 0x0006DA69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelActivityLevelInfoNotify.Descriptor;
			}
		}

		// Token: 0x06002A6F RID: 10863 RVA: 0x0006F870 File Offset: 0x0006DA70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityLevelInfoNotify()
		{
		}

		// Token: 0x06002A70 RID: 10864 RVA: 0x0006F883 File Offset: 0x0006DA83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityLevelInfoNotify(BabelActivityLevelInfoNotify other) : this()
		{
			this.babelActivityLevelInfos_ = other.babelActivityLevelInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002A71 RID: 10865 RVA: 0x0006F8AD File Offset: 0x0006DAAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityLevelInfoNotify Clone()
		{
			return new BabelActivityLevelInfoNotify(this);
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06002A72 RID: 10866 RVA: 0x0006F8B5 File Offset: 0x0006DAB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BabelActivityLevelInfo> BabelActivityLevelInfos
		{
			get
			{
				return this.babelActivityLevelInfos_;
			}
		}

		// Token: 0x06002A73 RID: 10867 RVA: 0x0006F8BD File Offset: 0x0006DABD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelActivityLevelInfoNotify);
		}

		// Token: 0x06002A74 RID: 10868 RVA: 0x0006F8CB File Offset: 0x0006DACB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelActivityLevelInfoNotify other)
		{
			return other != null && (other == this || (this.babelActivityLevelInfos_.Equals(other.babelActivityLevelInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002A75 RID: 10869 RVA: 0x0006F900 File Offset: 0x0006DB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.babelActivityLevelInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002A76 RID: 10870 RVA: 0x0006F934 File Offset: 0x0006DB34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002A77 RID: 10871 RVA: 0x0006F941 File Offset: 0x0006DB41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002A78 RID: 10872 RVA: 0x0006F94A File Offset: 0x0006DB4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.babelActivityLevelInfos_.WriteTo(ref output, BabelActivityLevelInfoNotify._repeated_babelActivityLevelInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002A79 RID: 10873 RVA: 0x0006F974 File Offset: 0x0006DB74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.babelActivityLevelInfos_.CalculateSize(BabelActivityLevelInfoNotify._repeated_babelActivityLevelInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002A7A RID: 10874 RVA: 0x0006F9AD File Offset: 0x0006DBAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelActivityLevelInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.babelActivityLevelInfos_.Add(other.babelActivityLevelInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002A7B RID: 10875 RVA: 0x0006F9DB File Offset: 0x0006DBDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002A7C RID: 10876 RVA: 0x0006F9E4 File Offset: 0x0006DBE4
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.babelActivityLevelInfos_.AddEntriesFrom(ref input, BabelActivityLevelInfoNotify._repeated_babelActivityLevelInfos_codec);
				}
			}
		}

		// Token: 0x040027B1 RID: 10161
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027B2 RID: 10162
		public const int BabelActivityLevelInfosFieldNumber = 14;

		// Token: 0x040027B3 RID: 10163
		private static readonly FieldCodec<BabelActivityLevelInfo> _repeated_babelActivityLevelInfos_codec = FieldCodec.ForMessage<BabelActivityLevelInfo>(114U, BabelActivityLevelInfo.Parser);

		// Token: 0x040027B4 RID: 10164
		private readonly RepeatedField<BabelActivityLevelInfo> babelActivityLevelInfos_ = new RepeatedField<BabelActivityLevelInfo>();
	}
}
