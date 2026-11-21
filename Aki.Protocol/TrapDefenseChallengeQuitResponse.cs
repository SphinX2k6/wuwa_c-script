using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200148C RID: 5260
	[NetMessage(EMessageId.TrapDefenseChallengeQuitResponse)]
	public sealed class TrapDefenseChallengeQuitResponse : IMessage<TrapDefenseChallengeQuitResponse>, IMessage, IEquatable<TrapDefenseChallengeQuitResponse>, IDeepCloneable<TrapDefenseChallengeQuitResponse>, IBufferMessage
	{
		// Token: 0x0601BEE9 RID: 114409 RVA: 0x0040EE69 File Offset: 0x0040D069
		[NullableContext(1)]
		public static TrapDefenseChallengeQuitResponse Create()
		{
			return new TrapDefenseChallengeQuitResponse();
		}

		// Token: 0x17005E96 RID: 24214
		// (get) Token: 0x0601BEEA RID: 114410 RVA: 0x0040EE70 File Offset: 0x0040D070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E97 RID: 24215
		// (get) Token: 0x0601BEEB RID: 114411 RVA: 0x0040EE73 File Offset: 0x0040D073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseChallengeQuitResponse.Descriptor;
			}
		}

		// Token: 0x0601BEEC RID: 114412 RVA: 0x0040EE7A File Offset: 0x0040D07A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseChallengeQuitResponse()
		{
		}

		// Token: 0x0601BEED RID: 114413 RVA: 0x0040EE82 File Offset: 0x0040D082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseChallengeQuitResponse(TrapDefenseChallengeQuitResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BEEE RID: 114414 RVA: 0x0040EEA7 File Offset: 0x0040D0A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseChallengeQuitResponse Clone()
		{
			return new TrapDefenseChallengeQuitResponse(this);
		}

		// Token: 0x17005E98 RID: 24216
		// (get) Token: 0x0601BEEF RID: 114415 RVA: 0x0040EEAF File Offset: 0x0040D0AF
		// (set) Token: 0x0601BEF0 RID: 114416 RVA: 0x0040EEB7 File Offset: 0x0040D0B7
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

		// Token: 0x0601BEF1 RID: 114417 RVA: 0x0040EEC0 File Offset: 0x0040D0C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseChallengeQuitResponse);
		}

		// Token: 0x0601BEF2 RID: 114418 RVA: 0x0040EECE File Offset: 0x0040D0CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseChallengeQuitResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BEF3 RID: 114419 RVA: 0x0040EEFC File Offset: 0x0040D0FC
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

		// Token: 0x0601BEF4 RID: 114420 RVA: 0x0040EF41 File Offset: 0x0040D141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BEF5 RID: 114421 RVA: 0x0040EF4E File Offset: 0x0040D14E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BEF6 RID: 114422 RVA: 0x0040EF57 File Offset: 0x0040D157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BEF7 RID: 114423 RVA: 0x0040EF8C File Offset: 0x0040D18C
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

		// Token: 0x0601BEF8 RID: 114424 RVA: 0x0040EFCA File Offset: 0x0040D1CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseChallengeQuitResponse other)
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

		// Token: 0x0601BEF9 RID: 114425 RVA: 0x0040EFFB File Offset: 0x0040D1FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BEFA RID: 114426 RVA: 0x0040F004 File Offset: 0x0040D204
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A1FC RID: 41468
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A1FD RID: 41469
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x0400A1FE RID: 41470
		private ErrorCode errorCode_;
	}
}
