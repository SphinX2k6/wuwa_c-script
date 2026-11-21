using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001464 RID: 5220
	public sealed class TrackMoonUpdateInfo : IMessage<TrackMoonUpdateInfo>, IMessage, IEquatable<TrackMoonUpdateInfo>, IDeepCloneable<TrackMoonUpdateInfo>, IBufferMessage
	{
		// Token: 0x0601BB60 RID: 113504 RVA: 0x00405F21 File Offset: 0x00404121
		[NullableContext(1)]
		public static TrackMoonUpdateInfo Create()
		{
			return new TrackMoonUpdateInfo();
		}

		// Token: 0x17005DBE RID: 23998
		// (get) Token: 0x0601BB61 RID: 113505 RVA: 0x00405F28 File Offset: 0x00404128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DBF RID: 23999
		// (get) Token: 0x0601BB62 RID: 113506 RVA: 0x00405F2B File Offset: 0x0040412B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonUpdateInfo.Descriptor;
			}
		}

		// Token: 0x0601BB63 RID: 113507 RVA: 0x00405F32 File Offset: 0x00404132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonUpdateInfo()
		{
		}

		// Token: 0x0601BB64 RID: 113508 RVA: 0x00405F3C File Offset: 0x0040413C
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

		// Token: 0x0601BB65 RID: 113509 RVA: 0x00405FB4 File Offset: 0x004041B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonUpdateInfo Clone()
		{
			return new TrackMoonUpdateInfo(this);
		}

		// Token: 0x17005DC0 RID: 24000
		// (get) Token: 0x0601BB66 RID: 113510 RVA: 0x00405FBC File Offset: 0x004041BC
		// (set) Token: 0x0601BB67 RID: 113511 RVA: 0x00405FD4 File Offset: 0x004041D4
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

		// Token: 0x17005DC1 RID: 24001
		// (get) Token: 0x0601BB68 RID: 113512 RVA: 0x00405FEA File Offset: 0x004041EA
		// (set) Token: 0x0601BB69 RID: 113513 RVA: 0x00406002 File Offset: 0x00404202
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

		// Token: 0x17005DC2 RID: 24002
		// (get) Token: 0x0601BB6A RID: 113514 RVA: 0x00406018 File Offset: 0x00404218
		// (set) Token: 0x0601BB6B RID: 113515 RVA: 0x00406030 File Offset: 0x00404230
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

		// Token: 0x17005DC3 RID: 24003
		// (get) Token: 0x0601BB6C RID: 113516 RVA: 0x00406046 File Offset: 0x00404246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonUpdateInfo.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x0601BB6D RID: 113517 RVA: 0x0040604E File Offset: 0x0040424E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = TrackMoonUpdateInfo.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x0601BB6E RID: 113518 RVA: 0x0040605E File Offset: 0x0040425E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonUpdateInfo);
		}

		// Token: 0x0601BB6F RID: 113519 RVA: 0x0040606C File Offset: 0x0040426C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonUpdateInfo other)
		{
			return other != null && (other == this || (object.Equals(this.EntrustInfo, other.EntrustInfo) && object.Equals(this.EntrustRoleInfo, other.EntrustRoleInfo) && object.Equals(this.BuildingInfo, other.BuildingInfo) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BB70 RID: 113520 RVA: 0x004060E4 File Offset: 0x004042E4
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

		// Token: 0x0601BB71 RID: 113521 RVA: 0x00406158 File Offset: 0x00404358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BB72 RID: 113522 RVA: 0x00406165 File Offset: 0x00404365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BB73 RID: 113523 RVA: 0x00406170 File Offset: 0x00404370
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

		// Token: 0x0601BB74 RID: 113524 RVA: 0x004061E8 File Offset: 0x004043E8
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

		// Token: 0x0601BB75 RID: 113525 RVA: 0x0040625C File Offset: 0x0040445C
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

		// Token: 0x0601BB76 RID: 113526 RVA: 0x00406311 File Offset: 0x00404511
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BB77 RID: 113527 RVA: 0x0040631C File Offset: 0x0040451C
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

		// Token: 0x0400A0D2 RID: 41170
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A0D3 RID: 41171
		public const int EntrustInfoFieldNumber = 1;

		// Token: 0x0400A0D4 RID: 41172
		public const int EntrustRoleInfoFieldNumber = 2;

		// Token: 0x0400A0D5 RID: 41173
		public const int BuildingInfoFieldNumber = 3;

		// Token: 0x0400A0D6 RID: 41174
		private object data_;

		// Token: 0x0400A0D7 RID: 41175
		private TrackMoonUpdateInfo.DataOneofCase dataCase_;

		// Token: 0x02001A72 RID: 6770
		public enum DataOneofCase
		{
			// Token: 0x0400CFF2 RID: 53234
			None,
			// Token: 0x0400CFF3 RID: 53235
			EntrustInfo,
			// Token: 0x0400CFF4 RID: 53236
			EntrustRoleInfo,
			// Token: 0x0400CFF5 RID: 53237
			BuildingInfo
		}
	}
}
