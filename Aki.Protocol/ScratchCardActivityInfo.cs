using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200119B RID: 4507
	public sealed class ScratchCardActivityInfo : IMessage<ScratchCardActivityInfo>, IMessage, IEquatable<ScratchCardActivityInfo>, IDeepCloneable<ScratchCardActivityInfo>, IBufferMessage
	{
		// Token: 0x06018045 RID: 98373 RVA: 0x0037CC9B File Offset: 0x0037AE9B
		[NullableContext(1)]
		public static ScratchCardActivityInfo Create()
		{
			return new ScratchCardActivityInfo();
		}

		// Token: 0x170050B4 RID: 20660
		// (get) Token: 0x06018046 RID: 98374 RVA: 0x0037CCA2 File Offset: 0x0037AEA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170050B5 RID: 20661
		// (get) Token: 0x06018047 RID: 98375 RVA: 0x0037CCA5 File Offset: 0x0037AEA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ScratchCardActivityInfo.Descriptor;
			}
		}

		// Token: 0x06018048 RID: 98376 RVA: 0x0037CCAC File Offset: 0x0037AEAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardActivityInfo()
		{
		}

		// Token: 0x06018049 RID: 98377 RVA: 0x0037CCCA File Offset: 0x0037AECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardActivityInfo(ScratchCardActivityInfo other) : this()
		{
			this.roundInfos_ = other.roundInfos_.Clone();
			this.scratchTimeInfos_ = other.scratchTimeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601804A RID: 98378 RVA: 0x0037CD05 File Offset: 0x0037AF05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardActivityInfo Clone()
		{
			return new ScratchCardActivityInfo(this);
		}

		// Token: 0x170050B6 RID: 20662
		// (get) Token: 0x0601804B RID: 98379 RVA: 0x0037CD0D File Offset: 0x0037AF0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ScratchCardRoundInfo> RoundInfos
		{
			get
			{
				return this.roundInfos_;
			}
		}

		// Token: 0x170050B7 RID: 20663
		// (get) Token: 0x0601804C RID: 98380 RVA: 0x0037CD15 File Offset: 0x0037AF15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ScratchCardTimeInfo> ScratchTimeInfos
		{
			get
			{
				return this.scratchTimeInfos_;
			}
		}

		// Token: 0x0601804D RID: 98381 RVA: 0x0037CD1D File Offset: 0x0037AF1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ScratchCardActivityInfo);
		}

		// Token: 0x0601804E RID: 98382 RVA: 0x0037CD2C File Offset: 0x0037AF2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ScratchCardActivityInfo other)
		{
			return other != null && (other == this || (this.roundInfos_.Equals(other.roundInfos_) && this.scratchTimeInfos_.Equals(other.scratchTimeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601804F RID: 98383 RVA: 0x0037CD80 File Offset: 0x0037AF80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.roundInfos_.GetHashCode();
			num ^= this.scratchTimeInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018050 RID: 98384 RVA: 0x0037CDC2 File Offset: 0x0037AFC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018051 RID: 98385 RVA: 0x0037CDCF File Offset: 0x0037AFCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018052 RID: 98386 RVA: 0x0037CDD8 File Offset: 0x0037AFD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roundInfos_.WriteTo(ref output, ScratchCardActivityInfo._repeated_roundInfos_codec);
			this.scratchTimeInfos_.WriteTo(ref output, ScratchCardActivityInfo._repeated_scratchTimeInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018053 RID: 98387 RVA: 0x0037CE10 File Offset: 0x0037B010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roundInfos_.CalculateSize(ScratchCardActivityInfo._repeated_roundInfos_codec);
			num += this.scratchTimeInfos_.CalculateSize(ScratchCardActivityInfo._repeated_scratchTimeInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018054 RID: 98388 RVA: 0x0037CE5C File Offset: 0x0037B05C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ScratchCardActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.roundInfos_.Add(other.roundInfos_);
			this.scratchTimeInfos_.Add(other.scratchTimeInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018055 RID: 98389 RVA: 0x0037CE9B File Offset: 0x0037B09B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018056 RID: 98390 RVA: 0x0037CEA4 File Offset: 0x0037B0A4
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.scratchTimeInfos_.AddEntriesFrom(ref input, ScratchCardActivityInfo._repeated_scratchTimeInfos_codec);
					}
				}
				else
				{
					this.roundInfos_.AddEntriesFrom(ref input, ScratchCardActivityInfo._repeated_roundInfos_codec);
				}
			}
		}

		// Token: 0x04008E34 RID: 36404
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E35 RID: 36405
		public const int RoundInfosFieldNumber = 1;

		// Token: 0x04008E36 RID: 36406
		private static readonly FieldCodec<ScratchCardRoundInfo> _repeated_roundInfos_codec = FieldCodec.ForMessage<ScratchCardRoundInfo>(10U, ScratchCardRoundInfo.Parser);

		// Token: 0x04008E37 RID: 36407
		private readonly RepeatedField<ScratchCardRoundInfo> roundInfos_ = new RepeatedField<ScratchCardRoundInfo>();

		// Token: 0x04008E38 RID: 36408
		public const int ScratchTimeInfosFieldNumber = 2;

		// Token: 0x04008E39 RID: 36409
		private static readonly FieldCodec<ScratchCardTimeInfo> _repeated_scratchTimeInfos_codec = FieldCodec.ForMessage<ScratchCardTimeInfo>(18U, ScratchCardTimeInfo.Parser);

		// Token: 0x04008E3A RID: 36410
		private readonly RepeatedField<ScratchCardTimeInfo> scratchTimeInfos_ = new RepeatedField<ScratchCardTimeInfo>();
	}
}
