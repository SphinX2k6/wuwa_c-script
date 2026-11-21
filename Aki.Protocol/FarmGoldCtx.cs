using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000507 RID: 1287
	public sealed class FarmGoldCtx : IMessage<FarmGoldCtx>, IMessage, IEquatable<FarmGoldCtx>, IDeepCloneable<FarmGoldCtx>, IBufferMessage
	{
		// Token: 0x06007973 RID: 31091 RVA: 0x00127734 File Offset: 0x00125934
		[NullableContext(1)]
		public static FarmGoldCtx Create()
		{
			return new FarmGoldCtx();
		}

		// Token: 0x17001786 RID: 6022
		// (get) Token: 0x06007974 RID: 31092 RVA: 0x0012773B File Offset: 0x0012593B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001787 RID: 6023
		// (get) Token: 0x06007975 RID: 31093 RVA: 0x0012773E File Offset: 0x0012593E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FarmGoldCtx.Descriptor;
			}
		}

		// Token: 0x06007976 RID: 31094 RVA: 0x00127745 File Offset: 0x00125945
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldCtx()
		{
		}

		// Token: 0x06007977 RID: 31095 RVA: 0x00127758 File Offset: 0x00125958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldCtx(FarmGoldCtx other) : this()
		{
			this.skillBranchId_ = other.skillBranchId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007978 RID: 31096 RVA: 0x00127782 File Offset: 0x00125982
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldCtx Clone()
		{
			return new FarmGoldCtx(this);
		}

		// Token: 0x17001788 RID: 6024
		// (get) Token: 0x06007979 RID: 31097 RVA: 0x0012778A File Offset: 0x0012598A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkillBranchId
		{
			get
			{
				return this.skillBranchId_;
			}
		}

		// Token: 0x0600797A RID: 31098 RVA: 0x00127792 File Offset: 0x00125992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FarmGoldCtx);
		}

		// Token: 0x0600797B RID: 31099 RVA: 0x001277A0 File Offset: 0x001259A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FarmGoldCtx other)
		{
			return other != null && (other == this || (this.skillBranchId_.Equals(other.skillBranchId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600797C RID: 31100 RVA: 0x001277D4 File Offset: 0x001259D4
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

		// Token: 0x0600797D RID: 31101 RVA: 0x00127808 File Offset: 0x00125A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600797E RID: 31102 RVA: 0x00127815 File Offset: 0x00125A15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600797F RID: 31103 RVA: 0x0012781E File Offset: 0x00125A1E
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

		// Token: 0x06007980 RID: 31104 RVA: 0x00127848 File Offset: 0x00125A48
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

		// Token: 0x06007981 RID: 31105 RVA: 0x00127881 File Offset: 0x00125A81
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

		// Token: 0x06007982 RID: 31106 RVA: 0x001278AF File Offset: 0x00125AAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007983 RID: 31107 RVA: 0x001278B8 File Offset: 0x00125AB8
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

		// Token: 0x04003EF8 RID: 16120
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EF9 RID: 16121
		public const int SkillBranchIdFieldNumber = 1;

		// Token: 0x04003EFA RID: 16122
		private static readonly FieldCodec<int> _repeated_skillBranchId_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04003EFB RID: 16123
		private readonly RepeatedField<int> skillBranchId_ = new RepeatedField<int>();
	}
}
