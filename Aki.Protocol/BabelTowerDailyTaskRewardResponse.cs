using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200014F RID: 335
	[NetMessage(EMessageId.BabelTowerDailyTaskRewardResponse)]
	public sealed class BabelTowerDailyTaskRewardResponse : IMessage<BabelTowerDailyTaskRewardResponse>, IMessage, IEquatable<BabelTowerDailyTaskRewardResponse>, IDeepCloneable<BabelTowerDailyTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x06002AFC RID: 11004 RVA: 0x00070BC9 File Offset: 0x0006EDC9
		[NullableContext(1)]
		public static BabelTowerDailyTaskRewardResponse Create()
		{
			return new BabelTowerDailyTaskRewardResponse();
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06002AFD RID: 11005 RVA: 0x00070BD0 File Offset: 0x0006EDD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06002AFE RID: 11006 RVA: 0x00070BD3 File Offset: 0x0006EDD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelTowerDailyTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x06002AFF RID: 11007 RVA: 0x00070BDA File Offset: 0x0006EDDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerDailyTaskRewardResponse()
		{
		}

		// Token: 0x06002B00 RID: 11008 RVA: 0x00070BE2 File Offset: 0x0006EDE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerDailyTaskRewardResponse(BabelTowerDailyTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002B01 RID: 11009 RVA: 0x00070C07 File Offset: 0x0006EE07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerDailyTaskRewardResponse Clone()
		{
			return new BabelTowerDailyTaskRewardResponse(this);
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06002B02 RID: 11010 RVA: 0x00070C0F File Offset: 0x0006EE0F
		// (set) Token: 0x06002B03 RID: 11011 RVA: 0x00070C17 File Offset: 0x0006EE17
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

		// Token: 0x06002B04 RID: 11012 RVA: 0x00070C20 File Offset: 0x0006EE20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelTowerDailyTaskRewardResponse);
		}

		// Token: 0x06002B05 RID: 11013 RVA: 0x00070C2E File Offset: 0x0006EE2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelTowerDailyTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002B06 RID: 11014 RVA: 0x00070C5C File Offset: 0x0006EE5C
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

		// Token: 0x06002B07 RID: 11015 RVA: 0x00070CA1 File Offset: 0x0006EEA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002B08 RID: 11016 RVA: 0x00070CAE File Offset: 0x0006EEAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002B09 RID: 11017 RVA: 0x00070CB7 File Offset: 0x0006EEB7
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

		// Token: 0x06002B0A RID: 11018 RVA: 0x00070CEC File Offset: 0x0006EEEC
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

		// Token: 0x06002B0B RID: 11019 RVA: 0x00070D2A File Offset: 0x0006EF2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelTowerDailyTaskRewardResponse other)
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

		// Token: 0x06002B0C RID: 11020 RVA: 0x00070D5B File Offset: 0x0006EF5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002B0D RID: 11021 RVA: 0x00070D64 File Offset: 0x0006EF64
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

		// Token: 0x040027DF RID: 10207
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027E0 RID: 10208
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x040027E1 RID: 10209
		private ErrorCode errorCode_;
	}
}
