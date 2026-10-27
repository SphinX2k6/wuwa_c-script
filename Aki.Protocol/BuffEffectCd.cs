using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001FA RID: 506
	public sealed class BuffEffectCd : IMessage<BuffEffectCd>, IMessage, IEquatable<BuffEffectCd>, IDeepCloneable<BuffEffectCd>, IBufferMessage
	{
		// Token: 0x0600383F RID: 14399 RVA: 0x0008CA33 File Offset: 0x0008AC33
		[NullableContext(1)]
		public static BuffEffectCd Create()
		{
			return new BuffEffectCd();
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06003840 RID: 14400 RVA: 0x0008CA3A File Offset: 0x0008AC3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BuffEffectCd> Parser
		{
			get
			{
				return BuffEffectCd._parser;
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06003841 RID: 14401 RVA: 0x0008CA41 File Offset: 0x0008AC41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06003842 RID: 14402 RVA: 0x0008CA44 File Offset: 0x0008AC44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffEffectCd.Descriptor;
			}
		}

		// Token: 0x06003843 RID: 14403 RVA: 0x0008CA4B File Offset: 0x0008AC4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectCd()
		{
		}

		// Token: 0x06003844 RID: 14404 RVA: 0x0008CA5E File Offset: 0x0008AC5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectCd(BuffEffectCd other) : this()
		{
			this.buffId_ = other.buffId_;
			this.listCdRemaining_ = other.listCdRemaining_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003845 RID: 14405 RVA: 0x0008CA94 File Offset: 0x0008AC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectCd Clone()
		{
			return new BuffEffectCd(this);
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06003846 RID: 14406 RVA: 0x0008CA9C File Offset: 0x0008AC9C
		// (set) Token: 0x06003847 RID: 14407 RVA: 0x0008CAA4 File Offset: 0x0008ACA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BuffId
		{
			get
			{
				return this.buffId_;
			}
			set
			{
				this.buffId_ = value;
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06003848 RID: 14408 RVA: 0x0008CAAD File Offset: 0x0008ACAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ListCdRemaining
		{
			get
			{
				return this.listCdRemaining_;
			}
		}

		// Token: 0x06003849 RID: 14409 RVA: 0x0008CAB5 File Offset: 0x0008ACB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffEffectCd);
		}

		// Token: 0x0600384A RID: 14410 RVA: 0x0008CAC4 File Offset: 0x0008ACC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffEffectCd other)
		{
			return other != null && (other == this || (this.BuffId == other.BuffId && this.listCdRemaining_.Equals(other.listCdRemaining_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600384B RID: 14411 RVA: 0x0008CB14 File Offset: 0x0008AD14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuffId != 0L)
			{
				num ^= this.BuffId.GetHashCode();
			}
			num ^= this.listCdRemaining_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600384C RID: 14412 RVA: 0x0008CB61 File Offset: 0x0008AD61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600384D RID: 14413 RVA: 0x0008CB6E File Offset: 0x0008AD6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600384E RID: 14414 RVA: 0x0008CB78 File Offset: 0x0008AD78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuffId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.BuffId);
			}
			this.listCdRemaining_.WriteTo(ref output, BuffEffectCd._repeated_listCdRemaining_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600384F RID: 14415 RVA: 0x0008CBC8 File Offset: 0x0008ADC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuffId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BuffId);
			}
			num += this.listCdRemaining_.CalculateSize(BuffEffectCd._repeated_listCdRemaining_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003850 RID: 14416 RVA: 0x0008CC1C File Offset: 0x0008AE1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuffEffectCd other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuffId != 0L)
			{
				this.BuffId = other.BuffId;
			}
			this.listCdRemaining_.Add(other.listCdRemaining_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003851 RID: 14417 RVA: 0x0008CC69 File Offset: 0x0008AE69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003852 RID: 14418 RVA: 0x0008CC74 File Offset: 0x0008AE74
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
						this.listCdRemaining_.AddEntriesFrom(ref input, BuffEffectCd._repeated_listCdRemaining_codec);
					}
				}
				else
				{
					this.BuffId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002B29 RID: 11049
		private static readonly MessageParser<BuffEffectCd> _parser = new MessageParser<BuffEffectCd>(() => new BuffEffectCd());

		// Token: 0x04002B2A RID: 11050
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B2B RID: 11051
		public const int BuffIdFieldNumber = 1;

		// Token: 0x04002B2C RID: 11052
		private long buffId_;

		// Token: 0x04002B2D RID: 11053
		public const int ListCdRemainingFieldNumber = 2;

		// Token: 0x04002B2E RID: 11054
		private static readonly FieldCodec<int> _repeated_listCdRemaining_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04002B2F RID: 11055
		private readonly RepeatedField<int> listCdRemaining_ = new RepeatedField<int>();
	}
}
