using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B23 RID: 2851
	[NetMessage(EMessageId.NewTowerCycleStartResponse)]
	public sealed class NewTowerCycleStartResponse : IMessage<NewTowerCycleStartResponse>, IMessage, IEquatable<NewTowerCycleStartResponse>, IDeepCloneable<NewTowerCycleStartResponse>, IBufferMessage
	{
		// Token: 0x0600F7D9 RID: 63449 RVA: 0x00242EE0 File Offset: 0x002410E0
		[NullableContext(1)]
		public static NewTowerCycleStartResponse Create()
		{
			return new NewTowerCycleStartResponse();
		}

		// Token: 0x17003283 RID: 12931
		// (get) Token: 0x0600F7DA RID: 63450 RVA: 0x00242EE7 File Offset: 0x002410E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003284 RID: 12932
		// (get) Token: 0x0600F7DB RID: 63451 RVA: 0x00242EEA File Offset: 0x002410EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerCycleStartResponse.Descriptor;
			}
		}

		// Token: 0x0600F7DC RID: 63452 RVA: 0x00242EF1 File Offset: 0x002410F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerCycleStartResponse()
		{
		}

		// Token: 0x0600F7DD RID: 63453 RVA: 0x00242EF9 File Offset: 0x002410F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerCycleStartResponse(NewTowerCycleStartResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F7DE RID: 63454 RVA: 0x00242F1E File Offset: 0x0024111E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerCycleStartResponse Clone()
		{
			return new NewTowerCycleStartResponse(this);
		}

		// Token: 0x17003285 RID: 12933
		// (get) Token: 0x0600F7DF RID: 63455 RVA: 0x00242F26 File Offset: 0x00241126
		// (set) Token: 0x0600F7E0 RID: 63456 RVA: 0x00242F2E File Offset: 0x0024112E
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

		// Token: 0x0600F7E1 RID: 63457 RVA: 0x00242F37 File Offset: 0x00241137
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerCycleStartResponse);
		}

		// Token: 0x0600F7E2 RID: 63458 RVA: 0x00242F45 File Offset: 0x00241145
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerCycleStartResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F7E3 RID: 63459 RVA: 0x00242F74 File Offset: 0x00241174
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

		// Token: 0x0600F7E4 RID: 63460 RVA: 0x00242FB9 File Offset: 0x002411B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F7E5 RID: 63461 RVA: 0x00242FC6 File Offset: 0x002411C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F7E6 RID: 63462 RVA: 0x00242FCF File Offset: 0x002411CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F7E7 RID: 63463 RVA: 0x00243004 File Offset: 0x00241204
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

		// Token: 0x0600F7E8 RID: 63464 RVA: 0x00243042 File Offset: 0x00241242
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerCycleStartResponse other)
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

		// Token: 0x0600F7E9 RID: 63465 RVA: 0x00243073 File Offset: 0x00241273
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F7EA RID: 63466 RVA: 0x0024307C File Offset: 0x0024127C
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040063DC RID: 25564
		private UnknownFieldSet _unknownFields;

		// Token: 0x040063DD RID: 25565
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x040063DE RID: 25566
		private ErrorCode errorCode_;
	}
}
