using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000612 RID: 1554
	[NetMessage(EMessageId.FormationAttrNotify)]
	public sealed class FormationAttrNotify : IMessage<FormationAttrNotify>, IMessage, IEquatable<FormationAttrNotify>, IDeepCloneable<FormationAttrNotify>, IBufferMessage
	{
		// Token: 0x06008FE4 RID: 36836 RVA: 0x0015CEE2 File Offset: 0x0015B0E2
		[NullableContext(1)]
		public static FormationAttrNotify Create()
		{
			return new FormationAttrNotify();
		}

		// Token: 0x17001C95 RID: 7317
		// (get) Token: 0x06008FE5 RID: 36837 RVA: 0x0015CEE9 File Offset: 0x0015B0E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C96 RID: 7318
		// (get) Token: 0x06008FE6 RID: 36838 RVA: 0x0015CEEC File Offset: 0x0015B0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormationAttrNotify.Descriptor;
			}
		}

		// Token: 0x06008FE7 RID: 36839 RVA: 0x0015CEF3 File Offset: 0x0015B0F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationAttrNotify()
		{
		}

		// Token: 0x06008FE8 RID: 36840 RVA: 0x0015CF06 File Offset: 0x0015B106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationAttrNotify(FormationAttrNotify other) : this()
		{
			this.curTime_ = other.curTime_;
			this.formationAttrs_ = other.formationAttrs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008FE9 RID: 36841 RVA: 0x0015CF3C File Offset: 0x0015B13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationAttrNotify Clone()
		{
			return new FormationAttrNotify(this);
		}

		// Token: 0x17001C97 RID: 7319
		// (get) Token: 0x06008FEA RID: 36842 RVA: 0x0015CF44 File Offset: 0x0015B144
		// (set) Token: 0x06008FEB RID: 36843 RVA: 0x0015CF4C File Offset: 0x0015B14C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CurTime
		{
			get
			{
				return this.curTime_;
			}
			set
			{
				this.curTime_ = value;
			}
		}

		// Token: 0x17001C98 RID: 7320
		// (get) Token: 0x06008FEC RID: 36844 RVA: 0x0015CF55 File Offset: 0x0015B155
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FormationAttr> FormationAttrs
		{
			get
			{
				return this.formationAttrs_;
			}
		}

		// Token: 0x06008FED RID: 36845 RVA: 0x0015CF5D File Offset: 0x0015B15D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormationAttrNotify);
		}

		// Token: 0x06008FEE RID: 36846 RVA: 0x0015CF6C File Offset: 0x0015B16C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormationAttrNotify other)
		{
			return other != null && (other == this || (this.CurTime == other.CurTime && this.formationAttrs_.Equals(other.formationAttrs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008FEF RID: 36847 RVA: 0x0015CFBC File Offset: 0x0015B1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurTime != 0L)
			{
				num ^= this.CurTime.GetHashCode();
			}
			num ^= this.formationAttrs_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008FF0 RID: 36848 RVA: 0x0015D009 File Offset: 0x0015B209
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008FF1 RID: 36849 RVA: 0x0015D016 File Offset: 0x0015B216
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008FF2 RID: 36850 RVA: 0x0015D020 File Offset: 0x0015B220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurTime != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.CurTime);
			}
			this.formationAttrs_.WriteTo(ref output, FormationAttrNotify._repeated_formationAttrs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008FF3 RID: 36851 RVA: 0x0015D070 File Offset: 0x0015B270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CurTime);
			}
			num += this.formationAttrs_.CalculateSize(FormationAttrNotify._repeated_formationAttrs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008FF4 RID: 36852 RVA: 0x0015D0C4 File Offset: 0x0015B2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FormationAttrNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurTime != 0L)
			{
				this.CurTime = other.CurTime;
			}
			this.formationAttrs_.Add(other.formationAttrs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008FF5 RID: 36853 RVA: 0x0015D111 File Offset: 0x0015B311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008FF6 RID: 36854 RVA: 0x0015D11C File Offset: 0x0015B31C
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
				if (num != 40U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.formationAttrs_.AddEntriesFrom(ref input, FormationAttrNotify._repeated_formationAttrs_codec);
					}
				}
				else
				{
					this.CurTime = input.ReadInt64();
				}
			}
		}

		// Token: 0x04004630 RID: 17968
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004631 RID: 17969
		public const int CurTimeFieldNumber = 5;

		// Token: 0x04004632 RID: 17970
		private long curTime_;

		// Token: 0x04004633 RID: 17971
		public const int FormationAttrsFieldNumber = 11;

		// Token: 0x04004634 RID: 17972
		private static readonly FieldCodec<FormationAttr> _repeated_formationAttrs_codec = FieldCodec.ForMessage<FormationAttr>(90U, FormationAttr.Parser);

		// Token: 0x04004635 RID: 17973
		private readonly RepeatedField<FormationAttr> formationAttrs_ = new RepeatedField<FormationAttr>();
	}
}
