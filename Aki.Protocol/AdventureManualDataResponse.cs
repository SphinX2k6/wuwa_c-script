using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000BE RID: 190
	[NetMessage(EMessageId.AdventureManualDataResponse)]
	public sealed class AdventureManualDataResponse : IMessage<AdventureManualDataResponse>, IMessage, IEquatable<AdventureManualDataResponse>, IDeepCloneable<AdventureManualDataResponse>, IBufferMessage
	{
		// Token: 0x06001E96 RID: 7830 RVA: 0x00053625 File Offset: 0x00051825
		[NullableContext(1)]
		public static AdventureManualDataResponse Create()
		{
			return new AdventureManualDataResponse();
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06001E97 RID: 7831 RVA: 0x0005362C File Offset: 0x0005182C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06001E98 RID: 7832 RVA: 0x0005362F File Offset: 0x0005182F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdventureManualDataResponse.Descriptor;
			}
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x00053636 File Offset: 0x00051836
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureManualDataResponse()
		{
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x00053640 File Offset: 0x00051840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureManualDataResponse(AdventureManualDataResponse other) : this()
		{
			this.code_ = other.code_;
			this.adventureManualData_ = ((other.adventureManualData_ != null) ? other.adventureManualData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001E9B RID: 7835 RVA: 0x0005368C File Offset: 0x0005188C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureManualDataResponse Clone()
		{
			return new AdventureManualDataResponse(this);
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06001E9C RID: 7836 RVA: 0x00053694 File Offset: 0x00051894
		// (set) Token: 0x06001E9D RID: 7837 RVA: 0x0005369C File Offset: 0x0005189C
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

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06001E9E RID: 7838 RVA: 0x000536A5 File Offset: 0x000518A5
		// (set) Token: 0x06001E9F RID: 7839 RVA: 0x000536AD File Offset: 0x000518AD
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

		// Token: 0x06001EA0 RID: 7840 RVA: 0x000536B6 File Offset: 0x000518B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdventureManualDataResponse);
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x000536C4 File Offset: 0x000518C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdventureManualDataResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this.AdventureManualData, other.AdventureManualData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x00053714 File Offset: 0x00051914
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

		// Token: 0x06001EA3 RID: 7843 RVA: 0x0005376F File Offset: 0x0005196F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x0005377C File Offset: 0x0005197C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x00053788 File Offset: 0x00051988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.adventureManualData_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AdventureManualData);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001EA6 RID: 7846 RVA: 0x000537E4 File Offset: 0x000519E4
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

		// Token: 0x06001EA7 RID: 7847 RVA: 0x0005383C File Offset: 0x00051A3C
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

		// Token: 0x06001EA8 RID: 7848 RVA: 0x000538A4 File Offset: 0x00051AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x000538B0 File Offset: 0x00051AB0
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
				if (num != 10U)
				{
					if (num != 56U)
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

		// Token: 0x0400236D RID: 9069
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400236E RID: 9070
		public const int CodeFieldNumber = 7;

		// Token: 0x0400236F RID: 9071
		private ErrorCode code_;

		// Token: 0x04002370 RID: 9072
		public const int AdventureManualDataFieldNumber = 1;

		// Token: 0x04002371 RID: 9073
		private AdventureManualData adventureManualData_;
	}
}
