using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200140A RID: 5130
	[NetMessage(EMessageId.TrapDefenseAuxiliaryResetResponse)]
	public sealed class TrapDefenseAuxiliaryResetResponse : IMessage<TrapDefenseAuxiliaryResetResponse>, IMessage, IEquatable<TrapDefenseAuxiliaryResetResponse>, IDeepCloneable<TrapDefenseAuxiliaryResetResponse>, IBufferMessage
	{
		// Token: 0x0601B31D RID: 111389 RVA: 0x003F1009 File Offset: 0x003EF209
		[NullableContext(1)]
		public static TrapDefenseAuxiliaryResetResponse Create()
		{
			return new TrapDefenseAuxiliaryResetResponse();
		}

		// Token: 0x17005BBA RID: 23482
		// (get) Token: 0x0601B31E RID: 111390 RVA: 0x003F1010 File Offset: 0x003EF210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BBB RID: 23483
		// (get) Token: 0x0601B31F RID: 111391 RVA: 0x003F1013 File Offset: 0x003EF213
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseAuxiliaryResetResponse.Descriptor;
			}
		}

		// Token: 0x0601B320 RID: 111392 RVA: 0x003F101A File Offset: 0x003EF21A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryResetResponse()
		{
		}

		// Token: 0x0601B321 RID: 111393 RVA: 0x003F1022 File Offset: 0x003EF222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryResetResponse(TrapDefenseAuxiliaryResetResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B322 RID: 111394 RVA: 0x003F1047 File Offset: 0x003EF247
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryResetResponse Clone()
		{
			return new TrapDefenseAuxiliaryResetResponse(this);
		}

		// Token: 0x17005BBC RID: 23484
		// (get) Token: 0x0601B323 RID: 111395 RVA: 0x003F104F File Offset: 0x003EF24F
		// (set) Token: 0x0601B324 RID: 111396 RVA: 0x003F1057 File Offset: 0x003EF257
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

		// Token: 0x0601B325 RID: 111397 RVA: 0x003F1060 File Offset: 0x003EF260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseAuxiliaryResetResponse);
		}

		// Token: 0x0601B326 RID: 111398 RVA: 0x003F106E File Offset: 0x003EF26E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseAuxiliaryResetResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B327 RID: 111399 RVA: 0x003F109C File Offset: 0x003EF29C
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

		// Token: 0x0601B328 RID: 111400 RVA: 0x003F10E1 File Offset: 0x003EF2E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B329 RID: 111401 RVA: 0x003F10EE File Offset: 0x003EF2EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B32A RID: 111402 RVA: 0x003F10F7 File Offset: 0x003EF2F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B32B RID: 111403 RVA: 0x003F112C File Offset: 0x003EF32C
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

		// Token: 0x0601B32C RID: 111404 RVA: 0x003F116A File Offset: 0x003EF36A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseAuxiliaryResetResponse other)
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

		// Token: 0x0601B32D RID: 111405 RVA: 0x003F119B File Offset: 0x003EF39B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B32E RID: 111406 RVA: 0x003F11A4 File Offset: 0x003EF3A4
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009D59 RID: 40281
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D5A RID: 40282
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04009D5B RID: 40283
		private ErrorCode errorCode_;
	}
}
