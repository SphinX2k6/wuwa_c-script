using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002DA RID: 730
	[NetMessage(EMessageId.ConfirmResourceQuestNotify)]
	public sealed class ConfirmResourceQuestNotify : IMessage<ConfirmResourceQuestNotify>, IMessage, IEquatable<ConfirmResourceQuestNotify>, IDeepCloneable<ConfirmResourceQuestNotify>, IBufferMessage
	{
		// Token: 0x06004AE1 RID: 19169 RVA: 0x000B732D File Offset: 0x000B552D
		[NullableContext(1)]
		public static ConfirmResourceQuestNotify Create()
		{
			return new ConfirmResourceQuestNotify();
		}

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x06004AE2 RID: 19170 RVA: 0x000B7334 File Offset: 0x000B5534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x06004AE3 RID: 19171 RVA: 0x000B7337 File Offset: 0x000B5537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConfirmResourceQuestNotify.Descriptor;
			}
		}

		// Token: 0x06004AE4 RID: 19172 RVA: 0x000B733E File Offset: 0x000B553E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConfirmResourceQuestNotify()
		{
		}

		// Token: 0x06004AE5 RID: 19173 RVA: 0x000B735C File Offset: 0x000B555C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConfirmResourceQuestNotify(ConfirmResourceQuestNotify other) : this()
		{
			this.questIds_ = other.questIds_.Clone();
			this.sceneInfo_ = other.sceneInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004AE6 RID: 19174 RVA: 0x000B7397 File Offset: 0x000B5597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConfirmResourceQuestNotify Clone()
		{
			return new ConfirmResourceQuestNotify(this);
		}

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x06004AE7 RID: 19175 RVA: 0x000B739F File Offset: 0x000B559F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> QuestIds
		{
			get
			{
				return this.questIds_;
			}
		}

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x06004AE8 RID: 19176 RVA: 0x000B73A7 File Offset: 0x000B55A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConfirmResourceSceneInfo> SceneInfo
		{
			get
			{
				return this.sceneInfo_;
			}
		}

		// Token: 0x06004AE9 RID: 19177 RVA: 0x000B73AF File Offset: 0x000B55AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConfirmResourceQuestNotify);
		}

		// Token: 0x06004AEA RID: 19178 RVA: 0x000B73C0 File Offset: 0x000B55C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConfirmResourceQuestNotify other)
		{
			return other != null && (other == this || (this.questIds_.Equals(other.questIds_) && this.sceneInfo_.Equals(other.sceneInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004AEB RID: 19179 RVA: 0x000B7414 File Offset: 0x000B5614
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

		// Token: 0x06004AEC RID: 19180 RVA: 0x000B7456 File Offset: 0x000B5656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004AED RID: 19181 RVA: 0x000B7463 File Offset: 0x000B5663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004AEE RID: 19182 RVA: 0x000B746C File Offset: 0x000B566C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.questIds_.WriteTo(ref output, ConfirmResourceQuestNotify._repeated_questIds_codec);
			this.sceneInfo_.WriteTo(ref output, ConfirmResourceQuestNotify._repeated_sceneInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004AEF RID: 19183 RVA: 0x000B74A4 File Offset: 0x000B56A4
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

		// Token: 0x06004AF0 RID: 19184 RVA: 0x000B74F0 File Offset: 0x000B56F0
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

		// Token: 0x06004AF1 RID: 19185 RVA: 0x000B752F File Offset: 0x000B572F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004AF2 RID: 19186 RVA: 0x000B7538 File Offset: 0x000B5738
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
				if (num != 64U && num != 66U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.sceneInfo_.AddEntriesFrom(ref input, ConfirmResourceQuestNotify._repeated_sceneInfo_codec);
					}
				}
				else
				{
					this.questIds_.AddEntriesFrom(ref input, ConfirmResourceQuestNotify._repeated_questIds_codec);
				}
			}
		}

		// Token: 0x040030F2 RID: 12530
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030F3 RID: 12531
		public const int QuestIdsFieldNumber = 8;

		// Token: 0x040030F4 RID: 12532
		private static readonly FieldCodec<int> _repeated_questIds_codec = FieldCodec.ForInt32(66U);

		// Token: 0x040030F5 RID: 12533
		private readonly RepeatedField<int> questIds_ = new RepeatedField<int>();

		// Token: 0x040030F6 RID: 12534
		public const int SceneInfoFieldNumber = 10;

		// Token: 0x040030F7 RID: 12535
		private static readonly FieldCodec<ConfirmResourceSceneInfo> _repeated_sceneInfo_codec = FieldCodec.ForMessage<ConfirmResourceSceneInfo>(82U, ConfirmResourceSceneInfo.Parser);

		// Token: 0x040030F8 RID: 12536
		private readonly RepeatedField<ConfirmResourceSceneInfo> sceneInfo_ = new RepeatedField<ConfirmResourceSceneInfo>();
	}
}
