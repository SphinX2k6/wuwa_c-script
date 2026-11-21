using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001182 RID: 4482
	[NetMessage(EMessageId.SceneBlockSplitPlayerNeedBlockPush)]
	public sealed class SceneBlockSplitPlayerNeedBlockPush : IMessage<SceneBlockSplitPlayerNeedBlockPush>, IMessage, IEquatable<SceneBlockSplitPlayerNeedBlockPush>, IDeepCloneable<SceneBlockSplitPlayerNeedBlockPush>, IBufferMessage
	{
		// Token: 0x06017F01 RID: 98049 RVA: 0x0037BC6C File Offset: 0x00379E6C
		[NullableContext(1)]
		public static SceneBlockSplitPlayerNeedBlockPush Create()
		{
			return new SceneBlockSplitPlayerNeedBlockPush();
		}

		// Token: 0x17005092 RID: 20626
		// (get) Token: 0x06017F02 RID: 98050 RVA: 0x0037BC73 File Offset: 0x00379E73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005093 RID: 20627
		// (get) Token: 0x06017F03 RID: 98051 RVA: 0x0037BC76 File Offset: 0x00379E76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneBlockSplitPlayerNeedBlockPush.Descriptor;
			}
		}

		// Token: 0x06017F04 RID: 98052 RVA: 0x0037BC7D File Offset: 0x00379E7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitPlayerNeedBlockPush()
		{
		}

		// Token: 0x06017F05 RID: 98053 RVA: 0x0037BC90 File Offset: 0x00379E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitPlayerNeedBlockPush(SceneBlockSplitPlayerNeedBlockPush other) : this()
		{
			this.playerNeedBlockId_ = other.playerNeedBlockId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017F06 RID: 98054 RVA: 0x0037BCBA File Offset: 0x00379EBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitPlayerNeedBlockPush Clone()
		{
			return new SceneBlockSplitPlayerNeedBlockPush(this);
		}

		// Token: 0x17005094 RID: 20628
		// (get) Token: 0x06017F07 RID: 98055 RVA: 0x0037BCC2 File Offset: 0x00379EC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PlayerNeedBlockId
		{
			get
			{
				return this.playerNeedBlockId_;
			}
		}

		// Token: 0x06017F08 RID: 98056 RVA: 0x0037BCCA File Offset: 0x00379ECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneBlockSplitPlayerNeedBlockPush);
		}

		// Token: 0x06017F09 RID: 98057 RVA: 0x0037BCD8 File Offset: 0x00379ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneBlockSplitPlayerNeedBlockPush other)
		{
			return other != null && (other == this || (this.playerNeedBlockId_.Equals(other.playerNeedBlockId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017F0A RID: 98058 RVA: 0x0037BD0C File Offset: 0x00379F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.playerNeedBlockId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017F0B RID: 98059 RVA: 0x0037BD40 File Offset: 0x00379F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017F0C RID: 98060 RVA: 0x0037BD4D File Offset: 0x00379F4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017F0D RID: 98061 RVA: 0x0037BD56 File Offset: 0x00379F56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.playerNeedBlockId_.WriteTo(ref output, SceneBlockSplitPlayerNeedBlockPush._repeated_playerNeedBlockId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017F0E RID: 98062 RVA: 0x0037BD80 File Offset: 0x00379F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.playerNeedBlockId_.CalculateSize(SceneBlockSplitPlayerNeedBlockPush._repeated_playerNeedBlockId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017F0F RID: 98063 RVA: 0x0037BDB9 File Offset: 0x00379FB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneBlockSplitPlayerNeedBlockPush other)
		{
			if (other == null)
			{
				return;
			}
			this.playerNeedBlockId_.Add(other.playerNeedBlockId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017F10 RID: 98064 RVA: 0x0037BDE7 File Offset: 0x00379FE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017F11 RID: 98065 RVA: 0x0037BDF0 File Offset: 0x00379FF0
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
				if (num != 96U && num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.playerNeedBlockId_.AddEntriesFrom(ref input, SceneBlockSplitPlayerNeedBlockPush._repeated_playerNeedBlockId_codec);
				}
			}
		}

		// Token: 0x04008E9D RID: 36509
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E9E RID: 36510
		public const int PlayerNeedBlockIdFieldNumber = 12;

		// Token: 0x04008E9F RID: 36511
		private static readonly FieldCodec<int> _repeated_playerNeedBlockId_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04008EA0 RID: 36512
		private readonly RepeatedField<int> playerNeedBlockId_ = new RepeatedField<int>();
	}
}
