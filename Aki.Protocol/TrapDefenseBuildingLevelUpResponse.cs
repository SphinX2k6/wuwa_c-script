using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001411 RID: 5137
	[NetMessage(EMessageId.TrapDefenseBuildingLevelUpResponse)]
	public sealed class TrapDefenseBuildingLevelUpResponse : IMessage<TrapDefenseBuildingLevelUpResponse>, IMessage, IEquatable<TrapDefenseBuildingLevelUpResponse>, IDeepCloneable<TrapDefenseBuildingLevelUpResponse>, IBufferMessage
	{
		// Token: 0x0601B3AD RID: 111533 RVA: 0x003F22B1 File Offset: 0x003F04B1
		[NullableContext(1)]
		public static TrapDefenseBuildingLevelUpResponse Create()
		{
			return new TrapDefenseBuildingLevelUpResponse();
		}

		// Token: 0x17005BD8 RID: 23512
		// (get) Token: 0x0601B3AE RID: 111534 RVA: 0x003F22B8 File Offset: 0x003F04B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BD9 RID: 23513
		// (get) Token: 0x0601B3AF RID: 111535 RVA: 0x003F22BB File Offset: 0x003F04BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseBuildingLevelUpResponse.Descriptor;
			}
		}

		// Token: 0x0601B3B0 RID: 111536 RVA: 0x003F22C2 File Offset: 0x003F04C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingLevelUpResponse()
		{
		}

		// Token: 0x0601B3B1 RID: 111537 RVA: 0x003F22CA File Offset: 0x003F04CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingLevelUpResponse(TrapDefenseBuildingLevelUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B3B2 RID: 111538 RVA: 0x003F22EF File Offset: 0x003F04EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingLevelUpResponse Clone()
		{
			return new TrapDefenseBuildingLevelUpResponse(this);
		}

		// Token: 0x17005BDA RID: 23514
		// (get) Token: 0x0601B3B3 RID: 111539 RVA: 0x003F22F7 File Offset: 0x003F04F7
		// (set) Token: 0x0601B3B4 RID: 111540 RVA: 0x003F22FF File Offset: 0x003F04FF
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

		// Token: 0x0601B3B5 RID: 111541 RVA: 0x003F2308 File Offset: 0x003F0508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseBuildingLevelUpResponse);
		}

		// Token: 0x0601B3B6 RID: 111542 RVA: 0x003F2316 File Offset: 0x003F0516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseBuildingLevelUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B3B7 RID: 111543 RVA: 0x003F2344 File Offset: 0x003F0544
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

		// Token: 0x0601B3B8 RID: 111544 RVA: 0x003F2389 File Offset: 0x003F0589
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B3B9 RID: 111545 RVA: 0x003F2396 File Offset: 0x003F0596
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B3BA RID: 111546 RVA: 0x003F239F File Offset: 0x003F059F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B3BB RID: 111547 RVA: 0x003F23D4 File Offset: 0x003F05D4
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

		// Token: 0x0601B3BC RID: 111548 RVA: 0x003F2412 File Offset: 0x003F0612
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseBuildingLevelUpResponse other)
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

		// Token: 0x0601B3BD RID: 111549 RVA: 0x003F2443 File Offset: 0x003F0643
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B3BE RID: 111550 RVA: 0x003F244C File Offset: 0x003F064C
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009D81 RID: 40321
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D82 RID: 40322
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04009D83 RID: 40323
		private ErrorCode errorCode_;
	}
}
