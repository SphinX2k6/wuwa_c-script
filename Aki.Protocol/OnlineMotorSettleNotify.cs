using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B9C RID: 2972
	[NetMessage(EMessageId.OnlineMotorSettleNotify)]
	public sealed class OnlineMotorSettleNotify : IMessage<OnlineMotorSettleNotify>, IMessage, IEquatable<OnlineMotorSettleNotify>, IDeepCloneable<OnlineMotorSettleNotify>, IBufferMessage
	{
		// Token: 0x060101E1 RID: 66017 RVA: 0x0025A65D File Offset: 0x0025885D
		[NullableContext(1)]
		public static OnlineMotorSettleNotify Create()
		{
			return new OnlineMotorSettleNotify();
		}

		// Token: 0x170034D4 RID: 13524
		// (get) Token: 0x060101E2 RID: 66018 RVA: 0x0025A664 File Offset: 0x00258864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170034D5 RID: 13525
		// (get) Token: 0x060101E3 RID: 66019 RVA: 0x0025A667 File Offset: 0x00258867
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OnlineMotorSettleNotify.Descriptor;
			}
		}

		// Token: 0x060101E4 RID: 66020 RVA: 0x0025A66E File Offset: 0x0025886E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorSettleNotify()
		{
		}

		// Token: 0x060101E5 RID: 66021 RVA: 0x0025A681 File Offset: 0x00258881
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorSettleNotify(OnlineMotorSettleNotify other) : this()
		{
			this.levelId_ = other.levelId_;
			this.settleInfos_ = other.settleInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060101E6 RID: 66022 RVA: 0x0025A6B7 File Offset: 0x002588B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorSettleNotify Clone()
		{
			return new OnlineMotorSettleNotify(this);
		}

		// Token: 0x170034D6 RID: 13526
		// (get) Token: 0x060101E7 RID: 66023 RVA: 0x0025A6BF File Offset: 0x002588BF
		// (set) Token: 0x060101E8 RID: 66024 RVA: 0x0025A6C7 File Offset: 0x002588C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x170034D7 RID: 13527
		// (get) Token: 0x060101E9 RID: 66025 RVA: 0x0025A6D0 File Offset: 0x002588D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OnlineMotorSettleInfo> SettleInfos
		{
			get
			{
				return this.settleInfos_;
			}
		}

		// Token: 0x060101EA RID: 66026 RVA: 0x0025A6D8 File Offset: 0x002588D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OnlineMotorSettleNotify);
		}

		// Token: 0x060101EB RID: 66027 RVA: 0x0025A6E8 File Offset: 0x002588E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OnlineMotorSettleNotify other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.settleInfos_.Equals(other.settleInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060101EC RID: 66028 RVA: 0x0025A738 File Offset: 0x00258938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			num ^= this.settleInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060101ED RID: 66029 RVA: 0x0025A785 File Offset: 0x00258985
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060101EE RID: 66030 RVA: 0x0025A792 File Offset: 0x00258992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060101EF RID: 66031 RVA: 0x0025A79C File Offset: 0x0025899C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LevelId);
			}
			this.settleInfos_.WriteTo(ref output, OnlineMotorSettleNotify._repeated_settleInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060101F0 RID: 66032 RVA: 0x0025A7EC File Offset: 0x002589EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			num += this.settleInfos_.CalculateSize(OnlineMotorSettleNotify._repeated_settleInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060101F1 RID: 66033 RVA: 0x0025A840 File Offset: 0x00258A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OnlineMotorSettleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			this.settleInfos_.Add(other.settleInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060101F2 RID: 66034 RVA: 0x0025A88D File Offset: 0x00258A8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060101F3 RID: 66035 RVA: 0x0025A898 File Offset: 0x00258A98
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
				if (num != 16U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.settleInfos_.AddEntriesFrom(ref input, OnlineMotorSettleNotify._repeated_settleInfos_codec);
					}
				}
				else
				{
					this.LevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040066BF RID: 26303
		private UnknownFieldSet _unknownFields;

		// Token: 0x040066C0 RID: 26304
		public const int LevelIdFieldNumber = 2;

		// Token: 0x040066C1 RID: 26305
		private int levelId_;

		// Token: 0x040066C2 RID: 26306
		public const int SettleInfosFieldNumber = 15;

		// Token: 0x040066C3 RID: 26307
		private static readonly FieldCodec<OnlineMotorSettleInfo> _repeated_settleInfos_codec = FieldCodec.ForMessage<OnlineMotorSettleInfo>(122U, OnlineMotorSettleInfo.Parser);

		// Token: 0x040066C4 RID: 26308
		private readonly RepeatedField<OnlineMotorSettleInfo> settleInfos_ = new RepeatedField<OnlineMotorSettleInfo>();
	}
}
