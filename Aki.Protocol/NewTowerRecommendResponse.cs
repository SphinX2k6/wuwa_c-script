using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B30 RID: 2864
	[NetMessage(EMessageId.NewTowerRecommendResponse)]
	public sealed class NewTowerRecommendResponse : IMessage<NewTowerRecommendResponse>, IMessage, IEquatable<NewTowerRecommendResponse>, IDeepCloneable<NewTowerRecommendResponse>, IBufferMessage
	{
		// Token: 0x0600F8D9 RID: 63705 RVA: 0x00244E46 File Offset: 0x00243046
		[NullableContext(1)]
		public static NewTowerRecommendResponse Create()
		{
			return new NewTowerRecommendResponse();
		}

		// Token: 0x170032B6 RID: 12982
		// (get) Token: 0x0600F8DA RID: 63706 RVA: 0x00244E4D File Offset: 0x0024304D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032B7 RID: 12983
		// (get) Token: 0x0600F8DB RID: 63707 RVA: 0x00244E50 File Offset: 0x00243050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerRecommendResponse.Descriptor;
			}
		}

		// Token: 0x0600F8DC RID: 63708 RVA: 0x00244E57 File Offset: 0x00243057
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRecommendResponse()
		{
		}

		// Token: 0x0600F8DD RID: 63709 RVA: 0x00244E60 File Offset: 0x00243060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRecommendResponse(NewTowerRecommendResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.newTowerRecommendData_ = ((other.newTowerRecommendData_ != null) ? other.newTowerRecommendData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F8DE RID: 63710 RVA: 0x00244EAC File Offset: 0x002430AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRecommendResponse Clone()
		{
			return new NewTowerRecommendResponse(this);
		}

		// Token: 0x170032B8 RID: 12984
		// (get) Token: 0x0600F8DF RID: 63711 RVA: 0x00244EB4 File Offset: 0x002430B4
		// (set) Token: 0x0600F8E0 RID: 63712 RVA: 0x00244EBC File Offset: 0x002430BC
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

		// Token: 0x170032B9 RID: 12985
		// (get) Token: 0x0600F8E1 RID: 63713 RVA: 0x00244EC5 File Offset: 0x002430C5
		// (set) Token: 0x0600F8E2 RID: 63714 RVA: 0x00244ECD File Offset: 0x002430CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRecommendData NewTowerRecommendData
		{
			get
			{
				return this.newTowerRecommendData_;
			}
			set
			{
				this.newTowerRecommendData_ = value;
			}
		}

		// Token: 0x0600F8E3 RID: 63715 RVA: 0x00244ED6 File Offset: 0x002430D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerRecommendResponse);
		}

		// Token: 0x0600F8E4 RID: 63716 RVA: 0x00244EE4 File Offset: 0x002430E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerRecommendResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.NewTowerRecommendData, other.NewTowerRecommendData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F8E5 RID: 63717 RVA: 0x00244F34 File Offset: 0x00243134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.newTowerRecommendData_ != null)
			{
				num ^= this.NewTowerRecommendData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F8E6 RID: 63718 RVA: 0x00244F8F File Offset: 0x0024318F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F8E7 RID: 63719 RVA: 0x00244F9C File Offset: 0x0024319C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F8E8 RID: 63720 RVA: 0x00244FA8 File Offset: 0x002431A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.newTowerRecommendData_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.NewTowerRecommendData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F8E9 RID: 63721 RVA: 0x00245004 File Offset: 0x00243204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.newTowerRecommendData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NewTowerRecommendData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F8EA RID: 63722 RVA: 0x0024505C File Offset: 0x0024325C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerRecommendResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.newTowerRecommendData_ != null)
			{
				if (this.newTowerRecommendData_ == null)
				{
					this.NewTowerRecommendData = new NewTowerRecommendData();
				}
				this.NewTowerRecommendData.MergeFrom(other.NewTowerRecommendData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F8EB RID: 63723 RVA: 0x002450C4 File Offset: 0x002432C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F8EC RID: 63724 RVA: 0x002450D0 File Offset: 0x002432D0
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
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.newTowerRecommendData_ == null)
						{
							this.NewTowerRecommendData = new NewTowerRecommendData();
						}
						input.ReadMessage(this.NewTowerRecommendData);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400641C RID: 25628
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400641D RID: 25629
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x0400641E RID: 25630
		private ErrorCode errorCode_;

		// Token: 0x0400641F RID: 25631
		public const int NewTowerRecommendDataFieldNumber = 12;

		// Token: 0x04006420 RID: 25632
		private NewTowerRecommendData newTowerRecommendData_;
	}
}
