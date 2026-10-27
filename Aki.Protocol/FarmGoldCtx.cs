using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200051C RID: 1308
	public sealed class FarmGoldCtx : IMessage<FarmGoldCtx>, IMessage, IEquatable<FarmGoldCtx>, IDeepCloneable<FarmGoldCtx>, IBufferMessage
	{
		// Token: 0x06007ADB RID: 31451 RVA: 0x0012A330 File Offset: 0x00128530
		[NullableContext(1)]
		public static FarmGoldCtx Create()
		{
			return new FarmGoldCtx();
		}

		// Token: 0x170017D3 RID: 6099
		// (get) Token: 0x06007ADC RID: 31452 RVA: 0x0012A337 File Offset: 0x00128537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017D4 RID: 6100
		// (get) Token: 0x06007ADD RID: 31453 RVA: 0x0012A33A File Offset: 0x0012853A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FarmGoldCtx.Descriptor;
			}
		}

		// Token: 0x06007ADE RID: 31454 RVA: 0x0012A341 File Offset: 0x00128541
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldCtx()
		{
		}

		// Token: 0x06007ADF RID: 31455 RVA: 0x0012A354 File Offset: 0x00128554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldCtx(FarmGoldCtx other) : this()
		{
			this.skillBranchId_ = other.skillBranchId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007AE0 RID: 31456 RVA: 0x0012A37E File Offset: 0x0012857E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldCtx Clone()
		{
			return new FarmGoldCtx(this);
		}

		// Token: 0x170017D5 RID: 6101
		// (get) Token: 0x06007AE1 RID: 31457 RVA: 0x0012A386 File Offset: 0x00128586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkillBranchId
		{
			get
			{
				return this.skillBranchId_;
			}
		}

		// Token: 0x06007AE2 RID: 31458 RVA: 0x0012A38E File Offset: 0x0012858E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FarmGoldCtx);
		}

		// Token: 0x06007AE3 RID: 31459 RVA: 0x0012A39C File Offset: 0x0012859C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FarmGoldCtx other)
		{
			return other != null && (other == this || (this.skillBranchId_.Equals(other.skillBranchId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007AE4 RID: 31460 RVA: 0x0012A3D0 File Offset: 0x001285D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.skillBranchId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007AE5 RID: 31461 RVA: 0x0012A404 File Offset: 0x00128604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007AE6 RID: 31462 RVA: 0x0012A411 File Offset: 0x00128611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007AE7 RID: 31463 RVA: 0x0012A41A File Offset: 0x0012861A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.skillBranchId_.WriteTo(ref output, FarmGoldCtx._repeated_skillBranchId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007AE8 RID: 31464 RVA: 0x0012A444 File Offset: 0x00128644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.skillBranchId_.CalculateSize(FarmGoldCtx._repeated_skillBranchId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007AE9 RID: 31465 RVA: 0x0012A47D File Offset: 0x0012867D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FarmGoldCtx other)
		{
			if (other == null)
			{
				return;
			}
			this.skillBranchId_.Add(other.skillBranchId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007AEA RID: 31466 RVA: 0x0012A4AB File Offset: 0x001286AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007AEB RID: 31467 RVA: 0x0012A4B4 File Offset: 0x001286B4
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.skillBranchId_.AddEntriesFrom(ref input, FarmGoldCtx._repeated_skillBranchId_codec);
				}
			}
		}

		// Token: 0x04003F02 RID: 16130
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F03 RID: 16131
		public const int SkillBranchIdFieldNumber = 1;

		// Token: 0x04003F04 RID: 16132
		private static readonly FieldCodec<int> _repeated_skillBranchId_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04003F05 RID: 16133
		private readonly RepeatedField<int> skillBranchId_ = new RepeatedField<int>();
	}
}
