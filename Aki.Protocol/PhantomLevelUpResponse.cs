using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CE4 RID: 3300
	[NetMessage(EMessageId.PhantomLevelUpResponse)]
	public sealed class PhantomLevelUpResponse : IMessage<PhantomLevelUpResponse>, IMessage, IEquatable<PhantomLevelUpResponse>, IDeepCloneable<PhantomLevelUpResponse>, IBufferMessage
	{
		// Token: 0x06011DAD RID: 73133 RVA: 0x0029CC37 File Offset: 0x0029AE37
		[NullableContext(1)]
		public static PhantomLevelUpResponse Create()
		{
			return new PhantomLevelUpResponse();
		}

		// Token: 0x17003B2D RID: 15149
		// (get) Token: 0x06011DAE RID: 73134 RVA: 0x0029CC3E File Offset: 0x0029AE3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B2E RID: 15150
		// (get) Token: 0x06011DAF RID: 73135 RVA: 0x0029CC41 File Offset: 0x0029AE41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomLevelUpResponse.Descriptor;
			}
		}

		// Token: 0x06011DB0 RID: 73136 RVA: 0x0029CC48 File Offset: 0x0029AE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomLevelUpResponse()
		{
		}

		// Token: 0x06011DB1 RID: 73137 RVA: 0x0029CC5C File Offset: 0x0029AE5C
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

		// Token: 0x06011DB2 RID: 73138 RVA: 0x0029CCD5 File Offset: 0x0029AED5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomLevelUpResponse Clone()
		{
			return new PhantomLevelUpResponse(this);
		}

		// Token: 0x17003B2F RID: 15151
		// (get) Token: 0x06011DB3 RID: 73139 RVA: 0x0029CCDD File Offset: 0x0029AEDD
		// (set) Token: 0x06011DB4 RID: 73140 RVA: 0x0029CCE5 File Offset: 0x0029AEE5
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

		// Token: 0x17003B30 RID: 15152
		// (get) Token: 0x06011DB5 RID: 73141 RVA: 0x0029CCEE File Offset: 0x0029AEEE
		// (set) Token: 0x06011DB6 RID: 73142 RVA: 0x0029CCF6 File Offset: 0x0029AEF6
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

		// Token: 0x17003B31 RID: 15153
		// (get) Token: 0x06011DB7 RID: 73143 RVA: 0x0029CCFF File Offset: 0x0029AEFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemMap
		{
			get
			{
				return this.itemMap_;
			}
		}

		// Token: 0x17003B32 RID: 15154
		// (get) Token: 0x06011DB8 RID: 73144 RVA: 0x0029CD07 File Offset: 0x0029AF07
		// (set) Token: 0x06011DB9 RID: 73145 RVA: 0x0029CD0F File Offset: 0x0029AF0F
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

		// Token: 0x06011DBA RID: 73146 RVA: 0x0029CD18 File Offset: 0x0029AF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomLevelUpResponse);
		}

		// Token: 0x06011DBB RID: 73147 RVA: 0x0029CD28 File Offset: 0x0029AF28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomLevelUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.UpdateInfo, other.UpdateInfo) && this.ItemMap.Equals(other.ItemMap) && object.Equals(this.StackSplitInfo, other.StackSplitInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011DBC RID: 73148 RVA: 0x0029CDA0 File Offset: 0x0029AFA0
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

		// Token: 0x06011DBD RID: 73149 RVA: 0x0029CE1F File Offset: 0x0029B01F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011DBE RID: 73150 RVA: 0x0029CE2C File Offset: 0x0029B02C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011DBF RID: 73151 RVA: 0x0029CE38 File Offset: 0x0029B038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemMap_.WriteTo(ref output, PhantomLevelUpResponse._map_itemMap_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.stackSplitInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.StackSplitInfo);
			}
			if (this.updateInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.UpdateInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011DC0 RID: 73152 RVA: 0x0029CEC0 File Offset: 0x0029B0C0
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

		// Token: 0x06011DC1 RID: 73153 RVA: 0x0029CF44 File Offset: 0x0029B144
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

		// Token: 0x06011DC2 RID: 73154 RVA: 0x0029CFE9 File Offset: 0x0029B1E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011DC3 RID: 73155 RVA: 0x0029CFF4 File Offset: 0x0029B1F4
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
				if (num <= 88U)
				{
					if (num == 34U)
					{
						this.itemMap_.AddEntriesFrom(ref input, PhantomLevelUpResponse._map_itemMap_codec);
						continue;
					}
					if (num == 88U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 106U)
					{
						if (this.stackSplitInfo_ == null)
						{
							this.StackSplitInfo = new PhantomStackSplitInfo();
						}
						input.ReadMessage(this.StackSplitInfo);
						continue;
					}
					if (num == 114U)
					{
						if (this.updateInfo_ == null)
						{
							this.UpdateInfo = new PhantomItem();
						}
						input.ReadMessage(this.UpdateInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400701C RID: 28700
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400701D RID: 28701
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x0400701E RID: 28702
		private ErrorCode errorCode_;

		// Token: 0x0400701F RID: 28703
		public const int UpdateInfoFieldNumber = 14;

		// Token: 0x04007020 RID: 28704
		private PhantomItem updateInfo_;

		// Token: 0x04007021 RID: 28705
		public const int ItemMapFieldNumber = 4;

		// Token: 0x04007022 RID: 28706
		private static readonly MapField<int, int>.Codec _map_itemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 34U);

		// Token: 0x04007023 RID: 28707
		private readonly MapField<int, int> itemMap_ = new MapField<int, int>();

		// Token: 0x04007024 RID: 28708
		public const int StackSplitInfoFieldNumber = 13;

		// Token: 0x04007025 RID: 28709
		private PhantomStackSplitInfo stackSplitInfo_;
	}
}
