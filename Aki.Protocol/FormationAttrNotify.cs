using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000626 RID: 1574
	[NetMessage(EMessageId.FormationAttrNotify)]
	public sealed class FormationAttrNotify : IMessage<FormationAttrNotify>, IMessage, IEquatable<FormationAttrNotify>, IDeepCloneable<FormationAttrNotify>, IBufferMessage
	{
		// Token: 0x0600913A RID: 37178 RVA: 0x0015F912 File Offset: 0x0015DB12
		[NullableContext(1)]
		public static FormationAttrNotify Create()
		{
			return new FormationAttrNotify();
		}

		// Token: 0x17001CDF RID: 7391
		// (get) Token: 0x0600913B RID: 37179 RVA: 0x0015F919 File Offset: 0x0015DB19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CE0 RID: 7392
		// (get) Token: 0x0600913C RID: 37180 RVA: 0x0015F91C File Offset: 0x0015DB1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormationAttrNotify.Descriptor;
			}
		}

		// Token: 0x0600913D RID: 37181 RVA: 0x0015F923 File Offset: 0x0015DB23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationAttrNotify()
		{
		}

		// Token: 0x0600913E RID: 37182 RVA: 0x0015F936 File Offset: 0x0015DB36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationAttrNotify(FormationAttrNotify other) : this()
		{
			this.curTime_ = other.curTime_;
			this.formationAttrs_ = other.formationAttrs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600913F RID: 37183 RVA: 0x0015F96C File Offset: 0x0015DB6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationAttrNotify Clone()
		{
			return new FormationAttrNotify(this);
		}

		// Token: 0x17001CE1 RID: 7393
		// (get) Token: 0x06009140 RID: 37184 RVA: 0x0015F974 File Offset: 0x0015DB74
		// (set) Token: 0x06009141 RID: 37185 RVA: 0x0015F97C File Offset: 0x0015DB7C
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

		// Token: 0x17001CE2 RID: 7394
		// (get) Token: 0x06009142 RID: 37186 RVA: 0x0015F985 File Offset: 0x0015DB85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FormationAttr> FormationAttrs
		{
			get
			{
				return this.formationAttrs_;
			}
		}

		// Token: 0x06009143 RID: 37187 RVA: 0x0015F98D File Offset: 0x0015DB8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormationAttrNotify);
		}

		// Token: 0x06009144 RID: 37188 RVA: 0x0015F99C File Offset: 0x0015DB9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormationAttrNotify other)
		{
			return other != null && (other == this || (this.CurTime == other.CurTime && this.formationAttrs_.Equals(other.formationAttrs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009145 RID: 37189 RVA: 0x0015F9EC File Offset: 0x0015DBEC
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

		// Token: 0x06009146 RID: 37190 RVA: 0x0015FA39 File Offset: 0x0015DC39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009147 RID: 37191 RVA: 0x0015FA46 File Offset: 0x0015DC46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009148 RID: 37192 RVA: 0x0015FA50 File Offset: 0x0015DC50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurTime != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.CurTime);
			}
			this.formationAttrs_.WriteTo(ref output, FormationAttrNotify._repeated_formationAttrs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009149 RID: 37193 RVA: 0x0015FAA0 File Offset: 0x0015DCA0
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

		// Token: 0x0600914A RID: 37194 RVA: 0x0015FAF4 File Offset: 0x0015DCF4
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

		// Token: 0x0600914B RID: 37195 RVA: 0x0015FB41 File Offset: 0x0015DD41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600914C RID: 37196 RVA: 0x0015FB4C File Offset: 0x0015DD4C
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
				if (num != 80U)
				{
					if (num != 114U)
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

		// Token: 0x04004637 RID: 17975
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004638 RID: 17976
		public const int CurTimeFieldNumber = 10;

		// Token: 0x04004639 RID: 17977
		private long curTime_;

		// Token: 0x0400463A RID: 17978
		public const int FormationAttrsFieldNumber = 14;

		// Token: 0x0400463B RID: 17979
		private static readonly FieldCodec<FormationAttr> _repeated_formationAttrs_codec = FieldCodec.ForMessage<FormationAttr>(114U, FormationAttr.Parser);

		// Token: 0x0400463C RID: 17980
		private readonly RepeatedField<FormationAttr> formationAttrs_ = new RepeatedField<FormationAttr>();
	}
}
