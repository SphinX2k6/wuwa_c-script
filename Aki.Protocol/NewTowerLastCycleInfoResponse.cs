using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B36 RID: 2870
	[NetMessage(EMessageId.NewTowerLastCycleInfoResponse)]
	public sealed class NewTowerLastCycleInfoResponse : IMessage<NewTowerLastCycleInfoResponse>, IMessage, IEquatable<NewTowerLastCycleInfoResponse>, IDeepCloneable<NewTowerLastCycleInfoResponse>, IBufferMessage
	{
		// Token: 0x0600F915 RID: 63765 RVA: 0x00245416 File Offset: 0x00243616
		[NullableContext(1)]
		public static NewTowerLastCycleInfoResponse Create()
		{
			return new NewTowerLastCycleInfoResponse();
		}

		// Token: 0x170032C6 RID: 12998
		// (get) Token: 0x0600F916 RID: 63766 RVA: 0x0024541D File Offset: 0x0024361D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032C7 RID: 12999
		// (get) Token: 0x0600F917 RID: 63767 RVA: 0x00245420 File Offset: 0x00243620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerLastCycleInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600F918 RID: 63768 RVA: 0x00245427 File Offset: 0x00243627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerLastCycleInfoResponse()
		{
		}

		// Token: 0x0600F919 RID: 63769 RVA: 0x00245430 File Offset: 0x00243630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerLastCycleInfoResponse(NewTowerLastCycleInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.newTowerCycleRecordPb_ = ((other.newTowerCycleRecordPb_ != null) ? other.newTowerCycleRecordPb_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F91A RID: 63770 RVA: 0x0024547C File Offset: 0x0024367C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerLastCycleInfoResponse Clone()
		{
			return new NewTowerLastCycleInfoResponse(this);
		}

		// Token: 0x170032C8 RID: 13000
		// (get) Token: 0x0600F91B RID: 63771 RVA: 0x00245484 File Offset: 0x00243684
		// (set) Token: 0x0600F91C RID: 63772 RVA: 0x0024548C File Offset: 0x0024368C
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

		// Token: 0x170032C9 RID: 13001
		// (get) Token: 0x0600F91D RID: 63773 RVA: 0x00245495 File Offset: 0x00243695
		// (set) Token: 0x0600F91E RID: 63774 RVA: 0x0024549D File Offset: 0x0024369D
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

		// Token: 0x0600F91F RID: 63775 RVA: 0x002454A6 File Offset: 0x002436A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerLastCycleInfoResponse);
		}

		// Token: 0x0600F920 RID: 63776 RVA: 0x002454B4 File Offset: 0x002436B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerLastCycleInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.NewTowerCycleRecordPb, other.NewTowerCycleRecordPb) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F921 RID: 63777 RVA: 0x00245504 File Offset: 0x00243704
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

		// Token: 0x0600F922 RID: 63778 RVA: 0x0024555F File Offset: 0x0024375F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F923 RID: 63779 RVA: 0x0024556C File Offset: 0x0024376C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F924 RID: 63780 RVA: 0x00245578 File Offset: 0x00243778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.newTowerCycleRecordPb_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.NewTowerCycleRecordPb);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F925 RID: 63781 RVA: 0x002455D4 File Offset: 0x002437D4
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

		// Token: 0x0600F926 RID: 63782 RVA: 0x0024562C File Offset: 0x0024382C
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

		// Token: 0x0600F927 RID: 63783 RVA: 0x00245694 File Offset: 0x00243894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F928 RID: 63784 RVA: 0x002456A0 File Offset: 0x002438A0
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
				if (num != 64U)
				{
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040063D7 RID: 25559
		private UnknownFieldSet _unknownFields;

		// Token: 0x040063D8 RID: 25560
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x040063D9 RID: 25561
		private ErrorCode errorCode_;

		// Token: 0x040063DA RID: 25562
		public const int NewTowerCycleRecordPbFieldNumber = 9;

		// Token: 0x040063DB RID: 25563
		private NewTowerCycleRecordPb newTowerCycleRecordPb_;
	}
}
