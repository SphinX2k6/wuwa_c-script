using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200079F RID: 1951
	[NetMessage(EMessageId.HonamiStoryScoreRewardInfoUpdateNotify)]
	public sealed class HonamiStoryScoreRewardInfoUpdateNotify : IMessage<HonamiStoryScoreRewardInfoUpdateNotify>, IMessage, IEquatable<HonamiStoryScoreRewardInfoUpdateNotify>, IDeepCloneable<HonamiStoryScoreRewardInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600AFE9 RID: 45033 RVA: 0x001A6077 File Offset: 0x001A4277
		[NullableContext(1)]
		public static HonamiStoryScoreRewardInfoUpdateNotify Create()
		{
			return new HonamiStoryScoreRewardInfoUpdateNotify();
		}

		// Token: 0x1700237C RID: 9084
		// (get) Token: 0x0600AFEA RID: 45034 RVA: 0x001A607E File Offset: 0x001A427E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700237D RID: 9085
		// (get) Token: 0x0600AFEB RID: 45035 RVA: 0x001A6081 File Offset: 0x001A4281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryScoreRewardInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600AFEC RID: 45036 RVA: 0x001A6088 File Offset: 0x001A4288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryScoreRewardInfoUpdateNotify()
		{
		}

		// Token: 0x0600AFED RID: 45037 RVA: 0x001A609B File Offset: 0x001A429B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryScoreRewardInfoUpdateNotify(HonamiStoryScoreRewardInfoUpdateNotify other) : this()
		{
			this.honamiStoryScoreRewardInfos_ = other.honamiStoryScoreRewardInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AFEE RID: 45038 RVA: 0x001A60C5 File Offset: 0x001A42C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryScoreRewardInfoUpdateNotify Clone()
		{
			return new HonamiStoryScoreRewardInfoUpdateNotify(this);
		}

		// Token: 0x1700237E RID: 9086
		// (get) Token: 0x0600AFEF RID: 45039 RVA: 0x001A60CD File Offset: 0x001A42CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStoryScoreRewardInfo> HonamiStoryScoreRewardInfos
		{
			get
			{
				return this.honamiStoryScoreRewardInfos_;
			}
		}

		// Token: 0x0600AFF0 RID: 45040 RVA: 0x001A60D5 File Offset: 0x001A42D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryScoreRewardInfoUpdateNotify);
		}

		// Token: 0x0600AFF1 RID: 45041 RVA: 0x001A60E3 File Offset: 0x001A42E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryScoreRewardInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.honamiStoryScoreRewardInfos_.Equals(other.honamiStoryScoreRewardInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AFF2 RID: 45042 RVA: 0x001A6118 File Offset: 0x001A4318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.honamiStoryScoreRewardInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AFF3 RID: 45043 RVA: 0x001A614C File Offset: 0x001A434C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AFF4 RID: 45044 RVA: 0x001A6159 File Offset: 0x001A4359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AFF5 RID: 45045 RVA: 0x001A6162 File Offset: 0x001A4362
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.honamiStoryScoreRewardInfos_.WriteTo(ref output, HonamiStoryScoreRewardInfoUpdateNotify._repeated_honamiStoryScoreRewardInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AFF6 RID: 45046 RVA: 0x001A618C File Offset: 0x001A438C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.honamiStoryScoreRewardInfos_.CalculateSize(HonamiStoryScoreRewardInfoUpdateNotify._repeated_honamiStoryScoreRewardInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AFF7 RID: 45047 RVA: 0x001A61C5 File Offset: 0x001A43C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryScoreRewardInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.honamiStoryScoreRewardInfos_.Add(other.honamiStoryScoreRewardInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AFF8 RID: 45048 RVA: 0x001A61F3 File Offset: 0x001A43F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AFF9 RID: 45049 RVA: 0x001A61FC File Offset: 0x001A43FC
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.honamiStoryScoreRewardInfos_.AddEntriesFrom(ref input, HonamiStoryScoreRewardInfoUpdateNotify._repeated_honamiStoryScoreRewardInfos_codec);
				}
			}
		}

		// Token: 0x04004F19 RID: 20249
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F1A RID: 20250
		public const int HonamiStoryScoreRewardInfosFieldNumber = 7;

		// Token: 0x04004F1B RID: 20251
		private static readonly FieldCodec<HonamiStoryScoreRewardInfo> _repeated_honamiStoryScoreRewardInfos_codec = FieldCodec.ForMessage<HonamiStoryScoreRewardInfo>(58U, HonamiStoryScoreRewardInfo.Parser);

		// Token: 0x04004F1C RID: 20252
		private readonly RepeatedField<HonamiStoryScoreRewardInfo> honamiStoryScoreRewardInfos_ = new RepeatedField<HonamiStoryScoreRewardInfo>();
	}
}
