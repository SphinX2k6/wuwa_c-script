using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001454 RID: 5204
	[NetMessage(EMessageId.TrackMoonConditionNotify)]
	public sealed class TrackMoonConditionNotify : IMessage<TrackMoonConditionNotify>, IMessage, IEquatable<TrackMoonConditionNotify>, IDeepCloneable<TrackMoonConditionNotify>, IBufferMessage
	{
		// Token: 0x0601BA2E RID: 113198 RVA: 0x00403A45 File Offset: 0x00401C45
		[NullableContext(1)]
		public static TrackMoonConditionNotify Create()
		{
			return new TrackMoonConditionNotify();
		}

		// Token: 0x17005D85 RID: 23941
		// (get) Token: 0x0601BA2F RID: 113199 RVA: 0x00403A4C File Offset: 0x00401C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D86 RID: 23942
		// (get) Token: 0x0601BA30 RID: 113200 RVA: 0x00403A4F File Offset: 0x00401C4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonConditionNotify.Descriptor;
			}
		}

		// Token: 0x0601BA31 RID: 113201 RVA: 0x00403A56 File Offset: 0x00401C56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonConditionNotify()
		{
		}

		// Token: 0x0601BA32 RID: 113202 RVA: 0x00403A60 File Offset: 0x00401C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonConditionNotify(TrackMoonConditionNotify other) : this()
		{
			this.trackMoonConditionType_ = other.trackMoonConditionType_;
			this.trackMoonUpdateInfo_ = ((other.trackMoonUpdateInfo_ != null) ? other.trackMoonUpdateInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BA33 RID: 113203 RVA: 0x00403AAC File Offset: 0x00401CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonConditionNotify Clone()
		{
			return new TrackMoonConditionNotify(this);
		}

		// Token: 0x17005D87 RID: 23943
		// (get) Token: 0x0601BA34 RID: 113204 RVA: 0x00403AB4 File Offset: 0x00401CB4
		// (set) Token: 0x0601BA35 RID: 113205 RVA: 0x00403ABC File Offset: 0x00401CBC
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

		// Token: 0x17005D88 RID: 23944
		// (get) Token: 0x0601BA36 RID: 113206 RVA: 0x00403AC5 File Offset: 0x00401CC5
		// (set) Token: 0x0601BA37 RID: 113207 RVA: 0x00403ACD File Offset: 0x00401CCD
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

		// Token: 0x0601BA38 RID: 113208 RVA: 0x00403AD6 File Offset: 0x00401CD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonConditionNotify);
		}

		// Token: 0x0601BA39 RID: 113209 RVA: 0x00403AE4 File Offset: 0x00401CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonConditionNotify other)
		{
			return other != null && (other == this || (this.TrackMoonConditionType == other.TrackMoonConditionType && object.Equals(this.TrackMoonUpdateInfo, other.TrackMoonUpdateInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BA3A RID: 113210 RVA: 0x00403B34 File Offset: 0x00401D34
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

		// Token: 0x0601BA3B RID: 113211 RVA: 0x00403B8F File Offset: 0x00401D8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BA3C RID: 113212 RVA: 0x00403B9C File Offset: 0x00401D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BA3D RID: 113213 RVA: 0x00403BA8 File Offset: 0x00401DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.trackMoonUpdateInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.TrackMoonUpdateInfo);
			}
			if (this.TrackMoonConditionType != TrackMoonConditionType.TrackMoonEntrust)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.TrackMoonConditionType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BA3E RID: 113214 RVA: 0x00403C04 File Offset: 0x00401E04
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

		// Token: 0x0601BA3F RID: 113215 RVA: 0x00403C5C File Offset: 0x00401E5C
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

		// Token: 0x0601BA40 RID: 113216 RVA: 0x00403CC4 File Offset: 0x00401EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BA41 RID: 113217 RVA: 0x00403CD0 File Offset: 0x00401ED0
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
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TrackMoonConditionType = (TrackMoonConditionType)input.ReadEnum();
					}
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
		}

		// Token: 0x0400A08A RID: 41098
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A08B RID: 41099
		public const int TrackMoonConditionTypeFieldNumber = 4;

		// Token: 0x0400A08C RID: 41100
		private TrackMoonConditionType trackMoonConditionType_;

		// Token: 0x0400A08D RID: 41101
		public const int TrackMoonUpdateInfoFieldNumber = 1;

		// Token: 0x0400A08E RID: 41102
		private TrackMoonUpdateInfo trackMoonUpdateInfo_;
	}
}
