using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002D3 RID: 723
	[NetMessage(EMessageId.ConfirmResourceQuestNotify)]
	public sealed class ConfirmResourceQuestNotify : IMessage<ConfirmResourceQuestNotify>, IMessage, IEquatable<ConfirmResourceQuestNotify>, IDeepCloneable<ConfirmResourceQuestNotify>, IBufferMessage
	{
		// Token: 0x06004A08 RID: 18952 RVA: 0x000B4F45 File Offset: 0x000B3145
		[NullableContext(1)]
		public static ConfirmResourceQuestNotify Create()
		{
			return new ConfirmResourceQuestNotify();
		}

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x06004A09 RID: 18953 RVA: 0x000B4F4C File Offset: 0x000B314C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x06004A0A RID: 18954 RVA: 0x000B4F4F File Offset: 0x000B314F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConfirmResourceQuestNotify.Descriptor;
			}
		}

		// Token: 0x06004A0B RID: 18955 RVA: 0x000B4F56 File Offset: 0x000B3156
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConfirmResourceQuestNotify()
		{
		}

		// Token: 0x06004A0C RID: 18956 RVA: 0x000B4F74 File Offset: 0x000B3174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConfirmResourceQuestNotify(ConfirmResourceQuestNotify other) : this()
		{
			this.questIds_ = other.questIds_.Clone();
			this.sceneInfo_ = other.sceneInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004A0D RID: 18957 RVA: 0x000B4FAF File Offset: 0x000B31AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConfirmResourceQuestNotify Clone()
		{
			return new ConfirmResourceQuestNotify(this);
		}

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x06004A0E RID: 18958 RVA: 0x000B4FB7 File Offset: 0x000B31B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> QuestIds
		{
			get
			{
				return this.questIds_;
			}
		}

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x06004A0F RID: 18959 RVA: 0x000B4FBF File Offset: 0x000B31BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConfirmResourceSceneInfo> SceneInfo
		{
			get
			{
				return this.sceneInfo_;
			}
		}

		// Token: 0x06004A10 RID: 18960 RVA: 0x000B4FC7 File Offset: 0x000B31C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConfirmResourceQuestNotify);
		}

		// Token: 0x06004A11 RID: 18961 RVA: 0x000B4FD8 File Offset: 0x000B31D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConfirmResourceQuestNotify other)
		{
			return other != null && (other == this || (this.questIds_.Equals(other.questIds_) && this.sceneInfo_.Equals(other.sceneInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004A12 RID: 18962 RVA: 0x000B502C File Offset: 0x000B322C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.questIds_.GetHashCode();
			num ^= this.sceneInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004A13 RID: 18963 RVA: 0x000B506E File Offset: 0x000B326E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004A14 RID: 18964 RVA: 0x000B507B File Offset: 0x000B327B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004A15 RID: 18965 RVA: 0x000B5084 File Offset: 0x000B3284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.sceneInfo_.WriteTo(ref output, ConfirmResourceQuestNotify._repeated_sceneInfo_codec);
			this.questIds_.WriteTo(ref output, ConfirmResourceQuestNotify._repeated_questIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004A16 RID: 18966 RVA: 0x000B50BC File Offset: 0x000B32BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.questIds_.CalculateSize(ConfirmResourceQuestNotify._repeated_questIds_codec);
			num += this.sceneInfo_.CalculateSize(ConfirmResourceQuestNotify._repeated_sceneInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004A17 RID: 18967 RVA: 0x000B5108 File Offset: 0x000B3308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConfirmResourceQuestNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.questIds_.Add(other.questIds_);
			this.sceneInfo_.Add(other.sceneInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004A18 RID: 18968 RVA: 0x000B5147 File Offset: 0x000B3347
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004A19 RID: 18969 RVA: 0x000B5150 File Offset: 0x000B3350
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
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.questIds_.AddEntriesFrom(ref input, ConfirmResourceQuestNotify._repeated_questIds_codec);
					}
				}
				else
				{
					this.sceneInfo_.AddEntriesFrom(ref input, ConfirmResourceQuestNotify._repeated_sceneInfo_codec);
				}
			}
		}

		// Token: 0x0400305B RID: 12379
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400305C RID: 12380
		public const int QuestIdsFieldNumber = 2;

		// Token: 0x0400305D RID: 12381
		private static readonly FieldCodec<int> _repeated_questIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400305E RID: 12382
		private readonly RepeatedField<int> questIds_ = new RepeatedField<int>();

		// Token: 0x0400305F RID: 12383
		public const int SceneInfoFieldNumber = 1;

		// Token: 0x04003060 RID: 12384
		private static readonly FieldCodec<ConfirmResourceSceneInfo> _repeated_sceneInfo_codec = FieldCodec.ForMessage<ConfirmResourceSceneInfo>(10U, ConfirmResourceSceneInfo.Parser);

		// Token: 0x04003061 RID: 12385
		private readonly RepeatedField<ConfirmResourceSceneInfo> sceneInfo_ = new RepeatedField<ConfirmResourceSceneInfo>();
	}
}
