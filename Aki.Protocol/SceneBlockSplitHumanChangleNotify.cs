using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200117F RID: 4479
	[NetMessage(EMessageId.SceneBlockSplitHumanChangleNotify)]
	public sealed class SceneBlockSplitHumanChangleNotify : IMessage<SceneBlockSplitHumanChangleNotify>, IMessage, IEquatable<SceneBlockSplitHumanChangleNotify>, IDeepCloneable<SceneBlockSplitHumanChangleNotify>, IBufferMessage
	{
		// Token: 0x06017EC4 RID: 97988 RVA: 0x0037B3C5 File Offset: 0x003795C5
		[NullableContext(1)]
		public static SceneBlockSplitHumanChangleNotify Create()
		{
			return new SceneBlockSplitHumanChangleNotify();
		}

		// Token: 0x17005085 RID: 20613
		// (get) Token: 0x06017EC5 RID: 97989 RVA: 0x0037B3CC File Offset: 0x003795CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005086 RID: 20614
		// (get) Token: 0x06017EC6 RID: 97990 RVA: 0x0037B3CF File Offset: 0x003795CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneBlockSplitHumanChangleNotify.Descriptor;
			}
		}

		// Token: 0x06017EC7 RID: 97991 RVA: 0x0037B3D6 File Offset: 0x003795D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitHumanChangleNotify()
		{
		}

		// Token: 0x06017EC8 RID: 97992 RVA: 0x0037B3F4 File Offset: 0x003795F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitHumanChangleNotify(SceneBlockSplitHumanChangleNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.downloadBlockId_ = other.downloadBlockId_.Clone();
			this.deleteBlockId_ = other.deleteBlockId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017EC9 RID: 97993 RVA: 0x0037B446 File Offset: 0x00379646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitHumanChangleNotify Clone()
		{
			return new SceneBlockSplitHumanChangleNotify(this);
		}

		// Token: 0x17005087 RID: 20615
		// (get) Token: 0x06017ECA RID: 97994 RVA: 0x0037B44E File Offset: 0x0037964E
		// (set) Token: 0x06017ECB RID: 97995 RVA: 0x0037B456 File Offset: 0x00379656
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

		// Token: 0x17005088 RID: 20616
		// (get) Token: 0x06017ECC RID: 97996 RVA: 0x0037B45F File Offset: 0x0037965F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DownloadBlockId
		{
			get
			{
				return this.downloadBlockId_;
			}
		}

		// Token: 0x17005089 RID: 20617
		// (get) Token: 0x06017ECD RID: 97997 RVA: 0x0037B467 File Offset: 0x00379667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DeleteBlockId
		{
			get
			{
				return this.deleteBlockId_;
			}
		}

		// Token: 0x06017ECE RID: 97998 RVA: 0x0037B46F File Offset: 0x0037966F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneBlockSplitHumanChangleNotify);
		}

		// Token: 0x06017ECF RID: 97999 RVA: 0x0037B480 File Offset: 0x00379680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneBlockSplitHumanChangleNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.downloadBlockId_.Equals(other.downloadBlockId_) && this.deleteBlockId_.Equals(other.deleteBlockId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017ED0 RID: 98000 RVA: 0x0037B4E4 File Offset: 0x003796E4
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

		// Token: 0x06017ED1 RID: 98001 RVA: 0x0037B53F File Offset: 0x0037973F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017ED2 RID: 98002 RVA: 0x0037B54C File Offset: 0x0037974C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017ED3 RID: 98003 RVA: 0x0037B558 File Offset: 0x00379758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.downloadBlockId_.WriteTo(ref output, SceneBlockSplitHumanChangleNotify._repeated_downloadBlockId_codec);
			this.deleteBlockId_.WriteTo(ref output, SceneBlockSplitHumanChangleNotify._repeated_deleteBlockId_codec);
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017ED4 RID: 98004 RVA: 0x0037B5B8 File Offset: 0x003797B8
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

		// Token: 0x06017ED5 RID: 98005 RVA: 0x0037B61C File Offset: 0x0037981C
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

		// Token: 0x06017ED6 RID: 98006 RVA: 0x0037B67A File Offset: 0x0037987A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017ED7 RID: 98007 RVA: 0x0037B684 File Offset: 0x00379884
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
				if (num <= 50U)
				{
					if (num == 48U || num == 50U)
					{
						this.downloadBlockId_.AddEntriesFrom(ref input, SceneBlockSplitHumanChangleNotify._repeated_downloadBlockId_codec);
						continue;
					}
				}
				else
				{
					if (num == 56U || num == 58U)
					{
						this.deleteBlockId_.AddEntriesFrom(ref input, SceneBlockSplitHumanChangleNotify._repeated_deleteBlockId_codec);
						continue;
					}
					if (num == 64U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008E89 RID: 36489
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E8A RID: 36490
		public const int PlayerIdFieldNumber = 8;

		// Token: 0x04008E8B RID: 36491
		private int playerId_;

		// Token: 0x04008E8C RID: 36492
		public const int DownloadBlockIdFieldNumber = 6;

		// Token: 0x04008E8D RID: 36493
		private static readonly FieldCodec<int> _repeated_downloadBlockId_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04008E8E RID: 36494
		private readonly RepeatedField<int> downloadBlockId_ = new RepeatedField<int>();

		// Token: 0x04008E8F RID: 36495
		public const int DeleteBlockIdFieldNumber = 7;

		// Token: 0x04008E90 RID: 36496
		private static readonly FieldCodec<int> _repeated_deleteBlockId_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04008E91 RID: 36497
		private readonly RepeatedField<int> deleteBlockId_ = new RepeatedField<int>();
	}
}
