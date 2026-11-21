using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A56 RID: 2646
	[NetMessage(EMessageId.MotorFightSelectCollectionResponse)]
	public sealed class MotorFightSelectCollectionResponse : IMessage<MotorFightSelectCollectionResponse>, IMessage, IEquatable<MotorFightSelectCollectionResponse>, IDeepCloneable<MotorFightSelectCollectionResponse>, IBufferMessage
	{
		// Token: 0x0600E73A RID: 59194 RVA: 0x0021D173 File Offset: 0x0021B373
		[NullableContext(1)]
		public static MotorFightSelectCollectionResponse Create()
		{
			return new MotorFightSelectCollectionResponse();
		}

		// Token: 0x17002EEA RID: 12010
		// (get) Token: 0x0600E73B RID: 59195 RVA: 0x0021D17A File Offset: 0x0021B37A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002EEB RID: 12011
		// (get) Token: 0x0600E73C RID: 59196 RVA: 0x0021D17D File Offset: 0x0021B37D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightSelectCollectionResponse.Descriptor;
			}
		}

		// Token: 0x0600E73D RID: 59197 RVA: 0x0021D184 File Offset: 0x0021B384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightSelectCollectionResponse()
		{
		}

		// Token: 0x0600E73E RID: 59198 RVA: 0x0021D18C File Offset: 0x0021B38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightSelectCollectionResponse(MotorFightSelectCollectionResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E73F RID: 59199 RVA: 0x0021D1B1 File Offset: 0x0021B3B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightSelectCollectionResponse Clone()
		{
			return new MotorFightSelectCollectionResponse(this);
		}

		// Token: 0x17002EEC RID: 12012
		// (get) Token: 0x0600E740 RID: 59200 RVA: 0x0021D1B9 File Offset: 0x0021B3B9
		// (set) Token: 0x0600E741 RID: 59201 RVA: 0x0021D1C1 File Offset: 0x0021B3C1
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

		// Token: 0x0600E742 RID: 59202 RVA: 0x0021D1CA File Offset: 0x0021B3CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightSelectCollectionResponse);
		}

		// Token: 0x0600E743 RID: 59203 RVA: 0x0021D1D8 File Offset: 0x0021B3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightSelectCollectionResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E744 RID: 59204 RVA: 0x0021D208 File Offset: 0x0021B408
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

		// Token: 0x0600E745 RID: 59205 RVA: 0x0021D24D File Offset: 0x0021B44D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E746 RID: 59206 RVA: 0x0021D25A File Offset: 0x0021B45A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E747 RID: 59207 RVA: 0x0021D263 File Offset: 0x0021B463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E748 RID: 59208 RVA: 0x0021D298 File Offset: 0x0021B498
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

		// Token: 0x0600E749 RID: 59209 RVA: 0x0021D2D6 File Offset: 0x0021B4D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightSelectCollectionResponse other)
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

		// Token: 0x0600E74A RID: 59210 RVA: 0x0021D307 File Offset: 0x0021B507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E74B RID: 59211 RVA: 0x0021D310 File Offset: 0x0021B510
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005EAF RID: 24239
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005EB0 RID: 24240
		public const int ErrCodeFieldNumber = 13;

		// Token: 0x04005EB1 RID: 24241
		private ErrorCode errCode_;
	}
}
