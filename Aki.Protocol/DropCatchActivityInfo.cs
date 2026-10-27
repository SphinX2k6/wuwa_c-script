using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000406 RID: 1030
	public sealed class DropCatchActivityInfo : IMessage<DropCatchActivityInfo>, IMessage, IEquatable<DropCatchActivityInfo>, IDeepCloneable<DropCatchActivityInfo>, IBufferMessage
	{
		// Token: 0x06006367 RID: 25447 RVA: 0x000EF232 File Offset: 0x000ED432
		[NullableContext(1)]
		public static DropCatchActivityInfo Create()
		{
			return new DropCatchActivityInfo();
		}

		// Token: 0x1700128E RID: 4750
		// (get) Token: 0x06006368 RID: 25448 RVA: 0x000EF239 File Offset: 0x000ED439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700128F RID: 4751
		// (get) Token: 0x06006369 RID: 25449 RVA: 0x000EF23C File Offset: 0x000ED43C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DropCatchActivityInfo.Descriptor;
			}
		}

		// Token: 0x0600636A RID: 25450 RVA: 0x000EF243 File Offset: 0x000ED443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchActivityInfo()
		{
		}

		// Token: 0x0600636B RID: 25451 RVA: 0x000EF256 File Offset: 0x000ED456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchActivityInfo(DropCatchActivityInfo other) : this()
		{
			this.dropCatchLevelInfos_ = other.dropCatchLevelInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600636C RID: 25452 RVA: 0x000EF280 File Offset: 0x000ED480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchActivityInfo Clone()
		{
			return new DropCatchActivityInfo(this);
		}

		// Token: 0x17001290 RID: 4752
		// (get) Token: 0x0600636D RID: 25453 RVA: 0x000EF288 File Offset: 0x000ED488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DropCatchLevelInfo> DropCatchLevelInfos
		{
			get
			{
				return this.dropCatchLevelInfos_;
			}
		}

		// Token: 0x0600636E RID: 25454 RVA: 0x000EF290 File Offset: 0x000ED490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DropCatchActivityInfo);
		}

		// Token: 0x0600636F RID: 25455 RVA: 0x000EF29E File Offset: 0x000ED49E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DropCatchActivityInfo other)
		{
			return other != null && (other == this || (this.dropCatchLevelInfos_.Equals(other.dropCatchLevelInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006370 RID: 25456 RVA: 0x000EF2D4 File Offset: 0x000ED4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.dropCatchLevelInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006371 RID: 25457 RVA: 0x000EF308 File Offset: 0x000ED508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006372 RID: 25458 RVA: 0x000EF315 File Offset: 0x000ED515
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006373 RID: 25459 RVA: 0x000EF31E File Offset: 0x000ED51E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dropCatchLevelInfos_.WriteTo(ref output, DropCatchActivityInfo._repeated_dropCatchLevelInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006374 RID: 25460 RVA: 0x000EF348 File Offset: 0x000ED548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.dropCatchLevelInfos_.CalculateSize(DropCatchActivityInfo._repeated_dropCatchLevelInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006375 RID: 25461 RVA: 0x000EF381 File Offset: 0x000ED581
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DropCatchActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.dropCatchLevelInfos_.Add(other.dropCatchLevelInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006376 RID: 25462 RVA: 0x000EF3AF File Offset: 0x000ED5AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006377 RID: 25463 RVA: 0x000EF3B8 File Offset: 0x000ED5B8
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.dropCatchLevelInfos_.AddEntriesFrom(ref input, DropCatchActivityInfo._repeated_dropCatchLevelInfos_codec);
				}
			}
		}

		// Token: 0x04003823 RID: 14371
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003824 RID: 14372
		public const int DropCatchLevelInfosFieldNumber = 1;

		// Token: 0x04003825 RID: 14373
		private static readonly FieldCodec<DropCatchLevelInfo> _repeated_dropCatchLevelInfos_codec = FieldCodec.ForMessage<DropCatchLevelInfo>(10U, DropCatchLevelInfo.Parser);

		// Token: 0x04003826 RID: 14374
		private readonly RepeatedField<DropCatchLevelInfo> dropCatchLevelInfos_ = new RepeatedField<DropCatchLevelInfo>();
	}
}
