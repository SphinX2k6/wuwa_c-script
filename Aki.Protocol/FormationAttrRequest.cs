using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000627 RID: 1575
	[NetMessage(EMessageId.FormationAttrRequest)]
	public sealed class FormationAttrRequest : IMessage<FormationAttrRequest>, IMessage, IEquatable<FormationAttrRequest>, IDeepCloneable<FormationAttrRequest>, IBufferMessage
	{
		// Token: 0x0600914E RID: 37198 RVA: 0x0015FBBC File Offset: 0x0015DDBC
		[NullableContext(1)]
		public static FormationAttrRequest Create()
		{
			return new FormationAttrRequest();
		}

		// Token: 0x17001CE3 RID: 7395
		// (get) Token: 0x0600914F RID: 37199 RVA: 0x0015FBC3 File Offset: 0x0015DDC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CE4 RID: 7396
		// (get) Token: 0x06009150 RID: 37200 RVA: 0x0015FBC6 File Offset: 0x0015DDC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormationAttrRequest.Descriptor;
			}
		}

		// Token: 0x06009151 RID: 37201 RVA: 0x0015FBCD File Offset: 0x0015DDCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationAttrRequest()
		{
		}

		// Token: 0x06009152 RID: 37202 RVA: 0x0015FBE0 File Offset: 0x0015DDE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationAttrRequest(FormationAttrRequest other) : this()
		{
			this.curTime_ = other.curTime_;
			this.formationAttrs_ = other.formationAttrs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009153 RID: 37203 RVA: 0x0015FC16 File Offset: 0x0015DE16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationAttrRequest Clone()
		{
			return new FormationAttrRequest(this);
		}

		// Token: 0x17001CE5 RID: 7397
		// (get) Token: 0x06009154 RID: 37204 RVA: 0x0015FC1E File Offset: 0x0015DE1E
		// (set) Token: 0x06009155 RID: 37205 RVA: 0x0015FC26 File Offset: 0x0015DE26
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

		// Token: 0x17001CE6 RID: 7398
		// (get) Token: 0x06009156 RID: 37206 RVA: 0x0015FC2F File Offset: 0x0015DE2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FormationAttr> FormationAttrs
		{
			get
			{
				return this.formationAttrs_;
			}
		}

		// Token: 0x06009157 RID: 37207 RVA: 0x0015FC37 File Offset: 0x0015DE37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormationAttrRequest);
		}

		// Token: 0x06009158 RID: 37208 RVA: 0x0015FC48 File Offset: 0x0015DE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormationAttrRequest other)
		{
			return other != null && (other == this || (this.CurTime == other.CurTime && this.formationAttrs_.Equals(other.formationAttrs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009159 RID: 37209 RVA: 0x0015FC98 File Offset: 0x0015DE98
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

		// Token: 0x0600915A RID: 37210 RVA: 0x0015FCE5 File Offset: 0x0015DEE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600915B RID: 37211 RVA: 0x0015FCF2 File Offset: 0x0015DEF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600915C RID: 37212 RVA: 0x0015FCFC File Offset: 0x0015DEFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurTime != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.CurTime);
			}
			this.formationAttrs_.WriteTo(ref output, FormationAttrRequest._repeated_formationAttrs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600915D RID: 37213 RVA: 0x0015FD4C File Offset: 0x0015DF4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CurTime);
			}
			num += this.formationAttrs_.CalculateSize(FormationAttrRequest._repeated_formationAttrs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600915E RID: 37214 RVA: 0x0015FDA0 File Offset: 0x0015DFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FormationAttrRequest other)
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

		// Token: 0x0600915F RID: 37215 RVA: 0x0015FDED File Offset: 0x0015DFED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009160 RID: 37216 RVA: 0x0015FDF8 File Offset: 0x0015DFF8
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
				if (num != 32U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.formationAttrs_.AddEntriesFrom(ref input, FormationAttrRequest._repeated_formationAttrs_codec);
					}
				}
				else
				{
					this.CurTime = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400463D RID: 17981
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400463E RID: 17982
		public const int CurTimeFieldNumber = 4;

		// Token: 0x0400463F RID: 17983
		private long curTime_;

		// Token: 0x04004640 RID: 17984
		public const int FormationAttrsFieldNumber = 15;

		// Token: 0x04004641 RID: 17985
		private static readonly FieldCodec<FormationAttr> _repeated_formationAttrs_codec = FieldCodec.ForMessage<FormationAttr>(122U, FormationAttr.Parser);

		// Token: 0x04004642 RID: 17986
		private readonly RepeatedField<FormationAttr> formationAttrs_ = new RepeatedField<FormationAttr>();
	}
}
