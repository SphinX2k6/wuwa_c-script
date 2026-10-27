using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001144 RID: 4420
	[NetMessage(EMessageId.SceneBlockSplitClientLoginPush)]
	public sealed class SceneBlockSplitClientLoginPush : IMessage<SceneBlockSplitClientLoginPush>, IMessage, IEquatable<SceneBlockSplitClientLoginPush>, IDeepCloneable<SceneBlockSplitClientLoginPush>, IBufferMessage
	{
		// Token: 0x06017911 RID: 96529 RVA: 0x0036BE9D File Offset: 0x0036A09D
		[NullableContext(1)]
		public static SceneBlockSplitClientLoginPush Create()
		{
			return new SceneBlockSplitClientLoginPush();
		}

		// Token: 0x17004F16 RID: 20246
		// (get) Token: 0x06017912 RID: 96530 RVA: 0x0036BEA4 File Offset: 0x0036A0A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F17 RID: 20247
		// (get) Token: 0x06017913 RID: 96531 RVA: 0x0036BEA7 File Offset: 0x0036A0A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneBlockSplitClientLoginPush.Descriptor;
			}
		}

		// Token: 0x06017914 RID: 96532 RVA: 0x0036BEAE File Offset: 0x0036A0AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitClientLoginPush()
		{
		}

		// Token: 0x06017915 RID: 96533 RVA: 0x0036BEC1 File Offset: 0x0036A0C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitClientLoginPush(SceneBlockSplitClientLoginPush other) : this()
		{
			this.downloadBlockId_ = other.downloadBlockId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017916 RID: 96534 RVA: 0x0036BEEB File Offset: 0x0036A0EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitClientLoginPush Clone()
		{
			return new SceneBlockSplitClientLoginPush(this);
		}

		// Token: 0x17004F18 RID: 20248
		// (get) Token: 0x06017917 RID: 96535 RVA: 0x0036BEF3 File Offset: 0x0036A0F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DownloadBlockId
		{
			get
			{
				return this.downloadBlockId_;
			}
		}

		// Token: 0x06017918 RID: 96536 RVA: 0x0036BEFB File Offset: 0x0036A0FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneBlockSplitClientLoginPush);
		}

		// Token: 0x06017919 RID: 96537 RVA: 0x0036BF09 File Offset: 0x0036A109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneBlockSplitClientLoginPush other)
		{
			return other != null && (other == this || (this.downloadBlockId_.Equals(other.downloadBlockId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601791A RID: 96538 RVA: 0x0036BF3C File Offset: 0x0036A13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.downloadBlockId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601791B RID: 96539 RVA: 0x0036BF70 File Offset: 0x0036A170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601791C RID: 96540 RVA: 0x0036BF7D File Offset: 0x0036A17D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601791D RID: 96541 RVA: 0x0036BF86 File Offset: 0x0036A186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.downloadBlockId_.WriteTo(ref output, SceneBlockSplitClientLoginPush._repeated_downloadBlockId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601791E RID: 96542 RVA: 0x0036BFB0 File Offset: 0x0036A1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.downloadBlockId_.CalculateSize(SceneBlockSplitClientLoginPush._repeated_downloadBlockId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601791F RID: 96543 RVA: 0x0036BFE9 File Offset: 0x0036A1E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneBlockSplitClientLoginPush other)
		{
			if (other == null)
			{
				return;
			}
			this.downloadBlockId_.Add(other.downloadBlockId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017920 RID: 96544 RVA: 0x0036C017 File Offset: 0x0036A217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017921 RID: 96545 RVA: 0x0036C020 File Offset: 0x0036A220
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
				if (num != 56U && num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.downloadBlockId_.AddEntriesFrom(ref input, SceneBlockSplitClientLoginPush._repeated_downloadBlockId_codec);
				}
			}
		}

		// Token: 0x04008BF2 RID: 35826
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BF3 RID: 35827
		public const int DownloadBlockIdFieldNumber = 7;

		// Token: 0x04008BF4 RID: 35828
		private static readonly FieldCodec<int> _repeated_downloadBlockId_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04008BF5 RID: 35829
		private readonly RepeatedField<int> downloadBlockId_ = new RepeatedField<int>();
	}
}
