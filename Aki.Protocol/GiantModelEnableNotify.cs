using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006E1 RID: 1761
	[NetMessage(EMessageId.GiantModelEnableNotify)]
	public sealed class GiantModelEnableNotify : IMessage<GiantModelEnableNotify>, IMessage, IEquatable<GiantModelEnableNotify>, IDeepCloneable<GiantModelEnableNotify>, IBufferMessage
	{
		// Token: 0x0600A0B6 RID: 41142 RVA: 0x00185227 File Offset: 0x00183427
		[NullableContext(1)]
		public static GiantModelEnableNotify Create()
		{
			return new GiantModelEnableNotify();
		}

		// Token: 0x17002049 RID: 8265
		// (get) Token: 0x0600A0B7 RID: 41143 RVA: 0x0018522E File Offset: 0x0018342E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700204A RID: 8266
		// (get) Token: 0x0600A0B8 RID: 41144 RVA: 0x00185231 File Offset: 0x00183431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantModelEnableNotify.Descriptor;
			}
		}

		// Token: 0x0600A0B9 RID: 41145 RVA: 0x00185238 File Offset: 0x00183438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantModelEnableNotify()
		{
		}

		// Token: 0x0600A0BA RID: 41146 RVA: 0x00185240 File Offset: 0x00183440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantModelEnableNotify(GiantModelEnableNotify other) : this()
		{
			this.enable_ = other.enable_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A0BB RID: 41147 RVA: 0x00185265 File Offset: 0x00183465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantModelEnableNotify Clone()
		{
			return new GiantModelEnableNotify(this);
		}

		// Token: 0x1700204B RID: 8267
		// (get) Token: 0x0600A0BC RID: 41148 RVA: 0x0018526D File Offset: 0x0018346D
		// (set) Token: 0x0600A0BD RID: 41149 RVA: 0x00185275 File Offset: 0x00183475
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Enable
		{
			get
			{
				return this.enable_;
			}
			set
			{
				this.enable_ = value;
			}
		}

		// Token: 0x0600A0BE RID: 41150 RVA: 0x0018527E File Offset: 0x0018347E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantModelEnableNotify);
		}

		// Token: 0x0600A0BF RID: 41151 RVA: 0x0018528C File Offset: 0x0018348C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantModelEnableNotify other)
		{
			return other != null && (other == this || (this.Enable == other.Enable && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A0C0 RID: 41152 RVA: 0x001852BC File Offset: 0x001834BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Enable)
			{
				num ^= this.Enable.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A0C1 RID: 41153 RVA: 0x001852FB File Offset: 0x001834FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A0C2 RID: 41154 RVA: 0x00185308 File Offset: 0x00183508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A0C3 RID: 41155 RVA: 0x00185311 File Offset: 0x00183511
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Enable)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Enable);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A0C4 RID: 41156 RVA: 0x00185344 File Offset: 0x00183544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Enable)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A0C5 RID: 41157 RVA: 0x00185376 File Offset: 0x00183576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GiantModelEnableNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Enable)
			{
				this.Enable = other.Enable;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A0C6 RID: 41158 RVA: 0x001853A7 File Offset: 0x001835A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A0C7 RID: 41159 RVA: 0x001853B0 File Offset: 0x001835B0
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
					this.Enable = input.ReadBool();
				}
			}
		}

		// Token: 0x04004AC7 RID: 19143
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AC8 RID: 19144
		public const int EnableFieldNumber = 2;

		// Token: 0x04004AC9 RID: 19145
		private bool enable_;
	}
}
