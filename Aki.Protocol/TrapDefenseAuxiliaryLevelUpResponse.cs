using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001407 RID: 5127
	[NetMessage(EMessageId.TrapDefenseAuxiliaryLevelUpResponse)]
	public sealed class TrapDefenseAuxiliaryLevelUpResponse : IMessage<TrapDefenseAuxiliaryLevelUpResponse>, IMessage, IEquatable<TrapDefenseAuxiliaryLevelUpResponse>, IDeepCloneable<TrapDefenseAuxiliaryLevelUpResponse>, IBufferMessage
	{
		// Token: 0x0601B2E7 RID: 111335 RVA: 0x003F0A71 File Offset: 0x003EEC71
		[NullableContext(1)]
		public static TrapDefenseAuxiliaryLevelUpResponse Create()
		{
			return new TrapDefenseAuxiliaryLevelUpResponse();
		}

		// Token: 0x17005BB1 RID: 23473
		// (get) Token: 0x0601B2E8 RID: 111336 RVA: 0x003F0A78 File Offset: 0x003EEC78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BB2 RID: 23474
		// (get) Token: 0x0601B2E9 RID: 111337 RVA: 0x003F0A7B File Offset: 0x003EEC7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseAuxiliaryLevelUpResponse.Descriptor;
			}
		}

		// Token: 0x0601B2EA RID: 111338 RVA: 0x003F0A82 File Offset: 0x003EEC82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryLevelUpResponse()
		{
		}

		// Token: 0x0601B2EB RID: 111339 RVA: 0x003F0A8A File Offset: 0x003EEC8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryLevelUpResponse(TrapDefenseAuxiliaryLevelUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B2EC RID: 111340 RVA: 0x003F0AAF File Offset: 0x003EECAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryLevelUpResponse Clone()
		{
			return new TrapDefenseAuxiliaryLevelUpResponse(this);
		}

		// Token: 0x17005BB3 RID: 23475
		// (get) Token: 0x0601B2ED RID: 111341 RVA: 0x003F0AB7 File Offset: 0x003EECB7
		// (set) Token: 0x0601B2EE RID: 111342 RVA: 0x003F0ABF File Offset: 0x003EECBF
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

		// Token: 0x0601B2EF RID: 111343 RVA: 0x003F0AC8 File Offset: 0x003EECC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseAuxiliaryLevelUpResponse);
		}

		// Token: 0x0601B2F0 RID: 111344 RVA: 0x003F0AD6 File Offset: 0x003EECD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseAuxiliaryLevelUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B2F1 RID: 111345 RVA: 0x003F0B04 File Offset: 0x003EED04
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

		// Token: 0x0601B2F2 RID: 111346 RVA: 0x003F0B49 File Offset: 0x003EED49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B2F3 RID: 111347 RVA: 0x003F0B56 File Offset: 0x003EED56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B2F4 RID: 111348 RVA: 0x003F0B5F File Offset: 0x003EED5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B2F5 RID: 111349 RVA: 0x003F0B94 File Offset: 0x003EED94
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

		// Token: 0x0601B2F6 RID: 111350 RVA: 0x003F0BD2 File Offset: 0x003EEDD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseAuxiliaryLevelUpResponse other)
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

		// Token: 0x0601B2F7 RID: 111351 RVA: 0x003F0C03 File Offset: 0x003EEE03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B2F8 RID: 111352 RVA: 0x003F0C0C File Offset: 0x003EEE0C
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009D4F RID: 40271
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D50 RID: 40272
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04009D51 RID: 40273
		private ErrorCode errorCode_;
	}
}
