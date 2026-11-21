using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BC3 RID: 3011
	[NetMessage(EMessageId.PassiveSkillRemoveNotify)]
	public sealed class PassiveSkillRemoveNotify : IMessage<PassiveSkillRemoveNotify>, IMessage, IEquatable<PassiveSkillRemoveNotify>, IDeepCloneable<PassiveSkillRemoveNotify>, IBufferMessage
	{
		// Token: 0x06010547 RID: 66887 RVA: 0x00261FA1 File Offset: 0x002601A1
		[NullableContext(1)]
		public static PassiveSkillRemoveNotify Create()
		{
			return new PassiveSkillRemoveNotify();
		}

		// Token: 0x17003589 RID: 13705
		// (get) Token: 0x06010548 RID: 66888 RVA: 0x00261FA8 File Offset: 0x002601A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700358A RID: 13706
		// (get) Token: 0x06010549 RID: 66889 RVA: 0x00261FAB File Offset: 0x002601AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PassiveSkillRemoveNotify.Descriptor;
			}
		}

		// Token: 0x0601054A RID: 66890 RVA: 0x00261FB2 File Offset: 0x002601B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillRemoveNotify()
		{
		}

		// Token: 0x0601054B RID: 66891 RVA: 0x00261FC5 File Offset: 0x002601C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillRemoveNotify(PassiveSkillRemoveNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.skillIdList_ = other.skillIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601054C RID: 66892 RVA: 0x00261FFB File Offset: 0x002601FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillRemoveNotify Clone()
		{
			return new PassiveSkillRemoveNotify(this);
		}

		// Token: 0x1700358B RID: 13707
		// (get) Token: 0x0601054D RID: 66893 RVA: 0x00262003 File Offset: 0x00260203
		// (set) Token: 0x0601054E RID: 66894 RVA: 0x0026200B File Offset: 0x0026020B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x1700358C RID: 13708
		// (get) Token: 0x0601054F RID: 66895 RVA: 0x00262014 File Offset: 0x00260214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> SkillIdList
		{
			get
			{
				return this.skillIdList_;
			}
		}

		// Token: 0x06010550 RID: 66896 RVA: 0x0026201C File Offset: 0x0026021C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PassiveSkillRemoveNotify);
		}

		// Token: 0x06010551 RID: 66897 RVA: 0x0026202C File Offset: 0x0026022C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PassiveSkillRemoveNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.skillIdList_.Equals(other.skillIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010552 RID: 66898 RVA: 0x0026207C File Offset: 0x0026027C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			num ^= this.skillIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010553 RID: 66899 RVA: 0x002620C9 File Offset: 0x002602C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010554 RID: 66900 RVA: 0x002620D6 File Offset: 0x002602D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010555 RID: 66901 RVA: 0x002620E0 File Offset: 0x002602E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityId);
			}
			this.skillIdList_.WriteTo(ref output, PassiveSkillRemoveNotify._repeated_skillIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010556 RID: 66902 RVA: 0x00262130 File Offset: 0x00260330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			num += this.skillIdList_.CalculateSize(PassiveSkillRemoveNotify._repeated_skillIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010557 RID: 66903 RVA: 0x00262184 File Offset: 0x00260384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PassiveSkillRemoveNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this.skillIdList_.Add(other.skillIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010558 RID: 66904 RVA: 0x002621D1 File Offset: 0x002603D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010559 RID: 66905 RVA: 0x002621DC File Offset: 0x002603DC
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
				if (num != 16U)
				{
					if (num != 56U && num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.skillIdList_.AddEntriesFrom(ref input, PassiveSkillRemoveNotify._repeated_skillIdList_codec);
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04006815 RID: 26645
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006816 RID: 26646
		public const int EntityIdFieldNumber = 2;

		// Token: 0x04006817 RID: 26647
		private long entityId_;

		// Token: 0x04006818 RID: 26648
		public const int SkillIdListFieldNumber = 7;

		// Token: 0x04006819 RID: 26649
		private static readonly FieldCodec<long> _repeated_skillIdList_codec = FieldCodec.ForInt64(58U);

		// Token: 0x0400681A RID: 26650
		private readonly RepeatedField<long> skillIdList_ = new RepeatedField<long>();
	}
}
