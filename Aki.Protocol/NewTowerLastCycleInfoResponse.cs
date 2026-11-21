using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B25 RID: 2853
	[NetMessage(EMessageId.NewTowerLastCycleInfoResponse)]
	public sealed class NewTowerLastCycleInfoResponse : IMessage<NewTowerLastCycleInfoResponse>, IMessage, IEquatable<NewTowerLastCycleInfoResponse>, IDeepCloneable<NewTowerLastCycleInfoResponse>, IBufferMessage
	{
		// Token: 0x0600F7FB RID: 63483 RVA: 0x002431FA File Offset: 0x002413FA
		[NullableContext(1)]
		public static NewTowerLastCycleInfoResponse Create()
		{
			return new NewTowerLastCycleInfoResponse();
		}

		// Token: 0x17003288 RID: 12936
		// (get) Token: 0x0600F7FC RID: 63484 RVA: 0x00243201 File Offset: 0x00241401
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003289 RID: 12937
		// (get) Token: 0x0600F7FD RID: 63485 RVA: 0x00243204 File Offset: 0x00241404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerLastCycleInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600F7FE RID: 63486 RVA: 0x0024320B File Offset: 0x0024140B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerLastCycleInfoResponse()
		{
		}

		// Token: 0x0600F7FF RID: 63487 RVA: 0x00243214 File Offset: 0x00241414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerLastCycleInfoResponse(NewTowerLastCycleInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.newTowerCycleRecordPb_ = ((other.newTowerCycleRecordPb_ != null) ? other.newTowerCycleRecordPb_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F800 RID: 63488 RVA: 0x00243260 File Offset: 0x00241460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerLastCycleInfoResponse Clone()
		{
			return new NewTowerLastCycleInfoResponse(this);
		}

		// Token: 0x1700328A RID: 12938
		// (get) Token: 0x0600F801 RID: 63489 RVA: 0x00243268 File Offset: 0x00241468
		// (set) Token: 0x0600F802 RID: 63490 RVA: 0x00243270 File Offset: 0x00241470
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

		// Token: 0x1700328B RID: 12939
		// (get) Token: 0x0600F803 RID: 63491 RVA: 0x00243279 File Offset: 0x00241479
		// (set) Token: 0x0600F804 RID: 63492 RVA: 0x00243281 File Offset: 0x00241481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerCycleRecordPb NewTowerCycleRecordPb
		{
			get
			{
				return this.newTowerCycleRecordPb_;
			}
			set
			{
				this.newTowerCycleRecordPb_ = value;
			}
		}

		// Token: 0x0600F805 RID: 63493 RVA: 0x0024328A File Offset: 0x0024148A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerLastCycleInfoResponse);
		}

		// Token: 0x0600F806 RID: 63494 RVA: 0x00243298 File Offset: 0x00241498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerLastCycleInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.NewTowerCycleRecordPb, other.NewTowerCycleRecordPb) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F807 RID: 63495 RVA: 0x002432E8 File Offset: 0x002414E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.newTowerCycleRecordPb_ != null)
			{
				num ^= this.NewTowerCycleRecordPb.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F808 RID: 63496 RVA: 0x00243343 File Offset: 0x00241543
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F809 RID: 63497 RVA: 0x00243350 File Offset: 0x00241550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F80A RID: 63498 RVA: 0x0024335C File Offset: 0x0024155C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.newTowerCycleRecordPb_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.NewTowerCycleRecordPb);
			}
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

		// Token: 0x0600F80B RID: 63499 RVA: 0x002433B8 File Offset: 0x002415B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.newTowerCycleRecordPb_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NewTowerCycleRecordPb);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F80C RID: 63500 RVA: 0x00243410 File Offset: 0x00241610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerLastCycleInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.newTowerCycleRecordPb_ != null)
			{
				if (this.newTowerCycleRecordPb_ == null)
				{
					this.NewTowerCycleRecordPb = new NewTowerCycleRecordPb();
				}
				this.NewTowerCycleRecordPb.MergeFrom(other.NewTowerCycleRecordPb);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F80D RID: 63501 RVA: 0x00243478 File Offset: 0x00241678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F80E RID: 63502 RVA: 0x00243484 File Offset: 0x00241684
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
				if (num != 58U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.newTowerCycleRecordPb_ == null)
					{
						this.NewTowerCycleRecordPb = new NewTowerCycleRecordPb();
					}
					input.ReadMessage(this.NewTowerCycleRecordPb);
				}
			}
		}

		// Token: 0x040063E0 RID: 25568
		private UnknownFieldSet _unknownFields;

		// Token: 0x040063E1 RID: 25569
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x040063E2 RID: 25570
		private ErrorCode errorCode_;

		// Token: 0x040063E3 RID: 25571
		public const int NewTowerCycleRecordPbFieldNumber = 7;

		// Token: 0x040063E4 RID: 25572
		private NewTowerCycleRecordPb newTowerCycleRecordPb_;
	}
}
