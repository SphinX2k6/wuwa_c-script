using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013F1 RID: 5105
	public sealed class TrackMoonUpdateInfo : IMessage<TrackMoonUpdateInfo>, IMessage, IEquatable<TrackMoonUpdateInfo>, IDeepCloneable<TrackMoonUpdateInfo>, IBufferMessage
	{
		// Token: 0x0601B0D5 RID: 110805 RVA: 0x003EAC4D File Offset: 0x003E8E4D
		[NullableContext(1)]
		public static TrackMoonUpdateInfo Create()
		{
			return new TrackMoonUpdateInfo();
		}

		// Token: 0x17005B29 RID: 23337
		// (get) Token: 0x0601B0D6 RID: 110806 RVA: 0x003EAC54 File Offset: 0x003E8E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B2A RID: 23338
		// (get) Token: 0x0601B0D7 RID: 110807 RVA: 0x003EAC57 File Offset: 0x003E8E57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonUpdateInfo.Descriptor;
			}
		}

		// Token: 0x0601B0D8 RID: 110808 RVA: 0x003EAC5E File Offset: 0x003E8E5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonUpdateInfo()
		{
		}

		// Token: 0x0601B0D9 RID: 110809 RVA: 0x003EAC68 File Offset: 0x003E8E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonUpdateInfo(TrackMoonUpdateInfo other) : this()
		{
			switch (other.DataCase)
			{
			case TrackMoonUpdateInfo.DataOneofCase.EntrustInfo:
				this.EntrustInfo = other.EntrustInfo.Clone();
				break;
			case TrackMoonUpdateInfo.DataOneofCase.EntrustRoleInfo:
				this.EntrustRoleInfo = other.EntrustRoleInfo.Clone();
				break;
			case TrackMoonUpdateInfo.DataOneofCase.BuildingInfo:
				this.BuildingInfo = other.BuildingInfo.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B0DA RID: 110810 RVA: 0x003EACE0 File Offset: 0x003E8EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonUpdateInfo Clone()
		{
			return new TrackMoonUpdateInfo(this);
		}

		// Token: 0x17005B2B RID: 23339
		// (get) Token: 0x0601B0DB RID: 110811 RVA: 0x003EACE8 File Offset: 0x003E8EE8
		// (set) Token: 0x0601B0DC RID: 110812 RVA: 0x003EAD00 File Offset: 0x003E8F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntrustInfo EntrustInfo
		{
			get
			{
				if (this.dataCase_ != TrackMoonUpdateInfo.DataOneofCase.EntrustInfo)
				{
					return null;
				}
				return (EntrustInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? TrackMoonUpdateInfo.DataOneofCase.None : TrackMoonUpdateInfo.DataOneofCase.EntrustInfo);
			}
		}

		// Token: 0x17005B2C RID: 23340
		// (get) Token: 0x0601B0DD RID: 110813 RVA: 0x003EAD16 File Offset: 0x003E8F16
		// (set) Token: 0x0601B0DE RID: 110814 RVA: 0x003EAD2E File Offset: 0x003E8F2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntrustRoleInfo EntrustRoleInfo
		{
			get
			{
				if (this.dataCase_ != TrackMoonUpdateInfo.DataOneofCase.EntrustRoleInfo)
				{
					return null;
				}
				return (EntrustRoleInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? TrackMoonUpdateInfo.DataOneofCase.None : TrackMoonUpdateInfo.DataOneofCase.EntrustRoleInfo);
			}
		}

		// Token: 0x17005B2D RID: 23341
		// (get) Token: 0x0601B0DF RID: 110815 RVA: 0x003EAD44 File Offset: 0x003E8F44
		// (set) Token: 0x0601B0E0 RID: 110816 RVA: 0x003EAD5C File Offset: 0x003E8F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuildingInfo BuildingInfo
		{
			get
			{
				if (this.dataCase_ != TrackMoonUpdateInfo.DataOneofCase.BuildingInfo)
				{
					return null;
				}
				return (BuildingInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? TrackMoonUpdateInfo.DataOneofCase.None : TrackMoonUpdateInfo.DataOneofCase.BuildingInfo);
			}
		}

		// Token: 0x17005B2E RID: 23342
		// (get) Token: 0x0601B0E1 RID: 110817 RVA: 0x003EAD72 File Offset: 0x003E8F72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonUpdateInfo.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x0601B0E2 RID: 110818 RVA: 0x003EAD7A File Offset: 0x003E8F7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = TrackMoonUpdateInfo.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x0601B0E3 RID: 110819 RVA: 0x003EAD8A File Offset: 0x003E8F8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonUpdateInfo);
		}

		// Token: 0x0601B0E4 RID: 110820 RVA: 0x003EAD98 File Offset: 0x003E8F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonUpdateInfo other)
		{
			return other != null && (other == this || (object.Equals(this.EntrustInfo, other.EntrustInfo) && object.Equals(this.EntrustRoleInfo, other.EntrustRoleInfo) && object.Equals(this.BuildingInfo, other.BuildingInfo) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B0E5 RID: 110821 RVA: 0x003EAE10 File Offset: 0x003E9010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.dataCase_ == TrackMoonUpdateInfo.DataOneofCase.EntrustInfo)
			{
				num ^= this.EntrustInfo.GetHashCode();
			}
			if (this.dataCase_ == TrackMoonUpdateInfo.DataOneofCase.EntrustRoleInfo)
			{
				num ^= this.EntrustRoleInfo.GetHashCode();
			}
			if (this.dataCase_ == TrackMoonUpdateInfo.DataOneofCase.BuildingInfo)
			{
				num ^= this.BuildingInfo.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B0E6 RID: 110822 RVA: 0x003EAE84 File Offset: 0x003E9084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B0E7 RID: 110823 RVA: 0x003EAE91 File Offset: 0x003E9091
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B0E8 RID: 110824 RVA: 0x003EAE9C File Offset: 0x003E909C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.dataCase_ == TrackMoonUpdateInfo.DataOneofCase.EntrustInfo)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntrustInfo);
			}
			if (this.dataCase_ == TrackMoonUpdateInfo.DataOneofCase.EntrustRoleInfo)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.EntrustRoleInfo);
			}
			if (this.dataCase_ == TrackMoonUpdateInfo.DataOneofCase.BuildingInfo)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.BuildingInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B0E9 RID: 110825 RVA: 0x003EAF14 File Offset: 0x003E9114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.dataCase_ == TrackMoonUpdateInfo.DataOneofCase.EntrustInfo)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntrustInfo);
			}
			if (this.dataCase_ == TrackMoonUpdateInfo.DataOneofCase.EntrustRoleInfo)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntrustRoleInfo);
			}
			if (this.dataCase_ == TrackMoonUpdateInfo.DataOneofCase.BuildingInfo)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BuildingInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B0EA RID: 110826 RVA: 0x003EAF88 File Offset: 0x003E9188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrackMoonUpdateInfo other)
		{
			if (other == null)
			{
				return;
			}
			switch (other.DataCase)
			{
			case TrackMoonUpdateInfo.DataOneofCase.EntrustInfo:
				if (this.EntrustInfo == null)
				{
					this.EntrustInfo = new EntrustInfo();
				}
				this.EntrustInfo.MergeFrom(other.EntrustInfo);
				break;
			case TrackMoonUpdateInfo.DataOneofCase.EntrustRoleInfo:
				if (this.EntrustRoleInfo == null)
				{
					this.EntrustRoleInfo = new EntrustRoleInfo();
				}
				this.EntrustRoleInfo.MergeFrom(other.EntrustRoleInfo);
				break;
			case TrackMoonUpdateInfo.DataOneofCase.BuildingInfo:
				if (this.BuildingInfo == null)
				{
					this.BuildingInfo = new BuildingInfo();
				}
				this.BuildingInfo.MergeFrom(other.BuildingInfo);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B0EB RID: 110827 RVA: 0x003EB03D File Offset: 0x003E923D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B0EC RID: 110828 RVA: 0x003EB048 File Offset: 0x003E9248
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
					if (num != 18U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							BuildingInfo buildingInfo = new BuildingInfo();
							if (this.dataCase_ == TrackMoonUpdateInfo.DataOneofCase.BuildingInfo)
							{
								buildingInfo.MergeFrom(this.BuildingInfo);
							}
							input.ReadMessage(buildingInfo);
							this.BuildingInfo = buildingInfo;
						}
					}
					else
					{
						EntrustRoleInfo entrustRoleInfo = new EntrustRoleInfo();
						if (this.dataCase_ == TrackMoonUpdateInfo.DataOneofCase.EntrustRoleInfo)
						{
							entrustRoleInfo.MergeFrom(this.EntrustRoleInfo);
						}
						input.ReadMessage(entrustRoleInfo);
						this.EntrustRoleInfo = entrustRoleInfo;
					}
				}
				else
				{
					EntrustInfo entrustInfo = new EntrustInfo();
					if (this.dataCase_ == TrackMoonUpdateInfo.DataOneofCase.EntrustInfo)
					{
						entrustInfo.MergeFrom(this.EntrustInfo);
					}
					input.ReadMessage(entrustInfo);
					this.EntrustInfo = entrustInfo;
				}
			}
		}

		// Token: 0x04009C8B RID: 40075
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C8C RID: 40076
		public const int EntrustInfoFieldNumber = 1;

		// Token: 0x04009C8D RID: 40077
		public const int EntrustRoleInfoFieldNumber = 2;

		// Token: 0x04009C8E RID: 40078
		public const int BuildingInfoFieldNumber = 3;

		// Token: 0x04009C8F RID: 40079
		private object data_;

		// Token: 0x04009C90 RID: 40080
		private TrackMoonUpdateInfo.DataOneofCase dataCase_;

		// Token: 0x020019D0 RID: 6608
		public enum DataOneofCase
		{
			// Token: 0x0400CA87 RID: 51847
			None,
			// Token: 0x0400CA88 RID: 51848
			EntrustInfo,
			// Token: 0x0400CA89 RID: 51849
			EntrustRoleInfo,
			// Token: 0x0400CA8A RID: 51850
			BuildingInfo
		}
	}
}
