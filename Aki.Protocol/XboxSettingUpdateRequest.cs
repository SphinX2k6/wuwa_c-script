using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200152E RID: 5422
	[NetMessage(EMessageId.XboxSettingUpdateRequest)]
	public sealed class XboxSettingUpdateRequest : IMessage<XboxSettingUpdateRequest>, IMessage, IEquatable<XboxSettingUpdateRequest>, IDeepCloneable<XboxSettingUpdateRequest>, IBufferMessage
	{
		// Token: 0x0601CA60 RID: 117344 RVA: 0x00422DD5 File Offset: 0x00420FD5
		[NullableContext(1)]
		public static XboxSettingUpdateRequest Create()
		{
			return new XboxSettingUpdateRequest();
		}

		// Token: 0x17006093 RID: 24723
		// (get) Token: 0x0601CA61 RID: 117345 RVA: 0x00422DDC File Offset: 0x00420FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006094 RID: 24724
		// (get) Token: 0x0601CA62 RID: 117346 RVA: 0x00422DDF File Offset: 0x00420FDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return XboxSettingUpdateRequest.Descriptor;
			}
		}

		// Token: 0x0601CA63 RID: 117347 RVA: 0x00422DE6 File Offset: 0x00420FE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public XboxSettingUpdateRequest()
		{
		}

		// Token: 0x0601CA64 RID: 117348 RVA: 0x00422DEE File Offset: 0x00420FEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public XboxSettingUpdateRequest(XboxSettingUpdateRequest other) : this()
		{
			this.matchXboxUser_ = other.matchXboxUser_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CA65 RID: 117349 RVA: 0x00422E13 File Offset: 0x00421013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public XboxSettingUpdateRequest Clone()
		{
			return new XboxSettingUpdateRequest(this);
		}

		// Token: 0x17006095 RID: 24725
		// (get) Token: 0x0601CA66 RID: 117350 RVA: 0x00422E1B File Offset: 0x0042101B
		// (set) Token: 0x0601CA67 RID: 117351 RVA: 0x00422E23 File Offset: 0x00421023
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

		// Token: 0x0601CA68 RID: 117352 RVA: 0x00422E2C File Offset: 0x0042102C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as XboxSettingUpdateRequest);
		}

		// Token: 0x0601CA69 RID: 117353 RVA: 0x00422E3A File Offset: 0x0042103A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(XboxSettingUpdateRequest other)
		{
			return other != null && (other == this || (this.MatchXboxUser == other.MatchXboxUser && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CA6A RID: 117354 RVA: 0x00422E68 File Offset: 0x00421068
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

		// Token: 0x0601CA6B RID: 117355 RVA: 0x00422EA7 File Offset: 0x004210A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CA6C RID: 117356 RVA: 0x00422EB4 File Offset: 0x004210B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CA6D RID: 117357 RVA: 0x00422EBD File Offset: 0x004210BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MatchXboxUser)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.MatchXboxUser);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CA6E RID: 117358 RVA: 0x00422EF0 File Offset: 0x004210F0
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

		// Token: 0x0601CA6F RID: 117359 RVA: 0x00422F22 File Offset: 0x00421122
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CA70 RID: 117360 RVA: 0x00422F53 File Offset: 0x00421153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CA71 RID: 117361 RVA: 0x00422F5C File Offset: 0x0042115C
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
					this.MatchXboxUser = input.ReadBool();
				}
			}
		}

		// Token: 0x0400A3C2 RID: 41922
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A3C3 RID: 41923
		public const int MatchXboxUserFieldNumber = 9;

		// Token: 0x0400A3C4 RID: 41924
		private bool matchXboxUser_;
	}
}
