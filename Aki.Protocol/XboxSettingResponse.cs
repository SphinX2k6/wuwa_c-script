using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200152D RID: 5421
	[NetMessage(EMessageId.XboxSettingResponse)]
	public sealed class XboxSettingResponse : IMessage<XboxSettingResponse>, IMessage, IEquatable<XboxSettingResponse>, IDeepCloneable<XboxSettingResponse>, IBufferMessage
	{
		// Token: 0x0601CA4E RID: 117326 RVA: 0x00422C06 File Offset: 0x00420E06
		[NullableContext(1)]
		public static XboxSettingResponse Create()
		{
			return new XboxSettingResponse();
		}

		// Token: 0x17006090 RID: 24720
		// (get) Token: 0x0601CA4F RID: 117327 RVA: 0x00422C0D File Offset: 0x00420E0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006091 RID: 24721
		// (get) Token: 0x0601CA50 RID: 117328 RVA: 0x00422C10 File Offset: 0x00420E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return XboxSettingResponse.Descriptor;
			}
		}

		// Token: 0x0601CA51 RID: 117329 RVA: 0x00422C17 File Offset: 0x00420E17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public XboxSettingResponse()
		{
		}

		// Token: 0x0601CA52 RID: 117330 RVA: 0x00422C1F File Offset: 0x00420E1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public XboxSettingResponse(XboxSettingResponse other) : this()
		{
			this.matchXboxUser_ = other.matchXboxUser_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CA53 RID: 117331 RVA: 0x00422C44 File Offset: 0x00420E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public XboxSettingResponse Clone()
		{
			return new XboxSettingResponse(this);
		}

		// Token: 0x17006092 RID: 24722
		// (get) Token: 0x0601CA54 RID: 117332 RVA: 0x00422C4C File Offset: 0x00420E4C
		// (set) Token: 0x0601CA55 RID: 117333 RVA: 0x00422C54 File Offset: 0x00420E54
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

		// Token: 0x0601CA56 RID: 117334 RVA: 0x00422C5D File Offset: 0x00420E5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as XboxSettingResponse);
		}

		// Token: 0x0601CA57 RID: 117335 RVA: 0x00422C6B File Offset: 0x00420E6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(XboxSettingResponse other)
		{
			return other != null && (other == this || (this.MatchXboxUser == other.MatchXboxUser && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CA58 RID: 117336 RVA: 0x00422C9C File Offset: 0x00420E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MatchXboxUser)
			{
				num ^= this.MatchXboxUser.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CA59 RID: 117337 RVA: 0x00422CDB File Offset: 0x00420EDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CA5A RID: 117338 RVA: 0x00422CE8 File Offset: 0x00420EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CA5B RID: 117339 RVA: 0x00422CF1 File Offset: 0x00420EF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MatchXboxUser)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.MatchXboxUser);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CA5C RID: 117340 RVA: 0x00422D24 File Offset: 0x00420F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MatchXboxUser)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CA5D RID: 117341 RVA: 0x00422D56 File Offset: 0x00420F56
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CA5E RID: 117342 RVA: 0x00422D87 File Offset: 0x00420F87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CA5F RID: 117343 RVA: 0x00422D90 File Offset: 0x00420F90
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MatchXboxUser = input.ReadBool();
				}
			}
		}

		// Token: 0x0400A3BF RID: 41919
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A3C0 RID: 41920
		public const int MatchXboxUserFieldNumber = 2;

		// Token: 0x0400A3C1 RID: 41921
		private bool matchXboxUser_;
	}
}
