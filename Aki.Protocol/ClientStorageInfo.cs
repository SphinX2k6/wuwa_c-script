using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002A1 RID: 673
	public sealed class ClientStorageInfo : IMessage<ClientStorageInfo>, IMessage, IEquatable<ClientStorageInfo>, IDeepCloneable<ClientStorageInfo>, IBufferMessage
	{
		// Token: 0x060045F9 RID: 17913 RVA: 0x000ABF14 File Offset: 0x000AA114
		[NullableContext(1)]
		public static ClientStorageInfo Create()
		{
			return new ClientStorageInfo();
		}

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x060045FA RID: 17914 RVA: 0x000ABF1B File Offset: 0x000AA11B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ClientStorageInfo> Parser
		{
			get
			{
				return ClientStorageInfo._parser;
			}
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x060045FB RID: 17915 RVA: 0x000ABF22 File Offset: 0x000AA122
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x060045FC RID: 17916 RVA: 0x000ABF25 File Offset: 0x000AA125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientStorageInfo.Descriptor;
			}
		}

		// Token: 0x060045FD RID: 17917 RVA: 0x000ABF2C File Offset: 0x000AA12C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageInfo()
		{
		}

		// Token: 0x060045FE RID: 17918 RVA: 0x000ABF34 File Offset: 0x000AA134
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

		// Token: 0x060045FF RID: 17919 RVA: 0x000AC04B File Offset: 0x000AA24B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageInfo Clone()
		{
			return new ClientStorageInfo(this);
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x06004600 RID: 17920 RVA: 0x000AC053 File Offset: 0x000AA253
		// (set) Token: 0x06004601 RID: 17921 RVA: 0x000AC05B File Offset: 0x000AA25B
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

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x06004602 RID: 17922 RVA: 0x000AC064 File Offset: 0x000AA264
		// (set) Token: 0x06004603 RID: 17923 RVA: 0x000AC07C File Offset: 0x000AA27C
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

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x06004604 RID: 17924 RVA: 0x000AC092 File Offset: 0x000AA292
		// (set) Token: 0x06004605 RID: 17925 RVA: 0x000AC0AA File Offset: 0x000AA2AA
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

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x06004606 RID: 17926 RVA: 0x000AC0C0 File Offset: 0x000AA2C0
		// (set) Token: 0x06004607 RID: 17927 RVA: 0x000AC0D8 File Offset: 0x000AA2D8
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

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x06004608 RID: 17928 RVA: 0x000AC0EE File Offset: 0x000AA2EE
		// (set) Token: 0x06004609 RID: 17929 RVA: 0x000AC106 File Offset: 0x000AA306
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

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x0600460A RID: 17930 RVA: 0x000AC11C File Offset: 0x000AA31C
		// (set) Token: 0x0600460B RID: 17931 RVA: 0x000AC134 File Offset: 0x000AA334
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

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x0600460C RID: 17932 RVA: 0x000AC14A File Offset: 0x000AA34A
		// (set) Token: 0x0600460D RID: 17933 RVA: 0x000AC162 File Offset: 0x000AA362
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

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x0600460E RID: 17934 RVA: 0x000AC178 File Offset: 0x000AA378
		// (set) Token: 0x0600460F RID: 17935 RVA: 0x000AC191 File Offset: 0x000AA391
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

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x06004610 RID: 17936 RVA: 0x000AC1A8 File Offset: 0x000AA3A8
		// (set) Token: 0x06004611 RID: 17937 RVA: 0x000AC1C1 File Offset: 0x000AA3C1
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

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x06004612 RID: 17938 RVA: 0x000AC1D8 File Offset: 0x000AA3D8
		// (set) Token: 0x06004613 RID: 17939 RVA: 0x000AC1F1 File Offset: 0x000AA3F1
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

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x06004614 RID: 17940 RVA: 0x000AC208 File Offset: 0x000AA408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageInfo.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06004615 RID: 17941 RVA: 0x000AC210 File Offset: 0x000AA410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = ClientStorageInfo.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06004616 RID: 17942 RVA: 0x000AC220 File Offset: 0x000AA420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientStorageInfo);
		}

		// Token: 0x06004617 RID: 17943 RVA: 0x000AC230 File Offset: 0x000AA430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientStorageInfo other)
		{
			return other != null && (other == this || (this.SystemId == other.SystemId && object.Equals(this.MapMapData, other.MapMapData) && object.Equals(this.MapListData, other.MapListData) && object.Equals(this.MapData, other.MapData) && object.Equals(this.ListData, other.ListData) && object.Equals(this.SetData, other.SetData) && object.Equals(this.BoolData, other.BoolData) && object.Equals(this.IntData, other.IntData) && object.Equals(this.LongData, other.LongData) && object.Equals(this.StringData, other.StringData) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004618 RID: 17944 RVA: 0x000AC338 File Offset: 0x000AA538
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

		// Token: 0x06004619 RID: 17945 RVA: 0x000AC452 File Offset: 0x000AA652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600461A RID: 17946 RVA: 0x000AC45F File Offset: 0x000AA65F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600461B RID: 17947 RVA: 0x000AC468 File Offset: 0x000AA668
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

		// Token: 0x0600461C RID: 17948 RVA: 0x000AC5AC File Offset: 0x000AA7AC
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

		// Token: 0x0600461D RID: 17949 RVA: 0x000AC6D0 File Offset: 0x000AA8D0
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

		// Token: 0x0600461E RID: 17950 RVA: 0x000AC8A7 File Offset: 0x000AAAA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600461F RID: 17951 RVA: 0x000AC8B0 File Offset: 0x000AAAB0
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

		// Token: 0x04002F33 RID: 12083
		private static readonly MessageParser<ClientStorageInfo> _parser = new MessageParser<ClientStorageInfo>(() => new ClientStorageInfo());

		// Token: 0x04002F34 RID: 12084
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F35 RID: 12085
		public const int SystemIdFieldNumber = 1;

		// Token: 0x04002F36 RID: 12086
		private int systemId_;

		// Token: 0x04002F37 RID: 12087
		public const int MapMapDataFieldNumber = 3;

		// Token: 0x04002F38 RID: 12088
		public const int MapListDataFieldNumber = 4;

		// Token: 0x04002F39 RID: 12089
		public const int MapDataFieldNumber = 5;

		// Token: 0x04002F3A RID: 12090
		public const int ListDataFieldNumber = 6;

		// Token: 0x04002F3B RID: 12091
		public const int SetDataFieldNumber = 7;

		// Token: 0x04002F3C RID: 12092
		public const int BoolDataFieldNumber = 8;

		// Token: 0x04002F3D RID: 12093
		public const int IntDataFieldNumber = 9;

		// Token: 0x04002F3E RID: 12094
		public const int LongDataFieldNumber = 10;

		// Token: 0x04002F3F RID: 12095
		public const int StringDataFieldNumber = 11;

		// Token: 0x04002F40 RID: 12096
		private object data_;

		// Token: 0x04002F41 RID: 12097
		private ClientStorageInfo.DataOneofCase dataCase_;

		// Token: 0x02001719 RID: 5913
		public enum DataOneofCase
		{
			// Token: 0x0400C573 RID: 50547
			None,
			// Token: 0x0400C574 RID: 50548
			MapMapData = 3,
			// Token: 0x0400C575 RID: 50549
			MapListData,
			// Token: 0x0400C576 RID: 50550
			MapData,
			// Token: 0x0400C577 RID: 50551
			ListData,
			// Token: 0x0400C578 RID: 50552
			SetData,
			// Token: 0x0400C579 RID: 50553
			BoolData,
			// Token: 0x0400C57A RID: 50554
			IntData,
			// Token: 0x0400C57B RID: 50555
			LongData,
			// Token: 0x0400C57C RID: 50556
			StringData
		}
	}
}
