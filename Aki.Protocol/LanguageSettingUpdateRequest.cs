using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008E4 RID: 2276
	[NetMessage(EMessageId.LanguageSettingUpdateRequest)]
	public sealed class LanguageSettingUpdateRequest : IMessage<LanguageSettingUpdateRequest>, IMessage, IEquatable<LanguageSettingUpdateRequest>, IDeepCloneable<LanguageSettingUpdateRequest>, IBufferMessage
	{
		// Token: 0x0600C966 RID: 51558 RVA: 0x001DC191 File Offset: 0x001DA391
		[NullableContext(1)]
		public static LanguageSettingUpdateRequest Create()
		{
			return new LanguageSettingUpdateRequest();
		}

		// Token: 0x170028AF RID: 10415
		// (get) Token: 0x0600C967 RID: 51559 RVA: 0x001DC198 File Offset: 0x001DA398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028B0 RID: 10416
		// (get) Token: 0x0600C968 RID: 51560 RVA: 0x001DC19B File Offset: 0x001DA39B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LanguageSettingUpdateRequest.Descriptor;
			}
		}

		// Token: 0x0600C969 RID: 51561 RVA: 0x001DC1A2 File Offset: 0x001DA3A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LanguageSettingUpdateRequest()
		{
		}

		// Token: 0x0600C96A RID: 51562 RVA: 0x001DC1AA File Offset: 0x001DA3AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LanguageSettingUpdateRequest(LanguageSettingUpdateRequest other) : this()
		{
			this.language_ = other.language_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C96B RID: 51563 RVA: 0x001DC1CF File Offset: 0x001DA3CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LanguageSettingUpdateRequest Clone()
		{
			return new LanguageSettingUpdateRequest(this);
		}

		// Token: 0x170028B1 RID: 10417
		// (get) Token: 0x0600C96C RID: 51564 RVA: 0x001DC1D7 File Offset: 0x001DA3D7
		// (set) Token: 0x0600C96D RID: 51565 RVA: 0x001DC1DF File Offset: 0x001DA3DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Language
		{
			get
			{
				return this.language_;
			}
			set
			{
				this.language_ = value;
			}
		}

		// Token: 0x0600C96E RID: 51566 RVA: 0x001DC1E8 File Offset: 0x001DA3E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LanguageSettingUpdateRequest);
		}

		// Token: 0x0600C96F RID: 51567 RVA: 0x001DC1F6 File Offset: 0x001DA3F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LanguageSettingUpdateRequest other)
		{
			return other != null && (other == this || (this.Language == other.Language && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C970 RID: 51568 RVA: 0x001DC224 File Offset: 0x001DA424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Language != 0)
			{
				num ^= this.Language.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C971 RID: 51569 RVA: 0x001DC263 File Offset: 0x001DA463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C972 RID: 51570 RVA: 0x001DC270 File Offset: 0x001DA470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C973 RID: 51571 RVA: 0x001DC279 File Offset: 0x001DA479
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Language != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Language);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C974 RID: 51572 RVA: 0x001DC2AC File Offset: 0x001DA4AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Language != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Language);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C975 RID: 51573 RVA: 0x001DC2EA File Offset: 0x001DA4EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LanguageSettingUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Language != 0)
			{
				this.Language = other.Language;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C976 RID: 51574 RVA: 0x001DC31B File Offset: 0x001DA51B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C977 RID: 51575 RVA: 0x001DC324 File Offset: 0x001DA524
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Language = input.ReadInt32();
				}
			}
		}

		// Token: 0x040055EE RID: 21998
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055EF RID: 21999
		public const int LanguageFieldNumber = 9;

		// Token: 0x040055F0 RID: 22000
		private int language_;
	}
}
