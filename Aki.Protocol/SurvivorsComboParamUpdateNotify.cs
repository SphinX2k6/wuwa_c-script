using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012C3 RID: 4803
	[NetMessage(EMessageId.SurvivorsComboParamUpdateNotify)]
	public sealed class SurvivorsComboParamUpdateNotify : IMessage<SurvivorsComboParamUpdateNotify>, IMessage, IEquatable<SurvivorsComboParamUpdateNotify>, IDeepCloneable<SurvivorsComboParamUpdateNotify>, IBufferMessage
	{
		// Token: 0x060198E7 RID: 104679 RVA: 0x003B6EB8 File Offset: 0x003B50B8
		[NullableContext(1)]
		public static SurvivorsComboParamUpdateNotify Create()
		{
			return new SurvivorsComboParamUpdateNotify();
		}

		// Token: 0x17005633 RID: 22067
		// (get) Token: 0x060198E8 RID: 104680 RVA: 0x003B6EBF File Offset: 0x003B50BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005634 RID: 22068
		// (get) Token: 0x060198E9 RID: 104681 RVA: 0x003B6EC2 File Offset: 0x003B50C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsComboParamUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060198EA RID: 104682 RVA: 0x003B6EC9 File Offset: 0x003B50C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsComboParamUpdateNotify()
		{
		}

		// Token: 0x060198EB RID: 104683 RVA: 0x003B6EDC File Offset: 0x003B50DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsComboParamUpdateNotify(SurvivorsComboParamUpdateNotify other) : this()
		{
			this.comboParamInfos_ = other.comboParamInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060198EC RID: 104684 RVA: 0x003B6F06 File Offset: 0x003B5106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsComboParamUpdateNotify Clone()
		{
			return new SurvivorsComboParamUpdateNotify(this);
		}

		// Token: 0x17005635 RID: 22069
		// (get) Token: 0x060198ED RID: 104685 RVA: 0x003B6F0E File Offset: 0x003B510E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ComboParamInfo> ComboParamInfos
		{
			get
			{
				return this.comboParamInfos_;
			}
		}

		// Token: 0x060198EE RID: 104686 RVA: 0x003B6F16 File Offset: 0x003B5116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsComboParamUpdateNotify);
		}

		// Token: 0x060198EF RID: 104687 RVA: 0x003B6F24 File Offset: 0x003B5124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsComboParamUpdateNotify other)
		{
			return other != null && (other == this || (this.comboParamInfos_.Equals(other.comboParamInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060198F0 RID: 104688 RVA: 0x003B6F58 File Offset: 0x003B5158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.comboParamInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060198F1 RID: 104689 RVA: 0x003B6F8C File Offset: 0x003B518C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060198F2 RID: 104690 RVA: 0x003B6F99 File Offset: 0x003B5199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060198F3 RID: 104691 RVA: 0x003B6FA2 File Offset: 0x003B51A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.comboParamInfos_.WriteTo(ref output, SurvivorsComboParamUpdateNotify._repeated_comboParamInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060198F4 RID: 104692 RVA: 0x003B6FCC File Offset: 0x003B51CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.comboParamInfos_.CalculateSize(SurvivorsComboParamUpdateNotify._repeated_comboParamInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060198F5 RID: 104693 RVA: 0x003B7005 File Offset: 0x003B5205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsComboParamUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.comboParamInfos_.Add(other.comboParamInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060198F6 RID: 104694 RVA: 0x003B7033 File Offset: 0x003B5233
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060198F7 RID: 104695 RVA: 0x003B703C File Offset: 0x003B523C
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.comboParamInfos_.AddEntriesFrom(ref input, SurvivorsComboParamUpdateNotify._repeated_comboParamInfos_codec);
				}
			}
		}

		// Token: 0x040095ED RID: 38381
		private UnknownFieldSet _unknownFields;

		// Token: 0x040095EE RID: 38382
		public const int ComboParamInfosFieldNumber = 6;

		// Token: 0x040095EF RID: 38383
		private static readonly FieldCodec<ComboParamInfo> _repeated_comboParamInfos_codec = FieldCodec.ForMessage<ComboParamInfo>(50U, ComboParamInfo.Parser);

		// Token: 0x040095F0 RID: 38384
		private readonly RepeatedField<ComboParamInfo> comboParamInfos_ = new RepeatedField<ComboParamInfo>();
	}
}
