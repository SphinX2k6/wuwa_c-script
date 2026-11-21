using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200147D RID: 5245
	[NetMessage(EMessageId.TrapDefenseAuxiliaryResetResponse)]
	public sealed class TrapDefenseAuxiliaryResetResponse : IMessage<TrapDefenseAuxiliaryResetResponse>, IMessage, IEquatable<TrapDefenseAuxiliaryResetResponse>, IDeepCloneable<TrapDefenseAuxiliaryResetResponse>, IBufferMessage
	{
		// Token: 0x0601BDA8 RID: 114088 RVA: 0x0040C2DD File Offset: 0x0040A4DD
		[NullableContext(1)]
		public static TrapDefenseAuxiliaryResetResponse Create()
		{
			return new TrapDefenseAuxiliaryResetResponse();
		}

		// Token: 0x17005E4F RID: 24143
		// (get) Token: 0x0601BDA9 RID: 114089 RVA: 0x0040C2E4 File Offset: 0x0040A4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E50 RID: 24144
		// (get) Token: 0x0601BDAA RID: 114090 RVA: 0x0040C2E7 File Offset: 0x0040A4E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseAuxiliaryResetResponse.Descriptor;
			}
		}

		// Token: 0x0601BDAB RID: 114091 RVA: 0x0040C2EE File Offset: 0x0040A4EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryResetResponse()
		{
		}

		// Token: 0x0601BDAC RID: 114092 RVA: 0x0040C2F6 File Offset: 0x0040A4F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryResetResponse(TrapDefenseAuxiliaryResetResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BDAD RID: 114093 RVA: 0x0040C31B File Offset: 0x0040A51B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryResetResponse Clone()
		{
			return new TrapDefenseAuxiliaryResetResponse(this);
		}

		// Token: 0x17005E51 RID: 24145
		// (get) Token: 0x0601BDAE RID: 114094 RVA: 0x0040C323 File Offset: 0x0040A523
		// (set) Token: 0x0601BDAF RID: 114095 RVA: 0x0040C32B File Offset: 0x0040A52B
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

		// Token: 0x0601BDB0 RID: 114096 RVA: 0x0040C334 File Offset: 0x0040A534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseAuxiliaryResetResponse);
		}

		// Token: 0x0601BDB1 RID: 114097 RVA: 0x0040C342 File Offset: 0x0040A542
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseAuxiliaryResetResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BDB2 RID: 114098 RVA: 0x0040C370 File Offset: 0x0040A570
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

		// Token: 0x0601BDB3 RID: 114099 RVA: 0x0040C3B5 File Offset: 0x0040A5B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BDB4 RID: 114100 RVA: 0x0040C3C2 File Offset: 0x0040A5C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BDB5 RID: 114101 RVA: 0x0040C3CB File Offset: 0x0040A5CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BDB6 RID: 114102 RVA: 0x0040C400 File Offset: 0x0040A600
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

		// Token: 0x0601BDB7 RID: 114103 RVA: 0x0040C43E File Offset: 0x0040A63E
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

		// Token: 0x0601BDB8 RID: 114104 RVA: 0x0040C46F File Offset: 0x0040A66F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BDB9 RID: 114105 RVA: 0x0040C478 File Offset: 0x0040A678
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A1A0 RID: 41376
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A1A1 RID: 41377
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x0400A1A2 RID: 41378
		private ErrorCode errorCode_;
	}
}
