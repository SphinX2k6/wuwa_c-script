using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013B6 RID: 5046
	[NetMessage(EMessageId.TowerDifficultyUpdateNotify)]
	public sealed class TowerDifficultyUpdateNotify : IMessage<TowerDifficultyUpdateNotify>, IMessage, IEquatable<TowerDifficultyUpdateNotify>, IDeepCloneable<TowerDifficultyUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601AC54 RID: 109652 RVA: 0x003E1CFF File Offset: 0x003DFEFF
		[NullableContext(1)]
		public static TowerDifficultyUpdateNotify Create()
		{
			return new TowerDifficultyUpdateNotify();
		}

		// Token: 0x17005A49 RID: 23113
		// (get) Token: 0x0601AC55 RID: 109653 RVA: 0x003E1D06 File Offset: 0x003DFF06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A4A RID: 23114
		// (get) Token: 0x0601AC56 RID: 109654 RVA: 0x003E1D09 File Offset: 0x003DFF09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDifficultyUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601AC57 RID: 109655 RVA: 0x003E1D10 File Offset: 0x003DFF10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDifficultyUpdateNotify()
		{
		}

		// Token: 0x0601AC58 RID: 109656 RVA: 0x003E1D23 File Offset: 0x003DFF23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDifficultyUpdateNotify(TowerDifficultyUpdateNotify other) : this()
		{
			this.towerDifficulties_ = other.towerDifficulties_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AC59 RID: 109657 RVA: 0x003E1D4D File Offset: 0x003DFF4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDifficultyUpdateNotify Clone()
		{
			return new TowerDifficultyUpdateNotify(this);
		}

		// Token: 0x17005A4B RID: 23115
		// (get) Token: 0x0601AC5A RID: 109658 RVA: 0x003E1D55 File Offset: 0x003DFF55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TowerDifficultyPb> TowerDifficulties
		{
			get
			{
				return this.towerDifficulties_;
			}
		}

		// Token: 0x0601AC5B RID: 109659 RVA: 0x003E1D5D File Offset: 0x003DFF5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDifficultyUpdateNotify);
		}

		// Token: 0x0601AC5C RID: 109660 RVA: 0x003E1D6B File Offset: 0x003DFF6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDifficultyUpdateNotify other)
		{
			return other != null && (other == this || (this.towerDifficulties_.Equals(other.towerDifficulties_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AC5D RID: 109661 RVA: 0x003E1DA0 File Offset: 0x003DFFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.towerDifficulties_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AC5E RID: 109662 RVA: 0x003E1DD4 File Offset: 0x003DFFD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AC5F RID: 109663 RVA: 0x003E1DE1 File Offset: 0x003DFFE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AC60 RID: 109664 RVA: 0x003E1DEA File Offset: 0x003DFFEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.towerDifficulties_.WriteTo(ref output, TowerDifficultyUpdateNotify._repeated_towerDifficulties_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AC61 RID: 109665 RVA: 0x003E1E14 File Offset: 0x003E0014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.towerDifficulties_.CalculateSize(TowerDifficultyUpdateNotify._repeated_towerDifficulties_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AC62 RID: 109666 RVA: 0x003E1E4D File Offset: 0x003E004D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDifficultyUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.towerDifficulties_.Add(other.towerDifficulties_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AC63 RID: 109667 RVA: 0x003E1E7B File Offset: 0x003E007B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AC64 RID: 109668 RVA: 0x003E1E84 File Offset: 0x003E0084
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
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.towerDifficulties_.AddEntriesFrom(ref input, TowerDifficultyUpdateNotify._repeated_towerDifficulties_codec);
				}
			}
		}

		// Token: 0x04009B6E RID: 39790
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B6F RID: 39791
		public const int TowerDifficultiesFieldNumber = 3;

		// Token: 0x04009B70 RID: 39792
		private static readonly FieldCodec<TowerDifficultyPb> _repeated_towerDifficulties_codec = FieldCodec.ForMessage<TowerDifficultyPb>(26U, TowerDifficultyPb.Parser);

		// Token: 0x04009B71 RID: 39793
		private readonly RepeatedField<TowerDifficultyPb> towerDifficulties_ = new RepeatedField<TowerDifficultyPb>();
	}
}
