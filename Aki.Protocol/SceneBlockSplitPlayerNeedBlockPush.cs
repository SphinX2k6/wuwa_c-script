using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001148 RID: 4424
	[NetMessage(EMessageId.SceneBlockSplitPlayerNeedBlockPush)]
	public sealed class SceneBlockSplitPlayerNeedBlockPush : IMessage<SceneBlockSplitPlayerNeedBlockPush>, IMessage, IEquatable<SceneBlockSplitPlayerNeedBlockPush>, IDeepCloneable<SceneBlockSplitPlayerNeedBlockPush>, IBufferMessage
	{
		// Token: 0x06017960 RID: 96608 RVA: 0x0036C91F File Offset: 0x0036AB1F
		[NullableContext(1)]
		public static SceneBlockSplitPlayerNeedBlockPush Create()
		{
			return new SceneBlockSplitPlayerNeedBlockPush();
		}

		// Token: 0x17004F26 RID: 20262
		// (get) Token: 0x06017961 RID: 96609 RVA: 0x0036C926 File Offset: 0x0036AB26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F27 RID: 20263
		// (get) Token: 0x06017962 RID: 96610 RVA: 0x0036C929 File Offset: 0x0036AB29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneBlockSplitPlayerNeedBlockPush.Descriptor;
			}
		}

		// Token: 0x06017963 RID: 96611 RVA: 0x0036C930 File Offset: 0x0036AB30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitPlayerNeedBlockPush()
		{
		}

		// Token: 0x06017964 RID: 96612 RVA: 0x0036C943 File Offset: 0x0036AB43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitPlayerNeedBlockPush(SceneBlockSplitPlayerNeedBlockPush other) : this()
		{
			this.playerNeedBlockId_ = other.playerNeedBlockId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017965 RID: 96613 RVA: 0x0036C96D File Offset: 0x0036AB6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitPlayerNeedBlockPush Clone()
		{
			return new SceneBlockSplitPlayerNeedBlockPush(this);
		}

		// Token: 0x17004F28 RID: 20264
		// (get) Token: 0x06017966 RID: 96614 RVA: 0x0036C975 File Offset: 0x0036AB75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PlayerNeedBlockId
		{
			get
			{
				return this.playerNeedBlockId_;
			}
		}

		// Token: 0x06017967 RID: 96615 RVA: 0x0036C97D File Offset: 0x0036AB7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneBlockSplitPlayerNeedBlockPush);
		}

		// Token: 0x06017968 RID: 96616 RVA: 0x0036C98B File Offset: 0x0036AB8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneBlockSplitPlayerNeedBlockPush other)
		{
			return other != null && (other == this || (this.playerNeedBlockId_.Equals(other.playerNeedBlockId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017969 RID: 96617 RVA: 0x0036C9C0 File Offset: 0x0036ABC0
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

		// Token: 0x0601796A RID: 96618 RVA: 0x0036C9F4 File Offset: 0x0036ABF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601796B RID: 96619 RVA: 0x0036CA01 File Offset: 0x0036AC01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601796C RID: 96620 RVA: 0x0036CA0A File Offset: 0x0036AC0A
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

		// Token: 0x0601796D RID: 96621 RVA: 0x0036CA34 File Offset: 0x0036AC34
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

		// Token: 0x0601796E RID: 96622 RVA: 0x0036CA6D File Offset: 0x0036AC6D
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

		// Token: 0x0601796F RID: 96623 RVA: 0x0036CA9B File Offset: 0x0036AC9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017970 RID: 96624 RVA: 0x0036CAA4 File Offset: 0x0036ACA4
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
				if (num != 32U && num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.playerNeedBlockId_.AddEntriesFrom(ref input, SceneBlockSplitPlayerNeedBlockPush._repeated_playerNeedBlockId_codec);
				}
			}
		}

		// Token: 0x04008C0A RID: 35850
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008C0B RID: 35851
		public const int PlayerNeedBlockIdFieldNumber = 4;

		// Token: 0x04008C0C RID: 35852
		private static readonly FieldCodec<int> _repeated_playerNeedBlockId_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04008C0D RID: 35853
		private readonly RepeatedField<int> playerNeedBlockId_ = new RepeatedField<int>();
	}
}
