using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008D4 RID: 2260
	[NetMessage(EMessageId.LanguageSettingUpdateResponse)]
	public sealed class LanguageSettingUpdateResponse : IMessage<LanguageSettingUpdateResponse>, IMessage, IEquatable<LanguageSettingUpdateResponse>, IDeepCloneable<LanguageSettingUpdateResponse>, IBufferMessage
	{
		// Token: 0x0600C85C RID: 51292 RVA: 0x001DA08D File Offset: 0x001D828D
		[NullableContext(1)]
		public static LanguageSettingUpdateResponse Create()
		{
			return new LanguageSettingUpdateResponse();
		}

		// Token: 0x17002873 RID: 10355
		// (get) Token: 0x0600C85D RID: 51293 RVA: 0x001DA094 File Offset: 0x001D8294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002874 RID: 10356
		// (get) Token: 0x0600C85E RID: 51294 RVA: 0x001DA097 File Offset: 0x001D8297
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LanguageSettingUpdateResponse.Descriptor;
			}
		}

		// Token: 0x0600C85F RID: 51295 RVA: 0x001DA09E File Offset: 0x001D829E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LanguageSettingUpdateResponse()
		{
		}

		// Token: 0x0600C860 RID: 51296 RVA: 0x001DA0A6 File Offset: 0x001D82A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LanguageSettingUpdateResponse(LanguageSettingUpdateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C861 RID: 51297 RVA: 0x001DA0CB File Offset: 0x001D82CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LanguageSettingUpdateResponse Clone()
		{
			return new LanguageSettingUpdateResponse(this);
		}

		// Token: 0x17002875 RID: 10357
		// (get) Token: 0x0600C862 RID: 51298 RVA: 0x001DA0D3 File Offset: 0x001D82D3
		// (set) Token: 0x0600C863 RID: 51299 RVA: 0x001DA0DB File Offset: 0x001D82DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x0600C864 RID: 51300 RVA: 0x001DA0E4 File Offset: 0x001D82E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LanguageSettingUpdateResponse);
		}

		// Token: 0x0600C865 RID: 51301 RVA: 0x001DA0F2 File Offset: 0x001D82F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LanguageSettingUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C866 RID: 51302 RVA: 0x001DA120 File Offset: 0x001D8320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C867 RID: 51303 RVA: 0x001DA165 File Offset: 0x001D8365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C868 RID: 51304 RVA: 0x001DA172 File Offset: 0x001D8372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C869 RID: 51305 RVA: 0x001DA17B File Offset: 0x001D837B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C86A RID: 51306 RVA: 0x001DA1AC File Offset: 0x001D83AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C86B RID: 51307 RVA: 0x001DA1EA File Offset: 0x001D83EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LanguageSettingUpdateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C86C RID: 51308 RVA: 0x001DA21B File Offset: 0x001D841B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C86D RID: 51309 RVA: 0x001DA224 File Offset: 0x001D8424
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040055F8 RID: 22008
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055F9 RID: 22009
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040055FA RID: 22010
		private ErrorCode errorCode_;
	}
}
