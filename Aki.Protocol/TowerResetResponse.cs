using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013C7 RID: 5063
	[NetMessage(EMessageId.TowerResetResponse)]
	public sealed class TowerResetResponse : IMessage<TowerResetResponse>, IMessage, IEquatable<TowerResetResponse>, IDeepCloneable<TowerResetResponse>, IBufferMessage
	{
		// Token: 0x0601ADAD RID: 109997 RVA: 0x003E4A39 File Offset: 0x003E2C39
		[NullableContext(1)]
		public static TowerResetResponse Create()
		{
			return new TowerResetResponse();
		}

		// Token: 0x17005A91 RID: 23185
		// (get) Token: 0x0601ADAE RID: 109998 RVA: 0x003E4A40 File Offset: 0x003E2C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A92 RID: 23186
		// (get) Token: 0x0601ADAF RID: 109999 RVA: 0x003E4A43 File Offset: 0x003E2C43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerResetResponse.Descriptor;
			}
		}

		// Token: 0x0601ADB0 RID: 110000 RVA: 0x003E4A4A File Offset: 0x003E2C4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerResetResponse()
		{
		}

		// Token: 0x0601ADB1 RID: 110001 RVA: 0x003E4A52 File Offset: 0x003E2C52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerResetResponse(TowerResetResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.towerConfigId_ = other.towerConfigId_;
			this.needUpdateSeason_ = other.needUpdateSeason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601ADB2 RID: 110002 RVA: 0x003E4A8F File Offset: 0x003E2C8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerResetResponse Clone()
		{
			return new TowerResetResponse(this);
		}

		// Token: 0x17005A93 RID: 23187
		// (get) Token: 0x0601ADB3 RID: 110003 RVA: 0x003E4A97 File Offset: 0x003E2C97
		// (set) Token: 0x0601ADB4 RID: 110004 RVA: 0x003E4A9F File Offset: 0x003E2C9F
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

		// Token: 0x17005A94 RID: 23188
		// (get) Token: 0x0601ADB5 RID: 110005 RVA: 0x003E4AA8 File Offset: 0x003E2CA8
		// (set) Token: 0x0601ADB6 RID: 110006 RVA: 0x003E4AB0 File Offset: 0x003E2CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TowerConfigId
		{
			get
			{
				return this.towerConfigId_;
			}
			set
			{
				this.towerConfigId_ = value;
			}
		}

		// Token: 0x17005A95 RID: 23189
		// (get) Token: 0x0601ADB7 RID: 110007 RVA: 0x003E4AB9 File Offset: 0x003E2CB9
		// (set) Token: 0x0601ADB8 RID: 110008 RVA: 0x003E4AC1 File Offset: 0x003E2CC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NeedUpdateSeason
		{
			get
			{
				return this.needUpdateSeason_;
			}
			set
			{
				this.needUpdateSeason_ = value;
			}
		}

		// Token: 0x0601ADB9 RID: 110009 RVA: 0x003E4ACA File Offset: 0x003E2CCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerResetResponse);
		}

		// Token: 0x0601ADBA RID: 110010 RVA: 0x003E4AD8 File Offset: 0x003E2CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerResetResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.TowerConfigId == other.TowerConfigId && this.NeedUpdateSeason == other.NeedUpdateSeason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601ADBB RID: 110011 RVA: 0x003E4B34 File Offset: 0x003E2D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.TowerConfigId != 0)
			{
				num ^= this.TowerConfigId.GetHashCode();
			}
			if (this.NeedUpdateSeason)
			{
				num ^= this.NeedUpdateSeason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601ADBC RID: 110012 RVA: 0x003E4BAB File Offset: 0x003E2DAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601ADBD RID: 110013 RVA: 0x003E4BB8 File Offset: 0x003E2DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601ADBE RID: 110014 RVA: 0x003E4BC4 File Offset: 0x003E2DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NeedUpdateSeason)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.NeedUpdateSeason);
			}
			if (this.TowerConfigId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.TowerConfigId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601ADBF RID: 110015 RVA: 0x003E4C3C File Offset: 0x003E2E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.TowerConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TowerConfigId);
			}
			if (this.NeedUpdateSeason)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601ADC0 RID: 110016 RVA: 0x003E4CA0 File Offset: 0x003E2EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerResetResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.TowerConfigId != 0)
			{
				this.TowerConfigId = other.TowerConfigId;
			}
			if (other.NeedUpdateSeason)
			{
				this.NeedUpdateSeason = other.NeedUpdateSeason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601ADC1 RID: 110017 RVA: 0x003E4D04 File Offset: 0x003E2F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601ADC2 RID: 110018 RVA: 0x003E4D10 File Offset: 0x003E2F10
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
				if (num != 24U)
				{
					if (num != 64U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ErrorCode = (ErrorCode)input.ReadEnum();
						}
					}
					else
					{
						this.TowerConfigId = input.ReadInt32();
					}
				}
				else
				{
					this.NeedUpdateSeason = input.ReadBool();
				}
			}
		}

		// Token: 0x04009BD0 RID: 39888
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009BD1 RID: 39889
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04009BD2 RID: 39890
		private ErrorCode errorCode_;

		// Token: 0x04009BD3 RID: 39891
		public const int TowerConfigIdFieldNumber = 8;

		// Token: 0x04009BD4 RID: 39892
		private int towerConfigId_;

		// Token: 0x04009BD5 RID: 39893
		public const int NeedUpdateSeasonFieldNumber = 3;

		// Token: 0x04009BD6 RID: 39894
		private bool needUpdateSeason_;
	}
}
