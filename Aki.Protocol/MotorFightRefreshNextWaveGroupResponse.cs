using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A5A RID: 2650
	[NetMessage(EMessageId.MotorFightRefreshNextWaveGroupResponse)]
	public sealed class MotorFightRefreshNextWaveGroupResponse : IMessage<MotorFightRefreshNextWaveGroupResponse>, IMessage, IEquatable<MotorFightRefreshNextWaveGroupResponse>, IDeepCloneable<MotorFightRefreshNextWaveGroupResponse>, IBufferMessage
	{
		// Token: 0x0600E725 RID: 59173 RVA: 0x0021C2BD File Offset: 0x0021A4BD
		[NullableContext(1)]
		public static MotorFightRefreshNextWaveGroupResponse Create()
		{
			return new MotorFightRefreshNextWaveGroupResponse();
		}

		// Token: 0x17002EDD RID: 11997
		// (get) Token: 0x0600E726 RID: 59174 RVA: 0x0021C2C4 File Offset: 0x0021A4C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002EDE RID: 11998
		// (get) Token: 0x0600E727 RID: 59175 RVA: 0x0021C2C7 File Offset: 0x0021A4C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightRefreshNextWaveGroupResponse.Descriptor;
			}
		}

		// Token: 0x0600E728 RID: 59176 RVA: 0x0021C2CE File Offset: 0x0021A4CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshNextWaveGroupResponse()
		{
		}

		// Token: 0x0600E729 RID: 59177 RVA: 0x0021C2D6 File Offset: 0x0021A4D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshNextWaveGroupResponse(MotorFightRefreshNextWaveGroupResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E72A RID: 59178 RVA: 0x0021C2FB File Offset: 0x0021A4FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshNextWaveGroupResponse Clone()
		{
			return new MotorFightRefreshNextWaveGroupResponse(this);
		}

		// Token: 0x17002EDF RID: 11999
		// (get) Token: 0x0600E72B RID: 59179 RVA: 0x0021C303 File Offset: 0x0021A503
		// (set) Token: 0x0600E72C RID: 59180 RVA: 0x0021C30B File Offset: 0x0021A50B
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

		// Token: 0x0600E72D RID: 59181 RVA: 0x0021C314 File Offset: 0x0021A514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightRefreshNextWaveGroupResponse);
		}

		// Token: 0x0600E72E RID: 59182 RVA: 0x0021C322 File Offset: 0x0021A522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightRefreshNextWaveGroupResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E72F RID: 59183 RVA: 0x0021C350 File Offset: 0x0021A550
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

		// Token: 0x0600E730 RID: 59184 RVA: 0x0021C395 File Offset: 0x0021A595
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E731 RID: 59185 RVA: 0x0021C3A2 File Offset: 0x0021A5A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E732 RID: 59186 RVA: 0x0021C3AB File Offset: 0x0021A5AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E733 RID: 59187 RVA: 0x0021C3E0 File Offset: 0x0021A5E0
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

		// Token: 0x0600E734 RID: 59188 RVA: 0x0021C41E File Offset: 0x0021A61E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightRefreshNextWaveGroupResponse other)
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

		// Token: 0x0600E735 RID: 59189 RVA: 0x0021C44F File Offset: 0x0021A64F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E736 RID: 59190 RVA: 0x0021C458 File Offset: 0x0021A658
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005E30 RID: 24112
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E31 RID: 24113
		public const int ErrCodeFieldNumber = 3;

		// Token: 0x04005E32 RID: 24114
		private ErrorCode errCode_;
	}
}
