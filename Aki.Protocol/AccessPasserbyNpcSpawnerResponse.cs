using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000052 RID: 82
	[NetMessage(EMessageId.AccessPasserbyNpcSpawnerResponse)]
	public sealed class AccessPasserbyNpcSpawnerResponse : IMessage<AccessPasserbyNpcSpawnerResponse>, IMessage, IEquatable<AccessPasserbyNpcSpawnerResponse>, IDeepCloneable<AccessPasserbyNpcSpawnerResponse>, IBufferMessage
	{
		// Token: 0x0600152E RID: 5422 RVA: 0x00038797 File Offset: 0x00036997
		[NullableContext(1)]
		public static AccessPasserbyNpcSpawnerResponse Create()
		{
			return new AccessPasserbyNpcSpawnerResponse();
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x0600152F RID: 5423 RVA: 0x0003879E File Offset: 0x0003699E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06001530 RID: 5424 RVA: 0x000387A1 File Offset: 0x000369A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccessPasserbyNpcSpawnerResponse.Descriptor;
			}
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x000387A8 File Offset: 0x000369A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessPasserbyNpcSpawnerResponse()
		{
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x000387B0 File Offset: 0x000369B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessPasserbyNpcSpawnerResponse(AccessPasserbyNpcSpawnerResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x000387D5 File Offset: 0x000369D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessPasserbyNpcSpawnerResponse Clone()
		{
			return new AccessPasserbyNpcSpawnerResponse(this);
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06001534 RID: 5428 RVA: 0x000387DD File Offset: 0x000369DD
		// (set) Token: 0x06001535 RID: 5429 RVA: 0x000387E5 File Offset: 0x000369E5
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

		// Token: 0x06001536 RID: 5430 RVA: 0x000387EE File Offset: 0x000369EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AccessPasserbyNpcSpawnerResponse);
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x000387FC File Offset: 0x000369FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AccessPasserbyNpcSpawnerResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x0003882C File Offset: 0x00036A2C
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

		// Token: 0x06001539 RID: 5433 RVA: 0x00038871 File Offset: 0x00036A71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x0003887E File Offset: 0x00036A7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x00038887 File Offset: 0x00036A87
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

		// Token: 0x0600153C RID: 5436 RVA: 0x000388BC File Offset: 0x00036ABC
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

		// Token: 0x0600153D RID: 5437 RVA: 0x000388FA File Offset: 0x00036AFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AccessPasserbyNpcSpawnerResponse other)
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

		// Token: 0x0600153E RID: 5438 RVA: 0x0003892B File Offset: 0x00036B2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600153F RID: 5439 RVA: 0x00038934 File Offset: 0x00036B34
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

		// Token: 0x040020DF RID: 8415
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020E0 RID: 8416
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x040020E1 RID: 8417
		private ErrorCode errorCode_;
	}
}
