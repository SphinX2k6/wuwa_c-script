using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008D3 RID: 2259
	[NetMessage(EMessageId.LanguageSettingUpdateRequest)]
	public sealed class LanguageSettingUpdateRequest : IMessage<LanguageSettingUpdateRequest>, IMessage, IEquatable<LanguageSettingUpdateRequest>, IDeepCloneable<LanguageSettingUpdateRequest>, IBufferMessage
	{
		// Token: 0x0600C84A RID: 51274 RVA: 0x001D9EB5 File Offset: 0x001D80B5
		[NullableContext(1)]
		public static LanguageSettingUpdateRequest Create()
		{
			return new LanguageSettingUpdateRequest();
		}

		// Token: 0x17002870 RID: 10352
		// (get) Token: 0x0600C84B RID: 51275 RVA: 0x001D9EBC File Offset: 0x001D80BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002871 RID: 10353
		// (get) Token: 0x0600C84C RID: 51276 RVA: 0x001D9EBF File Offset: 0x001D80BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LanguageSettingUpdateRequest.Descriptor;
			}
		}

		// Token: 0x0600C84D RID: 51277 RVA: 0x001D9EC6 File Offset: 0x001D80C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LanguageSettingUpdateRequest()
		{
		}

		// Token: 0x0600C84E RID: 51278 RVA: 0x001D9ECE File Offset: 0x001D80CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LanguageSettingUpdateRequest(LanguageSettingUpdateRequest other) : this()
		{
			this.language_ = other.language_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C84F RID: 51279 RVA: 0x001D9EF3 File Offset: 0x001D80F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LanguageSettingUpdateRequest Clone()
		{
			return new LanguageSettingUpdateRequest(this);
		}

		// Token: 0x17002872 RID: 10354
		// (get) Token: 0x0600C850 RID: 51280 RVA: 0x001D9EFB File Offset: 0x001D80FB
		// (set) Token: 0x0600C851 RID: 51281 RVA: 0x001D9F03 File Offset: 0x001D8103
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

		// Token: 0x0600C852 RID: 51282 RVA: 0x001D9F0C File Offset: 0x001D810C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LanguageSettingUpdateRequest);
		}

		// Token: 0x0600C853 RID: 51283 RVA: 0x001D9F1A File Offset: 0x001D811A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LanguageSettingUpdateRequest other)
		{
			return other != null && (other == this || (this.Language == other.Language && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C854 RID: 51284 RVA: 0x001D9F48 File Offset: 0x001D8148
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

		// Token: 0x0600C855 RID: 51285 RVA: 0x001D9F87 File Offset: 0x001D8187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C856 RID: 51286 RVA: 0x001D9F94 File Offset: 0x001D8194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C857 RID: 51287 RVA: 0x001D9F9D File Offset: 0x001D819D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Language != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Language);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C858 RID: 51288 RVA: 0x001D9FD0 File Offset: 0x001D81D0
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

		// Token: 0x0600C859 RID: 51289 RVA: 0x001DA00E File Offset: 0x001D820E
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

		// Token: 0x0600C85A RID: 51290 RVA: 0x001DA03F File Offset: 0x001D823F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C85B RID: 51291 RVA: 0x001DA048 File Offset: 0x001D8248
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Language = input.ReadInt32();
				}
			}
		}

		// Token: 0x040055F5 RID: 22005
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055F6 RID: 22006
		public const int LanguageFieldNumber = 15;

		// Token: 0x040055F7 RID: 22007
		private int language_;
	}
}
