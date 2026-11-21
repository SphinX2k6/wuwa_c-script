using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000BF RID: 191
	[NetMessage(EMessageId.AdventureManualDataResponse)]
	public sealed class AdventureManualDataResponse : IMessage<AdventureManualDataResponse>, IMessage, IEquatable<AdventureManualDataResponse>, IDeepCloneable<AdventureManualDataResponse>, IBufferMessage
	{
		// Token: 0x06001EDF RID: 7903 RVA: 0x000542D9 File Offset: 0x000524D9
		[NullableContext(1)]
		public static AdventureManualDataResponse Create()
		{
			return new AdventureManualDataResponse();
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06001EE0 RID: 7904 RVA: 0x000542E0 File Offset: 0x000524E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06001EE1 RID: 7905 RVA: 0x000542E3 File Offset: 0x000524E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdventureManualDataResponse.Descriptor;
			}
		}

		// Token: 0x06001EE2 RID: 7906 RVA: 0x000542EA File Offset: 0x000524EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureManualDataResponse()
		{
		}

		// Token: 0x06001EE3 RID: 7907 RVA: 0x000542F4 File Offset: 0x000524F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureManualDataResponse(AdventureManualDataResponse other) : this()
		{
			this.code_ = other.code_;
			this.adventureManualData_ = ((other.adventureManualData_ != null) ? other.adventureManualData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001EE4 RID: 7908 RVA: 0x00054340 File Offset: 0x00052540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureManualDataResponse Clone()
		{
			return new AdventureManualDataResponse(this);
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06001EE5 RID: 7909 RVA: 0x00054348 File Offset: 0x00052548
		// (set) Token: 0x06001EE6 RID: 7910 RVA: 0x00054350 File Offset: 0x00052550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06001EE7 RID: 7911 RVA: 0x00054359 File Offset: 0x00052559
		// (set) Token: 0x06001EE8 RID: 7912 RVA: 0x00054361 File Offset: 0x00052561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureManualData AdventureManualData
		{
			get
			{
				return this.adventureManualData_;
			}
			set
			{
				this.adventureManualData_ = value;
			}
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x0005436A File Offset: 0x0005256A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdventureManualDataResponse);
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x00054378 File Offset: 0x00052578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdventureManualDataResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this.AdventureManualData, other.AdventureManualData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x000543C8 File Offset: 0x000525C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.adventureManualData_ != null)
			{
				num ^= this.AdventureManualData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x00054423 File Offset: 0x00052623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x00054430 File Offset: 0x00052630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x0005443C File Offset: 0x0005263C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.adventureManualData_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.AdventureManualData);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001EEF RID: 7919 RVA: 0x00054498 File Offset: 0x00052698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.adventureManualData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AdventureManualData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001EF0 RID: 7920 RVA: 0x000544F0 File Offset: 0x000526F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdventureManualDataResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.adventureManualData_ != null)
			{
				if (this.adventureManualData_ == null)
				{
					this.AdventureManualData = new AdventureManualData();
				}
				this.AdventureManualData.MergeFrom(other.AdventureManualData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001EF1 RID: 7921 RVA: 0x00054558 File Offset: 0x00052758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001EF2 RID: 7922 RVA: 0x00054564 File Offset: 0x00052764
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
				if (num != 50U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Code = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.adventureManualData_ == null)
					{
						this.AdventureManualData = new AdventureManualData();
					}
					input.ReadMessage(this.AdventureManualData);
				}
			}
		}

		// Token: 0x040023D0 RID: 9168
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023D1 RID: 9169
		public const int CodeFieldNumber = 8;

		// Token: 0x040023D2 RID: 9170
		private ErrorCode code_;

		// Token: 0x040023D3 RID: 9171
		public const int AdventureManualDataFieldNumber = 6;

		// Token: 0x040023D4 RID: 9172
		private AdventureManualData adventureManualData_;
	}
}
