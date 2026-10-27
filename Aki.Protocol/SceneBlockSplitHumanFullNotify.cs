using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001146 RID: 4422
	[NetMessage(EMessageId.SceneBlockSplitHumanFullNotify)]
	public sealed class SceneBlockSplitHumanFullNotify : IMessage<SceneBlockSplitHumanFullNotify>, IMessage, IEquatable<SceneBlockSplitHumanFullNotify>, IDeepCloneable<SceneBlockSplitHumanFullNotify>, IBufferMessage
	{
		// Token: 0x06017938 RID: 96568 RVA: 0x0036C3DC File Offset: 0x0036A5DC
		[NullableContext(1)]
		public static SceneBlockSplitHumanFullNotify Create()
		{
			return new SceneBlockSplitHumanFullNotify();
		}

		// Token: 0x17004F1E RID: 20254
		// (get) Token: 0x06017939 RID: 96569 RVA: 0x0036C3E3 File Offset: 0x0036A5E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F1F RID: 20255
		// (get) Token: 0x0601793A RID: 96570 RVA: 0x0036C3E6 File Offset: 0x0036A5E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneBlockSplitHumanFullNotify.Descriptor;
			}
		}

		// Token: 0x0601793B RID: 96571 RVA: 0x0036C3ED File Offset: 0x0036A5ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitHumanFullNotify()
		{
		}

		// Token: 0x0601793C RID: 96572 RVA: 0x0036C400 File Offset: 0x0036A600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitHumanFullNotify(SceneBlockSplitHumanFullNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.downloadBlockId_ = other.downloadBlockId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601793D RID: 96573 RVA: 0x0036C436 File Offset: 0x0036A636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitHumanFullNotify Clone()
		{
			return new SceneBlockSplitHumanFullNotify(this);
		}

		// Token: 0x17004F20 RID: 20256
		// (get) Token: 0x0601793E RID: 96574 RVA: 0x0036C43E File Offset: 0x0036A63E
		// (set) Token: 0x0601793F RID: 96575 RVA: 0x0036C446 File Offset: 0x0036A646
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

		// Token: 0x17004F21 RID: 20257
		// (get) Token: 0x06017940 RID: 96576 RVA: 0x0036C44F File Offset: 0x0036A64F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DownloadBlockId
		{
			get
			{
				return this.downloadBlockId_;
			}
		}

		// Token: 0x06017941 RID: 96577 RVA: 0x0036C457 File Offset: 0x0036A657
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneBlockSplitHumanFullNotify);
		}

		// Token: 0x06017942 RID: 96578 RVA: 0x0036C468 File Offset: 0x0036A668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneBlockSplitHumanFullNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.downloadBlockId_.Equals(other.downloadBlockId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017943 RID: 96579 RVA: 0x0036C4B8 File Offset: 0x0036A6B8
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017944 RID: 96580 RVA: 0x0036C505 File Offset: 0x0036A705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017945 RID: 96581 RVA: 0x0036C512 File Offset: 0x0036A712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017946 RID: 96582 RVA: 0x0036C51C File Offset: 0x0036A71C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.PlayerId);
			}
			this.downloadBlockId_.WriteTo(ref output, SceneBlockSplitHumanFullNotify._repeated_downloadBlockId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017947 RID: 96583 RVA: 0x0036C56C File Offset: 0x0036A76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			num += this.downloadBlockId_.CalculateSize(SceneBlockSplitHumanFullNotify._repeated_downloadBlockId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017948 RID: 96584 RVA: 0x0036C5C0 File Offset: 0x0036A7C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneBlockSplitHumanFullNotify other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017949 RID: 96585 RVA: 0x0036C60D File Offset: 0x0036A80D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601794A RID: 96586 RVA: 0x0036C618 File Offset: 0x0036A818
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
					if (num != 120U && num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.downloadBlockId_.AddEntriesFrom(ref input, SceneBlockSplitHumanFullNotify._repeated_downloadBlockId_codec);
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008BFF RID: 35839
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008C00 RID: 35840
		public const int PlayerIdFieldNumber = 6;

		// Token: 0x04008C01 RID: 35841
		private int playerId_;

		// Token: 0x04008C02 RID: 35842
		public const int DownloadBlockIdFieldNumber = 15;

		// Token: 0x04008C03 RID: 35843
		private static readonly FieldCodec<int> _repeated_downloadBlockId_codec = FieldCodec.ForInt32(122U);

		// Token: 0x04008C04 RID: 35844
		private readonly RepeatedField<int> downloadBlockId_ = new RepeatedField<int>();
	}
}
