using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001180 RID: 4480
	[NetMessage(EMessageId.SceneBlockSplitHumanFullNotify)]
	public sealed class SceneBlockSplitHumanFullNotify : IMessage<SceneBlockSplitHumanFullNotify>, IMessage, IEquatable<SceneBlockSplitHumanFullNotify>, IDeepCloneable<SceneBlockSplitHumanFullNotify>, IBufferMessage
	{
		// Token: 0x06017ED9 RID: 98009 RVA: 0x0037B724 File Offset: 0x00379924
		[NullableContext(1)]
		public static SceneBlockSplitHumanFullNotify Create()
		{
			return new SceneBlockSplitHumanFullNotify();
		}

		// Token: 0x1700508A RID: 20618
		// (get) Token: 0x06017EDA RID: 98010 RVA: 0x0037B72B File Offset: 0x0037992B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700508B RID: 20619
		// (get) Token: 0x06017EDB RID: 98011 RVA: 0x0037B72E File Offset: 0x0037992E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneBlockSplitHumanFullNotify.Descriptor;
			}
		}

		// Token: 0x06017EDC RID: 98012 RVA: 0x0037B735 File Offset: 0x00379935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitHumanFullNotify()
		{
		}

		// Token: 0x06017EDD RID: 98013 RVA: 0x0037B748 File Offset: 0x00379948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitHumanFullNotify(SceneBlockSplitHumanFullNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.downloadBlockId_ = other.downloadBlockId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017EDE RID: 98014 RVA: 0x0037B77E File Offset: 0x0037997E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitHumanFullNotify Clone()
		{
			return new SceneBlockSplitHumanFullNotify(this);
		}

		// Token: 0x1700508C RID: 20620
		// (get) Token: 0x06017EDF RID: 98015 RVA: 0x0037B786 File Offset: 0x00379986
		// (set) Token: 0x06017EE0 RID: 98016 RVA: 0x0037B78E File Offset: 0x0037998E
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

		// Token: 0x1700508D RID: 20621
		// (get) Token: 0x06017EE1 RID: 98017 RVA: 0x0037B797 File Offset: 0x00379997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DownloadBlockId
		{
			get
			{
				return this.downloadBlockId_;
			}
		}

		// Token: 0x06017EE2 RID: 98018 RVA: 0x0037B79F File Offset: 0x0037999F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneBlockSplitHumanFullNotify);
		}

		// Token: 0x06017EE3 RID: 98019 RVA: 0x0037B7B0 File Offset: 0x003799B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneBlockSplitHumanFullNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.downloadBlockId_.Equals(other.downloadBlockId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017EE4 RID: 98020 RVA: 0x0037B800 File Offset: 0x00379A00
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

		// Token: 0x06017EE5 RID: 98021 RVA: 0x0037B84D File Offset: 0x00379A4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017EE6 RID: 98022 RVA: 0x0037B85A File Offset: 0x00379A5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017EE7 RID: 98023 RVA: 0x0037B864 File Offset: 0x00379A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.downloadBlockId_.WriteTo(ref output, SceneBlockSplitHumanFullNotify._repeated_downloadBlockId_codec);
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017EE8 RID: 98024 RVA: 0x0037B8B4 File Offset: 0x00379AB4
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

		// Token: 0x06017EE9 RID: 98025 RVA: 0x0037B908 File Offset: 0x00379B08
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

		// Token: 0x06017EEA RID: 98026 RVA: 0x0037B955 File Offset: 0x00379B55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017EEB RID: 98027 RVA: 0x0037B960 File Offset: 0x00379B60
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
				if (num != 24U && num != 26U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PlayerId = input.ReadInt32();
					}
				}
				else
				{
					this.downloadBlockId_.AddEntriesFrom(ref input, SceneBlockSplitHumanFullNotify._repeated_downloadBlockId_codec);
				}
			}
		}

		// Token: 0x04008E92 RID: 36498
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E93 RID: 36499
		public const int PlayerIdFieldNumber = 5;

		// Token: 0x04008E94 RID: 36500
		private int playerId_;

		// Token: 0x04008E95 RID: 36501
		public const int DownloadBlockIdFieldNumber = 3;

		// Token: 0x04008E96 RID: 36502
		private static readonly FieldCodec<int> _repeated_downloadBlockId_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04008E97 RID: 36503
		private readonly RepeatedField<int> downloadBlockId_ = new RepeatedField<int>();
	}
}
