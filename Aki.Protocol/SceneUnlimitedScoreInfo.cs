using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001195 RID: 4501
	public sealed class SceneUnlimitedScoreInfo : IMessage<SceneUnlimitedScoreInfo>, IMessage, IEquatable<SceneUnlimitedScoreInfo>, IDeepCloneable<SceneUnlimitedScoreInfo>, IBufferMessage
	{
		// Token: 0x06017FD0 RID: 98256 RVA: 0x0037BE2E File Offset: 0x0037A02E
		[NullableContext(1)]
		public static SceneUnlimitedScoreInfo Create()
		{
			return new SceneUnlimitedScoreInfo();
		}

		// Token: 0x1700509D RID: 20637
		// (get) Token: 0x06017FD1 RID: 98257 RVA: 0x0037BE35 File Offset: 0x0037A035
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneUnlimitedScoreInfo> Parser
		{
			get
			{
				return SceneUnlimitedScoreInfo._parser;
			}
		}

		// Token: 0x1700509E RID: 20638
		// (get) Token: 0x06017FD2 RID: 98258 RVA: 0x0037BE3C File Offset: 0x0037A03C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700509F RID: 20639
		// (get) Token: 0x06017FD3 RID: 98259 RVA: 0x0037BE3F File Offset: 0x0037A03F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneUnlimitedScoreInfo.Descriptor;
			}
		}

		// Token: 0x06017FD4 RID: 98260 RVA: 0x0037BE46 File Offset: 0x0037A046
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneUnlimitedScoreInfo()
		{
		}

		// Token: 0x06017FD5 RID: 98261 RVA: 0x0037BE59 File Offset: 0x0037A059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneUnlimitedScoreInfo(SceneUnlimitedScoreInfo other) : this()
		{
			this.instId_ = other.instId_;
			this.unlimitedScoreInfos_ = other.unlimitedScoreInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017FD6 RID: 98262 RVA: 0x0037BE8F File Offset: 0x0037A08F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneUnlimitedScoreInfo Clone()
		{
			return new SceneUnlimitedScoreInfo(this);
		}

		// Token: 0x170050A0 RID: 20640
		// (get) Token: 0x06017FD7 RID: 98263 RVA: 0x0037BE97 File Offset: 0x0037A097
		// (set) Token: 0x06017FD8 RID: 98264 RVA: 0x0037BE9F File Offset: 0x0037A09F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x170050A1 RID: 20641
		// (get) Token: 0x06017FD9 RID: 98265 RVA: 0x0037BEA8 File Offset: 0x0037A0A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<UnlimitedScoreInfo> UnlimitedScoreInfos
		{
			get
			{
				return this.unlimitedScoreInfos_;
			}
		}

		// Token: 0x06017FDA RID: 98266 RVA: 0x0037BEB0 File Offset: 0x0037A0B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneUnlimitedScoreInfo);
		}

		// Token: 0x06017FDB RID: 98267 RVA: 0x0037BEC0 File Offset: 0x0037A0C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneUnlimitedScoreInfo other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.unlimitedScoreInfos_.Equals(other.unlimitedScoreInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017FDC RID: 98268 RVA: 0x0037BF10 File Offset: 0x0037A110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			num ^= this.unlimitedScoreInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017FDD RID: 98269 RVA: 0x0037BF5D File Offset: 0x0037A15D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017FDE RID: 98270 RVA: 0x0037BF6A File Offset: 0x0037A16A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017FDF RID: 98271 RVA: 0x0037BF74 File Offset: 0x0037A174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InstId);
			}
			this.unlimitedScoreInfos_.WriteTo(ref output, SceneUnlimitedScoreInfo._repeated_unlimitedScoreInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017FE0 RID: 98272 RVA: 0x0037BFC4 File Offset: 0x0037A1C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			num += this.unlimitedScoreInfos_.CalculateSize(SceneUnlimitedScoreInfo._repeated_unlimitedScoreInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017FE1 RID: 98273 RVA: 0x0037C018 File Offset: 0x0037A218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneUnlimitedScoreInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this.unlimitedScoreInfos_.Add(other.unlimitedScoreInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017FE2 RID: 98274 RVA: 0x0037C065 File Offset: 0x0037A265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017FE3 RID: 98275 RVA: 0x0037C070 File Offset: 0x0037A270
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.unlimitedScoreInfos_.AddEntriesFrom(ref input, SceneUnlimitedScoreInfo._repeated_unlimitedScoreInfos_codec);
					}
				}
				else
				{
					this.InstId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008E17 RID: 36375
		private static readonly MessageParser<SceneUnlimitedScoreInfo> _parser = new MessageParser<SceneUnlimitedScoreInfo>(() => new SceneUnlimitedScoreInfo());

		// Token: 0x04008E18 RID: 36376
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E19 RID: 36377
		public const int InstIdFieldNumber = 1;

		// Token: 0x04008E1A RID: 36378
		private int instId_;

		// Token: 0x04008E1B RID: 36379
		public const int UnlimitedScoreInfosFieldNumber = 2;

		// Token: 0x04008E1C RID: 36380
		private static readonly FieldCodec<UnlimitedScoreInfo> _repeated_unlimitedScoreInfos_codec = FieldCodec.ForMessage<UnlimitedScoreInfo>(18U, UnlimitedScoreInfo.Parser);

		// Token: 0x04008E1D RID: 36381
		private readonly RepeatedField<UnlimitedScoreInfo> unlimitedScoreInfos_ = new RepeatedField<UnlimitedScoreInfo>();
	}
}
