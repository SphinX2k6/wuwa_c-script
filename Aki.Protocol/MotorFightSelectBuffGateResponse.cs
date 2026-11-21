using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A54 RID: 2644
	[NetMessage(EMessageId.MotorFightSelectBuffGateResponse)]
	public sealed class MotorFightSelectBuffGateResponse : IMessage<MotorFightSelectBuffGateResponse>, IMessage, IEquatable<MotorFightSelectBuffGateResponse>, IDeepCloneable<MotorFightSelectBuffGateResponse>, IBufferMessage
	{
		// Token: 0x0600E70E RID: 59150 RVA: 0x0021CAED File Offset: 0x0021ACED
		[NullableContext(1)]
		public static MotorFightSelectBuffGateResponse Create()
		{
			return new MotorFightSelectBuffGateResponse();
		}

		// Token: 0x17002EE0 RID: 12000
		// (get) Token: 0x0600E70F RID: 59151 RVA: 0x0021CAF4 File Offset: 0x0021ACF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002EE1 RID: 12001
		// (get) Token: 0x0600E710 RID: 59152 RVA: 0x0021CAF7 File Offset: 0x0021ACF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightSelectBuffGateResponse.Descriptor;
			}
		}

		// Token: 0x0600E711 RID: 59153 RVA: 0x0021CAFE File Offset: 0x0021ACFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightSelectBuffGateResponse()
		{
		}

		// Token: 0x0600E712 RID: 59154 RVA: 0x0021CB06 File Offset: 0x0021AD06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightSelectBuffGateResponse(MotorFightSelectBuffGateResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E713 RID: 59155 RVA: 0x0021CB2B File Offset: 0x0021AD2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightSelectBuffGateResponse Clone()
		{
			return new MotorFightSelectBuffGateResponse(this);
		}

		// Token: 0x17002EE2 RID: 12002
		// (get) Token: 0x0600E714 RID: 59156 RVA: 0x0021CB33 File Offset: 0x0021AD33
		// (set) Token: 0x0600E715 RID: 59157 RVA: 0x0021CB3B File Offset: 0x0021AD3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x0600E716 RID: 59158 RVA: 0x0021CB44 File Offset: 0x0021AD44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightSelectBuffGateResponse);
		}

		// Token: 0x0600E717 RID: 59159 RVA: 0x0021CB52 File Offset: 0x0021AD52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightSelectBuffGateResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E718 RID: 59160 RVA: 0x0021CB80 File Offset: 0x0021AD80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E719 RID: 59161 RVA: 0x0021CBC5 File Offset: 0x0021ADC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E71A RID: 59162 RVA: 0x0021CBD2 File Offset: 0x0021ADD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E71B RID: 59163 RVA: 0x0021CBDB File Offset: 0x0021ADDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E71C RID: 59164 RVA: 0x0021CC10 File Offset: 0x0021AE10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E71D RID: 59165 RVA: 0x0021CC4E File Offset: 0x0021AE4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightSelectBuffGateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E71E RID: 59166 RVA: 0x0021CC7F File Offset: 0x0021AE7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E71F RID: 59167 RVA: 0x0021CC88 File Offset: 0x0021AE88
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005EA1 RID: 24225
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005EA2 RID: 24226
		public const int ErrCodeFieldNumber = 11;

		// Token: 0x04005EA3 RID: 24227
		private ErrorCode errCode_;
	}
}
