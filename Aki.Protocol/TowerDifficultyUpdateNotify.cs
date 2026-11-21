using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001429 RID: 5161
	[NetMessage(EMessageId.TowerDifficultyUpdateNotify)]
	public sealed class TowerDifficultyUpdateNotify : IMessage<TowerDifficultyUpdateNotify>, IMessage, IEquatable<TowerDifficultyUpdateNotify>, IDeepCloneable<TowerDifficultyUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601B6DF RID: 112351 RVA: 0x003FCFBF File Offset: 0x003FB1BF
		[NullableContext(1)]
		public static TowerDifficultyUpdateNotify Create()
		{
			return new TowerDifficultyUpdateNotify();
		}

		// Token: 0x17005CDE RID: 23774
		// (get) Token: 0x0601B6E0 RID: 112352 RVA: 0x003FCFC6 File Offset: 0x003FB1C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CDF RID: 23775
		// (get) Token: 0x0601B6E1 RID: 112353 RVA: 0x003FCFC9 File Offset: 0x003FB1C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDifficultyUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601B6E2 RID: 112354 RVA: 0x003FCFD0 File Offset: 0x003FB1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDifficultyUpdateNotify()
		{
		}

		// Token: 0x0601B6E3 RID: 112355 RVA: 0x003FCFE3 File Offset: 0x003FB1E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDifficultyUpdateNotify(TowerDifficultyUpdateNotify other) : this()
		{
			this.towerDifficulties_ = other.towerDifficulties_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B6E4 RID: 112356 RVA: 0x003FD00D File Offset: 0x003FB20D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDifficultyUpdateNotify Clone()
		{
			return new TowerDifficultyUpdateNotify(this);
		}

		// Token: 0x17005CE0 RID: 23776
		// (get) Token: 0x0601B6E5 RID: 112357 RVA: 0x003FD015 File Offset: 0x003FB215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TowerDifficultyPb> TowerDifficulties
		{
			get
			{
				return this.towerDifficulties_;
			}
		}

		// Token: 0x0601B6E6 RID: 112358 RVA: 0x003FD01D File Offset: 0x003FB21D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDifficultyUpdateNotify);
		}

		// Token: 0x0601B6E7 RID: 112359 RVA: 0x003FD02B File Offset: 0x003FB22B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDifficultyUpdateNotify other)
		{
			return other != null && (other == this || (this.towerDifficulties_.Equals(other.towerDifficulties_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B6E8 RID: 112360 RVA: 0x003FD060 File Offset: 0x003FB260
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

		// Token: 0x0601B6E9 RID: 112361 RVA: 0x003FD094 File Offset: 0x003FB294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B6EA RID: 112362 RVA: 0x003FD0A1 File Offset: 0x003FB2A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B6EB RID: 112363 RVA: 0x003FD0AA File Offset: 0x003FB2AA
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

		// Token: 0x0601B6EC RID: 112364 RVA: 0x003FD0D4 File Offset: 0x003FB2D4
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

		// Token: 0x0601B6ED RID: 112365 RVA: 0x003FD10D File Offset: 0x003FB30D
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

		// Token: 0x0601B6EE RID: 112366 RVA: 0x003FD13B File Offset: 0x003FB33B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B6EF RID: 112367 RVA: 0x003FD144 File Offset: 0x003FB344
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.towerDifficulties_.AddEntriesFrom(ref input, TowerDifficultyUpdateNotify._repeated_towerDifficulties_codec);
				}
			}
		}

		// Token: 0x04009FB5 RID: 40885
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009FB6 RID: 40886
		public const int TowerDifficultiesFieldNumber = 15;

		// Token: 0x04009FB7 RID: 40887
		private static readonly FieldCodec<TowerDifficultyPb> _repeated_towerDifficulties_codec = FieldCodec.ForMessage<TowerDifficultyPb>(122U, TowerDifficultyPb.Parser);

		// Token: 0x04009FB8 RID: 40888
		private readonly RepeatedField<TowerDifficultyPb> towerDifficulties_ = new RepeatedField<TowerDifficultyPb>();
	}
}
