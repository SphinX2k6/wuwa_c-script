using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013E1 RID: 5089
	[NetMessage(EMessageId.TrackMoonConditionNotify)]
	public sealed class TrackMoonConditionNotify : IMessage<TrackMoonConditionNotify>, IMessage, IEquatable<TrackMoonConditionNotify>, IDeepCloneable<TrackMoonConditionNotify>, IBufferMessage
	{
		// Token: 0x0601AFA3 RID: 110499 RVA: 0x003E8779 File Offset: 0x003E6979
		[NullableContext(1)]
		public static TrackMoonConditionNotify Create()
		{
			return new TrackMoonConditionNotify();
		}

		// Token: 0x17005AF0 RID: 23280
		// (get) Token: 0x0601AFA4 RID: 110500 RVA: 0x003E8780 File Offset: 0x003E6980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005AF1 RID: 23281
		// (get) Token: 0x0601AFA5 RID: 110501 RVA: 0x003E8783 File Offset: 0x003E6983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonConditionNotify.Descriptor;
			}
		}

		// Token: 0x0601AFA6 RID: 110502 RVA: 0x003E878A File Offset: 0x003E698A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonConditionNotify()
		{
		}

		// Token: 0x0601AFA7 RID: 110503 RVA: 0x003E8794 File Offset: 0x003E6994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonConditionNotify(TrackMoonConditionNotify other) : this()
		{
			this.trackMoonConditionType_ = other.trackMoonConditionType_;
			this.trackMoonUpdateInfo_ = ((other.trackMoonUpdateInfo_ != null) ? other.trackMoonUpdateInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AFA8 RID: 110504 RVA: 0x003E87E0 File Offset: 0x003E69E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonConditionNotify Clone()
		{
			return new TrackMoonConditionNotify(this);
		}

		// Token: 0x17005AF2 RID: 23282
		// (get) Token: 0x0601AFA9 RID: 110505 RVA: 0x003E87E8 File Offset: 0x003E69E8
		// (set) Token: 0x0601AFAA RID: 110506 RVA: 0x003E87F0 File Offset: 0x003E69F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonConditionType TrackMoonConditionType
		{
			get
			{
				return this.trackMoonConditionType_;
			}
			set
			{
				this.trackMoonConditionType_ = value;
			}
		}

		// Token: 0x17005AF3 RID: 23283
		// (get) Token: 0x0601AFAB RID: 110507 RVA: 0x003E87F9 File Offset: 0x003E69F9
		// (set) Token: 0x0601AFAC RID: 110508 RVA: 0x003E8801 File Offset: 0x003E6A01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonUpdateInfo TrackMoonUpdateInfo
		{
			get
			{
				return this.trackMoonUpdateInfo_;
			}
			set
			{
				this.trackMoonUpdateInfo_ = value;
			}
		}

		// Token: 0x0601AFAD RID: 110509 RVA: 0x003E880A File Offset: 0x003E6A0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonConditionNotify);
		}

		// Token: 0x0601AFAE RID: 110510 RVA: 0x003E8818 File Offset: 0x003E6A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonConditionNotify other)
		{
			return other != null && (other == this || (this.TrackMoonConditionType == other.TrackMoonConditionType && object.Equals(this.TrackMoonUpdateInfo, other.TrackMoonUpdateInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AFAF RID: 110511 RVA: 0x003E8868 File Offset: 0x003E6A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TrackMoonConditionType != TrackMoonConditionType.TrackMoonEntrust)
			{
				num ^= this.TrackMoonConditionType.GetHashCode();
			}
			if (this.trackMoonUpdateInfo_ != null)
			{
				num ^= this.TrackMoonUpdateInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AFB0 RID: 110512 RVA: 0x003E88C3 File Offset: 0x003E6AC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AFB1 RID: 110513 RVA: 0x003E88D0 File Offset: 0x003E6AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AFB2 RID: 110514 RVA: 0x003E88DC File Offset: 0x003E6ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TrackMoonConditionType != TrackMoonConditionType.TrackMoonEntrust)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.TrackMoonConditionType);
			}
			if (this.trackMoonUpdateInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.TrackMoonUpdateInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AFB3 RID: 110515 RVA: 0x003E8938 File Offset: 0x003E6B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TrackMoonConditionType != TrackMoonConditionType.TrackMoonEntrust)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.TrackMoonConditionType);
			}
			if (this.trackMoonUpdateInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TrackMoonUpdateInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AFB4 RID: 110516 RVA: 0x003E8990 File Offset: 0x003E6B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrackMoonConditionNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TrackMoonConditionType != TrackMoonConditionType.TrackMoonEntrust)
			{
				this.TrackMoonConditionType = other.TrackMoonConditionType;
			}
			if (other.trackMoonUpdateInfo_ != null)
			{
				if (this.trackMoonUpdateInfo_ == null)
				{
					this.TrackMoonUpdateInfo = new TrackMoonUpdateInfo();
				}
				this.TrackMoonUpdateInfo.MergeFrom(other.TrackMoonUpdateInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AFB5 RID: 110517 RVA: 0x003E89F8 File Offset: 0x003E6BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AFB6 RID: 110518 RVA: 0x003E8A04 File Offset: 0x003E6C04
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
				if (num != 16U)
				{
					if (num != 26U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.trackMoonUpdateInfo_ == null)
						{
							this.TrackMoonUpdateInfo = new TrackMoonUpdateInfo();
						}
						input.ReadMessage(this.TrackMoonUpdateInfo);
					}
				}
				else
				{
					this.TrackMoonConditionType = (TrackMoonConditionType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009C43 RID: 40003
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C44 RID: 40004
		public const int TrackMoonConditionTypeFieldNumber = 2;

		// Token: 0x04009C45 RID: 40005
		private TrackMoonConditionType trackMoonConditionType_;

		// Token: 0x04009C46 RID: 40006
		public const int TrackMoonUpdateInfoFieldNumber = 3;

		// Token: 0x04009C47 RID: 40007
		private TrackMoonUpdateInfo trackMoonUpdateInfo_;
	}
}
