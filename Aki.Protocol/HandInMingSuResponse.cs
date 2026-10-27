using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200073B RID: 1851
	[NetMessage(EMessageId.HandInMingSuResponse)]
	public sealed class HandInMingSuResponse : IMessage<HandInMingSuResponse>, IMessage, IEquatable<HandInMingSuResponse>, IDeepCloneable<HandInMingSuResponse>, IBufferMessage
	{
		// Token: 0x0600A7C7 RID: 42951 RVA: 0x00193CAF File Offset: 0x00191EAF
		[NullableContext(1)]
		public static HandInMingSuResponse Create()
		{
			return new HandInMingSuResponse();
		}

		// Token: 0x170021BB RID: 8635
		// (get) Token: 0x0600A7C8 RID: 42952 RVA: 0x00193CB6 File Offset: 0x00191EB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021BC RID: 8636
		// (get) Token: 0x0600A7C9 RID: 42953 RVA: 0x00193CB9 File Offset: 0x00191EB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HandInMingSuResponse.Descriptor;
			}
		}

		// Token: 0x0600A7CA RID: 42954 RVA: 0x00193CC0 File Offset: 0x00191EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInMingSuResponse()
		{
		}

		// Token: 0x0600A7CB RID: 42955 RVA: 0x00193CC8 File Offset: 0x00191EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInMingSuResponse(HandInMingSuResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.dragonPoolId_ = other.dragonPoolId_;
			this.level_ = other.level_;
			this.injectedCoreItemCount_ = other.injectedCoreItemCount_;
			this.levelGains_ = other.levelGains_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A7CC RID: 42956 RVA: 0x00193D28 File Offset: 0x00191F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInMingSuResponse Clone()
		{
			return new HandInMingSuResponse(this);
		}

		// Token: 0x170021BD RID: 8637
		// (get) Token: 0x0600A7CD RID: 42957 RVA: 0x00193D30 File Offset: 0x00191F30
		// (set) Token: 0x0600A7CE RID: 42958 RVA: 0x00193D38 File Offset: 0x00191F38
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

		// Token: 0x170021BE RID: 8638
		// (get) Token: 0x0600A7CF RID: 42959 RVA: 0x00193D41 File Offset: 0x00191F41
		// (set) Token: 0x0600A7D0 RID: 42960 RVA: 0x00193D49 File Offset: 0x00191F49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DragonPoolId
		{
			get
			{
				return this.dragonPoolId_;
			}
			set
			{
				this.dragonPoolId_ = value;
			}
		}

		// Token: 0x170021BF RID: 8639
		// (get) Token: 0x0600A7D1 RID: 42961 RVA: 0x00193D52 File Offset: 0x00191F52
		// (set) Token: 0x0600A7D2 RID: 42962 RVA: 0x00193D5A File Offset: 0x00191F5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x170021C0 RID: 8640
		// (get) Token: 0x0600A7D3 RID: 42963 RVA: 0x00193D63 File Offset: 0x00191F63
		// (set) Token: 0x0600A7D4 RID: 42964 RVA: 0x00193D6B File Offset: 0x00191F6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InjectedCoreItemCount
		{
			get
			{
				return this.injectedCoreItemCount_;
			}
			set
			{
				this.injectedCoreItemCount_ = value;
			}
		}

		// Token: 0x170021C1 RID: 8641
		// (get) Token: 0x0600A7D5 RID: 42965 RVA: 0x00193D74 File Offset: 0x00191F74
		// (set) Token: 0x0600A7D6 RID: 42966 RVA: 0x00193D7C File Offset: 0x00191F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelGains
		{
			get
			{
				return this.levelGains_;
			}
			set
			{
				this.levelGains_ = value;
			}
		}

		// Token: 0x0600A7D7 RID: 42967 RVA: 0x00193D85 File Offset: 0x00191F85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HandInMingSuResponse);
		}

		// Token: 0x0600A7D8 RID: 42968 RVA: 0x00193D94 File Offset: 0x00191F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HandInMingSuResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.DragonPoolId == other.DragonPoolId && this.Level == other.Level && this.InjectedCoreItemCount == other.InjectedCoreItemCount && this.LevelGains == other.LevelGains && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A7D9 RID: 42969 RVA: 0x00193E10 File Offset: 0x00192010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.DragonPoolId != 0)
			{
				num ^= this.DragonPoolId.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.InjectedCoreItemCount != 0)
			{
				num ^= this.InjectedCoreItemCount.GetHashCode();
			}
			if (this.LevelGains != 0)
			{
				num ^= this.LevelGains.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A7DA RID: 42970 RVA: 0x00193EB9 File Offset: 0x001920B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A7DB RID: 42971 RVA: 0x00193EC6 File Offset: 0x001920C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A7DC RID: 42972 RVA: 0x00193ED0 File Offset: 0x001920D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelGains != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.LevelGains);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.DragonPoolId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.DragonPoolId);
			}
			if (this.InjectedCoreItemCount != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.InjectedCoreItemCount);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A7DD RID: 42973 RVA: 0x00193F80 File Offset: 0x00192180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.DragonPoolId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DragonPoolId);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.InjectedCoreItemCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InjectedCoreItemCount);
			}
			if (this.LevelGains != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelGains);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A7DE RID: 42974 RVA: 0x00194020 File Offset: 0x00192220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HandInMingSuResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.DragonPoolId != 0)
			{
				this.DragonPoolId = other.DragonPoolId;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.InjectedCoreItemCount != 0)
			{
				this.InjectedCoreItemCount = other.InjectedCoreItemCount;
			}
			if (other.LevelGains != 0)
			{
				this.LevelGains = other.LevelGains;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A7DF RID: 42975 RVA: 0x001940AC File Offset: 0x001922AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A7E0 RID: 42976 RVA: 0x001940B8 File Offset: 0x001922B8
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
				if (num <= 80U)
				{
					if (num == 40U)
					{
						this.LevelGains = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.DragonPoolId = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.InjectedCoreItemCount = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.Level = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004CA5 RID: 19621
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CA6 RID: 19622
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04004CA7 RID: 19623
		private ErrorCode errorCode_;

		// Token: 0x04004CA8 RID: 19624
		public const int DragonPoolIdFieldNumber = 13;

		// Token: 0x04004CA9 RID: 19625
		private int dragonPoolId_;

		// Token: 0x04004CAA RID: 19626
		public const int LevelFieldNumber = 15;

		// Token: 0x04004CAB RID: 19627
		private int level_;

		// Token: 0x04004CAC RID: 19628
		public const int InjectedCoreItemCountFieldNumber = 14;

		// Token: 0x04004CAD RID: 19629
		private int injectedCoreItemCount_;

		// Token: 0x04004CAE RID: 19630
		public const int LevelGainsFieldNumber = 5;

		// Token: 0x04004CAF RID: 19631
		private int levelGains_;
	}
}
