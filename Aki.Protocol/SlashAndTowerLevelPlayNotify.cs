using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001287 RID: 4743
	[NetMessage(EMessageId.SlashAndTowerLevelPlayNotify)]
	public sealed class SlashAndTowerLevelPlayNotify : IMessage<SlashAndTowerLevelPlayNotify>, IMessage, IEquatable<SlashAndTowerLevelPlayNotify>, IDeepCloneable<SlashAndTowerLevelPlayNotify>, IBufferMessage
	{
		// Token: 0x0601951D RID: 103709 RVA: 0x003B179D File Offset: 0x003AF99D
		[NullableContext(1)]
		public static SlashAndTowerLevelPlayNotify Create()
		{
			return new SlashAndTowerLevelPlayNotify();
		}

		// Token: 0x170055A5 RID: 21925
		// (get) Token: 0x0601951E RID: 103710 RVA: 0x003B17A4 File Offset: 0x003AF9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055A6 RID: 21926
		// (get) Token: 0x0601951F RID: 103711 RVA: 0x003B17A7 File Offset: 0x003AF9A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SlashAndTowerLevelPlayNotify.Descriptor;
			}
		}

		// Token: 0x06019520 RID: 103712 RVA: 0x003B17AE File Offset: 0x003AF9AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerLevelPlayNotify()
		{
		}

		// Token: 0x06019521 RID: 103713 RVA: 0x003B17C1 File Offset: 0x003AF9C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerLevelPlayNotify(SlashAndTowerLevelPlayNotify other) : this()
		{
			this.slashLevelPlayInfos_ = other.slashLevelPlayInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019522 RID: 103714 RVA: 0x003B17EB File Offset: 0x003AF9EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerLevelPlayNotify Clone()
		{
			return new SlashAndTowerLevelPlayNotify(this);
		}

		// Token: 0x170055A7 RID: 21927
		// (get) Token: 0x06019523 RID: 103715 RVA: 0x003B17F3 File Offset: 0x003AF9F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SlashLevelPlayInfo> SlashLevelPlayInfos
		{
			get
			{
				return this.slashLevelPlayInfos_;
			}
		}

		// Token: 0x06019524 RID: 103716 RVA: 0x003B17FB File Offset: 0x003AF9FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SlashAndTowerLevelPlayNotify);
		}

		// Token: 0x06019525 RID: 103717 RVA: 0x003B1809 File Offset: 0x003AFA09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SlashAndTowerLevelPlayNotify other)
		{
			return other != null && (other == this || (this.slashLevelPlayInfos_.Equals(other.slashLevelPlayInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019526 RID: 103718 RVA: 0x003B183C File Offset: 0x003AFA3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.slashLevelPlayInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019527 RID: 103719 RVA: 0x003B1870 File Offset: 0x003AFA70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019528 RID: 103720 RVA: 0x003B187D File Offset: 0x003AFA7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019529 RID: 103721 RVA: 0x003B1886 File Offset: 0x003AFA86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.slashLevelPlayInfos_.WriteTo(ref output, SlashAndTowerLevelPlayNotify._repeated_slashLevelPlayInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601952A RID: 103722 RVA: 0x003B18B0 File Offset: 0x003AFAB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.slashLevelPlayInfos_.CalculateSize(SlashAndTowerLevelPlayNotify._repeated_slashLevelPlayInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601952B RID: 103723 RVA: 0x003B18E9 File Offset: 0x003AFAE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SlashAndTowerLevelPlayNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.slashLevelPlayInfos_.Add(other.slashLevelPlayInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601952C RID: 103724 RVA: 0x003B1917 File Offset: 0x003AFB17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601952D RID: 103725 RVA: 0x003B1920 File Offset: 0x003AFB20
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
					this.slashLevelPlayInfos_.AddEntriesFrom(ref input, SlashAndTowerLevelPlayNotify._repeated_slashLevelPlayInfos_codec);
				}
			}
		}

		// Token: 0x040095D2 RID: 38354
		private UnknownFieldSet _unknownFields;

		// Token: 0x040095D3 RID: 38355
		public const int SlashLevelPlayInfosFieldNumber = 14;

		// Token: 0x040095D4 RID: 38356
		private static readonly FieldCodec<SlashLevelPlayInfo> _repeated_slashLevelPlayInfos_codec = FieldCodec.ForMessage<SlashLevelPlayInfo>(114U, SlashLevelPlayInfo.Parser);

		// Token: 0x040095D5 RID: 38357
		private readonly RepeatedField<SlashLevelPlayInfo> slashLevelPlayInfos_ = new RepeatedField<SlashLevelPlayInfo>();
	}
}
