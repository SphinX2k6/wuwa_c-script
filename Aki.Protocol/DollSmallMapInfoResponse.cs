using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003E5 RID: 997
	[NetMessage(EMessageId.DollSmallMapInfoResponse)]
	public sealed class DollSmallMapInfoResponse : IMessage<DollSmallMapInfoResponse>, IMessage, IEquatable<DollSmallMapInfoResponse>, IDeepCloneable<DollSmallMapInfoResponse>, IBufferMessage
	{
		// Token: 0x06006103 RID: 24835 RVA: 0x000EA366 File Offset: 0x000E8566
		[NullableContext(1)]
		public static DollSmallMapInfoResponse Create()
		{
			return new DollSmallMapInfoResponse();
		}

		// Token: 0x1700120A RID: 4618
		// (get) Token: 0x06006104 RID: 24836 RVA: 0x000EA36D File Offset: 0x000E856D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700120B RID: 4619
		// (get) Token: 0x06006105 RID: 24837 RVA: 0x000EA370 File Offset: 0x000E8570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollSmallMapInfoResponse.Descriptor;
			}
		}

		// Token: 0x06006106 RID: 24838 RVA: 0x000EA377 File Offset: 0x000E8577
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollSmallMapInfoResponse()
		{
		}

		// Token: 0x06006107 RID: 24839 RVA: 0x000EA398 File Offset: 0x000E8598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollSmallMapInfoResponse(DollSmallMapInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.sceneUnlimitedScoreInfos_ = other.sceneUnlimitedScoreInfos_.Clone();
			this.sceneDollDeliveryInfos_ = other.sceneDollDeliveryInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006108 RID: 24840 RVA: 0x000EA3EA File Offset: 0x000E85EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollSmallMapInfoResponse Clone()
		{
			return new DollSmallMapInfoResponse(this);
		}

		// Token: 0x1700120C RID: 4620
		// (get) Token: 0x06006109 RID: 24841 RVA: 0x000EA3F2 File Offset: 0x000E85F2
		// (set) Token: 0x0600610A RID: 24842 RVA: 0x000EA3FA File Offset: 0x000E85FA
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

		// Token: 0x1700120D RID: 4621
		// (get) Token: 0x0600610B RID: 24843 RVA: 0x000EA403 File Offset: 0x000E8603
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneUnlimitedScoreInfo> SceneUnlimitedScoreInfos
		{
			get
			{
				return this.sceneUnlimitedScoreInfos_;
			}
		}

		// Token: 0x1700120E RID: 4622
		// (get) Token: 0x0600610C RID: 24844 RVA: 0x000EA40B File Offset: 0x000E860B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneDollDeliveryInfo> SceneDollDeliveryInfos
		{
			get
			{
				return this.sceneDollDeliveryInfos_;
			}
		}

		// Token: 0x0600610D RID: 24845 RVA: 0x000EA413 File Offset: 0x000E8613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollSmallMapInfoResponse);
		}

		// Token: 0x0600610E RID: 24846 RVA: 0x000EA424 File Offset: 0x000E8624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollSmallMapInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.sceneUnlimitedScoreInfos_.Equals(other.sceneUnlimitedScoreInfos_) && this.sceneDollDeliveryInfos_.Equals(other.sceneDollDeliveryInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600610F RID: 24847 RVA: 0x000EA488 File Offset: 0x000E8688
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

		// Token: 0x06006110 RID: 24848 RVA: 0x000EA4E9 File Offset: 0x000E86E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006111 RID: 24849 RVA: 0x000EA4F6 File Offset: 0x000E86F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006112 RID: 24850 RVA: 0x000EA500 File Offset: 0x000E8700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.sceneDollDeliveryInfos_.WriteTo(ref output, DollSmallMapInfoResponse._repeated_sceneDollDeliveryInfos_codec);
			this.sceneUnlimitedScoreInfos_.WriteTo(ref output, DollSmallMapInfoResponse._repeated_sceneUnlimitedScoreInfos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006113 RID: 24851 RVA: 0x000EA560 File Offset: 0x000E8760
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

		// Token: 0x06006114 RID: 24852 RVA: 0x000EA5C4 File Offset: 0x000E87C4
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

		// Token: 0x06006115 RID: 24853 RVA: 0x000EA622 File Offset: 0x000E8822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006116 RID: 24854 RVA: 0x000EA62C File Offset: 0x000E882C
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
				if (num != 66U)
				{
					if (num != 98U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ErrorCode = (ErrorCode)input.ReadEnum();
						}
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
		}

		// Token: 0x040037CE RID: 14286
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037CF RID: 14287
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x040037D0 RID: 14288
		private ErrorCode errorCode_;

		// Token: 0x040037D1 RID: 14289
		public const int SceneUnlimitedScoreInfosFieldNumber = 12;

		// Token: 0x040037D2 RID: 14290
		private static readonly FieldCodec<SceneUnlimitedScoreInfo> _repeated_sceneUnlimitedScoreInfos_codec = FieldCodec.ForMessage<SceneUnlimitedScoreInfo>(98U, SceneUnlimitedScoreInfo.Parser);

		// Token: 0x040037D3 RID: 14291
		private readonly RepeatedField<SceneUnlimitedScoreInfo> sceneUnlimitedScoreInfos_ = new RepeatedField<SceneUnlimitedScoreInfo>();

		// Token: 0x040037D4 RID: 14292
		public const int SceneDollDeliveryInfosFieldNumber = 8;

		// Token: 0x040037D5 RID: 14293
		private static readonly FieldCodec<SceneDollDeliveryInfo> _repeated_sceneDollDeliveryInfos_codec = FieldCodec.ForMessage<SceneDollDeliveryInfo>(66U, SceneDollDeliveryInfo.Parser);

		// Token: 0x040037D6 RID: 14294
		private readonly RepeatedField<SceneDollDeliveryInfo> sceneDollDeliveryInfos_ = new RepeatedField<SceneDollDeliveryInfo>();
	}
}
