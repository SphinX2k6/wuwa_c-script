using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C5F RID: 3167
	public sealed class PhantomBattleCardSelectEffectCtx : IMessage<PhantomBattleCardSelectEffectCtx>, IMessage, IEquatable<PhantomBattleCardSelectEffectCtx>, IDeepCloneable<PhantomBattleCardSelectEffectCtx>, IBufferMessage
	{
		// Token: 0x060112B0 RID: 70320 RVA: 0x00283669 File Offset: 0x00281869
		[NullableContext(1)]
		public static PhantomBattleCardSelectEffectCtx Create()
		{
			return new PhantomBattleCardSelectEffectCtx();
		}

		// Token: 0x170038C0 RID: 14528
		// (get) Token: 0x060112B1 RID: 70321 RVA: 0x00283670 File Offset: 0x00281870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170038C1 RID: 14529
		// (get) Token: 0x060112B2 RID: 70322 RVA: 0x00283673 File Offset: 0x00281873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardSelectEffectCtx.Descriptor;
			}
		}

		// Token: 0x060112B3 RID: 70323 RVA: 0x0028367A File Offset: 0x0028187A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardSelectEffectCtx()
		{
		}

		// Token: 0x060112B4 RID: 70324 RVA: 0x0028368D File Offset: 0x0028188D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardSelectEffectCtx(PhantomBattleCardSelectEffectCtx other) : this()
		{
			this.phantomBattleHandCardInfos_ = other.phantomBattleHandCardInfos_.Clone();
			this.selectCount_ = other.selectCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060112B5 RID: 70325 RVA: 0x002836C3 File Offset: 0x002818C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardSelectEffectCtx Clone()
		{
			return new PhantomBattleCardSelectEffectCtx(this);
		}

		// Token: 0x170038C2 RID: 14530
		// (get) Token: 0x060112B6 RID: 70326 RVA: 0x002836CB File Offset: 0x002818CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleHandCardInfo> PhantomBattleHandCardInfos
		{
			get
			{
				return this.phantomBattleHandCardInfos_;
			}
		}

		// Token: 0x170038C3 RID: 14531
		// (get) Token: 0x060112B7 RID: 70327 RVA: 0x002836D3 File Offset: 0x002818D3
		// (set) Token: 0x060112B8 RID: 70328 RVA: 0x002836DB File Offset: 0x002818DB
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

		// Token: 0x060112B9 RID: 70329 RVA: 0x002836E4 File Offset: 0x002818E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardSelectEffectCtx);
		}

		// Token: 0x060112BA RID: 70330 RVA: 0x002836F4 File Offset: 0x002818F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardSelectEffectCtx other)
		{
			return other != null && (other == this || (this.phantomBattleHandCardInfos_.Equals(other.phantomBattleHandCardInfos_) && this.SelectCount == other.SelectCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060112BB RID: 70331 RVA: 0x00283744 File Offset: 0x00281944
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

		// Token: 0x060112BC RID: 70332 RVA: 0x00283791 File Offset: 0x00281991
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060112BD RID: 70333 RVA: 0x0028379E File Offset: 0x0028199E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060112BE RID: 70334 RVA: 0x002837A8 File Offset: 0x002819A8
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

		// Token: 0x060112BF RID: 70335 RVA: 0x002837F8 File Offset: 0x002819F8
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

		// Token: 0x060112C0 RID: 70336 RVA: 0x0028384C File Offset: 0x00281A4C
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

		// Token: 0x060112C1 RID: 70337 RVA: 0x00283899 File Offset: 0x00281A99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060112C2 RID: 70338 RVA: 0x002838A4 File Offset: 0x00281AA4
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

		// Token: 0x04006CA0 RID: 27808
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006CA1 RID: 27809
		public const int PhantomBattleHandCardInfosFieldNumber = 1;

		// Token: 0x04006CA2 RID: 27810
		private static readonly FieldCodec<PhantomBattleHandCardInfo> _repeated_phantomBattleHandCardInfos_codec = FieldCodec.ForMessage<PhantomBattleHandCardInfo>(10U, PhantomBattleHandCardInfo.Parser);

		// Token: 0x04006CA3 RID: 27811
		private readonly RepeatedField<PhantomBattleHandCardInfo> phantomBattleHandCardInfos_ = new RepeatedField<PhantomBattleHandCardInfo>();

		// Token: 0x04006CA4 RID: 27812
		public const int SelectCountFieldNumber = 2;

		// Token: 0x04006CA5 RID: 27813
		private int selectCount_;
	}
}
