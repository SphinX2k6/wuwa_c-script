using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000220 RID: 544
	public sealed class CalabashDevelopInfo : IMessage<CalabashDevelopInfo>, IMessage, IEquatable<CalabashDevelopInfo>, IDeepCloneable<CalabashDevelopInfo>, IBufferMessage
	{
		// Token: 0x06003BAC RID: 15276 RVA: 0x00094BB7 File Offset: 0x00092DB7
		[NullableContext(1)]
		public static CalabashDevelopInfo Create()
		{
			return new CalabashDevelopInfo();
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06003BAD RID: 15277 RVA: 0x00094BBE File Offset: 0x00092DBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CalabashDevelopInfo> Parser
		{
			get
			{
				return CalabashDevelopInfo._parser;
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06003BAE RID: 15278 RVA: 0x00094BC5 File Offset: 0x00092DC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06003BAF RID: 15279 RVA: 0x00094BC8 File Offset: 0x00092DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CalabashDevelopInfo.Descriptor;
			}
		}

		// Token: 0x06003BB0 RID: 15280 RVA: 0x00094BCF File Offset: 0x00092DCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashDevelopInfo()
		{
		}

		// Token: 0x06003BB1 RID: 15281 RVA: 0x00094BE2 File Offset: 0x00092DE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashDevelopInfo(CalabashDevelopInfo other) : this()
		{
			this.monsterId_ = other.monsterId_;
			this.unlockConditions_ = other.unlockConditions_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003BB2 RID: 15282 RVA: 0x00094C18 File Offset: 0x00092E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashDevelopInfo Clone()
		{
			return new CalabashDevelopInfo(this);
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06003BB3 RID: 15283 RVA: 0x00094C20 File Offset: 0x00092E20
		// (set) Token: 0x06003BB4 RID: 15284 RVA: 0x00094C28 File Offset: 0x00092E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MonsterId
		{
			get
			{
				return this.monsterId_;
			}
			set
			{
				this.monsterId_ = value;
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06003BB5 RID: 15285 RVA: 0x00094C31 File Offset: 0x00092E31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CalabashDevelopConditionState> UnlockConditions
		{
			get
			{
				return this.unlockConditions_;
			}
		}

		// Token: 0x06003BB6 RID: 15286 RVA: 0x00094C39 File Offset: 0x00092E39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CalabashDevelopInfo);
		}

		// Token: 0x06003BB7 RID: 15287 RVA: 0x00094C48 File Offset: 0x00092E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CalabashDevelopInfo other)
		{
			return other != null && (other == this || (this.MonsterId == other.MonsterId && this.unlockConditions_.Equals(other.unlockConditions_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003BB8 RID: 15288 RVA: 0x00094C98 File Offset: 0x00092E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MonsterId != 0)
			{
				num ^= this.MonsterId.GetHashCode();
			}
			num ^= this.unlockConditions_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003BB9 RID: 15289 RVA: 0x00094CE5 File Offset: 0x00092EE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003BBA RID: 15290 RVA: 0x00094CF2 File Offset: 0x00092EF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003BBB RID: 15291 RVA: 0x00094CFC File Offset: 0x00092EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MonsterId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MonsterId);
			}
			this.unlockConditions_.WriteTo(ref output, CalabashDevelopInfo._repeated_unlockConditions_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003BBC RID: 15292 RVA: 0x00094D4C File Offset: 0x00092F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MonsterId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MonsterId);
			}
			num += this.unlockConditions_.CalculateSize(CalabashDevelopInfo._repeated_unlockConditions_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003BBD RID: 15293 RVA: 0x00094DA0 File Offset: 0x00092FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CalabashDevelopInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MonsterId != 0)
			{
				this.MonsterId = other.MonsterId;
			}
			this.unlockConditions_.Add(other.unlockConditions_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003BBE RID: 15294 RVA: 0x00094DED File Offset: 0x00092FED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003BBF RID: 15295 RVA: 0x00094DF8 File Offset: 0x00092FF8
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.unlockConditions_.AddEntriesFrom(ref input, CalabashDevelopInfo._repeated_unlockConditions_codec);
					}
				}
				else
				{
					this.MonsterId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002C8A RID: 11402
		private static readonly MessageParser<CalabashDevelopInfo> _parser = new MessageParser<CalabashDevelopInfo>(() => new CalabashDevelopInfo());

		// Token: 0x04002C8B RID: 11403
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C8C RID: 11404
		public const int MonsterIdFieldNumber = 1;

		// Token: 0x04002C8D RID: 11405
		private int monsterId_;

		// Token: 0x04002C8E RID: 11406
		public const int UnlockConditionsFieldNumber = 2;

		// Token: 0x04002C8F RID: 11407
		private static readonly FieldCodec<CalabashDevelopConditionState> _repeated_unlockConditions_codec = FieldCodec.ForMessage<CalabashDevelopConditionState>(18U, CalabashDevelopConditionState.Parser);

		// Token: 0x04002C90 RID: 11408
		private readonly RepeatedField<CalabashDevelopConditionState> unlockConditions_ = new RepeatedField<CalabashDevelopConditionState>();
	}
}
