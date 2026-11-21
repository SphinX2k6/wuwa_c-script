using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000812 RID: 2066
	public sealed class InstLevelPlayStateReq : IMessage<InstLevelPlayStateReq>, IMessage, IEquatable<InstLevelPlayStateReq>, IDeepCloneable<InstLevelPlayStateReq>, IBufferMessage
	{
		// Token: 0x0600B912 RID: 47378 RVA: 0x001B9189 File Offset: 0x001B7389
		[NullableContext(1)]
		public static InstLevelPlayStateReq Create()
		{
			return new InstLevelPlayStateReq();
		}

		// Token: 0x1700254C RID: 9548
		// (get) Token: 0x0600B913 RID: 47379 RVA: 0x001B9190 File Offset: 0x001B7390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InstLevelPlayStateReq> Parser
		{
			get
			{
				return InstLevelPlayStateReq._parser;
			}
		}

		// Token: 0x1700254D RID: 9549
		// (get) Token: 0x0600B914 RID: 47380 RVA: 0x001B9197 File Offset: 0x001B7397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700254E RID: 9550
		// (get) Token: 0x0600B915 RID: 47381 RVA: 0x001B919A File Offset: 0x001B739A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstLevelPlayStateReq.Descriptor;
			}
		}

		// Token: 0x0600B916 RID: 47382 RVA: 0x001B91A1 File Offset: 0x001B73A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstLevelPlayStateReq()
		{
		}

		// Token: 0x0600B917 RID: 47383 RVA: 0x001B91B4 File Offset: 0x001B73B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstLevelPlayStateReq(InstLevelPlayStateReq other) : this()
		{
			this.instId_ = other.instId_;
			this.levelPlayIds_ = other.levelPlayIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B918 RID: 47384 RVA: 0x001B91EA File Offset: 0x001B73EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstLevelPlayStateReq Clone()
		{
			return new InstLevelPlayStateReq(this);
		}

		// Token: 0x1700254F RID: 9551
		// (get) Token: 0x0600B919 RID: 47385 RVA: 0x001B91F2 File Offset: 0x001B73F2
		// (set) Token: 0x0600B91A RID: 47386 RVA: 0x001B91FA File Offset: 0x001B73FA
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

		// Token: 0x17002550 RID: 9552
		// (get) Token: 0x0600B91B RID: 47387 RVA: 0x001B9203 File Offset: 0x001B7403
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> LevelPlayIds
		{
			get
			{
				return this.levelPlayIds_;
			}
		}

		// Token: 0x0600B91C RID: 47388 RVA: 0x001B920B File Offset: 0x001B740B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstLevelPlayStateReq);
		}

		// Token: 0x0600B91D RID: 47389 RVA: 0x001B921C File Offset: 0x001B741C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstLevelPlayStateReq other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.levelPlayIds_.Equals(other.levelPlayIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B91E RID: 47390 RVA: 0x001B926C File Offset: 0x001B746C
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

		// Token: 0x0600B91F RID: 47391 RVA: 0x001B92B9 File Offset: 0x001B74B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B920 RID: 47392 RVA: 0x001B92C6 File Offset: 0x001B74C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B921 RID: 47393 RVA: 0x001B92D0 File Offset: 0x001B74D0
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

		// Token: 0x0600B922 RID: 47394 RVA: 0x001B9320 File Offset: 0x001B7520
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

		// Token: 0x0600B923 RID: 47395 RVA: 0x001B9374 File Offset: 0x001B7574
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

		// Token: 0x0600B924 RID: 47396 RVA: 0x001B93C1 File Offset: 0x001B75C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B925 RID: 47397 RVA: 0x001B93CC File Offset: 0x001B75CC
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

		// Token: 0x040051CD RID: 20941
		private static readonly MessageParser<InstLevelPlayStateReq> _parser = new MessageParser<InstLevelPlayStateReq>(() => new InstLevelPlayStateReq());

		// Token: 0x040051CE RID: 20942
		private UnknownFieldSet _unknownFields;

		// Token: 0x040051CF RID: 20943
		public const int InstIdFieldNumber = 1;

		// Token: 0x040051D0 RID: 20944
		private int instId_;

		// Token: 0x040051D1 RID: 20945
		public const int LevelPlayIdsFieldNumber = 2;

		// Token: 0x040051D2 RID: 20946
		private static readonly FieldCodec<int> _repeated_levelPlayIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040051D3 RID: 20947
		private readonly RepeatedField<int> levelPlayIds_ = new RepeatedField<int>();
	}
}
