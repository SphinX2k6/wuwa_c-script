using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006E1 RID: 1761
	[NetMessage(EMessageId.GivebackRewardResponse)]
	public sealed class GivebackRewardResponse : IMessage<GivebackRewardResponse>, IMessage, IEquatable<GivebackRewardResponse>, IDeepCloneable<GivebackRewardResponse>, IBufferMessage
	{
		// Token: 0x0600A0FB RID: 41211 RVA: 0x00186048 File Offset: 0x00184248
		[NullableContext(1)]
		public static GivebackRewardResponse Create()
		{
			return new GivebackRewardResponse();
		}

		// Token: 0x17002057 RID: 8279
		// (get) Token: 0x0600A0FC RID: 41212 RVA: 0x0018604F File Offset: 0x0018424F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002058 RID: 8280
		// (get) Token: 0x0600A0FD RID: 41213 RVA: 0x00186052 File Offset: 0x00184252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GivebackRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600A0FE RID: 41214 RVA: 0x00186059 File Offset: 0x00184259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackRewardResponse()
		{
		}

		// Token: 0x0600A0FF RID: 41215 RVA: 0x00186061 File Offset: 0x00184261
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackRewardResponse(GivebackRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A100 RID: 41216 RVA: 0x00186086 File Offset: 0x00184286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackRewardResponse Clone()
		{
			return new GivebackRewardResponse(this);
		}

		// Token: 0x17002059 RID: 8281
		// (get) Token: 0x0600A101 RID: 41217 RVA: 0x0018608E File Offset: 0x0018428E
		// (set) Token: 0x0600A102 RID: 41218 RVA: 0x00186096 File Offset: 0x00184296
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

		// Token: 0x0600A103 RID: 41219 RVA: 0x0018609F File Offset: 0x0018429F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GivebackRewardResponse);
		}

		// Token: 0x0600A104 RID: 41220 RVA: 0x001860AD File Offset: 0x001842AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GivebackRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A105 RID: 41221 RVA: 0x001860DC File Offset: 0x001842DC
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

		// Token: 0x0600A106 RID: 41222 RVA: 0x00186121 File Offset: 0x00184321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A107 RID: 41223 RVA: 0x0018612E File Offset: 0x0018432E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A108 RID: 41224 RVA: 0x00186137 File Offset: 0x00184337
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A109 RID: 41225 RVA: 0x0018616C File Offset: 0x0018436C
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

		// Token: 0x0600A10A RID: 41226 RVA: 0x001861AA File Offset: 0x001843AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GivebackRewardResponse other)
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

		// Token: 0x0600A10B RID: 41227 RVA: 0x001861DB File Offset: 0x001843DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A10C RID: 41228 RVA: 0x001861E4 File Offset: 0x001843E4
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004B3C RID: 19260
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B3D RID: 19261
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04004B3E RID: 19262
		private ErrorCode errorCode_;
	}
}
