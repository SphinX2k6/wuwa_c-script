using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CED RID: 3309
	[NetMessage(EMessageId.PhantomMusicSwitchResponse)]
	public sealed class PhantomMusicSwitchResponse : IMessage<PhantomMusicSwitchResponse>, IMessage, IEquatable<PhantomMusicSwitchResponse>, IDeepCloneable<PhantomMusicSwitchResponse>, IBufferMessage
	{
		// Token: 0x06011E58 RID: 73304 RVA: 0x0029E135 File Offset: 0x0029C335
		[NullableContext(1)]
		public static PhantomMusicSwitchResponse Create()
		{
			return new PhantomMusicSwitchResponse();
		}

		// Token: 0x17003B4D RID: 15181
		// (get) Token: 0x06011E59 RID: 73305 RVA: 0x0029E13C File Offset: 0x0029C33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B4E RID: 15182
		// (get) Token: 0x06011E5A RID: 73306 RVA: 0x0029E13F File Offset: 0x0029C33F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomMusicSwitchResponse.Descriptor;
			}
		}

		// Token: 0x06011E5B RID: 73307 RVA: 0x0029E146 File Offset: 0x0029C346
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicSwitchResponse()
		{
		}

		// Token: 0x06011E5C RID: 73308 RVA: 0x0029E14E File Offset: 0x0029C34E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicSwitchResponse(PhantomMusicSwitchResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011E5D RID: 73309 RVA: 0x0029E173 File Offset: 0x0029C373
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicSwitchResponse Clone()
		{
			return new PhantomMusicSwitchResponse(this);
		}

		// Token: 0x17003B4F RID: 15183
		// (get) Token: 0x06011E5E RID: 73310 RVA: 0x0029E17B File Offset: 0x0029C37B
		// (set) Token: 0x06011E5F RID: 73311 RVA: 0x0029E183 File Offset: 0x0029C383
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

		// Token: 0x06011E60 RID: 73312 RVA: 0x0029E18C File Offset: 0x0029C38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomMusicSwitchResponse);
		}

		// Token: 0x06011E61 RID: 73313 RVA: 0x0029E19A File Offset: 0x0029C39A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomMusicSwitchResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011E62 RID: 73314 RVA: 0x0029E1C8 File Offset: 0x0029C3C8
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

		// Token: 0x06011E63 RID: 73315 RVA: 0x0029E20D File Offset: 0x0029C40D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011E64 RID: 73316 RVA: 0x0029E21A File Offset: 0x0029C41A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011E65 RID: 73317 RVA: 0x0029E223 File Offset: 0x0029C423
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011E66 RID: 73318 RVA: 0x0029E254 File Offset: 0x0029C454
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

		// Token: 0x06011E67 RID: 73319 RVA: 0x0029E292 File Offset: 0x0029C492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomMusicSwitchResponse other)
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

		// Token: 0x06011E68 RID: 73320 RVA: 0x0029E2C3 File Offset: 0x0029C4C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011E69 RID: 73321 RVA: 0x0029E2CC File Offset: 0x0029C4CC
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007045 RID: 28741
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007046 RID: 28742
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04007047 RID: 28743
		private ErrorCode errorCode_;
	}
}
