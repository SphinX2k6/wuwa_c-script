using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006FF RID: 1791
	public sealed class GmLevelActionCtxPb : IMessage<GmLevelActionCtxPb>, IMessage, IEquatable<GmLevelActionCtxPb>, IDeepCloneable<GmLevelActionCtxPb>, IBufferMessage
	{
		// Token: 0x0600A314 RID: 41748 RVA: 0x0018A1FD File Offset: 0x001883FD
		[NullableContext(1)]
		public static GmLevelActionCtxPb Create()
		{
			return new GmLevelActionCtxPb();
		}

		// Token: 0x170020C8 RID: 8392
		// (get) Token: 0x0600A315 RID: 41749 RVA: 0x0018A204 File Offset: 0x00188404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020C9 RID: 8393
		// (get) Token: 0x0600A316 RID: 41750 RVA: 0x0018A207 File Offset: 0x00188407
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GmLevelActionCtxPb.Descriptor;
			}
		}

		// Token: 0x0600A317 RID: 41751 RVA: 0x0018A20E File Offset: 0x0018840E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmLevelActionCtxPb()
		{
		}

		// Token: 0x0600A318 RID: 41752 RVA: 0x0018A221 File Offset: 0x00188421
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmLevelActionCtxPb(GmLevelActionCtxPb other) : this()
		{
			this.jsonStr_ = other.jsonStr_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A319 RID: 41753 RVA: 0x0018A246 File Offset: 0x00188446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmLevelActionCtxPb Clone()
		{
			return new GmLevelActionCtxPb(this);
		}

		// Token: 0x170020CA RID: 8394
		// (get) Token: 0x0600A31A RID: 41754 RVA: 0x0018A24E File Offset: 0x0018844E
		// (set) Token: 0x0600A31B RID: 41755 RVA: 0x0018A256 File Offset: 0x00188456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string JsonStr
		{
			get
			{
				return this.jsonStr_;
			}
			set
			{
				this.jsonStr_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0600A31C RID: 41756 RVA: 0x0018A269 File Offset: 0x00188469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GmLevelActionCtxPb);
		}

		// Token: 0x0600A31D RID: 41757 RVA: 0x0018A277 File Offset: 0x00188477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GmLevelActionCtxPb other)
		{
			return other != null && (other == this || (!(this.JsonStr != other.JsonStr) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A31E RID: 41758 RVA: 0x0018A2AC File Offset: 0x001884AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.JsonStr.Length != 0)
			{
				num ^= this.JsonStr.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A31F RID: 41759 RVA: 0x0018A2ED File Offset: 0x001884ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A320 RID: 41760 RVA: 0x0018A2FA File Offset: 0x001884FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A321 RID: 41761 RVA: 0x0018A303 File Offset: 0x00188503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.JsonStr.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.JsonStr);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A322 RID: 41762 RVA: 0x0018A33C File Offset: 0x0018853C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.JsonStr.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.JsonStr);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A323 RID: 41763 RVA: 0x0018A37F File Offset: 0x0018857F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GmLevelActionCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.JsonStr.Length != 0)
			{
				this.JsonStr = other.JsonStr;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A324 RID: 41764 RVA: 0x0018A3B5 File Offset: 0x001885B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A325 RID: 41765 RVA: 0x0018A3C0 File Offset: 0x001885C0
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.JsonStr = input.ReadString();
				}
			}
		}

		// Token: 0x04004B73 RID: 19315
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B74 RID: 19316
		public const int JsonStrFieldNumber = 1;

		// Token: 0x04004B75 RID: 19317
		private string jsonStr_ = "";
	}
}
