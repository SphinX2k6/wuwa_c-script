using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014A8 RID: 5288
	[NetMessage(EMessageId.UpdateSceneGroupDataNotify)]
	public sealed class UpdateSceneGroupDataNotify : IMessage<UpdateSceneGroupDataNotify>, IMessage, IEquatable<UpdateSceneGroupDataNotify>, IDeepCloneable<UpdateSceneGroupDataNotify>, IBufferMessage
	{
		// Token: 0x0601BF75 RID: 114549 RVA: 0x0040AC18 File Offset: 0x00408E18
		[NullableContext(1)]
		public static UpdateSceneGroupDataNotify Create()
		{
			return new UpdateSceneGroupDataNotify();
		}

		// Token: 0x17005E3E RID: 24126
		// (get) Token: 0x0601BF76 RID: 114550 RVA: 0x0040AC1F File Offset: 0x00408E1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E3F RID: 24127
		// (get) Token: 0x0601BF77 RID: 114551 RVA: 0x0040AC22 File Offset: 0x00408E22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateSceneGroupDataNotify.Descriptor;
			}
		}

		// Token: 0x0601BF78 RID: 114552 RVA: 0x0040AC29 File Offset: 0x00408E29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneGroupDataNotify()
		{
		}

		// Token: 0x0601BF79 RID: 114553 RVA: 0x0040AC3C File Offset: 0x00408E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneGroupDataNotify(UpdateSceneGroupDataNotify other) : this()
		{
			this.playerSceneGroupDataList_ = other.playerSceneGroupDataList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BF7A RID: 114554 RVA: 0x0040AC66 File Offset: 0x00408E66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneGroupDataNotify Clone()
		{
			return new UpdateSceneGroupDataNotify(this);
		}

		// Token: 0x17005E40 RID: 24128
		// (get) Token: 0x0601BF7B RID: 114555 RVA: 0x0040AC6E File Offset: 0x00408E6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerSceneGroupDataList> PlayerSceneGroupDataList
		{
			get
			{
				return this.playerSceneGroupDataList_;
			}
		}

		// Token: 0x0601BF7C RID: 114556 RVA: 0x0040AC76 File Offset: 0x00408E76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateSceneGroupDataNotify);
		}

		// Token: 0x0601BF7D RID: 114557 RVA: 0x0040AC84 File Offset: 0x00408E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateSceneGroupDataNotify other)
		{
			return other != null && (other == this || (this.playerSceneGroupDataList_.Equals(other.playerSceneGroupDataList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BF7E RID: 114558 RVA: 0x0040ACB8 File Offset: 0x00408EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.playerSceneGroupDataList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BF7F RID: 114559 RVA: 0x0040ACEC File Offset: 0x00408EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BF80 RID: 114560 RVA: 0x0040ACF9 File Offset: 0x00408EF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BF81 RID: 114561 RVA: 0x0040AD02 File Offset: 0x00408F02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.playerSceneGroupDataList_.WriteTo(ref output, UpdateSceneGroupDataNotify._repeated_playerSceneGroupDataList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BF82 RID: 114562 RVA: 0x0040AD2C File Offset: 0x00408F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.playerSceneGroupDataList_.CalculateSize(UpdateSceneGroupDataNotify._repeated_playerSceneGroupDataList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BF83 RID: 114563 RVA: 0x0040AD65 File Offset: 0x00408F65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateSceneGroupDataNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.playerSceneGroupDataList_.Add(other.playerSceneGroupDataList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BF84 RID: 114564 RVA: 0x0040AD93 File Offset: 0x00408F93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BF85 RID: 114565 RVA: 0x0040AD9C File Offset: 0x00408F9C
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.playerSceneGroupDataList_.AddEntriesFrom(ref input, UpdateSceneGroupDataNotify._repeated_playerSceneGroupDataList_codec);
				}
			}
		}

		// Token: 0x0400A0A6 RID: 41126
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A0A7 RID: 41127
		public const int PlayerSceneGroupDataListFieldNumber = 2;

		// Token: 0x0400A0A8 RID: 41128
		private static readonly FieldCodec<PlayerSceneGroupDataList> _repeated_playerSceneGroupDataList_codec = FieldCodec.ForMessage<PlayerSceneGroupDataList>(18U, Aki.Protocol.PlayerSceneGroupDataList.Parser);

		// Token: 0x0400A0A9 RID: 41129
		private readonly RepeatedField<PlayerSceneGroupDataList> playerSceneGroupDataList_ = new RepeatedField<PlayerSceneGroupDataList>();
	}
}
