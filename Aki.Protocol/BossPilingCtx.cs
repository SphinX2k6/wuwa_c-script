using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001C3 RID: 451
	public sealed class BossPilingCtx : IMessage<BossPilingCtx>, IMessage, IEquatable<BossPilingCtx>, IDeepCloneable<BossPilingCtx>, IBufferMessage
	{
		// Token: 0x060033D5 RID: 13269 RVA: 0x00082F8F File Offset: 0x0008118F
		[NullableContext(1)]
		public static BossPilingCtx Create()
		{
			return new BossPilingCtx();
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x060033D6 RID: 13270 RVA: 0x00082F96 File Offset: 0x00081196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x060033D7 RID: 13271 RVA: 0x00082F99 File Offset: 0x00081199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossPilingCtx.Descriptor;
			}
		}

		// Token: 0x060033D8 RID: 13272 RVA: 0x00082FA0 File Offset: 0x000811A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingCtx()
		{
		}

		// Token: 0x060033D9 RID: 13273 RVA: 0x00082FB3 File Offset: 0x000811B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingCtx(BossPilingCtx other) : this()
		{
			this.bossPilingLevelId_ = other.bossPilingLevelId_;
			this.skillBranchId_ = other.skillBranchId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060033DA RID: 13274 RVA: 0x00082FE9 File Offset: 0x000811E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingCtx Clone()
		{
			return new BossPilingCtx(this);
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x060033DB RID: 13275 RVA: 0x00082FF1 File Offset: 0x000811F1
		// (set) Token: 0x060033DC RID: 13276 RVA: 0x00082FF9 File Offset: 0x000811F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BossPilingLevelId
		{
			get
			{
				return this.bossPilingLevelId_;
			}
			set
			{
				this.bossPilingLevelId_ = value;
			}
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x060033DD RID: 13277 RVA: 0x00083002 File Offset: 0x00081202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkillBranchId
		{
			get
			{
				return this.skillBranchId_;
			}
		}

		// Token: 0x060033DE RID: 13278 RVA: 0x0008300A File Offset: 0x0008120A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossPilingCtx);
		}

		// Token: 0x060033DF RID: 13279 RVA: 0x00083018 File Offset: 0x00081218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossPilingCtx other)
		{
			return other != null && (other == this || (this.BossPilingLevelId == other.BossPilingLevelId && this.skillBranchId_.Equals(other.skillBranchId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060033E0 RID: 13280 RVA: 0x00083068 File Offset: 0x00081268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BossPilingLevelId != 0)
			{
				num ^= this.BossPilingLevelId.GetHashCode();
			}
			num ^= this.skillBranchId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060033E1 RID: 13281 RVA: 0x000830B5 File Offset: 0x000812B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060033E2 RID: 13282 RVA: 0x000830C2 File Offset: 0x000812C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060033E3 RID: 13283 RVA: 0x000830CC File Offset: 0x000812CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BossPilingLevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BossPilingLevelId);
			}
			this.skillBranchId_.WriteTo(ref output, BossPilingCtx._repeated_skillBranchId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060033E4 RID: 13284 RVA: 0x0008311C File Offset: 0x0008131C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BossPilingLevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BossPilingLevelId);
			}
			num += this.skillBranchId_.CalculateSize(BossPilingCtx._repeated_skillBranchId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060033E5 RID: 13285 RVA: 0x00083170 File Offset: 0x00081370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossPilingCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BossPilingLevelId != 0)
			{
				this.BossPilingLevelId = other.BossPilingLevelId;
			}
			this.skillBranchId_.Add(other.skillBranchId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060033E6 RID: 13286 RVA: 0x000831BD File Offset: 0x000813BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060033E7 RID: 13287 RVA: 0x000831C8 File Offset: 0x000813C8
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
						this.skillBranchId_.AddEntriesFrom(ref input, BossPilingCtx._repeated_skillBranchId_codec);
					}
				}
				else
				{
					this.BossPilingLevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040029D7 RID: 10711
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029D8 RID: 10712
		public const int BossPilingLevelIdFieldNumber = 1;

		// Token: 0x040029D9 RID: 10713
		private int bossPilingLevelId_;

		// Token: 0x040029DA RID: 10714
		public const int SkillBranchIdFieldNumber = 2;

		// Token: 0x040029DB RID: 10715
		private static readonly FieldCodec<int> _repeated_skillBranchId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040029DC RID: 10716
		private readonly RepeatedField<int> skillBranchId_ = new RepeatedField<int>();
	}
}
