using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015A3 RID: 5539
	[NetMessage(EMessageId.XboxSettingResponse)]
	public sealed class XboxSettingResponse : IMessage<XboxSettingResponse>, IMessage, IEquatable<XboxSettingResponse>, IDeepCloneable<XboxSettingResponse>, IBufferMessage
	{
		// Token: 0x0601D515 RID: 120085 RVA: 0x0043E6C2 File Offset: 0x0043C8C2
		[NullableContext(1)]
		public static XboxSettingResponse Create()
		{
			return new XboxSettingResponse();
		}

		// Token: 0x17006331 RID: 25393
		// (get) Token: 0x0601D516 RID: 120086 RVA: 0x0043E6C9 File Offset: 0x0043C8C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006332 RID: 25394
		// (get) Token: 0x0601D517 RID: 120087 RVA: 0x0043E6CC File Offset: 0x0043C8CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return XboxSettingResponse.Descriptor;
			}
		}

		// Token: 0x0601D518 RID: 120088 RVA: 0x0043E6D3 File Offset: 0x0043C8D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public XboxSettingResponse()
		{
		}

		// Token: 0x0601D519 RID: 120089 RVA: 0x0043E6DB File Offset: 0x0043C8DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public XboxSettingResponse(XboxSettingResponse other) : this()
		{
			this.matchXboxUser_ = other.matchXboxUser_;
			this.xboxBlockUserCreatedContentViewing_ = other.xboxBlockUserCreatedContentViewing_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D51A RID: 120090 RVA: 0x0043E70C File Offset: 0x0043C90C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public XboxSettingResponse Clone()
		{
			return new XboxSettingResponse(this);
		}

		// Token: 0x17006333 RID: 25395
		// (get) Token: 0x0601D51B RID: 120091 RVA: 0x0043E714 File Offset: 0x0043C914
		// (set) Token: 0x0601D51C RID: 120092 RVA: 0x0043E71C File Offset: 0x0043C91C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool MatchXboxUser
		{
			get
			{
				return this.matchXboxUser_;
			}
			set
			{
				this.matchXboxUser_ = value;
			}
		}

		// Token: 0x17006334 RID: 25396
		// (get) Token: 0x0601D51D RID: 120093 RVA: 0x0043E725 File Offset: 0x0043C925
		// (set) Token: 0x0601D51E RID: 120094 RVA: 0x0043E72D File Offset: 0x0043C92D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool XboxBlockUserCreatedContentViewing
		{
			get
			{
				return this.xboxBlockUserCreatedContentViewing_;
			}
			set
			{
				this.xboxBlockUserCreatedContentViewing_ = value;
			}
		}

		// Token: 0x0601D51F RID: 120095 RVA: 0x0043E736 File Offset: 0x0043C936
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as XboxSettingResponse);
		}

		// Token: 0x0601D520 RID: 120096 RVA: 0x0043E744 File Offset: 0x0043C944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(XboxSettingResponse other)
		{
			return other != null && (other == this || (this.MatchXboxUser == other.MatchXboxUser && this.XboxBlockUserCreatedContentViewing == other.XboxBlockUserCreatedContentViewing && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D521 RID: 120097 RVA: 0x0043E784 File Offset: 0x0043C984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MatchXboxUser)
			{
				num ^= this.MatchXboxUser.GetHashCode();
			}
			if (this.XboxBlockUserCreatedContentViewing)
			{
				num ^= this.XboxBlockUserCreatedContentViewing.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D522 RID: 120098 RVA: 0x0043E7DC File Offset: 0x0043C9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D523 RID: 120099 RVA: 0x0043E7E9 File Offset: 0x0043C9E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D524 RID: 120100 RVA: 0x0043E7F4 File Offset: 0x0043C9F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MatchXboxUser)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.MatchXboxUser);
			}
			if (this.XboxBlockUserCreatedContentViewing)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.XboxBlockUserCreatedContentViewing);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D525 RID: 120101 RVA: 0x0043E84C File Offset: 0x0043CA4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MatchXboxUser)
			{
				num += 2;
			}
			if (this.XboxBlockUserCreatedContentViewing)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D526 RID: 120102 RVA: 0x0043E88C File Offset: 0x0043CA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(XboxSettingResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MatchXboxUser)
			{
				this.MatchXboxUser = other.MatchXboxUser;
			}
			if (other.XboxBlockUserCreatedContentViewing)
			{
				this.XboxBlockUserCreatedContentViewing = other.XboxBlockUserCreatedContentViewing;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D527 RID: 120103 RVA: 0x0043E8DC File Offset: 0x0043CADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D528 RID: 120104 RVA: 0x0043E8E8 File Offset: 0x0043CAE8
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
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.XboxBlockUserCreatedContentViewing = input.ReadBool();
					}
				}
				else
				{
					this.MatchXboxUser = input.ReadBool();
				}
			}
		}

		// Token: 0x0400A818 RID: 43032
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A819 RID: 43033
		public const int MatchXboxUserFieldNumber = 1;

		// Token: 0x0400A81A RID: 43034
		private bool matchXboxUser_;

		// Token: 0x0400A81B RID: 43035
		public const int XboxBlockUserCreatedContentViewingFieldNumber = 10;

		// Token: 0x0400A81C RID: 43036
		private bool xboxBlockUserCreatedContentViewing_;
	}
}
