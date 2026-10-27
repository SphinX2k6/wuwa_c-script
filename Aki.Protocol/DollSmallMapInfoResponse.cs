using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003FC RID: 1020
	[NetMessage(EMessageId.DollSmallMapInfoResponse)]
	public sealed class DollSmallMapInfoResponse : IMessage<DollSmallMapInfoResponse>, IMessage, IEquatable<DollSmallMapInfoResponse>, IDeepCloneable<DollSmallMapInfoResponse>, IBufferMessage
	{
		// Token: 0x06006293 RID: 25235 RVA: 0x000ED4DE File Offset: 0x000EB6DE
		[NullableContext(1)]
		public static DollSmallMapInfoResponse Create()
		{
			return new DollSmallMapInfoResponse();
		}

		// Token: 0x1700125F RID: 4703
		// (get) Token: 0x06006294 RID: 25236 RVA: 0x000ED4E5 File Offset: 0x000EB6E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001260 RID: 4704
		// (get) Token: 0x06006295 RID: 25237 RVA: 0x000ED4E8 File Offset: 0x000EB6E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollSmallMapInfoResponse.Descriptor;
			}
		}

		// Token: 0x06006296 RID: 25238 RVA: 0x000ED4EF File Offset: 0x000EB6EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollSmallMapInfoResponse()
		{
		}

		// Token: 0x06006297 RID: 25239 RVA: 0x000ED510 File Offset: 0x000EB710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollSmallMapInfoResponse(DollSmallMapInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.sceneUnlimitedScoreInfos_ = other.sceneUnlimitedScoreInfos_.Clone();
			this.sceneDollDeliveryInfos_ = other.sceneDollDeliveryInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006298 RID: 25240 RVA: 0x000ED562 File Offset: 0x000EB762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollSmallMapInfoResponse Clone()
		{
			return new DollSmallMapInfoResponse(this);
		}

		// Token: 0x17001261 RID: 4705
		// (get) Token: 0x06006299 RID: 25241 RVA: 0x000ED56A File Offset: 0x000EB76A
		// (set) Token: 0x0600629A RID: 25242 RVA: 0x000ED572 File Offset: 0x000EB772
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17001262 RID: 4706
		// (get) Token: 0x0600629B RID: 25243 RVA: 0x000ED57B File Offset: 0x000EB77B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneUnlimitedScoreInfo> SceneUnlimitedScoreInfos
		{
			get
			{
				return this.sceneUnlimitedScoreInfos_;
			}
		}

		// Token: 0x17001263 RID: 4707
		// (get) Token: 0x0600629C RID: 25244 RVA: 0x000ED583 File Offset: 0x000EB783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneDollDeliveryInfo> SceneDollDeliveryInfos
		{
			get
			{
				return this.sceneDollDeliveryInfos_;
			}
		}

		// Token: 0x0600629D RID: 25245 RVA: 0x000ED58B File Offset: 0x000EB78B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollSmallMapInfoResponse);
		}

		// Token: 0x0600629E RID: 25246 RVA: 0x000ED59C File Offset: 0x000EB79C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollSmallMapInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.sceneUnlimitedScoreInfos_.Equals(other.sceneUnlimitedScoreInfos_) && this.sceneDollDeliveryInfos_.Equals(other.sceneDollDeliveryInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600629F RID: 25247 RVA: 0x000ED600 File Offset: 0x000EB800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.sceneUnlimitedScoreInfos_.GetHashCode();
			num ^= this.sceneDollDeliveryInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060062A0 RID: 25248 RVA: 0x000ED661 File Offset: 0x000EB861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060062A1 RID: 25249 RVA: 0x000ED66E File Offset: 0x000EB86E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060062A2 RID: 25250 RVA: 0x000ED678 File Offset: 0x000EB878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.sceneDollDeliveryInfos_.WriteTo(ref output, DollSmallMapInfoResponse._repeated_sceneDollDeliveryInfos_codec);
			this.sceneUnlimitedScoreInfos_.WriteTo(ref output, DollSmallMapInfoResponse._repeated_sceneUnlimitedScoreInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060062A3 RID: 25251 RVA: 0x000ED6D8 File Offset: 0x000EB8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.sceneUnlimitedScoreInfos_.CalculateSize(DollSmallMapInfoResponse._repeated_sceneUnlimitedScoreInfos_codec);
			num += this.sceneDollDeliveryInfos_.CalculateSize(DollSmallMapInfoResponse._repeated_sceneDollDeliveryInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060062A4 RID: 25252 RVA: 0x000ED73C File Offset: 0x000EB93C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DollSmallMapInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.sceneUnlimitedScoreInfos_.Add(other.sceneUnlimitedScoreInfos_);
			this.sceneDollDeliveryInfos_.Add(other.sceneDollDeliveryInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060062A5 RID: 25253 RVA: 0x000ED79A File Offset: 0x000EB99A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060062A6 RID: 25254 RVA: 0x000ED7A4 File Offset: 0x000EB9A4
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
				if (num != 48U)
				{
					if (num != 58U)
					{
						if (num != 106U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.sceneUnlimitedScoreInfos_.AddEntriesFrom(ref input, DollSmallMapInfoResponse._repeated_sceneUnlimitedScoreInfos_codec);
						}
					}
					else
					{
						this.sceneDollDeliveryInfos_.AddEntriesFrom(ref input, DollSmallMapInfoResponse._repeated_sceneDollDeliveryInfos_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040037E1 RID: 14305
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037E2 RID: 14306
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x040037E3 RID: 14307
		private ErrorCode errorCode_;

		// Token: 0x040037E4 RID: 14308
		public const int SceneUnlimitedScoreInfosFieldNumber = 13;

		// Token: 0x040037E5 RID: 14309
		private static readonly FieldCodec<SceneUnlimitedScoreInfo> _repeated_sceneUnlimitedScoreInfos_codec = FieldCodec.ForMessage<SceneUnlimitedScoreInfo>(106U, SceneUnlimitedScoreInfo.Parser);

		// Token: 0x040037E6 RID: 14310
		private readonly RepeatedField<SceneUnlimitedScoreInfo> sceneUnlimitedScoreInfos_ = new RepeatedField<SceneUnlimitedScoreInfo>();

		// Token: 0x040037E7 RID: 14311
		public const int SceneDollDeliveryInfosFieldNumber = 7;

		// Token: 0x040037E8 RID: 14312
		private static readonly FieldCodec<SceneDollDeliveryInfo> _repeated_sceneDollDeliveryInfos_codec = FieldCodec.ForMessage<SceneDollDeliveryInfo>(58U, SceneDollDeliveryInfo.Parser);

		// Token: 0x040037E9 RID: 14313
		private readonly RepeatedField<SceneDollDeliveryInfo> sceneDollDeliveryInfos_ = new RepeatedField<SceneDollDeliveryInfo>();
	}
}
