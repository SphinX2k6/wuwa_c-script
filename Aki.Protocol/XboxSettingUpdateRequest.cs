using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015A4 RID: 5540
	[NetMessage(EMessageId.XboxSettingUpdateRequest)]
	public sealed class XboxSettingUpdateRequest : IMessage<XboxSettingUpdateRequest>, IMessage, IEquatable<XboxSettingUpdateRequest>, IDeepCloneable<XboxSettingUpdateRequest>, IBufferMessage
	{
		// Token: 0x0601D529 RID: 120105 RVA: 0x0043E93F File Offset: 0x0043CB3F
		[NullableContext(1)]
		public static XboxSettingUpdateRequest Create()
		{
			return new XboxSettingUpdateRequest();
		}

		// Token: 0x17006335 RID: 25397
		// (get) Token: 0x0601D52A RID: 120106 RVA: 0x0043E946 File Offset: 0x0043CB46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006336 RID: 25398
		// (get) Token: 0x0601D52B RID: 120107 RVA: 0x0043E949 File Offset: 0x0043CB49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return XboxSettingUpdateRequest.Descriptor;
			}
		}

		// Token: 0x0601D52C RID: 120108 RVA: 0x0043E950 File Offset: 0x0043CB50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public XboxSettingUpdateRequest()
		{
		}

		// Token: 0x0601D52D RID: 120109 RVA: 0x0043E958 File Offset: 0x0043CB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public XboxSettingUpdateRequest(XboxSettingUpdateRequest other) : this()
		{
			this.matchXboxUser_ = other.matchXboxUser_;
			this.xboxBlockUserCreatedContentViewing_ = other.xboxBlockUserCreatedContentViewing_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D52E RID: 120110 RVA: 0x0043E989 File Offset: 0x0043CB89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public XboxSettingUpdateRequest Clone()
		{
			return new XboxSettingUpdateRequest(this);
		}

		// Token: 0x17006337 RID: 25399
		// (get) Token: 0x0601D52F RID: 120111 RVA: 0x0043E991 File Offset: 0x0043CB91
		// (set) Token: 0x0601D530 RID: 120112 RVA: 0x0043E999 File Offset: 0x0043CB99
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

		// Token: 0x17006338 RID: 25400
		// (get) Token: 0x0601D531 RID: 120113 RVA: 0x0043E9A2 File Offset: 0x0043CBA2
		// (set) Token: 0x0601D532 RID: 120114 RVA: 0x0043E9AA File Offset: 0x0043CBAA
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

		// Token: 0x0601D533 RID: 120115 RVA: 0x0043E9B3 File Offset: 0x0043CBB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as XboxSettingUpdateRequest);
		}

		// Token: 0x0601D534 RID: 120116 RVA: 0x0043E9C1 File Offset: 0x0043CBC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(XboxSettingUpdateRequest other)
		{
			return other != null && (other == this || (this.MatchXboxUser == other.MatchXboxUser && this.XboxBlockUserCreatedContentViewing == other.XboxBlockUserCreatedContentViewing && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D535 RID: 120117 RVA: 0x0043EA00 File Offset: 0x0043CC00
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

		// Token: 0x0601D536 RID: 120118 RVA: 0x0043EA58 File Offset: 0x0043CC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D537 RID: 120119 RVA: 0x0043EA65 File Offset: 0x0043CC65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D538 RID: 120120 RVA: 0x0043EA70 File Offset: 0x0043CC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.XboxBlockUserCreatedContentViewing)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.XboxBlockUserCreatedContentViewing);
			}
			if (this.MatchXboxUser)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.MatchXboxUser);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D539 RID: 120121 RVA: 0x0043EACC File Offset: 0x0043CCCC
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

		// Token: 0x0601D53A RID: 120122 RVA: 0x0043EB0C File Offset: 0x0043CD0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(XboxSettingUpdateRequest other)
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

		// Token: 0x0601D53B RID: 120123 RVA: 0x0043EB5C File Offset: 0x0043CD5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D53C RID: 120124 RVA: 0x0043EB68 File Offset: 0x0043CD68
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
				if (num != 56U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MatchXboxUser = input.ReadBool();
					}
				}
				else
				{
					this.XboxBlockUserCreatedContentViewing = input.ReadBool();
				}
			}
		}

		// Token: 0x0400A81D RID: 43037
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A81E RID: 43038
		public const int MatchXboxUserFieldNumber = 13;

		// Token: 0x0400A81F RID: 43039
		private bool matchXboxUser_;

		// Token: 0x0400A820 RID: 43040
		public const int XboxBlockUserCreatedContentViewingFieldNumber = 7;

		// Token: 0x0400A821 RID: 43041
		private bool xboxBlockUserCreatedContentViewing_;
	}
}
