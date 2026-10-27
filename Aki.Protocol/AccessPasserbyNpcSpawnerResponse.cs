using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000051 RID: 81
	[NetMessage(EMessageId.AccessPasserbyNpcSpawnerResponse)]
	public sealed class AccessPasserbyNpcSpawnerResponse : IMessage<AccessPasserbyNpcSpawnerResponse>, IMessage, IEquatable<AccessPasserbyNpcSpawnerResponse>, IDeepCloneable<AccessPasserbyNpcSpawnerResponse>, IBufferMessage
	{
		// Token: 0x060014EB RID: 5355 RVA: 0x00037DF3 File Offset: 0x00035FF3
		[NullableContext(1)]
		public static AccessPasserbyNpcSpawnerResponse Create()
		{
			return new AccessPasserbyNpcSpawnerResponse();
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060014EC RID: 5356 RVA: 0x00037DFA File Offset: 0x00035FFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060014ED RID: 5357 RVA: 0x00037DFD File Offset: 0x00035FFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccessPasserbyNpcSpawnerResponse.Descriptor;
			}
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x00037E04 File Offset: 0x00036004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessPasserbyNpcSpawnerResponse()
		{
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x00037E0C File Offset: 0x0003600C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessPasserbyNpcSpawnerResponse(AccessPasserbyNpcSpawnerResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x00037E31 File Offset: 0x00036031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessPasserbyNpcSpawnerResponse Clone()
		{
			return new AccessPasserbyNpcSpawnerResponse(this);
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060014F1 RID: 5361 RVA: 0x00037E39 File Offset: 0x00036039
		// (set) Token: 0x060014F2 RID: 5362 RVA: 0x00037E41 File Offset: 0x00036041
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

		// Token: 0x060014F3 RID: 5363 RVA: 0x00037E4A File Offset: 0x0003604A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AccessPasserbyNpcSpawnerResponse);
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x00037E58 File Offset: 0x00036058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AccessPasserbyNpcSpawnerResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x00037E88 File Offset: 0x00036088
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

		// Token: 0x060014F6 RID: 5366 RVA: 0x00037ECD File Offset: 0x000360CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x00037EDA File Offset: 0x000360DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x00037EE3 File Offset: 0x000360E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x00037F18 File Offset: 0x00036118
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

		// Token: 0x060014FA RID: 5370 RVA: 0x00037F56 File Offset: 0x00036156
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

		// Token: 0x060014FB RID: 5371 RVA: 0x00037F87 File Offset: 0x00036187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x00037F90 File Offset: 0x00036190
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002080 RID: 8320
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002081 RID: 8321
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04002082 RID: 8322
		private ErrorCode errorCode_;
	}
}
