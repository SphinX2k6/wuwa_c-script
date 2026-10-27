using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011F3 RID: 4595
	[NetMessage(EMessageId.ShopInfoRequest)]
	public sealed class ShopInfoRequest : IMessage<ShopInfoRequest>, IMessage, IEquatable<ShopInfoRequest>, IDeepCloneable<ShopInfoRequest>, IBufferMessage
	{
		// Token: 0x060187ED RID: 100333 RVA: 0x0038FD14 File Offset: 0x0038DF14
		[NullableContext(1)]
		public static ShopInfoRequest Create()
		{
			return new ShopInfoRequest();
		}

		// Token: 0x1700527E RID: 21118
		// (get) Token: 0x060187EE RID: 100334 RVA: 0x0038FD1B File Offset: 0x0038DF1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700527F RID: 21119
		// (get) Token: 0x060187EF RID: 100335 RVA: 0x0038FD1E File Offset: 0x0038DF1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShopInfoRequest.Descriptor;
			}
		}

		// Token: 0x060187F0 RID: 100336 RVA: 0x0038FD25 File Offset: 0x0038DF25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopInfoRequest()
		{
		}

		// Token: 0x060187F1 RID: 100337 RVA: 0x0038FD38 File Offset: 0x0038DF38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopInfoRequest(ShopInfoRequest other) : this()
		{
			this.versionStr_ = other.versionStr_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060187F2 RID: 100338 RVA: 0x0038FD5D File Offset: 0x0038DF5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopInfoRequest Clone()
		{
			return new ShopInfoRequest(this);
		}

		// Token: 0x17005280 RID: 21120
		// (get) Token: 0x060187F3 RID: 100339 RVA: 0x0038FD65 File Offset: 0x0038DF65
		// (set) Token: 0x060187F4 RID: 100340 RVA: 0x0038FD6D File Offset: 0x0038DF6D
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

		// Token: 0x060187F5 RID: 100341 RVA: 0x0038FD80 File Offset: 0x0038DF80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShopInfoRequest);
		}

		// Token: 0x060187F6 RID: 100342 RVA: 0x0038FD8E File Offset: 0x0038DF8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShopInfoRequest other)
		{
			return other != null && (other == this || (!(this.VersionStr != other.VersionStr) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060187F7 RID: 100343 RVA: 0x0038FDC4 File Offset: 0x0038DFC4
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

		// Token: 0x060187F8 RID: 100344 RVA: 0x0038FE05 File Offset: 0x0038E005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060187F9 RID: 100345 RVA: 0x0038FE12 File Offset: 0x0038E012
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060187FA RID: 100346 RVA: 0x0038FE1B File Offset: 0x0038E01B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.VersionStr.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.VersionStr);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060187FB RID: 100347 RVA: 0x0038FE54 File Offset: 0x0038E054
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

		// Token: 0x060187FC RID: 100348 RVA: 0x0038FE97 File Offset: 0x0038E097
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

		// Token: 0x060187FD RID: 100349 RVA: 0x0038FECD File Offset: 0x0038E0CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060187FE RID: 100350 RVA: 0x0038FED8 File Offset: 0x0038E0D8
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.VersionStr = input.ReadString();
				}
			}
		}

		// Token: 0x040090CC RID: 37068
		private UnknownFieldSet _unknownFields;

		// Token: 0x040090CD RID: 37069
		public const int VersionStrFieldNumber = 4;

		// Token: 0x040090CE RID: 37070
		private string versionStr_ = "";
	}
}
