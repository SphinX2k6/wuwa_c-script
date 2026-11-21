using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000613 RID: 1555
	[NetMessage(EMessageId.FormationAttrRequest)]
	public sealed class FormationAttrRequest : IMessage<FormationAttrRequest>, IMessage, IEquatable<FormationAttrRequest>, IDeepCloneable<FormationAttrRequest>, IBufferMessage
	{
		// Token: 0x06008FF8 RID: 36856 RVA: 0x0015D18C File Offset: 0x0015B38C
		[NullableContext(1)]
		public static FormationAttrRequest Create()
		{
			return new FormationAttrRequest();
		}

		// Token: 0x17001C99 RID: 7321
		// (get) Token: 0x06008FF9 RID: 36857 RVA: 0x0015D193 File Offset: 0x0015B393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C9A RID: 7322
		// (get) Token: 0x06008FFA RID: 36858 RVA: 0x0015D196 File Offset: 0x0015B396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormationAttrRequest.Descriptor;
			}
		}

		// Token: 0x06008FFB RID: 36859 RVA: 0x0015D19D File Offset: 0x0015B39D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationAttrRequest()
		{
		}

		// Token: 0x06008FFC RID: 36860 RVA: 0x0015D1B0 File Offset: 0x0015B3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationAttrRequest(FormationAttrRequest other) : this()
		{
			this.curTime_ = other.curTime_;
			this.formationAttrs_ = other.formationAttrs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008FFD RID: 36861 RVA: 0x0015D1E6 File Offset: 0x0015B3E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationAttrRequest Clone()
		{
			return new FormationAttrRequest(this);
		}

		// Token: 0x17001C9B RID: 7323
		// (get) Token: 0x06008FFE RID: 36862 RVA: 0x0015D1EE File Offset: 0x0015B3EE
		// (set) Token: 0x06008FFF RID: 36863 RVA: 0x0015D1F6 File Offset: 0x0015B3F6
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

		// Token: 0x17001C9C RID: 7324
		// (get) Token: 0x06009000 RID: 36864 RVA: 0x0015D1FF File Offset: 0x0015B3FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FormationAttr> FormationAttrs
		{
			get
			{
				return this.formationAttrs_;
			}
		}

		// Token: 0x06009001 RID: 36865 RVA: 0x0015D207 File Offset: 0x0015B407
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormationAttrRequest);
		}

		// Token: 0x06009002 RID: 36866 RVA: 0x0015D218 File Offset: 0x0015B418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormationAttrRequest other)
		{
			return other != null && (other == this || (this.CurTime == other.CurTime && this.formationAttrs_.Equals(other.formationAttrs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009003 RID: 36867 RVA: 0x0015D268 File Offset: 0x0015B468
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

		// Token: 0x06009004 RID: 36868 RVA: 0x0015D2B5 File Offset: 0x0015B4B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009005 RID: 36869 RVA: 0x0015D2C2 File Offset: 0x0015B4C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009006 RID: 36870 RVA: 0x0015D2CC File Offset: 0x0015B4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.formationAttrs_.WriteTo(ref output, FormationAttrRequest._repeated_formationAttrs_codec);
			if (this.CurTime != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.CurTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009007 RID: 36871 RVA: 0x0015D31C File Offset: 0x0015B51C
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

		// Token: 0x06009008 RID: 36872 RVA: 0x0015D370 File Offset: 0x0015B570
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

		// Token: 0x06009009 RID: 36873 RVA: 0x0015D3BD File Offset: 0x0015B5BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600900A RID: 36874 RVA: 0x0015D3C8 File Offset: 0x0015B5C8
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
				if (num != 26U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CurTime = input.ReadInt64();
					}
				}
				else
				{
					this.formationAttrs_.AddEntriesFrom(ref input, FormationAttrRequest._repeated_formationAttrs_codec);
				}
			}
		}

		// Token: 0x04004636 RID: 17974
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004637 RID: 17975
		public const int CurTimeFieldNumber = 11;

		// Token: 0x04004638 RID: 17976
		private long curTime_;

		// Token: 0x04004639 RID: 17977
		public const int FormationAttrsFieldNumber = 3;

		// Token: 0x0400463A RID: 17978
		private static readonly FieldCodec<FormationAttr> _repeated_formationAttrs_codec = FieldCodec.ForMessage<FormationAttr>(26U, FormationAttr.Parser);

		// Token: 0x0400463B RID: 17979
		private readonly RepeatedField<FormationAttr> formationAttrs_ = new RepeatedField<FormationAttr>();
	}
}
