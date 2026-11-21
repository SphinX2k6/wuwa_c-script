using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200112E RID: 4398
	[NetMessage(EMessageId.RoverRogueBlessGroupSelectResponse)]
	public sealed class RoverRogueBlessGroupSelectResponse : IMessage<RoverRogueBlessGroupSelectResponse>, IMessage, IEquatable<RoverRogueBlessGroupSelectResponse>, IDeepCloneable<RoverRogueBlessGroupSelectResponse>, IBufferMessage
	{
		// Token: 0x060177F0 RID: 96240 RVA: 0x0036B1B8 File Offset: 0x003693B8
		[NullableContext(1)]
		public static RoverRogueBlessGroupSelectResponse Create()
		{
			return new RoverRogueBlessGroupSelectResponse();
		}

		// Token: 0x17004EF7 RID: 20215
		// (get) Token: 0x060177F1 RID: 96241 RVA: 0x0036B1BF File Offset: 0x003693BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004EF8 RID: 20216
		// (get) Token: 0x060177F2 RID: 96242 RVA: 0x0036B1C2 File Offset: 0x003693C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueBlessGroupSelectResponse.Descriptor;
			}
		}

		// Token: 0x060177F3 RID: 96243 RVA: 0x0036B1C9 File Offset: 0x003693C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueBlessGroupSelectResponse()
		{
		}

		// Token: 0x060177F4 RID: 96244 RVA: 0x0036B1D1 File Offset: 0x003693D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueBlessGroupSelectResponse(RoverRogueBlessGroupSelectResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060177F5 RID: 96245 RVA: 0x0036B1F6 File Offset: 0x003693F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueBlessGroupSelectResponse Clone()
		{
			return new RoverRogueBlessGroupSelectResponse(this);
		}

		// Token: 0x17004EF9 RID: 20217
		// (get) Token: 0x060177F6 RID: 96246 RVA: 0x0036B1FE File Offset: 0x003693FE
		// (set) Token: 0x060177F7 RID: 96247 RVA: 0x0036B206 File Offset: 0x00369406
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

		// Token: 0x060177F8 RID: 96248 RVA: 0x0036B20F File Offset: 0x0036940F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueBlessGroupSelectResponse);
		}

		// Token: 0x060177F9 RID: 96249 RVA: 0x0036B21D File Offset: 0x0036941D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueBlessGroupSelectResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060177FA RID: 96250 RVA: 0x0036B24C File Offset: 0x0036944C
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

		// Token: 0x060177FB RID: 96251 RVA: 0x0036B291 File Offset: 0x00369491
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060177FC RID: 96252 RVA: 0x0036B29E File Offset: 0x0036949E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060177FD RID: 96253 RVA: 0x0036B2A7 File Offset: 0x003694A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060177FE RID: 96254 RVA: 0x0036B2DC File Offset: 0x003694DC
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

		// Token: 0x060177FF RID: 96255 RVA: 0x0036B31A File Offset: 0x0036951A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueBlessGroupSelectResponse other)
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

		// Token: 0x06017800 RID: 96256 RVA: 0x0036B34B File Offset: 0x0036954B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017801 RID: 96257 RVA: 0x0036B354 File Offset: 0x00369554
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008C3F RID: 35903
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008C40 RID: 35904
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04008C41 RID: 35905
		private ErrorCode errorCode_;
	}
}
