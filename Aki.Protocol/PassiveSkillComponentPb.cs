using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BBF RID: 3007
	public sealed class PassiveSkillComponentPb : IMessage<PassiveSkillComponentPb>, IMessage, IEquatable<PassiveSkillComponentPb>, IDeepCloneable<PassiveSkillComponentPb>, IBufferMessage
	{
		// Token: 0x060104F7 RID: 66807 RVA: 0x00261619 File Offset: 0x0025F819
		[NullableContext(1)]
		public static PassiveSkillComponentPb Create()
		{
			return new PassiveSkillComponentPb();
		}

		// Token: 0x17003579 RID: 13689
		// (get) Token: 0x060104F8 RID: 66808 RVA: 0x00261620 File Offset: 0x0025F820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700357A RID: 13690
		// (get) Token: 0x060104F9 RID: 66809 RVA: 0x00261623 File Offset: 0x0025F823
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PassiveSkillComponentPb.Descriptor;
			}
		}

		// Token: 0x060104FA RID: 66810 RVA: 0x0026162A File Offset: 0x0025F82A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillComponentPb()
		{
		}

		// Token: 0x060104FB RID: 66811 RVA: 0x0026163D File Offset: 0x0025F83D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillComponentPb(PassiveSkillComponentPb other) : this()
		{
			this.passiveSkillItemPbList_ = other.passiveSkillItemPbList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060104FC RID: 66812 RVA: 0x00261667 File Offset: 0x0025F867
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillComponentPb Clone()
		{
			return new PassiveSkillComponentPb(this);
		}

		// Token: 0x1700357B RID: 13691
		// (get) Token: 0x060104FD RID: 66813 RVA: 0x0026166F File Offset: 0x0025F86F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PassiveSkillItemPb> PassiveSkillItemPbList
		{
			get
			{
				return this.passiveSkillItemPbList_;
			}
		}

		// Token: 0x060104FE RID: 66814 RVA: 0x00261677 File Offset: 0x0025F877
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PassiveSkillComponentPb);
		}

		// Token: 0x060104FF RID: 66815 RVA: 0x00261685 File Offset: 0x0025F885
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PassiveSkillComponentPb other)
		{
			return other != null && (other == this || (this.passiveSkillItemPbList_.Equals(other.passiveSkillItemPbList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010500 RID: 66816 RVA: 0x002616B8 File Offset: 0x0025F8B8
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

		// Token: 0x06010501 RID: 66817 RVA: 0x002616EC File Offset: 0x0025F8EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010502 RID: 66818 RVA: 0x002616F9 File Offset: 0x0025F8F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010503 RID: 66819 RVA: 0x00261702 File Offset: 0x0025F902
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

		// Token: 0x06010504 RID: 66820 RVA: 0x0026172C File Offset: 0x0025F92C
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

		// Token: 0x06010505 RID: 66821 RVA: 0x00261765 File Offset: 0x0025F965
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

		// Token: 0x06010506 RID: 66822 RVA: 0x00261793 File Offset: 0x0025F993
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010507 RID: 66823 RVA: 0x0026179C File Offset: 0x0025F99C
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

		// Token: 0x04006801 RID: 26625
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006802 RID: 26626
		public const int PassiveSkillItemPbListFieldNumber = 1;

		// Token: 0x04006803 RID: 26627
		private static readonly FieldCodec<PassiveSkillItemPb> _repeated_passiveSkillItemPbList_codec = FieldCodec.ForMessage<PassiveSkillItemPb>(10U, PassiveSkillItemPb.Parser);

		// Token: 0x04006804 RID: 26628
		private readonly RepeatedField<PassiveSkillItemPb> passiveSkillItemPbList_ = new RepeatedField<PassiveSkillItemPb>();
	}
}
