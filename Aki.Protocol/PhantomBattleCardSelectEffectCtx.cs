using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C4F RID: 3151
	public sealed class PhantomBattleCardSelectEffectCtx : IMessage<PhantomBattleCardSelectEffectCtx>, IMessage, IEquatable<PhantomBattleCardSelectEffectCtx>, IDeepCloneable<PhantomBattleCardSelectEffectCtx>, IBufferMessage
	{
		// Token: 0x060111B0 RID: 70064 RVA: 0x002818FA File Offset: 0x0027FAFA
		[NullableContext(1)]
		public static PhantomBattleCardSelectEffectCtx Create()
		{
			return new PhantomBattleCardSelectEffectCtx();
		}

		// Token: 0x17003889 RID: 14473
		// (get) Token: 0x060111B1 RID: 70065 RVA: 0x00281901 File Offset: 0x0027FB01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700388A RID: 14474
		// (get) Token: 0x060111B2 RID: 70066 RVA: 0x00281904 File Offset: 0x0027FB04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardSelectEffectCtx.Descriptor;
			}
		}

		// Token: 0x060111B3 RID: 70067 RVA: 0x0028190B File Offset: 0x0027FB0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardSelectEffectCtx()
		{
		}

		// Token: 0x060111B4 RID: 70068 RVA: 0x0028191E File Offset: 0x0027FB1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardSelectEffectCtx(PhantomBattleCardSelectEffectCtx other) : this()
		{
			this.phantomBattleHandCardInfos_ = other.phantomBattleHandCardInfos_.Clone();
			this.selectCount_ = other.selectCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060111B5 RID: 70069 RVA: 0x00281954 File Offset: 0x0027FB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardSelectEffectCtx Clone()
		{
			return new PhantomBattleCardSelectEffectCtx(this);
		}

		// Token: 0x1700388B RID: 14475
		// (get) Token: 0x060111B6 RID: 70070 RVA: 0x0028195C File Offset: 0x0027FB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleHandCardInfo> PhantomBattleHandCardInfos
		{
			get
			{
				return this.phantomBattleHandCardInfos_;
			}
		}

		// Token: 0x1700388C RID: 14476
		// (get) Token: 0x060111B7 RID: 70071 RVA: 0x00281964 File Offset: 0x0027FB64
		// (set) Token: 0x060111B8 RID: 70072 RVA: 0x0028196C File Offset: 0x0027FB6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SelectCount
		{
			get
			{
				return this.selectCount_;
			}
			set
			{
				this.selectCount_ = value;
			}
		}

		// Token: 0x060111B9 RID: 70073 RVA: 0x00281975 File Offset: 0x0027FB75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardSelectEffectCtx);
		}

		// Token: 0x060111BA RID: 70074 RVA: 0x00281984 File Offset: 0x0027FB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardSelectEffectCtx other)
		{
			return other != null && (other == this || (this.phantomBattleHandCardInfos_.Equals(other.phantomBattleHandCardInfos_) && this.SelectCount == other.SelectCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060111BB RID: 70075 RVA: 0x002819D4 File Offset: 0x0027FBD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.phantomBattleHandCardInfos_.GetHashCode();
			if (this.SelectCount != 0)
			{
				num ^= this.SelectCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060111BC RID: 70076 RVA: 0x00281A21 File Offset: 0x0027FC21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060111BD RID: 70077 RVA: 0x00281A2E File Offset: 0x0027FC2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060111BE RID: 70078 RVA: 0x00281A38 File Offset: 0x0027FC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomBattleHandCardInfos_.WriteTo(ref output, PhantomBattleCardSelectEffectCtx._repeated_phantomBattleHandCardInfos_codec);
			if (this.SelectCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SelectCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060111BF RID: 70079 RVA: 0x00281A88 File Offset: 0x0027FC88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantomBattleHandCardInfos_.CalculateSize(PhantomBattleCardSelectEffectCtx._repeated_phantomBattleHandCardInfos_codec);
			if (this.SelectCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SelectCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060111C0 RID: 70080 RVA: 0x00281ADC File Offset: 0x0027FCDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardSelectEffectCtx other)
		{
			if (other == null)
			{
				return;
			}
			this.phantomBattleHandCardInfos_.Add(other.phantomBattleHandCardInfos_);
			if (other.SelectCount != 0)
			{
				this.SelectCount = other.SelectCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060111C1 RID: 70081 RVA: 0x00281B29 File Offset: 0x0027FD29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060111C2 RID: 70082 RVA: 0x00281B34 File Offset: 0x0027FD34
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SelectCount = input.ReadInt32();
					}
				}
				else
				{
					this.phantomBattleHandCardInfos_.AddEntriesFrom(ref input, PhantomBattleCardSelectEffectCtx._repeated_phantomBattleHandCardInfos_codec);
				}
			}
		}

		// Token: 0x04006CB4 RID: 27828
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006CB5 RID: 27829
		public const int PhantomBattleHandCardInfosFieldNumber = 1;

		// Token: 0x04006CB6 RID: 27830
		private static readonly FieldCodec<PhantomBattleHandCardInfo> _repeated_phantomBattleHandCardInfos_codec = FieldCodec.ForMessage<PhantomBattleHandCardInfo>(10U, PhantomBattleHandCardInfo.Parser);

		// Token: 0x04006CB7 RID: 27831
		private readonly RepeatedField<PhantomBattleHandCardInfo> phantomBattleHandCardInfos_ = new RepeatedField<PhantomBattleHandCardInfo>();

		// Token: 0x04006CB8 RID: 27832
		public const int SelectCountFieldNumber = 2;

		// Token: 0x04006CB9 RID: 27833
		private int selectCount_;
	}
}
