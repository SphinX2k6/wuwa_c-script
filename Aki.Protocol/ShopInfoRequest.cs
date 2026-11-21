using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200122F RID: 4655
	[NetMessage(EMessageId.ShopInfoRequest)]
	public sealed class ShopInfoRequest : IMessage<ShopInfoRequest>, IMessage, IEquatable<ShopInfoRequest>, IDeepCloneable<ShopInfoRequest>, IBufferMessage
	{
		// Token: 0x06018DC7 RID: 101831 RVA: 0x0039FBB8 File Offset: 0x0039DDB8
		[NullableContext(1)]
		public static ShopInfoRequest Create()
		{
			return new ShopInfoRequest();
		}

		// Token: 0x170053FB RID: 21499
		// (get) Token: 0x06018DC8 RID: 101832 RVA: 0x0039FBBF File Offset: 0x0039DDBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170053FC RID: 21500
		// (get) Token: 0x06018DC9 RID: 101833 RVA: 0x0039FBC2 File Offset: 0x0039DDC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShopInfoRequest.Descriptor;
			}
		}

		// Token: 0x06018DCA RID: 101834 RVA: 0x0039FBC9 File Offset: 0x0039DDC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopInfoRequest()
		{
		}

		// Token: 0x06018DCB RID: 101835 RVA: 0x0039FBDC File Offset: 0x0039DDDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopInfoRequest(ShopInfoRequest other) : this()
		{
			this.versionStr_ = other.versionStr_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018DCC RID: 101836 RVA: 0x0039FC01 File Offset: 0x0039DE01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopInfoRequest Clone()
		{
			return new ShopInfoRequest(this);
		}

		// Token: 0x170053FD RID: 21501
		// (get) Token: 0x06018DCD RID: 101837 RVA: 0x0039FC09 File Offset: 0x0039DE09
		// (set) Token: 0x06018DCE RID: 101838 RVA: 0x0039FC11 File Offset: 0x0039DE11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string VersionStr
		{
			get
			{
				return this.versionStr_;
			}
			set
			{
				this.versionStr_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06018DCF RID: 101839 RVA: 0x0039FC24 File Offset: 0x0039DE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShopInfoRequest);
		}

		// Token: 0x06018DD0 RID: 101840 RVA: 0x0039FC32 File Offset: 0x0039DE32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShopInfoRequest other)
		{
			return other != null && (other == this || (!(this.VersionStr != other.VersionStr) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018DD1 RID: 101841 RVA: 0x0039FC68 File Offset: 0x0039DE68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.VersionStr.Length != 0)
			{
				num ^= this.VersionStr.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018DD2 RID: 101842 RVA: 0x0039FCA9 File Offset: 0x0039DEA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018DD3 RID: 101843 RVA: 0x0039FCB6 File Offset: 0x0039DEB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018DD4 RID: 101844 RVA: 0x0039FCBF File Offset: 0x0039DEBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.VersionStr.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteString(this.VersionStr);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018DD5 RID: 101845 RVA: 0x0039FCF8 File Offset: 0x0039DEF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.VersionStr.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.VersionStr);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018DD6 RID: 101846 RVA: 0x0039FD3B File Offset: 0x0039DF3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShopInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.VersionStr.Length != 0)
			{
				this.VersionStr = other.VersionStr;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018DD7 RID: 101847 RVA: 0x0039FD71 File Offset: 0x0039DF71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018DD8 RID: 101848 RVA: 0x0039FD7C File Offset: 0x0039DF7C
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.VersionStr = input.ReadString();
				}
			}
		}

		// Token: 0x0400937D RID: 37757
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400937E RID: 37758
		public const int VersionStrFieldNumber = 15;

		// Token: 0x0400937F RID: 37759
		private string versionStr_ = "";
	}
}
