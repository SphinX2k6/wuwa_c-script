using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200050E RID: 1294
	[NetMessage(EMessageId.ExploreToolAuthorizationNotify)]
	public sealed class ExploreToolAuthorizationNotify : IMessage<ExploreToolAuthorizationNotify>, IMessage, IEquatable<ExploreToolAuthorizationNotify>, IDeepCloneable<ExploreToolAuthorizationNotify>, IBufferMessage
	{
		// Token: 0x060079BF RID: 31167 RVA: 0x00127F40 File Offset: 0x00126140
		[NullableContext(1)]
		public static ExploreToolAuthorizationNotify Create()
		{
			return new ExploreToolAuthorizationNotify();
		}

		// Token: 0x17001799 RID: 6041
		// (get) Token: 0x060079C0 RID: 31168 RVA: 0x00127F47 File Offset: 0x00126147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700179A RID: 6042
		// (get) Token: 0x060079C1 RID: 31169 RVA: 0x00127F4A File Offset: 0x0012614A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreToolAuthorizationNotify.Descriptor;
			}
		}

		// Token: 0x060079C2 RID: 31170 RVA: 0x00127F51 File Offset: 0x00126151
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreToolAuthorizationNotify()
		{
		}

		// Token: 0x060079C3 RID: 31171 RVA: 0x00127F64 File Offset: 0x00126164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreToolAuthorizationNotify(ExploreToolAuthorizationNotify other) : this()
		{
			this.authorizationItems_ = other.authorizationItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060079C4 RID: 31172 RVA: 0x00127F8E File Offset: 0x0012618E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreToolAuthorizationNotify Clone()
		{
			return new ExploreToolAuthorizationNotify(this);
		}

		// Token: 0x1700179B RID: 6043
		// (get) Token: 0x060079C5 RID: 31173 RVA: 0x00127F96 File Offset: 0x00126196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> AuthorizationItems
		{
			get
			{
				return this.authorizationItems_;
			}
		}

		// Token: 0x060079C6 RID: 31174 RVA: 0x00127F9E File Offset: 0x0012619E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreToolAuthorizationNotify);
		}

		// Token: 0x060079C7 RID: 31175 RVA: 0x00127FAC File Offset: 0x001261AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreToolAuthorizationNotify other)
		{
			return other != null && (other == this || (this.authorizationItems_.Equals(other.authorizationItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060079C8 RID: 31176 RVA: 0x00127FE0 File Offset: 0x001261E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.authorizationItems_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060079C9 RID: 31177 RVA: 0x00128014 File Offset: 0x00126214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060079CA RID: 31178 RVA: 0x00128021 File Offset: 0x00126221
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060079CB RID: 31179 RVA: 0x0012802A File Offset: 0x0012622A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.authorizationItems_.WriteTo(ref output, ExploreToolAuthorizationNotify._repeated_authorizationItems_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060079CC RID: 31180 RVA: 0x00128054 File Offset: 0x00126254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.authorizationItems_.CalculateSize(ExploreToolAuthorizationNotify._repeated_authorizationItems_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060079CD RID: 31181 RVA: 0x0012808D File Offset: 0x0012628D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreToolAuthorizationNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.authorizationItems_.Add(other.authorizationItems_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060079CE RID: 31182 RVA: 0x001280BB File Offset: 0x001262BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060079CF RID: 31183 RVA: 0x001280C4 File Offset: 0x001262C4
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
				if (num != 80U && num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.authorizationItems_.AddEntriesFrom(ref input, ExploreToolAuthorizationNotify._repeated_authorizationItems_codec);
				}
			}
		}

		// Token: 0x04003EC0 RID: 16064
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EC1 RID: 16065
		public const int AuthorizationItemsFieldNumber = 10;

		// Token: 0x04003EC2 RID: 16066
		private static readonly FieldCodec<int> _repeated_authorizationItems_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04003EC3 RID: 16067
		private readonly RepeatedField<int> authorizationItems_ = new RepeatedField<int>();
	}
}
