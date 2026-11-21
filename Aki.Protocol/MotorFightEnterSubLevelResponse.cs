using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A2F RID: 2607
	[NetMessage(EMessageId.MotorFightEnterSubLevelResponse)]
	public sealed class MotorFightEnterSubLevelResponse : IMessage<MotorFightEnterSubLevelResponse>, IMessage, IEquatable<MotorFightEnterSubLevelResponse>, IDeepCloneable<MotorFightEnterSubLevelResponse>, IBufferMessage
	{
		// Token: 0x0600E3FF RID: 58367 RVA: 0x00215C78 File Offset: 0x00213E78
		[NullableContext(1)]
		public static MotorFightEnterSubLevelResponse Create()
		{
			return new MotorFightEnterSubLevelResponse();
		}

		// Token: 0x17002E35 RID: 11829
		// (get) Token: 0x0600E400 RID: 58368 RVA: 0x00215C7F File Offset: 0x00213E7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E36 RID: 11830
		// (get) Token: 0x0600E401 RID: 58369 RVA: 0x00215C82 File Offset: 0x00213E82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightEnterSubLevelResponse.Descriptor;
			}
		}

		// Token: 0x0600E402 RID: 58370 RVA: 0x00215C89 File Offset: 0x00213E89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightEnterSubLevelResponse()
		{
		}

		// Token: 0x0600E403 RID: 58371 RVA: 0x00215C91 File Offset: 0x00213E91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightEnterSubLevelResponse(MotorFightEnterSubLevelResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E404 RID: 58372 RVA: 0x00215CB6 File Offset: 0x00213EB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightEnterSubLevelResponse Clone()
		{
			return new MotorFightEnterSubLevelResponse(this);
		}

		// Token: 0x17002E37 RID: 11831
		// (get) Token: 0x0600E405 RID: 58373 RVA: 0x00215CBE File Offset: 0x00213EBE
		// (set) Token: 0x0600E406 RID: 58374 RVA: 0x00215CC6 File Offset: 0x00213EC6
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

		// Token: 0x0600E407 RID: 58375 RVA: 0x00215CCF File Offset: 0x00213ECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightEnterSubLevelResponse);
		}

		// Token: 0x0600E408 RID: 58376 RVA: 0x00215CDD File Offset: 0x00213EDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightEnterSubLevelResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E409 RID: 58377 RVA: 0x00215D0C File Offset: 0x00213F0C
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

		// Token: 0x0600E40A RID: 58378 RVA: 0x00215D51 File Offset: 0x00213F51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E40B RID: 58379 RVA: 0x00215D5E File Offset: 0x00213F5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E40C RID: 58380 RVA: 0x00215D67 File Offset: 0x00213F67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E40D RID: 58381 RVA: 0x00215D9C File Offset: 0x00213F9C
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

		// Token: 0x0600E40E RID: 58382 RVA: 0x00215DDA File Offset: 0x00213FDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightEnterSubLevelResponse other)
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

		// Token: 0x0600E40F RID: 58383 RVA: 0x00215E0B File Offset: 0x0021400B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E410 RID: 58384 RVA: 0x00215E14 File Offset: 0x00214014
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005DB1 RID: 23985
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005DB2 RID: 23986
		public const int ErrCodeFieldNumber = 12;

		// Token: 0x04005DB3 RID: 23987
		private ErrorCode errCode_;
	}
}
