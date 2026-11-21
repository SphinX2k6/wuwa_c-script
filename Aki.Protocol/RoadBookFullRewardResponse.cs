using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F5C RID: 3932
	[NetMessage(EMessageId.RoadBookFullRewardResponse)]
	public sealed class RoadBookFullRewardResponse : IMessage<RoadBookFullRewardResponse>, IMessage, IEquatable<RoadBookFullRewardResponse>, IDeepCloneable<RoadBookFullRewardResponse>, IBufferMessage
	{
		// Token: 0x060150D4 RID: 86228 RVA: 0x0030E0B6 File Offset: 0x0030C2B6
		[NullableContext(1)]
		public static RoadBookFullRewardResponse Create()
		{
			return new RoadBookFullRewardResponse();
		}

		// Token: 0x1700460B RID: 17931
		// (get) Token: 0x060150D5 RID: 86229 RVA: 0x0030E0BD File Offset: 0x0030C2BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700460C RID: 17932
		// (get) Token: 0x060150D6 RID: 86230 RVA: 0x0030E0C0 File Offset: 0x0030C2C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoadBookFullRewardResponse.Descriptor;
			}
		}

		// Token: 0x060150D7 RID: 86231 RVA: 0x0030E0C7 File Offset: 0x0030C2C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookFullRewardResponse()
		{
		}

		// Token: 0x060150D8 RID: 86232 RVA: 0x0030E0CF File Offset: 0x0030C2CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookFullRewardResponse(RoadBookFullRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060150D9 RID: 86233 RVA: 0x0030E0F4 File Offset: 0x0030C2F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookFullRewardResponse Clone()
		{
			return new RoadBookFullRewardResponse(this);
		}

		// Token: 0x1700460D RID: 17933
		// (get) Token: 0x060150DA RID: 86234 RVA: 0x0030E0FC File Offset: 0x0030C2FC
		// (set) Token: 0x060150DB RID: 86235 RVA: 0x0030E104 File Offset: 0x0030C304
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

		// Token: 0x060150DC RID: 86236 RVA: 0x0030E10D File Offset: 0x0030C30D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoadBookFullRewardResponse);
		}

		// Token: 0x060150DD RID: 86237 RVA: 0x0030E11B File Offset: 0x0030C31B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoadBookFullRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060150DE RID: 86238 RVA: 0x0030E14C File Offset: 0x0030C34C
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

		// Token: 0x060150DF RID: 86239 RVA: 0x0030E191 File Offset: 0x0030C391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060150E0 RID: 86240 RVA: 0x0030E19E File Offset: 0x0030C39E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060150E1 RID: 86241 RVA: 0x0030E1A7 File Offset: 0x0030C3A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060150E2 RID: 86242 RVA: 0x0030E1DC File Offset: 0x0030C3DC
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

		// Token: 0x060150E3 RID: 86243 RVA: 0x0030E21A File Offset: 0x0030C41A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoadBookFullRewardResponse other)
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

		// Token: 0x060150E4 RID: 86244 RVA: 0x0030E24B File Offset: 0x0030C44B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060150E5 RID: 86245 RVA: 0x0030E254 File Offset: 0x0030C454
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007F36 RID: 32566
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F37 RID: 32567
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04007F38 RID: 32568
		private ErrorCode errorCode_;
	}
}
