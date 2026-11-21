using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x02001726 RID: 5926
	public sealed class AiControlSwitch : IMessage<AiControlSwitch>, IMessage, IEquatable<AiControlSwitch>, IDeepCloneable<AiControlSwitch>, IBufferMessage
	{
		// Token: 0x0601DBF4 RID: 121844 RVA: 0x0045CFB9 File Offset: 0x0045B1B9
		[NullableContext(1)]
		public static AiControlSwitch Create()
		{
			return new AiControlSwitch();
		}

		// Token: 0x17006548 RID: 25928
		// (get) Token: 0x0601DBF5 RID: 121845 RVA: 0x0045CFC0 File Offset: 0x0045B1C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AiControlSwitch> Parser
		{
			get
			{
				return AiControlSwitch._parser;
			}
		}

		// Token: 0x17006549 RID: 25929
		// (get) Token: 0x0601DBF6 RID: 121846 RVA: 0x0045CFC7 File Offset: 0x0045B1C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700654A RID: 25930
		// (get) Token: 0x0601DBF7 RID: 121847 RVA: 0x0045CFCA File Offset: 0x0045B1CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiControlSwitch.Descriptor;
			}
		}

		// Token: 0x0601DBF8 RID: 121848 RVA: 0x0045CFD1 File Offset: 0x0045B1D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiControlSwitch()
		{
		}

		// Token: 0x0601DBF9 RID: 121849 RVA: 0x0045CFDC File Offset: 0x0045B1DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiControlSwitch(AiControlSwitch other) : this()
		{
			this.entityId_ = other.entityId_;
			this.aiInfo_ = ((other.aiInfo_ != null) ? other.aiInfo_.Clone() : null);
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DBFA RID: 121850 RVA: 0x0045D034 File Offset: 0x0045B234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiControlSwitch Clone()
		{
			return new AiControlSwitch(this);
		}

		// Token: 0x1700654B RID: 25931
		// (get) Token: 0x0601DBFB RID: 121851 RVA: 0x0045D03C File Offset: 0x0045B23C
		// (set) Token: 0x0601DBFC RID: 121852 RVA: 0x0045D044 File Offset: 0x0045B244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x1700654C RID: 25932
		// (get) Token: 0x0601DBFD RID: 121853 RVA: 0x0045D04D File Offset: 0x0045B24D
		// (set) Token: 0x0601DBFE RID: 121854 RVA: 0x0045D055 File Offset: 0x0045B255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformation AiInfo
		{
			get
			{
				return this.aiInfo_;
			}
			set
			{
				this.aiInfo_ = value;
			}
		}

		// Token: 0x1700654D RID: 25933
		// (get) Token: 0x0601DBFF RID: 121855 RVA: 0x0045D05E File Offset: 0x0045B25E
		// (set) Token: 0x0601DC00 RID: 121856 RVA: 0x0045D066 File Offset: 0x0045B266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x0601DC01 RID: 121857 RVA: 0x0045D06F File Offset: 0x0045B26F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiControlSwitch);
		}

		// Token: 0x0601DC02 RID: 121858 RVA: 0x0045D080 File Offset: 0x0045B280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiControlSwitch other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.AiInfo, other.AiInfo) && this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DC03 RID: 121859 RVA: 0x0045D0E0 File Offset: 0x0045B2E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.aiInfo_ != null)
			{
				num ^= this.AiInfo.GetHashCode();
			}
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601DC04 RID: 121860 RVA: 0x0045D14E File Offset: 0x0045B34E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DC05 RID: 121861 RVA: 0x0045D15B File Offset: 0x0045B35B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DC06 RID: 121862 RVA: 0x0045D164 File Offset: 0x0045B364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.aiInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.AiInfo);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601DC07 RID: 121863 RVA: 0x0045D1D8 File Offset: 0x0045B3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.aiInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AiInfo);
			}
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601DC08 RID: 121864 RVA: 0x0045D248 File Offset: 0x0045B448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiControlSwitch other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.aiInfo_ != null)
			{
				if (this.aiInfo_ == null)
				{
					this.AiInfo = new AiInformation();
				}
				this.AiInfo.MergeFrom(other.AiInfo);
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601DC09 RID: 121865 RVA: 0x0045D2C4 File Offset: 0x0045B4C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DC0A RID: 121866 RVA: 0x0045D2D0 File Offset: 0x0045B4D0
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.PlayerId = input.ReadInt32();
						}
					}
					else
					{
						if (this.aiInfo_ == null)
						{
							this.AiInfo = new AiInformation();
						}
						input.ReadMessage(this.AiInfo);
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400C957 RID: 51543
		private static readonly MessageParser<AiControlSwitch> _parser = new MessageParser<AiControlSwitch>(() => new AiControlSwitch());

		// Token: 0x0400C958 RID: 51544
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C959 RID: 51545
		public const int EntityIdFieldNumber = 1;

		// Token: 0x0400C95A RID: 51546
		private long entityId_;

		// Token: 0x0400C95B RID: 51547
		public const int AiInfoFieldNumber = 2;

		// Token: 0x0400C95C RID: 51548
		private AiInformation aiInfo_;

		// Token: 0x0400C95D RID: 51549
		public const int PlayerIdFieldNumber = 3;

		// Token: 0x0400C95E RID: 51550
		private int playerId_;
	}
}
