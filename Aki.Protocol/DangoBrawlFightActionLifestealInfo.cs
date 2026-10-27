using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000351 RID: 849
	public sealed class DangoBrawlFightActionLifestealInfo : IMessage<DangoBrawlFightActionLifestealInfo>, IMessage, IEquatable<DangoBrawlFightActionLifestealInfo>, IDeepCloneable<DangoBrawlFightActionLifestealInfo>, IBufferMessage
	{
		// Token: 0x060054EB RID: 21739 RVA: 0x000CF8B7 File Offset: 0x000CDAB7
		[NullableContext(1)]
		public static DangoBrawlFightActionLifestealInfo Create()
		{
			return new DangoBrawlFightActionLifestealInfo();
		}

		// Token: 0x17000F83 RID: 3971
		// (get) Token: 0x060054EC RID: 21740 RVA: 0x000CF8BE File Offset: 0x000CDABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F84 RID: 3972
		// (get) Token: 0x060054ED RID: 21741 RVA: 0x000CF8C1 File Offset: 0x000CDAC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFightActionLifestealInfo.Descriptor;
			}
		}

		// Token: 0x060054EE RID: 21742 RVA: 0x000CF8C8 File Offset: 0x000CDAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionLifestealInfo()
		{
		}

		// Token: 0x060054EF RID: 21743 RVA: 0x000CF8DB File Offset: 0x000CDADB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionLifestealInfo(DangoBrawlFightActionLifestealInfo other) : this()
		{
			this.targetFighterUId_ = other.targetFighterUId_;
			this.healValues_ = other.healValues_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060054F0 RID: 21744 RVA: 0x000CF911 File Offset: 0x000CDB11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionLifestealInfo Clone()
		{
			return new DangoBrawlFightActionLifestealInfo(this);
		}

		// Token: 0x17000F85 RID: 3973
		// (get) Token: 0x060054F1 RID: 21745 RVA: 0x000CF919 File Offset: 0x000CDB19
		// (set) Token: 0x060054F2 RID: 21746 RVA: 0x000CF921 File Offset: 0x000CDB21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetFighterUId
		{
			get
			{
				return this.targetFighterUId_;
			}
			set
			{
				this.targetFighterUId_ = value;
			}
		}

		// Token: 0x17000F86 RID: 3974
		// (get) Token: 0x060054F3 RID: 21747 RVA: 0x000CF92A File Offset: 0x000CDB2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> HealValues
		{
			get
			{
				return this.healValues_;
			}
		}

		// Token: 0x060054F4 RID: 21748 RVA: 0x000CF932 File Offset: 0x000CDB32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFightActionLifestealInfo);
		}

		// Token: 0x060054F5 RID: 21749 RVA: 0x000CF940 File Offset: 0x000CDB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFightActionLifestealInfo other)
		{
			return other != null && (other == this || (this.TargetFighterUId == other.TargetFighterUId && this.healValues_.Equals(other.healValues_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060054F6 RID: 21750 RVA: 0x000CF990 File Offset: 0x000CDB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetFighterUId != 0)
			{
				num ^= this.TargetFighterUId.GetHashCode();
			}
			num ^= this.healValues_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060054F7 RID: 21751 RVA: 0x000CF9DD File Offset: 0x000CDBDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060054F8 RID: 21752 RVA: 0x000CF9EA File Offset: 0x000CDBEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060054F9 RID: 21753 RVA: 0x000CF9F4 File Offset: 0x000CDBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetFighterUId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TargetFighterUId);
			}
			this.healValues_.WriteTo(ref output, DangoBrawlFightActionLifestealInfo._repeated_healValues_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060054FA RID: 21754 RVA: 0x000CFA44 File Offset: 0x000CDC44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetFighterUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetFighterUId);
			}
			num += this.healValues_.CalculateSize(DangoBrawlFightActionLifestealInfo._repeated_healValues_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060054FB RID: 21755 RVA: 0x000CFA98 File Offset: 0x000CDC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlFightActionLifestealInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetFighterUId != 0)
			{
				this.TargetFighterUId = other.TargetFighterUId;
			}
			this.healValues_.Add(other.healValues_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060054FC RID: 21756 RVA: 0x000CFAE5 File Offset: 0x000CDCE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060054FD RID: 21757 RVA: 0x000CFAF0 File Offset: 0x000CDCF0
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
						this.healValues_.AddEntriesFrom(ref input, DangoBrawlFightActionLifestealInfo._repeated_healValues_codec);
					}
				}
				else
				{
					this.TargetFighterUId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040033F8 RID: 13304
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033F9 RID: 13305
		public const int TargetFighterUIdFieldNumber = 1;

		// Token: 0x040033FA RID: 13306
		private int targetFighterUId_;

		// Token: 0x040033FB RID: 13307
		public const int HealValuesFieldNumber = 2;

		// Token: 0x040033FC RID: 13308
		private static readonly FieldCodec<int> _repeated_healValues_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040033FD RID: 13309
		private readonly RepeatedField<int> healValues_ = new RepeatedField<int>();
	}
}
