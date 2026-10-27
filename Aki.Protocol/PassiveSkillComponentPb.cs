using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BCF RID: 3023
	public sealed class PassiveSkillComponentPb : IMessage<PassiveSkillComponentPb>, IMessage, IEquatable<PassiveSkillComponentPb>, IDeepCloneable<PassiveSkillComponentPb>, IBufferMessage
	{
		// Token: 0x060105FB RID: 67067 RVA: 0x002634D5 File Offset: 0x002616D5
		[NullableContext(1)]
		public static PassiveSkillComponentPb Create()
		{
			return new PassiveSkillComponentPb();
		}

		// Token: 0x170035B2 RID: 13746
		// (get) Token: 0x060105FC RID: 67068 RVA: 0x002634DC File Offset: 0x002616DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170035B3 RID: 13747
		// (get) Token: 0x060105FD RID: 67069 RVA: 0x002634DF File Offset: 0x002616DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PassiveSkillComponentPb.Descriptor;
			}
		}

		// Token: 0x060105FE RID: 67070 RVA: 0x002634E6 File Offset: 0x002616E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillComponentPb()
		{
		}

		// Token: 0x060105FF RID: 67071 RVA: 0x002634F9 File Offset: 0x002616F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillComponentPb(PassiveSkillComponentPb other) : this()
		{
			this.passiveSkillItemPbList_ = other.passiveSkillItemPbList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010600 RID: 67072 RVA: 0x00263523 File Offset: 0x00261723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillComponentPb Clone()
		{
			return new PassiveSkillComponentPb(this);
		}

		// Token: 0x170035B4 RID: 13748
		// (get) Token: 0x06010601 RID: 67073 RVA: 0x0026352B File Offset: 0x0026172B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PassiveSkillItemPb> PassiveSkillItemPbList
		{
			get
			{
				return this.passiveSkillItemPbList_;
			}
		}

		// Token: 0x06010602 RID: 67074 RVA: 0x00263533 File Offset: 0x00261733
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PassiveSkillComponentPb);
		}

		// Token: 0x06010603 RID: 67075 RVA: 0x00263541 File Offset: 0x00261741
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PassiveSkillComponentPb other)
		{
			return other != null && (other == this || (this.passiveSkillItemPbList_.Equals(other.passiveSkillItemPbList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010604 RID: 67076 RVA: 0x00263574 File Offset: 0x00261774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.passiveSkillItemPbList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010605 RID: 67077 RVA: 0x002635A8 File Offset: 0x002617A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010606 RID: 67078 RVA: 0x002635B5 File Offset: 0x002617B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010607 RID: 67079 RVA: 0x002635BE File Offset: 0x002617BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.passiveSkillItemPbList_.WriteTo(ref output, PassiveSkillComponentPb._repeated_passiveSkillItemPbList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010608 RID: 67080 RVA: 0x002635E8 File Offset: 0x002617E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.passiveSkillItemPbList_.CalculateSize(PassiveSkillComponentPb._repeated_passiveSkillItemPbList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010609 RID: 67081 RVA: 0x00263621 File Offset: 0x00261821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PassiveSkillComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			this.passiveSkillItemPbList_.Add(other.passiveSkillItemPbList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601060A RID: 67082 RVA: 0x0026364F File Offset: 0x0026184F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601060B RID: 67083 RVA: 0x00263658 File Offset: 0x00261858
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.passiveSkillItemPbList_.AddEntriesFrom(ref input, PassiveSkillComponentPb._repeated_passiveSkillItemPbList_codec);
				}
			}
		}

		// Token: 0x040067F1 RID: 26609
		private UnknownFieldSet _unknownFields;

		// Token: 0x040067F2 RID: 26610
		public const int PassiveSkillItemPbListFieldNumber = 1;

		// Token: 0x040067F3 RID: 26611
		private static readonly FieldCodec<PassiveSkillItemPb> _repeated_passiveSkillItemPbList_codec = FieldCodec.ForMessage<PassiveSkillItemPb>(10U, PassiveSkillItemPb.Parser);

		// Token: 0x040067F4 RID: 26612
		private readonly RepeatedField<PassiveSkillItemPb> passiveSkillItemPbList_ = new RepeatedField<PassiveSkillItemPb>();
	}
}
