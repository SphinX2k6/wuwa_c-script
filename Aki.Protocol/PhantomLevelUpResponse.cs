using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CD4 RID: 3284
	[NetMessage(EMessageId.PhantomLevelUpResponse)]
	public sealed class PhantomLevelUpResponse : IMessage<PhantomLevelUpResponse>, IMessage, IEquatable<PhantomLevelUpResponse>, IDeepCloneable<PhantomLevelUpResponse>, IBufferMessage
	{
		// Token: 0x06011CB1 RID: 72881 RVA: 0x0029B023 File Offset: 0x00299223
		[NullableContext(1)]
		public static PhantomLevelUpResponse Create()
		{
			return new PhantomLevelUpResponse();
		}

		// Token: 0x17003AF8 RID: 15096
		// (get) Token: 0x06011CB2 RID: 72882 RVA: 0x0029B02A File Offset: 0x0029922A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AF9 RID: 15097
		// (get) Token: 0x06011CB3 RID: 72883 RVA: 0x0029B02D File Offset: 0x0029922D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomLevelUpResponse.Descriptor;
			}
		}

		// Token: 0x06011CB4 RID: 72884 RVA: 0x0029B034 File Offset: 0x00299234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomLevelUpResponse()
		{
		}

		// Token: 0x06011CB5 RID: 72885 RVA: 0x0029B048 File Offset: 0x00299248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomLevelUpResponse(PhantomLevelUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.updateInfo_ = ((other.updateInfo_ != null) ? other.updateInfo_.Clone() : null);
			this.itemMap_ = other.itemMap_.Clone();
			this.stackSplitInfo_ = ((other.stackSplitInfo_ != null) ? other.stackSplitInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011CB6 RID: 72886 RVA: 0x0029B0C1 File Offset: 0x002992C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomLevelUpResponse Clone()
		{
			return new PhantomLevelUpResponse(this);
		}

		// Token: 0x17003AFA RID: 15098
		// (get) Token: 0x06011CB7 RID: 72887 RVA: 0x0029B0C9 File Offset: 0x002992C9
		// (set) Token: 0x06011CB8 RID: 72888 RVA: 0x0029B0D1 File Offset: 0x002992D1
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

		// Token: 0x17003AFB RID: 15099
		// (get) Token: 0x06011CB9 RID: 72889 RVA: 0x0029B0DA File Offset: 0x002992DA
		// (set) Token: 0x06011CBA RID: 72890 RVA: 0x0029B0E2 File Offset: 0x002992E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItem UpdateInfo
		{
			get
			{
				return this.updateInfo_;
			}
			set
			{
				this.updateInfo_ = value;
			}
		}

		// Token: 0x17003AFC RID: 15100
		// (get) Token: 0x06011CBB RID: 72891 RVA: 0x0029B0EB File Offset: 0x002992EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemMap
		{
			get
			{
				return this.itemMap_;
			}
		}

		// Token: 0x17003AFD RID: 15101
		// (get) Token: 0x06011CBC RID: 72892 RVA: 0x0029B0F3 File Offset: 0x002992F3
		// (set) Token: 0x06011CBD RID: 72893 RVA: 0x0029B0FB File Offset: 0x002992FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomStackSplitInfo StackSplitInfo
		{
			get
			{
				return this.stackSplitInfo_;
			}
			set
			{
				this.stackSplitInfo_ = value;
			}
		}

		// Token: 0x06011CBE RID: 72894 RVA: 0x0029B104 File Offset: 0x00299304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomLevelUpResponse);
		}

		// Token: 0x06011CBF RID: 72895 RVA: 0x0029B114 File Offset: 0x00299314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomLevelUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.UpdateInfo, other.UpdateInfo) && this.ItemMap.Equals(other.ItemMap) && object.Equals(this.StackSplitInfo, other.StackSplitInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011CC0 RID: 72896 RVA: 0x0029B18C File Offset: 0x0029938C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.updateInfo_ != null)
			{
				num ^= this.UpdateInfo.GetHashCode();
			}
			num ^= this.ItemMap.GetHashCode();
			if (this.stackSplitInfo_ != null)
			{
				num ^= this.StackSplitInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011CC1 RID: 72897 RVA: 0x0029B20B File Offset: 0x0029940B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011CC2 RID: 72898 RVA: 0x0029B218 File Offset: 0x00299418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011CC3 RID: 72899 RVA: 0x0029B224 File Offset: 0x00299424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.itemMap_.WriteTo(ref output, PhantomLevelUpResponse._map_itemMap_codec);
			if (this.updateInfo_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.UpdateInfo);
			}
			if (this.stackSplitInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.StackSplitInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011CC4 RID: 72900 RVA: 0x0029B2AC File Offset: 0x002994AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.updateInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UpdateInfo);
			}
			num += this.itemMap_.CalculateSize(PhantomLevelUpResponse._map_itemMap_codec);
			if (this.stackSplitInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StackSplitInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011CC5 RID: 72901 RVA: 0x0029B330 File Offset: 0x00299530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomLevelUpResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.updateInfo_ != null)
			{
				if (this.updateInfo_ == null)
				{
					this.UpdateInfo = new PhantomItem();
				}
				this.UpdateInfo.MergeFrom(other.UpdateInfo);
			}
			this.itemMap_.MergeFrom(other.itemMap_);
			if (other.stackSplitInfo_ != null)
			{
				if (this.stackSplitInfo_ == null)
				{
					this.StackSplitInfo = new PhantomStackSplitInfo();
				}
				this.StackSplitInfo.MergeFrom(other.StackSplitInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011CC6 RID: 72902 RVA: 0x0029B3D5 File Offset: 0x002995D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011CC7 RID: 72903 RVA: 0x0029B3E0 File Offset: 0x002995E0
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
				if (num <= 66U)
				{
					if (num == 16U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 66U)
					{
						this.itemMap_.AddEntriesFrom(ref input, PhantomLevelUpResponse._map_itemMap_codec);
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						if (this.updateInfo_ == null)
						{
							this.UpdateInfo = new PhantomItem();
						}
						input.ReadMessage(this.UpdateInfo);
						continue;
					}
					if (num == 122U)
					{
						if (this.stackSplitInfo_ == null)
						{
							this.StackSplitInfo = new PhantomStackSplitInfo();
						}
						input.ReadMessage(this.StackSplitInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007034 RID: 28724
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007035 RID: 28725
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04007036 RID: 28726
		private ErrorCode errorCode_;

		// Token: 0x04007037 RID: 28727
		public const int UpdateInfoFieldNumber = 9;

		// Token: 0x04007038 RID: 28728
		private PhantomItem updateInfo_;

		// Token: 0x04007039 RID: 28729
		public const int ItemMapFieldNumber = 8;

		// Token: 0x0400703A RID: 28730
		private static readonly MapField<int, int>.Codec _map_itemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 66U);

		// Token: 0x0400703B RID: 28731
		private readonly MapField<int, int> itemMap_ = new MapField<int, int>();

		// Token: 0x0400703C RID: 28732
		public const int StackSplitInfoFieldNumber = 15;

		// Token: 0x0400703D RID: 28733
		private PhantomStackSplitInfo stackSplitInfo_;
	}
}
