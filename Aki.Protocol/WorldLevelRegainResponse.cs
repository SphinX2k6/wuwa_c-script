using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001593 RID: 5523
	[NetMessage(EMessageId.WorldLevelRegainResponse)]
	public sealed class WorldLevelRegainResponse : IMessage<WorldLevelRegainResponse>, IMessage, IEquatable<WorldLevelRegainResponse>, IDeepCloneable<WorldLevelRegainResponse>, IBufferMessage
	{
		// Token: 0x0601D3B2 RID: 119730 RVA: 0x0043B1B6 File Offset: 0x004393B6
		[NullableContext(1)]
		public static WorldLevelRegainResponse Create()
		{
			return new WorldLevelRegainResponse();
		}

		// Token: 0x170062DF RID: 25311
		// (get) Token: 0x0601D3B3 RID: 119731 RVA: 0x0043B1BD File Offset: 0x004393BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062E0 RID: 25312
		// (get) Token: 0x0601D3B4 RID: 119732 RVA: 0x0043B1C0 File Offset: 0x004393C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorldLevelRegainResponse.Descriptor;
			}
		}

		// Token: 0x0601D3B5 RID: 119733 RVA: 0x0043B1C7 File Offset: 0x004393C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldLevelRegainResponse()
		{
		}

		// Token: 0x0601D3B6 RID: 119734 RVA: 0x0043B1D0 File Offset: 0x004393D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldLevelRegainResponse(WorldLevelRegainResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.originWorldLevel_ = other.originWorldLevel_;
			this.curWorldLevel_ = other.curWorldLevel_;
			this.worldLevelTimeStamp_ = other.worldLevelTimeStamp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D3B7 RID: 119735 RVA: 0x0043B224 File Offset: 0x00439424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldLevelRegainResponse Clone()
		{
			return new WorldLevelRegainResponse(this);
		}

		// Token: 0x170062E1 RID: 25313
		// (get) Token: 0x0601D3B8 RID: 119736 RVA: 0x0043B22C File Offset: 0x0043942C
		// (set) Token: 0x0601D3B9 RID: 119737 RVA: 0x0043B234 File Offset: 0x00439434
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

		// Token: 0x170062E2 RID: 25314
		// (get) Token: 0x0601D3BA RID: 119738 RVA: 0x0043B23D File Offset: 0x0043943D
		// (set) Token: 0x0601D3BB RID: 119739 RVA: 0x0043B245 File Offset: 0x00439445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OriginWorldLevel
		{
			get
			{
				return this.originWorldLevel_;
			}
			set
			{
				this.originWorldLevel_ = value;
			}
		}

		// Token: 0x170062E3 RID: 25315
		// (get) Token: 0x0601D3BC RID: 119740 RVA: 0x0043B24E File Offset: 0x0043944E
		// (set) Token: 0x0601D3BD RID: 119741 RVA: 0x0043B256 File Offset: 0x00439456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurWorldLevel
		{
			get
			{
				return this.curWorldLevel_;
			}
			set
			{
				this.curWorldLevel_ = value;
			}
		}

		// Token: 0x170062E4 RID: 25316
		// (get) Token: 0x0601D3BE RID: 119742 RVA: 0x0043B25F File Offset: 0x0043945F
		// (set) Token: 0x0601D3BF RID: 119743 RVA: 0x0043B267 File Offset: 0x00439467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WorldLevelTimeStamp
		{
			get
			{
				return this.worldLevelTimeStamp_;
			}
			set
			{
				this.worldLevelTimeStamp_ = value;
			}
		}

		// Token: 0x0601D3C0 RID: 119744 RVA: 0x0043B270 File Offset: 0x00439470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorldLevelRegainResponse);
		}

		// Token: 0x0601D3C1 RID: 119745 RVA: 0x0043B280 File Offset: 0x00439480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorldLevelRegainResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.OriginWorldLevel == other.OriginWorldLevel && this.CurWorldLevel == other.CurWorldLevel && this.WorldLevelTimeStamp == other.WorldLevelTimeStamp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D3C2 RID: 119746 RVA: 0x0043B2EC File Offset: 0x004394EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.OriginWorldLevel != 0)
			{
				num ^= this.OriginWorldLevel.GetHashCode();
			}
			if (this.CurWorldLevel != 0)
			{
				num ^= this.CurWorldLevel.GetHashCode();
			}
			if (this.WorldLevelTimeStamp != 0)
			{
				num ^= this.WorldLevelTimeStamp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D3C3 RID: 119747 RVA: 0x0043B37C File Offset: 0x0043957C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D3C4 RID: 119748 RVA: 0x0043B389 File Offset: 0x00439589
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D3C5 RID: 119749 RVA: 0x0043B394 File Offset: 0x00439594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WorldLevelTimeStamp != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.WorldLevelTimeStamp);
			}
			if (this.OriginWorldLevel != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.OriginWorldLevel);
			}
			if (this.CurWorldLevel != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.CurWorldLevel);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D3C6 RID: 119750 RVA: 0x0043B424 File Offset: 0x00439624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.OriginWorldLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OriginWorldLevel);
			}
			if (this.CurWorldLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurWorldLevel);
			}
			if (this.WorldLevelTimeStamp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WorldLevelTimeStamp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D3C7 RID: 119751 RVA: 0x0043B4AC File Offset: 0x004396AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WorldLevelRegainResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.OriginWorldLevel != 0)
			{
				this.OriginWorldLevel = other.OriginWorldLevel;
			}
			if (other.CurWorldLevel != 0)
			{
				this.CurWorldLevel = other.CurWorldLevel;
			}
			if (other.WorldLevelTimeStamp != 0)
			{
				this.WorldLevelTimeStamp = other.WorldLevelTimeStamp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D3C8 RID: 119752 RVA: 0x0043B524 File Offset: 0x00439724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D3C9 RID: 119753 RVA: 0x0043B530 File Offset: 0x00439730
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
				if (num <= 32U)
				{
					if (num == 8U)
					{
						this.WorldLevelTimeStamp = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.OriginWorldLevel = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.CurWorldLevel = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A7A1 RID: 42913
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A7A2 RID: 42914
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x0400A7A3 RID: 42915
		private ErrorCode errorCode_;

		// Token: 0x0400A7A4 RID: 42916
		public const int OriginWorldLevelFieldNumber = 4;

		// Token: 0x0400A7A5 RID: 42917
		private int originWorldLevel_;

		// Token: 0x0400A7A6 RID: 42918
		public const int CurWorldLevelFieldNumber = 8;

		// Token: 0x0400A7A7 RID: 42919
		private int curWorldLevel_;

		// Token: 0x0400A7A8 RID: 42920
		public const int WorldLevelTimeStampFieldNumber = 1;

		// Token: 0x0400A7A9 RID: 42921
		private int worldLevelTimeStamp_;
	}
}
