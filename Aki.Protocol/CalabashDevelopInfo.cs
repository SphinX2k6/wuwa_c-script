using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200021B RID: 539
	public sealed class CalabashDevelopInfo : IMessage<CalabashDevelopInfo>, IMessage, IEquatable<CalabashDevelopInfo>, IDeepCloneable<CalabashDevelopInfo>, IBufferMessage
	{
		// Token: 0x06003B07 RID: 15111 RVA: 0x00092F9F File Offset: 0x0009119F
		[NullableContext(1)]
		public static CalabashDevelopInfo Create()
		{
			return new CalabashDevelopInfo();
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06003B08 RID: 15112 RVA: 0x00092FA6 File Offset: 0x000911A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CalabashDevelopInfo> Parser
		{
			get
			{
				return CalabashDevelopInfo._parser;
			}
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06003B09 RID: 15113 RVA: 0x00092FAD File Offset: 0x000911AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x06003B0A RID: 15114 RVA: 0x00092FB0 File Offset: 0x000911B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CalabashDevelopInfo.Descriptor;
			}
		}

		// Token: 0x06003B0B RID: 15115 RVA: 0x00092FB7 File Offset: 0x000911B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashDevelopInfo()
		{
		}

		// Token: 0x06003B0C RID: 15116 RVA: 0x00092FCA File Offset: 0x000911CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashDevelopInfo(CalabashDevelopInfo other) : this()
		{
			this.monsterId_ = other.monsterId_;
			this.unlockConditions_ = other.unlockConditions_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003B0D RID: 15117 RVA: 0x00093000 File Offset: 0x00091200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashDevelopInfo Clone()
		{
			return new CalabashDevelopInfo(this);
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x06003B0E RID: 15118 RVA: 0x00093008 File Offset: 0x00091208
		// (set) Token: 0x06003B0F RID: 15119 RVA: 0x00093010 File Offset: 0x00091210
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

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06003B10 RID: 15120 RVA: 0x00093019 File Offset: 0x00091219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CalabashDevelopConditionState> UnlockConditions
		{
			get
			{
				return this.unlockConditions_;
			}
		}

		// Token: 0x06003B11 RID: 15121 RVA: 0x00093021 File Offset: 0x00091221
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CalabashDevelopInfo);
		}

		// Token: 0x06003B12 RID: 15122 RVA: 0x00093030 File Offset: 0x00091230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CalabashDevelopInfo other)
		{
			return other != null && (other == this || (this.MonsterId == other.MonsterId && this.unlockConditions_.Equals(other.unlockConditions_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003B13 RID: 15123 RVA: 0x00093080 File Offset: 0x00091280
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

		// Token: 0x06003B14 RID: 15124 RVA: 0x000930CD File Offset: 0x000912CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003B15 RID: 15125 RVA: 0x000930DA File Offset: 0x000912DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003B16 RID: 15126 RVA: 0x000930E4 File Offset: 0x000912E4
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

		// Token: 0x06003B17 RID: 15127 RVA: 0x00093134 File Offset: 0x00091334
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

		// Token: 0x06003B18 RID: 15128 RVA: 0x00093188 File Offset: 0x00091388
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

		// Token: 0x06003B19 RID: 15129 RVA: 0x000931D5 File Offset: 0x000913D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003B1A RID: 15130 RVA: 0x000931E0 File Offset: 0x000913E0
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

		// Token: 0x04002C08 RID: 11272
		private static readonly MessageParser<CalabashDevelopInfo> _parser = new MessageParser<CalabashDevelopInfo>(() => new CalabashDevelopInfo());

		// Token: 0x04002C09 RID: 11273
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C0A RID: 11274
		public const int MonsterIdFieldNumber = 1;

		// Token: 0x04002C0B RID: 11275
		private int monsterId_;

		// Token: 0x04002C0C RID: 11276
		public const int UnlockConditionsFieldNumber = 2;

		// Token: 0x04002C0D RID: 11277
		private static readonly FieldCodec<CalabashDevelopConditionState> _repeated_unlockConditions_codec = FieldCodec.ForMessage<CalabashDevelopConditionState>(18U, CalabashDevelopConditionState.Parser);

		// Token: 0x04002C0E RID: 11278
		private readonly RepeatedField<CalabashDevelopConditionState> unlockConditions_ = new RepeatedField<CalabashDevelopConditionState>();
	}
}
