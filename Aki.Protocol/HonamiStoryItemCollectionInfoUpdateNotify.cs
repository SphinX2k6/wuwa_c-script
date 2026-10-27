using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200077F RID: 1919
	[NetMessage(EMessageId.HonamiStoryItemCollectionInfoUpdateNotify)]
	public sealed class HonamiStoryItemCollectionInfoUpdateNotify : IMessage<HonamiStoryItemCollectionInfoUpdateNotify>, IMessage, IEquatable<HonamiStoryItemCollectionInfoUpdateNotify>, IDeepCloneable<HonamiStoryItemCollectionInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600AD6C RID: 44396 RVA: 0x001A0EBF File Offset: 0x0019F0BF
		[NullableContext(1)]
		public static HonamiStoryItemCollectionInfoUpdateNotify Create()
		{
			return new HonamiStoryItemCollectionInfoUpdateNotify();
		}

		// Token: 0x170022FC RID: 8956
		// (get) Token: 0x0600AD6D RID: 44397 RVA: 0x001A0EC6 File Offset: 0x0019F0C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022FD RID: 8957
		// (get) Token: 0x0600AD6E RID: 44398 RVA: 0x001A0EC9 File Offset: 0x0019F0C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryItemCollectionInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600AD6F RID: 44399 RVA: 0x001A0ED0 File Offset: 0x0019F0D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemCollectionInfoUpdateNotify()
		{
		}

		// Token: 0x0600AD70 RID: 44400 RVA: 0x001A0EE3 File Offset: 0x0019F0E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemCollectionInfoUpdateNotify(HonamiStoryItemCollectionInfoUpdateNotify other) : this()
		{
			this.honamiStoryItemCollectionInfos_ = other.honamiStoryItemCollectionInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AD71 RID: 44401 RVA: 0x001A0F0D File Offset: 0x0019F10D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemCollectionInfoUpdateNotify Clone()
		{
			return new HonamiStoryItemCollectionInfoUpdateNotify(this);
		}

		// Token: 0x170022FE RID: 8958
		// (get) Token: 0x0600AD72 RID: 44402 RVA: 0x001A0F15 File Offset: 0x0019F115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStoryItemCollectionInfo> HonamiStoryItemCollectionInfos
		{
			get
			{
				return this.honamiStoryItemCollectionInfos_;
			}
		}

		// Token: 0x0600AD73 RID: 44403 RVA: 0x001A0F1D File Offset: 0x0019F11D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryItemCollectionInfoUpdateNotify);
		}

		// Token: 0x0600AD74 RID: 44404 RVA: 0x001A0F2B File Offset: 0x0019F12B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryItemCollectionInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.honamiStoryItemCollectionInfos_.Equals(other.honamiStoryItemCollectionInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AD75 RID: 44405 RVA: 0x001A0F60 File Offset: 0x0019F160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.honamiStoryItemCollectionInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AD76 RID: 44406 RVA: 0x001A0F94 File Offset: 0x0019F194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AD77 RID: 44407 RVA: 0x001A0FA1 File Offset: 0x0019F1A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AD78 RID: 44408 RVA: 0x001A0FAA File Offset: 0x0019F1AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.honamiStoryItemCollectionInfos_.WriteTo(ref output, HonamiStoryItemCollectionInfoUpdateNotify._repeated_honamiStoryItemCollectionInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AD79 RID: 44409 RVA: 0x001A0FD4 File Offset: 0x0019F1D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.honamiStoryItemCollectionInfos_.CalculateSize(HonamiStoryItemCollectionInfoUpdateNotify._repeated_honamiStoryItemCollectionInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AD7A RID: 44410 RVA: 0x001A100D File Offset: 0x0019F20D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryItemCollectionInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.honamiStoryItemCollectionInfos_.Add(other.honamiStoryItemCollectionInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AD7B RID: 44411 RVA: 0x001A103B File Offset: 0x0019F23B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AD7C RID: 44412 RVA: 0x001A1044 File Offset: 0x0019F244
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
					this.honamiStoryItemCollectionInfos_.AddEntriesFrom(ref input, HonamiStoryItemCollectionInfoUpdateNotify._repeated_honamiStoryItemCollectionInfos_codec);
				}
			}
		}

		// Token: 0x04004E72 RID: 20082
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E73 RID: 20083
		public const int HonamiStoryItemCollectionInfosFieldNumber = 14;

		// Token: 0x04004E74 RID: 20084
		private static readonly FieldCodec<HonamiStoryItemCollectionInfo> _repeated_honamiStoryItemCollectionInfos_codec = FieldCodec.ForMessage<HonamiStoryItemCollectionInfo>(114U, HonamiStoryItemCollectionInfo.Parser);

		// Token: 0x04004E75 RID: 20085
		private readonly RepeatedField<HonamiStoryItemCollectionInfo> honamiStoryItemCollectionInfos_ = new RepeatedField<HonamiStoryItemCollectionInfo>();
	}
}
