using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002A7 RID: 679
	public sealed class ClientStorageInfo : IMessage<ClientStorageInfo>, IMessage, IEquatable<ClientStorageInfo>, IDeepCloneable<ClientStorageInfo>, IBufferMessage
	{
		// Token: 0x060046C0 RID: 18112 RVA: 0x000AE124 File Offset: 0x000AC324
		[NullableContext(1)]
		public static ClientStorageInfo Create()
		{
			return new ClientStorageInfo();
		}

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x060046C1 RID: 18113 RVA: 0x000AE12B File Offset: 0x000AC32B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ClientStorageInfo> Parser
		{
			get
			{
				return ClientStorageInfo._parser;
			}
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x060046C2 RID: 18114 RVA: 0x000AE132 File Offset: 0x000AC332
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x060046C3 RID: 18115 RVA: 0x000AE135 File Offset: 0x000AC335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientStorageInfo.Descriptor;
			}
		}

		// Token: 0x060046C4 RID: 18116 RVA: 0x000AE13C File Offset: 0x000AC33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageInfo()
		{
		}

		// Token: 0x060046C5 RID: 18117 RVA: 0x000AE144 File Offset: 0x000AC344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageInfo(ClientStorageInfo other) : this()
		{
			this.systemId_ = other.systemId_;
			switch (other.DataCase)
			{
			case ClientStorageInfo.DataOneofCase.MapMapData:
				this.MapMapData = other.MapMapData.Clone();
				break;
			case ClientStorageInfo.DataOneofCase.MapListData:
				this.MapListData = other.MapListData.Clone();
				break;
			case ClientStorageInfo.DataOneofCase.MapData:
				this.MapData = other.MapData.Clone();
				break;
			case ClientStorageInfo.DataOneofCase.ListData:
				this.ListData = other.ListData.Clone();
				break;
			case ClientStorageInfo.DataOneofCase.SetData:
				this.SetData = other.SetData.Clone();
				break;
			case ClientStorageInfo.DataOneofCase.BoolData:
				this.BoolData = other.BoolData.Clone();
				break;
			case ClientStorageInfo.DataOneofCase.IntData:
				this.IntData = other.IntData.Clone();
				break;
			case ClientStorageInfo.DataOneofCase.LongData:
				this.LongData = other.LongData.Clone();
				break;
			case ClientStorageInfo.DataOneofCase.StringData:
				this.StringData = other.StringData.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060046C6 RID: 18118 RVA: 0x000AE25B File Offset: 0x000AC45B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageInfo Clone()
		{
			return new ClientStorageInfo(this);
		}

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x060046C7 RID: 18119 RVA: 0x000AE263 File Offset: 0x000AC463
		// (set) Token: 0x060046C8 RID: 18120 RVA: 0x000AE26B File Offset: 0x000AC46B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SystemId
		{
			get
			{
				return this.systemId_;
			}
			set
			{
				this.systemId_ = value;
			}
		}

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x060046C9 RID: 18121 RVA: 0x000AE274 File Offset: 0x000AC474
		// (set) Token: 0x060046CA RID: 18122 RVA: 0x000AE28C File Offset: 0x000AC48C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageMapMapData MapMapData
		{
			get
			{
				if (this.dataCase_ != ClientStorageInfo.DataOneofCase.MapMapData)
				{
					return null;
				}
				return (ClientStorageMapMapData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ClientStorageInfo.DataOneofCase.None : ClientStorageInfo.DataOneofCase.MapMapData);
			}
		}

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x060046CB RID: 18123 RVA: 0x000AE2A2 File Offset: 0x000AC4A2
		// (set) Token: 0x060046CC RID: 18124 RVA: 0x000AE2BA File Offset: 0x000AC4BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageMapListData MapListData
		{
			get
			{
				if (this.dataCase_ != ClientStorageInfo.DataOneofCase.MapListData)
				{
					return null;
				}
				return (ClientStorageMapListData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ClientStorageInfo.DataOneofCase.None : ClientStorageInfo.DataOneofCase.MapListData);
			}
		}

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x060046CD RID: 18125 RVA: 0x000AE2D0 File Offset: 0x000AC4D0
		// (set) Token: 0x060046CE RID: 18126 RVA: 0x000AE2E8 File Offset: 0x000AC4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageMapData MapData
		{
			get
			{
				if (this.dataCase_ != ClientStorageInfo.DataOneofCase.MapData)
				{
					return null;
				}
				return (ClientStorageMapData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ClientStorageInfo.DataOneofCase.None : ClientStorageInfo.DataOneofCase.MapData);
			}
		}

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x060046CF RID: 18127 RVA: 0x000AE2FE File Offset: 0x000AC4FE
		// (set) Token: 0x060046D0 RID: 18128 RVA: 0x000AE316 File Offset: 0x000AC516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageListData ListData
		{
			get
			{
				if (this.dataCase_ != ClientStorageInfo.DataOneofCase.ListData)
				{
					return null;
				}
				return (ClientStorageListData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ClientStorageInfo.DataOneofCase.None : ClientStorageInfo.DataOneofCase.ListData);
			}
		}

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x060046D1 RID: 18129 RVA: 0x000AE32C File Offset: 0x000AC52C
		// (set) Token: 0x060046D2 RID: 18130 RVA: 0x000AE344 File Offset: 0x000AC544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageSetData SetData
		{
			get
			{
				if (this.dataCase_ != ClientStorageInfo.DataOneofCase.SetData)
				{
					return null;
				}
				return (ClientStorageSetData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ClientStorageInfo.DataOneofCase.None : ClientStorageInfo.DataOneofCase.SetData);
			}
		}

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x060046D3 RID: 18131 RVA: 0x000AE35A File Offset: 0x000AC55A
		// (set) Token: 0x060046D4 RID: 18132 RVA: 0x000AE372 File Offset: 0x000AC572
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageBoolData BoolData
		{
			get
			{
				if (this.dataCase_ != ClientStorageInfo.DataOneofCase.BoolData)
				{
					return null;
				}
				return (ClientStorageBoolData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ClientStorageInfo.DataOneofCase.None : ClientStorageInfo.DataOneofCase.BoolData);
			}
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x060046D5 RID: 18133 RVA: 0x000AE388 File Offset: 0x000AC588
		// (set) Token: 0x060046D6 RID: 18134 RVA: 0x000AE3A1 File Offset: 0x000AC5A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageIntData IntData
		{
			get
			{
				if (this.dataCase_ != ClientStorageInfo.DataOneofCase.IntData)
				{
					return null;
				}
				return (ClientStorageIntData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ClientStorageInfo.DataOneofCase.None : ClientStorageInfo.DataOneofCase.IntData);
			}
		}

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x060046D7 RID: 18135 RVA: 0x000AE3B8 File Offset: 0x000AC5B8
		// (set) Token: 0x060046D8 RID: 18136 RVA: 0x000AE3D1 File Offset: 0x000AC5D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageLongData LongData
		{
			get
			{
				if (this.dataCase_ != ClientStorageInfo.DataOneofCase.LongData)
				{
					return null;
				}
				return (ClientStorageLongData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ClientStorageInfo.DataOneofCase.None : ClientStorageInfo.DataOneofCase.LongData);
			}
		}

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x060046D9 RID: 18137 RVA: 0x000AE3E8 File Offset: 0x000AC5E8
		// (set) Token: 0x060046DA RID: 18138 RVA: 0x000AE401 File Offset: 0x000AC601
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageStringData StringData
		{
			get
			{
				if (this.dataCase_ != ClientStorageInfo.DataOneofCase.StringData)
				{
					return null;
				}
				return (ClientStorageStringData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ClientStorageInfo.DataOneofCase.None : ClientStorageInfo.DataOneofCase.StringData);
			}
		}

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x060046DB RID: 18139 RVA: 0x000AE418 File Offset: 0x000AC618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageInfo.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x060046DC RID: 18140 RVA: 0x000AE420 File Offset: 0x000AC620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = ClientStorageInfo.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x060046DD RID: 18141 RVA: 0x000AE430 File Offset: 0x000AC630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientStorageInfo);
		}

		// Token: 0x060046DE RID: 18142 RVA: 0x000AE440 File Offset: 0x000AC640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientStorageInfo other)
		{
			return other != null && (other == this || (this.SystemId == other.SystemId && object.Equals(this.MapMapData, other.MapMapData) && object.Equals(this.MapListData, other.MapListData) && object.Equals(this.MapData, other.MapData) && object.Equals(this.ListData, other.ListData) && object.Equals(this.SetData, other.SetData) && object.Equals(this.BoolData, other.BoolData) && object.Equals(this.IntData, other.IntData) && object.Equals(this.LongData, other.LongData) && object.Equals(this.StringData, other.StringData) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060046DF RID: 18143 RVA: 0x000AE548 File Offset: 0x000AC748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SystemId != 0)
			{
				num ^= this.SystemId.GetHashCode();
			}
			if (this.dataCase_ == ClientStorageInfo.DataOneofCase.MapMapData)
			{
				num ^= this.MapMapData.GetHashCode();
			}
			if (this.dataCase_ == ClientStorageInfo.DataOneofCase.MapListData)
			{
				num ^= this.MapListData.GetHashCode();
			}
			if (this.dataCase_ == ClientStorageInfo.DataOneofCase.MapData)
			{
				num ^= this.MapData.GetHashCode();
			}
			if (this.dataCase_ == ClientStorageInfo.DataOneofCase.ListData)
			{
				num ^= this.ListData.GetHashCode();
			}
			if (this.dataCase_ == ClientStorageInfo.DataOneofCase.SetData)
			{
				num ^= this.SetData.GetHashCode();
			}
			if (this.dataCase_ == ClientStorageInfo.DataOneofCase.BoolData)
			{
				num ^= this.BoolData.GetHashCode();
			}
			if (this.dataCase_ == ClientStorageInfo.DataOneofCase.IntData)
			{
				num ^= this.IntData.GetHashCode();
			}
			if (this.dataCase_ == ClientStorageInfo.DataOneofCase.LongData)
			{
				num ^= this.LongData.GetHashCode();
			}
			if (this.dataCase_ == ClientStorageInfo.DataOneofCase.StringData)
			{
				num ^= this.StringData.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060046E0 RID: 18144 RVA: 0x000AE662 File Offset: 0x000AC862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060046E1 RID: 18145 RVA: 0x000AE66F File Offset: 0x000AC86F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060046E2 RID: 18146 RVA: 0x000AE678 File Offset: 0x000AC878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SystemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SystemId);
			}
			if (this.dataCase_ == ClientStorageInfo.DataOneofCase.MapMapData)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.MapMapData);
			}
			if (this.dataCase_ == ClientStorageInfo.DataOneofCase.MapListData)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.MapListData);
			}
			if (this.dataCase_ == ClientStorageInfo.DataOneofCase.MapData)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.MapData);
			}
			if (this.dataCase_ == ClientStorageInfo.DataOneofCase.ListData)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.ListData);
			}
			if (this.dataCase_ == ClientStorageInfo.DataOneofCase.SetData)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.SetData);
			}
			if (this.dataCase_ == ClientStorageInfo.DataOneofCase.BoolData)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.BoolData);
			}
			if (this.dataCase_ == ClientStorageInfo.DataOneofCase.IntData)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.IntData);
			}
			if (this.dataCase_ == ClientStorageInfo.DataOneofCase.LongData)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.LongData);
			}
			if (this.dataCase_ == ClientStorageInfo.DataOneofCase.StringData)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.StringData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060046E3 RID: 18147 RVA: 0x000AE7BC File Offset: 0x000AC9BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SystemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SystemId);
			}
			if (this.dataCase_ == ClientStorageInfo.DataOneofCase.MapMapData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MapMapData);
			}
			if (this.dataCase_ == ClientStorageInfo.DataOneofCase.MapListData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MapListData);
			}
			if (this.dataCase_ == ClientStorageInfo.DataOneofCase.MapData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MapData);
			}
			if (this.dataCase_ == ClientStorageInfo.DataOneofCase.ListData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ListData);
			}
			if (this.dataCase_ == ClientStorageInfo.DataOneofCase.SetData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SetData);
			}
			if (this.dataCase_ == ClientStorageInfo.DataOneofCase.BoolData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BoolData);
			}
			if (this.dataCase_ == ClientStorageInfo.DataOneofCase.IntData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.IntData);
			}
			if (this.dataCase_ == ClientStorageInfo.DataOneofCase.LongData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LongData);
			}
			if (this.dataCase_ == ClientStorageInfo.DataOneofCase.StringData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StringData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060046E4 RID: 18148 RVA: 0x000AE8E0 File Offset: 0x000ACAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClientStorageInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SystemId != 0)
			{
				this.SystemId = other.SystemId;
			}
			switch (other.DataCase)
			{
			case ClientStorageInfo.DataOneofCase.MapMapData:
				if (this.MapMapData == null)
				{
					this.MapMapData = new ClientStorageMapMapData();
				}
				this.MapMapData.MergeFrom(other.MapMapData);
				break;
			case ClientStorageInfo.DataOneofCase.MapListData:
				if (this.MapListData == null)
				{
					this.MapListData = new ClientStorageMapListData();
				}
				this.MapListData.MergeFrom(other.MapListData);
				break;
			case ClientStorageInfo.DataOneofCase.MapData:
				if (this.MapData == null)
				{
					this.MapData = new ClientStorageMapData();
				}
				this.MapData.MergeFrom(other.MapData);
				break;
			case ClientStorageInfo.DataOneofCase.ListData:
				if (this.ListData == null)
				{
					this.ListData = new ClientStorageListData();
				}
				this.ListData.MergeFrom(other.ListData);
				break;
			case ClientStorageInfo.DataOneofCase.SetData:
				if (this.SetData == null)
				{
					this.SetData = new ClientStorageSetData();
				}
				this.SetData.MergeFrom(other.SetData);
				break;
			case ClientStorageInfo.DataOneofCase.BoolData:
				if (this.BoolData == null)
				{
					this.BoolData = new ClientStorageBoolData();
				}
				this.BoolData.MergeFrom(other.BoolData);
				break;
			case ClientStorageInfo.DataOneofCase.IntData:
				if (this.IntData == null)
				{
					this.IntData = new ClientStorageIntData();
				}
				this.IntData.MergeFrom(other.IntData);
				break;
			case ClientStorageInfo.DataOneofCase.LongData:
				if (this.LongData == null)
				{
					this.LongData = new ClientStorageLongData();
				}
				this.LongData.MergeFrom(other.LongData);
				break;
			case ClientStorageInfo.DataOneofCase.StringData:
				if (this.StringData == null)
				{
					this.StringData = new ClientStorageStringData();
				}
				this.StringData.MergeFrom(other.StringData);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060046E5 RID: 18149 RVA: 0x000AEAB7 File Offset: 0x000ACCB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060046E6 RID: 18150 RVA: 0x000AEAC0 File Offset: 0x000ACCC0
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
				if (num <= 50U)
				{
					if (num <= 26U)
					{
						if (num == 8U)
						{
							this.SystemId = input.ReadInt32();
							continue;
						}
						if (num == 26U)
						{
							ClientStorageMapMapData clientStorageMapMapData = new ClientStorageMapMapData();
							if (this.dataCase_ == ClientStorageInfo.DataOneofCase.MapMapData)
							{
								clientStorageMapMapData.MergeFrom(this.MapMapData);
							}
							input.ReadMessage(clientStorageMapMapData);
							this.MapMapData = clientStorageMapMapData;
							continue;
						}
					}
					else
					{
						if (num == 34U)
						{
							ClientStorageMapListData clientStorageMapListData = new ClientStorageMapListData();
							if (this.dataCase_ == ClientStorageInfo.DataOneofCase.MapListData)
							{
								clientStorageMapListData.MergeFrom(this.MapListData);
							}
							input.ReadMessage(clientStorageMapListData);
							this.MapListData = clientStorageMapListData;
							continue;
						}
						if (num == 42U)
						{
							ClientStorageMapData clientStorageMapData = new ClientStorageMapData();
							if (this.dataCase_ == ClientStorageInfo.DataOneofCase.MapData)
							{
								clientStorageMapData.MergeFrom(this.MapData);
							}
							input.ReadMessage(clientStorageMapData);
							this.MapData = clientStorageMapData;
							continue;
						}
						if (num == 50U)
						{
							ClientStorageListData clientStorageListData = new ClientStorageListData();
							if (this.dataCase_ == ClientStorageInfo.DataOneofCase.ListData)
							{
								clientStorageListData.MergeFrom(this.ListData);
							}
							input.ReadMessage(clientStorageListData);
							this.ListData = clientStorageListData;
							continue;
						}
					}
				}
				else if (num <= 66U)
				{
					if (num == 58U)
					{
						ClientStorageSetData clientStorageSetData = new ClientStorageSetData();
						if (this.dataCase_ == ClientStorageInfo.DataOneofCase.SetData)
						{
							clientStorageSetData.MergeFrom(this.SetData);
						}
						input.ReadMessage(clientStorageSetData);
						this.SetData = clientStorageSetData;
						continue;
					}
					if (num == 66U)
					{
						ClientStorageBoolData clientStorageBoolData = new ClientStorageBoolData();
						if (this.dataCase_ == ClientStorageInfo.DataOneofCase.BoolData)
						{
							clientStorageBoolData.MergeFrom(this.BoolData);
						}
						input.ReadMessage(clientStorageBoolData);
						this.BoolData = clientStorageBoolData;
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						ClientStorageIntData clientStorageIntData = new ClientStorageIntData();
						if (this.dataCase_ == ClientStorageInfo.DataOneofCase.IntData)
						{
							clientStorageIntData.MergeFrom(this.IntData);
						}
						input.ReadMessage(clientStorageIntData);
						this.IntData = clientStorageIntData;
						continue;
					}
					if (num == 82U)
					{
						ClientStorageLongData clientStorageLongData = new ClientStorageLongData();
						if (this.dataCase_ == ClientStorageInfo.DataOneofCase.LongData)
						{
							clientStorageLongData.MergeFrom(this.LongData);
						}
						input.ReadMessage(clientStorageLongData);
						this.LongData = clientStorageLongData;
						continue;
					}
					if (num == 90U)
					{
						ClientStorageStringData clientStorageStringData = new ClientStorageStringData();
						if (this.dataCase_ == ClientStorageInfo.DataOneofCase.StringData)
						{
							clientStorageStringData.MergeFrom(this.StringData);
						}
						input.ReadMessage(clientStorageStringData);
						this.StringData = clientStorageStringData;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002FC6 RID: 12230
		private static readonly MessageParser<ClientStorageInfo> _parser = new MessageParser<ClientStorageInfo>(() => new ClientStorageInfo());

		// Token: 0x04002FC7 RID: 12231
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FC8 RID: 12232
		public const int SystemIdFieldNumber = 1;

		// Token: 0x04002FC9 RID: 12233
		private int systemId_;

		// Token: 0x04002FCA RID: 12234
		public const int MapMapDataFieldNumber = 3;

		// Token: 0x04002FCB RID: 12235
		public const int MapListDataFieldNumber = 4;

		// Token: 0x04002FCC RID: 12236
		public const int MapDataFieldNumber = 5;

		// Token: 0x04002FCD RID: 12237
		public const int ListDataFieldNumber = 6;

		// Token: 0x04002FCE RID: 12238
		public const int SetDataFieldNumber = 7;

		// Token: 0x04002FCF RID: 12239
		public const int BoolDataFieldNumber = 8;

		// Token: 0x04002FD0 RID: 12240
		public const int IntDataFieldNumber = 9;

		// Token: 0x04002FD1 RID: 12241
		public const int LongDataFieldNumber = 10;

		// Token: 0x04002FD2 RID: 12242
		public const int StringDataFieldNumber = 11;

		// Token: 0x04002FD3 RID: 12243
		private object data_;

		// Token: 0x04002FD4 RID: 12244
		private ClientStorageInfo.DataOneofCase dataCase_;

		// Token: 0x02001797 RID: 6039
		public enum DataOneofCase
		{
			// Token: 0x0400CAA9 RID: 51881
			None,
			// Token: 0x0400CAAA RID: 51882
			MapMapData = 3,
			// Token: 0x0400CAAB RID: 51883
			MapListData,
			// Token: 0x0400CAAC RID: 51884
			MapData,
			// Token: 0x0400CAAD RID: 51885
			ListData,
			// Token: 0x0400CAAE RID: 51886
			SetData,
			// Token: 0x0400CAAF RID: 51887
			BoolData,
			// Token: 0x0400CAB0 RID: 51888
			IntData,
			// Token: 0x0400CAB1 RID: 51889
			LongData,
			// Token: 0x0400CAB2 RID: 51890
			StringData
		}
	}
}
