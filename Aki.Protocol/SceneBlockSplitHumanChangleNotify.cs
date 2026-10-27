using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001145 RID: 4421
	[NetMessage(EMessageId.SceneBlockSplitHumanChangleNotify)]
	public sealed class SceneBlockSplitHumanChangleNotify : IMessage<SceneBlockSplitHumanChangleNotify>, IMessage, IEquatable<SceneBlockSplitHumanChangleNotify>, IDeepCloneable<SceneBlockSplitHumanChangleNotify>, IBufferMessage
	{
		// Token: 0x06017923 RID: 96547 RVA: 0x0036C07D File Offset: 0x0036A27D
		[NullableContext(1)]
		public static SceneBlockSplitHumanChangleNotify Create()
		{
			return new SceneBlockSplitHumanChangleNotify();
		}

		// Token: 0x17004F19 RID: 20249
		// (get) Token: 0x06017924 RID: 96548 RVA: 0x0036C084 File Offset: 0x0036A284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F1A RID: 20250
		// (get) Token: 0x06017925 RID: 96549 RVA: 0x0036C087 File Offset: 0x0036A287
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneBlockSplitHumanChangleNotify.Descriptor;
			}
		}

		// Token: 0x06017926 RID: 96550 RVA: 0x0036C08E File Offset: 0x0036A28E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitHumanChangleNotify()
		{
		}

		// Token: 0x06017927 RID: 96551 RVA: 0x0036C0AC File Offset: 0x0036A2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitHumanChangleNotify(SceneBlockSplitHumanChangleNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.downloadBlockId_ = other.downloadBlockId_.Clone();
			this.deleteBlockId_ = other.deleteBlockId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017928 RID: 96552 RVA: 0x0036C0FE File Offset: 0x0036A2FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitHumanChangleNotify Clone()
		{
			return new SceneBlockSplitHumanChangleNotify(this);
		}

		// Token: 0x17004F1B RID: 20251
		// (get) Token: 0x06017929 RID: 96553 RVA: 0x0036C106 File Offset: 0x0036A306
		// (set) Token: 0x0601792A RID: 96554 RVA: 0x0036C10E File Offset: 0x0036A30E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17004F1C RID: 20252
		// (get) Token: 0x0601792B RID: 96555 RVA: 0x0036C117 File Offset: 0x0036A317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DownloadBlockId
		{
			get
			{
				return this.downloadBlockId_;
			}
		}

		// Token: 0x17004F1D RID: 20253
		// (get) Token: 0x0601792C RID: 96556 RVA: 0x0036C11F File Offset: 0x0036A31F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DeleteBlockId
		{
			get
			{
				return this.deleteBlockId_;
			}
		}

		// Token: 0x0601792D RID: 96557 RVA: 0x0036C127 File Offset: 0x0036A327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneBlockSplitHumanChangleNotify);
		}

		// Token: 0x0601792E RID: 96558 RVA: 0x0036C138 File Offset: 0x0036A338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneBlockSplitHumanChangleNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.downloadBlockId_.Equals(other.downloadBlockId_) && this.deleteBlockId_.Equals(other.deleteBlockId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601792F RID: 96559 RVA: 0x0036C19C File Offset: 0x0036A39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			num ^= this.downloadBlockId_.GetHashCode();
			num ^= this.deleteBlockId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017930 RID: 96560 RVA: 0x0036C1F7 File Offset: 0x0036A3F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017931 RID: 96561 RVA: 0x0036C204 File Offset: 0x0036A404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017932 RID: 96562 RVA: 0x0036C210 File Offset: 0x0036A410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.downloadBlockId_.WriteTo(ref output, SceneBlockSplitHumanChangleNotify._repeated_downloadBlockId_codec);
			this.deleteBlockId_.WriteTo(ref output, SceneBlockSplitHumanChangleNotify._repeated_deleteBlockId_codec);
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017933 RID: 96563 RVA: 0x0036C270 File Offset: 0x0036A470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			num += this.downloadBlockId_.CalculateSize(SceneBlockSplitHumanChangleNotify._repeated_downloadBlockId_codec);
			num += this.deleteBlockId_.CalculateSize(SceneBlockSplitHumanChangleNotify._repeated_deleteBlockId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017934 RID: 96564 RVA: 0x0036C2D4 File Offset: 0x0036A4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneBlockSplitHumanChangleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this.downloadBlockId_.Add(other.downloadBlockId_);
			this.deleteBlockId_.Add(other.deleteBlockId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017935 RID: 96565 RVA: 0x0036C332 File Offset: 0x0036A532
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017936 RID: 96566 RVA: 0x0036C33C File Offset: 0x0036A53C
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
				if (num <= 98U)
				{
					if (num == 96U || num == 98U)
					{
						this.downloadBlockId_.AddEntriesFrom(ref input, SceneBlockSplitHumanChangleNotify._repeated_downloadBlockId_codec);
						continue;
					}
				}
				else
				{
					if (num == 104U || num == 106U)
					{
						this.deleteBlockId_.AddEntriesFrom(ref input, SceneBlockSplitHumanChangleNotify._repeated_deleteBlockId_codec);
						continue;
					}
					if (num == 120U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008BF6 RID: 35830
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BF7 RID: 35831
		public const int PlayerIdFieldNumber = 15;

		// Token: 0x04008BF8 RID: 35832
		private int playerId_;

		// Token: 0x04008BF9 RID: 35833
		public const int DownloadBlockIdFieldNumber = 12;

		// Token: 0x04008BFA RID: 35834
		private static readonly FieldCodec<int> _repeated_downloadBlockId_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04008BFB RID: 35835
		private readonly RepeatedField<int> downloadBlockId_ = new RepeatedField<int>();

		// Token: 0x04008BFC RID: 35836
		public const int DeleteBlockIdFieldNumber = 13;

		// Token: 0x04008BFD RID: 35837
		private static readonly FieldCodec<int> _repeated_deleteBlockId_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04008BFE RID: 35838
		private readonly RepeatedField<int> deleteBlockId_ = new RepeatedField<int>();
	}
}
