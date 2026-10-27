using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B41 RID: 2881
	[NetMessage(EMessageId.NewTowerRecommendResponse)]
	public sealed class NewTowerRecommendResponse : IMessage<NewTowerRecommendResponse>, IMessage, IEquatable<NewTowerRecommendResponse>, IDeepCloneable<NewTowerRecommendResponse>, IBufferMessage
	{
		// Token: 0x0600F9F3 RID: 63987 RVA: 0x00247062 File Offset: 0x00245262
		[NullableContext(1)]
		public static NewTowerRecommendResponse Create()
		{
			return new NewTowerRecommendResponse();
		}

		// Token: 0x170032F4 RID: 13044
		// (get) Token: 0x0600F9F4 RID: 63988 RVA: 0x00247069 File Offset: 0x00245269
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032F5 RID: 13045
		// (get) Token: 0x0600F9F5 RID: 63989 RVA: 0x0024706C File Offset: 0x0024526C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerRecommendResponse.Descriptor;
			}
		}

		// Token: 0x0600F9F6 RID: 63990 RVA: 0x00247073 File Offset: 0x00245273
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRecommendResponse()
		{
		}

		// Token: 0x0600F9F7 RID: 63991 RVA: 0x0024707C File Offset: 0x0024527C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRecommendResponse(NewTowerRecommendResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.newTowerRecommendData_ = ((other.newTowerRecommendData_ != null) ? other.newTowerRecommendData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F9F8 RID: 63992 RVA: 0x002470C8 File Offset: 0x002452C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRecommendResponse Clone()
		{
			return new NewTowerRecommendResponse(this);
		}

		// Token: 0x170032F6 RID: 13046
		// (get) Token: 0x0600F9F9 RID: 63993 RVA: 0x002470D0 File Offset: 0x002452D0
		// (set) Token: 0x0600F9FA RID: 63994 RVA: 0x002470D8 File Offset: 0x002452D8
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

		// Token: 0x170032F7 RID: 13047
		// (get) Token: 0x0600F9FB RID: 63995 RVA: 0x002470E1 File Offset: 0x002452E1
		// (set) Token: 0x0600F9FC RID: 63996 RVA: 0x002470E9 File Offset: 0x002452E9
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

		// Token: 0x0600F9FD RID: 63997 RVA: 0x002470F2 File Offset: 0x002452F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerRecommendResponse);
		}

		// Token: 0x0600F9FE RID: 63998 RVA: 0x00247100 File Offset: 0x00245300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerRecommendResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.NewTowerRecommendData, other.NewTowerRecommendData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F9FF RID: 63999 RVA: 0x00247150 File Offset: 0x00245350
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

		// Token: 0x0600FA00 RID: 64000 RVA: 0x002471AB File Offset: 0x002453AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FA01 RID: 64001 RVA: 0x002471B8 File Offset: 0x002453B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FA02 RID: 64002 RVA: 0x002471C4 File Offset: 0x002453C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.newTowerRecommendData_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.NewTowerRecommendData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FA03 RID: 64003 RVA: 0x0024721C File Offset: 0x0024541C
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

		// Token: 0x0600FA04 RID: 64004 RVA: 0x00247274 File Offset: 0x00245474
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

		// Token: 0x0600FA05 RID: 64005 RVA: 0x002472DC File Offset: 0x002454DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FA06 RID: 64006 RVA: 0x002472E8 File Offset: 0x002454E8
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
				if (num != 8U)
				{
					if (num != 18U)
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

		// Token: 0x04006413 RID: 25619
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006414 RID: 25620
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04006415 RID: 25621
		private ErrorCode errorCode_;

		// Token: 0x04006416 RID: 25622
		public const int NewTowerRecommendDataFieldNumber = 2;

		// Token: 0x04006417 RID: 25623
		private NewTowerRecommendData newTowerRecommendData_;
	}
}
