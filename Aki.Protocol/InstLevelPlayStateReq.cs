using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000826 RID: 2086
	public sealed class InstLevelPlayStateReq : IMessage<InstLevelPlayStateReq>, IMessage, IEquatable<InstLevelPlayStateReq>, IDeepCloneable<InstLevelPlayStateReq>, IBufferMessage
	{
		// Token: 0x0600BA68 RID: 47720 RVA: 0x001BBBCA File Offset: 0x001B9DCA
		[NullableContext(1)]
		public static InstLevelPlayStateReq Create()
		{
			return new InstLevelPlayStateReq();
		}

		// Token: 0x17002596 RID: 9622
		// (get) Token: 0x0600BA69 RID: 47721 RVA: 0x001BBBD1 File Offset: 0x001B9DD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InstLevelPlayStateReq> Parser
		{
			get
			{
				return InstLevelPlayStateReq._parser;
			}
		}

		// Token: 0x17002597 RID: 9623
		// (get) Token: 0x0600BA6A RID: 47722 RVA: 0x001BBBD8 File Offset: 0x001B9DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002598 RID: 9624
		// (get) Token: 0x0600BA6B RID: 47723 RVA: 0x001BBBDB File Offset: 0x001B9DDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstLevelPlayStateReq.Descriptor;
			}
		}

		// Token: 0x0600BA6C RID: 47724 RVA: 0x001BBBE2 File Offset: 0x001B9DE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstLevelPlayStateReq()
		{
		}

		// Token: 0x0600BA6D RID: 47725 RVA: 0x001BBBF5 File Offset: 0x001B9DF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstLevelPlayStateReq(InstLevelPlayStateReq other) : this()
		{
			this.instId_ = other.instId_;
			this.levelPlayIds_ = other.levelPlayIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BA6E RID: 47726 RVA: 0x001BBC2B File Offset: 0x001B9E2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstLevelPlayStateReq Clone()
		{
			return new InstLevelPlayStateReq(this);
		}

		// Token: 0x17002599 RID: 9625
		// (get) Token: 0x0600BA6F RID: 47727 RVA: 0x001BBC33 File Offset: 0x001B9E33
		// (set) Token: 0x0600BA70 RID: 47728 RVA: 0x001BBC3B File Offset: 0x001B9E3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x1700259A RID: 9626
		// (get) Token: 0x0600BA71 RID: 47729 RVA: 0x001BBC44 File Offset: 0x001B9E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> LevelPlayIds
		{
			get
			{
				return this.levelPlayIds_;
			}
		}

		// Token: 0x0600BA72 RID: 47730 RVA: 0x001BBC4C File Offset: 0x001B9E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstLevelPlayStateReq);
		}

		// Token: 0x0600BA73 RID: 47731 RVA: 0x001BBC5C File Offset: 0x001B9E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstLevelPlayStateReq other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.levelPlayIds_.Equals(other.levelPlayIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BA74 RID: 47732 RVA: 0x001BBCAC File Offset: 0x001B9EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			num ^= this.levelPlayIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BA75 RID: 47733 RVA: 0x001BBCF9 File Offset: 0x001B9EF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BA76 RID: 47734 RVA: 0x001BBD06 File Offset: 0x001B9F06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BA77 RID: 47735 RVA: 0x001BBD10 File Offset: 0x001B9F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InstId);
			}
			this.levelPlayIds_.WriteTo(ref output, InstLevelPlayStateReq._repeated_levelPlayIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BA78 RID: 47736 RVA: 0x001BBD60 File Offset: 0x001B9F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			num += this.levelPlayIds_.CalculateSize(InstLevelPlayStateReq._repeated_levelPlayIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BA79 RID: 47737 RVA: 0x001BBDB4 File Offset: 0x001B9FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InstLevelPlayStateReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this.levelPlayIds_.Add(other.levelPlayIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BA7A RID: 47738 RVA: 0x001BBE01 File Offset: 0x001BA001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BA7B RID: 47739 RVA: 0x001BBE0C File Offset: 0x001BA00C
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
				if (num != 8U)
				{
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.levelPlayIds_.AddEntriesFrom(ref input, InstLevelPlayStateReq._repeated_levelPlayIds_codec);
					}
				}
				else
				{
					this.InstId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040051D4 RID: 20948
		private static readonly MessageParser<InstLevelPlayStateReq> _parser = new MessageParser<InstLevelPlayStateReq>(() => new InstLevelPlayStateReq());

		// Token: 0x040051D5 RID: 20949
		private UnknownFieldSet _unknownFields;

		// Token: 0x040051D6 RID: 20950
		public const int InstIdFieldNumber = 1;

		// Token: 0x040051D7 RID: 20951
		private int instId_;

		// Token: 0x040051D8 RID: 20952
		public const int LevelPlayIdsFieldNumber = 2;

		// Token: 0x040051D9 RID: 20953
		private static readonly FieldCodec<int> _repeated_levelPlayIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040051DA RID: 20954
		private readonly RepeatedField<int> levelPlayIds_ = new RepeatedField<int>();
	}
}
